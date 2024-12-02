namespace FelixManagementApp.Forms
{
    partial class FrmEquipos
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
            label1 = new Label();
            lblTitulo = new Label();
            btnCerrarSesion = new Button();
            dgvEquipos = new DataGridView();
            btnClientes = new Button();
            btnOrdenes = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(237, 32);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(237, 73);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(330, 46);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Equipos de Clientes";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(64, 68, 75);
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(595, 22);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(193, 36);
            btnCerrarSesion.TabIndex = 7;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // dgvEquipos
            // 
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Location = new Point(12, 132);
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.RowHeadersWidth = 51;
            dgvEquipos.Size = new Size(776, 256);
            dgvEquipos.TabIndex = 8;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(64, 68, 75);
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(525, 394);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(127, 36);
            btnClientes.TabIndex = 10;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnOrdenes
            // 
            btnOrdenes.BackColor = Color.FromArgb(64, 68, 75);
            btnOrdenes.FlatAppearance.BorderSize = 0;
            btnOrdenes.FlatStyle = FlatStyle.Flat;
            btnOrdenes.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrdenes.ForeColor = Color.White;
            btnOrdenes.Location = new Point(663, 394);
            btnOrdenes.Name = "btnOrdenes";
            btnOrdenes.Size = new Size(124, 36);
            btnOrdenes.TabIndex = 11;
            btnOrdenes.Text = "Ordenes";
            btnOrdenes.UseVisualStyleBackColor = false;
            btnOrdenes.Click += btnOrdenes_Click;
            // 
            // FrmEquipos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(800, 450);
            Controls.Add(btnOrdenes);
            Controls.Add(btnClientes);
            Controls.Add(dgvEquipos);
            Controls.Add(btnCerrarSesion);
            Controls.Add(lblTitulo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmEquipos";
            Text = "Felix Electronics";
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTitulo;
        private Button btnCerrarSesion;
        private DataGridView dgvEquipos;
        private Button btnClientes;
        private Button btnOrdenes;
    }
}