using System;
using LystfiskerPortalen.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LystfiskerPortalen.Data
{
    public static class DataSeeding
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // 1. Seed Locations
            modelBuilder.Entity<Location>().HasData(
                new Location { LocationId = 1, Name = "Gudenåen", Latitude = 56.4605, Longitude = 9.9805 },
                new Location { LocationId = 2, Name = "Esrum Sø", Latitude = 56.0000, Longitude = 12.3800 },
                new Location { LocationId = 3, Name = "Øresund", Latitude = 55.7500, Longitude = 12.6667 },
                new Location { LocationId = 4, Name = "Storeåen", Latitude = 56.3667, Longitude = 8.6167 }
            );

            // 2. Seed Fish
            modelBuilder.Entity<Fish>().HasData(
                new Fish { FishId = 1, Name = "Gedde", Length = 150, Weight = 20.0 },
                new Fish { FishId = 2, Name = "Aborre", Length = 50, Weight = 2.5 },
                new Fish { FishId = 3, Name = "Havørred", Length = 100, Weight = 15.0 },
                new Fish { FishId = 4, Name = "Laks", Length = 130, Weight = 25.0 },
                new Fish { FishId = 5, Name = "Torsk", Length = 120, Weight = 30.0 }
            );

            // 3. Seed Profiles (IdentityUser)
            var hasher = new PasswordHasher<Profile>();

            var user1 = new Profile
            {
                Id = "user-guid-1",
                UserName = "jens@lystfisker.dk",
                NormalizedUserName = "JENS@LYSTFISKER.DK",
                Email = "jens@lystfisker.dk",
                NormalizedEmail = "JENS@LYSTFISKER.DK",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ProfilePicture = "https://example.com/jens.jpg"
            };
            user1.PasswordHash = hasher.HashPassword(user1, "Fiske123!");

            var user2 = new Profile
            {
                Id = "user-guid-2",
                UserName = "anne@lystfisker.dk",
                NormalizedUserName = "ANNE@LYSTFISKER.DK",
                Email = "anne@lystfisker.dk",
                NormalizedEmail = "ANNE@LYSTFISKER.DK",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ProfilePicture = "https://example.com/anne.jpg"
            };
            user2.PasswordHash = hasher.HashPassword(user2, "Fiske123!");

            var user3 = new Profile
            {
                Id = "user-guid-3",
                UserName = "peter@lystfisker.dk",
                NormalizedUserName = "PETER@LYSTFISKER.DK",
                Email = "peter@lystfisker.dk",
                NormalizedEmail = "PETER@LYSTFISKER.DK",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ProfilePicture = "https://example.com/peter.jpg"
            };
            user3.PasswordHash = hasher.HashPassword(user3, "Fiske123!");

            modelBuilder.Entity<Profile>().HasData(user1, user2, user3);

            // 4. Seed Posts
            
            // General Posts
            modelBuilder.Entity<GeneralPost>().HasData(
                new 
                {
                    PostId = 1,
                    PostTime = DateTime.Now.AddDays(-14),
                    Description = "Sæsonstart ved Gudenåen! Vandstanden ser perfekt ud, og vejret er med os. Knæk og bræk til alle derude.",
                    Picture = "",
                    ProfileId = "user-guid-1",
                    LocationId = 1,
                    IsQuestion = false
                },
                new 
                {
                    PostId = 2,
                    PostTime = DateTime.Now.AddDays(-5),
                    Description = "Er der nogen der har erfaring med det nye Shimano hjul? Overvejer at købe det til kystfiskeri.",
                    Picture = "",
                    ProfileId = "user-guid-3",
                    LocationId = 3,
                    IsQuestion = true
                }
            );

            // Catches (Fangster)
            modelBuilder.Entity<Catch>().HasData(
                new 
                {
                    PostId = 3,
                    PostTime = DateTime.Now.AddDays(-10),
                    Description = "Min første laks! Efter 3 dages forgæves fiskeri lykkedes det endelig.",
                    Picture = "laks.jpg",
                    ProfileId = "user-guid-1",
                    LocationId = (int?)4, // Storeåen
                    FishId = 4,    // Laks
                    CatchTime = DateTime.Now.AddDays(-10).AddHours(-2),
                    Lure = "Spinner",
                    Technique = "Spinnefiskeri"
                },
                new 
                {
                    PostId = 4,
                    PostTime = DateTime.Now.AddDays(-2),
                    Description = "Stor gedde i Esrum. Tog denne madamme på en stor wobler. Den fik friheden igen efter billedet.",
                    Picture = "gedde.jpg",
                    ProfileId = "user-guid-2",
                    LocationId = (int?)2, // Esrum Sø
                    FishId = 1,    // Gedde
                    CatchTime = DateTime.Now.AddDays(-2).AddHours(-1),
                    Lure = "Wobler",
                    Technique = "Dørgning"
                },
                new 
                {
                    PostId = 5,
                    PostTime = DateTime.Now.AddHours(-12),
                    Description = "Aftentur efter torsk. Fik et par fine torsk med hjem til aftensmaden.",
                    Picture = "torsk.jpg",
                    ProfileId = "user-guid-3",
                    LocationId = (int?)3, // Øresund
                    FishId = 5,    // Torsk
                    CatchTime = DateTime.Now.AddHours(-14),
                    Lure = "Pirk",
                    Technique = "Pirkefiskeri"
                }
            );

            // Events
            modelBuilder.Entity<Event>().HasData(
                new 
                {
                    PostId = 6,
                    PostTime = DateTime.Now.AddMonths(-1),
                    Description = "Kom og vær med til årets store geddekonkurrence på Esrum Sø. Fine præmier!",
                    Title = "Esrum Open 2025",
                    Picture = "",
                    ProfileId = "user-guid-3",
                    LocationId = (int?)2,
                    EventTime = DateTime.Now.AddMonths(2)
                },
                new 
                {
                    PostId = 7,
                    PostTime = DateTime.Now.AddDays(-7),
                    Description = "Vi mødes ved broen og samler affald. Foreningen giver kaffe og kage bagefter.",
                    Title = "Fælles oprydning ved Gudenåen",
                    Picture = "",
                    ProfileId = "user-guid-1",
                    LocationId = (int?)1,
                    EventTime = DateTime.Now.AddDays(14)
                }
            );

            // 5. Seed Comments
            modelBuilder.Entity<Comment>().HasData(
                new Comment
                {
                    CommentId = 1,
                    Text = "Kæmpe tillykke Jens! Det er en drømmefisk.",
                    CommentTime = DateTime.Now.AddDays(-9),
                    ProfileId = "user-guid-2",
                    PostId = 3 // The Salmon catch
                },
                new Comment
                {
                    CommentId = 2,
                    Text = "Hvad tog den på? Flue eller spinner?",
                    CommentTime = DateTime.Now.AddDays(-9).AddHours(2),
                    ProfileId = "user-guid-3",
                    PostId = 3 // The Salmon catch
                },
                new Comment
                {
                    CommentId = 3,
                    Text = "Respekt for C&R! Flot fisk.",
                    CommentTime = DateTime.Now.AddDays(-1),
                    ProfileId = "user-guid-1",
                    PostId = 4 // The Pike catch
                },
                new Comment
                {
                    CommentId = 4,
                    Text = "Jeg kommer helt sikkert!",
                    CommentTime = DateTime.Now.AddDays(-6),
                    ProfileId = "user-guid-2",
                    PostId = 7 // The Cleanup event
                }
            );
        }
    }
}
