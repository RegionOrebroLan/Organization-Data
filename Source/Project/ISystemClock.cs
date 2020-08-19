using System;

namespace RegionOrebroLan.OrganizationServices.Data
{
	public interface ISystemClock
	{
		#region Properties

		DateTime Now { get; }
		DateTime UtcNow { get; }

		#endregion
	}
}