using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectDAL.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permission_FlatOwner_OwnerFlatNumber",
                table: "Permission");

            migrationBuilder.DropIndex(
                name: "IX_Permission_OwnerFlatNumber",
                table: "Permission");

            migrationBuilder.DropColumn(
                name: "OwnerFlatNumber",
                table: "Permission");

            migrationBuilder.AlterColumn<string>(
                name: "VisitorsName",
                table: "Permission",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "FlatNumber",
                table: "Permission",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "facilities",
                table: "FlatOwner",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "gatePasses",
                table: "FlatOwner",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "facilities",
                table: "FlatOwner");

            migrationBuilder.DropColumn(
                name: "gatePasses",
                table: "FlatOwner");

            migrationBuilder.AlterColumn<string>(
                name: "VisitorsName",
                table: "Permission",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FlatNumber",
                table: "Permission",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OwnerFlatNumber",
                table: "Permission",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Permission_OwnerFlatNumber",
                table: "Permission",
                column: "OwnerFlatNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Permission_FlatOwner_OwnerFlatNumber",
                table: "Permission",
                column: "OwnerFlatNumber",
                principalTable: "FlatOwner",
                principalColumn: "FlatNumber");
        }
    }
}
