
using LystfiskerPortalen.Models;

namespace LystfiskerPortalen.Persistence
{
    public interface IProfileRepository
    {
        public List<Profile> GetAll();
        public Profile? GetById(string id);
        public Profile Add(Profile profile);
        public void Delete(string Id);
        public void Update(Profile profile);
    }
}
