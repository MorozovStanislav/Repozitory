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

        Wishes(string firstname, string secondname, string lastname, string colour, int size, int price, int ordernumber)
        {
            this.FirstName = firstname;
            this.SecondName = secondname;
            this.LastName = lastname;
            this.Size = size;
            this.Colour = colour;
            this.Price = price;
            this.OrderNumber = ordernumber;
        }
    }
}