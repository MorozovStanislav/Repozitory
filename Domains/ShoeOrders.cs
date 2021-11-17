using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ShoeStore.Domains
{

    public class ShoeOrger
    {
        public int ShoeOrderNumber { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string LastName { get; set; }

        public int Size { get; set; }

        public string NameMaterial { get; set; }

        public int Count { get; set; }

        ShoeOrger(int shoeordernumber, string firstname, string secondname, string lastname, int size, string namematerial, int count)
        {
            this.ShoeOrderNumber = shoeordernumber;
            this.FirstName = firstname;
            this.SecondName = secondname;
            this.LastName = lastname;
            this.NameMaterial = namematerial;
            this.Size = size;
            this.Count = count;
        }
    }
}