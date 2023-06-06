using Guna.UI2.WinForms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace JuegoPicasYFijas
{
    public partial class Juego : Form
    {
        int Intentos = 1;
        int Tiempo = 0;
        int i = 0;
        public int y = 0;
        public int x = 0;
        public static int NumeroIntentos = 6;
        public static int NumeroRestaIntentos;
        public int num;
        public int numo;
        public int[] nums = new int[6];
        public int cont = 0;
        public static int Minutos = 2;
        public static int Segundos = 30;
        public static int MinutosResta, SegundosResta;

        Random Random = new Random();

        public Juego()
        {
            // Se llama al método InitializeComponent para inicializar los controles de la interfaz gráfica
            InitializeComponent();

            // Se establece el texto de la etiqueta label5 con el valor de la variable NumeroIntentos
            label5.Text = NumeroIntentos.ToString();

            // Se establece el texto de las etiquetas label7 y label8 con los valores de las variables estáticas Minutos y Segundos, respectivamente
            label7.Text = Minutos.ToString();
            label8.Text = Segundos.ToString();

            // Se asigna el valor de la variable NumeroIntentos a la variable estática NumeroRestaIntentos
            NumeroRestaIntentos = NumeroIntentos;

            // Se asignan los valores de las variables estáticas Minutos y Segundos a las variables estáticas MinutosResta y SegundosResta, respectivamente
            MinutosResta = Minutos;
            SegundosResta = Segundos;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
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
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Se genera un número aleatorio entre 100000 y 999999 y se asigna a la variable num
            num = Random.Next(100000, 999999);

            // Se asigna el valor de num a la variable numo
            numo = num;

            // Se habilitan los temporizadores timer1 y timer4
            timer1.Enabled = true;
            timer4.Enabled = true;
            label9.Enabled = true;
        }


        private void button2_Click(object sender, EventArgs e)
        {

            int contp = 0;
            int contf = 0;
            int n1, n2, n3, n4, n5, n6;
            bool numerosDiferentes = true;

            if (label2.Text.Equals(""))
            {
                MessageBox.Show("No se ha generado un número, presione - Jugar -", "Error número", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                button1.Enabled = false;
                button5.Enabled = false;
                timer4.Enabled = true;

                if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(textBox4.Text) || String.IsNullOrEmpty(textBox5.Text) || String.IsNullOrEmpty(textBox6.Text))
                {
                    MessageBox.Show("Faltan numeros por digitar", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    n1 = int.Parse(textBox1.Text);
                    n2 = int.Parse(textBox2.Text);
                    n3 = int.Parse(textBox3.Text);
                    n4 = int.Parse(textBox4.Text);
                    n5 = int.Parse(textBox5.Text);
                    n6 = int.Parse(textBox6.Text);

                    if (n1 == n2 || n1 == n3 || n1 == n4 || n1 == n5 || n1 == n6 || n2 == n3 || n2 == n4 || n2 == n5 || n2 == n6 || n3 == n4 || n3 == n5 || n3 == n6 || n4 == n5 || n4 == n6 || n5 == n6)
                    {
                        numerosDiferentes = false;
                        MessageBox.Show("No se pueden ingresar números repetidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    if (n1 == 6 && n2 == 6 && n3 == 6 && n4 == 6 && n5 == 6 && n6 == 6)
                    {
                        textBox1.Enabled = false;
                        textBox2.Enabled = false;
                        textBox3.Enabled = false;
                        textBox5.Enabled = false;
                        textBox6.Enabled = false;
                        button2.Enabled = false;
                        button2.Enabled = false;
                        this.BackColor = Color.White;
                        timer4.Enabled = false;
                    }
                    NumeroRestaIntentos--;
                    label5.Text = NumeroRestaIntentos.ToString();

                    if (NumeroIntentos >= 4)
                    {
                        if (NumeroRestaIntentos == NumeroIntentos / 2)
                        {
                            this.BackColor = Color.White;
                        }
                    }
                    if (NumeroRestaIntentos == 1)
                    {
                        timer6.Enabled = true;
                    }

                    if (n1 == nums[0])
                    {
                        contf++;
                    }
                    if (n2 == nums[1])
                    {
                        contf++;
                    }
                    if (n3 == nums[2])
                    {
                        contf++;
                    }
                    if (n4 == nums[3])
                    {
                        contf++;
                    }
                    if (n5 == nums[4])
                    {
                        contf++;
                    }
                    if (n6 == nums[5])
                    {
                        contf++;
                    }

                    if (contf == 6)
                    {
                        label11.Visible = true;
                        timer5.Enabled = true;
                        timer4.Enabled = false;
                    }

                    for (int i = 0; i < 6; i++)
                    {
                        if (n1 == nums[i] && i != 0)
                        {
                            contp++;
                        }
                    }
                    for (int j = 0; j < 6; j++)
                    {
                        if (n2 == nums[j] && j != 1)
                        {
                            contp++;
                        }
                    }
                    for (int k = 0; k < 6; k++)
                    {
                        if (n3 == nums[k] && k != 2)
                        {
                            contp++;
                        }
                    }
                    for (int l = 0; l < 6; l++)
                    {
                        if (n4 == nums[l] && l != 3)
                        {
                            contp++;
                        }
                    }
                    for (int m = 0; m < 6; m++)
                    {
                        if (n5 == nums[m] && m != 4)
                        {
                            contp++;
                        }
                    }
                    for (int h = 0; h < 6; h++)
                    {
                        if (n6 == nums[h] && h != 5)
                        {
                            contp++;
                        }
                    }

                    if (NumeroRestaIntentos == 0 && contf != 6)
                    {
                        textBox1.Enabled = false;
                        textBox2.Enabled = false;
                        textBox3.Enabled = false;
                        textBox4.Enabled = false;
                        textBox5.Enabled = false;
                        textBox6.Enabled = false;
                        button2.Enabled = false;
                        button2.Enabled = false;
                        label3.Text = "Fin del juego";
                        label3.Visible = true;
                        timer2.Enabled = true;
                        timer6.Enabled = false;
                        timer4.Enabled = false;
                    }
                }
                listBox1.Items.Add($"Intento N°" + Intentos);
                listBox1.Items.Add($"Picas: {contp.ToString()}");
                listBox1.Items.Add($"Fijas: {contf.ToString()}");
                Intentos++;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            button2.Enabled = true;
            button1.Enabled = true;
            button5.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            timer6.Enabled = false;
            timer7.Enabled = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            NumeroRestaIntentos = NumeroIntentos;
            label5.Text = NumeroIntentos.ToString();
            MinutosResta = Minutos;
            SegundosResta = Segundos;
            label7.Text = Minutos.ToString();
            label8.Text = Segundos.ToString();
            listBox1.Items.Clear(); // Reiniciar la lista de intentos.
            label2.Text = "";
            x = 0;
            label11.Visible = false;

            Intentos = 1; // Reiniciar la variable de conteo de intentos.
        }
        private void button4_Click(object sender, EventArgs e)
        {
            // Mostramos un mensaje de confirmación antes de salir de la aplicación
            DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "KillProgram", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                // Si se confirma la salida, cerramos la aplicación
                Application.Exit();
            }
            else
            {
                // Si se cancela la salida, no hacemos nada
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Abrimos la ventana de configuración
            Configuración configuracion = new Configuración();
            configuracion.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                // Movemos el control hacia la izquierda
                Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
                t.add(pictureBox3, "Left", 65);
                t.run();
                i = 50;
            }
            else
            {
                // Movemos el control hacia la derecha
                Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
                t.add(pictureBox3, "Left", 850);
                t.run();
                i = 0;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Generar un número aleatorio de 6 dígitos
            num = Random.Next(100000, 999999);
            numo = num;

            // Verificar si hay dígitos repetidos
            for (int i = 5; i >= 0; i--)
            {
                nums[i] = num % 10;
                num = num / 10;
            }

            for (int j = 1; j < 6; j++)
            {
                if (nums[0] != nums[j])
                {
                    cont++;
                }
            }
            for (int k = 2; k < 6; k++)
            {
                if (nums[1] != nums[k])
                {
                    cont++;
                }
            }
            for (int l = 3; l < 6; l++)
            {
                if (nums[2] != nums[l])
                {
                    cont++;
                }
            }
            for (int m = 4; m < 6; m++)
            {
                if (nums[3] != nums[m])
                {
                    cont++;
                }
            }
            for (int n = 5; n < 6; n++)
            {
                if (nums[4] != nums[n])
                {
                    cont++;
                }
            }

            // Si no hay dígitos repetidos, mostrar el número y desactivar el temporizador
            if (cont == 15)
            {
                label2.Text = numo.ToString();
                timer1.Enabled = false;
            }
            // Si hay dígitos repetidos, generar otro número aleatorio y repetir el proceso
            else
            {
                cont = 0;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            y++;
            label3.ForeColor = Color.White;
            label3.Location = new Point(label1.Location.X + 40, label1.Location.Y + y);
            if (y == 245)
            {
                timer3.Enabled = true;
                timer2.Enabled = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            y--;
            label3.Location = new Point(label1.Location.X + 60, label1.Location.Y + y);
            label3.ForeColor = Color.White;
            if (y == 10)
            {
                timer2.Enabled = true;
                timer3.Enabled = false;
            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            // Sección 1: Mover la etiqueta "label8" 10 píxeles hacia la derecha cuando hay 10 segundos restantes
            if (SegundosResta == 10)
            {
                label8.Location = new Point(label8.Location.X + 10, label8.Location.Y);
            }

            // Sección 2: Mover la etiqueta "label8" 10 píxeles hacia la derecha cuando los segundos restantes llegan a 0 y x es igual a 0
            if (Segundos == 0 && x == 0)
            {
                label8.Location = new Point(label8.Location.X + 10, label8.Location.Y);
                x++;
            }
            if (SegundosResta == 00)
            {
                label8.Location = new Point(label8.Location.X - 10, label8.Location.Y);
                SegundosResta = 60;
                SegundosResta = SegundosResta - 1;
                MinutosResta = MinutosResta - 1;
                label8.Text = SegundosResta.ToString();
                label7.Text = MinutosResta.ToString();
            }
            // Sección 3: Mover la etiqueta "label8" 10 píxeles hacia la izquierda y actualizar los segundos y minutos restantes
            else
            {
                SegundosResta = SegundosResta - 1;
                label8.Text = SegundosResta.ToString();
            }

            // Sección 4: Mostrar un mensaje de "Fin del juego" y deshabilitar varias entradas de texto y botones cuando los minutos y segundos restantes llegan a 0
            if (SegundosResta == 0 && MinutosResta == 0)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                button2.Enabled = false;
                button2.Enabled = false;
                label3.Text = "Fin del juego";
                label3.Visible = true;
                timer2.Enabled = true;
                timer4.Enabled = false;
                label8.Location = new Point(label8.Location.X + 10, label8.Location.Y);
                timer6.Enabled = false;
            }
        }


        private void timer5_Tick(object sender, EventArgs e)
        {
            // Genera tres números aleatorios entre 1 y 254 para crear un nuevo color para el texto de label11
            int re = Random.Next(1, 254);
            int gre = Random.Next(0, 254);
            int blu = Random.Next(0, 254);

            // Genera tres números aleatorios para cambiar el tamaño y la posición del control label11
            int tamañoL = Random.Next(1, 100);
            int posX = Random.Next(0, 150);
            int posY = Random.Next(0, 310);

            // Crea una nueva fuente utilizando la fuente actual de label11 y el tamaño aleatorio generado
            Font fuente = new Font(label11.Font.FontFamily, tamañoL);
            label11.Font = fuente;

            // Cambia la ubicación de label11 utilizando las coordenadas aleatorias generadas
            label11.Location = new Point(posX, posY);

            // Establece el color de fondo del formulario en blanco
            this.BackColor = Color.White;

            // Incrementa la variable Tiempo en 2
            Tiempo = Tiempo + 2;

            // Si Tiempo es igual a 30, realiza una animación que mueve y agranda el control label11
            if (Tiempo == 30)
            {
                // Crea una nueva fuente para label11 con un tamaño de 70
                fuente = new Font(label11.Font.FontFamily, 70);
                label11.Font = fuente;

                // Cambia la ubicación de label11 a una posición específica (900, 159)
                label11.Location = new Point(900, 159);

                // Crea una nueva transición para mover label11 a la izquierda
                Transition ganador = new Transition(new TransitionType_Linear(250));
                ganador.add(label11, "Left", 100);
                ganador.run();

                // Deshabilita el temporizador 5
                timer5.Enabled = false;
            }
        }


        private void timer6_Tick(object sender, EventArgs e)
        {
            // Habilita el temporizador 7 y deshabilita el temporizador 6
            timer7.Enabled = true;
            timer6.Enabled = false;
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            // Habilita el temporizador 6 y deshabilita el temporizador 7
            timer6.Enabled = true;
            timer7.Enabled = false;
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            // Activa la fecha y hora
            label9.Text = DateTime.Now.ToShortTimeString();
            label12.Text = DateTime.Now.ToShortDateString();
        }
    }
}