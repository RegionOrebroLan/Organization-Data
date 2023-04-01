using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Internal;
using RegionOrebroLan.Organization.Data.Sqlite;
using RegionOrebroLan.Organization.Data.SqlServer;

namespace RegionOrebroLan.Organization.Data.DependencyInjection.Extensions
{
	public static class ServiceCollectionExtension
	{
		#region Methods

		public static IServiceCollection AddOrganizationContext<T>(this IServiceCollection services, Action<DbContextOptionsBuilder> optionsAction = null, ServiceLifetime contextLifetime = ServiceLifetime.Scoped, ServiceLifetime optionsLifetime = ServiceLifetime.Scoped) where T : OrganizationContext
		{
			if(services == null)
				throw new ArgumentNullException(nameof(services));

			services.AddOrganizationContextDependencies();
			services.AddDbContext<T>(optionsAction, contextLifetime, optionsLifetime);
			services.Add(new ServiceDescriptor(typeof(IOrganizationContext), serviceProvider => serviceProvider.GetService<OrganizationContext>(), contextLifetime));
			services.Add(new ServiceDescriptor(typeof(OrganizationContext), serviceProvider => serviceProvider.GetService<T>(), contextLifetime));
			services.AddSingleton<IOrganizationContextFactory, OrganizationContextFactory>();

			return services;
		}

		public static IServiceCollection AddOrganizationContextDependencies(this IServiceCollection services)
		{
			if(services == null)
				throw new ArgumentNullException(nameof(services));

			services.TryAddSingleton<IGuidFactory, GuidFactory>();
			services.TryAddSingleton<ISystemClock, SystemClock>();

			return services;
		}

		public static IServiceCollection AddSqliteOrganizationContext(this IServiceCollection services, Action<DbContextOptionsBuilder> optionsAction = null, ServiceLifetime contextLifetime = ServiceLifetime.Scoped, ServiceLifetime optionsLifetime = ServiceLifetime.Scoped)
		{
			return services.AddOrganizationContext<SqliteOrganizationContext>(optionsAction, contextLifetime, optionsLifetime);
		}

		public static IServiceCollection AddSqlServerOrganizationContext(this IServiceCollection services, Action<DbContextOptionsBuilder> optionsAction = null, ServiceLifetime contextLifetime = ServiceLifetime.Scoped, ServiceLifetime optionsLifetime = ServiceLifetime.Scoped)
		{
			return services.AddOrganizationContext<SqlServerOrganizationContext>(optionsAction, contextLifetime, optionsLifetime);
		}

		#endregion
	}
}