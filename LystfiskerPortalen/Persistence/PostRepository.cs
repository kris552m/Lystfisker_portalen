using LystfiskerPortalen.Data;
using LystfiskerPortalen.Models;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;


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
            return context.Posts
            .Include(p => p.Comments)
            .ThenInclude(c => c.Profile)
            .ThenInclude(c => c.Reactions)
            .Include(p => p.Reactions).ToList();
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
                postToUpdate.Images = post.Images;
                postToUpdate.Reactions = post.Reactions;
                postToUpdate.Comments = post.Comments;
                postToUpdate.PostTime = post.PostTime;
                postToUpdate.Description = post.Description;
                postToUpdate.Location = post.Location;

                context.SaveChanges();

            }
        }
    }
}
