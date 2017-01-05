using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TodoApis.Models
{
    public class ActionTask
    {
        public int ActionTaskID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int ProjectID { get; set; }
        [Required]
        public virtual Project Project { get; set; }

        public int CollaboratorID { get; set; }
        public virtual Collaborator Collaborator { get; set; }

        [Display(Name = "Status")]
        [EnumDataType(typeof(Status))]
        public Status TaskStatus { get; set; }

        [Display(Name = "Priority")]
        [EnumDataType(typeof(Priority))]
        public Priority TaskPriority { get; set; }
    }
}