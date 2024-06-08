using Ofelia_Sara;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace practica
{
    public partial class fomulario_IPP : salto_de_input
    {
        // Importar las funciones de la API de Windows necesarias
        [DllImport("user32.dll")]
        private static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("user32.dll")]
        private static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);

        private const int WM_NCPAINT = 0x85;
        private const int WM_NCACTIVATE = 0x86;

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        public fomulario_IPP()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_NCPAINT || m.Msg == WM_NCACTIVATE)
            {
                IntPtr hdc = GetDC(this.Handle);
                if (hdc != IntPtr.Zero)
                {
                    Graphics g = Graphics.FromHdc(hdc);
                    DrawCustomTitleBar(g);
                    ReleaseDC(this.Handle, hdc);
                }
            }
        }

        private void DrawCustomTitleBar(Graphics g)
        {
            // Obtener el rect�ngulo de la barra de t�tulo
            RECT rect;
            GetWindowRect(this.Handle, out rect);

            // Definir la fuente y el formato del texto
            Font font = this.Font;
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            // Definir el rect�ngulo del texto
            int borderWidth = (rect.Right - rect.Left - this.ClientSize.Width) / 2;
            Rectangle titleRect = new Rectangle(0, 0, rect.Right - rect.Left, SystemInformation.CaptionHeight);

            // Dibujar el texto centrado en la barra de t�tulo
            g.DrawString(this.Text, font, Brushes.Black, titleRect, format);
        }

        // Eventos de la interfaz de usuario
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Para que el texto siempre sea mayuscula
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                textBox.Text = textBox.Text.ToUpper();
                // Coloca el cursor al final del texto para mantener la posici�n correcta
                textBox.SelectionStart = textBox.Text.Length;
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void EnviarImprimir_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarContenido_Click(object sender, EventArgs e)
        {
            // Limpiar todos los TextBox
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty; // reemplaza contenido por cadena vacia
                }
                // Limpiar todos los ComboBox
                if (control is ComboBox comboBox)
                {
                    comboBox.Text = string.Empty; // reemplaza contenido por cadena vacia
                }
                // Limpiar todos los numericUpDown
                if (control is NumericUpDown numericUpDown)
                {
                    numericUpDown.Text = string.Empty; // reemplaza contenido por cadena vacia
                }
            }
        }

        private void dato_DENUNCIANTE_TextChanged(object sender, EventArgs e)
        {
            // Para que el texto siempre sea mayuscula
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                textBox.Text = textBox.Text.ToUpper();
                // Coloca el cursor al final del texto para mantener la posici�n correcta
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void dato_IMPUTADO_TextChanged(object sender, EventArgs e)
        {
            // Para que el texto siempre sea mayuscula
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                textBox.Text = textBox.Text.ToUpper();
                // Coloca el cursor al final del texto para mantener la posici�n correcta
                textBox.SelectionStart = textBox.Text.Length;
            }
        }
    }
}
