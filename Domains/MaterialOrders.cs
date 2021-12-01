using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ShoeStore.Domains
{

    public class MaterialOrders
    {
        public int MaterialOrderNumber { get; set; }

        public int Quantity { get; set; }

        public string NameMaterial { get; set; }

        public MaterialOrders() { }

        public MaterialOrders(int materialordernumber, int quantity, string namematerial)
        {
            MaterialOrderNumber = materialordernumber;
            Quantity = quantity;
            NameMaterial = namematerial;
        }
    }
}