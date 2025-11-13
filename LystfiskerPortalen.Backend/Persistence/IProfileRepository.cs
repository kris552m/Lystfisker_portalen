using LystfiskerPortalen.ClassLibrary;

namespace LystfiskerPortalen.Backend.Persistence
{
    public interface IProfileRepository
    {
        public Task<List<Profile>> GetAllAsync();
        public Task<Profile?> GetByIdAsync(int id);
        public void AddAsync(Profile profile);
        public void DeleteAsync(int Id);
        public void UpdateAsync(Profile profile);
    }
}
