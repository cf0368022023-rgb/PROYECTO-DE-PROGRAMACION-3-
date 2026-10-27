namespace LacteosLaFe.View
{
    partial class ClientsForm
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
            dgvClients = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.WhiteSmoke;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(229, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(336, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "GESTIÓN DE CLIENTES";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.DimGray;
            lblName.Location = new Point(12, 77);
            lblName.Name = "lblName";
            lblName.Size = new Size(76, 23);
            lblName.TabIndex = 1;
            lblName.Text = "Nombre";
            // 
            // txtName
            // 
            txtName.Location = new Point(94, 77);
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 27);
            txtName.TabIndex = 2;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = Color.DimGray;
            lblPhone.Location = new Point(423, 77);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(78, 23);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Teléfono";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(507, 76);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 27);
            txtPhone.TabIndex = 4;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = Color.DimGray;
            lblAddress.Location = new Point(12, 135);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(85, 23);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "Dirección";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(94, 131);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(400, 27);
            txtAddress.TabIndex = 6;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = CheckState.Checked;
            chkIsActive.ForeColor = Color.DimGray;
            chkIsActive.Location = new Point(12, 177);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(121, 24);
            chkIsActive.TabIndex = 7;
            chkIsActive.Text = "Cliente activo";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(12, 268);
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
            btnEdit.Location = new Point(183, 268);
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
            btnDeactivate.Location = new Point(360, 268);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(110, 35);
            btnDeactivate.TabIndex = 10;
            btnDeactivate.Text = "Desactivar";
            btnDeactivate.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Aquamarine;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.DimGray;
            btnClear.Location = new Point(536, 268);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(185, 35);
            btnClear.TabIndex = 11;
            btnClear.Text = "Limpiar campos";
            btnClear.UseVisualStyleBackColor = false;
           
            // 
            // dgvClients
            // 
            dgvClients.AllowUserToAddRows = false;
            dgvClients.AllowUserToDeleteRows = false;
            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClients.BackgroundColor = Color.White;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(12, 321);
            dgvClients.Name = "dgvClients";
            dgvClients.ReadOnly = true;
            dgvClients.RowHeadersWidth = 51;
            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClients.Size = new Size(780, 220);
            dgvClients.TabIndex = 12;
            // 
            // ClientsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(dgvClients);
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
            Name = "ClientsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Clientes";
            Load += ClientsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
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
        private DataGridView dgvClients;
    }
}