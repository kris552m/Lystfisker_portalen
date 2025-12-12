using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LystfiskerPortalen.Migrations
{
    /// <inheritdoc />
    public partial class migrationnewest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-guid-1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91fd3936-bcf9-477b-ad0a-1baeb7045213", "AQAAAAIAAYagAAAAEDNNis3BJL6fpJpHUVsmEPkDY9qE37YRMt3aVfOyKlTPCSQTSJb72a7W+FOVOgo2Nw==", "e7477755-ce3e-4822-8ed8-ea9f2620ccca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-guid-2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f85ebed-8cc1-4b8a-8e35-93aae8f1090d", "AQAAAAIAAYagAAAAEJys/9cNqMWq4aeVGU6ARvcc0KyHY27k1qvMKpcQlDztRh/A7/3JveZfOOxiXX+a1A==", "a7830172-4a9f-4773-a103-1a7ae2c966fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-guid-3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97629842-0971-4f76-933a-beb75cbb32b1", "AQAAAAIAAYagAAAAEDG0uqcmzkYEZXwE+cLUB8WPHEKSKivWV+yzqfIg20pXtN5kGpKbNvBekM76EyHHug==", "5bda8483-6efc-4582-b13a-52d01eb957aa" });

            migrationBuilder.UpdateData(
                table: "Catches",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CatchTime",
                value: new DateTime(2025, 11, 25, 10, 39, 2, 32, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "Catches",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CatchTime",
                value: new DateTime(2025, 12, 3, 11, 39, 2, 32, DateTimeKind.Local).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "Catches",
                keyColumn: "PostId",
                keyValue: 5,
                column: "CatchTime",
                value: new DateTime(2025, 12, 4, 22, 39, 2, 32, DateTimeKind.Local).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CommentTime",
                value: new DateTime(2025, 11, 26, 12, 39, 2, 32, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CommentTime",
                value: new DateTime(2025, 11, 26, 14, 39, 2, 32, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CommentTime",
                value: new DateTime(2025, 12, 4, 12, 39, 2, 32, DateTimeKind.Local).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "CommentTime",
                value: new DateTime(2025, 11, 29, 12, 39, 2, 32, DateTimeKind.Local).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "PostId",
                keyValue: 6,
                column: "EventTime",
                value: new DateTime(2026, 2, 5, 12, 39, 2, 32, DateTimeKind.Local).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "PostId",
                keyValue: 7,
                column: "EventTime",
                value: new DateTime(2025, 12, 19, 12, 39, 2, 32, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "PostTime",
                value: new DateTime(2025, 11, 21, 12, 39, 2, 32, DateTimeKind.Local).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "PostTime",
                value: new DateTime(2025, 11, 30, 12, 39, 2, 32, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "PostTime",
                value: new DateTime(2025, 11, 25, 12, 39, 2, 32, DateTimeKind.Local).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "PostTime",
                value: new DateTime(2025, 12, 3, 12, 39, 2, 32, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "PostTime",
                value: new DateTime(2025, 12, 5, 0, 39, 2, 32, DateTimeKind.Local).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "PostTime",
                value: new DateTime(2025, 11, 5, 12, 39, 2, 32, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "PostTime",
                value: new DateTime(2025, 11, 28, 12, 39, 2, 32, DateTimeKind.Local).AddTicks(3798));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-guid-1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f7d5657-aa41-418a-a0ca-bcf08247c75e", "AQAAAAIAAYagAAAAEOXkJ3o3fwGZlAX1LctSC4InVaLhUA7gp8gNnE8zV00FN1spF8jQIxNHnzlrotac4Q==", "151a58f1-accc-445a-9b97-cfb5b369aa67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-guid-2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ba4fff5-3383-446e-909f-3b27ec13e896", "AQAAAAIAAYagAAAAEKGhEbxs1qwTIn5kGEf92lE21S7QCVzVc/BIWf0Ba1uyIS6K8Q4tYWyCPkD4EyPcpQ==", "16aedb11-87ef-496b-846b-c4c013d46aa5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-guid-3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b111ff6-01fd-4bae-a9f9-d93759ec4cea", "AQAAAAIAAYagAAAAEPYetasqhyB75R52XVFFt6EgHmf5tyflHXCb/ZXjhp7Dixcjx7rOyFbAIrM5FxQNrg==", "84ecd1db-e3cf-4fa2-ae53-e37a910f9568" });

            migrationBuilder.UpdateData(
                table: "Catches",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CatchTime",
                value: new DateTime(2025, 11, 15, 10, 20, 37, 556, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Catches",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CatchTime",
                value: new DateTime(2025, 11, 23, 11, 20, 37, 556, DateTimeKind.Local).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "Catches",
                keyColumn: "PostId",
                keyValue: 5,
                column: "CatchTime",
                value: new DateTime(2025, 11, 24, 22, 20, 37, 556, DateTimeKind.Local).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CommentTime",
                value: new DateTime(2025, 11, 16, 12, 20, 37, 556, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CommentTime",
                value: new DateTime(2025, 11, 16, 14, 20, 37, 556, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CommentTime",
                value: new DateTime(2025, 11, 24, 12, 20, 37, 556, DateTimeKind.Local).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "CommentTime",
                value: new DateTime(2025, 11, 19, 12, 20, 37, 556, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "PostId",
                keyValue: 6,
                column: "EventTime",
                value: new DateTime(2026, 1, 25, 12, 20, 37, 556, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "PostId",
                keyValue: 7,
                column: "EventTime",
                value: new DateTime(2025, 12, 9, 12, 20, 37, 556, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "PostTime",
                value: new DateTime(2025, 11, 11, 12, 20, 37, 553, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "PostTime",
                value: new DateTime(2025, 11, 20, 12, 20, 37, 553, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "PostTime",
                value: new DateTime(2025, 11, 15, 12, 20, 37, 556, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "PostTime",
                value: new DateTime(2025, 11, 23, 12, 20, 37, 556, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "PostTime",
                value: new DateTime(2025, 11, 25, 0, 20, 37, 556, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "PostTime",
                value: new DateTime(2025, 10, 25, 12, 20, 37, 556, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "PostTime",
                value: new DateTime(2025, 11, 18, 12, 20, 37, 556, DateTimeKind.Local).AddTicks(7174));
        }
    }
}
