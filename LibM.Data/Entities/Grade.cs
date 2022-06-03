using System.ComponentModel.DataAnnotations.Schema;

namespace LibM.Data.Entities
{
    [Table("Grades")]
    public class Grade
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; } //navigation prop
    }
}