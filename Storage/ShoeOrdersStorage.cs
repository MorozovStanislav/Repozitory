using Shoe_store.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Shoe_store.Storage
{
    public class ShoeOrders
    {
        public class ShoeOrdersStorage
        {
            private Dictionary<int, ShoeOrders> ShoeOrdersx { get; } = new Dictionary<int, ShoeOrders>();

            public void Create(ShoeOrders shoeOrders)
            {
                ShoeOrdersx.Add(shoeOrders.ShoeOrdersId, shoeOrders);
            }

            public ShoeOrders Read(int shoeOrdersId)
            {
                return ShoeOrdersx[shoeOrdersId];
            }

            public ShoeOrders Update(int shoeOrdersId, ShoeOrders newShoeOrders)
            {
                ShoeOrdersx[shoeOrdersId] = newShoeOrders;
                return ShoeOrdersx[shoeOrdersId];
            }

            public bool Delete(int shoeOrdersId)
            {
                return ShoeOrdersx.Remove(shoeOrdersId);
            }
        }
    }
}