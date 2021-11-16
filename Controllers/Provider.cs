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
    }
}
>>>>>>> e5dd49a86a08d1c4fe87011012bbd642458b2178
