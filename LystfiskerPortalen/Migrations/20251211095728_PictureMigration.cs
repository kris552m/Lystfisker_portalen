using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LystfiskerPortalen.Migrations
{
    /// <inheritdoc />
    public partial class PictureMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProfileFollowings_AspNetUsers_ProfileId",
                table: "ProfileFollowings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProfileFollowings",
                table: "ProfileFollowings");

            migrationBuilder.DropIndex(
                name: "IX_ProfileFollowings_ProfileId",
                table: "ProfileFollowings");

            migrationBuilder.RenameColumn(
                name: "ProfileId",
                table: "ProfileFollowings",
                newName: "FollowerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProfileFollowings",
                table: "ProfileFollowings",
                columns: new[] { "FollowerId", "FollowingId" });

            migrationBuilder.CreateTable(
                name: "Pictures",
                columns: table => new
                {
                    PictureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PictureName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictures", x => x.PictureId);
                    table.ForeignKey(
                        name: "FK_Pictures_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId");
                });

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
                column: "PostTime",
                value: new DateTime(2025, 11, 27, 10, 57, 28, 60, DateTimeKind.Local).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "PostTime",
                value: new DateTime(2025, 12, 6, 10, 57, 28, 60, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "PostTime",
                value: new DateTime(2025, 12, 1, 10, 57, 28, 60, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "PostTime",
                value: new DateTime(2025, 12, 9, 10, 57, 28, 60, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "PostTime",
                value: new DateTime(2025, 12, 10, 22, 57, 28, 60, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "PostTime",
                value: new DateTime(2025, 11, 11, 10, 57, 28, 60, DateTimeKind.Local).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "PostTime",
                value: new DateTime(2025, 12, 4, 10, 57, 28, 60, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.CreateIndex(
                name: "IX_ProfileFollowings_FollowingId",
                table: "ProfileFollowings",
                column: "FollowingId");

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_PostId",
                table: "Pictures",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileFollowings_AspNetUsers_FollowerId",
                table: "ProfileFollowings",
                column: "FollowerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProfileFollowings_AspNetUsers_FollowerId",
                table: "ProfileFollowings");

            migrationBuilder.DropTable(
                name: "Pictures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProfileFollowings",
                table: "ProfileFollowings");

            migrationBuilder.DropIndex(
                name: "IX_ProfileFollowings_FollowingId",
                table: "ProfileFollowings");

            migrationBuilder.RenameColumn(
                name: "FollowerId",
                table: "ProfileFollowings",
                newName: "ProfileId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProfileFollowings",
                table: "ProfileFollowings",
                columns: new[] { "FollowingId", "ProfileId" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-guid-1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "995e5580-2eeb-4488-9fda-102520ca9bd4", "AQAAAAIAAYagAAAAENARgSVoBuMTAtuH1fi5fV/KsVMa44Qj2dXhMhijN80k5OBNb7lNNmrN3lIsgFMiLQ==", "7655deef-fbb6-4cde-9c8e-a20a5d89b071" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-guid-2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9538670f-602a-476d-8a3f-9469634c3a42", "AQAAAAIAAYagAAAAEF5/jfxRZwG9qFHAaSnHChoAbR3xTl4YpKTQt2YIC7NGoSP5FYV6vXIn0/oaHwX4Zw==", "b206e42d-10fe-4138-be95-a56ee751876e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-guid-3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ede4db3a-91e2-4d26-be23-6d5404d1649c", "AQAAAAIAAYagAAAAEOaLPKG4U/Mz+lcCYEX/txQn3dlKTpufYFHGrXASQZHDXJ9Jl4DglZkkrsb/2fkgTA==", "acefa2e9-e1b5-4359-9d2b-4da752a9e916" });

            migrationBuilder.UpdateData(
                table: "Catches",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CatchTime",
                value: new DateTime(2025, 11, 22, 8, 35, 32, 316, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Catches",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CatchTime",
                value: new DateTime(2025, 11, 30, 9, 35, 32, 316, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "Catches",
                keyColumn: "PostId",
                keyValue: 5,
                column: "CatchTime",
                value: new DateTime(2025, 12, 1, 20, 35, 32, 316, DateTimeKind.Local).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CommentTime",
                value: new DateTime(2025, 11, 23, 10, 35, 32, 316, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CommentTime",
                value: new DateTime(2025, 11, 23, 12, 35, 32, 316, DateTimeKind.Local).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CommentTime",
                value: new DateTime(2025, 12, 1, 10, 35, 32, 316, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "CommentTime",
                value: new DateTime(2025, 11, 26, 10, 35, 32, 316, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "PostId",
                keyValue: 6,
                column: "EventTime",
                value: new DateTime(2026, 2, 2, 10, 35, 32, 316, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "PostId",
                keyValue: 7,
                column: "EventTime",
                value: new DateTime(2025, 12, 16, 10, 35, 32, 316, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "PostTime",
                value: new DateTime(2025, 11, 18, 10, 35, 32, 316, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "PostTime",
                value: new DateTime(2025, 11, 27, 10, 35, 32, 316, DateTimeKind.Local).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "PostTime",
                value: new DateTime(2025, 11, 22, 10, 35, 32, 316, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "PostTime",
                value: new DateTime(2025, 11, 30, 10, 35, 32, 316, DateTimeKind.Local).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "PostTime",
                value: new DateTime(2025, 12, 1, 22, 35, 32, 316, DateTimeKind.Local).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "PostTime",
                value: new DateTime(2025, 11, 2, 10, 35, 32, 316, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "PostTime",
                value: new DateTime(2025, 11, 25, 10, 35, 32, 316, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.CreateIndex(
                name: "IX_ProfileFollowings_ProfileId",
                table: "ProfileFollowings",
                column: "ProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileFollowings_AspNetUsers_ProfileId",
                table: "ProfileFollowings",
                column: "ProfileId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
