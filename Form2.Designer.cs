namespace NutriHelper
{
    partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.txt_nombre = new System.Windows.Forms.TextBox();
			this.txt_peso = new System.Windows.Forms.TextBox();
			this.txt_altura = new System.Windows.Forms.TextBox();
			this.txt_edad = new System.Windows.Forms.TextBox();
			this.btn_avanzar = new System.Windows.Forms.Button();
			this.cmb_sexo = new System.Windows.Forms.ComboBox();
			this.cmb_actividad = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_contraseña = new System.Windows.Forms.TextBox();
			this.pb_ocultarcontraseña = new System.Windows.Forms.PictureBox();
			this.pb_mostrarcontraseña = new System.Windows.Forms.PictureBox();
			this.btn_regresar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pb_ocultarcontraseña)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_mostrarcontraseña)).BeginInit();
			this.SuspendLayout();
			// 
			// txt_nombre
			// 
			this.txt_nombre.Cursor = System.Windows.Forms.Cursors.Hand;
			this.txt_nombre.Location = new System.Drawing.Point(93, 199);
			this.txt_nombre.Multiline = true;
			this.txt_nombre.Name = "txt_nombre";
			this.txt_nombre.Size = new System.Drawing.Size(266, 42);
			this.txt_nombre.TabIndex = 0;
			this.txt_nombre.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
			// 
			// txt_peso
			// 
			this.txt_peso.Cursor = System.Windows.Forms.Cursors.Hand;
			this.txt_peso.Location = new System.Drawing.Point(570, 313);
			this.txt_peso.Multiline = true;
			this.txt_peso.Name = "txt_peso";
			this.txt_peso.Size = new System.Drawing.Size(266, 43);
			this.txt_peso.TabIndex = 2;
			// 
			// txt_altura
			// 
			this.txt_altura.Cursor = System.Windows.Forms.Cursors.Hand;
			this.txt_altura.Location = new System.Drawing.Point(570, 199);
			this.txt_altura.Multiline = true;
			this.txt_altura.Name = "txt_altura";
			this.txt_altura.Size = new System.Drawing.Size(266, 42);
			this.txt_altura.TabIndex = 3;
			this.txt_altura.TextChanged += new System.EventHandler(this.Txt_altura_TextChanged);
			// 
			// txt_edad
			// 
			this.txt_edad.Cursor = System.Windows.Forms.Cursors.Hand;
			this.txt_edad.Location = new System.Drawing.Point(93, 424);
			this.txt_edad.Multiline = true;
			this.txt_edad.Name = "txt_edad";
			this.txt_edad.Size = new System.Drawing.Size(266, 44);
			this.txt_edad.TabIndex = 4;
			this.txt_edad.TextChanged += new System.EventHandler(this.Txt_edad_TextChanged);
			// 
			// btn_avanzar
			// 
			this.btn_avanzar.BackColor = System.Drawing.Color.Transparent;
			this.btn_avanzar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_avanzar.FlatAppearance.BorderSize = 0;
			this.btn_avanzar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btn_avanzar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btn_avanzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_avanzar.Location = new System.Drawing.Point(955, 603);
			this.btn_avanzar.Name = "btn_avanzar";
			this.btn_avanzar.Size = new System.Drawing.Size(295, 41);
			this.btn_avanzar.TabIndex = 5;
			this.btn_avanzar.UseVisualStyleBackColor = false;
			this.btn_avanzar.Click += new System.EventHandler(this.Btn_avanzar_Click);
			// 
			// cmb_sexo
			// 
			this.cmb_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_sexo.FormattingEnabled = true;
			this.cmb_sexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
			this.cmb_sexo.Location = new System.Drawing.Point(570, 436);
			this.cmb_sexo.Name = "cmb_sexo";
			this.cmb_sexo.Size = new System.Drawing.Size(266, 21);
			this.cmb_sexo.TabIndex = 6;
			this.cmb_sexo.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
			// 
			// cmb_actividad
			// 
			this.cmb_actividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_actividad.FormattingEnabled = true;
			this.cmb_actividad.Items.AddRange(new object[] {
            "Sedentaria (0-1 veces/semana)",
            "Ligera (1-3 veces/semana)",
            "Moderada (3-5 veces/semana)",
            "Activas (6-7 veces/semana)",
            "Intensa (2 hs por dia)"});
			this.cmb_actividad.Location = new System.Drawing.Point(570, 549);
			this.cmb_actividad.Name = "cmb_actividad";
			this.cmb_actividad.Size = new System.Drawing.Size(266, 21);
			this.cmb_actividad.TabIndex = 7;
			this.cmb_actividad.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged_1);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(515, 218);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 13);
			this.label3.TabIndex = 13;
			this.label3.Click += new System.EventHandler(this.Label3_Click);
			// 
			// txt_contraseña
			// 
			this.txt_contraseña.Location = new System.Drawing.Point(93, 313);
			this.txt_contraseña.Multiline = true;
			this.txt_contraseña.Name = "txt_contraseña";
			this.txt_contraseña.PasswordChar = '*';
			this.txt_contraseña.Size = new System.Drawing.Size(266, 43);
			this.txt_contraseña.TabIndex = 14;
			this.txt_contraseña.TextChanged += new System.EventHandler(this.Txt_contraseña_TextChanged);
			// 
			// pb_ocultarcontraseña
			// 
			this.pb_ocultarcontraseña.Image = ((System.Drawing.Image)(resources.GetObject("pb_ocultarcontraseña.Image")));
			this.pb_ocultarcontraseña.Location = new System.Drawing.Point(365, 313);
			this.pb_ocultarcontraseña.Name = "pb_ocultarcontraseña";
			this.pb_ocultarcontraseña.Size = new System.Drawing.Size(40, 43);
			this.pb_ocultarcontraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb_ocultarcontraseña.TabIndex = 15;
			this.pb_ocultarcontraseña.TabStop = false;
			this.pb_ocultarcontraseña.Click += new System.EventHandler(this.Pb_ocultarcontraseña_Click);
			// 
			// pb_mostrarcontraseña
			// 
			this.pb_mostrarcontraseña.Image = ((System.Drawing.Image)(resources.GetObject("pb_mostrarcontraseña.Image")));
			this.pb_mostrarcontraseña.Location = new System.Drawing.Point(365, 313);
			this.pb_mostrarcontraseña.Name = "pb_mostrarcontraseña";
			this.pb_mostrarcontraseña.Size = new System.Drawing.Size(40, 43);
			this.pb_mostrarcontraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb_mostrarcontraseña.TabIndex = 16;
			this.pb_mostrarcontraseña.TabStop = false;
			this.pb_mostrarcontraseña.Click += new System.EventHandler(this.Pb_mostrarcontraseña_Click);
			// 
			// btn_regresar
			// 
			this.btn_regresar.BackColor = System.Drawing.Color.Transparent;
			this.btn_regresar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_regresar.FlatAppearance.BorderSize = 0;
			this.btn_regresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btn_regresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_regresar.Location = new System.Drawing.Point(13, 13);
			this.btn_regresar.Name = "btn_regresar";
			this.btn_regresar.Size = new System.Drawing.Size(49, 47);
			this.btn_regresar.TabIndex = 17;
			this.btn_regresar.UseVisualStyleBackColor = false;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1370, 749);
			this.Controls.Add(this.btn_regresar);
			this.Controls.Add(this.txt_contraseña);
			this.Controls.Add(this.pb_mostrarcontraseña);
			this.Controls.Add(this.pb_ocultarcontraseña);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmb_actividad);
			this.Controls.Add(this.cmb_sexo);
			this.Controls.Add(this.btn_avanzar);
			this.Controls.Add(this.txt_edad);
			this.Controls.Add(this.txt_altura);
			this.Controls.Add(this.txt_peso);
			this.Controls.Add(this.txt_nombre);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.DoubleBuffered = true;
			this.Name = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.pb_ocultarcontraseña)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_mostrarcontraseña)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Button btn_avanzar;
        private System.Windows.Forms.ComboBox cmb_sexo;
        private System.Windows.Forms.ComboBox cmb_actividad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_contraseña;
		private System.Windows.Forms.PictureBox pb_ocultarcontraseña;
		private System.Windows.Forms.PictureBox pb_mostrarcontraseña;
		private System.Windows.Forms.Button btn_regresar;
	}
}