using System.Collections.Generic;
using ShoeStore.Domains;

namespace Shoe_store.Storage
{
    public class MaterialWarehouseStorage
    {
        private static Dictionary<int, MaterialWarehouse> MaterialWarehouses { get; } = new Dictionary<int, MaterialWarehouse>();

        public static void Create(MaterialWarehouse materialWarehouse)
        {
            MaterialWarehouses.Add(materialWarehouse.MaterialWarehouseId, materialWarehouse);
        }

        public static MaterialWarehouse Read(int materialWarehouseId)
        {
            return MaterialWarehouses[materialWarehouseId];
        }

        public static MaterialWarehouse Update(int materialWarehouseId, MaterialWarehouse newMaterialWarehouse)
        {
            MaterialWarehouses[materialWarehouseId] = newMaterialWarehouse;
            return MaterialWarehouses[materialWarehouseId];
        }

        public static bool Delete(int materialWarehouseId)
        {
            return MaterialWarehouses.Remove(materialWarehouseId);
        }
    }
}