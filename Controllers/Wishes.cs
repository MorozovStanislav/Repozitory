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
    [Route("/Wishes")]
    public class WishesController : ControllerBase
    {
        [HttpPost("Create")]
        public void Create(Wishes wishes)
        {
            return Storage.WishesStorage.Create(wishes);
        }

        [HttpGet("Read")]
        public Wishes Read(int wishesID)
        {
            return Storage.WishesStorage.Read(wishesID);
        }

        [HttpPut("Update")]
        public Wishes Update(Wishes wishes)
        {
            return Storage.WishesStorage.Update(wishes);
        }

        [HttpDelete("Delete")]
        public bool Delete(int wishesID)
        {
            return Storage.WishesStorage.Delete(wishesID);
        }
    }
}