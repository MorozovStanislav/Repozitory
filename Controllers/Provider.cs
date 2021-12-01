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
    [Route("/Provider")]
    public class ProviderController : ControllerBase
    {

        [HttpPost("SuppliesMaterials")]
        public string SuppliesMaterials(string str)
        {
            return str; // Поставка материалов
        }
        [HttpPost("SuppliesShoes")]
        public string SuppliesShoes(string str)
        {
            return str;// Поставка обуви
        }

        [HttpPost("Create")]
        public void Create(Provider provider)
        {
            return Storage.ProviderStorage.Create(provider);
        }

        [HttpGet("Read")]
        public Provider Read(int providerID)
        {
            return Storage.ProviderStorage.Read(providerID);
        }

        [HttpPut("Update")]
        public Provider Update(Provider provider)
        {
            return Storage.ProviderStorage.Update(provider);
        }

        [HttpDelete("Delete")]
        public bool Delete(int providerID)
        {
            return Storage.ProviderStorage.Delete(providerID);
        }
    }
}