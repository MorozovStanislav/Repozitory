using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ShoeStore.Domains
{
    public class ShoeOrders
    {
        public int ShoeOrdersId { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string LastName { get; set; }

        public int Size { get; set; }

        public string NameMaterial { get; set; }

        public int Count { get; set; }

        public ShoeOrders() { }

        public ShoeOrders(string firstname, string secondname, string lastname, int size, string namematerial, int count)
        {
            FirstName = firstname;
            SecondName = secondname;
            LastName = lastname;
            NameMaterial = namematerial;
            Size = size;
            Count = count;
        }
    }
}