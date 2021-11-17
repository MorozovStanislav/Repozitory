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
        public int ProjectNumber { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string LastName { get; set; }

        public int Ñonstruction { get; set; }

        public string Materials { get; set; }

        DesignProject(int projectnumber, string firstname, string secondname, string lastname, int construction, string materials)
        {
            this.ProjectNumber = projectnumber;
            this.FirstName = firstname;
            this.SecondName = secondname;
            this.LastName = lastname;
            this.Ñonstruction = construction;
            this.Materials = materials;
        }
    }
}