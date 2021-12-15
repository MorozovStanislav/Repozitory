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
        public int PackageId { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public int Weight { get; set; }

        public Package() { }

        public Package(string firstname, string secondname, string lastname, string address, int weight)
        {
            FirstName = firstname;
            SecondName = secondname;
            LastName = lastname;
            Address = address;
            Weight = weight;
        }
    }
}