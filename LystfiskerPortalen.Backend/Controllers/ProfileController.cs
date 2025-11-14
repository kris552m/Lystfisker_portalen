using LystfiskerPortalen.Backend.Persistence;
using LystfiskerPortalen.ClassLibrary;
using Microsoft.AspNetCore.Mvc;

namespace LystfiskerPortalen.Backend.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileRepository repository;
        public ProfileController(IProfileRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Profile>>> GetAllAsync()
        {
            return Ok(await repository.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Profile?>> GetByIdAsync(int id)
        {
            if (id <= 0) return BadRequest();
            return Ok(await repository.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult> AddAsync(Profile profile)
        {
            var newProfil = await repository.AddAsync(profile);
            return CreatedAtAction("AddProfile", newProfil);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int Id)
        {
            var profileToDelete = repository.GetByIdAsync(Id);
            if (profileToDelete == null) 
            {
                return NotFound();
            }
            return Ok(repository?.DeleteAsync(profileToDelete.Id));
        }

        [HttpPut]
        public async Task<ActionResult> UpdateAsync(Profile profile)
        {
            return Ok(repository.UpdateAsync(profile));
        }
    }
}
