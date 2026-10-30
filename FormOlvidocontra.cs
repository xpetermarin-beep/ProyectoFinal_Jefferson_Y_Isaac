using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace ProyectoFinal_Jefferson_Y_Isaac
{
    public partial class FormOlvidocontra : Form
    {
        public FormOlvidocontra()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)

        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void btnRecuperarContra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuarioOlvi.Text) ||

                string.IsNullOrWhiteSpace(txtNewpass.Text))
            {
                MessageBox.Show("Completa todos los campos",
                    "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var usuario = FormRegristro.ListaUsuarios
                .FirstOrDefault(u => u.NombreUsuario == txtUsuarioOlvi.Text);


            if (usuario == null)
            {
                MessageBox.Show(" No se encontró ese usuario",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            usuario.Contrasena = txtNewpass.Text;

            MessageBox.Show("¡Contraseña actualizada con éxito!",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void lnkIniciarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void txtUsuarioOlvi_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuarioOlvi.Text == "Usuario")
            {
                txtUsuarioOlvi.ForeColor = Color.Gray;
            }
            else
            {
                txtUsuarioOlvi.ForeColor = Color.Black;
            }

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuarioOlvi_Enter(object sender, EventArgs e)
        {
            if (txtUsuarioOlvi.Text == "Usuario")
            {
                txtUsuarioOlvi.Text = "";
                txtUsuarioOlvi.ForeColor = Color.LightGray;
            }


        }

        private void txtUsuarioOlvi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuarioOlvi.Text))
            {
                txtUsuarioOlvi.Text = "Usuario";
                txtUsuarioOlvi.ForeColor = Color.Gray;
            }


        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {

        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {



        }

        private void txtNewpass_Enter(object sender, EventArgs e)
        {
            if
                (txtNewpass.Text == "Nueva Contraseña")
            {
                txtNewpass.Text = "";
                txtNewpass.ForeColor = Color.LightGray;
                txtNewpass.UseSystemPasswordChar = true;
            }


        }

        private void txtNewpass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewpass.Text))
            {
                txtNewpass.Text = "Nueva Contraseña";
                txtNewpass.ForeColor = Color.LightGray;
                txtNewpass.UseSystemPasswordChar = false;
            }
        }

        private void txtNewpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNewpass_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtNewpass.Text == "Nueva Contraseña")
            {
                txtNewpass.Text = "";
                txtNewpass.ForeColor = Color.LightGray;
                txtNewpass.UseSystemPasswordChar = true;
            }
        }

        private void FormOlvidocontra_Load(object sender, EventArgs e)
        {

        }
    }
}
        
    

