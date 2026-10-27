using LacteosLaFe.Business;
using LacteosLaFe.Entity;

namespace LacteosLaFe.View
{
    public partial class SuppliersForm : Form
    {
        private readonly SupplierRepository _supplierRepository;
        private int selectedSupplierId = 0;

        public SuppliersForm(SupplierRepository supplierRepository)
        {
            InitializeComponent();

            _supplierRepository = supplierRepository;

            // Eventos
            Load += SuppliersForm_Load;
            btnSave.Click += btnSave_Click;
            btnEdit.Click += btnEdit_Click;
            btnDeactivate.Click += btnDeactivate_Click;
            btnClear.Click += btnClear_Click;
            dgvSuppliers.CellClick += dgvSuppliers_CellClick;
        }

        private void SuppliersForm_Load(object? sender, EventArgs e)
        {
            ConfigureGrid();
            UpdateGrid();
            ClearFields();
        }

        private void ConfigureGrid()
        {
            dgvSuppliers.Columns.Clear();
            dgvSuppliers.AutoGenerateColumns = true;

            dgvSuppliers.ReadOnly = true;
            dgvSuppliers.AllowUserToAddRows = false;
            dgvSuppliers.AllowUserToDeleteRows = false;
            dgvSuppliers.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.MultiSelect = false;
            dgvSuppliers.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void UpdateGrid()
        {
            var suppliers = _supplierRepository.GetAll();

            var query = (from x in suppliers
                         select new
                         {
                             Id = x.SupplierId,
                             Nombre = x.Name,
                             Telefono = x.Phone,
                             Direccion = x.Address,
                             Estado = x.IsActive ? "Activo" : "Inactivo"
                         }).ToList();

            dgvSuppliers.DataSource = null;
            dgvSuppliers.DataSource = query;
        }

        // GUARDAR
        private void btnSave_Click(object? sender, EventArgs e)
        {
            try
            {
                Supplier supplier = new Supplier
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

                if (_supplierRepository.Insert(supplier))
                {
                    MessageBox.Show(
                        "Proveedor guardado correctamente.",
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

        // SELECCIONAR PROVEEDOR
        private void dgvSuppliers_CellClick(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvSuppliers.Rows[e.RowIndex];

                selectedSupplierId =
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
            if (selectedSupplierId == 0)
            {
                MessageBox.Show(
                    "Seleccione un proveedor para editar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                Supplier supplier = new Supplier
                {
                    SupplierId = selectedSupplierId,
                    Name = txtName.Text.Trim(),

                    Phone = string.IsNullOrWhiteSpace(txtPhone.Text)
                        ? null
                        : txtPhone.Text.Trim(),

                    Address = string.IsNullOrWhiteSpace(txtAddress.Text)
                        ? null
                        : txtAddress.Text.Trim(),

                    IsActive = chkIsActive.Checked
                };

                if (_supplierRepository.Update(supplier))
                {
                    MessageBox.Show(
                        "Proveedor actualizado correctamente.",
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
            if (selectedSupplierId == 0)
            {
                MessageBox.Show(
                    "Seleccione un proveedor para desactivar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult result = MessageBox.Show(
                "¿Está seguro de desactivar este proveedor?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (_supplierRepository.Deactivate(selectedSupplierId))
                    {
                        MessageBox.Show(
                            "Proveedor desactivado correctamente.",
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
            selectedSupplierId = 0;

            txtName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();

            chkIsActive.Checked = true;

            dgvSuppliers.ClearSelection();

            txtName.Focus();
        }
    }
}