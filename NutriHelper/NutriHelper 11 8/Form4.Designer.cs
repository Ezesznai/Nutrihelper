namespace NutriHelper
{
    partial class Form4
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
            this.lbl_felicidades = new System.Windows.Forms.Label();
            this.lbl_kcal = new System.Windows.Forms.Label();
            this.lbl_imc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_felicidades
            // 
            this.lbl_felicidades.AutoSize = true;
            this.lbl_felicidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_felicidades.Location = new System.Drawing.Point(228, 12);
            this.lbl_felicidades.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_felicidades.Name = "lbl_felicidades";
            this.lbl_felicidades.Size = new System.Drawing.Size(542, 26);
            this.lbl_felicidades.TabIndex = 0;
            this.lbl_felicidades.Text = "Felicidades!! ya terminaste y puedes ver tus resultados";
            this.lbl_felicidades.Click += new System.EventHandler(this.Lbl_felicidades_Click);
            // 
            // lbl_kcal
            // 
            this.lbl_kcal.AutoSize = true;
            this.lbl_kcal.Location = new System.Drawing.Point(166, 112);
            this.lbl_kcal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_kcal.Name = "lbl_kcal";
            this.lbl_kcal.Size = new System.Drawing.Size(0, 17);
            this.lbl_kcal.TabIndex = 1;
            this.lbl_kcal.Click += new System.EventHandler(this.Lbl_kcal_Click);
            // 
            // lbl_imc
            // 
            this.lbl_imc.AutoSize = true;
            this.lbl_imc.Location = new System.Drawing.Point(620, 161);
            this.lbl_imc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_imc.Name = "lbl_imc";
            this.lbl_imc.Size = new System.Drawing.Size(0, 17);
            this.lbl_imc.TabIndex = 2;
            this.lbl_imc.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 588);
            this.Controls.Add(this.lbl_imc);
            this.Controls.Add(this.lbl_kcal);
            this.Controls.Add(this.lbl_felicidades);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_felicidades;
        private System.Windows.Forms.Label lbl_kcal;
        private System.Windows.Forms.Label lbl_imc;
    }
}