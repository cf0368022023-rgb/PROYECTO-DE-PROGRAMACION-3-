namespace LacteosLaFe.View
{
    partial class SuppliersForm
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
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            chkIsActive = new CheckBox();
            btnSave = new Button();
            btnEdit = new Button();
            btnDeactivate = new Button();
            btnClear = new Button();
            dgvSuppliers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(312, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(412, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "GESTIÓN DE PROVEEDORES";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.DimGray;
            lblName.Location = new Point(66, 65);
            lblName.Name = "lblName";
            lblName.Size = new Size(76, 23);
            lblName.TabIndex = 1;
            lblName.Text = "Nombre";
            // 
            // txtName
            // 
            txtName.Location = new Point(160, 65);
            txtName.MaxLength = 100;
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 27);
            txtName.TabIndex = 2;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = Color.DimGray;
            lblPhone.Location = new Point(66, 124);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(78, 23);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Teléfono";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(160, 120);
            txtPhone.MaxLength = 20;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 27);
            txtPhone.TabIndex = 4;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = Color.DimGray;
            lblAddress.Location = new Point(64, 174);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(85, 23);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "Dirección";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(160, 173);
            txtAddress.MaxLength = 200;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(400, 27);
            txtAddress.TabIndex = 6;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = CheckState.Checked;
            chkIsActive.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkIsActive.ForeColor = Color.DimGray;
            chkIsActive.Location = new Point(406, 123);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(149, 24);
            chkIsActive.TabIndex = 7;
            chkIsActive.Text = "Proveedor activo";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(96, 251);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 35);
            btnSave.TabIndex = 8;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.LightSteelBlue;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(276, 251);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(110, 35);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDeactivate
            // 
            btnDeactivate.BackColor = Color.IndianRed;
            btnDeactivate.FlatStyle = FlatStyle.Flat;
            btnDeactivate.ForeColor = Color.White;
            btnDeactivate.Location = new Point(464, 251);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(110, 35);
            btnDeactivate.TabIndex = 10;
            btnDeactivate.Text = "Desactivar";
            btnDeactivate.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gainsboro;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.DimGray;
            btnClear.Location = new Point(612, 251);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(184, 35);
            btnClear.TabIndex = 11;
            btnClear.Text = "Limpiar campos";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.AllowUserToAddRows = false;
            dgvSuppliers.AllowUserToDeleteRows = false;
            dgvSuppliers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuppliers.BackgroundColor = Color.White;
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.Location = new Point(96, 321);
            dgvSuppliers.MultiSelect = false;
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.ReadOnly = true;
            dgvSuppliers.RowHeadersWidth = 51;
            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.Size = new Size(700, 220);
            dgvSuppliers.TabIndex = 12;
            // 
            // SuppliersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(882, 553);
            Controls.Add(dgvSuppliers);
            Controls.Add(btnClear);
            Controls.Add(btnDeactivate);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(chkIsActive);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Name = "SuppliersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Proveedores";
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private TextBox txtName;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblAddress;
        private TextBox txtAddress;
        private CheckBox chkIsActive;
        private Button btnSave;
        private Button btnEdit;
        private Button btnDeactivate;
        private Button btnClear;
        private DataGridView dgvSuppliers;
    }
}