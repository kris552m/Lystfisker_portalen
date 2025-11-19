using LystfiskerPortalen.Backend.Data;
using LystfiskerPortalen.ClassLibrary;
using Microsoft.EntityFrameworkCore;

namespace LystfiskerPortalen.Persistence
{
    public class ProfileRepository : LystFiskerContext, IProfileRepository
    {
        private readonly LystFiskerContext context;
        public ProfileRepository(LystFiskerContext context, DbContextOptions<LystFiskerContext> options) : base(options)
        {
            this.context = context;
        }

        public async Task<Profile> AddAsync(Profile profile)
        {
            context.Profiles.Add(profile);
            context.SaveChanges();
            return profile;
        }

        public async Task DeleteAsync(int Id)
        {
            context.Profiles.Remove(await GetByIdAsync(Id));
            context.SaveChanges();
        }

        public async Task<List<Profile>> GetAllAsync()
        {
            return context.Profiles.ToList();
        }

        public async Task<Profile?> GetByIdAsync(int id)
        {
            return await context.Profiles.FindAsync(id);
        }

        public async Task UpdateAsync(Profile profile)
        {
            Profile profileToUpdate = await GetByIdAsync(profile.Id);
            if (profileToUpdate != null)
            {
                profileToUpdate.Username = profile.Username;
                profileToUpdate.Password = profile.Password;
                profileToUpdate.ProfilePicture = profile.ProfilePicture;
                profileToUpdate.Following = profile.Following;

                await context.SaveChangesAsync();
            }
        }
    }
}
