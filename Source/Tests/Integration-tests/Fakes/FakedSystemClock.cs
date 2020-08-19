using System;

namespace RegionOrebroLan.OrganizationServices.Data.IntegrationTests.Fakes
{
	public class FakedSystemClock : ISystemClock
	{
		#region Properties

		public virtual DateTime Now { get; set; }
		public virtual DateTime UtcNow { get; set; }

		#endregion
	}
}