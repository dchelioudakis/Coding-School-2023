using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FuelStation.EF.Migrations
{
    /// <inheritdoc />
    public partial class SettingsEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RentingCost = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    ManagerMaxCount = table.Column<int>(type: "int", nullable: false),
                    ManagerMinCount = table.Column<int>(type: "int", nullable: false),
                    CashierMaxCount = table.Column<int>(type: "int", nullable: false),
                    CashierMinCount = table.Column<int>(type: "int", nullable: false),
                    StaffMaxCount = table.Column<int>(type: "int", nullable: false),
                    StaffMinCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");
        }
    }
}
