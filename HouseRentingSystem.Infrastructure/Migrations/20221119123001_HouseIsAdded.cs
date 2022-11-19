using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class HouseIsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Houses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "dac7a760-c1ed-4d49-a896-8febd8f5d8d8", "AQAAAAEAACcQAAAAENe+WtcZ0h2nKWA8u3XSY7NJcKdBDQwyRPAcCrlRg8bph8sP5X4GpIlBqECrZv6Xgw==", "ba7de08f-5a9b-45a2-9c88-6456bb10413c" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "6d31fbf8-ef92-4db4-9c1d-ca16236a2555", "AQAAAAEAACcQAAAAEEMTTZy7MC5vqsEdLLTho/yXGXYvWEzl7FVP8H4J87UuaoHWG9KzHPurW5XeE0Z23w==", "702147d8-57a1-4c02-be08-350ef0fea977" });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsActive",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Houses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41f57186-b553-42ba-9ede-c5267761657e", "AQAAAAEAACcQAAAAEMzLcluTexRcx/ify7BLPtroF8YyxVTAxJKTQmBxRnIF7FEN49JrbB3Dz4UGGLNT8w==", "bc9744c7-8ad0-4208-8915-0482ffc230f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14fc3cfe-21aa-4c84-aabe-83c65d7ead1f", "AQAAAAEAACcQAAAAECRMRzy2VEnb6F1BHe/8iCYSdLgvKfoTnTO2o24JocsCXP6EGDf8Esr3YrTGuuchyQ==", "2670c366-21bd-4f83-935c-1b4c69c2c3b6" });
        }
    }
}
