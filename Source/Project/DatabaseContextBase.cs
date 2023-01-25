using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Internal;
using RegionOrebroLan.OrganizationServices.Data.Entities;

namespace RegionOrebroLan.OrganizationServices.Data
{
	public abstract class DatabaseContextBase : DbContext
	{
		#region Fields

		public const string EntriesTableName = "Entries";

		#endregion

		#region Constructors

		protected DatabaseContextBase(IGuidFactory guidFactory, DbContextOptions options, ISystemClock systemClock) : base(options)
		{
			this.GuidFactory = guidFactory ?? throw new ArgumentNullException(nameof(guidFactory));
			this.SystemClock = systemClock ?? throw new ArgumentNullException(nameof(systemClock));
		}

		#endregion

		#region Properties

		public virtual DbSet<Entry> Entries { get; set; }
		protected internal virtual IGuidFactory GuidFactory { get; }
		protected internal virtual ISystemClock SystemClock { get; }

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

		public override int SaveChanges()
		{
			var entityEntries = this.ChangeTracker.Entries().Where(entityEntry => entityEntry.State == EntityState.Added || entityEntry.State == EntityState.Modified).ToArray();
			var entries = entityEntries.Select(entityEntry => entityEntry.Entity).OfType<Entry>().ToArray();

			var now = this.SystemClock.UtcNow.UtcDateTime;

			foreach(var entityEntry in entityEntries)
			{
				if(!(entityEntry.Entity is Entry entry))
					continue;

				if(entityEntry.State == EntityState.Added)
				{
					entry.Created = now;
					entry.Guid = this.GuidFactory.Create();
				}

				entry.Saved = now;
			}

			return base.SaveChanges();
		}

		#endregion
	}

	public abstract class DatabaseContextBase<T> : DatabaseContextBase where T : DatabaseContextBase
	{
		#region Constructors

		protected DatabaseContextBase(IGuidFactory guidFactory, DbContextOptions<T> options, ISystemClock systemClock) : base(guidFactory, options, systemClock) { }

		#endregion
	}
}