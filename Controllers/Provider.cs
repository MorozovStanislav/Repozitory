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

        [HttpPost("Suppliesmaterials")]
        public string Suppliesmaterials(string str)
        {
            return str; // Поставка материалов
        }
        [HttpPost("Suppliesshoes")]
        public string Suppliesshoes(string str)
        {
            return str;// Поставка обуви
        }
    }
}
