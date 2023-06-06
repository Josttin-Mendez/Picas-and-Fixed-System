using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JuegoPicasYFijas
{
    public partial class Configuración : Form
    {
        string NombreUsuario = "Josttin";
        string ContrasenaUsuario = "12345";
        string Usuario;
        string Contrasena;
        int Minutos;
        int Segundos;
        int NumeroIntentosConfiguración;
        public Configuración()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener valores de usuario y contraseña ingresados en los TextBox
            Usuario = textBox1.Text;
            Contrasena = textBox2.Text;

            // Comprobar si los valores son correctos
            if (Usuario.Equals(NombreUsuario) && Contrasena.Equals(ContrasenaUsuario))
            {
                // Si son correctos, ocultar los controles de inicio de sesión y mostrar los de configuración
                textBox1.Visible = false;
                textBox2.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                button1.Visible = false;
                label1.Text = "Configuración";
                label4.Visible = true;
                label5.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                button2.Visible = true;
            }
            else
            {
                // Si son incorrectos, mostrar mensaje de error
                MessageBox.Show("Credenciales inválidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Comprobar si los campos de número de intentos y tiempo no están vacíos
            if (String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(textBox4.Text))
            {
                // Si están vacíos, mostrar mensaje de error
                MessageBox.Show("Hay campos vacíos", "Null", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Obtener los valores de número de intentos, minutos y segundos ingresados en los TextBox
                NumeroIntentosConfiguración = int.Parse(textBox3.Text);
                Minutos = int.Parse(textBox4.Text);
                Segundos = int.Parse(textBox5.Text);

                // Comprobar si los valores son correctos
                if (Minutos <= 90 && Minutos >= 0 && Segundos <= 60 && Segundos >= 5)
                {
                    if (NumeroIntentosConfiguración >= 1)
                    {
                        // Si son correctos, asignarlos a las variables correspondientes del juego y cerrar la ventana de configuración
                        Juego.NumeroIntentos = NumeroIntentosConfiguración;
                        Juego.NumeroRestaIntentos = Juego.NumeroIntentos;

                        Juego.Minutos = Minutos;
                        Juego.MinutosResta = Juego.Minutos;

                        Juego.Segundos = Segundos;
                        Juego.SegundosResta = Juego.Segundos;

                        this.Close();
                    }
                    else
                    {
                        // Si el número de intentos es incorrecto, mostrar mensaje de error
                        MessageBox.Show("El número de intentos debe ser mayor a 0 ", "Intentos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Si el tiempo es incorrecto, mostrar mensaje de error
                    MessageBox.Show("El tiempo no es correcto, debe ser menor de 90 en MM y menor de 60 en SS", "Tiempo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

