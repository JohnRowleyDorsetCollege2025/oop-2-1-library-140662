using System.ComponentModel.DataAnnotations;

namespace oop_2_1_library_140662.Models
{
    public class Member
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        // Relationship: Member 1 — * Loan
        public ICollection<Loan> Loans { get; set; } = new List<Loan>();
    }
}
