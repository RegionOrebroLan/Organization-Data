using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Internal;

namespace RegionOrebroLan.Organization.Data.Sqlite
{
	public class SqliteOrganizationContext(IGuidFactory guidFactory, DbContextOptions<SqliteOrganizationContext> options, ISystemClock systemClock) : OrganizationContext<SqliteOrganizationContext>(guidFactory, options, systemClock) { }
}