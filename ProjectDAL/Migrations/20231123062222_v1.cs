using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectDAL.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Facilities",
                columns: table => new
                {
                    FacilityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isAvailable = table.Column<bool>(type: "bit", nullable: false),
                    FacilityName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facilities", x => x.FacilityId);
                });

            migrationBuilder.CreateTable(
                name: "FlatOwner",
                columns: table => new
                {
                    FlatNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlatOwner", x => x.FlatNumber);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    GatePassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlatNumber = table.Column<int>(type: "int", nullable: false),
                    VisitorsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerFlatNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.GatePassId);
                    table.ForeignKey(
                        name: "FK_Permission_FlatOwner_OwnerFlatNumber",
                        column: x => x.OwnerFlatNumber,
                        principalTable: "FlatOwner",
                        principalColumn: "FlatNumber");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Permission_OwnerFlatNumber",
                table: "Permission",
                column: "OwnerFlatNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facilities");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "FlatOwner");
        }
    }
}
