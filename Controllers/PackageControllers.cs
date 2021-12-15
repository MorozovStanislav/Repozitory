using Microsoft.AspNetCore.Mvc;
using Shoe_store.Storage;
using ShoeStore.Domains;

namespace Repozitory.Controllers
{
    [ApiController]
    [Route("/Package")]
    public class PackageController : ControllerBase
    {
        [HttpPost("Create")]
        public void Create(Package package)
        {
            PackageStorage.Create(package);
        }

        [HttpGet("Read")]
        public Package Read(int packageId)
        {
            return PackageStorage.Read(packageId);
        }

        [HttpPut("Update")]
        public Package Update(int id, Package package)
        {
            return PackageStorage.Update(id, package);
        }

        [HttpDelete("Delete")]
        public bool Delete(int packageId)
        {
            return PackageStorage.Delete(packageId);
        }
    }
}