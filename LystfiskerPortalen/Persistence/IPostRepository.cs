
using LystfiskerPortalen.Models;

namespace LystfiskerPortalen.Persistence
{
    public interface IPostRepository
    {
        public Task<List<Post>> GetAllAsync();
        public Task<Post?> GetByIdAsync(int id);
        public Task<Post> AddAsync(Post post);
        public Task DeleteAsync(int id);
        public Task UpdateAsync(Post post);
    }
}
