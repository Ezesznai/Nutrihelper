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
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_nombre.Location = new System.Drawing.Point(353, 169);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(223, 20);
            this.txt_nombre.TabIndex = 0;
            this.txt_nombre.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txt_peso
            // 
            this.txt_peso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_peso.Location = new System.Drawing.Point(353, 293);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(223, 20);
            this.txt_peso.TabIndex = 2;
            // 
            // txt_altura
            // 
            this.txt_altura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_altura.Location = new System.Drawing.Point(353, 355);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(223, 20);
            this.txt_altura.TabIndex = 3;
            this.txt_altura.TextChanged += new System.EventHandler(this.Txt_altura_TextChanged);
            // 
            // txt_edad
            // 
            this.txt_edad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_edad.Location = new System.Drawing.Point(353, 423);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(223, 20);
            this.txt_edad.TabIndex = 4;
            this.txt_edad.TextChanged += new System.EventHandler(this.Txt_edad_TextChanged);
            // 
            // btn_avanzar
            // 
            this.btn_avanzar.BackColor = System.Drawing.SystemColors.Control;
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
            this.cmb_sexo.Location = new System.Drawing.Point(353, 228);
            this.cmb_sexo.Name = "cmb_sexo";
            this.cmb_sexo.Size = new System.Drawing.Size(223, 21);
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
            this.cmb_actividad.Location = new System.Drawing.Point(353, 486);
            this.cmb_actividad.Name = "cmb_actividad";
            this.cmb_actividad.Size = new System.Drawing.Size(223, 21);
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
            this.txt_contraseña.Location = new System.Drawing.Point(625, 169);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(238, 20);
            this.txt_contraseña.TabIndex = 14;
            this.txt_contraseña.TextChanged += new System.EventHandler(this.Txt_contraseña_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.txt_contraseña);
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
    }
}