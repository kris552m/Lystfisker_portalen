using LystfiskerPortalen.Backend.Persistence;
using LystfiskerPortalen.ClassLibrary;
using Microsoft.AspNetCore.Mvc;

namespace LystfiskerPortalen.Backend.Controllers
{
    public class PostController : Controller, IPostRepository
    {
        private readonly IPostRepository repository;

        public PostController(IPostRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        [Route("/Post")]
        public Task<List<Post>> GetAllAsync()
        {
            return repository.GetAllAsync();
        }
        [HttpGet]
        [Route("/Post{id}")]
        public Task<Post> GetByIdAsync(int id)
        {
            return repository.GetByIdAsync(id);
        }

        [HttpPost]
        [Route("/post")]
        public void AddAsync(Post post)
        {
            repository.AddAsync(post);
        }


        [HttpPut]
        [Route("/post")]
        public void UpdateAsync(Post post)
        {

            repository.UpdateAsync(post);
        }
        [HttpDelete]
        [Route("/post")]
        public void DeleteAsync(int id)
        {

            repository.DeleteAsync(id);
        }


        //api endpoint for get all comments and reactions (future task)
    }
}
