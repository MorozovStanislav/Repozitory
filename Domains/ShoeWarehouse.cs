using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ShoeStore.Domains
{

    public class ShoeWarehouse
    {
        public int ShoeNumber { get; set; }

        public ShoeWarehouse() { }

        public ShoeWarehouse(int shoenumber)
        {
            ShoeNumber = shoenumber;
        }
    }
}