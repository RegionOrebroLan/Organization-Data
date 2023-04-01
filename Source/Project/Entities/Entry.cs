using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using RegionOrebroLan.Organization.Data.Entities.Internal;

namespace RegionOrebroLan.Organization.Data.Entities
{
	public class Entry
	{
		#region Properties

		[MaxLength(200)]
		public virtual string BusinessClassificationName { get; set; }

		/// <summary>
		/// Common name
		/// </summary>
		[MaxLength(100)]
		public virtual string Cn { get; set; }

		[MaxLength(10)]
		public virtual string CountyCode { get; set; }

		[MaxLength(20)]
		public virtual string CountyName { get; set; }

		/// <summary>
		/// Datetime UTC
		/// </summary>
		public virtual DateTime Created { get; set; }

		public virtual string Description { get; set; }
		public virtual bool Disabled { get; set; }

		[MaxLength(50)]
		public virtual string DisplayName { get; set; }

		/// <summary>
		/// Eg. 5#6
		/// </summary>
		[MaxLength(10)]
		public virtual string DisplayOption { get; set; }

		[MaxLength(500)]
		[Required]
		public virtual string DistinguishedName { get; set; }

		[MaxLength(Metadata.BusinessHoursLength)]
		public virtual string DropInHours { get; set; }

		/// <summary>
		/// Datetime UTC - yyyyMMddHHmmssZ
		/// </summary>
		[MaxLength(20)]
		public virtual string EndDate { get; set; }

		[MaxLength(Metadata.TelephoneNumberLength)]
		public virtual string Extension { get; set; }

		[MaxLength(Metadata.TelephoneNumberLength)]
		public virtual string FacsimileTelephoneNumber { get; set; }

		[MaxLength(20)]
		public virtual string FinancingOrganization { get; set; }

		[MaxLength(100)]
		public virtual string FullName { get; set; }

		[MaxLength(20)]
		public virtual string GeographicalCoordinates { get; set; }

		[MaxLength(50)]
		public virtual string GivenName { get; set; }

		[SuppressMessage("Naming", "CA1720:Identifier contains type name")]
		public virtual Guid Guid { get; set; }

		[MaxLength(100)]
		public virtual string HsaAltText { get; set; }

		[MaxLength(100)]
		public virtual string HsaConsigneeAddress { get; set; }

		[MaxLength(100)]
		public virtual string HsaDeliveryAddress { get; set; }

		[MaxLength(100)]
		public virtual string HsaDirectoryContact { get; set; }

		[MaxLength(10)]
		public virtual string HsaGroupPrescriptionCode { get; set; }

		[MaxLength(100)]
		public virtual string HsaHealthCareArea { get; set; }

		[MaxLength(20)]
		public virtual string HsaHealthCareUnitManager { get; set; }

		public virtual string HsaHealthCareUnitMember { get; set; }

		[MaxLength(50)]
		[Required]
		public virtual string HsaIdentity { get; set; }

		[MaxLength(100)]
		public virtual string HsaInvoiceAddress { get; set; }

		[MaxLength(10)]
		public virtual string HsaProtectedPerson { get; set; }

		[MaxLength(50)]
		public virtual string HsaResponsibleHealthCareProvider { get; set; }

		[MaxLength(Metadata.TelephoneNumberLength)]
		public virtual string HsaSwitchboardNumber { get; set; }

		[MaxLength(Metadata.TelephoneNumberLength)]
		public virtual string HsaTelephoneNumber { get; set; }

		[MaxLength(Metadata.TelephoneNumberLength)]
		public virtual string HsaTextTelephoneNumber { get; set; }

		[MaxLength(50)]
		public virtual string HsaTitle { get; set; }

		[MaxLength(10)]
		public virtual string HsaVisitingRuleAge { get; set; }

		[MaxLength(200)]
		public virtual string HsaVisitingRuleReferral { get; set; }

		[MaxLength(200)]
		public virtual string HsaVisitingRules { get; set; }

		public virtual string HsaVpwInformation1 { get; set; }
		public virtual string HsaVpwInformation2 { get; set; }
		public virtual string HsaVpwInformation3 { get; set; }
		public virtual string HsaVpwInformation4 { get; set; }

		[MaxLength(500)]
		public virtual string HsaVpwNeighbouringObject { get; set; }

		public virtual int Id { get; set; }

		[MaxLength(10)]
		public virtual string Initials { get; set; }

