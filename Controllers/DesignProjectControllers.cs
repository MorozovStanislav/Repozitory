using Microsoft.AspNetCore.Mvc;
using Shoe_store.Storage;
using ShoeStore.Domains;

namespace Repozitory.Controllers
{
    [ApiController]
    [Route("/DesignProject")]
    public class DesignProjectController : ControllerBase
    {
        [HttpPost("Create")]
        public void Create(DesignProject designProject)
        {
            DesignProjectStorage.Create(designProject);
        }

        [HttpGet("Read")]
        public DesignProject Read(int designProjectId)
        {
            return DesignProjectStorage.Read(designProjectId);
        }

        [HttpPut("Update")]
        public DesignProject Update(int id, DesignProject designProject)
        {
            return DesignProjectStorage.Update(id, designProject);
        }

        [HttpDelete("Delete")]
        public bool Delete(int designProjectId)
        {
            return DesignProjectStorage.Delete(designProjectId);
        }
    }
}
