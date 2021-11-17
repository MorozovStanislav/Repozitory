using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        [HttpPost]
        public string Create(string str)
        {
            return str;
        }

        [HttpGet]
        public string Read(string str)
        {
            return str;
        }

        [HttpPut]
        public string Update(string str)
        {
            return str;
        }

        [HttpDelete]
        public string Delete(string str)
        {
            return str;
        }
    }
}
