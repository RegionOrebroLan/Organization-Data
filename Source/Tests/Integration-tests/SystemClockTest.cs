using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RegionOrebroLan.OrganizationServices.Data.IntegrationTests
{
	[TestClass]
	public class SystemClockTest
	{
		#region Methods

		[TestMethod]
		public void Now_Test()
		{
			Assert.AreEqual(DateTimeKind.Local, new SystemClock().Now.Kind);
		}

		[TestMethod]
		public void UtcNow_Test()
		{
			Assert.AreEqual(DateTimeKind.Utc, new SystemClock().UtcNow.Kind);
		}

		#endregion
	}
}