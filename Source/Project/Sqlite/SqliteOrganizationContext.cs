using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Internal;

namespace RegionOrebroLan.Organization.Data.Sqlite
{
	public class SqliteOrganizationContext : OrganizationContext<SqliteOrganizationContext>
	{
		#region Constructors

		public SqliteOrganizationContext(IGuidFactory guidFactory, DbContextOptions<SqliteOrganizationContext> options, ISystemClock systemClock) : base(guidFactory, options, systemClock) { }

		#endregion
	}
}