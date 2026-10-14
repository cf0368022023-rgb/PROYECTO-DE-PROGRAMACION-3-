using LacteosLaFe.Business;
using LacteosLaFe.Entity;

namespace LacteosLaFe.View
{
    public partial class ProductsForm : Form
    {
        private readonly ProductRepository _productRepository;
        private int selectedProductId = 0;

        public ProductsForm(ProductRepository productRepository)
        {
            InitializeComponent();

            _productRepository = productRepository;

            Load += ProductsForm_Load;
            btnSave.Click += btnSave_Click;
            dgvProducts.CellClick += dgvProducts_CellClick;
            btnEdit.Click += btnEdit_Click;
            btnDeactivate.Click += btnDeactivate_Click;
            btnClear.Click += btnClear_Click;
        }

        private void ProductsForm_Load(object? sender, EventArgs e)
        {
            LoadUnitMeasures();
            UpdateGrid();

        }
        private void UpdateGrid()
        {
            var products = _productRepository.GetAll();

            var query = (from x in products
                         select new
                         {
                             Id = x.ProductId,
                             Nombre = x.Name,
                             Unidad = x.UnitMeasure,
                             Precio = x.CurrentPrice,
                             Estado = x.IsActive ? "Activo" : "Inactivo"
                         }).ToList();

            dgvProducts.DataSource = query;

        }
        private void LoadUnitMeasures()
        {
            cmbUnitMeasure.Items.Clear();

            cmbUnitMeasure.Items.Add("lb");
            cmbUnitMeasure.Items.Add("unidad");
            cmbUnitMeasure.Items.Add("botella");

            cmbUnitMeasure.SelectedIndex = 0;
        }
        private void btnSave_Click(object? sender, EventArgs e)
        {
            if (!decimal.TryParse(txtCurrentPrice.Text, out decimal price))
            {
                MessageBox.Show(
                    "Ingrese un precio válido.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                Product product = new Product
                {
                    Name = txtName.Text.Trim(),
                    UnitMeasure = cmbUnitMeasure.SelectedItem?.ToString() ?? "",
                    CurrentPrice = price,
                    IsActive = chkIsActive.Checked
                };

                if (_productRepository.Insert(product))
                {
                    MessageBox.Show(
                        "Producto guardado correctamente.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    UpdateGrid();

                    txtName.Clear();
                    txtCurrentPrice.Clear();
                    cmbUnitMeasure.SelectedIndex = 0;
                    chkIsActive.Checked = true;
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
        private void dgvProducts_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

                selectedProductId = Convert.ToInt32(row.Cells[0].Value);

                txtName.Text = row.Cells[1].Value?.ToString();
                cmbUnitMeasure.SelectedItem = row.Cells[2].Value?.ToString();
                txtCurrentPrice.Text = row.Cells[3].Value?.ToString();

                string estado = row.Cells[4].Value?.ToString() ?? "";
                chkIsActive.Checked = estado == "Activo";
            }
        }

        private void btnEdit_Click(object? sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                MessageBox.Show(
                    "Seleccione un producto para editar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!decimal.TryParse(txtCurrentPrice.Text, out decimal price))
            {
                MessageBox.Show(
                    "Ingrese un precio válido.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                Product product = new Product
                {
                    ProductId = selectedProductId,
                    Name = txtName.Text.Trim(),
                    UnitMeasure = cmbUnitMeasure.SelectedItem?.ToString() ?? "",
                    CurrentPrice = price,
                    IsActive = chkIsActive.Checked
                };

                if (_productRepository.Update(product))
                {
                    MessageBox.Show(
                        "Producto actualizado correctamente.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    UpdateGrid();
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
        private void btnDeactivate_Click(object? sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                MessageBox.Show(
                    "Seleccione un producto para desactivar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult result = MessageBox.Show(
                "¿Está seguro de desactivar este producto?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (_productRepository.Deactivate(selectedProductId))
                    {
                        MessageBox.Show(
                            "Producto desactivado correctamente.",
                            "Información",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        UpdateGrid();
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
        private void btnClear_Click(object? sender, EventArgs e)
        {
            selectedProductId = 0;

            txtName.Text = "";
            txtCurrentPrice.Text = "";
            cmbUnitMeasure.SelectedIndex = -1;
            chkIsActive.Checked = false;

            dgvProducts.CurrentCell = null;
            dgvProducts.ClearSelection();
        }
    }
}