using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Test.Migrations
{
    /// <inheritdoc />
    public partial class Added_seed_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Application1" },
                    { 2, "Application2" },
                    { 3, "Application3" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Customer1" },
                    { 2, "Customer2" },
                    { 3, "Customer3" }
                });

            migrationBuilder.InsertData(
                table: "CustomerApplications",
                columns: new[] { "ApplicationId", "CustomerId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 2 },
                    { 1, 3 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ApplicationId", "Description" },
                values: new object[,]
                {
                    { 1, 1, "Rule1" },
                    { 2, 1, "Rule2" },
                    { 3, 2, "Rule3" },
                    { 4, 2, "Rule4" },
                    { 5, 3, "Rule5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CustomerApplications",
                keyColumns: new[] { "ApplicationId", "CustomerId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CustomerApplications",
                keyColumns: new[] { "ApplicationId", "CustomerId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CustomerApplications",
                keyColumns: new[] { "ApplicationId", "CustomerId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CustomerApplications",
                keyColumns: new[] { "ApplicationId", "CustomerId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "CustomerApplications",
                keyColumns: new[] { "ApplicationId", "CustomerId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "CustomerApplications",
                keyColumns: new[] { "ApplicationId", "CustomerId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
