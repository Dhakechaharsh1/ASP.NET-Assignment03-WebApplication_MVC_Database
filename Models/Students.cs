using System.ComponentModel.DataAnnotations;

namespace StudentsMVC_Assignment3.Models
{
    public class Students
    {
        [Key]
        public int Id { get; set; } // This will be the primary key
      
        public required string FirstName { get; set; }
       
        public required string LastName { get; set; }
       
        public required string Standard { get; set; }
       
        public required string MainSubject { get; set; }
        
        public required string RollNumber { get; set; }
    }
}
