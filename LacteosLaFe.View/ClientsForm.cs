using LacteosLaFe.Business;
using LacteosLaFe.Entity;

namespace LacteosLaFe.View
{
    public partial class ClientsForm : Form
    {
        private readonly ClientRepository _clientRepository;
        private int selectedClientId = 0;

        public ClientsForm(ClientRepository clientRepository)
        {
            InitializeComponent();

            _clientRepository = clientRepository;

            // Eventos
            Load += ClientsForm_Load;
            btnSave.Click += btnSave_Click;
            btnEdit.Click += btnEdit_Click;
            btnDeactivate.Click += btnDeactivate_Click;
            btnClear.Click += btnClear_Click;
            dgvClients.CellClick += dgvClients_CellClick;
        }

        private void ClientsForm_Load(object? sender, EventArgs e)
        {
            ConfigureGrid();
            UpdateGrid();
            ClearFields();
        }

        private void ConfigureGrid()
        {
            // Quita las columnas creadas manualmente en el diseñador
            dgvClients.Columns.Clear();

            // Las columnas se crean según los datos cargados
            dgvClients.AutoGenerateColumns = true;

            dgvClients.ReadOnly = true;
            dgvClients.AllowUserToAddRows = false;
            dgvClients.AllowUserToDeleteRows = false;
            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void UpdateGrid()
        {
            var clients = _clientRepository.GetAll();

            var query = (from x in clients
                         select new
                         {
                             Id = x.ClientId,
                             Nombre = x.Name,
                             Telefono = x.Phone,
                             Direccion = x.Address,
                             Estado = x.IsActive ? "Activo" : "Inactivo"
                         }).ToList();

            dgvClients.DataSource = null;
            dgvClients.DataSource = query;
        }

        // GUARDAR
        private void btnSave_Click(object? sender, EventArgs e)
        {
            try
            {
                Client client = new Client
                {
                    Name = txtName.Text.Trim(),

                    Phone = string.IsNullOrWhiteSpace(txtPhone.Text)
                        ? null
                        : txtPhone.Text.Trim(),

                    Address = string.IsNullOrWhiteSpace(txtAddress.Text)
                        ? null
                        : txtAddress.Text.Trim(),

                    IsActive = chkIsActive.Checked
                };

                if (_clientRepository.Insert(client))
                {
                    MessageBox.Show(
                        "Cliente guardado correctamente.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

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
                    MessageBoxIcon.Warning
                );
            }
        }

        // SELECCIONAR CLIENTE
        private void dgvClients_CellClick(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClients.Rows[e.RowIndex];

                selectedClientId =
                    Convert.ToInt32(row.Cells[0].Value);

                txtName.Text =
                    row.Cells[1].Value?.ToString();

                txtPhone.Text =
                    row.Cells[2].Value?.ToString();

                txtAddress.Text =
                    row.Cells[3].Value?.ToString();

                string estado =
                    row.Cells[4].Value?.ToString() ?? "";

                chkIsActive.Checked =
                    estado == "Activo";
            }
        }

        // EDITAR
        private void btnEdit_Click(object? sender, EventArgs e)
        {
            if (selectedClientId == 0)
            {
                MessageBox.Show(
                    "Seleccione un cliente para editar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                Client client = new Client
                {
                    ClientId = selectedClientId,
                    Name = txtName.Text.Trim(),

                    Phone = string.IsNullOrWhiteSpace(txtPhone.Text)
                        ? null
                        : txtPhone.Text.Trim(),

                    Address = string.IsNullOrWhiteSpace(txtAddress.Text)
                        ? null
                        : txtAddress.Text.Trim(),

                    IsActive = chkIsActive.Checked
                };

                if (_clientRepository.Update(client))
                {
                    MessageBox.Show(
                        "Cliente actualizado correctamente.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

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
                    MessageBoxIcon.Warning
                );
            }
        }

        // DESACTIVAR
        private void btnDeactivate_Click(object? sender, EventArgs e)
        {
            if (selectedClientId == 0)
            {
                MessageBox.Show(
                    "Seleccione un cliente para desactivar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Cliente General no debe desactivarse
            if (txtName.Text.Trim().Equals(
                "Cliente General",
                StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "Cliente General no puede ser desactivado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult result = MessageBox.Show(
                "¿Está seguro de desactivar este cliente?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (_clientRepository.Deactivate(selectedClientId))
                    {
                        MessageBox.Show(
                            "Cliente desactivado correctamente.",
                            "Información",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

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
                        MessageBoxIcon.Warning
                    );
                }
            }
        }

        // LIMPIAR CAMPOS
        private void btnClear_Click(object? sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            selectedClientId = 0;

            txtName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();

            chkIsActive.Checked = true;

            dgvClients.ClearSelection();

            txtName.Focus();
        }
    }
}
