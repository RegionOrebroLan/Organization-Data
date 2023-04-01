using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Internal;

namespace RegionOrebroLan.Organization.Data.SqlServer
{
	public class SqlServerOrganizationContext : OrganizationContext<SqlServerOrganizationContext>
	{
		#region Constructors

		public SqlServerOrganizationContext(IGuidFactory guidFactory, DbContextOptions<SqlServerOrganizationContext> options, ISystemClock systemClock) : base(guidFactory, options, systemClock) { }

		#endregion
	}
}