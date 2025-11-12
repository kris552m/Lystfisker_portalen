using LystfiskerPortalen.ClassLibrary;
using Microsoft.EntityFrameworkCore;

namespace LystfiskerPortalen.Backend.Data
{
    public class LystFiskerContext : DbContext
    {
        public DbSet<Catch> Catches { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Fish> Fishes { get; set; }
        public DbSet<GeneralPost> GeneralPosts { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Reaction> Reactions { get; set; }
        public LystFiskerContext(DbContextOptions<LystFiskerContext> options)
            : base(options)
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



        }

    }
}