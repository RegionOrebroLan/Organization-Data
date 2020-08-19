using System;

namespace RegionOrebroLan.OrganizationServices.Data
{
	public class SystemClock : ISystemClock
	{
		#region Properties

		public virtual DateTime Now => DateTime.Now;
		public virtual DateTime UtcNow => DateTime.UtcNow;

		#endregion
	}
}