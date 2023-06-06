using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoPicasYFijas
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Este método se activa cuando se carga el formulario.
            // Actualmente está vacío y no hace nada en particular.
        }
        private void label1_Click(object sender, EventArgs e)
        {
            // Este método se activa cuando se hace clic en el control de etiqueta "label1".
            // Actualmente está vacío y no hace nada en particular.
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Este método se activa cuando se hace clic en el botón "button1".
            // Crea una instancia de un formulario llamado "Juego" y lo muestra.
            Juego Form2 = new Juego();
            Form2.Show();
            // Oculta el formulario actual.
            this.Hide();
        }
    }
}
