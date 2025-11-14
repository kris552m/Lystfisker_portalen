using LystfiskerPortalen.ClassLibrary;

namespace LystfiskerPortalen.Backend.Persistence
{
    public interface IPostRepository
    {
        public Task<List<Post>> GetAllAsync();
        public Task<Post?> GetByIdAsync(int id);
        public void AddAsync(Post post);
        public void DeleteAsync(int id);
        public void UpdateAsync(int id);
    }
}
