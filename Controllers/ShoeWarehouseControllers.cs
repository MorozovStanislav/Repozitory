using Microsoft.AspNetCore.Mvc;
using Shoe_store.Storage;
using ShoeStore.Domains;

namespace Repozitory.Controllers
{
    [ApiController]
    [Route("/ShoeWarehouse")]
    public class ShoeWarehouseController : ControllerBase
    {
        [HttpPost("Create")]
        public void Create(ShoeWarehouse shoeWarehouse)
        {
           ShoeWarehouseStorage.Create(shoeWarehouse);
        }

        [HttpGet("Read")]
        public ShoeWarehouse Read(int shoeWarehouseId)
        {
            return ShoeWarehouseStorage.Read(shoeWarehouseId);
        }

        [HttpPut("Update")]
        public ShoeWarehouse Update(int id, ShoeWarehouse shoeWarehouse)
        {
            return ShoeWarehouseStorage.Update(id, shoeWarehouse);
        }

        [HttpDelete("Delete")]
        public bool Delete(int shoeWarehouseId)
        {
            return ShoeWarehouseStorage.Delete(shoeWarehouseId);
        }
    }
}