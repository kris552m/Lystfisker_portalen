using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LystfiskerPortalen.Migrations
{
    /// <inheritdoc />
    public partial class RMPicPost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Posts");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-guid-1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d32f809-bc8b-4f7d-b4c8-21396f9a92b7", "AQAAAAIAAYagAAAAEE+RlLu470u9gFjng25nn8nnUGDnTWWcmv2BafdSLz6tRkeHWSqpffdrXG5HmDN5CQ==", "d940288f-b74c-42d0-a3ef-7597fbdbb315" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-guid-2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc81bab4-96c8-4032-8965-65f160e9a71b", "AQAAAAIAAYagAAAAEIm0qsOpX0SI1xO8O/iVrVdGOehxBRvFviP2Qw9pA5AkOwbfQ0kKpnF645fxb2yxXw==", "c0190277-d660-4b4f-b08c-8b108dfa70b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-guid-3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6a213a3-4e1d-4192-b84f-54ddddc62392", "AQAAAAIAAYagAAAAEOONmbQBHIlSMvtXtr2gmL+Isi5+X8nEMfIE11XUUCvOeGOM7pzxG9GyGtyj3mIpdQ==", "c3eb11a2-e70a-406b-9040-9ab5d7c991c9" });

            migrationBuilder.UpdateData(
                table: "Catches",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CatchTime",
                value: new DateTime(2025, 12, 1, 8, 57, 28, 60, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "Catches",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CatchTime",
                value: new DateTime(2025, 12, 9, 9, 57, 28, 60, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Catches",
                keyColumn: "PostId",
                keyValue: 5,
                column: "CatchTime",
                value: new DateTime(2025, 12, 10, 20, 57, 28, 60, DateTimeKind.Local).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CommentTime",
                value: new DateTime(2025, 12, 2, 10, 57, 28, 60, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CommentTime",
                value: new DateTime(2025, 12, 2, 12, 57, 28, 60, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CommentTime",
                value: new DateTime(2025, 12, 10, 10, 57, 28, 60, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "CommentTime",
                value: new DateTime(2025, 12, 5, 10, 57, 28, 60, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "PostId",
                keyValue: 6,
                column: "EventTime",
                value: new DateTime(2026, 2, 11, 10, 57, 28, 60, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "PostId",
                keyValue: 7,
                column: "EventTime",
                value: new DateTime(2025, 12, 25, 10, 57, 28, 60, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "Picture", "PostTime" },
                values: new object[] { "", new DateTime(2025, 11, 27, 10, 57, 28, 60, DateTimeKind.Local).AddTicks(7707) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "Picture", "PostTime" },
                values: new object[] { "", new DateTime(2025, 12, 6, 10, 57, 28, 60, DateTimeKind.Local).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "Picture", "PostTime" },
                values: new object[] { "laks.jpg", new DateTime(2025, 12, 1, 10, 57, 28, 60, DateTimeKind.Local).AddTicks(8261) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                columns: new[] { "Picture", "PostTime" },
                values: new object[] { "gedde.jpg", new DateTime(2025, 12, 9, 10, 57, 28, 60, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                columns: new[] { "Picture", "PostTime" },
                values: new object[] { "torsk.jpg", new DateTime(2025, 12, 10, 22, 57, 28, 60, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                columns: new[] { "Picture", "PostTime" },
                values: new object[] { "", new DateTime(2025, 11, 11, 10, 57, 28, 60, DateTimeKind.Local).AddTicks(8585) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                columns: new[] { "Picture", "PostTime" },
                values: new object[] { "", new DateTime(2025, 12, 4, 10, 57, 28, 60, DateTimeKind.Local).AddTicks(8611) });
        }
    }
}
