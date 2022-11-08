namespace TESTAPIBIEN
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
            this.lbltester = new System.Windows.Forms.Label();
            this.proceso = new System.Windows.Forms.Button();
            this.txtIntroducirComida = new System.Windows.Forms.TextBox();
            this.lblCalorias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltester
            // 
            this.lbltester.AutoSize = true;
            this.lbltester.Location = new System.Drawing.Point(44, 175);
            this.lbltester.Name = "lbltester";
            this.lbltester.Size = new System.Drawing.Size(35, 13);
            this.lbltester.TabIndex = 0;
            this.lbltester.Text = "label1";
            this.lbltester.Click += new System.EventHandler(this.Lbltester_Click);
            // 
            // proceso
            // 
            this.proceso.Location = new System.Drawing.Point(332, 123);
            this.proceso.Name = "proceso";
            this.proceso.Size = new System.Drawing.Size(75, 23);
            this.proceso.TabIndex = 1;
            this.proceso.Text = "button1";
            this.proceso.UseVisualStyleBackColor = true;
            this.proceso.Click += new System.EventHandler(this.Proceso_Click);
            // 
            // txtIntroducirComida
            // 
            this.txtIntroducirComida.Location = new System.Drawing.Point(103, 68);
            this.txtIntroducirComida.Name = "txtIntroducirComida";
            this.txtIntroducirComida.Size = new System.Drawing.Size(100, 20);
            this.txtIntroducirComida.TabIndex = 2;
            this.txtIntroducirComida.TextChanged += new System.EventHandler(this.TxtIntroducirComida_TextChanged);
            // 
            // lblCalorias
            // 
            this.lblCalorias.AutoSize = true;
            this.lblCalorias.Location = new System.Drawing.Point(37, 243);
            this.lblCalorias.Name = "lblCalorias";
            this.lblCalorias.Size = new System.Drawing.Size(35, 13);
            this.lblCalorias.TabIndex = 3;
            this.lblCalorias.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCalorias);
            this.Controls.Add(this.txtIntroducirComida);
            this.Controls.Add(this.proceso);
            this.Controls.Add(this.lbltester);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltester;
        private System.Windows.Forms.Button proceso;
        private System.Windows.Forms.TextBox txtIntroducirComida;
        private System.Windows.Forms.Label lblCalorias;
    }
}

