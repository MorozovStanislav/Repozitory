using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ShoeStore.Domains
{

    public class MaterialWarehouse
    {
        public int MaterialWarehouseId { get; set; }

        public string ReceiptDate { get; set; }

        public MaterialWarehouse() { }

        public MaterialWarehouse(string receiptdate)
        {
            ReceiptDate = receiptdate;
        }
    }
}