using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LystfiskerPortalen.Migrations
{
    /// <inheritdoc />
    public partial class dataseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "user-guid-1", 0, "7f7d5657-aa41-418a-a0ca-bcf08247c75e", "jens@lystfisker.dk", true, false, null, "JENS@LYSTFISKER.DK", "JENS@LYSTFISKER.DK", "AQAAAAIAAYagAAAAEOXkJ3o3fwGZlAX1LctSC4InVaLhUA7gp8gNnE8zV00FN1spF8jQIxNHnzlrotac4Q==", null, false, "https://example.com/jens.jpg", "151a58f1-accc-445a-9b97-cfb5b369aa67", false, "jens@lystfisker.dk" },
                    { "user-guid-2", 0, "7ba4fff5-3383-446e-909f-3b27ec13e896", "anne@lystfisker.dk", true, false, null, "ANNE@LYSTFISKER.DK", "ANNE@LYSTFISKER.DK", "AQAAAAIAAYagAAAAEKGhEbxs1qwTIn5kGEf92lE21S7QCVzVc/BIWf0Ba1uyIS6K8Q4tYWyCPkD4EyPcpQ==", null, false, "https://example.com/anne.jpg", "16aedb11-87ef-496b-846b-c4c013d46aa5", false, "anne@lystfisker.dk" },
                    { "user-guid-3", 0, "9b111ff6-01fd-4bae-a9f9-d93759ec4cea", "peter@lystfisker.dk", true, false, null, "PETER@LYSTFISKER.DK", "PETER@LYSTFISKER.DK", "AQAAAAIAAYagAAAAEPYetasqhyB75R52XVFFt6EgHmf5tyflHXCb/ZXjhp7Dixcjx7rOyFbAIrM5FxQNrg==", null, false, "https://example.com/peter.jpg", "84ecd1db-e3cf-4fa2-ae53-e37a910f9568", false, "peter@lystfisker.dk" }
                });

            migrationBuilder.InsertData(
                table: "Fishes",
                columns: new[] { "FishId", "Length", "Name", "Weight" },
                values: new object[,]
                {
                    { 1, 150, "Gedde", 20.0 },
                    { 2, 50, "Aborre", 2.5 },
                    { 3, 100, "Havørred", 15.0 },
                    { 4, 130, "Laks", 25.0 },
                    { 5, 120, "Torsk", 30.0 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "Latitude", "Longitude", "Name" },
                values: new object[,]
                {
                    { 1, 56.460500000000003, 9.9804999999999993, "Gudenåen" },
                    { 2, 56.0, 12.380000000000001, "Esrum Sø" },
                    { 3, 55.75, 12.666700000000001, "Øresund" },
                    { 4, 56.366700000000002, 8.6166999999999998, "Storeåen" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Description", "LocationId", "Picture", "PostTime", "ProfileId" },
                values: new object[,]
                {
                    { 1, "Sæsonstart ved Gudenåen! Vandstanden ser perfekt ud, og vejret er med os. Knæk og bræk til alle derude.", 1, "", new DateTime(2025, 11, 11, 12, 20, 37, 553, DateTimeKind.Local).AddTicks(8697), "user-guid-1" },
                    { 2, "Er der nogen der har erfaring med det nye Shimano hjul? Overvejer at købe det til kystfiskeri.", 3, "", new DateTime(2025, 11, 20, 12, 20, 37, 553, DateTimeKind.Local).AddTicks(8771), "user-guid-3" },
                    { 3, "Min første laks! Efter 3 dages forgæves fiskeri lykkedes det endelig.", 4, "laks.jpg", new DateTime(2025, 11, 15, 12, 20, 37, 556, DateTimeKind.Local).AddTicks(6678), "user-guid-1" },
                    { 4, "Stor gedde i Esrum. Tog denne madamme på en stor wobler. Den fik friheden igen efter billedet.", 2, "gedde.jpg", new DateTime(2025, 11, 23, 12, 20, 37, 556, DateTimeKind.Local).AddTicks(6751), "user-guid-2" },
                    { 5, "Aftentur efter torsk. Fik et par fine torsk med hjem til aftensmaden.", 3, "torsk.jpg", new DateTime(2025, 11, 25, 0, 20, 37, 556, DateTimeKind.Local).AddTicks(6954), "user-guid-3" },
                    { 6, "Kom og vær med til årets store geddekonkurrence på Esrum Sø. Fine præmier!", 2, "", new DateTime(2025, 10, 25, 12, 20, 37, 556, DateTimeKind.Local).AddTicks(7159), "user-guid-3" },
                    { 7, "Vi mødes ved broen og samler affald. Foreningen giver kaffe og kage bagefter.", 1, "", new DateTime(2025, 11, 18, 12, 20, 37, 556, DateTimeKind.Local).AddTicks(7174), "user-guid-1" }
                });

            migrationBuilder.InsertData(
                table: "Catches",
                columns: new[] { "PostId", "CatchTime", "FishId", "Lure", "Technique" },
                values: new object[,]
                {
                    { 3, new DateTime(2025, 11, 15, 10, 20, 37, 556, DateTimeKind.Local).AddTicks(6740), 4, "Spinner", "Spinnefiskeri" },
                    { 4, new DateTime(2025, 11, 23, 11, 20, 37, 556, DateTimeKind.Local).AddTicks(6755), 1, "Wobler", "Dørgning" },
                    { 5, new DateTime(2025, 11, 24, 22, 20, 37, 556, DateTimeKind.Local).AddTicks(6967), 5, "Pirk", "Pirkefiskeri" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "CommentTime", "PostId", "ProfileId", "Text" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 11, 16, 12, 20, 37, 556, DateTimeKind.Local).AddTicks(7316), 3, "user-guid-2", "Kæmpe tillykke Jens! Det er en drømmefisk." },
                    { 2, new DateTime(2025, 11, 16, 14, 20, 37, 556, DateTimeKind.Local).AddTicks(7327), 3, "user-guid-3", "Hvad tog den på? Flue eller spinner?" },
                    { 3, new DateTime(2025, 11, 24, 12, 20, 37, 556, DateTimeKind.Local).AddTicks(7332), 4, "user-guid-1", "Respekt for C&R! Flot fisk." },
                    { 4, new DateTime(2025, 11, 19, 12, 20, 37, 556, DateTimeKind.Local).AddTicks(7336), 7, "user-guid-2", "Jeg kommer helt sikkert!" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "PostId", "EventTime", "Title" },
                values: new object[,]
                {
                    { 6, new DateTime(2026, 1, 25, 12, 20, 37, 556, DateTimeKind.Local).AddTicks(7168), "Esrum Open 2025" },
                    { 7, new DateTime(2025, 12, 9, 12, 20, 37, 556, DateTimeKind.Local).AddTicks(7178), "Fælles oprydning ved Gudenåen" }
                });

            migrationBuilder.InsertData(
                table: "GeneralPosts",
                columns: new[] { "PostId", "IsQuestion" },
                values: new object[,]
                {
                    { 1, false },
                    { 2, true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Catches",
                keyColumn: "PostId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Catches",
                keyColumn: "PostId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Catches",
                keyColumn: "PostId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "PostId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "PostId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Fishes",
                keyColumn: "FishId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Fishes",
                keyColumn: "FishId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GeneralPosts",
                keyColumn: "PostId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GeneralPosts",
                keyColumn: "PostId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Fishes",
                keyColumn: "FishId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fishes",
                keyColumn: "FishId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Fishes",
                keyColumn: "FishId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-guid-1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-guid-2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-guid-3");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 4);
        }
    }
}
