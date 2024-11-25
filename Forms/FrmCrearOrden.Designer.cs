namespace FelixManagementApp.Forms
{
    partial class FrmCrearOrden
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
            cbCliente = new ComboBox();
            button1 = new Button();
            dgvComputadoras = new DataGridView();
            button2 = new Button();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            txtContra = new TextBox();
            txtAccesorios = new TextBox();
            txtProblema = new RichTextBox();
            cbEstatus = new ComboBox();
            timePicker = new DateTimePicker();
            txtCosto = new TextBox();
            cbTecnico = new ComboBox();
            btnGuardar = new Button();
            btnAgregarComp = new Button();
            lbl = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label7 = new Label();
            label10 = new Label();
            label9 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvComputadoras).BeginInit();
            SuspendLayout();
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(84, 26);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(194, 23);
            cbCliente.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(84, 55);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // dgvComputadoras
            // 
            dgvComputadoras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComputadoras.Location = new Point(306, 12);
            dgvComputadoras.Name = "dgvComputadoras";
            dgvComputadoras.Size = new Size(482, 285);
            dgvComputadoras.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(203, 55);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(84, 93);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(194, 23);
            txtMarca.TabIndex = 5;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(84, 139);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(194, 23);
            txtModelo.TabIndex = 7;
            // 
            // txtContra
            // 
            txtContra.Location = new Point(84, 182);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(194, 23);
            txtContra.TabIndex = 9;
            // 
            // txtAccesorios
            // 
            txtAccesorios.Location = new Point(84, 225);
            txtAccesorios.Name = "txtAccesorios";
            txtAccesorios.Size = new Size(194, 23);
            txtAccesorios.TabIndex = 11;
            // 
            // txtProblema
            // 
            txtProblema.Location = new Point(84, 268);
            txtProblema.Name = "txtProblema";
            txtProblema.Size = new Size(194, 96);
            txtProblema.TabIndex = 15;
            txtProblema.Text = "";
            // 
            // cbEstatus
            // 
            cbEstatus.FormattingEnabled = true;
            cbEstatus.Location = new Point(84, 382);
            cbEstatus.Name = "cbEstatus";
            cbEstatus.Size = new Size(194, 23);
            cbEstatus.TabIndex = 18;
            // 
            // timePicker
            // 
            timePicker.Location = new Point(84, 424);
            timePicker.Name = "timePicker";
            timePicker.Size = new Size(194, 23);
            timePicker.TabIndex = 19;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(84, 467);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(194, 23);
            txtCosto.TabIndex = 21;
            // 
            // cbTecnico
            // 
            cbTecnico.FormattingEnabled = true;
            cbTecnico.Location = new Point(84, 509);
            cbTecnico.Name = "cbTecnico";
            cbTecnico.Size = new Size(194, 23);
            cbTecnico.TabIndex = 24;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(64, 68, 75);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(456, 315);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(216, 35);
            btnGuardar.TabIndex = 27;
            btnGuardar.Text = "CREAR NUEVA ORDEN";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnAgregarComp
            // 
            btnAgregarComp.BackColor = Color.FromArgb(64, 68, 75);
            btnAgregarComp.FlatAppearance.BorderSize = 0;
            btnAgregarComp.FlatStyle = FlatStyle.Flat;
            btnAgregarComp.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarComp.ForeColor = Color.White;
            btnAgregarComp.Location = new Point(98, 544);
            btnAgregarComp.Name = "btnAgregarComp";
            btnAgregarComp.Size = new Size(164, 23);
            btnAgregarComp.TabIndex = 28;
            btnAgregarComp.Text = "AGREGAR COMPUTADORA";
            btnAgregarComp.UseVisualStyleBackColor = false;
            btnAgregarComp.Click += btnAgregarComp_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.ForeColor = Color.White;
            lbl.Location = new Point(12, 29);
            lbl.Name = "lbl";
            lbl.Size = new Size(46, 15);
            lbl.TabIndex = 29;
            lbl.Text = "Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 96);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 30;
            label1.Text = "Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 142);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 31;
            label2.Text = "Modelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 185);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 32;
            label3.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 228);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 33;
            label4.Text = "Accesorios";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 271);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 34;
            label5.Text = "Problema";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 385);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 35;
            label6.Text = "Estatus";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 470);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 37;
            label8.Text = "Costo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(12, 417);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 39;
            label7.Text = "Fecha";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(12, 432);
            label10.Name = "label10";
            label10.Size = new Size(68, 15);
            label10.TabIndex = 40;
            label10.Text = "de entrega";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(4, 517);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 42;
            label9.Text = "asignado";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(4, 502);
            label11.Name = "label11";
            label11.Size = new Size(49, 15);
            label11.TabIndex = 41;
            label11.Text = "Técnico";
            // 
            // FrmCrearOrden
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(800, 579);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl);
            Controls.Add(btnAgregarComp);
            Controls.Add(btnGuardar);
            Controls.Add(cbTecnico);
            Controls.Add(txtCosto);
            Controls.Add(timePicker);
            Controls.Add(cbEstatus);
            Controls.Add(txtProblema);
            Controls.Add(txtAccesorios);
            Controls.Add(txtContra);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(button2);
            Controls.Add(dgvComputadoras);
            Controls.Add(button1);
            Controls.Add(cbCliente);
            Name = "FrmCrearOrden";
            Text = "FrmCrearOrden";
            ((System.ComponentModel.ISupportInitialize)dgvComputadoras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbCliente;
        private Button button1;
        private DataGridView dgvComputadoras;
        private Button button2;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private TextBox txtContra;
        private TextBox txtAccesorios;
        private RichTextBox txtProblema;
        private ComboBox cbEstatus;
        private DateTimePicker timePicker;
        private TextBox txtCosto;
        private ComboBox cbTecnico;
        private Button btnGuardar;
        private Button btnAgregarComp;
        private Label lbl;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label10;
        private Label label9;
        private Label label11;
    }
}