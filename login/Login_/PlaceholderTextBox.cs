using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//no olvidar
using System.Windows.Forms;

// Clase que agrega funcionalidad de placeholder a un TextBox de Windows Forms.
public class PlaceholderTextBox
{
    // Campos privados
    // Referencia al TextBox al que se le aplicará el placeholder.
    private TextBox _textBox;
    // Texto que se mostrará como placeholder.
    private string _placeholderText;
    // Color del texto del placeholder (por ejemplo, gris claro).
    private Color _placeholderColor;

    // Color del texto cuando el usuario escribe (por ejemplo, negro).
    private Color _textColor;

    // Constructor de la clase PlaceholderTextBox
    /// <param name="textBox">El TextBox al que se aplicará el placeholder.</param>
    /// <param name="placeholderText">El texto del placeholder.</param>
    /// <param name="placeholderColor">El color del placeholder.</param>
    /// <param name="textColor">El color del texto real cuando el usuario escribe.</param>
    public PlaceholderTextBox(TextBox textBox, string placeholderText, Color placeholderColor, Color textColor)
    {
        // Asigna los parámetros a los campos privados correspondientes.
        _textBox = textBox;
        _placeholderText = placeholderText;
        _placeholderColor = placeholderColor;
        _textColor = textColor;

        // Inicializa el placeholder cuando se crea una instancia de la clase.
        SetPlaceholder();

        // Asocia los eventos Enter y Leave del TextBox a los métodos correspondientes.
        _textBox.Enter += RemovePlaceholder; // Evento que se dispara cuando el TextBox recibe el foco.
        _textBox.Leave += SetPlaceholder;  // Evento que se dispara cuando el TextBox pierde el foco.
    }


    // Método para establecer el placeholder en el TextBox.
    private void SetPlaceholder(object sender = null, EventArgs e = null)
    {
        // Verifica si el TextBox está vacío o contiene solo espacios en blanco.
        if (string.IsNullOrWhiteSpace(_textBox.Text))
        {
            // Establece el texto del placeholder.
            _textBox.Text = _placeholderText;
            // Cambia el color del texto al color del placeholder.
            _textBox.ForeColor = _placeholderColor;
        }
    }

    //Método para eliminar el placeholder cuando el usuario comienza a interactuar con el TextBox.
    private void RemovePlaceholder(object sender, EventArgs e)
    {
        // Verifica si el texto actual del TextBox es igual al texto del placeholder.
        if (_textBox.Text == _placeholderText)
        {
            // Borra el texto del TextBox para que el usuario pueda escribir.
            _textBox.Text = "";
            // Cambia el color del texto al color real (por ejemplo, negro).
            _textBox.ForeColor = _textColor;

        }
    }
}