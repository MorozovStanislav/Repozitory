using System.Collections.Generic;
using ShoeStore.Domains;

namespace Shoe_store.Storage
{
    public class PackageStorage
    {
        private static Dictionary<int, Package> Packages { get; } = new Dictionary<int, Package>();

        public static void Create(Package package)
        {
            Packages.Add(package.PackageId, package);
        }

        public static Package Read(int packageId)
        {
            return Packages[packageId];
        }

        public static Package Update(int packageId, Package newPackage)
        {
            Packages[packageId] = newPackage;
            return Packages[packageId];
        }

        public static bool Delete(int packageId)
        {
            return Packages.Remove(packageId);
        }
    }
}