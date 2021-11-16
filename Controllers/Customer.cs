<<<<<<< HEAD
<<<<<<< HEAD
﻿using System;
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
    }
}

=======
﻿using System;
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
    }
}

>>>>>>> 51063bef4390c6c661561e61a83516f60357e48f
=======
﻿using System;
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
    }
}

>>>>>>> e5dd49a86a08d1c4fe87011012bbd642458b2178
