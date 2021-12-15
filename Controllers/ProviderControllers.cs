using Microsoft.AspNetCore.Mvc;
using Shoe_store.Storage;
using ShoeStore.Domains;

namespace Repozitory.Controllers
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
            ProviderStorage.Create(provider);
        }

        [HttpGet("Read")]
        public Provider Read(int providerId)
        {
            return ProviderStorage.Read(providerId);
        }

        [HttpPut("Update")]
        public Provider Update(int id, Provider provider)
        {
            return ProviderStorage.Update(id, provider);
        }

        [HttpDelete("Delete")]
        public bool Delete(int providerId)
        {
            return ProviderStorage.Delete(providerId);
        }
    }
}