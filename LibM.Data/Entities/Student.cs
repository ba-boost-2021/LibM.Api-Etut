using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibM.Data.Entities
{
    [Table("Students")]
    public class Student
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        public short Age { get; set; }
        public DateTime BirthDate { get; set; }
        public Guid GradeId { get; set; }
        public Grade Grade { get; set; } //navigation property
    }
}