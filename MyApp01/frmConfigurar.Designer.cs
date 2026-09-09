namespace MyApp01
{
    partial class frmConfigurar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpconfigura = new System.Windows.Forms.DateTimePicker();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpconfigura
            // 
            this.dtpconfigura.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpconfigura.Location = new System.Drawing.Point(42, 56);
            this.dtpconfigura.Name = "dtpconfigura";
            this.dtpconfigura.ShowUpDown = true;
            this.dtpconfigura.Size = new System.Drawing.Size(200, 22);
            this.dtpconfigura.TabIndex = 0;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(324, 55);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 1;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // frmConfigurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 165);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.dtpconfigura);
            this.Name = "frmConfigurar";
            this.Text = "Configurar Alarma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpconfigura;
        private System.Windows.Forms.Button btnaceptar;
    }
}