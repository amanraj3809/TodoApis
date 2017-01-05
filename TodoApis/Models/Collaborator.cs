using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoApis.Models
{
    public class Collaborator
    {
        public int CollaboratorID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Contact { get; set; }

        public virtual List<Project> Projects { get; set; }

        public virtual List<ActionTask> Tasks { get; set; }
    }
}