using System;
using Microsoft.Extensions.DependencyInjection;

namespace RegionOrebroLan.Organization.Data
{
	/// <summary>
	/// Needs a transient lifetime for the organization-context.
	/// </summary>
	public class OrganizationContextFactory : IOrganizationContextFactory
	{
		#region Constructors

		public OrganizationContextFactory(IServiceProvider serviceProvider)
		{
			this.ServiceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
		}

		#endregion

		#region Properties

		protected internal virtual IServiceProvider ServiceProvider { get; }

		#endregion

		#region Methods

		public virtual IOrganizationContext Create()
		{
			return this.ServiceProvider.GetRequiredService<IOrganizationContext>();
		}

		#endregion
	}
}