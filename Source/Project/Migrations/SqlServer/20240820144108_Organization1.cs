using Microsoft.EntityFrameworkCore.Migrations;

namespace RegionOrebroLan.Organization.Data.Migrations.SqlServer
{
	public partial class Organization1 : Migration
	{
		#region Methods

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropColumn(
				name: "HsaVideoPhone",
				table: "Entries");
		}

		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AddColumn<string>(
				name: "HsaVideoPhone",
				table: "Entries",
				type: "nvarchar(200)",
				maxLength: 200,
				nullable: true);
		}

		#endregion
	}
}