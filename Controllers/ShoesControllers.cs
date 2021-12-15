using Microsoft.AspNetCore.Mvc;
using Shoe_store.Storage;
using ShoeStore.Domains;

namespace Repozitory.Controllers
{
    [ApiController]
    [Route("/Shoes")]
    public class ShoeController : ControllerBase
    {
        [HttpPost("Create")]
        public void Create(Shoes shoes)
        {
            ShoesStorage.Create(shoes);
        }

        [HttpGet("Read")]
        public Shoes Read(int shoesId)
        {
            return ShoesStorage.Read(shoesId);
        }

        [HttpPut("Update")]
        public Shoes Update(int id, Shoes shoes)
        {
            return ShoesStorage.Update(id, shoes);
        }

        [HttpDelete("Delete")]
        public bool Delete(int shoesId)
        {
            return ShoesStorage.Delete(shoesId);
        }
    }
}