using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ShoeStore.Domains
{
    public class Reviews
    {
        public int ReviewsId { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string LastName { get; set; }

        public int Grade { get; set; }

        public Reviews() { }

        public Reviews(string firstname, string secondname, string lastname, int grade)
        {
            FirstName = firstname;
            SecondName = secondname;
            LastName = lastname;
            Grade = grade;
        }
    }
}