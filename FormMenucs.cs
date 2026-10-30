using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

    

namespace ProyectoFinal_Jefferson_Y_Isaac
{
    public partial class FormMenucs : Form
    {


        public string? NombreUsuario { get; set; }
        public string? Posicion { get; set; } 
        public FormMenucs()
        {
            InitializeComponent();
        }

        private void FormMenucs_Load(object sender, EventArgs e)
        {
            lblNombreUsuarioMenu.Text = $"Usuario: {NombreUsuario!}";
            lblPosicionMenu.Text = $"Posición: {Posicion!}";
        }

        private void lblNombreUsuarioMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
