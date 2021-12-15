using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ShoeStore.Domains
{

    public class DesignProject
    {
        public int DesignProjectId { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string LastName { get; set; }

        public int Сonstruction { get; set; }

        public string Materials { get; set; }

        public DesignProject() { }

        public DesignProject(string firstname, string secondname, string lastname, int construction, string materials)
        {
            FirstName = firstname;
            SecondName = secondname;
            LastName = lastname;
            Сonstruction = construction;
            Materials = materials;
        }
    }
}