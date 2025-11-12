using LystfiskerPortalen.Backend.Persistence;
using Microsoft.AspNetCore.Mvc;
using RazorClassLibrary;

namespace LystfiskerPortalen.Backend.Controllers
{
    public class ProfileController : Controller, IProfileRepository
    {
        public void AddAsync(Profile profile)
        {
            throw new NotImplementedException();
        }

        public void DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Profile>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Profile?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateAsync(Profile profile)
        {
            throw new NotImplementedException();
        }
    }
}
