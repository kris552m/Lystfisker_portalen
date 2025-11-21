
using LystfiskerPortalen.Models;

namespace LystfiskerPortalen.Persistence
{
    public interface IProfileRepository
    {
        public List<Profile> GetAll();
        public Profile? GetById(int id);
        public Profile Add(Profile profile);
        public void Delete(int Id);
        public void Update(Profile profile);
    }
}
