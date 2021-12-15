using Microsoft.AspNetCore.Mvc;
using Shoe_store.Storage;
using ShoeStore.Domains;

namespace Repozitory.Controllers
{
    [ApiController]
    [Route("/ShoeOrders")]
    public class ShoeOrdersController : ControllerBase
    {
        [HttpPost("Create")]
        public void Create(ShoeOrders shoeOrders)
        {
            ShoeOrdersStorage.Create(shoeOrders);
        }

        [HttpGet("Read")]
        public ShoeOrders Read(int shoeOrdersId)
        {
            return ShoeOrdersStorage.Read(shoeOrdersId);
        }

        [HttpPut("Update")]
        public ShoeOrders Update(int id, ShoeOrders shoeOrders)
        {
            return ShoeOrdersStorage.Update(id, shoeOrders);
        }

        [HttpDelete("Delete")]
        public bool Delete(int shoeOrdersId)
        {
            return ShoeOrdersStorage.Delete(shoeOrdersId);
        }
    }
}