using mbaliStudyGroup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace mbaliStudyGroup.Controllers
{
    public class StudyGroupController : Controller
    {
        // GET: StudyGroup
        List<Models.StudyGroup> studyGroup = new List<Models.StudyGroup>();


        public ActionResult StudyGroup(Models.StudyGroup study)
        {


            //studyGroup.Add(new Models.StudyGroup { StudentNumber = "u22500172", FirstName = "Mbali", LastName = "Nkosi", EmailAddress = "u22500172@tuks.co.za", Delete = "Delete" });
            // studyGroup.Add(new Models.StudyGroup { StudentNumber = "u12345678", FirstName = "John", LastName = "Smith", EmailAddress = "u12345678@tuks.co.za", Delete = "Delete" });
            // studyGroup.Add(new Models.StudyGroup { StudentNumber = "u22334455", FirstName = "Thando", LastName = "Dlamini", EmailAddress = "u22334455@tuks.co.za", Delete = "Delete" });
            //studyGroup.Add(new Models.StudyGroup { StudentNumber = "u21456789", FirstName = "Angela", LastName = "Khoza", EmailAddress = "u21456789@tuks.co.za", Delete = "Delete" });
            studyGroup.Add(new Models.StudyGroup { StudentNumber = "u19202122", FirstName = "Thabo", LastName = "Tau", EmailAddress = "u19202122@tuks.co.za", Delete = "Delete" });
            // studyGroup.Add(new Models.StudyGroup { StudentNumber = studentNum, FirstName = name, LastName =  surname, EmailAddress= email, Delete = "Delete" });

           

                studyGroup.Add(new StudyGroup() { StudentNumber = study.StudentNumber, FirstName = study.FirstName, LastName = study.LastName, EmailAddress = study.EmailAddress, Delete = "Delete" }); 
                ViewData["group"] = studyGroup;
           
            return View();
        }




        public ActionResult CreatePerson()
        {
             return View();
        }


    }
}