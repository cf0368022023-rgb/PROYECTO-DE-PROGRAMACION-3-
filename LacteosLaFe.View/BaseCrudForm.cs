using LacteosLaFe.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace LacteosLaFe.View
{
    public partial class BaseCrudForm : Form
    {
        private readonly LacteosLaFeDbContext _context;

        public BaseCrudForm(LacteosLaFeDbContext context)
        {
            InitializeComponent();
            dgvRecords.AutoGenerateColumns = false;
            _context = context;

            Load += BaseCrudForm_Load;
        }

        private void BaseCrudForm_Load(object? sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            var inventories = _context.Inventories
                .Include(x => x.Product)
                .Include(x => x.InventoryLocation)
                .ToList();

            var query = (from x in inventories
                         select new
                         {
                             Id = x.InventoryId,
                             Producto = x.Product.Name,
                             Ubicacion = x.InventoryLocation.Name,
                             Cantidad = x.Stock,
                             Guacales = x.GuacalCount,
                             Actualizacion = x.LastUpdate
                         }).ToList();

            dgvRecords.DataSource = query;
        }
    }
}