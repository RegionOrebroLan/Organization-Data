using System;

namespace RegionOrebroLan.OrganizationServices.Data
{
	public class GuidFactory : IGuidFactory
	{
		#region Methods

		public virtual Guid Create()
		{
			return Guid.NewGuid();
		}

		#endregion
	}
}