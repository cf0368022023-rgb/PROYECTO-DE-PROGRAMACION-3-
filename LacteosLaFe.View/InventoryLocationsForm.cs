using LacteosLaFe.Business;
using LacteosLaFe.Entity;

namespace LacteosLaFe.View
{
    public partial class InventoryLocationsForm : Form
    {
        private readonly InventoryLocationRepository _locationRepository;
        private int selectedLocationId = 0;

        public InventoryLocationsForm(
            InventoryLocationRepository locationRepository)
        {
            InitializeComponent();

            _locationRepository = locationRepository;

            // Eventos
            Load += InventoryLocationsForm_Load;
            btnSave.Click += btnSave_Click;
            btnEdit.Click += btnEdit_Click;
            btnDeactivate.Click += btnDeactivate_Click;
            btnClear.Click += btnClear_Click;
            dgvLocations.CellClick += dgvLocations_CellClick;
        }

        private void InventoryLocationsForm_Load(
            object? sender,
            EventArgs e)
        {
            ConfigureGrid();
            UpdateGrid();
            ClearFields();
        }

        // CONFIGURAR TABLA
        private void ConfigureGrid()
        {
            dgvLocations.Columns.Clear();
            dgvLocations.AutoGenerateColumns = true;

            dgvLocations.ReadOnly = true;
            dgvLocations.AllowUserToAddRows = false;
            dgvLocations.AllowUserToDeleteRows = false;
            dgvLocations.MultiSelect = false;

            dgvLocations.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvLocations.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        // CARGAR UBICACIONES
        private void UpdateGrid()
        {
            var locations = _locationRepository.GetAll();

            var query =
                (from x in locations
                 select new
                 {
                     Id = x.InventoryLocationId,
                     Nombre = x.Name,
                     Descripcion = x.Description,
                     Estado = x.IsActive
                         ? "Activo"
                         : "Inactivo"
                 }).ToList();

            dgvLocations.DataSource = null;
            dgvLocations.DataSource = query;
        }

        // GUARDAR
        private void btnSave_Click(
            object? sender,
            EventArgs e)
        {
            try
            {
                InventoryLocation location =
                    new InventoryLocation
                    {
                        Name = txtName.Text.Trim(),

                        Description =
                            string.IsNullOrWhiteSpace(
                                txtDescription.Text)
                            ? null
                            : txtDescription.Text.Trim(),

                        IsActive = chkIsActive.Checked
                    };

                if (_locationRepository.Insert(location))
                {
                    MessageBox.Show(
                        "Ubicación guardada correctamente.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    UpdateGrid();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // SELECCIONAR FILA
        private void dgvLocations_CellClick(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvLocations.Rows[e.RowIndex];

                selectedLocationId =
                    Convert.ToInt32(row.Cells[0].Value);

                txtName.Text =
                    row.Cells[1].Value?.ToString();

                txtDescription.Text =
                    row.Cells[2].Value?.ToString();

                string estado =
                    row.Cells[3].Value?.ToString() ?? "";

                chkIsActive.Checked =
                    estado == "Activo";
            }
        }

        // EDITAR
        private void btnEdit_Click(
            object? sender,
            EventArgs e)
        {
            if (selectedLocationId == 0)
            {
                MessageBox.Show(
                    "Seleccione una ubicación para editar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                InventoryLocation location =
                    new InventoryLocation
                    {
                        InventoryLocationId =
                            selectedLocationId,

                        Name =
                            txtName.Text.Trim(),

                        Description =
                            string.IsNullOrWhiteSpace(
                                txtDescription.Text)
                            ? null
                            : txtDescription.Text.Trim(),

                        IsActive =
                            chkIsActive.Checked
                    };

                if (_locationRepository.Update(location))
                {
                    MessageBox.Show(
                        "Ubicación actualizada correctamente.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    UpdateGrid();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // DESACTIVAR
        private void btnDeactivate_Click(
            object? sender,
            EventArgs e)
        {
            if (selectedLocationId == 0)
            {
                MessageBox.Show(
                    "Seleccione una ubicación para desactivar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "¿Está seguro de desactivar esta ubicación?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (_locationRepository
                        .Deactivate(selectedLocationId))
                    {
                        MessageBox.Show(
                            "Ubicación desactivada correctamente.",
                            "Información",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        UpdateGrid();
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        // LIMPIAR CAMPOS
        private void btnClear_Click(
            object? sender,
            EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            selectedLocationId = 0;

            txtName.Clear();
            txtDescription.Clear();

            chkIsActive.Checked = true;

            dgvLocations.ClearSelection();

            txtName.Focus();
        }
    }
}