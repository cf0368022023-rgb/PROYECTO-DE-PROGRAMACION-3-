using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LacteosLaFe.Entity
{
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }

        public int ClientId { get; set; }

        [ForeignKey(nameof(ClientId))]
        public Client Client { get; set; } = null!;

        public int CashRegisterId { get; set; }

        [ForeignKey(nameof(CashRegisterId))]
        public CashRegister CashRegister { get; set; } = null!;

        [Required]
        public DateTime SaleDate { get; set; }

        [Required]
        [StringLength(20)]
        public string SaleOrigin { get; set; } = null!;

        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal Total { get; set; }

        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal CashReceived { get; set; }

        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal Change { get; set; }
    }
}