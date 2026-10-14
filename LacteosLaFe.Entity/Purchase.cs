using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LacteosLaFe.Entity
{
    public class Purchase
    {
        [Key]
        public int PurchaseId { get; set; }

        public int SupplierId { get; set; }

        [ForeignKey(nameof(SupplierId))]
        public Supplier Supplier { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string InvoiceNumber { get; set; } = null!;

        [Required]
        public DateTime PurchaseDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal Total { get; set; }

        [Required]
        [StringLength(15)]
        public string PaymentStatus { get; set; } = null!;

        public DateTime? PaymentDate { get; set; }
    }
}