namespace ProyectoFinal_Jefferson_Y_Isaac
{
    partial class FormRegristro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegristro));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUsuarioReg = new TextBox();
            txtContaReg = new TextBox();
            txtPassConf = new TextBox();
            btnRegristrar = new Button();
            linkRegistrar = new LinkLabel();
            label6 = new Label();
            lblError = new Label();
            label7 = new Label();
            btnCerrar = new PictureBox();
            btnminimizar = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 192);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 417);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(90, 260);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(77, 85);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(55, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 230);
            label1.Name = "label1";
            label1.Size = new Size(214, 27);
            label1.TabIndex = 1;
            label1.Text = "\"CREA TU CUENTA\"";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(411, 22);
            label3.Name = "label3";
            label3.Size = new Size(245, 40);
            label3.TabIndex = 6;
            label3.Text = "REGRISTRARSE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(286, 114);
            label2.Name = "label2";
            label2.Size = new Size(513, 20);
            label2.TabIndex = 7;
            label2.Text = "____________________________________________________________________________________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(286, 163);
            label4.Name = "label4";
            label4.Size = new Size(513, 20);
            label4.TabIndex = 8;
            label4.Text = "____________________________________________________________________________________";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(286, 216);
            label5.Name = "label5";
            label5.Size = new Size(513, 20);
            label5.TabIndex = 9;
            label5.Text = "____________________________________________________________________________________";
            // 
            // txtUsuarioReg
            // 
            txtUsuarioReg.BackColor = SystemColors.InactiveCaptionText;
            txtUsuarioReg.BorderStyle = BorderStyle.None;
            txtUsuarioReg.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuarioReg.ForeColor = Color.DimGray;
            txtUsuarioReg.Location = new Point(286, 100);
            txtUsuarioReg.Name = "txtUsuarioReg";
            txtUsuarioReg.Size = new Size(513, 25);
            txtUsuarioReg.TabIndex = 10;
            txtUsuarioReg.Text = "USUARIO";
            txtUsuarioReg.TextChanged += txtUsuarioReg_TextChanged;
            txtUsuarioReg.Enter += txtUsuarioReg_Enter;
            txtUsuarioReg.Leave += txtUsuarioReg_Leave;
            // 
            // txtContaReg
            // 
            txtContaReg.BackColor = SystemColors.InactiveCaptionText;
            txtContaReg.BorderStyle = BorderStyle.None;
            txtContaReg.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContaReg.ForeColor = Color.DimGray;
            txtContaReg.Location = new Point(286, 148);
            txtContaReg.Name = "txtContaReg";
            txtContaReg.Size = new Size(513, 25);
            txtContaReg.TabIndex = 11;
            txtContaReg.Text = "CONTRASEÑA";
            txtContaReg.Enter += txtContaReg_Enter;
            txtContaReg.Leave += txtContaReg_Leave;
            // 
            // txtPassConf
            // 
            txtPassConf.BackColor = SystemColors.InactiveCaptionText;
            txtPassConf.BorderStyle = BorderStyle.None;
            txtPassConf.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassConf.ForeColor = Color.DimGray;
            txtPassConf.Location = new Point(286, 202);
            txtPassConf.Name = "txtPassConf";
            txtPassConf.Size = new Size(513, 25);
            txtPassConf.TabIndex = 12;
            txtPassConf.Text = "CONFIRMAR CONTRASEÑA";
            txtPassConf.TextChanged += txtPassConf_TextChanged;
            txtPassConf.Enter += txtPassConf_Enter;
            txtPassConf.Leave += txtPassConf_Leave;
            // 
            // btnRegristrar
            // 
            btnRegristrar.BackColor = Color.FromArgb(40, 40, 40);
            btnRegristrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnRegristrar.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnRegristrar.FlatStyle = FlatStyle.Flat;
            btnRegristrar.ForeColor = Color.Gray;
            btnRegristrar.Location = new Point(256, 284);
            btnRegristrar.Name = "btnRegristrar";
            btnRegristrar.Size = new Size(531, 40);
            btnRegristrar.TabIndex = 13;
            btnRegristrar.Text = "CREAR CUENTA";
            btnRegristrar.UseVisualStyleBackColor = false;
            btnRegristrar.Click += btnRegristrar_Click;
            // 
            // linkRegistrar
            // 
            linkRegistrar.ActiveLinkColor = Color.FromArgb(0, 0, 192);
            linkRegistrar.AutoSize = true;
            linkRegistrar.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkRegistrar.LinkColor = Color.Gray;
            linkRegistrar.Location = new Point(453, 367);
            linkRegistrar.Name = "linkRegistrar";
            linkRegistrar.Size = new Size(149, 21);
            linkRegistrar.TabIndex = 14;
            linkRegistrar.TabStop = true;
            linkRegistrar.Text = "INICIAR CUENTA";
            linkRegistrar.LinkClicked += linkRegistrar_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(453, 341);
            label6.Name = "label6";
            label6.Size = new Size(131, 17);
            label6.TabIndex = 15;
            label6.Text = "¿Ya tienes cuenta?";
            label6.Click += label6_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.DimGray;
            lblError.Location = new Point(462, 210);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 17);
            lblError.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(764, 358);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 17;
            label7.Text = "label7";
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(835, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(23, 20);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 18;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnminimizar
            // 
            btnminimizar.Image = (Image)resources.GetObject("btnminimizar.Image");
            btnminimizar.Location = new Point(806, 0);
            btnminimizar.Name = "btnminimizar";
            btnminimizar.Size = new Size(23, 20);
            btnminimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnminimizar.TabIndex = 19;
            btnminimizar.TabStop = false;
            btnminimizar.Click += btnminimizar_Click;
            // 
            // FormRegristro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(857, 417);
            Controls.Add(btnminimizar);
            Controls.Add(btnCerrar);
            Controls.Add(label7);
            Controls.Add(lblError);
            Controls.Add(label6);
            Controls.Add(linkRegistrar);
            Controls.Add(btnRegristrar);
            Controls.Add(txtPassConf);
            Controls.Add(txtContaReg);
            Controls.Add(txtUsuarioReg);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegristro";
            Text = "Regristro de Usuario";
            MouseDown += FormRegristro_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox txtUsuarioReg;
        private TextBox txtContaReg;
        private TextBox txtPassConf;
        private Button btnRegristrar;
        private LinkLabel linkRegistrar;
        private Label label6;
        private Label lblError;
        private Label label7;
        private PictureBox btnCerrar;
        private PictureBox btnminimizar;
    }
}