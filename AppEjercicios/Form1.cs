using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace AppEjercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_prom_Click(object sender, EventArgs e)
        {
            int notaA = Convert.ToInt32(nota1.Text);
            int notaB = Convert.ToInt32(nota2.Text);
            int notaC = Convert.ToInt32(nota3.Text);

            float prom = (float)(notaA + notaB + notaC) / 3;

            if (prom >= 7)
            {
                MessageBox.Show("Promocionado");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox4.Text);
            int num2 = Convert.ToInt32(textBox5.Text);
            int num3 = Convert.ToInt32(textBox6.Text);

            if (num1 < 10 && num2 < 10 && num3 < 10)
            {
                MessageBox.Show("Todos los numeros son menores a 10");
            }
        }

        /// <summary>
        /// Ejercicio con Else If
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_aumento_Click(object sender, EventArgs e)
        {
            int anios = Convert.ToInt32(txt_anios.Text);
            float sueldo = Convert.ToInt32(txt_sueldo.Text);
            float auxSueldo;

            if (sueldo < 500 && anios >= 10)
            {
                auxSueldo = (float)(sueldo * 1.2);
                MessageBox.Show("El sueldo es de: " + auxSueldo);
            }
            else if (sueldo < 500 && anios < 10)
            {
                auxSueldo = (float)(sueldo * 1.05);
                MessageBox.Show("El sueldo es de: " + auxSueldo);
            }
            else if ( sueldo >= 500)
            {
                MessageBox.Show("No hay aumento");
            }

        }

        /// <summary>
        /// Ejercicio con Switch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSwitch_Click(object sender, EventArgs e)
        {
            int opcion= opciones.SelectedIndex;
            
            switch (opcion)
            {
                case 0:
                    MessageBox.Show("Hay un descuento del 10%");
                    break;
                case 1:
                    MessageBox.Show("Hay un descuento del 5%");
                    break;
                case 2:
                    MessageBox.Show("Hay un descuento del 2%");
                    break;
                case 3:
                    MessageBox.Show("No hay descuento");
                    break;
            }
        }

        /// <summary>
        /// Ejercicio con For
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                MessageBox.Show(i.ToString());
            }
        }

        /// <summary>
        /// Ejercicio con Vectores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_vectores_Click(object sender, EventArgs e)
        {
            int[] sueldos = new int[5]; //array sueldos
            string[] nombres = new string[5];   // array nombres
            int sueldoMayor = 0;
            string trabajadorSueldoMayor = string.Empty;

            for (int i = 0; i < 5; i++)
            {
                int sueldo = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un sueldo"));
                string nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un el nombre del trabajador");
                sueldos[i] = sueldo;
                nombres[i] = nombre;
                if (sueldoMayor < sueldo)
                {
                    sueldoMayor = sueldo;
                    trabajadorSueldoMayor = nombre;
                }
            }

            MessageBox.Show(trabajadorSueldoMayor);
            MessageBox.Show(sueldoMayor.ToString());
        }

        struct Biblioteca
        {
            string autor;
            string titulo;
            int anio;
            public void setValor(string autor, string titulo, int anio)
            {
                this.autor = autor;
                this.titulo = titulo;
                this.anio = anio;
            }
            public string getValores()
            {
                return $"Autor: {this.autor} Titulo: {this.titulo}  Año: {this.anio}";
            }
        }

        private void btn_struct_Click(object sender, EventArgs e)
        {
            Biblioteca libros = new Biblioteca();
            string autor = txt_autor.Text;
            string titulo = txt_titulo.Text;
            string anio = txt_anio.Text;

            libros.setValor(autor, titulo, int.Parse(anio));

            MessageBox.Show(libros.getValores().ToString());
        }
    }
}
