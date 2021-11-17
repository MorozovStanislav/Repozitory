using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ShoeStore.Domains
{

    public class Package
    {
        public int ParcelNumber { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public int Weight { get; set; }

        Package(int parcelnumber, string firstname, string secondname, string lastname, string address, int weight)
        {
            this.ParcelNumber = parcelnumber
            this.FirstName = firstname;
            this.SecondName = secondname;
            this.LastName = lastname;
            this.Address = address;
            this.Weight = weight;
        }
    }
}