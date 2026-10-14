namespace LacteosLaFe.View
{
    partial class BaseCrudForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            btnSave = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvRecords = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colProduct = new DataGridViewTextBoxColumn();
            colLocation = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colGuacales = new DataGridViewTextBoxColumn();
            colUpdate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(216, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(371, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "GESTIÓN DE REGISTROS";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.DimGray;
            lblName.Location = new Point(83, 91);
            lblName.Name = "lblName";
            lblName.Size = new Size(79, 23);
            lblName.TabIndex = 1;
            lblName.Text = "Nombre";
            // 
            // txtName
            // 
            txtName.Location = new Point(196, 87);
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 27);
            txtName.TabIndex = 2;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.DimGray;
            lblDescription.Location = new Point(83, 134);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(107, 23);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Descripción";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(196, 134);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(300, 27);
            txtDescription.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(38, 184);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 35);
            btnSave.TabIndex = 5;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.LightSteelBlue;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(226, 184);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(110, 35);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Editar\r\n";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(430, 184);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 35);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gainsboro;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.DimGray;
            btnClear.Location = new Point(634, 184);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 35);
            btnClear.TabIndex = 8;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // dgvRecords
            // 
            dgvRecords.AllowUserToAddRows = false;
            dgvRecords.AllowUserToDeleteRows = false;
            dgvRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecords.Columns.AddRange(new DataGridViewColumn[] { colId, colProduct, colLocation, colStock, colGuacales, colUpdate });
            dgvRecords.Location = new Point(38, 271);
            dgvRecords.Name = "dgvRecords";
            dgvRecords.ReadOnly = true;
            dgvRecords.RowHeadersWidth = 51;
            dgvRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecords.Size = new Size(740, 220);
            dgvRecords.TabIndex = 9;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colProduct
            // 
            colProduct.DataPropertyName = "Producto";
            colProduct.HeaderText = "Producto";
            colProduct.MinimumWidth = 6;
            colProduct.Name = "colProduct";
            colProduct.ReadOnly = true;
            // 
            // colLocation
            // 
            colLocation.DataPropertyName = "Ubicacion";
            colLocation.HeaderText = "Ubicacion";
            colLocation.MinimumWidth = 6;
            colLocation.Name = "colLocation";
            colLocation.ReadOnly = true;
            // 
            // colStock
            // 
            colStock.DataPropertyName = "Cantidad";
            colStock.HeaderText = "Cantidad ";
            colStock.MinimumWidth = 6;
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            // 
            // colGuacales
            // 
            colGuacales.DataPropertyName = "Guacales";
            colGuacales.HeaderText = "Guacales ";
            colGuacales.MinimumWidth = 6;
            colGuacales.Name = "colGuacales";
            colGuacales.ReadOnly = true;
            // 
            // colUpdate
            // 
            colUpdate.DataPropertyName = "Actualizacion";
            colUpdate.HeaderText = "Actualizacion";
            colUpdate.MinimumWidth = 6;
            colUpdate.Name = "colUpdate";
            colUpdate.ReadOnly = true;
            // 
            // BaseCrudForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 503);
            Controls.Add(dgvRecords);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Name = "BaseCrudForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Registros";
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private TextBox txtName;
        private Label lblDescription;
        private TextBox txtDescription;
        private Button btnSave;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvRecords;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colProduct;
        private DataGridViewTextBoxColumn colLocation;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colGuacales;
        private DataGridViewTextBoxColumn colUpdate;
    }
}