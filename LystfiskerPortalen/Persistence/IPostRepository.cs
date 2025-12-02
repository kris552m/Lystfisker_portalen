
using LystfiskerPortalen.Models;

namespace LystfiskerPortalen.Persistence
{
    public interface IPostRepository
    {
        public List<Post> GetAll();
        public Post? GetById(int id);
        public Post Add(Post post);
        public void Delete(int id);
        public void Update(Post post);
        Task<List<Post>> GetPostsByProfileIdAsync(string profileId);



    }
}
