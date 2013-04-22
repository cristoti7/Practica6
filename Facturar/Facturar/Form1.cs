using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double producto1;
            double producto2;
            double producto3;
            double subtotal;
            double iva;
            double total;
            producto1 = double.Parse(this.EntradaProducto1.Text);
            producto2 = double.Parse(this.EntradaProducto2.Text);
            producto3 = double.Parse(this.EntradaProducto3.Text);

            subtotal = producto1 + producto2 + producto3;
            iva = subtotal * .16;
            total = subtotal + iva;
            MuestraSubtotal.Text = subtotal.ToString();
            MuestraIva.Text = iva.ToString();
            MuestraTotal.Text = total.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {


            MuestraSubtotal.Text = " ";
            MuestraIva.Text = " ";
            MuestraTotal.Text = " ";
            EntradaProducto1.Text=" ";
            EntradaProducto2.Text=" ";
            EntradaProducto3.Text = " ";

        }
    }
}
