namespace FelixManagementApp.Forms
{
    partial class FrmLogin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            pictureBox1 = new PictureBox();
            BtnOk = new Button();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(29, 133);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(145, 23);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(29, 215);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(145, 23);
            txtPassword.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(82, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // BtnOk
            // 
            BtnOk.Location = new Point(198, 312);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(70, 23);
            BtnOk.TabIndex = 7;
            BtnOk.Text = "Ok";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 115);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 31;
            label3.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 197);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 32;
            label1.Text = "Contraseña";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(280, 347);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(BtnOk);
            Controls.Add(pictureBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "FrmLogin";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private PictureBox pictureBox1;
        private Button BtnOk;
        private Label label3;
        private Label label1;
    }
}