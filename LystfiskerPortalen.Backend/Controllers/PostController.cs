using LystfiskerPortalen.Backend.Persistence;
using LystfiskerPortalen.ClassLibrary;
using Microsoft.AspNetCore.Mvc;

namespace LystfiskerPortalen.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository repository;
        public PostController(IPostRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Post>>> GetAllAsync()
        {
            return Ok(await repository.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Post>> GetByIdAsync(int id)
        {
            if (id <= 0) return BadRequest();
            return Ok(await repository.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult> AddAsync(Post post)
        {
            var newPost = await repository.AddAsync(post);
            return CreatedAtAction("AddPost", newPost);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int Id)
        {
            var postToDelete = repository.GetByIdAsync(Id);
            if (postToDelete == null)
            {
                return NotFound();
            }
            return Ok(repository?.DeleteAsync(postToDelete.Id));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAsync(Post post)
        {

            return Ok(repository.UpdateAsync(post));
        }


        //api endpoint for get all comments and reactions (future task)
    }
}
