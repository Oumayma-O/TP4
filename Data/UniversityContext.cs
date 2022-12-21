using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TP4.Models;

namespace TP4.Data
{
    public class UniversityContext : DbContext
    {
        static private UniversityContext? universityContextInstance = null ;
        static public int count = 0 ; 

        private UniversityContext(DbContextOptions<UniversityContext> options)
            : base(options)
        {
            Debug.WriteLine("UniversityContext constructor called");
            count++;
        }

        static public UniversityContext Instantiate_UniversityContext()
        {
            Debug.WriteLine("UniversityContext Instantiate_UniversityContext called");
            if (universityContextInstance == null)
            {
                var optionsBuilder = new DbContextOptionsBuilder<UniversityContext>();
                optionsBuilder.UseSqlite(@"Data Source = C:\Users\htc msi\OneDrive\Documents\ouma\gl3\.net\SQLiteDB\University.db");
                universityContextInstance = new UniversityContext(optionsBuilder.Options);
            }
            return universityContextInstance;

        }
        
        
        public DbSet<Student> Student { get; set; }
    }
    
        
    
}
