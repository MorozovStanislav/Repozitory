using Microsoft.AspNetCore.Mvc;
using Shoe_store.Storage;
using ShoeStore.Domains;

namespace Repozitory.Controllers
{
    [ApiController]
    [Route("/MaterialWarehouse")]
    public class MaterialWarehouseController : ControllerBase
    {
        [HttpPost("Create")]
        public void Create(MaterialWarehouse materialWarehouse)
        {
            MaterialWarehouseStorage.Create(materialWarehouse);
        }

        [HttpGet("Read")]
        public MaterialWarehouse Read(int materialWarehouseId)
        {
            return MaterialWarehouseStorage.Read(materialWarehouseId);
        }

        [HttpPut("Update")]
        public MaterialWarehouse Update(int id, MaterialWarehouse materialWarehouse)
        {
            return MaterialWarehouseStorage.Update(id, materialWarehouse);
        }

        [HttpDelete("Delete")]
        public bool Delete(int materialWarehouseId)
        {
            return MaterialWarehouseStorage.Delete(materialWarehouseId);
        }
    }
}