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
    public partial class OFP : Form
    {
        bool save = false;
        public OFP()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DialogResult = ds;
            ofpAbrir.ShowDialog();
           

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofpAbrir.ShowDialog() == DialogResult.OK) {
            rctTexto.LoadFile(ofpAbrir.FileName, RichTextBoxStreamType.PlainText);


        }
    }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
         if (save==false) {   
         if (sfdGuardar.ShowDialog() == DialogResult.OK)
                {
                save = true;
                }

        }
    }
