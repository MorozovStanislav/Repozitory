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
    [Route("/ShoeWarehouse")]
    public class ShoeWarehouseController : ControllerBase
    {
        [HttpPost("Create")]
        public void Create(ShoeWarehouse shoeWarehouse)
        {
            return Storage.ShoeWarehouseStorage.Create(shoeWarehouse);
        }

        [HttpGet("Read")]
        public ShoeWarehouse Read(int shoeWarehouseID)
        {
            return Storage.ShoeWarehouseStorage.Read(shoeWarehouseID);
        }

        [HttpPut("Update")]
        public ShoeWarehouse Update(ShoeWarehouse shoeWarehouse)
        {
            return Storage.ShoeWarehouseStorage.Update(shoeWarehouse);
        }

        [HttpDelete("Delete")]
        public bool Delete(int shoeWarehouseID)
        {
            return Storage.ShoeWarehouseStorage.Delete(shoeWarehouseID);
        }
    }
}