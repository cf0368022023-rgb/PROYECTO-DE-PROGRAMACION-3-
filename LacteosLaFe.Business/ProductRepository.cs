using LacteosLaFe.Entity;
using LacteosLaFe.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace LacteosLaFe.Business
{
    public class ProductRepository
    {
        private readonly LacteosLaFeDbContext _context;

        public ProductRepository(LacteosLaFeDbContext context)
        {
            _context = context;
        }

        public List<Product> GetAll()
        {
            return _context.Products
                .AsNoTracking()
                .ToList();
        }

        public Product? GetById(int productId)
        {
            return _context.Products
                .AsNoTracking()
                .FirstOrDefault(x => x.ProductId == productId);
        }

        public bool Insert(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.Name))
                throw new ArgumentException(
                    "El nombre del producto no puede estar vacío."
                );

            if (string.IsNullOrWhiteSpace(product.UnitMeasure))
                throw new ArgumentException(
                    "La unidad de medida no puede estar vacía."
                );

            if (product.CurrentPrice <= 0)
                throw new ArgumentException(
                    "El precio debe ser mayor que cero.",
                    nameof(product)
                );

            bool exists = _context.Products
                .Any(x => x.Name.ToLower() == product.Name.ToLower());

            if (exists)
                throw new ArgumentException(
                    "Ya existe un producto con ese nombre."
                );

            _context.Products.Add(product);

            return _context.SaveChanges() > 0;
        }

        public bool Update(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.Name))
                throw new ArgumentException(
                    "El nombre del producto no puede estar vacío."
                );

            if (string.IsNullOrWhiteSpace(product.UnitMeasure))
                throw new ArgumentException(
                    "La unidad de medida no puede estar vacía."
                );

            if (product.CurrentPrice <= 0)
                throw new ArgumentException(
                    "El precio debe ser mayor que cero.",
                    nameof(product)
                );

            bool exists = _context.Products
                .Any(x => x.Name.ToLower() == product.Name.ToLower()
                       && x.ProductId != product.ProductId);

            if (exists)
                throw new ArgumentException(
                    "Ya existe otro producto con ese nombre."
                );

            var existingProduct = _context.Products
                .FirstOrDefault(x => x.ProductId == product.ProductId);

            if (existingProduct == null)
                throw new ArgumentException(
                    "El producto no existe."
                );

            existingProduct.Name = product.Name;
            existingProduct.UnitMeasure = product.UnitMeasure;
            existingProduct.CurrentPrice = product.CurrentPrice;
            existingProduct.IsActive = product.IsActive;

            return _context.SaveChanges() > 0;
        }

        public bool Deactivate(int productId)
        {
            var product = _context.Products
                .FirstOrDefault(x => x.ProductId == productId);

            if (product == null)
                throw new ArgumentException(
                    "El producto no existe."
                );

            product.IsActive = false;

            return _context.SaveChanges() > 0;
        }
    }
}