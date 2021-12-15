using System.Collections.Generic;
using ShoeStore.Domains;

namespace Shoe_store.Storage
{
    public class StoreAccountStorage
    {
        private static Dictionary<int, StoreAccount> StoreAccounts { get; } = new Dictionary<int, StoreAccount>();

        public static void Create(StoreAccount storeAccount)
        {
            StoreAccounts.Add(storeAccount.TranslationId, storeAccount);
        }

        public static StoreAccount Read(int translationId)
        {
            return StoreAccounts[translationId];
        }

        public static StoreAccount Update(int translationId, StoreAccount newStoreAccount)
        {
            StoreAccounts[translationId] = newStoreAccount;
            return StoreAccounts[translationId];
        }

        public static bool Delete(int translationId)
        {
            return StoreAccounts.Remove(translationId);
        }
    }
}