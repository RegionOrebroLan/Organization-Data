using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Internal;

namespace RegionOrebroLan.Organization.Data.Sqlite
{
	/// <summary>
	/// Class used when creating migrations.
	/// </summary>
	public class SqliteOrganizationContextDesignTimeFactory : IDesignTimeDbContextFactory<SqliteOrganizationContext>
	{
		#region Methods

		public SqliteOrganizationContext CreateDbContext(string[] args)
		{
			var optionsBuilder = new DbContextOptionsBuilder<SqliteOrganizationContext>();
			optionsBuilder.UseSqlite("A value that can not be empty just to be able to create/update migrations.");

			return new SqliteOrganizationContext(new GuidFactory(), optionsBuilder.Options, new SystemClock());
		}

		#endregion
	}
}