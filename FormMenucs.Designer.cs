namespace ProyectoFinal_Jefferson_Y_Isaac
{
    partial class FormMenucs
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
            lblNombreUsuarioMenu = new Label();
            lblPosicionMenu = new Label();
            SuspendLayout();
            // 
            // lblNombreUsuarioMenu
            // 
            lblNombreUsuarioMenu.AutoSize = true;
            lblNombreUsuarioMenu.Location = new Point(401, 84);
            lblNombreUsuarioMenu.Name = "lblNombreUsuarioMenu";
            lblNombreUsuarioMenu.Size = new Size(50, 20);
            lblNombreUsuarioMenu.TabIndex = 0;
            lblNombreUsuarioMenu.Text = "label1";
            lblNombreUsuarioMenu.Click += lblNombreUsuarioMenu_Click;
            // 
            // lblPosicionMenu
            // 
            lblPosicionMenu.AutoSize = true;
            lblPosicionMenu.Location = new Point(394, 160);
            lblPosicionMenu.Name = "lblPosicionMenu";
            lblPosicionMenu.Size = new Size(50, 20);
            lblPosicionMenu.TabIndex = 1;
            lblPosicionMenu.Text = "label2";
            // 
            // FormMenucs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPosicionMenu);
            Controls.Add(lblNombreUsuarioMenu);
            Name = "FormMenucs";
            Text = "FormMenucs";
            Load += FormMenucs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreUsuarioMenu;
        private Label lblPosicionMenu;
    }
}