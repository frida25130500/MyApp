using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp01
{

    public partial class OFP : Form
    {
        //se agrega un contador
        int contador = 0;
        
        bool save = false;
        string Path;
        // cambios;
        public OFP()
        {
            InitializeComponent();
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // DialogResult = ds;
            //ofpAbrir.ShowDialog();


        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofpAbrir.ShowDialog() == DialogResult.OK)
            {
                Path = ofpAbrir.FileName;
                save = true;
                rctTexto.LoadFile(ofpAbrir.FileName, RichTextBoxStreamType.PlainText);
                guardarComoToolStripMenuItem.Enabled = false;

                //agregar contadores
                contador = 0;
                timer.Start();

            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (save == false)
            {
                if (sfdGuardar.ShowDialog() == DialogResult.OK)
                {
                    Path = sfdGuardar.FileName;
                    save = true;

                }

            }
            rctTexto.SaveFile(Path, RichTextBoxStreamType.PlainText);
            guardarToolStripMenuItem.Enabled = false;

            //agregar contadores
            contador = 0;
            timer.Start();

        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdGuardar.ShowDialog(this) == DialogResult.OK)
            {
                Path = sfdGuardar.FileName;
                rctTexto.SaveFile(Path, RichTextBoxStreamType.PlainText);
                guardarToolStripMenuItem.Enabled = true;
                save = true;

                
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rctTexto.Clear();
            rctTexto.Focus();
            Path = "";
            save = false;
            //guardarComoToolStripMenuItem1 = false;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void rctTexto_TextChanged(object sender, EventArgs e)
        {
            guardarToolStripMenuItem.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            contador++;

            if (contador >= 30)
            {
                rctTexto.SaveFile(Path, RichTextBoxStreamType.PlainText);
                toolStripStatusLabel1.Text = "Archivo guardado";
                
                contador = 0;
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}