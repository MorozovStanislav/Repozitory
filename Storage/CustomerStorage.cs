using Shoe_store.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Shoe_store.Storage
{
    public class Customer
    {
        public class CustomerStorage
        {
            private Dictionary<int, Customer> Customers { get; } = new Dictionary<int, Customer>();

            public void Create(Customer customer)
            {
                Customers.Add(customer.CustomerId, customer);
            }

            public Customer Read(int customerId)
            {
                return Customers[customerId];
            }

            public Customer Update(int customerId, Customer newCustomer)
            {
                Customers[customerId] = newCustomer;
                return Customers[customerId];
            }

            public bool Delete(int customerId)
            {
                return Customers.Remove(customerId);
            }
        }
    }
}