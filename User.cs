using System.ComponentModel.DataAnnotations;

namespace LacteosLaFe.Entity
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; } = null!;

        [Required]
        [StringLength(250)]
        public string Password { get; set; } = null!;

        public bool IsActive { get; set; }
    }
}