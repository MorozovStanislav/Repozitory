using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ShoeStore.Domains
{

    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string LastName { get; set; }

        public int ParcelNumber { get; set; }

        public string Address { get; set; }

        public Customer() { }

        public Customer(string firstname, string secondname, string lastname, int parcelnumber, string address)
        {
            FirstName = firstname;
            SecondName = secondname;
            LastName = lastname;
            ParcelNumber = parcelnumber;
            Address = address;
        }
    }
}