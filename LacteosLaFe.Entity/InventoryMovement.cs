using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LacteosLaFe.Entity
{
    public class InventoryMovement
    {
        [Key]
        public int InventoryMovementId { get; set; }

        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;

        public int? OriginLocationId { get; set; }

        [ForeignKey(nameof(OriginLocationId))]
        public InventoryLocation? OriginLocation { get; set; }

        public int? DestinationLocationId { get; set; }

        [ForeignKey(nameof(DestinationLocationId))]
        public InventoryLocation? DestinationLocation { get; set; }

        [Required]
        [StringLength(20)]
        public string MovementType { get; set; } = null!;

        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal Quantity { get; set; }

        // Guacal: forma de control físico utilizada por el negocio para los quesillos.
        public int? GuacalCount { get; set; }

        [Required]
        public DateTime MovementDate { get; set; }

        [StringLength(200)]
        public string? Observation { get; set; }
    }
}