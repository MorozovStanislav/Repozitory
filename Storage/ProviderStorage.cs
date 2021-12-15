using System.Collections.Generic;
using ShoeStore.Domains;

namespace Shoe_store.Storage
{
    public class ProviderStorage
    {
        private static Dictionary<int, Provider> Providers { get; } = new Dictionary<int, Provider>();

        public static void Create(Provider provider)
        {
            Providers.Add(provider.ProviderId, provider);
        }

        public static Provider Read(int providerId)
        {
            return Providers[providerId];
        }

        public static Provider Update(int providerId, Provider newProvider)
        {
            Providers[providerId] = newProvider;
            return Providers[providerId];
        }

        public static bool Delete(int providerId)
        {
            return Providers.Remove(providerId);
        }
    }
}