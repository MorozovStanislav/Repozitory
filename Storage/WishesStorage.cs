using Shoe_store.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Shoe_store.Storage
{
    public class Wishes
    {
        public class WishesStorage
        {
            private Dictionary<int, Wishes> Wishesx { get; } = new Dictionary<int, Wishes>();

            public void Create(Wishes wishes)
            {
                Wishesx.Add(wishes.WishesId, wishes);
            }

            public Wishes Read(int wishesId)
            {
                return Wishesx[wishesId];
            }

            public Wishes Update(int wishesId, Wishes newWishes)
            {
                Wishesx[wishesId] = newWishes;
                return Wishesx[wishesId];
            }

            public bool Delete(int wishesId)
            {
                return Wishesx.Remove(wishesId);
            }
        }
    }
}