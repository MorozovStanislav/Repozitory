using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ShoeStore.Domains
{

    public class Wishes
    {
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string LastName { get; set; }

        public string Colour { get; set; }

        public int Size { get; set; }

        public int Price { get; set; }

        public int OrderNumber { get; set; }

        public Wishes() { }

        public Wishes(string firstname, string secondname, string lastname, string colour, int size, int price, int ordernumber)
        {
            FirstName = firstname;
            SecondName = secondname;
            LastName = lastname;
            Size = size;
            Colour = colour;
            Price = price;
            OrderNumber = ordernumber;
        }
    }
}