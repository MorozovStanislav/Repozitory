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
        public int MaterialsId { get; set; }

        public string NameMaterial { get; set; }

        public int Count { get; set; }

        public Materials() { }

        public Materials(string namematerial, int count)
        {
            NameMaterial = namematerial;
            Count = count;
        }
    }
}