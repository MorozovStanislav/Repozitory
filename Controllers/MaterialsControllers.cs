using Microsoft.AspNetCore.Mvc;
using Shoe_store.Storage;
using ShoeStore.Domains;

namespace Repozitory.Controllers
{
    [ApiController]
    [Route("/Materials")]
    public class MaterialsController : ControllerBase
    {
        [HttpPost("Create")]
        public void Create(Materials materials)
        {
            MaterialsStorage.Create(materials);
        }

        [HttpGet("Read")]
        public Materials Read(int materialsId)
        {
            return MaterialsStorage.Read(materialsId);
        }

        [HttpPut("Update")]
        public Materials Update(int id, Materials materials)
        {
            return MaterialsStorage.Update(id, materials);
        }

        [HttpDelete("Delete")]
        public bool Delete(int materialsId)
        {
            return MaterialsStorage.Delete(materialsId);
        }
    }
}