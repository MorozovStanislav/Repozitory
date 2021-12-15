using Microsoft.AspNetCore.Mvc;
using Shoe_store.Storage;
using ShoeStore.Domains;

namespace Repozitory.Controllers
{
    [ApiController]
    [Route("/Wishes")]
    public class WishesController : ControllerBase
    {
        [HttpPost("Create")]
        public void Create(Wishes wishes)
        {
            WishesStorage.Create(wishes);
        }

        [HttpGet("Read")]
        public Wishes Read(int wishesId)
        {
            return WishesStorage.Read(wishesId);
        }

        [HttpPut("Update")]
        public Wishes Update(int id, Wishes wishes)
        {
            return WishesStorage.Update(id, wishes);
        }

        [HttpDelete("Delete")]
        public bool Delete(int wishesId)
        {
            return WishesStorage.Delete(wishesId);
        }
    }
}