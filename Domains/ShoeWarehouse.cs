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

        ShoeWarehouse(int shoenumber)
        {
            this.ShoeNumber = shoenumber;
        }
    }
}