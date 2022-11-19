using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class HouseIsActiveAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        //    migrationBuilder.UpdateData(
        //        table: "AspNetUsers",
        //        keyColumn: "Id",
        //        keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
        //        columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
        //        values: new object[] { "a061162e-33e2-4fdd-ab07-2fa9d7c1565b", "AQAAAAEAACcQAAAAEG1LMq6/rke0AWjHKICBLkVouLz2PM7W8Or4qrwFNwcH1mxevLk34xNf86w1aAD7lQ==", "4ac40a28-e904-46df-811f-03882ff9f230" });

        //    migrationBuilder.UpdateData(
        //        table: "AspNetUsers",
        //        keyColumn: "Id",
        //        keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
        //        columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
        //        values: new object[] { "f9842fb2-b48a-47a8-8a3b-8fb3508e0d2f", "AQAAAAEAACcQAAAAEKaN5ePJBGz2H4W851ufOJh5zbtTSunZ6ZG9UEnzA69n86rE3z5/5vVjlGVGFWYocQ==", "3c3f4008-4bb6-4603-bde9-522fd1919d7c" });
        //
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dac7a760-c1ed-4d49-a896-8febd8f5d8d8", "AQAAAAEAACcQAAAAENe+WtcZ0h2nKWA8u3XSY7NJcKdBDQwyRPAcCrlRg8bph8sP5X4GpIlBqECrZv6Xgw==", "ba7de08f-5a9b-45a2-9c88-6456bb10413c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d31fbf8-ef92-4db4-9c1d-ca16236a2555", "AQAAAAEAACcQAAAAEEMTTZy7MC5vqsEdLLTho/yXGXYvWEzl7FVP8H4J87UuaoHWG9KzHPurW5XeE0Z23w==", "702147d8-57a1-4c02-be08-350ef0fea977" });
        }
    }
}
