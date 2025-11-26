using LystfiskerPortalen.Data;
using LystfiskerPortalen.Models;

namespace LystfiskerPortalen.Persistence
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly LystFiskerContext _context;
        public ProfileRepository(LystFiskerContext context)
        {
            _context = context;
        }

        public Profile Add(Profile profile)
        {
            _context.Profiles.Add(profile);
            _context.SaveChanges();
            return profile;
        }

        public void Delete(string Id)
        {
            _context.Profiles.Remove(GetById(Id));
            _context.SaveChanges();
        }

        public List<Profile> GetAll()
        {
            return _context.Profiles.ToList();
        }

        public Profile? GetById(string id)
        {
            return _context.Profiles.Find(id);
        }

        public void Update(Profile profile)
        {
            Profile profileToUpdate = GetById(profile.Id);
            if (profileToUpdate != null)
            {
                profileToUpdate.ProfilePicture = profile.ProfilePicture;
                profileToUpdate.Following = profile.Following;

                _context.SaveChanges();
            }
        }
    }
}
