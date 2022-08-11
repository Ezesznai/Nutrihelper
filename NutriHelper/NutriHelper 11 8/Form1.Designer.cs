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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Empezar = new System.Windows.Forms.Button();
            this.btn_tengocuenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Empezar
            // 
            this.btn_Empezar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Empezar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Empezar.BackgroundImage")));
            this.btn_Empezar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Empezar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Empezar.Location = new System.Drawing.Point(357, 401);
            this.btn_Empezar.Name = "btn_Empezar";
            this.btn_Empezar.Size = new System.Drawing.Size(176, 40);
            this.btn_Empezar.TabIndex = 4;
            this.btn_Empezar.UseVisualStyleBackColor = false;
            this.btn_Empezar.Click += new System.EventHandler(this.Btn_Empezar_Click);
            // 
            // btn_tengocuenta
            // 
            this.btn_tengocuenta.BackColor = System.Drawing.Color.Transparent;
            this.btn_tengocuenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_tengocuenta.BackgroundImage")));
            this.btn_tengocuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_tengocuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tengocuenta.Location = new System.Drawing.Point(332, 320);
            this.btn_tengocuenta.Name = "btn_tengocuenta";
            this.btn_tengocuenta.Size = new System.Drawing.Size(225, 39);
            this.btn_tengocuenta.TabIndex = 5;
            this.btn_tengocuenta.UseVisualStyleBackColor = false;
            this.btn_tengocuenta.Click += new System.EventHandler(this.Btn_tengocuenta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 464);
            this.Controls.Add(this.btn_tengocuenta);
            this.Controls.Add(this.btn_Empezar);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Empezar;
        private System.Windows.Forms.Button btn_tengocuenta;
    }
}

