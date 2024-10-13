using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_
{

    internal class DiseñoButton
    {
        public static Color TextoOriginal;

        public static void DiseñoBtn(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.BorderColor = Color.Gray;
            //hacer que el mouse cuando pasa no haga sombra en el boton ya que el color es el mismo y no se nota
            btn.FlatAppearance.MouseOverBackColor = btn.BackColor;

            // Guardar el color original del texto
            TextoOriginal = btn.ForeColor= Color.Black;

            // Agregar eventos de mouse
            btn.MouseEnter += (sender, e) =>
            {
                btn.ForeColor = Color.DarkOrchid; // Cambiar el color del texto al pasar el mouse
            };

            btn.MouseLeave += (sender, e) =>
            {
                btn.ForeColor = TextoOriginal; // Restaurar el color original del texto al salir
            };


        }



    }



}
