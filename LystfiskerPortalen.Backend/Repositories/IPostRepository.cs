using RazorClassLibrary;
namespace LystfiskerPortalen.Backend.Repositories
{
    public interface IPostRepository
    {
        Task<List<Post>> GetAllAsync();
        Task<Post> GetAsync(int id);
        Task AddAsync(Post post);
        Task<Post> UpdateAsync(Post post);
        Task DeleteAsync(int id);
    }
}
