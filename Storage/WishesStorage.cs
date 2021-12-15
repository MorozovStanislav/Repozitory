using System.Collections.Generic;
using ShoeStore.Domains;

namespace Shoe_store.Storage
{
    public class WishesStorage
    {
        private static Dictionary<int, Wishes> Wishesx { get; } = new Dictionary<int, Wishes>();

        public static void Create(Wishes wishes)
        {
            Wishesx.Add(wishes.WishesId, wishes);
        }

        public static Wishes Read(int wishesId)
        {
            return Wishesx[wishesId];
        }

        public static Wishes Update(int wishesId, Wishes newWishes)
        {
            Wishesx[wishesId] = newWishes;
            return Wishesx[wishesId];
        }

        public static bool Delete(int wishesId)
        {
            return Wishesx.Remove(wishesId);
        }
    }
}