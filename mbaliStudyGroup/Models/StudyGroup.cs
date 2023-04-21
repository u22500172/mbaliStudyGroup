using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mbaliStudyGroup.Models
{
    public class StudyGroup
    {

        [Display(Name = "Student Number")]
        public string StudentNumber { get;set; }

        [Display(Name = "Name")]
        public string FirstName { get; set; }

        [Display(Name = "Surname")]
        public string LastName { get; set; }

        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Delete")]
        public string Delete { get; set; }





    }

   
}

