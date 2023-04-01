using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegionOrebroLan.Organization.Data.Migrations.Sqlite
{
	public partial class Create : Migration
	{
		#region Methods

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Entries");
		}

		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Entries",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("Sqlite:Autoincrement", true),
					BusinessClassificationName = table.Column<string>(maxLength: 200, nullable: true),
					Cn = table.Column<string>(maxLength: 100, nullable: true),
					CountyCode = table.Column<string>(maxLength: 10, nullable: true),
					CountyName = table.Column<string>(maxLength: 20, nullable: true),
					Created = table.Column<DateTime>(nullable: false),
					Description = table.Column<string>(nullable: true),
					Disabled = table.Column<bool>(nullable: false),
					DisplayName = table.Column<string>(maxLength: 50, nullable: true),
					DisplayOption = table.Column<string>(maxLength: 10, nullable: true),
					DistinguishedName = table.Column<string>(maxLength: 500, nullable: false),
					DropInHours = table.Column<string>(maxLength: 200, nullable: true),
					EndDate = table.Column<string>(maxLength: 20, nullable: true),
					Extension = table.Column<string>(maxLength: 50, nullable: true),
					FacsimileTelephoneNumber = table.Column<string>(maxLength: 50, nullable: true),
					FinancingOrganization = table.Column<string>(maxLength: 20, nullable: true),
					FullName = table.Column<string>(maxLength: 100, nullable: true),
					GeographicalCoordinates = table.Column<string>(maxLength: 20, nullable: true),
					GivenName = table.Column<string>(maxLength: 50, nullable: true),
					Guid = table.Column<Guid>(nullable: false),
					HsaAltText = table.Column<string>(maxLength: 100, nullable: true),
					HsaConsigneeAddress = table.Column<string>(maxLength: 100, nullable: true),
					HsaDeliveryAddress = table.Column<string>(maxLength: 100, nullable: true),
					HsaDirectoryContact = table.Column<string>(maxLength: 100, nullable: true),
					HsaGroupPrescriptionCode = table.Column<string>(maxLength: 10, nullable: true),
					HsaHealthCareArea = table.Column<string>(maxLength: 100, nullable: true),
					HsaHealthCareUnitManager = table.Column<string>(maxLength: 20, nullable: true),
					HsaHealthCareUnitMember = table.Column<string>(nullable: true),
					HsaIdentity = table.Column<string>(maxLength: 50, nullable: false),
					HsaInvoiceAddress = table.Column<string>(maxLength: 100, nullable: true),
					HsaProtectedPerson = table.Column<string>(maxLength: 10, nullable: true),
					HsaResponsibleHealthCareProvider = table.Column<string>(maxLength: 50, nullable: true),
					HsaSwitchboardNumber = table.Column<string>(maxLength: 50, nullable: true),
					HsaTelephoneNumber = table.Column<string>(maxLength: 50, nullable: true),
					HsaTextTelephoneNumber = table.Column<string>(maxLength: 50, nullable: true),
					HsaTitle = table.Column<string>(maxLength: 50, nullable: true),
					HsaVisitingRuleAge = table.Column<string>(maxLength: 10, nullable: true),
					HsaVisitingRuleReferral = table.Column<string>(maxLength: 200, nullable: true),
					HsaVisitingRules = table.Column<string>(maxLength: 200, nullable: true),
					HsaVpwInformation1 = table.Column<string>(nullable: true),
					HsaVpwInformation2 = table.Column<string>(nullable: true),
					HsaVpwInformation3 = table.Column<string>(nullable: true),
					HsaVpwInformation4 = table.Column<string>(nullable: true),
					HsaVpwNeighbouringObject = table.Column<string>(maxLength: 500, nullable: true),
					Initials = table.Column<string>(maxLength: 10, nullable: true),
					L = table.Column<string>(maxLength: 50, nullable: true),
					LabeledURI = table.Column<string>(maxLength: 500, nullable: true),
					Mail = table.Column<string>(maxLength: 100, nullable: true),
					MiddleName = table.Column<string>(maxLength: 20, nullable: true),
					Mobile = table.Column<string>(maxLength: 50, nullable: true),
					MunicipalityCode = table.Column<string>(maxLength: 10, nullable: true),
					MunicipalityName = table.Column<string>(maxLength: 20, nullable: true),
					NickName = table.Column<string>(maxLength: 20, nullable: true),
					O = table.Column<string>(maxLength: 20, nullable: true),
					ObjectClass = table.Column<string>(maxLength: 200, nullable: true),
					OllAssistant = table.Column<string>(maxLength: 20, nullable: true),
					OllInternalPagerNumber = table.Column<string>(maxLength: 50, nullable: true),
					OllManager = table.Column<string>(maxLength: 20, nullable: true),
					OllPublicTelephoneNumber = table.Column<string>(maxLength: 50, nullable: true),
					OllStudentValues = table.Column<string>(maxLength: 100, nullable: true),
					OllSystemId = table.Column<string>(maxLength: 20, nullable: true),
					OllSystemRole = table.Column<string>(nullable: true),
					OllViceManager = table.Column<string>(maxLength: 20, nullable: true),
					OrgNo = table.Column<string>(maxLength: 20, nullable: true),
					Ou = table.Column<string>(maxLength: 100, nullable: true),
					OuShort = table.Column<string>(maxLength: 50, nullable: true),
					Pager = table.Column<string>(maxLength: 50, nullable: true),
					PaTitleName = table.Column<string>(maxLength: 200, nullable: true),
					PostalAddress = table.Column<string>(maxLength: 100, nullable: true),
					PostalCode = table.Column<string>(maxLength: 10, nullable: true),
					PostOfficeBox = table.Column<string>(maxLength: 20, nullable: true),
					RBAC = table.Column<string>(maxLength: 500, nullable: true),
					Route = table.Column<string>(maxLength: 500, nullable: true),
					Saved = table.Column<DateTime>(nullable: false),
					SeeAlso = table.Column<string>(maxLength: 200, nullable: true),
					SmsTelephoneNumber = table.Column<string>(maxLength: 50, nullable: true),
					Sn = table.Column<string>(maxLength: 50, nullable: true),
					SpecialityName = table.Column<string>(maxLength: 100, nullable: true),
					St = table.Column<string>(maxLength: 20, nullable: true),
					StartDate = table.Column<string>(maxLength: 20, nullable: true),
					Street = table.Column<string>(maxLength: 200, nullable: true),
					SurgeryHours = table.Column<string>(maxLength: 200, nullable: true),
					TelephoneHours = table.Column<string>(maxLength: 200, nullable: true),
					TelephoneNumber = table.Column<string>(maxLength: 50, nullable: true),
					TelexNumber = table.Column<string>(maxLength: 20, nullable: true),
					Title = table.Column<string>(maxLength: 100, nullable: true),
					Uid = table.Column<string>(maxLength: 10, nullable: true),
					UnitPrescriptionCode = table.Column<string>(maxLength: 50, nullable: true),
					UnitShortName = table.Column<string>(maxLength: 50, nullable: true),
					ValidNotAfter = table.Column<string>(maxLength: 100, nullable: true),
					ValidNotBefore = table.Column<string>(maxLength: 500, nullable: true),
					VisitingHours = table.Column<string>(maxLength: 200, nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Entries", x => x.Id);
				});

			migrationBuilder.CreateIndex(
				name: "IX_Entries_DistinguishedName",
				table: "Entries",
				column: "DistinguishedName",
				unique: true);

			migrationBuilder.CreateIndex(
				name: "IX_Entries_Guid",
				table: "Entries",
				column: "Guid",
				unique: true);

			migrationBuilder.CreateIndex(
				name: "IX_Entries_HsaIdentity",
				table: "Entries",
				column: "HsaIdentity",
				unique: true);
		}

		#endregion
	}
}