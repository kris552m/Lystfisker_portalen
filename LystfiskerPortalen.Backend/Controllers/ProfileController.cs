using Microsoft.AspNetCore.Mvc;
using RazorClassLibrary;

namespace LystfiskerPortalen.Backend.Controllers
{
    public class ProfileController : Controller//, IProfileRepository
    {
        //private readonly IProfileRepository repository;
        public ProfileController(//IProfileRepository repository)
        {
            //this.repository = repository;
        }

        [HttpGet]
        [Route("/profile")]
        public Task<List<Profile>> GetAllAsync()
        {
            return //repository.GetAllAsync();
        }
        [HttpGet]
        [Route("/profile{id}")]
        public Task<Profile> GetByIdAsync(int id)
        {
            return //repository.GetByIdAsync();
        }
        [HttpPost]
        [Route("/profile")]
        public void AddAsync(Profile profile)
        {
            return //repository.CreateAsync();
        }
        [HttpPut]
        [Route("/profile")]
        public void ÚpdateAsync(Profile profile)
        {

            return //repository.UpdateAsync(profile);
        }
    }
}
