using Microsoft.AspNetCore.Mvc.RazorPages;
using RegionOrebroLan.Organization.Data;

namespace Application.Pages
{
	public class IndexModel(IOrganizationContextFactory organizationContextFactory) : PageModel
	{
		#region Properties

		public virtual Exception Exception { get; set; }
		public virtual string Message { get; set; }
		protected internal virtual IOrganizationContextFactory OrganizationContextFactory { get; } = organizationContextFactory ?? throw new ArgumentNullException(nameof(organizationContextFactory));

		#endregion

		#region Methods

		public void OnGet()
		{
			try
			{
				using(var organizationContext = this.OrganizationContextFactory.Create())
				{
					var numberOfEntries = organizationContext.Entries.Count();

					this.Message = $"There are {numberOfEntries} entries in the database.";
				}
			}
			catch(Exception exception)
			{
				this.Exception = exception;
			}
		}

		#endregion
	}
}