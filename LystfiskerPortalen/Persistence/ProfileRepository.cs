using LystfiskerPortalen.Data;
using LystfiskerPortalen.Models;
using Microsoft.EntityFrameworkCore;

namespace LystfiskerPortalen.Persistence
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly LystFiskerContext _context;
        public ProfileRepository(LystFiskerContext context)
        {
            _context = context;
        }

        public async Task<Profile> AddAsync(Profile profile)
        {
            _context.Profiles.Add(profile);
            _context.SaveChanges();
            return profile;
        }

        public async Task DeleteAsync(int Id)
        {
            _context.Profiles.Remove(await GetByIdAsync(Id));
            _context.SaveChanges();
        }

        public async Task<List<Profile>> GetAllAsync()
        {
            return _context.Profiles.ToList();
        }

        public async Task<Profile?> GetByIdAsync(int id)
        {
            return await _context.Profiles.FindAsync(id);
        }

        public async Task UpdateAsync(Profile profile)
        {
            Profile profileToUpdate = await GetByIdAsync(int.Parse(profile.Id));
            if (profileToUpdate != null)
            {
                profileToUpdate.ProfilePicture = profile.ProfilePicture;
                profileToUpdate.Following = profile.Following;

                await _context.SaveChangesAsync();
            }
        }
    }
}
