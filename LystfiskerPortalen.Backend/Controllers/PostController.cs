using Microsoft.AspNetCore.Mvc;

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
        //    public void AddAsync(Profile profile)
        //    {
        //        return //repository.CreateAsync();
        //}

        //    [HttpPost]
        //    [Route("/profile")]
        //    public void AddAsync(Profile profile)
        //    {
        //        return //repository.CreateAsync();
        //}
        //    [HttpPut]
        //    [Route("/profile")]
        //    public void ÚpdateAsync(Profile profile)
        //    {

        //        return //repository.UpdateAsync(profile);
        //}


    }
}
