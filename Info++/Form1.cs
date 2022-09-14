using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Info__
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtUnidades_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string Producto;
            int Unidades;
            double Precio, Descuento, subtotal, subtotalCD, subtotalCDIVA, subtotalIVA, IVA;


            if (txtProducto.Text == "")
            {
                MessageBox.Show("Ingresar Datos Alfabeticos");

                return;
            }
            if (txtUnidades.Text == "" || txtPrecio.Text == "" || txtDescuento.Text == "")
            {
                MessageBox.Show("Ingresar Datos Numericos");

                return;
            }
            
            Producto = txtProducto.Text;
            Unidades = int.Parse(txtUnidades.Text);
            Precio = Convert.ToDouble(txtPrecio.Text);
            Descuento = Convert.ToDouble(txtDescuento.Text);

            subtotal = Precio * Unidades;
            subtotalCD = subtotal - (subtotal * (Descuento / 100));
            IVA = 0.21;
            subtotalCDIVA = subtotalCD + subtotalCD * IVA;
            subtotalIVA = subtotal + subtotal * IVA;
                     

            txtProductoR.Text = Producto.ToString();
            txtUnidadesR.Text = Unidades.ToString();
            txtCIVACD.Text = "$" + subtotalCDIVA.ToString();
            txtCIVASD.Text = "$" + subtotalIVA.ToString();
            txtSIVACD.Text = "$" + subtotalCD.ToString();
            txtSIVASD.Text = "$" + subtotal.ToString();
        }

        private void txtUnidades_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
