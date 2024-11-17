namespace FelixManagementApp.Forms
{
    partial class FrmAgregarCliente
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
            lblTitulo = new Label();
            btnGuardar = new Button();
            button1 = new Button();
            lbl = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtApellidoPaterno = new TextBox();
            txtApellidoMaterno = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(207, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(198, 37);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Nuevo Cliente";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(64, 68, 75);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(235, 361);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(170, 29);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 68, 75);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(517, 409);
            button1.Name = "button1";
            button1.Size = new Size(91, 29);
            button1.TabIndex = 6;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl.ForeColor = Color.White;
            lbl.Location = new Point(42, 89);
            lbl.Name = "lbl";
            lbl.Size = new Size(86, 25);
            lbl.TabIndex = 7;
            lbl.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(342, 89);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 8;
            label1.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(43, 165);
            label2.Name = "label2";
            label2.Size = new Size(167, 25);
            label2.TabIndex = 9;
            label2.Text = "Apellido materno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(349, 165);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 10;
            label3.Text = "Correo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(42, 237);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 11;
            label4.Text = "Telefono";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(47, 117);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(277, 23);
            txtNombre.TabIndex = 12;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Location = new Point(349, 117);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(277, 23);
            txtApellidoPaterno.TabIndex = 13;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Location = new Point(47, 193);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(277, 23);
            txtApellidoMaterno.TabIndex = 14;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(349, 193);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(277, 23);
            txtCorreo.TabIndex = 15;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(47, 265);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(277, 23);
            txtTelefono.TabIndex = 16;
            // 
            // FrmAgregarCliente
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(638, 450);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(txtApellidoMaterno);
            Controls.Add(txtApellidoPaterno);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl);
            Controls.Add(button1);
            Controls.Add(btnGuardar);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmAgregarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Felix Elextronics";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private Button btnGuardar;
        private Button button1;
        private Label lbl;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtApellidoPaterno;
        private TextBox txtApellidoMaterno;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
    }
}