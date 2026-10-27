namespace LacteosLaFe.View
{
    partial class InventoryLocationsForm
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
            chkIsActive = new CheckBox();
            btnSave = new Button();
            btnEdit = new Button();
            btnDeactivate = new Button();
            btnClear = new Button();
            dgvLocations = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLocations).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(182, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(472, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "UBICACIONES DE INVENTARIO  ";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.DimGray;
            lblName.Location = new Point(12, 66);
            lblName.Name = "lblName";
            lblName.Size = new Size(76, 23);
            lblName.TabIndex = 1;
            lblName.Text = "Nombre";
            // 
            // txtName
            // 
            txtName.Location = new Point(106, 62);
            txtName.MaxLength = 50;
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 27);
            txtName.TabIndex = 2;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.DimGray;
            lblDescription.Location = new Point(12, 108);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(103, 23);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Descripción";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(136, 108);
            txtDescription.MaxLength = 150;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(430, 27);
            txtDescription.TabIndex = 4;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = CheckState.Checked;
            chkIsActive.ForeColor = Color.DimGray;
            chkIsActive.Location = new Point(12, 160);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(140, 24);
            chkIsActive.TabIndex = 5;
            chkIsActive.Text = "Ubicación activa";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(31, 213);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 35);
            btnSave.TabIndex = 6;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.LightSteelBlue;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(243, 213);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(110, 35);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDeactivate
            // 
            btnDeactivate.BackColor = Color.IndianRed;
            btnDeactivate.FlatStyle = FlatStyle.Flat;
            btnDeactivate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeactivate.ForeColor = Color.White;
            btnDeactivate.Location = new Point(429, 213);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(110, 35);
            btnDeactivate.TabIndex = 8;
            btnDeactivate.Text = "Desactivar";
            btnDeactivate.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gainsboro;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.DimGray;
            btnClear.Location = new Point(634, 213);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(125, 35);
            btnClear.TabIndex = 9;
            btnClear.Text = "Limpiar campos";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // dgvLocations
            // 
            dgvLocations.AllowUserToAddRows = false;
            dgvLocations.AllowUserToDeleteRows = false;
            dgvLocations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLocations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLocations.BackgroundColor = Color.White;
            dgvLocations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocations.Location = new Point(31, 254);
            dgvLocations.MultiSelect = false;
            dgvLocations.Name = "dgvLocations";
            dgvLocations.ReadOnly = true;
            dgvLocations.RowHeadersWidth = 51;
            dgvLocations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLocations.Size = new Size(737, 220);
            dgvLocations.TabIndex = 10;
            // 
            // InventoryLocationsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(882, 523);
            Controls.Add(dgvLocations);
            Controls.Add(btnClear);
            Controls.Add(btnDeactivate);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(chkIsActive);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Name = "InventoryLocationsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ubicaciones de Inventario";
            ((System.ComponentModel.ISupportInitialize)dgvLocations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private TextBox txtName;
        private Label lblDescription;
        private TextBox txtDescription;
        private CheckBox chkIsActive;
        private Button btnSave;
        private Button btnEdit;
        private Button btnDeactivate;
        private Button btnClear;
        private DataGridView dgvLocations;
    }
}