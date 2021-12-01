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
    [Route("/Customer")]
    public class CustomerController : ControllerBase
    {

        [HttpPost("OrdersShoes")]
        public string OrdersShoes(string str)
        {
            return str; // Заказывает обувь
        }
        [HttpPost("ExpressesWishes")]
        public string ExpressesWishes(string str)
        {
            return str;// Высказывает пожелания
        }
        [HttpPost("ExpressesClaims")]
        public string ExpressesClaims(string str)
        {
            return str;// Высказывает претензии
        }

        [HttpPost("Create")]
        public void Create(Customer customer)
        {
            return Storage.CustomerStorage.Create(customer);
        }

        [HttpGet("Read")]
        public Customer Read(int customerID)
        {
            return Storage.CustomerStorage.Read(customerID);
        }

        [HttpPut("Update")]
        public Customer Update(Customer customer)
        {
            return Storage.CustomerStorage.Update(customer);
        }

        [HttpDelete("Delete")]
        public bool Delete(int customerID)
        {
            return Storage.CustomerStorage.Delete(customerID);
        }
    }
}

