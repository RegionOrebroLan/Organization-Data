using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RegionOrebroLan.Organization.Data.Entities;

namespace RegionOrebroLan.Organization.Data
{
	public interface IOrganizationContext : IDisposable
	{
		#region Properties

		DbSet<Entry> Entries { get; set; }

		#endregion

		#region Methods

		int SaveChanges();
		int SaveChanges(bool acceptAllChangesOnSuccess);
		Task<int> SaveChangesAsync(CancellationToken cancellationToken);
		Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken);

		#endregion
	}
}