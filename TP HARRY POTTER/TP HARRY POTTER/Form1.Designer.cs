namespace TP_HARRY_POTTER
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
            this.txtEq1 = new System.Windows.Forms.TextBox();
            this.txtEq2 = new System.Windows.Forms.TextBox();
            this.lblPuntaje1 = new System.Windows.Forms.Label();
            this.lblPuntaje2 = new System.Windows.Forms.Label();
            this.btnAnotacion1 = new System.Windows.Forms.Button();
            this.btnAnotacion2 = new System.Windows.Forms.Button();
            this.btnSnitch1 = new System.Windows.Forms.Button();
            this.btnSnitch2 = new System.Windows.Forms.Button();
            this.btnFinTorneo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEq1
            // 
            this.txtEq1.Location = new System.Drawing.Point(71, 105);
            this.txtEq1.Name = "txtEq1";
            this.txtEq1.Size = new System.Drawing.Size(100, 20);
            this.txtEq1.TabIndex = 0;
            this.txtEq1.TextChanged += new System.EventHandler(this.TxtEq1_TextChanged);
            // 
            // txtEq2
            // 
            this.txtEq2.Location = new System.Drawing.Point(496, 105);
            this.txtEq2.Name = "txtEq2";
            this.txtEq2.Size = new System.Drawing.Size(100, 20);
            this.txtEq2.TabIndex = 1;
            this.txtEq2.TextChanged += new System.EventHandler(this.TxtEq2_TextChanged);
            // 
            // lblPuntaje1
            // 
            this.lblPuntaje1.AutoSize = true;
            this.lblPuntaje1.Location = new System.Drawing.Point(82, 152);
            this.lblPuntaje1.Name = "lblPuntaje1";
            this.lblPuntaje1.Size = new System.Drawing.Size(13, 13);
            this.lblPuntaje1.TabIndex = 2;
            this.lblPuntaje1.Text = "0";
            // 
            // lblPuntaje2
            // 
            this.lblPuntaje2.AutoSize = true;
            this.lblPuntaje2.Location = new System.Drawing.Point(496, 152);
            this.lblPuntaje2.Name = "lblPuntaje2";
            this.lblPuntaje2.Size = new System.Drawing.Size(13, 13);
            this.lblPuntaje2.TabIndex = 3;
            this.lblPuntaje2.Text = "0";
            // 
            // btnAnotacion1
            // 
            this.btnAnotacion1.Location = new System.Drawing.Point(71, 221);
            this.btnAnotacion1.Name = "btnAnotacion1";
            this.btnAnotacion1.Size = new System.Drawing.Size(83, 23);
            this.btnAnotacion1.TabIndex = 4;
            this.btnAnotacion1.Text = "ANOTACION";
            this.btnAnotacion1.UseVisualStyleBackColor = true;
            this.btnAnotacion1.Click += new System.EventHandler(this.BtnAnotacion1_Click);
            // 
            // btnAnotacion2
            // 
            this.btnAnotacion2.Location = new System.Drawing.Point(521, 221);
            this.btnAnotacion2.Name = "btnAnotacion2";
            this.btnAnotacion2.Size = new System.Drawing.Size(82, 23);
            this.btnAnotacion2.TabIndex = 5;
            this.btnAnotacion2.Text = "ANOTACION";
            this.btnAnotacion2.UseVisualStyleBackColor = true;
            this.btnAnotacion2.Click += new System.EventHandler(this.BtnAnotacion2_Click);
            // 
            // btnSnitch1
            // 
            this.btnSnitch1.Location = new System.Drawing.Point(71, 288);
            this.btnSnitch1.Name = "btnSnitch1";
            this.btnSnitch1.Size = new System.Drawing.Size(75, 23);
            this.btnSnitch1.TabIndex = 6;
            this.btnSnitch1.Text = "SNITCH";
            this.btnSnitch1.UseVisualStyleBackColor = true;
            this.btnSnitch1.Click += new System.EventHandler(this.BtnSnitch1_Click);
            // 
            // btnSnitch2
            // 
            this.btnSnitch2.Location = new System.Drawing.Point(521, 288);
            this.btnSnitch2.Name = "btnSnitch2";
            this.btnSnitch2.Size = new System.Drawing.Size(75, 23);
            this.btnSnitch2.TabIndex = 7;
            this.btnSnitch2.Text = "SNITCH";
            this.btnSnitch2.UseVisualStyleBackColor = true;
            this.btnSnitch2.Click += new System.EventHandler(this.BtnSnitch2_Click);
            // 
            // btnFinTorneo
            // 
            this.btnFinTorneo.Location = new System.Drawing.Point(259, 177);
            this.btnFinTorneo.Name = "btnFinTorneo";
            this.btnFinTorneo.Size = new System.Drawing.Size(92, 36);
            this.btnFinTorneo.TabIndex = 8;
            this.btnFinTorneo.Text = "FINALIZAR TORNEO";
            this.btnFinTorneo.UseVisualStyleBackColor = true;
            this.btnFinTorneo.Click += new System.EventHandler(this.BtnFinTorneo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFinTorneo);
            this.Controls.Add(this.btnSnitch2);
            this.Controls.Add(this.btnSnitch1);
            this.Controls.Add(this.btnAnotacion2);
            this.Controls.Add(this.btnAnotacion1);
            this.Controls.Add(this.lblPuntaje2);
            this.Controls.Add(this.lblPuntaje1);
            this.Controls.Add(this.txtEq2);
            this.Controls.Add(this.txtEq1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEq1;
        private System.Windows.Forms.TextBox txtEq2;
        private System.Windows.Forms.Label lblPuntaje1;
        private System.Windows.Forms.Label lblPuntaje2;
        private System.Windows.Forms.Button btnAnotacion1;
        private System.Windows.Forms.Button btnAnotacion2;
        private System.Windows.Forms.Button btnSnitch1;
        private System.Windows.Forms.Button btnSnitch2;
        private System.Windows.Forms.Button btnFinTorneo;
    }
}

