using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Shoe_store.Controllers
{
    [ApiController]
    [Route("/Customer")]
    public class CustomerController : ControllerBase
    {

        [HttpPost("Ordersshoes")]
        public string OrdersShoes(string str)
        {
            return str; // Заказывает обувь
        }
        [HttpPost("ExpressesWishes")]
        public string Expresseswishes(string str)
        {
            return str;// Высказывает пожелания
        }
        [HttpPost("ExpressesClaims")]
        public string Expressesclaims(string str)
        {
            return str;// Высказывает претензии
        }
    }
}

