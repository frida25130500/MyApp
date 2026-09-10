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
            this.components = new System.ComponentModel.Container();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblreloj = new System.Windows.Forms.Label();
            this.tmrreloj = new System.Windows.Forms.Timer(this.components);
            this.btnencender = new System.Windows.Forms.Button();
            this.lblejecucion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(120, 72);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(63, 69);
            this.lblfecha.TabIndex = 0;
            this.lblfecha.Text = "0";
            // 
            // lblreloj
            // 
            this.lblreloj.AutoSize = true;
            this.lblreloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreloj.Location = new System.Drawing.Point(120, 187);
            this.lblreloj.Name = "lblreloj";
            this.lblreloj.Size = new System.Drawing.Size(63, 69);
            this.lblreloj.TabIndex = 1;
            this.lblreloj.Text = "0";
            // 
            // tmrreloj
            // 
            this.tmrreloj.Interval = 1000;
            this.tmrreloj.Tick += new System.EventHandler(this.tmrreloj_Tick);
            // 
            // btnencender
            // 
            this.btnencender.Location = new System.Drawing.Point(508, 272);
            this.btnencender.Name = "btnencender";
            this.btnencender.Size = new System.Drawing.Size(75, 23);
            this.btnencender.TabIndex = 2;
            this.btnencender.Text = "Encender";
            this.btnencender.UseVisualStyleBackColor = true;
            this.btnencender.Click += new System.EventHandler(this.btnencender_Click);
            // 
            // lblejecucion
            // 
            this.lblejecucion.AutoSize = true;
            this.lblejecucion.Location = new System.Drawing.Point(129, 272);
            this.lblejecucion.Name = "lblejecucion";
            this.lblejecucion.Size = new System.Drawing.Size(134, 16);
            this.lblejecucion.TabIndex = 3;
            this.lblejecucion.Text = "Tiempo de ejecución";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 439);
            this.Controls.Add(this.lblejecucion);
            this.Controls.Add(this.btnencender);
            this.Controls.Add(this.lblreloj);
            this.Controls.Add(this.lblfecha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblreloj;
        private System.Windows.Forms.Timer tmrreloj;
        private System.Windows.Forms.Button btnencender;
        private System.Windows.Forms.Label lblejecucion;
    }
}

