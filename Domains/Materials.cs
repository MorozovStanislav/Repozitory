using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ShoeStore.Domains
{

    public class Materials
    {
        public int MaterialNumber { get; set; }

        public string NameMaterial { get; set; }

        public int Count { get; set; }

        public Materials() { }

        public Materials(int materialnumber, string namematerial, int count)
        {
            MaterialNumber = materialnumber;
            NameMaterial = namematerial;
            Count = count;
        }
    }
}