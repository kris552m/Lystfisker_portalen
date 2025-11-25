using LystfiskerPortalen.Data;
using LystfiskerPortalen.Models;
using LystfiskerPortalen.Persistence;
using Microsoft.EntityFrameworkCore;

namespace PostTests
{
    [TestClass]
    public class CrudPost
    {
        private DbContextOptions<LystFiskerContext> _options;

        [TestInitialize]
        public void Setup()
        {
            _options = new DbContextOptionsBuilder<LystFiskerContext>()
            .UseSqlServer("Server=.\\SQLEXPRESS;Database=LystFiskerDB;Trusted_Connection=True;TrustServerCertificate=True;")
            .Options;
        }
        [TestMethod]
        public async Task CanAddProfileToDatabase()
        {
            using var context = new LystFiskerContext(_options);
            // Arrange: create a profile
            var profile = new Profile
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "testuser4",
                Email = "test@example.com"
            };
            context.Users.Add(profile);
            await context.SaveChangesAsync();

            // Assert: query back from the real DB
            var savedProfile = context.Users
            .Where(u => u.UserName == "testuser4")
            .Select(u => new { u.UserName, u.Email })
            .FirstOrDefault();

            Assert.IsNotNull(savedProfile);
            Assert.AreEqual("testuser4", savedProfile.UserName);
        }


        [TestMethod]
        public async Task CanGetProfileThroughRepoFromDatabase()
        {
            using var context = new LystFiskerContext(_options);
            ProfileRepository Profilerepo = new ProfileRepository(context);


            // Assert: query back from the real DB
            var savedProfile = Profilerepo.GetById("acee7f97-286e-4f36-9186-607a8834aeac");

            Assert.IsNotNull(savedProfile);
            Assert.AreEqual("testuser4", savedProfile.UserName);
        }

        [TestMethod]
        public async Task CanAddLocationToDB()
        {
            //Arrange
            using var context = new LystFiskerContext(_options);
            var location = new Location
            {
                Name = "TestLocation",
                Latitude = 10.21,
                Longitude = 10.20,

            };
            //Act
            context.Locations.Add(location);
            await context.SaveChangesAsync();

            var savedLocation = context.Locations.Find(location.LocationId);

            //Assert
            Assert.IsNotNull(savedLocation);
            Assert.AreEqual("TestLocation", savedLocation.Name);
        }

        [TestMethod]
        public async Task CanAddGeneralPostRepoToDatabase()
        {
            using var context = new LystFiskerContext(_options);
            PostRepository Postrepo = new PostRepository(context);

            //arrange get user from db
            var savedProfile = context.Users.Find("fb34823d-803e-48fb-b353-64934a3272d3");

            // Act: add a GeneralPost
            var post = new GeneralPost
            {
                PostTime = DateTime.UtcNow,
                Description = "Integration test post",
                Location = context.Locations.Find(1),
                ProfileId = savedProfile.Id,
                IsQuestion = true,

            };
            Postrepo.Add(post);
            await context.SaveChangesAsync();

            // Assert: query back from the real DB
            var savedPost = Postrepo.GetById(post.PostId);

            Assert.IsNotNull(savedPost);
            Assert.AreEqual("testuser4", savedPost.Profile.UserName);
        }

    }
}
