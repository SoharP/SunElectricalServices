using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SunElectricalServices.Migrations
{
    /// <inheritdoc />
    public partial class aspnetroles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "Staff", "STAFF" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "781273fb-3be6-463f-86bd-91678cb1d3dc", "admin@sunelectrical.com", true, false, null, "ADMIN@SUNELECTRICAL.COM", "ADMIN", "AQAAAAIAAYagAAAAEPPMTYsEtOL3X8z59lyYnFTikzJ/POqBDHU14vp5IjWOS/MXOXPsk6s0fSDmN5UBqQ==", null, false, "f1d5f51c-2b64-40c8-8008-b54f9416f11e", false, "admin" },
                    { "2", 0, "9af296c3-ce07-4cf2-9a08-3fe2cdecf5e3", "ac116496@avcol.school.nz", true, false, null, "AC116496@AVCOL.SCHOOL.NZ", "SOHAR", "AQAAAAIAAYagAAAAEGQLy1oeTncc8D3qaKgY/ehkLIunuLIeW2dZfMIJz2o1M1saRFTJPgp3b6rk/IFB1A==", null, false, "391aec46-8817-4884-9760-5fae58e8d215", false, "Sohar" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "2", "2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");
        }
    }
}