		/// <summary>
		/// Locality name
		/// </summary>
		[MaxLength(50)]
		public virtual string L { get; set; }

		[MaxLength(500)]
		public virtual string LabeledURI { get; set; }

		[MaxLength(100)]
		public virtual string Mail { get; set; }

		[MaxLength(20)]
		public virtual string MiddleName { get; set; }

		[MaxLength(Metadata.TelephoneNumberLength)]
		public virtual string Mobile { get; set; }

		[MaxLength(10)]
		public virtual string MunicipalityCode { get; set; }

		[MaxLength(20)]
		public virtual string MunicipalityName { get; set; }

		[MaxLength(20)]
		public virtual string NickName { get; set; }

		/// <summary>
		/// Organization
		/// </summary>
		[MaxLength(20)]
		public virtual string O { get; set; }

		[MaxLength(200)]
		public virtual string ObjectClass { get; set; }

		[MaxLength(20)]
		public virtual string OllAssistant { get; set; }

		[MaxLength(Metadata.TelephoneNumberLength)]
		public virtual string OllInternalPagerNumber { get; set; }

		[MaxLength(20)]
		public virtual string OllManager { get; set; }

		[MaxLength(Metadata.TelephoneNumberLength)]
		public virtual string OllPublicTelephoneNumber { get; set; }

		[MaxLength(100)]
		public virtual string OllStudentValues { get; set; }

		[MaxLength(20)]
		public virtual string OllSystemId { get; set; }

		public virtual string OllSystemRole { get; set; }

		[MaxLength(20)]
		public virtual string OllViceManager { get; set; }

		[MaxLength(20)]
		public virtual string OrgNo { get; set; }

		/// <summary>
		/// Organizational unit
		/// </summary>
		[MaxLength(100)]
		public virtual string Ou { get; set; }

		[MaxLength(50)]
		public virtual string OuShort { get; set; }

		[MaxLength(Metadata.TelephoneNumberLength)]
		public virtual string Pager { get; set; }

		[MaxLength(200)]
		public virtual string PaTitleName { get; set; }

		[MaxLength(100)]
		public virtual string PostalAddress { get; set; }

		[MaxLength(10)]
		public virtual string PostalCode { get; set; }

		[MaxLength(20)]
		public virtual string PostOfficeBox { get; set; }

		[MaxLength(500)]
		public virtual string RBAC { get; set; }

		[MaxLength(500)]
		public virtual string Route { get; set; }

		/// <summary>
		/// Datetime UTC
		/// </summary>
		public virtual DateTime Saved { get; set; }

		[MaxLength(200)]
		public virtual string SeeAlso { get; set; }

		[MaxLength(Metadata.TelephoneNumberLength)]
		public virtual string SmsTelephoneNumber { get; set; }

		/// <summary>
		/// Surname
		/// </summary>
		[MaxLength(50)]
		public virtual string Sn { get; set; }

		[MaxLength(100)]
		public virtual string SpecialityName { get; set; }

		[MaxLength(20)]
		public virtual string St { get; set; }

		/// <summary>
		/// Datetime UTC - yyyyMMddHHmmssZ
		/// </summary>
		[MaxLength(20)]
		public virtual string StartDate { get; set; }

		[MaxLength(200)]
		public virtual string Street { get; set; }

		[MaxLength(Metadata.BusinessHoursLength)]
		public virtual string SurgeryHours { get; set; }

		[MaxLength(Metadata.BusinessHoursLength)]
		public virtual string TelephoneHours { get; set; }

		[MaxLength(Metadata.TelephoneNumberLength)]
		public virtual string TelephoneNumber { get; set; }

		[MaxLength(20)]
		public virtual string TelexNumber { get; set; }

		[MaxLength(100)]
		public virtual string Title { get; set; }

		[MaxLength(10)]
		public virtual string Uid { get; set; }

		[MaxLength(50)]
		public virtual string UnitPrescriptionCode { get; set; }

		[MaxLength(50)]
		public virtual string UnitShortName { get; set; }

		/// <summary>
		/// Datetime UTC - yyyyMMddHHmmssZ
		/// </summary>
		[MaxLength(100)]
		public virtual string ValidNotAfter { get; set; }

		/// <summary>
		/// Datetime UTC - yyyyMMddHHmmssZ
		/// </summary>
		[MaxLength(500)]
		public virtual string ValidNotBefore { get; set; }

		[MaxLength(Metadata.BusinessHoursLength)]
		public virtual string VisitingHours { get; set; }

		#endregion
	}
}