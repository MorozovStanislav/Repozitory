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
    [Route("/Package")]
    public class PackageController : ControllerBase
    {
        [HttpPost("Create")]
        public void Create(Package package)
        {
            return Storage.PackageStorage.Create(package);
        }

        [HttpGet("Read")]
        public Package Read(int packageID)
        {
            return Storage.PackageStorage.Read(packageID);
        }

        [HttpPut("Update")]
        public Package Update(Package package)
        {
            return Storage.PackageStorage.Update(package);
        }

        [HttpDelete("Delete")]
        public bool Delete(int packageID)
        {
            return Storage.PackageStorage.Delete(packageID);
        }
    }
}