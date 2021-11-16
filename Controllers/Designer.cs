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
    [Route("/Designer")]
    public class DesignerController : ControllerBase
    {

        [HttpPost("CreatesdesignProject")]
        public string CreatesdesignProject(string str)
        {
            return str; // Создаёт дизайн-проект
        }
        [HttpPost("DefinesMaterial")]
        public string DefinesMaterial(string str)
        {
            return str;// Определяет материал
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
    [Route("/Designer")]
    public class DesignerController : ControllerBase
    {

        [HttpPost("CreatesdesignProject")]
        public string CreatesdesignProject(string str)
        {
            return str; // Создаёт дизайн-проект
        }
        [HttpPost("DefinesMaterial")]
        public string DefinesMaterial(string str)
        {
            return str;// Определяет материал
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
    [Route("/Designer")]
    public class DesignerController : ControllerBase
    {

        [HttpPost("CreatesdesignProject")]
        public string CreatesdesignProject(string str)
        {
            return str; // Создаёт дизайн-проект
        }
        [HttpPost("DefinesMaterial")]
        public string DefinesMaterial(string str)
        {
            return str;// Определяет материал
        }
    }
}
>>>>>>> e5dd49a86a08d1c4fe87011012bbd642458b2178
