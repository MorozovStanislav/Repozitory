using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ShoeStore.Domains
{

    public class Shoes
    {
        public int ShoeNumber { get; set; }

        public int Size { get; set; }

        public string  Colour { get; set; }

        Shoes(int shoenumber, int size, string colour)
        {
            this.ShoeNumber = shoenumber;
            this.Size = size;
            this.Colour = colour;
        }
    }
}