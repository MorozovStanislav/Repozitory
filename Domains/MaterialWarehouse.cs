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
        public int MaterialNumber { get; set; }

        public string ReceiptDate { get; set; }

        MaterialWarehouse(int materialnumber, string receiptdate)
        {
            this.MaterialNumber = materialnumber;
            this.ReceiptDate = receiptdate;
        }
    }
}