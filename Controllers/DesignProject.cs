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
    [Route("/DesignProject")]
    public class DesignProjectController : ControllerBase
    {
        [HttpPost("Create")]
        public void Create(DesignProject designProject)
        {
            return Storage.DesignProjectStorage.Create(designProject);
        }

        [HttpGet("Read")]
        public DesignProject Read(int designProjectID)
        {
            return Storage.DesignProjectStorage.Read(designProjectID);
        }

        [HttpPut("Update")]
        public DesignProject Update(DesignProject designProject)
        {
            return Storage.DesignProjectStorage.Update(designProject);
        }

        [HttpDelete("Delete")]
        public bool Delete(int designProjectID)
        {
            return Storage.DesignProjectStorage.Delete(designProjectID);
        }
    }
}
