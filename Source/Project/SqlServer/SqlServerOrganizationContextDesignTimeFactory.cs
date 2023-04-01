using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Internal;

namespace RegionOrebroLan.Organization.Data.SqlServer
{
	/// <summary>
	/// Class used when creating migrations.
	/// </summary>
	public class SqlServerOrganizationContextDesignTimeFactory : IDesignTimeDbContextFactory<SqlServerOrganizationContext>
	{
		#region Methods

		public SqlServerOrganizationContext CreateDbContext(string[] args)
		{
			var optionsBuilder = new DbContextOptionsBuilder<SqlServerOrganizationContext>();
			optionsBuilder.UseSqlServer("A value that can not be empty just to be able to create/update migrations.");

			return new SqlServerOrganizationContext(new GuidFactory(), optionsBuilder.Options, new SystemClock());
		}

		#endregion
	}
}