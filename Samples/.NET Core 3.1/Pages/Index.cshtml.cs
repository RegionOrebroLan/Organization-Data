using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RegionOrebroLan.Organization.Data;

namespace Application.Pages
{
	public class IndexModel : PageModel
	{
		#region Constructors

		public IndexModel(IOrganizationContext organizationContext)
		{
			this.OrganizationContext = organizationContext ?? throw new ArgumentNullException(nameof(organizationContext));
		}

		#endregion

		#region Properties

		public virtual Exception Exception { get; set; }
		public virtual string Message { get; set; }
		protected internal virtual IOrganizationContext OrganizationContext { get; }

		#endregion

		#region Methods

		public void OnGet()
		{
			try
			{
				var numberOfEntries = this.OrganizationContext.Entries.Count();

				this.Message = $"There are {numberOfEntries} entries in the database.";
			}
			catch(Exception exception)
			{
				this.Exception = exception;
			}
		}

		#endregion
	}
}