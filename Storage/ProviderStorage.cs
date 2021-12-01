using Shoe_store.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Shoe_store.Storage
{
    public class Provider
    {
        public class ProviderStorage
        {
            private Dictionary<int, Provider> Providers { get; } = new Dictionary<int, Provider>();

            public void Create(Provider provider)
            {
                Providers.Add(provider.ProviderId, provider);
            }

            public Provider Read(int providerId)
            {
                return Providers[providerId];
            }

            public Provider Update(int providerId, Provider newDesignProject)
            {
                Providers[providerId] = newProvider;
                return Providers[providerId];
            }

            public bool Delete(int providerId)
            {
                return Providers.Remove(providerId);
            }
        }
    }
}