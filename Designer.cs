using System;
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

        [HttpPost("Createsdesignproject")]
        public string Createsdesignproject(string str)
        {
            return str; // Создаёт дизайн-проект
        }
        [HttpPost("Definesmaterial")]
        public string Definesmaterial(string str)
        {
            return str;// Определяет материал
        }
    }
}
