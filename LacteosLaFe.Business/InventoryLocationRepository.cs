using LacteosLaFe.Entity;
using LacteosLaFe.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace LacteosLaFe.Business
{
    public class InventoryLocationRepository
    {
        private readonly LacteosLaFeDbContext _context;

        public InventoryLocationRepository(LacteosLaFeDbContext context)
        {
            _context = context;
        }

        // OBTENER TODAS LAS UBICACIONES
        public List<InventoryLocation> GetAll()
        {
            return _context.InventoryLocations
                .AsNoTracking()
                .ToList();
        }

        // OBTENER UNA UBICACIÓN POR ID
        public InventoryLocation? GetById(int inventoryLocationId)
        {
            return _context.InventoryLocations
                .AsNoTracking()
                .FirstOrDefault(x =>
                    x.InventoryLocationId == inventoryLocationId);
        }

        // GUARDAR NUEVA UBICACIÓN
        public bool Insert(InventoryLocation location)
        {
            if (string.IsNullOrWhiteSpace(location.Name))
            {
                throw new ArgumentException(
                    "El nombre de la ubicación no puede estar vacío.");
            }

            bool exists = _context.InventoryLocations.Any(x =>
                x.Name.ToLower() == location.Name.ToLower());

            if (exists)
            {
                throw new ArgumentException(
                    "Ya existe una ubicación con ese nombre.");
            }

            _context.InventoryLocations.Add(location);

            return _context.SaveChanges() > 0;
        }

        // EDITAR UBICACIÓN
        public bool Update(InventoryLocation location)
        {
            if (string.IsNullOrWhiteSpace(location.Name))
            {
                throw new ArgumentException(
                    "El nombre de la ubicación no puede estar vacío.");
            }

            bool exists = _context.InventoryLocations.Any(x =>
                x.Name.ToLower() == location.Name.ToLower()
                &&
                x.InventoryLocationId != location.InventoryLocationId);

            if (exists)
            {
                throw new ArgumentException(
                    "Ya existe otra ubicación con ese nombre.");
            }

            var existingLocation =
                _context.InventoryLocations.FirstOrDefault(x =>
                    x.InventoryLocationId ==
                    location.InventoryLocationId);

            if (existingLocation == null)
            {
                throw new ArgumentException(
                    "La ubicación no existe.");
            }

            // Bodega y Sala de Ventas son ubicaciones principales.
            if (existingLocation.Name.Equals(
                    "Bodega",
                    StringComparison.OrdinalIgnoreCase)
                ||
                existingLocation.Name.Equals(
                    "Sala de Ventas",
                    StringComparison.OrdinalIgnoreCase))
            {
                // En estas dos solo permitimos modificar
                // la descripción.
                existingLocation.Description =
                    location.Description;

                existingLocation.IsActive = true;
            }
            else
            {
                existingLocation.Name =
                    location.Name;

                existingLocation.Description =
                    location.Description;

                existingLocation.IsActive =
                    location.IsActive;
            }

            return _context.SaveChanges() > 0;
        }

        // DESACTIVAR UBICACIÓN
        public bool Deactivate(int inventoryLocationId)
        {
            var location =
                _context.InventoryLocations.FirstOrDefault(x =>
                    x.InventoryLocationId ==
                    inventoryLocationId);

            if (location == null)
            {
                throw new ArgumentException(
                    "La ubicación no existe.");
            }

            // Protección de nuestras ubicaciones principales
            if (location.Name.Equals(
                    "Bodega",
                    StringComparison.OrdinalIgnoreCase)
                ||
                location.Name.Equals(
                    "Sala de Ventas",
                    StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException(
                    "Bodega y Sala de Ventas son ubicaciones principales y no pueden ser desactivadas.");
            }

            location.IsActive = false;

            return _context.SaveChanges() > 0;
        }
    }
}