using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form venta = new Venta();
            venta.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new Empresa();
            formulario.Show();
        }

        private void pictureBox2_Click(object sendre, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form empleado = new Empleado();
            empleado.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form proveedor = new Proveedor();
            proveedor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form producto = new Productos();
            producto.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form compra = new Compra();
            compra.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form cliente = new Clientes();
            cliente.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form inf = new Informe();
            inf.Show();
        }
    }
}
