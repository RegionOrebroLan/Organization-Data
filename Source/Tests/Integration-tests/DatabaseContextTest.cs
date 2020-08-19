using System;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegionOrebroLan.OrganizationServices.Data.DependencyInjection.Extensions;
using RegionOrebroLan.OrganizationServices.Data.Entities;
using RegionOrebroLan.OrganizationServices.Data.IntegrationTests.Fakes;
using RegionOrebroLan.OrganizationServices.Data.IntegrationTests.Helpers;

namespace RegionOrebroLan.OrganizationServices.Data.IntegrationTests
{
	[TestClass]
	public class DatabaseContextTest
	{
		#region Methods

		[TestMethod]
		public void Sqlite_Test()
		{
			var services = new ServiceCollection();
			services.AddSqliteDatabaseContext(builder => builder.UseSqlite(Global.Configuration.GetConnectionString("SQLite")));
			this.Test<SqliteDatabaseContext>(services);
		}

		[TestMethod]
		public void SqlServer_Test()
		{
			var connectionString = Global.Configuration.GetConnectionString("SQLServer");
			var dataDirectoryPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
			var originalDataDirectoryPath = AppDomain.CurrentDomain.GetData(Global.DataDirectoryName);
			Directory.CreateDirectory(dataDirectoryPath);
			AppDomain.CurrentDomain.SetData(Global.DataDirectoryName, dataDirectoryPath);

			connectionString = SqlServerHelper.ResolveConnectionString(connectionString, dataDirectoryPath);

			var services = new ServiceCollection();
			services.AddSqlServerDatabaseContext(builder => builder.UseSqlServer(connectionString));

			this.Test<SqlServerDatabaseContext>(services);

			AppDomain.CurrentDomain.SetData(Global.DataDirectoryName, originalDataDirectoryPath);
			Directory.Delete(dataDirectoryPath, true);
		}

		protected internal virtual void Test<TDatabaseContext>(IServiceCollection services) where TDatabaseContext : DatabaseContextBase
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
				var databaseContext = scope.ServiceProvider.GetRequiredService<TDatabaseContext>();

				try
				{
					databaseContext.Database.Migrate();

					var created = DateTime.UtcNow;
					systemClock.UtcNow = created;

					databaseContext.Add(new Entry {DistinguishedName = "Organization-A", HsaIdentity = "Organization-A"});
					Assert.AreEqual(1, databaseContext.SaveChanges());
					var entry = databaseContext.Entries.First();
					Assert.AreEqual(created, entry.Created);
					Assert.AreEqual(guidFactory.Guids.ElementAt(0), entry.Guid);
					Assert.AreEqual(created, entry.Saved);

					var saved = created.AddHours(2);
					systemClock.UtcNow = saved;

					entry = databaseContext.Entries.First();
					entry.Street += " (some more)";
					Assert.AreEqual(1, databaseContext.SaveChanges());
					Assert.AreEqual(created, entry.Created);
					Assert.AreEqual(guidFactory.Guids.ElementAt(0), entry.Guid);
					Assert.AreEqual(saved, entry.Saved);

					//databaseContext.Add(new Person {Entry = new Entry {DistinguishedName = "Person-A", Identity = "Person-A"}, GivenName = "Arne", Surname = "Arnesson"});
					//databaseContext.Add(new Person {Entry = new Entry {DistinguishedName = "Person-B", Identity = "Person-B"}, GivenName = "Arne", Surname = "Arnesson"});
					//databaseContext.Add(new Person {Entry = new Entry {DistinguishedName = "Person-C", Identity = "Person-C"}, GivenName = "Arne", Surname = "Arnesson"});
					//databaseContext.Add(new Person {Entry = new Entry {DistinguishedName = "Person-D", Identity = "Person-D"}, GivenName = "Arne", Surname = "Arnesson"});
					//Assert.AreEqual(8, databaseContext.SaveChanges());

					//Thread.Sleep(4000);

					//const int numberOfPeople = 2;

					//var people = databaseContext.People.Take(numberOfPeople).ToArray();

					//foreach(var person in people)
					//{
					//	person.GivenName += " (lite till)";
					//}

					//Assert.AreEqual(numberOfPeople, databaseContext.SaveChanges());

					//databaseContext.Add(new Unit {Entry = new Entry {DistinguishedName = "Unit-A", Identity = "Unit-A"}});
					//databaseContext.Add(new Unit {Entry = new Entry {DistinguishedName = "Unit-B", Identity = "Unit-B"}, UnitProperty = "Value"});
					//databaseContext.Add(new Unit {Entry = new Entry {DistinguishedName = "Unit-C", Identity = "Unit-C"}});
					//Assert.AreEqual(6, databaseContext.SaveChanges());
				}
				finally
				{
					databaseContext.Database.EnsureDeleted();
				}
			}
			// ReSharper restore ConvertToUsingDeclaration
		}

		#endregion
	}
}