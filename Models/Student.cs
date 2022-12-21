using System.ComponentModel.DataAnnotations;

namespace TP4.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
  
        public string Phone_number { get; set; }
        public string University { get; set; }
        public DateTime Timestamp { get; set; }
        public string Course { get; set; }
       
        
       
    }
}
