using System.Collections.Generic;
using ShoeStore.Domains;

namespace Shoe_store.Storage
{
    public class ShoeWarehouseStorage
    {
        private static Dictionary<int, ShoeWarehouse> ShoeWarehouses { get; } = new Dictionary<int, ShoeWarehouse>();

        public static void Create(ShoeWarehouse shoeWarehouse)
        {
            ShoeWarehouses.Add(shoeWarehouse.ShoeWarehouseId, shoeWarehouse);
        }

        public static ShoeWarehouse Read(int shoeWarehouseId)
        {
            return ShoeWarehouses[shoeWarehouseId];
        }

        public static ShoeWarehouse Update(int shoeWarehouseId, ShoeWarehouse newShoeWarehouse)
        {
            ShoeWarehouses[shoeWarehouseId] = newShoeWarehouse;
            return ShoeWarehouses[shoeWarehouseId];
        }

        public static bool Delete(int shoeWarehouseId)
        {
            return ShoeWarehouses.Remove(shoeWarehouseId);
        }
    }
}