using Shoe_store.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Shoe_store.Storage
{
    public class Package
    {
        public class PackageStorage
        {
            private Dictionary<int, Package> Packages { get; } = new Dictionary<int, Package>();

            public void Create(Package package)
            {
                Packages.Add(package.PackageId, package);
            }

            public Package Read(int packageId)
            {
                return Packages[packageId];
            }

            public Package Update(int packageId, Package newPackage)
            {
                Packages[packageId] = newPackage;
                return Packages[packageId];
            }

            public bool Delete(int packageId)
            {
                return Packages.Remove(packageId);
            }
        }
    }
}