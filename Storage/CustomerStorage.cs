using System.Collections.Generic;
using ShoeStore.Domains;

namespace Shoe_store.Storage
{
    public class CustomerStorage
    {
        private static Dictionary<int, Customer> Customers { get; } = new Dictionary<int, Customer>();

        public static void Create(Customer customer)
        {
            Customers.Add(customer.CustomerId, customer);
        }

        public static Customer Read(int customerId)
        {
            return Customers[customerId];
        }

        public static Customer Update(int customerId, Customer newCustomer)
        {
            Customers[customerId] = newCustomer;
            return Customers[customerId];
        }

        public static bool Delete(int customerId)
        {
            return Customers.Remove(customerId);
        }
    }
}