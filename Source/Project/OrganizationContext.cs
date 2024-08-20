using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Internal;
using RegionOrebroLan.Organization.Data.Entities;

namespace RegionOrebroLan.Organization.Data
{
	public abstract class OrganizationContext(IGuidFactory guidFactory, DbContextOptions options, ISystemClock systemClock) : DbContext(options), IOrganizationContext
	{
		#region Fields

		public const string EntriesTableName = "Entries";

		#endregion

		#region Properties

		public virtual DbSet<Entry> Entries { get; set; }
		protected internal virtual IGuidFactory GuidFactory { get; } = guidFactory ?? throw new ArgumentNullException(nameof(guidFactory));
		protected internal virtual ISystemClock SystemClock { get; } = systemClock ?? throw new ArgumentNullException(nameof(systemClock));

		#endregion

		#region Methods

		protected internal virtual void CreateEntryModel(ModelBuilder modelBuilder)
		{
			if(modelBuilder == null)
				throw new ArgumentNullException(nameof(modelBuilder));

			modelBuilder.Entity<Entry>(entity =>
			{
				entity.HasIndex(entry => entry.DistinguishedName).IsUnique();
				entity.HasIndex(entry => entry.Guid).IsUnique();
				entity.HasIndex(entry => entry.HsaIdentity).IsUnique();

				entity.HasKey(entry => entry.Id);

				entity.ToTable(EntriesTableName);
			});
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			this.CreateEntryModel(modelBuilder);
		}

		protected internal virtual void PrepareSaveChanges()
		{
			var entityEntries = this.ChangeTracker.Entries().Where(entityEntry => entityEntry.State is EntityState.Added or EntityState.Modified).ToArray();
			var entries = entityEntries.Select(entityEntry => entityEntry.Entity).OfType<Entry>().ToArray();

			var now = this.SystemClock.UtcNow.UtcDateTime;

			foreach(var entityEntry in entityEntries)
			{
				if(entityEntry.Entity is not Entry entry)
					continue;

				if(entityEntry.State == EntityState.Added)
				{
					entry.Created = now;
					entry.Guid = this.GuidFactory.Create();
				}

				entry.Saved = now;
			}
		}

		public override int SaveChanges(bool acceptAllChangesOnSuccess)
		{
			this.PrepareSaveChanges();

			return base.SaveChanges(acceptAllChangesOnSuccess);
		}

		public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
		{
			this.PrepareSaveChanges();

			return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
		}

		#endregion
	}

	public abstract class OrganizationContext<T>(IGuidFactory guidFactory, DbContextOptions<T> options, ISystemClock systemClock) : OrganizationContext(guidFactory, options, systemClock) where T : OrganizationContext { }
}