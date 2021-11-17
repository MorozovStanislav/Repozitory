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
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string LastName { get; set; }

        public int ParcelNumber { get; set; }

        public string Address { get; set; }

        Customer(string firstname, string secondname, string lastname, int parcelnumber, string address)
        {
            this.FirstName = firstname;
            this.SecondName = secondname;
            this.LastName = lastname;
            this.ParcelNumber = parcelnumber;
            this.Address = address;
        }
    }
}