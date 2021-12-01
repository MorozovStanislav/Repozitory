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
    [Route("/StoreAccount")]
    public class StoreAccountController : ControllerBase
    {
        [HttpPost("Create")]
        public void Create(StoreAccount storeAccount)
        {
            return Storage.StoreAccountStorage.Create(storeAccount);
        }

        [HttpGet("Read")]
        public StoreAccount Read(int storeAccountID)
        {
            return Storage.StoreAccountStorage.Read(storeAccountID);
        }

        [HttpPut("Update")]
        public StoreAccount Update(StoreAccount storeAccount)
        {
            return Storage.StoreAccountStorage.Update(storeAccount);
        }

        [HttpDelete("Delete")]
        public bool Delete(int storeAccountID)
        {
            return Storage.StoreAccountStorage.Delete(storeAccountID);
        }
    }
}