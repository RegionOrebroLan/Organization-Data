using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Internal;

namespace RegionOrebroLan.OrganizationServices.Data
{
	public class SqlServerDatabaseContext : DatabaseContextBase<SqlServerDatabaseContext>
	{
		#region Constructors

		public SqlServerDatabaseContext(IGuidFactory guidFactory, DbContextOptions<SqlServerDatabaseContext> options, ISystemClock systemClock) : base(guidFactory, options, systemClock) { }

		#endregion
	}
}