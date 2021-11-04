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

        [HttpPost("PurchaseMaterials")]
        public string PurchaseMaterials(string str)
        {
            return str; // Закупка материалов
        }
        [HttpPost("AcceptsWishes")]
        public string AcceptsWishes(string str)
        {
            return str;// Принимает пожелания
        }
        [HttpPost("AcceptsClaims")]
        public string AcceptsClaims(string str)
        {
            return str;// Принимает претензии
        }
        [HttpPost("ControlsProduction")]
        public string ControlsProduction(string str)
        {
            return str;// Контролирует производство
        }
    }
}

