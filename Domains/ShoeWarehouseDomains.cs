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
        public int ShoeWarehouseId { get; set; }

        public string Address { get; set; }

        public ShoeWarehouse() { }

        public ShoeWarehouse(string address)
        {
            Address = address;
        }
    }
}