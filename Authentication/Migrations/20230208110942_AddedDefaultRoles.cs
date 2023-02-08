using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Authentication.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "101ae0d3-da3d-4607-8ca5-082eb6e8e727", "ce78f055-aa97-4f95-af66-9494da098376", "Admin", "Admin" },
                    { "131d3621-9901-412e-9e3e-c43473ad6960", "705d1274-2a77-42a6-b0b4-b0c7e295e7a5", "User", "User" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "101ae0d3-da3d-4607-8ca5-082eb6e8e727");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "131d3621-9901-412e-9e3e-c43473ad6960");
        }
    }
}
