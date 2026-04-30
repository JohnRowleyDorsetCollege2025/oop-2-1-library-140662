using System.ComponentModel.DataAnnotations;

namespace oop_2_1_library_140662.Models
{
    public class Loan
    {
        public int Id { get; set; }

        // Foreign Key to Book
        public int BookId { get; set; }

        // Foreign Key to Member
        public int MemberId { get; set; }

        [Required]
        public DateTime LoanDate { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        public DateTime? ReturnedDate { get; set; }

        // Loan belongs to exactly one Book
        public Book? Book { get; set; } = null!;

        // Loan belongs to exactly one Member
        public Member? Member { get; set; } = null!;
    }
}
