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
    public partial class frmConfigurar : Form
    {
        public DateTime hora {  get; set; }
        public frmConfigurar()
        {
            InitializeComponent();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            hora = dtpconfigura.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
