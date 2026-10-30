using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;




namespace ProyectoFinal_Jefferson_Y_Isaac
{
    public partial class FormRegristro : Form
    {
        public FormRegristro()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int msg, int wParam, int lParam);




        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuarioReg_Enter(object sender, EventArgs e)
        {
            if (txtUsuarioReg.Text == "USUARIO")
            {
                txtUsuarioReg.Text = "";
                txtUsuarioReg.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuarioReg_Leave(object sender, EventArgs e)
        {
            if (txtUsuarioReg.Text == "")
            {
                txtUsuarioReg.Text = "USUARIO";
                txtUsuarioReg.ForeColor = Color.DimGray;
            }
        }

        private void txtContaReg_Enter(object sender, EventArgs e)
        {
            if (txtContaReg.Text == "CONTRASEÑA")
            {
                txtContaReg.Text = "";
                txtContaReg.ForeColor = Color.LightGray;
                txtContaReg.UseSystemPasswordChar = true;
            }
        }

        private void txtContaReg_Leave(object sender, EventArgs e)
        {
            if (txtContaReg.Text == "")
            {
                txtContaReg.Text = "CONTRASEÑA";
                txtContaReg.ForeColor = Color.DimGray;
                txtContaReg.UseSystemPasswordChar = false;
            }
        }

        private void txtPassConf_Enter(object sender, EventArgs e)
        {
            if (txtPassConf.Text == "CONFIRMAR CONTRASEÑA")
            {
                txtPassConf.Text = "";
                txtPassConf.ForeColor = Color.LightGray;
                txtPassConf.UseSystemPasswordChar = true;
            }
        }

        private void txtPassConf_Leave(object sender, EventArgs e)
        {
            if (txtPassConf.Text == "")
            {
                txtPassConf.Text = "CONFIRMAR CONTRASEÑA";
                txtPassConf.ForeColor = Color.DimGray;
                txtPassConf.UseSystemPasswordChar = false;
            }
        }

        private void txtPassConf_TextChanged(object sender, EventArgs e)
        {
            if (txtContaReg.Text != txtPassConf.Text)
            {
                lblError.Visible = true;
                lblError.Text = "Las contraseñas no coinciden";
            }
            else
            {
                lblError.Visible = false;
            }

        }

        private void linkRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            {
                this.Close();
            }
        }

        private void btnRegristrar_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            // ✅ Tus validaciones — NO se tocan
            if (string.IsNullOrWhiteSpace(txtUsuarioReg.Text) || string.IsNullOrWhiteSpace(txtContaReg.Text))
            {
                lblError.Visible = true;
                lblError.Text = "Por favor, completa todos los campos";
                return;
            }
            else if (txtContaReg.Text != txtPassConf.Text)
            {
                lblError.Visible = true;
                lblError.Text = "Las contraseñas no coinciden";
                return;
            }

            try
            {
                // 🔹 Verificar si el usuario ya existe en la base de datos
                bool usuarioExiste = false;

                using (var conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string verificar = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @NombreUsuario";
                    using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(verificar, conexion))
                    {
                        cmd.Parameters.AddWithValue("@NombreUsuario", txtUsuarioReg.Text);
                        int cantidad = (int)cmd.ExecuteScalar();
                        usuarioExiste = cantidad > 0;
                    }
                }

                if (usuarioExiste)
                {
                    lblError.Visible = true;
                    lblError.Text = "Este nombre de usuario ya existe";
                    return;
                }

                // 🔹 Insertar el nuevo usuario en la base de datos
                using (var conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string insertar = @"INSERT INTO Usuarios (NombreUsuario, Contrasena)
                               VALUES (@NombreUsuario, @Contrasena)";

                    using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(insertar, conexion))
                    {
                        cmd.Parameters.AddWithValue("@NombreUsuario", txtUsuarioReg.Text);
                        cmd.Parameters.AddWithValue("@Contrasena", txtContaReg.Text);
                        

                        cmd.ExecuteNonQuery();
                    }
                }

                // ✅ Mensaje de éxito — igual que antes
                MessageBox.Show("Registro exitoso!\nYa puedes iniciar sesión!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void FormRegristro_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        public static List<Usuario> ListaUsuarios = new List<Usuario>();

        private void txtUsuarioReg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
public class Usuario
{
    public string NombreUsuario { get; set; }
    public string Correo { get; set; }
    public string Contrasena { get; set; }
    public Usuario(string nombreUsuario, string contrasena)
    {
        NombreUsuario = nombreUsuario;
        
        Contrasena = contrasena;
    }
}