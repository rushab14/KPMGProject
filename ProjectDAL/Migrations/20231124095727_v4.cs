using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectDAL.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facilities_FlatOwner_OwnerFlatNumber",
                table: "Facilities");

            migrationBuilder.DropIndex(
                name: "IX_Facilities_OwnerFlatNumber",
                table: "Facilities");

            migrationBuilder.DropColumn(
                name: "OwnerFlatNumber",
                table: "Facilities");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OwnerFlatNumber",
                table: "Facilities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Facilities_OwnerFlatNumber",
                table: "Facilities",
                column: "OwnerFlatNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Facilities_FlatOwner_OwnerFlatNumber",
                table: "Facilities",
                column: "OwnerFlatNumber",
                principalTable: "FlatOwner",
                principalColumn: "FlatNumber");
        }
    }
}
