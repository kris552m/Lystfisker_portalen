using LystfiskerPortalen.Data;
using LystfiskerPortalen.Models;
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
        public async Task CanAddProfileToRealDatabase()
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
        public async Task CanGetProfileThrowRepoToRealDatabase()
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
        public async Task CanAddGeneralPostToRealDatabase()
        {
            using var context = new LystFiskerContext(_options);
            //arrange get user from db
            var savedProfile = context.Users
            .Where(u => u.UserName == "testuser4")
            .Select(u => new { u.UserName, u.Email })

            .FirstOrDefault();

            // Act: add a GeneralPost
            var post = new GeneralPost
            {
                PostTime = DateTime.UtcNow,
                Description = "Integration test post",
                ProfileId = savedProfile.Id
            };
            context.Posts.Add(post);
            await context.SaveChangesAsync();

            // Assert: query back from the real DB
            var savedPost = context.Posts.Include(p => p.Profile).FirstOrDefault(p => p.Description == "Integration test post");

            Assert.IsNotNull(savedPost);
            Assert.AreEqual("testuser", savedPost.Profile.UserName);
        }

    }
}
