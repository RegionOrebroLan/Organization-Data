using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace RegionOrebroLan.Organization.Data.Builder.Extensions
{
	public static class ApplicationBuilderExtension
	{
		#region Methods

		public static IApplicationBuilder UseOrganizationContext(this IApplicationBuilder applicationBuilder)
		{
			if(applicationBuilder == null)
				throw new ArgumentNullException(nameof(applicationBuilder));

			using(var scope = applicationBuilder.ApplicationServices.CreateScope())
			{
				scope.ServiceProvider.GetRequiredService<OrganizationContext>().Database.Migrate();
			}

			return applicationBuilder;
		}

		#endregion
	}
}