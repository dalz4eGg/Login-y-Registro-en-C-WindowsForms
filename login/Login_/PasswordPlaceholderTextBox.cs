using System;
using System.Drawing;
using System.Windows.Forms;

public class PasswordPlaceholderTextBox
{
    private TextBox _textBox;
    private string _placeholderText;
    private Color _placeholderColor;
    private Color _textColor;
    private char _passwordChar;

    public PasswordPlaceholderTextBox(TextBox textBox, string placeholderText, Color placeholderColor, Color textColor, char passwordChar = '•')
    {
        _textBox = textBox;
        _placeholderText = placeholderText;
        _placeholderColor = placeholderColor;
        _textColor = textColor;
        _passwordChar = passwordChar;

        // Inicializa el placeholder y sus eventos
        SetPlaceholder();
        _textBox.Enter += OnEnter;
        _textBox.Leave += OnLeave;
    }

    private void SetPlaceholder()
    {
        if (string.IsNullOrWhiteSpace(_textBox.Text))
        {
            _textBox.Text = _placeholderText;
            _textBox.ForeColor = _placeholderColor;
            _textBox.PasswordChar = '\0'; // Sin caracteres ocultos
        }
    }

    private void OnEnter(object sender, EventArgs e)
    {
        if (_textBox.Text == _placeholderText)
        {
            _textBox.Text = ""; // Limpia el texto de placeholder
            _textBox.ForeColor = _textColor; // Cambia el color a negro
        }
        _textBox.PasswordChar = _passwordChar; // Establece el caracter de contraseña
    }

    private void OnLeave(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(_textBox.Text))
        {
            _textBox.Text = _placeholderText; // Si está vacío, restablece el placeholder
            _textBox.ForeColor = _placeholderColor; // Cambia el color a gris
            _textBox.PasswordChar = '\0'; // Sin caracteres ocultos
        }
    }
}

