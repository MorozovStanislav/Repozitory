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

        [HttpPost]
        public string Create(string str)
        {
            return str;
        }

        [HttpGet]
        public string Read(string str)
        {
            return str;
        }

        [HttpPut]
        public string Update(string str)
        {
            return str;
        }

        [HttpDelete]
        public string Delete(string str)
        {
            return str;
        }
    }
}