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
            dgvEquipos = new DataGridView();
            btnClientes = new Button();
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
            // dgvEquipos
            // 
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Location = new Point(11, 132);
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
            btnClientes.Location = new Point(349, 403);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(127, 36);
            btnClientes.TabIndex = 10;
            btnClientes.Text = "Volver";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // FrmEquipos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(800, 451);
            Controls.Add(btnClientes);
            Controls.Add(dgvEquipos);
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
        private DataGridView dgvEquipos;
        private Button btnClientes;
    }
}