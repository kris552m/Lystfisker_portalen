using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LystfiskerPortalen.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-guid-1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31b98586-5bb8-43cd-90ad-d06faf7879a3", "AQAAAAIAAYagAAAAEJ7cNlwp7G9w/B/SCI9m+gFcZ67lSkIiI2ZSOBcuOj1YUE8sfS+HugE/pI/HzkSZYA==", "7be85018-a821-4150-8324-4f755434351d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-guid-2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b4ff118-899b-4ffd-a45a-abc2975ce69f", "AQAAAAIAAYagAAAAEMhoeMZM5E3P3mAiibSlkE4unkxDIshf1XF8af6thElP9jFti805qSF4K4zpHN9sLw==", "a544be91-65c2-4cd8-a63f-4fd6b78ed3d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-guid-3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22518753-ec5e-4263-b71a-262478ae24b4", "AQAAAAIAAYagAAAAEPvE/Myg/lpGpRR9Plc+3dGYc9mj+EFFX1kg9PB6T6lLUwzwP8PMeeTgFYoeRpm7RA==", "918b4975-2197-4bf9-ac00-9ac6b005c94b" });

            migrationBuilder.UpdateData(
                table: "Catches",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CatchTime",
                value: new DateTime(2025, 12, 1, 11, 1, 33, 806, DateTimeKind.Local).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "Catches",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CatchTime",
                value: new DateTime(2025, 12, 9, 12, 1, 33, 806, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "Catches",
                keyColumn: "PostId",
                keyValue: 5,
                column: "CatchTime",
                value: new DateTime(2025, 12, 10, 23, 1, 33, 806, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CommentTime",
                value: new DateTime(2025, 12, 2, 13, 1, 33, 806, DateTimeKind.Local).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CommentTime",
                value: new DateTime(2025, 12, 2, 15, 1, 33, 806, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CommentTime",
                value: new DateTime(2025, 12, 10, 13, 1, 33, 806, DateTimeKind.Local).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "CommentTime",
                value: new DateTime(2025, 12, 5, 13, 1, 33, 806, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "PostId",
                keyValue: 6,
                column: "EventTime",
                value: new DateTime(2026, 2, 11, 13, 1, 33, 806, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "PostId",
                keyValue: 7,
                column: "EventTime",
                value: new DateTime(2025, 12, 25, 13, 1, 33, 806, DateTimeKind.Local).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "PostTime",
                value: new DateTime(2025, 11, 27, 13, 1, 33, 806, DateTimeKind.Local).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "PostTime",
                value: new DateTime(2025, 12, 6, 13, 1, 33, 806, DateTimeKind.Local).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "PostTime",
                value: new DateTime(2025, 12, 1, 13, 1, 33, 806, DateTimeKind.Local).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "PostTime",
                value: new DateTime(2025, 12, 9, 13, 1, 33, 806, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "PostTime",
                value: new DateTime(2025, 12, 11, 1, 1, 33, 806, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "PostTime",
                value: new DateTime(2025, 11, 11, 13, 1, 33, 806, DateTimeKind.Local).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "PostTime",
                value: new DateTime(2025, 12, 4, 13, 1, 33, 806, DateTimeKind.Local).AddTicks(2889));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-guid-1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7a5ebd2-6272-479a-94eb-ea1a9736d19d", "AQAAAAIAAYagAAAAEKZhO7h9nWixWRg2cfsAUmACeRdG5no/+D2Bbr3oM6CoHgRb6JeOJSQkCKGRuFCb0A==", "ddd5a2f0-b1fc-4f9d-ac9e-a120d1de683e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-guid-2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f348c92-1566-40b5-b6ee-eb44b779d6d4", "AQAAAAIAAYagAAAAECD6PLuM1w8nCn2Nsgonih46fqtrw1GaXyaMQWYJvyakK01KqZ3Zy948KpuRXIoirg==", "b10583d6-7487-47ca-a851-87e644db6070" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-guid-3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1824df93-e9e6-489d-bd0a-e3f3fcbc1e2a", "AQAAAAIAAYagAAAAEBjXw8sWMTGx/TZFrLvAewMaMii0erzQMSwYFk/v1L7xuBjivOaXqcIcYoOM2n+tQA==", "3cfe531d-17a9-40b6-bfeb-ab4dd3c66aa0" });

            migrationBuilder.UpdateData(
                table: "Catches",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CatchTime",
                value: new DateTime(2025, 12, 1, 9, 47, 20, 70, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "Catches",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CatchTime",
                value: new DateTime(2025, 12, 9, 10, 47, 20, 70, DateTimeKind.Local).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Catches",
                keyColumn: "PostId",
                keyValue: 5,
                column: "CatchTime",
                value: new DateTime(2025, 12, 10, 21, 47, 20, 70, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CommentTime",
                value: new DateTime(2025, 12, 2, 11, 47, 20, 70, DateTimeKind.Local).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CommentTime",
                value: new DateTime(2025, 12, 2, 13, 47, 20, 70, DateTimeKind.Local).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CommentTime",
                value: new DateTime(2025, 12, 10, 11, 47, 20, 70, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "CommentTime",
                value: new DateTime(2025, 12, 5, 11, 47, 20, 70, DateTimeKind.Local).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "PostId",
                keyValue: 6,
                column: "EventTime",
                value: new DateTime(2026, 2, 11, 11, 47, 20, 70, DateTimeKind.Local).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "PostId",
                keyValue: 7,
                column: "EventTime",
                value: new DateTime(2025, 12, 25, 11, 47, 20, 70, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "PostTime",
                value: new DateTime(2025, 11, 27, 11, 47, 20, 70, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "PostTime",
                value: new DateTime(2025, 12, 6, 11, 47, 20, 70, DateTimeKind.Local).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "PostTime",
                value: new DateTime(2025, 12, 1, 11, 47, 20, 70, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "PostTime",
                value: new DateTime(2025, 12, 9, 11, 47, 20, 70, DateTimeKind.Local).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "PostTime",
                value: new DateTime(2025, 12, 10, 23, 47, 20, 70, DateTimeKind.Local).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "PostTime",
                value: new DateTime(2025, 11, 11, 11, 47, 20, 70, DateTimeKind.Local).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "PostTime",
                value: new DateTime(2025, 12, 4, 11, 47, 20, 70, DateTimeKind.Local).AddTicks(3697));
        }
    }
}
