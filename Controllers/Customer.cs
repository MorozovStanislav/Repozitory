using Microsoft.AspNetCore.Mvc;
using Shoe_store.Storage;
using ShoeStore.Domains;

namespace Repozitory.Controllers
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
            CustomerStorage.Create(customer);
        }

        [HttpGet("Read")]
        public Customer Read(int customerId)
        {
            return CustomerStorage.Read(customerId);
        }

        [HttpPut("Update")]
        public Customer Update(int id, Customer customer)
        {
            return CustomerStorage.Update(id, customer);
        }

        [HttpDelete("Delete")]
        public bool Delete(int customerId)
        {
            return CustomerStorage.Delete(customerId);
        }
    }
}

