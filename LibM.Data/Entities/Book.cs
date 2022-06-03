using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibM.Data.Entities
{
    [Table("Books")]
    public class Book
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string AuhtorName { get; set; }
    }
}