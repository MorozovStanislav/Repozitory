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
    [Route("/MaterialOrders")]
    public class MaterialOrdersController : ControllerBase
    {
        [HttpPost("Create")]
        public void Create(MaterialOrders materialOrders)
        {
            return Storage.MaterialOrdersStorage.Create(materialOrders);
        }

        [HttpGet("Read")]
        public MaterialOrders Read(int materialOrdersID)
        {
            return Storage.MaterialOrdersStorage.Read(materialOrdersID);
        }

        [HttpPut("Update")]
        public MaterialOrders Update(MaterialOrders materialOrders)
        {
            return Storage.MaterialOrdersStorage.Update(materialOrders);
        }

        [HttpDelete("Delete")]
        public bool Delete(int materialOrdersID)
        {
            return Storage.MaterialOrdersStorage.Delete(materialOrdersID);
        }
    }
}