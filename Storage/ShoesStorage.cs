using System.Collections.Generic;
using ShoeStore.Domains;

namespace Shoe_store.Storage
{
    public class ShoesStorage
    {
        private static Dictionary<int, Shoes> Shoesx { get; } = new Dictionary<int, Shoes>();

        public static void Create(Shoes shoes)
        {
            Shoesx.Add(shoes.ShoesId, shoes);
        }

        public static Shoes Read(int shoesId)
        {
            return Shoesx[shoesId];
        }

        public static Shoes Update(int shoesId, Shoes newShoes)
        {
            Shoesx[shoesId] = newShoes;
            return Shoesx[shoesId];
        }

        public static bool Delete(int shoesId)
        {
            return Shoesx.Remove(shoesId);
        }
    }
}