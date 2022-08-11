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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.btn_avanzar = new System.Windows.Forms.Button();
            this.cmb_sexo = new System.Windows.Forms.ComboBox();
            this.cmb_actividad = new System.Windows.Forms.ComboBox();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(322, 47);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(188, 20);
            this.txt_nombre.TabIndex = 0;
            this.txt_nombre.Text = "¿Cual es tu nombre?";
            this.txt_nombre.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(322, 169);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(188, 20);
            this.txt_peso.TabIndex = 2;
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(322, 129);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(188, 20);
            this.txt_altura.TabIndex = 3;
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(322, 85);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(188, 20);
            this.txt_edad.TabIndex = 4;
            this.txt_edad.TextChanged += new System.EventHandler(this.Txt_edad_TextChanged);
            // 
            // btn_avanzar
            // 
            this.btn_avanzar.Location = new System.Drawing.Point(315, 278);
            this.btn_avanzar.Name = "btn_avanzar";
            this.btn_avanzar.Size = new System.Drawing.Size(194, 35);
            this.btn_avanzar.TabIndex = 5;
            this.btn_avanzar.Text = "Avanzar";
            this.btn_avanzar.UseVisualStyleBackColor = true;
            this.btn_avanzar.Click += new System.EventHandler(this.Btn_avanzar_Click);
            // 
            // cmb_sexo
            // 
            this.cmb_sexo.FormattingEnabled = true;
            this.cmb_sexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.cmb_sexo.Location = new System.Drawing.Point(322, 208);
            this.cmb_sexo.Name = "cmb_sexo";
            this.cmb_sexo.Size = new System.Drawing.Size(187, 21);
            this.cmb_sexo.TabIndex = 6;
            this.cmb_sexo.Text = "¿Cual es tu sexo biologico?";
            this.cmb_sexo.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // cmb_actividad
            // 
            this.cmb_actividad.FormattingEnabled = true;
            this.cmb_actividad.Items.AddRange(new object[] {
            "Sedentaria (0-1 veces/semana)",
            "Ligera (1-3 veces/semana)",
            "Moderada (3-5 veces/semana)",
            "Activas (6-7 veces/semana)",
            "Intensa (2 hs por dia)"});
            this.cmb_actividad.Location = new System.Drawing.Point(322, 235);
            this.cmb_actividad.Name = "cmb_actividad";
            this.cmb_actividad.Size = new System.Drawing.Size(186, 21);
            this.cmb_actividad.TabIndex = 7;
            this.cmb_actividad.Text = "¿Cuanto ejercicio haces?";
            this.cmb_actividad.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged_1);
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.Location = new System.Drawing.Point(518, 85);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(31, 13);
            this.lbl_edad.TabIndex = 8;
            this.lbl_edad.Text = "edad";
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Location = new System.Drawing.Point(516, 132);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(33, 13);
            this.lbl_altura.TabIndex = 9;
            this.lbl_altura.Text = "altura";
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Location = new System.Drawing.Point(518, 169);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(30, 13);
            this.lbl_peso.TabIndex = 10;
            this.lbl_peso.Text = "peso";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_peso);
            this.Controls.Add(this.lbl_altura);
            this.Controls.Add(this.lbl_edad);
            this.Controls.Add(this.cmb_actividad);
            this.Controls.Add(this.cmb_sexo);
            this.Controls.Add(this.btn_avanzar);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.txt_nombre);
            this.Name = "Form2";
            this.Text = "Form2";
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
        private System.Windows.Forms.Label lbl_edad;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.Label lbl_peso;
    }
}