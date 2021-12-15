using Microsoft.AspNetCore.Mvc;
using Shoe_store.Storage;
using ShoeStore.Domains;

namespace Repozitory.Controllers
{
    [ApiController]
    [Route("/StoreAccount")]
    public class StoreAccountController : ControllerBase
    {
        [HttpPost("Create")]
        public void Create(StoreAccount storeAccount)
        {
            StoreAccountStorage.Create(storeAccount);
        }

        [HttpGet("Read")]
        public StoreAccount Read(int storeAccountId)
        {
            return StoreAccountStorage.Read(storeAccountId);
        }

        [HttpPut("Update")]
        public StoreAccount Update(int id, StoreAccount storeAccount)
        {
            return StoreAccountStorage.Update(id, storeAccount);
        }

        [HttpDelete("Delete")]
        public bool Delete(int storeAccountId)
        {
            return StoreAccountStorage.Delete(storeAccountId);
        }
    }
}