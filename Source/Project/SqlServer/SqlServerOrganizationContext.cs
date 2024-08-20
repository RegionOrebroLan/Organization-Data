using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Internal;

namespace RegionOrebroLan.Organization.Data.SqlServer
{
	public class SqlServerOrganizationContext(IGuidFactory guidFactory, DbContextOptions<SqlServerOrganizationContext> options, ISystemClock systemClock) : OrganizationContext<SqlServerOrganizationContext>(guidFactory, options, systemClock) { }
}