using System.ComponentModel.DataAnnotations;

namespace LacteosLaFe.Entity
{
    public class InventoryLocation
    {
        [Key]
        public int InventoryLocationId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        [StringLength(150)]
        public string? Description { get; set; }

        public bool IsActive { get; set; }
    }
}