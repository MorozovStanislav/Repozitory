using Shoe_store.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Shoe_store.Storage
{
    public class MaterialOrders
    {
        public class MaterialOrdersStorage
        {
            private Dictionary<int, MaterialOrders> MaterialOrdersx { get; } = new();

            public void Create(MaterialOrders materialOrders)
            {
                MaterialOrdersx.Add(MaterialOrders.MaterialOrdersId, materialOrders);
            }

            public MaterialOrders Read(int materialOrdersId)
            {
                return MaterialOrdersx[materialOrdersId];
            }

            public MaterialOrders Update(int materialOrdersId, MaterialOrders newMaterialOrders)
            {
                MaterialOrdersx[materialOrdersId] = newMaterialOrders;
                return MaterialOrdersx[materialOrdersId];
            }

            public bool Delete(int materialOrdersId)
            {
                return MaterialOrdersx.Remove(materialOrdersId);
            }
        }
    }
}