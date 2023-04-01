namespace RegionOrebroLan.Organization.Data
{
	/// <summary>
	/// Needs a transient lifetime for the organization-context.
	/// </summary>
	public interface IOrganizationContextFactory
	{
		#region Methods

		IOrganizationContext Create();

		#endregion
	}
}