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
        public string Ñomment { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string LastName { get; set; }

        public int Grade { get; set; }

        Reviews(int comment, string firstname, string secondname, string lastname, int grade)
        {
            this.Comment = comment;
            this.FirstName = firstname;
            this.SecondName = secondname;
            this.LastName = lastname;
            this.Grade = grade;
        }
    }
}