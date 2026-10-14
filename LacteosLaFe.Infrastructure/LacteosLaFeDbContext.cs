using LacteosLaFe.Entity;
using Microsoft.EntityFrameworkCore;

namespace LacteosLaFe.Infrastructure
{
    public class LacteosLaFeDbContext : DbContext
    {
        public LacteosLaFeDbContext(DbContextOptions<LacteosLaFeDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<InventoryLocation> InventoryLocations { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseDetail> PurchaseDetails { get; set; }

        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<InventoryMovement> InventoryMovements { get; set; }

        public DbSet<CashRegister> CashRegisters { get; set; }

        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDetail> SaleDetails { get; set; }
    }
}