using Microsoft.AspNetCore.Mvc;
using Shoe_store.Storage;
using ShoeStore.Domains;

namespace Repozitory.Controllers
{
    [ApiController]
    [Route("/Reviews")]
    public class ReviewsController : ControllerBase
    {
        [HttpPost("Create")]
        public void Create(Reviews reviews)
        {
            ReviewsStorage.Create(reviews);
        }

        [HttpGet("Read")]
        public Reviews Read(int reviewsId)
        {
            return ReviewsStorage.Read(reviewsId);
        }

        [HttpPut("Update")]
        public Reviews Update(int id, Reviews reviews)
        {
            return ReviewsStorage.Update(id, reviews);
        }

        [HttpDelete("Delete")]
        public bool Delete(int reviewsId)
        {
            return ReviewsStorage.Delete(reviewsId);
        }
    }
}