using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploInterfaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        interface Computadora
        {
            void ComputadoraEscritorio();
            void Laptops(); 
        }

        interface Modelo
        {
            void Modelo(); 
        }

        interface Tienda
        {
            void Tienda(); 
        }

        class ComputadoraAsus : Computadora, Modelo, Tienda
        {
            //Atributos
            public string nombre { get; set; }
            public double precio { get; set; }
            public string modelo { get; set; }
            public  string tienda { get; set; }

            public void ComputadoraEscritorio()
            {
                nombre = "Computadora 1";
                precio = 13000; 
            }
            public void Laptops()
            {
                nombre = "Laptop 1";
                precio = 18000; 
            }

            public void Modelo()
            {
                modelo = "Rog Strix"; 
            }

            public void Tienda()
            {
                tienda = "Sucursal LibresPool"; 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComputadoraAsus computadora = new ComputadoraAsus();
            ComputadoraAsus laptop = new ComputadoraAsus();
            computadora.ComputadoraEscritorio();
            laptop.Laptops();
            laptop.Modelo();
            laptop.Tienda(); 
            string texto = "El nombre de la computadora es: " + computadora.nombre + Environment.NewLine;
            texto += "El costo es: " + computadora.precio + Environment.NewLine;
            texto += Environment.NewLine;
            texto += "La laptop es: " + laptop.nombre + Environment.NewLine;
            texto += "El costo es: " + laptop.precio + Environment.NewLine;
            texto += "El modelo es: " + laptop.modelo + Environment.NewLine;
            texto += "La tienda es: "+ laptop.tienda + Environment.NewLine;
            textBox1.Text = texto; 
        }
    }
}
