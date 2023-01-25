using System;
using RegionOrebroLan.OrganizationServices.Data;

namespace IntegrationTests.Fakes
{
	public class FakedSystemClock : ISystemClock
	{
		#region Properties

		public virtual DateTime Now { get; set; }
		public virtual DateTime UtcNow { get; set; }

		#endregion
	}
}