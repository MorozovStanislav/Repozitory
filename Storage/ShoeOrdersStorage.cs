using System.Collections.Generic;
using ShoeStore.Domains;

namespace Shoe_store.Storage
{
    public class ShoeOrdersStorage
    {
        private static Dictionary<int, ShoeOrders> ShoeOrdersx { get; } = new Dictionary<int, ShoeOrders>();

        public static void Create(ShoeOrders shoeOrders)
        {
            ShoeOrdersx.Add(shoeOrders.ShoeOrdersId, shoeOrders);
        }

        public static ShoeOrders Read(int shoeOrdersId)
        {
            return ShoeOrdersx[shoeOrdersId];
        }

        public static ShoeOrders Update(int shoeOrdersId, ShoeOrders newShoeOrders)
        {
            ShoeOrdersx[shoeOrdersId] = newShoeOrders;
            return ShoeOrdersx[shoeOrdersId];
        }

        public static bool Delete(int shoeOrdersId)
        {
            return ShoeOrdersx.Remove(shoeOrdersId);
        }
    }
}