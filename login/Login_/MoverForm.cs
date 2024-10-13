using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_
{
    internal class MoverForm
    {
        // Constantes y DLL para mover la ventana
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        // Método para habilitar el movimiento del formulario o cualquier control
        public static void Enable(Control control)
        {
            control.MouseDown += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    // Mover siempre el formulario que contiene el control, no el control en sí
                    SendMessage(control.FindForm().Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

                    //mueve cada objeto de manera individual
                    //SendMessage(control.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            };

        }
    }

}
