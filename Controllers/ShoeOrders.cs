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
    [Route("/ShoeOrders")]
    public class ShoeOrdersController : ControllerBase
    {
        [HttpPost("Create")]
        public void Create(ShoeOrders shoeOrders)
        {
            return Storage.ShoeOrdersStorage.Create(shoeOrders);
        }

        [HttpGet("Read")]
        public ShoeOrders Read(int shoeOrdersID)
        {
            return Storage.ShoeOrdersStorage.Read(shoeOrdersID);
        }

        [HttpPut("Update")]
        public ShoeOrders Update(Customer shoeOrders)
        {
            return Storage.ShoeOrdersStorage.Update(shoeOrders);
        }

        [HttpDelete("Delete")]
        public bool Delete(int shoeOrdersID)
        {
            return Storage.ShoeOrdersStorage.Delete(shoeOrdersID);
        }
    }
}