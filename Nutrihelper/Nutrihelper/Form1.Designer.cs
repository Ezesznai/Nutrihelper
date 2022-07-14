namespace NutriHelper
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
            this.lbl_Bienvenidos = new System.Windows.Forms.Label();
            this.btn_Empezar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Bienvenidos
            // 
            this.lbl_Bienvenidos.AutoSize = true;
            this.lbl_Bienvenidos.Font = new System.Drawing.Font("Arial", 16.5F);
            this.lbl_Bienvenidos.Location = new System.Drawing.Point(48, 20);
            this.lbl_Bienvenidos.Name = "lbl_Bienvenidos";
            this.lbl_Bienvenidos.Size = new System.Drawing.Size(441, 100);
            this.lbl_Bienvenidos.TabIndex = 3;
            this.lbl_Bienvenidos.Text = "Bienvenidos, para empezar en este trayecto \r\nles vamos a tener que pedir \r\nalguno" +
    "s datos para brindarte\r\nla informacion mas precisa posible.";
            this.lbl_Bienvenidos.Click += new System.EventHandler(this.Label2_Click);
            // 
            // btn_Empezar
            // 
            this.btn_Empezar.Location = new System.Drawing.Point(315, 274);
            this.btn_Empezar.Name = "btn_Empezar";
            this.btn_Empezar.Size = new System.Drawing.Size(193, 58);
            this.btn_Empezar.TabIndex = 4;
            this.btn_Empezar.Text = "Empezar ya";
            this.btn_Empezar.UseVisualStyleBackColor = true;
            this.btn_Empezar.Click += new System.EventHandler(this.Btn_Empezar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 362);
            this.Controls.Add(this.btn_Empezar);
            this.Controls.Add(this.lbl_Bienvenidos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Bienvenidos;
        private System.Windows.Forms.Button btn_Empezar;
    }
}

