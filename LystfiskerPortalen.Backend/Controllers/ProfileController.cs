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

        [HttpPost]
        [Route("/Profile")]
        public void AddAsync(Profile profile)
        {
            repository.AddAsync(profile);
        }

        [HttpDelete]
        [Route("/Profile{id}")]
        public void DeleteAsync(int Id)
        {
            repository?.DeleteAsync(Id);
        }

        [HttpGet]
        [Route("/Profile")]
        public Task<List<Profile>> GetAllAsync()
        {
            return repository.GetAllAsync();
        }
        [HttpGet]
        [Route("/Profile{id}")]
        public Task<Profile?> GetByIdAsync(int id)
        {
            return repository.GetByIdAsync(id);
        }

        [HttpPut]
        [Route("/Profile")]
        public void UpdateAsync(Profile profile)
        {
            repository.UpdateAsync(profile);
        }
    }
}
