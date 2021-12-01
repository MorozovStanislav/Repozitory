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
    [Route("/MaterialWarehouse")]
    public class MaterialWarehouseController : ControllerBase
    {
        [HttpPost("Create")]
        public void Create(MaterialWarehouse materialWarehouse)
        {
            return Storage.MaterialWarehouseStorage.Create(materialWarehouse);
        }

        [HttpGet("Read")]
        public MaterialWarehouse Read(int materialWarehouseID)
        {
            return Storage.MaterialWarehouseStorage.Read(materialWarehouseID);
        }

        [HttpPut("Update")]
        public MaterialWarehouse Update(MaterialWarehouse materialWarehouse)
        {
            return Storage.MaterialWarehouseStorage.Update(materialWarehouse);
        }

        [HttpDelete("Delete")]
        public bool Delete(int materialWarehouseID)
        {
            return Storage.MaterialWarehouseStorage.Delete(materialWarehouseID);
        }
    }
}