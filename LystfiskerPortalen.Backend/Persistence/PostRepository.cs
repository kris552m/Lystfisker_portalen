using LystfiskerPortalen.Backend.Data;
using LystfiskerPortalen.ClassLibrary;
using Microsoft.EntityFrameworkCore;

namespace LystfiskerPortalen.Backend.Persistence
{
    public class PostRepository : LystFiskerContext, IPostRepository
    {
        private readonly LystFiskerContext context;
        public PostRepository(LystFiskerContext context, DbContextOptions<LystFiskerContext> options) : base(options)
        {

            this.context = context;
        }
        public async Task<Post> AddAsync(Post post)
        {
            context.Posts.Add(post);
            context.SaveChanges();
            return post;
        }

        public async Task DeleteAsync(int Id)
        {
            context.Posts.Remove(await GetByIdAsync(Id));
            context.SaveChanges();
        }

        public async Task<List<Post>> GetAllAsync()
        {
            return context.Posts.Include(p => p.Comments).ToList();
        }

        public async Task<Post?> GetByIdAsync(int id)
        {
            return await context.Posts.FindAsync(id);
        }

        public async Task UpdateAsync(Post post)
        {
            Post postToUpdate = await GetByIdAsync(post.Id);
            if (postToUpdate != null)
            {
                postToUpdate.Picture = post.Picture;
                postToUpdate.Reactions = post.Reactions;
                postToUpdate.Comments = post.Comments;
                postToUpdate.PostTime = post.PostTime;
                postToUpdate.Description = post.Description;
                postToUpdate.Location = post.Location;

                await context.SaveChangesAsync();

            }
        }
    }
}
