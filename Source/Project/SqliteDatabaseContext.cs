using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Internal;

namespace RegionOrebroLan.OrganizationServices.Data
{
	public class SqliteDatabaseContext : DatabaseContextBase<SqliteDatabaseContext>
	{
		#region Constructors

		public SqliteDatabaseContext(IGuidFactory guidFactory, DbContextOptions<SqliteDatabaseContext> options, ISystemClock systemClock) : base(guidFactory, options, systemClock) { }

		#endregion
	}
}