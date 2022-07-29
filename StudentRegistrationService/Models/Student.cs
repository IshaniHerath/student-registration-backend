using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentRegistrationService.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Mobile { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string NIC { get; set; }

        public DateTime? DOB { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Address { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string? ProfilePic { get; set; }
    }
}
