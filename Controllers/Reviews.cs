using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shoe_store.Domain;
using Shoe_store.Storage;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Shoe_store.Controllers
{
    [ApiController]
    [Route("/Reviews")]
    public class ReviewsController : ControllerBase
    {
        [HttpPost("Create")]
        public void Create(Reviews reviews)
        {
            return Storage.ReviewsStorage.Create(reviews);
        }

        [HttpGet("Read")]
        public Reviews Read(int reviewsID)
        {
            return Storage.ReviewsStorage.Read(reviewsID);
        }

        [HttpPut("Update")]
        public Reviews Update(Reviews reviews)
        {
            return Storage.ReviewsStorage.Update(reviews);
        }

        [HttpDelete("Delete")]
        public bool Delete(int reviewsID)
        {
            return Storage.ReviewsStorage.Delete(reviewsID);
        }
    }
}