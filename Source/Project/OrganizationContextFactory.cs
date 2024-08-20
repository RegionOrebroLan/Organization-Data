using System;
using Microsoft.Extensions.DependencyInjection;

namespace RegionOrebroLan.Organization.Data
{
	/// <summary>
	/// Needs a transient lifetime for the organization-context.
	/// </summary>
	public class OrganizationContextFactory(IServiceProvider serviceProvider) : IOrganizationContextFactory
	{
		#region Properties

		protected internal virtual IServiceProvider ServiceProvider { get; } = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));

		#endregion

		#region Methods

		public virtual IOrganizationContext Create()
		{
			return this.ServiceProvider.GetRequiredService<IOrganizationContext>();
		}

		#endregion
	}
}