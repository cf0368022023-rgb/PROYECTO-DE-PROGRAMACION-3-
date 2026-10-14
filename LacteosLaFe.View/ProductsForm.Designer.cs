namespace LacteosLaFe.View
{
    partial class ProductsForm
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
            lblUnitMeasure = new Label();
            cmbUnitMeasure = new ComboBox();
            lblCurrentPrice = new Label();
            txtCurrentPrice = new TextBox();
            chkIsActive = new CheckBox();
            btnSave = new Button();
            btnEdit = new Button();
            btnDeactivate = new Button();
            btnClear = new Button();
            dgvProducts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(263, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(382, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "GESTIÓN DE PRODUCTOS";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.DimGray;
            lblName.Location = new Point(181, 74);
            lblName.Name = "lblName";
            lblName.Size = new Size(76, 23);
            lblName.TabIndex = 1;
            lblName.Text = "Nombre";
            // 
            // txtName
            // 
            txtName.Location = new Point(291, 70);
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 27);
            txtName.TabIndex = 2;
            // 
            // lblUnitMeasure
            // 
            lblUnitMeasure.AutoSize = true;
            lblUnitMeasure.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnitMeasure.ForeColor = Color.DimGray;
            lblUnitMeasure.Location = new Point(98, 129);
            lblUnitMeasure.Name = "lblUnitMeasure";
            lblUnitMeasure.Size = new Size(159, 23);
            lblUnitMeasure.TabIndex = 3;
            lblUnitMeasure.Text = "Unidad de medida";
            // 
            // cmbUnitMeasure
            // 
            cmbUnitMeasure.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnitMeasure.FormattingEnabled = true;
            cmbUnitMeasure.Location = new Point(291, 124);
            cmbUnitMeasure.Name = "cmbUnitMeasure";
            cmbUnitMeasure.Size = new Size(200, 28);
            cmbUnitMeasure.TabIndex = 4;
            // 
            // lblCurrentPrice
            // 
            lblCurrentPrice.AutoSize = true;
            lblCurrentPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentPrice.ForeColor = Color.DimGray;
            lblCurrentPrice.Location = new Point(145, 181);
            lblCurrentPrice.Name = "lblCurrentPrice";
            lblCurrentPrice.Size = new Size(112, 23);
            lblCurrentPrice.TabIndex = 5;
            lblCurrentPrice.Text = "Precio actual";
            // 
            // txtCurrentPrice
            // 
            txtCurrentPrice.Location = new Point(291, 177);
            txtCurrentPrice.Name = "txtCurrentPrice";
            txtCurrentPrice.Size = new Size(150, 27);
            txtCurrentPrice.TabIndex = 6;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = CheckState.Checked;
            chkIsActive.Location = new Point(597, 72);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(73, 24);
            chkIsActive.TabIndex = 7;
            chkIsActive.Text = "Activo";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(60, 246);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 35);
            btnSave.TabIndex = 8;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.LightSteelBlue;
            btnEdit.Location = new Point(313, 246);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(110, 35);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDeactivate
            // 
            btnDeactivate.BackColor = Color.IndianRed;
            btnDeactivate.ForeColor = Color.White;
            btnDeactivate.Location = new Point(535, 246);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(110, 35);
            btnDeactivate.TabIndex = 10;
            btnDeactivate.Text = "Desactivar";
            btnDeactivate.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gainsboro;
            btnClear.Location = new Point(680, 246);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 35);
            btnClear.TabIndex = 11;
            btnClear.Text = "Limpiar campos";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(60, 321);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(770, 210);
            dgvProducts.TabIndex = 12;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(882, 553);
            Controls.Add(dgvProducts);
            Controls.Add(btnClear);
            Controls.Add(btnDeactivate);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(chkIsActive);
            Controls.Add(txtCurrentPrice);
            Controls.Add(lblCurrentPrice);
            Controls.Add(cmbUnitMeasure);
            Controls.Add(lblUnitMeasure);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Name = "ProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Productos";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private TextBox txtName;
        private Label lblUnitMeasure;
        private ComboBox cmbUnitMeasure;
        private Label lblCurrentPrice;
        private TextBox txtCurrentPrice;
        private CheckBox chkIsActive;
        private Button btnSave;
        private Button btnEdit;
        private Button btnDeactivate;
        private Button btnClear;
        private DataGridView dgvProducts;
    }
}