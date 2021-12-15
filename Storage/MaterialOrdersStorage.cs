using System.Collections.Generic;
using ShoeStore.Domains;

namespace Shoe_store.Storage
{
    public class MaterialOrdersStorage
    {
        private static Dictionary<int, MaterialOrders> MaterialOrdersx { get; } = new Dictionary<int, MaterialOrders>();

        public static void Create(MaterialOrders materialOrders)
        {
            MaterialOrdersx.Add(materialOrders.MaterialOrderId, materialOrders);
        }

        public static MaterialOrders Read(int materialOrdersId)
        {
            return MaterialOrdersx[materialOrdersId];
        }

        public static MaterialOrders Update(int materialOrdersId, MaterialOrders newMaterialOrders)
        {
            MaterialOrdersx[materialOrdersId] = newMaterialOrders;
            return MaterialOrdersx[materialOrdersId];
        }

        public static bool Delete(int materialOrdersId)
        {
            return MaterialOrdersx.Remove(materialOrdersId);
        }
    }
}