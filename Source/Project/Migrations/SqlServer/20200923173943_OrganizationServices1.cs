using Microsoft.EntityFrameworkCore.Migrations;

namespace RegionOrebroLan.Organization.Data.Migrations.SqlServer
{
	public partial class Update : Migration
	{
		#region Methods

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AlterColumn<string>(
				name: "VisitingHours",
				table: "Entries",
				type: "nvarchar(200)",
				maxLength: 200,
				nullable: true,
				oldClrType: typeof(string),
				oldMaxLength: 500,
				oldNullable: true);

			migrationBuilder.AlterColumn<string>(
				name: "TelephoneHours",
				table: "Entries",
				type: "nvarchar(200)",
				maxLength: 200,
				nullable: true,
				oldClrType: typeof(string),
				oldMaxLength: 500,
				oldNullable: true);

			migrationBuilder.AlterColumn<string>(
				name: "SurgeryHours",
				table: "Entries",
				type: "nvarchar(200)",
				maxLength: 200,
				nullable: true,
				oldClrType: typeof(string),
				oldMaxLength: 500,
				oldNullable: true);

			migrationBuilder.AlterColumn<string>(
				name: "DropInHours",
				table: "Entries",
				type: "nvarchar(200)",
				maxLength: 200,
				nullable: true,
				oldClrType: typeof(string),
				oldMaxLength: 500,
				oldNullable: true);
		}

		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AlterColumn<string>(
				name: "VisitingHours",
				table: "Entries",
				maxLength: 500,
				nullable: true,
				oldClrType: typeof(string),
				oldType: "nvarchar(200)",
				oldMaxLength: 200,
				oldNullable: true);

			migrationBuilder.AlterColumn<string>(
				name: "TelephoneHours",
				table: "Entries",
				maxLength: 500,
				nullable: true,
				oldClrType: typeof(string),
				oldType: "nvarchar(200)",
				oldMaxLength: 200,
				oldNullable: true);

			migrationBuilder.AlterColumn<string>(
				name: "SurgeryHours",
				table: "Entries",
				maxLength: 500,
				nullable: true,
				oldClrType: typeof(string),
				oldType: "nvarchar(200)",
				oldMaxLength: 200,
				oldNullable: true);

			migrationBuilder.AlterColumn<string>(
				name: "DropInHours",
				table: "Entries",
				maxLength: 500,
				nullable: true,
				oldClrType: typeof(string),
				oldType: "nvarchar(200)",
				oldMaxLength: 200,
				oldNullable: true);
		}

		#endregion
	}
}