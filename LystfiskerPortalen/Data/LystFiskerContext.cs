using LystfiskerPortalen.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LystfiskerPortalen.Data
{
    public class LystFiskerContext : IdentityDbContext<Profile>
    {
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Catch> Catches { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Fish> Fishes { get; set; }
        public DbSet<GeneralPost> GeneralPosts { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Reaction> Reactions { get; set; }
        public LystFiskerContext(DbContextOptions options) : base(options)
        {
        }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Post>().UseTptMappingStrategy();

            modelBuilder.Entity<Post>()
               .HasMany(p => p.Comments)
               .WithOne(c => c.Post)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Post>()
                .HasMany(p => p.Reactions)
                .WithOne(r => r.Post)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Post>()
                .HasOne(p => p.Location)
                .WithMany(l => l.Posts)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Comment>()
                .HasMany(c => c.Reactions)
                .WithMany(r => r.Comments)
                .UsingEntity(j => j.ToTable("CommentReactions"));

            modelBuilder.Entity<Profile>()
                .HasMany(p => p.Posts)
                .WithOne(post => post.Profile)
                .HasForeignKey(post => post.ProfileId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Profile>()
                .HasMany(p => p.Comments)
                .WithOne(c => c.Profile)
                .HasForeignKey(c => c.ProfileId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Profile>()
                .HasMany(p => p.Reactions)
                .WithOne(r => r.Profile)
                .HasForeignKey(r => r.ProfileId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Profile>()
                .HasMany(p => p.Following)
                .WithMany()
                .UsingEntity(j => j.ToTable("ProfileFollowings"));

        }

    }
}