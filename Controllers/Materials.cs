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
    [Route("/Materials")]
    public class MaterialsController : ControllerBase
    {
        [HttpPost("Create")]
        public void Create(Materials materials)
        {
            return Storage.MaterialsStorage.Create(materials);
        }

        [HttpGet("Read")]
        public Materials Read(int materialsID)
        {
            return Storage.MaterialsStorage.Read(materialsID);
        }

        [HttpPut("Update")]
        public Materials Update(Materials materials)
        {
            return Storage.MaterialsStorage.Update(materials);
        }

        [HttpDelete("Delete")]
        public bool Delete(int materialsID)
        {
            return Storage.MaterialsStorage.Delete(materialsID);
        }
    }
}