using Shoe_store.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Shoe_store.Storage
{
    public class ShoeWarehouse
    {
        public class ShoeWarehouseStorage
        {
            private Dictionary<int, ShoeWarehouse> ShoeWarehouses { get; } = new Dictionary<int, ShoeWarehouse>();

            public void Create(ShoeWarehouse shoeWarehouse)
            {
                ShoeWarehouses.Add(shoeWarehouse.ShoeWarehouseId, shoeWarehouse);
            }

            public ShoeWarehouse Read(int shoeWarehouse)
            {
                return ShoeWarehouses[shoeWarehouse];
            }

            public ShoeWarehouse Update(int shoeWarehouse, ShoeWarehouse newShoeWarehouse)
            {
                ShoeWarehouses[shoeWarehouse] = newShoeWarehouse;
                return ShoeWarehouses[shoeWarehouse];
            }

            public bool Delete(int shoeWarehouseId)
            {
                return ShoeWarehouses.Remove(shoeWarehouseId);
            }
        }
    }
}