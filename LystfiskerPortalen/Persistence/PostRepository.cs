using LystfiskerPortalen.Data;
using LystfiskerPortalen.Models;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;


namespace LystfiskerPortalen.Persistence
{
    public class PostRepository : IPostRepository
    {
        private readonly LystFiskerContext context;
        public PostRepository(LystFiskerContext context)
        {

            this.context = context;
        }
        public Post Add(Post post)
        {

            context.Posts.Add(post);
            context.SaveChanges();
            return post;
        }

        public void Delete(int Id)
        {
            context.Posts.Remove(GetById(Id));
            context.SaveChanges();
        }

        public List<Post> GetAll()
        {
            return context.Posts.ToList();
            return context.Posts
            .Include(p => p.Location)
            .Include(p => p.Profile)
            .Include(p => p.Comments)
            .ThenInclude(c => c.Profile)
            .ThenInclude(c => c.Reactions)
            .Include(p => p.Reactions)
            .Include(p => p.Pictures).ToList();
        }

        public Post? GetById(int id)
        {
            return context.Posts.Find(id);
        }

        public void Update(Post post)
        {
            Post postToUpdate = GetById(post.PostId);
            if (postToUpdate != null)
            {
                postToUpdate.Pictures = post.Pictures;
                postToUpdate.Reactions = post.Reactions;
                postToUpdate.Comments = post.Comments;
                postToUpdate.PostTime = post.PostTime;
                postToUpdate.Description = post.Description;
                postToUpdate.Location = post.Location;

                context.SaveChanges();

            }
        }

        // Added method to get posts by profile ID with related data included and ordered by post time descending 
        public async Task<List<Post>> GetPostsByProfileIdAsync(string profileId)
        {
            return await context.Posts
               .AsNoTracking()
               .Where(p => p.ProfileId == profileId)
               .Include(p => p.Comments).ThenInclude(c => c.Profile)
               .Include(p => p.Reactions)
               .Include(p => p.Location)
               .OrderByDescending(p => p.PostTime)
               .ToListAsync();
        }

    }
}
