using LystfiskerPortalen.Backend.Persistence;
using LystfiskerPortalen.ClassLibrary;
using Microsoft.AspNetCore.Mvc;

namespace LystfiskerPortalen.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase, IPostRepository
    {
        private readonly IPostRepository repository;
        public PostController(IPostRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<List<Post>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Post>> GetByIdAsync(int id)
        {
            return Ok(await repository.GetByIdAsync(id));
        }

        [HttpPost]
        public async void AddAsync(Post post)
        {
            repository.AddAsync(post);
        }

        [HttpDelete("{id}")]
        public async void DeleteAsync(int id)
        {

            repository.DeleteAsync(id);
        }

        [HttpPut("{id}")]
        public async void UpdateAsync(int id)
        {
            repository.UpdateAsync(id);
        }


        //api endpoint for get all comments and reactions (future task)
    }
}
