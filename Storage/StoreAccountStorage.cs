using Shoe_store.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Shoe_store.Storage
{
    public class StoreAccount
    {
        public class StoreAccountStorage
        {
            private Dictionary<int, StoreAccount> StoreAccounts { get; } = new Dictionary<int, StoreAccount>();

            public void Create(StoreAccount storeAccount)
            {
                StoreAccounts.Add(storeAccount.StoreAccountId, storeAccount);
            }

            public StoreAccount Read(int storeAccountId)
            {
                return StoreAccounts[storeAccountId];
            }

            public StoreAccount Update(int storeAccountId, StoreAccount newStoreAccount)
            {
                StoreAccounts[storeAccountId] = newStoreAccount;
                return StoreAccounts[storeAccountId];
            }

            public bool Delete(int storeAccountId)
            {
                return StoreAccounts.Remove(storeAccountId);
            }
        }
    }
}