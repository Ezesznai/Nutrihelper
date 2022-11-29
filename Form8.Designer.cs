namespace NutriHelper
{
    partial class Form8
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
			this.btn_confirmar = new System.Windows.Forms.Button();
			this.txt_nombre = new System.Windows.Forms.TextBox();
			this.txt_contraseña = new System.Windows.Forms.TextBox();
			this.pb_mostrarcontraseña = new System.Windows.Forms.PictureBox();
			this.pb_ocultarcontraseña = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pb_mostrarcontraseña)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_ocultarcontraseña)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_confirmar
			// 
			this.btn_confirmar.BackColor = System.Drawing.Color.Transparent;
			this.btn_confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_confirmar.FlatAppearance.BorderSize = 0;
			this.btn_confirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btn_confirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_confirmar.Location = new System.Drawing.Point(422, 343);
			this.btn_confirmar.Name = "btn_confirmar";
			this.btn_confirmar.Size = new System.Drawing.Size(124, 23);
			this.btn_confirmar.TabIndex = 2;
			this.btn_confirmar.UseVisualStyleBackColor = false;
			this.btn_confirmar.Click += new System.EventHandler(this.Button1_Click);
			// 
			// txt_nombre
			// 
			this.txt_nombre.Location = new System.Drawing.Point(255, 125);
			this.txt_nombre.Multiline = true;
			this.txt_nombre.Name = "txt_nombre";
			this.txt_nombre.Size = new System.Drawing.Size(116, 22);
			this.txt_nombre.TabIndex = 3;
			// 
			// txt_contraseña
			// 
			this.txt_contraseña.Location = new System.Drawing.Point(255, 223);
			this.txt_contraseña.Name = "txt_contraseña";
			this.txt_contraseña.PasswordChar = '*';
			this.txt_contraseña.Size = new System.Drawing.Size(116, 20);
			this.txt_contraseña.TabIndex = 4;
			this.txt_contraseña.TextChanged += new System.EventHandler(this.Txt_contraseña_TextChanged);
			// 
			// pb_mostrarcontraseña
			// 
			this.pb_mostrarcontraseña.Image = ((System.Drawing.Image)(resources.GetObject("pb_mostrarcontraseña.Image")));
			this.pb_mostrarcontraseña.Location = new System.Drawing.Point(391, 214);
			this.pb_mostrarcontraseña.Name = "pb_mostrarcontraseña";
			this.pb_mostrarcontraseña.Size = new System.Drawing.Size(38, 39);
			this.pb_mostrarcontraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb_mostrarcontraseña.TabIndex = 5;
			this.pb_mostrarcontraseña.TabStop = false;
			this.pb_mostrarcontraseña.Click += new System.EventHandler(this.Pb_mostrarcontraseña_Click);
			// 
			// pb_ocultarcontraseña
			// 
			this.pb_ocultarcontraseña.Image = ((System.Drawing.Image)(resources.GetObject("pb_ocultarcontraseña.Image")));
			this.pb_ocultarcontraseña.Location = new System.Drawing.Point(391, 214);
			this.pb_ocultarcontraseña.Name = "pb_ocultarcontraseña";
			this.pb_ocultarcontraseña.Size = new System.Drawing.Size(38, 39);
			this.pb_ocultarcontraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb_ocultarcontraseña.TabIndex = 6;
			this.pb_ocultarcontraseña.TabStop = false;
			this.pb_ocultarcontraseña.Click += new System.EventHandler(this.PictureBox2_Click);
			// 
			// Form8
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(800, 451);
			this.Controls.Add(this.pb_ocultarcontraseña);
			this.Controls.Add(this.pb_mostrarcontraseña);
			this.Controls.Add(this.txt_contraseña);
			this.Controls.Add(this.txt_nombre);
			this.Controls.Add(this.btn_confirmar);
			this.Name = "Form8";
			this.Text = "Form8";
			this.Load += new System.EventHandler(this.Form8_Load);
			((System.ComponentModel.ISupportInitialize)(this.pb_mostrarcontraseña)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_ocultarcontraseña)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_contraseña;
		private System.Windows.Forms.PictureBox pb_mostrarcontraseña;
		private System.Windows.Forms.PictureBox pb_ocultarcontraseña;
	}
}