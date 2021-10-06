using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Shoe_store.Controllers
{
    [ApiController]
    [Route("/Manager")]
    public class ManagerController : ControllerBase
    {

        [HttpPost("Purchasematerials")]
        public string Purchasematerials(string str)
        {
            return str; // Закупка материалов
        }
        [HttpPost("Acceptswishes")]
        public string Acceptswishes(string str)
        {
            return str;// Принимает пожелания
        }
        [HttpPost("Acceptsclaims")]
        public string Acceptsclaims(string str)
        {
            return str;// Принимает претензии
        }
        [HttpPost("Controlsproduction")]
        public string Controlsproduction(string str)
        {
            return str;// Контролирует производство
        }
    }
}

