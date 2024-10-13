using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_
{
    public partial class Form2 : Form
    {

        private Form1 ventanaLogin;
        private PlaceholderTextBox placeholderNombreCompleto;
        private PlaceholderTextBox placeholderCorreo;
        private PlaceholderTextBox placeholderUsuarioNuevo;
        private PlaceholderTextBox placeholderContraseñaNueva;


        public Form2()
        {
            InitializeComponent();
            MoverForm.Enable(this);
            MoverForm.Enable(pnlPaneRegistro);

            this.ventanaLogin = new Form1();

            placeholderNombreCompleto=new PlaceholderTextBox(txtNombreCompleto,"",Color.Gray,Color.Black);
            placeholderCorreo = new PlaceholderTextBox(txtNombreCompleto, "", Color.Gray, Color.Black);
            placeholderUsuarioNuevo = new PlaceholderTextBox(txtNombreCompleto, "", Color.Gray, Color.Black);
            placeholderContraseñaNueva = new PlaceholderTextBox(txtNombreCompleto, "", Color.Gray, Color.Black);

            DiseñoButton.DiseñoBtn(btnRegistrar);
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Establece la posición y el tamaño de Form2 para que coincida con Form1
            //estás indicando que la posición del formulario crearCuenta será definida manualmente por el programador. 
            ventanaLogin.StartPosition = FormStartPosition.Manual;
            ventanaLogin.Location = this.Location;
            ventanaLogin.Size = this.Size;
            // Muestra Form1 y oculta Form2
            ventanaLogin.Show();

            // Cierra el Form2 (puedes usar Close() si es modal o Hide() si necesitas mantener Form1 en segundo plano)
            this.Hide();
        }

        private void imgGmail_MouseClick(object sender, MouseEventArgs e)
        {
            txtGmail.Text = "@gmail.com";
        }

        private void imgOutlook_Click(object sender, EventArgs e)
        {
            txtGmail.Text = "@outlook.com";
        }

        private void imgYahoo_Click(object sender, EventArgs e)
        {
            txtGmail.Text = "@yahoo.com";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtNombreUsuario.Text) || String.IsNullOrEmpty(txtCorreo.Text) || String.IsNullOrEmpty(txtGmail.Text) || String.IsNullOrEmpty(txtNombreUsuario.Text) || String.IsNullOrEmpty(txtContraseñaNueva.Text) )
            {
                MessageBox.Show("Falta ingresar algunos datos!!","Error de Registro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Se ha registrado satisfactoriamente!","Listo",MessageBoxButtons.OK,MessageBoxIcon.None);
            }

        }


    }
}
