using Shoe_store.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Shoe_store.Storage
{
    public class MaterialWarehouse
    {
        public class MaterialWarehouseStorage
        {
            private Dictionary<int, MaterialWarehouse> MaterialWarehouses { get; } = new Dictionary<int, MaterialWarehouse>();

            public void Create(MaterialWarehouse materialWarehouse)
            {
                MaterialWarehouses.Add(materialWarehouse.MaterialWarehouseId, materialWarehouse);
            }

            public MaterialWarehouse Read(int materialWarehouseId)
            {
                return MaterialWarehouses[materialWarehouseId];
            }

            public MaterialWarehouse Update(int materialWarehouseId, MaterialWarehouse newMaterialWarehouse)
            {
                MaterialWarehouses[materialWarehouseId] = newMaterialWarehouse;
                return MaterialWarehouses[materialWarehouseId];
            }

            public bool Delete(int materialWarehouseId)
            {
                return MaterialWarehouses.Remove(materialWarehouseId);
            }
        }
    }
}