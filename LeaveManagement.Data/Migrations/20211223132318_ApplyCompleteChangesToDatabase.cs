using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class ApplyCompleteChangesToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "b6478504-bf99-4005-8a94-f9b8e0ba2e48");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "07d536a3-e10e-46fc-9276-1a5e07888fa3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa922f8c-11db-4882-9a74-142c15b4f905", "AQAAAAEAACcQAAAAEKPeahEyvemB6VgFNt0UYYHCEoi4hlR1z+rgMwajxPnlwdrbHThKy6RrBabYDpPt5A==", "b17d7563-d704-404e-a932-ba0bb8202020" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "194ea843-8410-42b1-b604-0d79ad51f9b1", "AQAAAAEAACcQAAAAEK4+niz+Q6cDiEFl/19LtdVAsE1g2SGyM+nk3Gq/okg9nMqIkRhNQPjkNhc8vCQ9Eg==", "254105d1-36ef-4239-86db-11e3e5fa744d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "4c0527fc-a9e6-4451-b8c7-3a10b7aca0fa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "ea9f3515-f510-48aa-9c3f-8b699ba94405");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9c3828e-9b86-4e80-8e4e-adce0b9066f5", "AQAAAAEAACcQAAAAEGJqNyCGluiBWtgQyE4Fqi5R6FIkMoeE5hb3Ae2xBrOdWMId7qysngXV3nKnBdS9TQ==", "528f44bd-6885-4d4d-9539-5a7c4849c273" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "295770ce-3f4b-4677-b0af-8d200fb60b8f", "AQAAAAEAACcQAAAAEEUIUqWq294RI6lX0MJC8VPeZH2T/jwLXg2Urd+V5xoJssKchHIlExmnxZy5UB/rpw==", "a43230f0-c9b2-406b-ab50-cd0905055fd1" });
        }
    }
}
