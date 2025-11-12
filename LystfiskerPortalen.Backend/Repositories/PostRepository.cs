using RazorClassLibrary;

namespace LystfiskerPortalen.Backend.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly LystFiskerContext _context;
        public PostRepository(LystFiskerContext context)
        {
            _context = context;
        }
        public Task AddAsync(Post post)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Post>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Post> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Post> UpdateAsync(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
