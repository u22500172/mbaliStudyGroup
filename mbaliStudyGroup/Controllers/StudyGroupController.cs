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
        List<StudyGroup> studyGroup = new List<StudyGroup>();


        public ActionResult StudyGroup(Models.StudyGroup study)
        {
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