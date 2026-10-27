using LacteosLaFe.Entity;
using LacteosLaFe.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace LacteosLaFe.Business
{
    public class SupplierRepository
    {
        private readonly LacteosLaFeDbContext _context;

        public SupplierRepository(LacteosLaFeDbContext context)
        {
            _context = context;
        }

        public List<Supplier> GetAll()
        {
            return _context.Suppliers
                .AsNoTracking()
                .ToList();
        }

        public Supplier? GetById(int supplierId)
        {
            return _context.Suppliers
                .AsNoTracking()
                .FirstOrDefault(x => x.SupplierId == supplierId);
        }

        public bool Insert(Supplier supplier)
        {
            if (string.IsNullOrWhiteSpace(supplier.Name))
                throw new ArgumentException(
                    "El nombre del proveedor no puede estar vacío."
                );

            bool exists = _context.Suppliers
                .Any(x => x.Name.ToLower() == supplier.Name.ToLower()
                       && x.Phone == supplier.Phone);

            if (exists)
                throw new ArgumentException(
                    "Ya existe un proveedor con esos datos."
                );

            _context.Suppliers.Add(supplier);

            return _context.SaveChanges() > 0;
        }

        public bool Update(Supplier supplier)
        {
            if (string.IsNullOrWhiteSpace(supplier.Name))
                throw new ArgumentException(
                    "El nombre del proveedor no puede estar vacío."
                );

            bool exists = _context.Suppliers
                .Any(x => x.Name.ToLower() == supplier.Name.ToLower()
                       && x.Phone == supplier.Phone
                       && x.SupplierId != supplier.SupplierId);

            if (exists)
                throw new ArgumentException(
                    "Ya existe otro proveedor con esos datos."
                );

            var existingSupplier = _context.Suppliers
                .FirstOrDefault(x => x.SupplierId == supplier.SupplierId);

            if (existingSupplier == null)
                throw new ArgumentException(
                    "El proveedor no existe."
                );

            existingSupplier.Name = supplier.Name;
            existingSupplier.Phone = supplier.Phone;
            existingSupplier.Address = supplier.Address;
            existingSupplier.IsActive = supplier.IsActive;

            return _context.SaveChanges() > 0;
        }

        public bool Deactivate(int supplierId)
        {
            var supplier = _context.Suppliers
                .FirstOrDefault(x => x.SupplierId == supplierId);

            if (supplier == null)
                throw new ArgumentException(
                    "El proveedor no existe."
                );

            supplier.IsActive = false;

            return _context.SaveChanges() > 0;
        }
    }
}