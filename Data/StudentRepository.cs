using TP4.Data;
using TP4.Models;

namespace TP4GestionDesStudents.Data
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        private readonly UniversityContext _universityContext;

        public StudentRepository(UniversityContext universityContext) : base(universityContext)
        {
            this._universityContext = universityContext;
        }

        public IEnumerable<string> GetUniqueCourses()
        {
            return (IEnumerable<string>)_universityContext.Student.Select(x => x.Course).Distinct();
        }

        public IEnumerable<Student> GetStudentsByCourse(string course)
        {
            return _universityContext.Student.Where(x => x.Course == course);
        }
    }
}
