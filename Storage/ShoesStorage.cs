using Shoe_store.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Shoe_store.Storage
{
    public class Shoes
    {
        public class ShoesStorage
        {
            private Dictionary<int, Shoes> Shoesx { get; } = new Dictionary<int, Shoes>();

            public void Create(Shoes shoes)
            {
                Shoesx.Add(shoes.ShoesId, shoes);
            }

            public Shoes Read(int shoesId)
            {
                return Shoesx[shoesId];
            }

            public Shoes Update(int shoesId, Shoes newShoes)
            {
                Shoesx[shoesId] = newShoes;
                return Shoesx[shoesId];
            }

            public bool Delete(int shoesId)
            {
                return Shoesx.Remove(shoesId);
            }
        }
    }
}