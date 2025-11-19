
using LystfiskerPortalen.Models;

namespace LystfiskerPortalen.Persistence
{
    public interface IProfileRepository
    {
        public Task<List<Profile>> GetAllAsync();
        public Task<Profile?> GetByIdAsync(int id);
        public Task<Profile> AddAsync(Profile profile);
        public Task DeleteAsync(int Id);
        public Task UpdateAsync(Profile profile);
    }
}
