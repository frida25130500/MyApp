using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProceso_Click(object sender, EventArgs e)
        {
            string nombre = TxtNumero1.Text;
            MessageBox.Show(nombre);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtNumero1.Clear ();
            TxtNumero2.Clear();
            TxtNumero3.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int a, b = 0;
            a= int.Parse(TxtNumero1.Text);
            b= int.Parse(TxtNumero2.Text);
            MessageBox.Show("La suma es: "+ (a+b).ToString());
            TxtNumero3.Text=(a+b).ToString();   
        }
    }
}
