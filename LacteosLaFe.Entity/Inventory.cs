using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LacteosLaFe.Entity
{
    public class Inventory
    {
        [Key]
        public int InventoryId { get; set; }

        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;

        public int InventoryLocationId { get; set; }

        [ForeignKey(nameof(InventoryLocationId))]
        public InventoryLocation InventoryLocation { get; set; } = null!;

        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal Stock { get; set; }

        public int? GuacalCount { get; set; }

        [Required]
        public DateTime LastUpdate { get; set; }
    }
}