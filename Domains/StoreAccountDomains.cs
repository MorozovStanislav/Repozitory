using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ShoeStore.Domains
{

    public class StoreAccount
    {
        public int TranslationId  { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string LastName { get; set; }

        public int MonetaryAmount  { get; set; }

        public StoreAccount() { }

        public StoreAccount(string firstname, string secondname, string lastname, int monetaryamount)
        {
            FirstName = firstname;
            SecondName = secondname;
            LastName = lastname;
            MonetaryAmount = monetaryamount;
        }
    }
}