using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibM.Data.Entities
{
    [Table("Transactions")]
    public class Transaction
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        public Guid StudentId { get; set; }
        public Guid BookId { get; set; }

        [ForeignKey(nameof(StudentId))]
        public Student Student { get; set; }

        [ForeignKey(nameof(BookId))]
        public Book Book { get; set; }
    }
}