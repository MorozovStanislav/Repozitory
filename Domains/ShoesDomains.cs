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
        public int ShoesId { get; set; }

        public int Size { get; set; }

        public string  Colour { get; set; }

        public Shoes() { }

        public Shoes(int size, string colour)
        {
            Size = size;
            Colour = colour;
        }
    }
}