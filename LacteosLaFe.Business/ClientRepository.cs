using LacteosLaFe.Entity;
using LacteosLaFe.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace LacteosLaFe.Business
{
    public class ClientRepository
    {
        private readonly LacteosLaFeDbContext _context;

        public ClientRepository(LacteosLaFeDbContext context)
        {
            _context = context;
        }

        public List<Client> GetAll()
        {
            return _context.Clients
                .AsNoTracking()
                .ToList();
        }

        public Client? GetById(int clientId)
        {
            return _context.Clients
                .AsNoTracking()
                .FirstOrDefault(x => x.ClientId == clientId);
        }

        public bool Insert(Client client)
        {
            if (string.IsNullOrWhiteSpace(client.Name))
                throw new ArgumentException(
                    "El nombre del cliente no puede estar vacío."
                );

            bool exists = _context.Clients
                .Any(x => x.Name.ToLower() == client.Name.ToLower()
                       && x.Phone == client.Phone);

            if (exists)
                throw new ArgumentException(
                    "Ya existe un cliente con esos datos."
                );

            _context.Clients.Add(client);

            return _context.SaveChanges() > 0;
        }

        public bool Update(Client client)
        {
            if (string.IsNullOrWhiteSpace(client.Name))
                throw new ArgumentException(
                    "El nombre del cliente no puede estar vacío."
                );

            bool exists = _context.Clients
                .Any(x => x.Name.ToLower() == client.Name.ToLower()
                       && x.Phone == client.Phone
                       && x.ClientId != client.ClientId);

            if (exists)
                throw new ArgumentException(
                    "Ya existe otro cliente con esos datos."
                );

            var existingClient = _context.Clients
                .FirstOrDefault(x => x.ClientId == client.ClientId);

            if (existingClient == null)
                throw new ArgumentException(
                    "El cliente no existe."
                );

            existingClient.Name = client.Name;
            existingClient.Phone = client.Phone;
            existingClient.Address = client.Address;
            existingClient.IsActive = client.IsActive;

            return _context.SaveChanges() > 0;
        }

        public bool Deactivate(int clientId)
        {
            var client = _context.Clients
                .FirstOrDefault(x => x.ClientId == clientId);

            if (client == null)
                throw new ArgumentException(
                    "El cliente no existe."
                );

            client.IsActive = false;

            return _context.SaveChanges() > 0;
        }
    }
}