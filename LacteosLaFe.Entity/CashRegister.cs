using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LacteosLaFe.Entity
{
    public class CashRegister
    {
        [Key]
        public int CashRegisterId { get; set; }

        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null!;

        [Required]
        public DateTime OpeningDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal OpeningAmount { get; set; }

        public DateTime? ClosingDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal TotalSales { get; set; }

        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal ExpectedCash { get; set; }

        [Column(TypeName = "decimal(12,2)")]
        public decimal? CountedCash { get; set; }

        [Column(TypeName = "decimal(12,2)")]
        public decimal? Difference { get; set; }

        [Required]
        [StringLength(10)]
        public string Status { get; set; } = null!;
    }
}