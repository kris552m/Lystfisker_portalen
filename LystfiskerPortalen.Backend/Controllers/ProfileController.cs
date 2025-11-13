using LystfiskerPortalen.Backend.Persistence;
using LystfiskerPortalen.ClassLibrary;
using Microsoft.AspNetCore.Mvc;

namespace LystfiskerPortalen.Backend.Controllers
{
    public class ProfileController : Controller, IProfileRepository
    {
        private readonly IProfileRepository repository;
        public ProfileController(IProfileRepository repository)
        {
            this.repository = repository;
        }
        public void AddAsync(Profile profile)
        {
            repository.AddAsync(profile);
        }

        public void DeleteAsync(int Id)
        {
            repository?.DeleteAsync(Id);
        }

        public Task<List<Profile>> GetAllAsync()
        {
            return repository.GetAllAsync();
        }

        public Task<Profile?> GetByIdAsync(int id)
        {
            return repository.GetByIdAsync(id);
        }

        public void UpdateAsync(Profile profile)
        {
            repository.UpdateAsync(profile);
        }
    }
}
