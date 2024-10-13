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
    public partial class Form1 : Form
    {
        private PlaceholderTextBox placeholderUsuario;
        private PlaceholderTextBox placeholderContraseña;
        private PasswordPlaceholderTextBox passwordPlaceholderContraseña;

        

        public Form1()
        {
            InitializeComponent();
            MoverForm.Enable(this);
            MoverForm.Enable(imgLogo);
            MoverForm.Enable(pnlPanel1);
           



            // Inicializa el PlaceholderTextBox para txtUsuario.
            // Parámetros:
            // - txtUsuario: El TextBox al que se aplicará el placeholder.
            // - "usuario": El texto del placeholder.
            // - Color.LightGray: El color del placeholder (gris claro).
            // - Color.Black: El color del texto real cuando el usuario escribe.
            placeholderUsuario = new PlaceholderTextBox(txtUsuario, "Usuario", Color.Gray, Color.Black);
            placeholderContraseña = new PlaceholderTextBox(txtContraseña, "Contraseña", Color.Gray, Color.Black);

            // Inicializa el PasswordPlaceholderTextBox para txtContraseña
            passwordPlaceholderContraseña = new PasswordPlaceholderTextBox(txtContraseña, "Contraseña", Color.Gray, Color.Black);

            DiseñoButton.DiseñoBtn(btnIngresar);
        }


        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Verificar si txtUsuario está vacío
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || txtUsuario.Text == "Usuario")
            {
                MessageBox.Show("Ingresar un Usuario/Contraseña registrado!", "Error de Logeo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }else if(string.IsNullOrWhiteSpace(txtContraseña.Text) || txtContraseña.Text == "Contraseña")
            {
               MessageBox.Show("Aun no ha ingresado su contraseña!", "Error de Logeo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linklblRegistrate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Form2 crearCuenta = new Form2();
            // Establece la posición y el tamaño de Form2 para que coincida con Form1
            //estás indicando que la posición del formulario crearCuenta será definida manualmente por el programador. 
            crearCuenta.StartPosition = FormStartPosition.Manual;
            crearCuenta.Location = this.Location;
            crearCuenta.Size = this.Size;
            crearCuenta.Show();

            // Cierra el Form1 (puedes usar Close() si es modal o Hide() si necesitas mantener Form1 en segundo plano)
            this.Hide();


        }
    }
}
