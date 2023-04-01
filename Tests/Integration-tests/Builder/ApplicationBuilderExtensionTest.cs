using System.Linq;
using System.Threading.Tasks;
using IntegrationTests.Helpers;
using Microsoft.AspNetCore.Builder.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegionOrebroLan.Organization.Data;
using RegionOrebroLan.Organization.Data.Builder;
using RegionOrebroLan.Organization.Data.DependencyInjection.Extensions;

namespace IntegrationTests.Builder
{
	[TestClass]
	public class ApplicationBuilderExtensionTest
	{
		#region Methods

		[ClassInitialize]
		public static async Task InitializeAsync(TestContext _)
		{
			await DatabaseHelper.DeleteDatabasesAsync();
		}

		protected internal virtual async Task UseOrganizationContext_Sqlite_Test(ServiceLifetime serviceLifetime)
		{
			var services = new ServiceCollection();
			services.AddSqliteOrganizationContext(builder => builder.UseSqlite(Global.Configuration.GetConnectionString("Sqlite")), serviceLifetime, serviceLifetime);

			using(var serviceProvider = services.BuildServiceProvider())
			{
				var applicationBuilder = new ApplicationBuilder(serviceProvider);
				applicationBuilder.UseOrganizationContext();

				using(var scope = applicationBuilder.ApplicationServices.CreateScope())
				{
					var sqliteOrganizationContext = scope.ServiceProvider.GetRequiredService<OrganizationContext>();

					Assert.IsFalse(sqliteOrganizationContext.Entries.Any());

					await sqliteOrganizationContext.Database.EnsureDeletedAsync();
				}
			}
		}

		[TestMethod]
		public async Task UseOrganizationContext_SqliteAndScopedLifetime_Test()
		{
			await this.UseOrganizationContext_Sqlite_Test(ServiceLifetime.Scoped);
		}

		[TestMethod]
		public async Task UseOrganizationContext_SqliteAndSingletonLifetime_Test()
		{
			await this.UseOrganizationContext_Sqlite_Test(ServiceLifetime.Singleton);
		}

		[TestMethod]
		public async Task UseOrganizationContext_SqliteAndTransientLifetime_Test()
		{
			await this.UseOrganizationContext_Sqlite_Test(ServiceLifetime.Transient);
		}

		protected internal virtual async Task UseOrganizationContext_SqlServer_Test(ServiceLifetime serviceLifetime)
		{
			var connectionString = Global.Configuration.GetConnectionString("SqlServer");
			connectionString = await SqlServerConnectionStringResolver.ResolveAsync(connectionString);

			var services = new ServiceCollection();
			services.AddSqlServerOrganizationContext(builder => builder.UseSqlServer(connectionString), serviceLifetime, serviceLifetime);

			using(var serviceProvider = services.BuildServiceProvider())
			{
				var applicationBuilder = new ApplicationBuilder(serviceProvider);
				applicationBuilder.UseOrganizationContext();

				using(var scope = applicationBuilder.ApplicationServices.CreateScope())
				{
					var sqlServerOrganizationContext = scope.ServiceProvider.GetRequiredService<OrganizationContext>();

					Assert.IsFalse(sqlServerOrganizationContext.Entries.Any());

					await sqlServerOrganizationContext.Database.EnsureDeletedAsync();
				}
			}
		}

		[TestMethod]
		public async Task UseOrganizationContext_SqlServerAndScopedLifetime_Test()
		{
			await this.UseOrganizationContext_SqlServer_Test(ServiceLifetime.Scoped);
		}

		[TestMethod]
		public async Task UseOrganizationContext_SqlServerAndSingletonLifetime_Test()
		{
			await this.UseOrganizationContext_SqlServer_Test(ServiceLifetime.Singleton);
		}

		[TestMethod]
		public async Task UseOrganizationContext_SqlServerAndTransientLifetime_Test()
		{
			await this.UseOrganizationContext_SqlServer_Test(ServiceLifetime.Transient);
		}

		#endregion
	}
}