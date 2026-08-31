namespace MyApp01
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtNumero1 = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNumero2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNumero3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtNumero1
            // 
            this.TxtNumero1.Location = new System.Drawing.Point(64, 77);
            this.TxtNumero1.Name = "TxtNumero1";
            this.TxtNumero1.Size = new System.Drawing.Size(268, 22);
            this.TxtNumero1.TabIndex = 0;
            this.TxtNumero1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(478, 55);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(268, 44);
            this.BtnCalcular.TabIndex = 1;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(478, 233);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(268, 44);
            this.BtnLimpiar.TabIndex = 3;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número 2";
            // 
            // TxtNumero2
            // 
            this.TxtNumero2.Location = new System.Drawing.Point(64, 198);
            this.TxtNumero2.Name = "TxtNumero2";
            this.TxtNumero2.Size = new System.Drawing.Size(268, 22);
            this.TxtNumero2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resultado";
            // 
            // TxtNumero3
            // 
            this.TxtNumero3.Location = new System.Drawing.Point(64, 319);
            this.TxtNumero3.Name = "TxtNumero3";
            this.TxtNumero3.Size = new System.Drawing.Size(268, 22);
            this.TxtNumero3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNumero3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNumero2);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtNumero1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNumero1;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNumero2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNumero3;
    }
}

