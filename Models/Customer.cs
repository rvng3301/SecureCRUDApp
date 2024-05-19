using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; } = string.Empty;

        [EmailAddress]
        public string Email { get; set; } = string.Empty;
    }
}