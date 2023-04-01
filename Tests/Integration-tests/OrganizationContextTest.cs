using System;
using System.Linq;
using System.Threading.Tasks;
using IntegrationTests.Fakes;
using IntegrationTests.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegionOrebroLan.Organization.Data;
using RegionOrebroLan.Organization.Data.DependencyInjection.Extensions;
using RegionOrebroLan.Organization.Data.Entities;
using RegionOrebroLan.Organization.Data.Sqlite;
using RegionOrebroLan.Organization.Data.SqlServer;

namespace IntegrationTests
{
	[TestClass]
	public class OrganizationContextTest
	{
		#region Methods

		[ClassInitialize]
		public static async Task InitializeAsync(TestContext _)
		{
			await DatabaseHelper.DeleteDatabasesAsync();
		}

		[TestMethod]
		public async Task Sqlite_Test()
		{
			var services = new ServiceCollection();
			services.AddSqliteOrganizationContext(builder => builder.UseSqlite(Global.Configuration.GetConnectionString("Sqlite")));
			await this.TestAsync<SqliteOrganizationContext>(services);
		}

		[TestMethod]
		public async Task SqlServer_Test()
		{
			var connectionString = Global.Configuration.GetConnectionString("SqlServer");
			connectionString = await SqlServerConnectionStringResolver.ResolveAsync(connectionString);

			var services = new ServiceCollection();
			services.AddSqlServerOrganizationContext(builder => builder.UseSqlServer(connectionString));

			await this.TestAsync<SqlServerOrganizationContext>(services);
		}

		protected internal virtual async Task TestAsync<T>(IServiceCollection services) where T : OrganizationContext
		{
			if(services == null)
				throw new ArgumentNullException(nameof(services));

			var guidFactory = new FakedGuidFactory();
			var systemClock = new FakedSystemClock();

			services.AddSingleton<IGuidFactory>(guidFactory);
			services.AddSingleton<ISystemClock>(systemClock);

			// ReSharper disable ConvertToUsingDeclaration
			using(var scope = services.BuildServiceProvider().CreateScope())
			{
				var organizationContext = scope.ServiceProvider.GetRequiredService<T>();

				try
				{
					await organizationContext.Database.MigrateAsync();

					systemClock.UtcNow = DateTimeOffset.UtcNow;
					var created = systemClock.UtcNow.UtcDateTime;

					organizationContext.Add(new Entry { DistinguishedName = "Organization-A", HsaIdentity = "Organization-A" });
					Assert.AreEqual(1, await organizationContext.SaveChangesAsync());
					var entry = organizationContext.Entries.First();
					Assert.AreEqual(created, entry.Created);
					Assert.AreEqual(guidFactory.Guids.ElementAt(0), entry.Guid);
					Assert.AreEqual(created, entry.Saved);

					var saved = created.AddHours(2);
					systemClock.UtcNow = saved;

					entry = organizationContext.Entries.First();
					entry.Street += " (some more)";
					Assert.AreEqual(1, await organizationContext.SaveChangesAsync());
					Assert.AreEqual(created, entry.Created);
					Assert.AreEqual(guidFactory.Guids.ElementAt(0), entry.Guid);
					Assert.AreEqual(saved, entry.Saved);
				}
				finally
				{
					await organizationContext.Database.EnsureDeletedAsync();
				}
			}
			// ReSharper restore ConvertToUsingDeclaration
		}

		#endregion
	}
}