using System;

namespace RegionOrebroLan.Organization.Data
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