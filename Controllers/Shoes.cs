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
    [Route("/Shoes")]
    public class ShoeController : ControllerBase
    {
        [HttpPost("Create")]
        public void Create(Shoes shoes)
        {
            return Storage.ShoesStorage.Create(shoes);
        }

        [HttpGet("Read")]
        public Shoes Read(int shoesID)
        {
            return Storage.ShoesStorage.Read(shoesID);
        }

        [HttpPut("Update")]
        public Shoes Update(Shoes shoes)
        {
            return Storage.ShoesStorage.Update(shoes);
        }

        [HttpDelete("Delete")]
        public bool Delete(int shoesID)
        {
            return Storage.ShoesStorage.Delete(shoesID);
        }
    }
}