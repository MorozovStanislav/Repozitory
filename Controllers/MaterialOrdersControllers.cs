using Microsoft.AspNetCore.Mvc;
using Shoe_store.Storage;
using ShoeStore.Domains;

namespace Repozitory.Controllers
{
    [ApiController]
    [Route("/MaterialOrders")]
    public class MaterialOrdersController : ControllerBase
    {
        [HttpPost("Create")]
        public void Create(MaterialOrders materialOrders)
        {
            MaterialOrdersStorage.Create(materialOrders);
        }

        [HttpGet("Read")]
        public MaterialOrders Read(int materialOrdersId)
        {
            return MaterialOrdersStorage.Read(materialOrdersId);
        }

        [HttpPut("Update")]
        public MaterialOrders Update(int id, MaterialOrders materialOrders)
        {
            return MaterialOrdersStorage.Update(id, materialOrders);
        }

        [HttpDelete("Delete")]
        public bool Delete(int materialOrdersId)
        {
            return MaterialOrdersStorage.Delete(materialOrdersId);
        }
    }
}