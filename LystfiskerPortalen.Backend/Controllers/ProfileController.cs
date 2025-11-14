using LystfiskerPortalen.Backend.Persistence;
using LystfiskerPortalen.ClassLibrary;
using Microsoft.AspNetCore.Mvc;

namespace LystfiskerPortalen.Backend.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class ProfileController : ControllerBase, IProfileRepository
    {
        private readonly IProfileRepository repository;
        public ProfileController(IProfileRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<List<Profile>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<Profile?> GetByIdAsync(int id)
        {
            return await repository.GetByIdAsync(id);
        }

        [HttpPost]
        [Route("/Profile")]
        public async void AddAsync(Profile profile)
        {
            repository.AddAsync(profile);
        }

        [HttpDelete]
        [Route("/Profile{id}")]
        public async void DeleteAsync(int Id)
        {
            repository?.DeleteAsync(Id);
        }


        [HttpPut]
        [Route("/Profile")]
        public async void UpdateAsync(Profile profile)
        {
            repository.UpdateAsync(profile);
        }
    }
}
