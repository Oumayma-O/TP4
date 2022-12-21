using TP4.Models;

namespace TP4.Data
{
    public interface IStudentRepository : IRepository<Student>
    {
        IEnumerable<string> GetUniqueCourses();
        IEnumerable<Student> GetStudentsByCourse(string c );

    }
    
    
}
