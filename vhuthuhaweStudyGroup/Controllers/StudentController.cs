using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vhuthuhaweStudyGroup.ViewModels;
namespace vhuthuhaweStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult StudentView()
        {
            List<StudentsViewModel> students = GetTestData();
            return View(students);
        }
        private List<StudentsViewModel> GetTestData()
        {
            List<StudentsViewModel> students = new List<StudentsViewModel>();
            StudentsViewModel student1 = new StudentsViewModel("u01234567", "jane", "Doe", "jane.doe@tuks.co.za");
            StudentsViewModel student2 = new StudentsViewModel("u12345678", "jane", "Doe", "jane.doe@tuks.co.za");
            StudentsViewModel student3 = new StudentsViewModel("u23619270", "vhuthu", "Negondeni", "u23619270@tuks.co.za");
            StudentsViewModel student4 = new StudentsViewModel("u23957281", "Andani", "Bologo", "u23957281@tuks.co.za");
            StudentsViewModel student5 = new StudentsViewModel("u23544474", "sithembiso", "Ngcobo", "u23544474@tuks.co.za");

            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);
            students.Add(student5);
            return students;
        }
    }
}