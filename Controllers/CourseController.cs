using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP4.Data;
using TP4.Models;
using TP4GestionDesStudents.Data;

namespace TP4.Controllers
{
    public class CourseController : Controller
    {
        // GET: CourseController
        public ActionResult Index()
        {
            UniversityContext uni = UniversityContext.Instantiate_UniversityContext();
            StudentRepository st = new StudentRepository(uni);
            return View(st.GetUniqueCourses());
        }


        [Route("Course/{course}")]
        public ActionResult CourseX(string course)
        {
            UniversityContext uni = UniversityContext.Instantiate_UniversityContext();
            StudentRepository st = new StudentRepository(uni);
            return View(st.GetStudentsByCourse(course));
        }
            
        
      
        
    }
}
