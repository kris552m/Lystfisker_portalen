using Microsoft.AspNetCore.Mvc;
using RazorClassLibrary;

namespace LystfiskerPortalen.Backend.Controllers
{
    public class PostController : Controller//, IPostRepository
    {
        //private readonly IPostRepository repository;

        public PostController(//IProfileRepository repository)
        {
            //this.repository = repository;
        }

        [HttpGet]
        [Route("/Post")]
        public Task<List<Post>> GetAllAsync()
        {
            return//repository.GetAllAsync();
        }
        [HttpGet]
        [Route("/Post{id}")]
        public Task<Post> GetByIdAsync(int id)
        {
            return//repository.GetByIdAsync();
        }

        [HttpPost]
        [Route("/post")]
        public void AddAsync(Post post)
        {
            return //repository.CreateAsync();
        }


        [HttpPut]
        [Route("/post")]
        public void ÚpdateAsync(Post post)
        {

            return //repository.UpdateAsync(profile);
        }
        [HttpDelete]
        [Route("/post")]
        public void DeleteAsync(int id)
        {

            return //repository.DeleteAsync(id);
        }


        //api endpoint for get all comments and reactions (future task)
    }
}
