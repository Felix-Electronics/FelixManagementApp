﻿namespace FelixManagementApp.Forms
{
    partial class FrmOrdenes
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
            dgvOrdenes = new DataGridView();
            button1 = new Button();
            btnClientes = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenes).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(325, 41);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(153, 46);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Ordenes";
            // 
            // dgvOrdenes
            // 
            dgvOrdenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenes.Location = new Point(11, 111);
            dgvOrdenes.Name = "dgvOrdenes";
            dgvOrdenes.RowHeadersWidth = 51;
            dgvOrdenes.Size = new Size(776, 283);
            dgvOrdenes.TabIndex = 9;
            dgvOrdenes.CellDoubleClick += dgvOrdenes_CellDoubleClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 68, 75);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(315, 403);
            button1.Name = "button1";
            button1.Size = new Size(171, 36);
            button1.TabIndex = 10;
            button1.Text = "Nueva Orden";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(64, 68, 75);
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(664, 403);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(123, 36);
            btnClientes.TabIndex = 11;
            btnClientes.Text = "Volver";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // FrmOrdenes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(800, 451);
            Controls.Add(btnClientes);
            Controls.Add(button1);
            Controls.Add(dgvOrdenes);
            Controls.Add(lblTitulo);
            Name = "FrmOrdenes";
            Text = "FrmOrdenes";
            ((System.ComponentModel.ISupportInitialize)dgvOrdenes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dgvOrdenes;
        private Button button1;
        private Button btnClientes;
    }
}