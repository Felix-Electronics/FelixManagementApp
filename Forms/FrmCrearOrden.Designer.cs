﻿namespace FelixManagementApp.Forms
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
            dgvComputadoras = new DataGridView();
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
            label7 = new Label();
            label10 = new Label();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            button3 = new Button();
            btnActualizarCliente = new Button();
            btnClientes = new Button();
            btnOrdenes = new Button();
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
            // dgvComputadoras
            // 
            dgvComputadoras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComputadoras.Location = new Point(306, 12);
            dgvComputadoras.Name = "dgvComputadoras";
            dgvComputadoras.Size = new Size(482, 285);
            dgvComputadoras.TabIndex = 3;
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
            txtCosto.Location = new Point(466, 314);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(194, 23);
            txtCosto.TabIndex = 21;
            // 
            // cbTecnico
            // 
            cbTecnico.FormattingEnabled = true;
            cbTecnico.Location = new Point(84, 464);
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
            btnGuardar.Location = new Point(454, 356);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(216, 35);
            btnGuardar.TabIndex = 27;
            btnGuardar.Text = "CREAR NUEVA ORDEN";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnAgregarComp
            // 
            btnAgregarComp.BackColor = Color.FromArgb(64, 68, 75);
            btnAgregarComp.FlatAppearance.BorderSize = 0;
            btnAgregarComp.FlatStyle = FlatStyle.Flat;
            btnAgregarComp.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarComp.ForeColor = Color.White;
            btnAgregarComp.Location = new Point(96, 503);
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
            label9.Location = new Point(4, 472);
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
            label11.Location = new Point(4, 457);
            label11.Name = "label11";
            label11.Size = new Size(49, 15);
            label11.TabIndex = 41;
            label11.Text = "Técnico";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(388, 322);
            label12.Name = "label12";
            label12.Size = new Size(52, 15);
            label12.TabIndex = 44;
            label12.Text = "la orden";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(388, 307);
            label13.Name = "label13";
            label13.Size = new Size(55, 15);
            label13.TabIndex = 43;
            label13.Text = "Costo de";
            label13.Click += label13_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 68, 75);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Consolas", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(84, 49);
            button3.Name = "button3";
            button3.Size = new Size(66, 40);
            button3.TabIndex = 45;
            button3.Text = "AGREGAR CLIENTE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnActualizarCliente
            // 
            btnActualizarCliente.BackColor = Color.FromArgb(64, 68, 75);
            btnActualizarCliente.FlatAppearance.BorderSize = 0;
            btnActualizarCliente.FlatStyle = FlatStyle.Flat;
            btnActualizarCliente.Font = new Font("Consolas", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizarCliente.ForeColor = Color.White;
            btnActualizarCliente.Location = new Point(203, 49);
            btnActualizarCliente.Name = "btnActualizarCliente";
            btnActualizarCliente.Size = new Size(75, 40);
            btnActualizarCliente.TabIndex = 46;
            btnActualizarCliente.Text = "ACTUALIZAR CLIENTE";
            btnActualizarCliente.UseVisualStyleBackColor = false;
            btnActualizarCliente.Click += btnActualizarCliente_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(64, 68, 75);
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(539, 495);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(121, 35);
            btnClientes.TabIndex = 80;
            btnClientes.Text = "CLIENTES";
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
            btnOrdenes.Location = new Point(667, 495);
            btnOrdenes.Name = "btnOrdenes";
            btnOrdenes.Size = new Size(121, 35);
            btnOrdenes.TabIndex = 79;
            btnOrdenes.Text = "ORDENES";
            btnOrdenes.UseVisualStyleBackColor = false;
            btnOrdenes.Click += btnOrdenes_Click;
            // 
            // FrmCrearOrden
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(800, 540);
            Controls.Add(btnClientes);
            Controls.Add(btnOrdenes);
            Controls.Add(btnActualizarCliente);
            Controls.Add(button3);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label7);
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
            Controls.Add(dgvComputadoras);
            Controls.Add(cbCliente);
            Name = "FrmCrearOrden";
            Text = "FrmCrearOrden";
            ((System.ComponentModel.ISupportInitialize)dgvComputadoras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbCliente;
        private DataGridView dgvComputadoras;
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
        private Label label7;
        private Label label10;
        private Label label9;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button button3;
        private Button btnActualizarCliente;
        private Button btnClientes;
        private Button btnOrdenes;
    }
}