using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TodoApis.Models
{
    public class Project
    {
        public int ProjectID { get; set; }

        [Display(Name = "Project Name")]
        public string ProjectName { get; set; }

        public string Description { get; set; }

        public virtual List<ActionTask> Tasks { get; set; }

        public virtual List<Collaborator> Collaborators { get; set; }

        public string ProjectAdministrator { get; set; }
    }
}