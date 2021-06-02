using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Around.API.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TouristRoutes",
                columns: new[] { "Id", "CreateTime", "DepartureTime", "Description", "DiscountPresent", "Features", "Fees", "Notes", "OriginalPrice", "Title", "UpdateTime" },
                values: new object[] { new Guid("a3ac242e-e6ed-4ba8-ba1e-d8bb055769e9"), new DateTime(2021, 4, 18, 2, 17, 40, 22, DateTimeKind.Utc).AddTicks(2160), null, "description", null, null, null, null, 0m, "test_title", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("a3ac242e-e6ed-4ba8-ba1e-d8bb055769e9"));
        }
    }
}
