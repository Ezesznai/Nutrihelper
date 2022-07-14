namespace NutriHelper
{
    partial class Form3
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
            this.btn_grasa = new System.Windows.Forms.Button();
            this.btn_mantener = new System.Windows.Forms.Button();
            this.btn_musculo = new System.Windows.Forms.Button();
            this.lbl_objetivos = new System.Windows.Forms.Label();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_grasa
            // 
            this.btn_grasa.Location = new System.Drawing.Point(102, 114);
            this.btn_grasa.Name = "btn_grasa";
            this.btn_grasa.Size = new System.Drawing.Size(188, 59);
            this.btn_grasa.TabIndex = 0;
            this.btn_grasa.Text = "Perder grasa";
            this.btn_grasa.UseVisualStyleBackColor = true;
            this.btn_grasa.Click += new System.EventHandler(this.Btn_grasa_Click);
            // 
            // btn_mantener
            // 
            this.btn_mantener.Location = new System.Drawing.Point(354, 114);
            this.btn_mantener.Name = "btn_mantener";
            this.btn_mantener.Size = new System.Drawing.Size(164, 59);
            this.btn_mantener.TabIndex = 1;
            this.btn_mantener.Text = "Mantener peso";
            this.btn_mantener.UseVisualStyleBackColor = true;
            this.btn_mantener.Click += new System.EventHandler(this.Btn_mantener_Click);
            // 
            // btn_musculo
            // 
            this.btn_musculo.Location = new System.Drawing.Point(597, 114);
            this.btn_musculo.Name = "btn_musculo";
            this.btn_musculo.Size = new System.Drawing.Size(162, 59);
            this.btn_musculo.TabIndex = 2;
            this.btn_musculo.Text = "Ganar musculo";
            this.btn_musculo.UseVisualStyleBackColor = true;
            this.btn_musculo.Click += new System.EventHandler(this.Btn_musculo_Click);
            // 
            // lbl_objetivos
            // 
            this.lbl_objetivos.AutoSize = true;
            this.lbl_objetivos.Font = new System.Drawing.Font("Arial", 14F);
            this.lbl_objetivos.Location = new System.Drawing.Point(306, 9);
            this.lbl_objetivos.Name = "lbl_objetivos";
            this.lbl_objetivos.Size = new System.Drawing.Size(282, 88);
            this.lbl_objetivos.TabIndex = 3;
            this.lbl_objetivos.Text = "Muchas Gracias!!\r\nAhora necesitamos saber tus \r\nobjetivos para poder adaptarnos\r\n" +
    "y hacerlo posible";
            this.lbl_objetivos.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(334, 237);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(210, 47);
            this.btn_confirmar.TabIndex = 4;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.Btn_confirmar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 347);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.lbl_objetivos);
            this.Controls.Add(this.btn_musculo);
            this.Controls.Add(this.btn_mantener);
            this.Controls.Add(this.btn_grasa);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_grasa;
        private System.Windows.Forms.Button btn_mantener;
        private System.Windows.Forms.Button btn_musculo;
        private System.Windows.Forms.Label lbl_objetivos;
        private System.Windows.Forms.Button btn_confirmar;
    }
}