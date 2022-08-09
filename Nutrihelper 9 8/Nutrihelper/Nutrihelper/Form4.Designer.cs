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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_felicidades
            // 
            this.lbl_felicidades.AutoSize = true;
            this.lbl_felicidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_felicidades.Location = new System.Drawing.Point(152, 9);
            this.lbl_felicidades.Name = "lbl_felicidades";
            this.lbl_felicidades.Size = new System.Drawing.Size(542, 26);
            this.lbl_felicidades.TabIndex = 0;
            this.lbl_felicidades.Text = "Felicidades!! ya terminaste y puedes ver tus resultados";
            this.lbl_felicidades.Click += new System.EventHandler(this.Lbl_felicidades_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "AAAA";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_felicidades);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_felicidades;
        private System.Windows.Forms.Label label1;
    }
}