using System;

namespace NutriHelper
{
    partial class Form5
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
            this.btnInfografias = new System.Windows.Forms.Button();
            this.btnDesayuno = new System.Windows.Forms.Button();
            this.btnAlmuerzo = new System.Windows.Forms.Button();
            this.btnCena = new System.Windows.Forms.Button();
            this.btnSnacks = new System.Windows.Forms.Button();
            this.lblKcalRest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInfografias
            // 
            this.btnInfografias.Location = new System.Drawing.Point(51, 168);
            this.btnInfografias.Name = "btnInfografias";
            this.btnInfografias.Size = new System.Drawing.Size(75, 23);
            this.btnInfografias.TabIndex = 0;
            this.btnInfografias.Text = "Infografias";
            this.btnInfografias.UseVisualStyleBackColor = true;
            this.btnInfografias.Click += new System.EventHandler(this.BtnInfografias_Click);
            // 
            // btnDesayuno
            // 
            this.btnDesayuno.BackColor = System.Drawing.Color.DarkGray;
            this.btnDesayuno.Location = new System.Drawing.Point(300, 167);
            this.btnDesayuno.Name = "btnDesayuno";
            this.btnDesayuno.Size = new System.Drawing.Size(75, 23);
            this.btnDesayuno.TabIndex = 1;
            this.btnDesayuno.Text = "desayuno";
            this.btnDesayuno.UseVisualStyleBackColor = false;
            this.btnDesayuno.Click += new System.EventHandler(this.BtnDesayuno_Click);
            // 
            // btnAlmuerzo
            // 
            this.btnAlmuerzo.Location = new System.Drawing.Point(300, 197);
            this.btnAlmuerzo.Name = "btnAlmuerzo";
            this.btnAlmuerzo.Size = new System.Drawing.Size(75, 23);
            this.btnAlmuerzo.TabIndex = 2;
            this.btnAlmuerzo.Text = "almuerzo";
            this.btnAlmuerzo.UseVisualStyleBackColor = true;
            // 
            // btnCena
            // 
            this.btnCena.Location = new System.Drawing.Point(300, 227);
            this.btnCena.Name = "btnCena";
            this.btnCena.Size = new System.Drawing.Size(75, 23);
            this.btnCena.TabIndex = 3;
            this.btnCena.Text = "cena";
            this.btnCena.UseVisualStyleBackColor = true;
            // 
            // btnSnacks
            // 
            this.btnSnacks.Location = new System.Drawing.Point(300, 257);
            this.btnSnacks.Name = "btnSnacks";
            this.btnSnacks.Size = new System.Drawing.Size(75, 23);
            this.btnSnacks.TabIndex = 4;
            this.btnSnacks.Text = "snack";
            this.btnSnacks.UseVisualStyleBackColor = true;
            // 
            // lblKcalRest
            // 
            this.lblKcalRest.AutoSize = true;
            this.lblKcalRest.Location = new System.Drawing.Point(51, 32);
            this.lblKcalRest.Name = "lblKcalRest";
            this.lblKcalRest.Size = new System.Drawing.Size(0, 13);
            this.lblKcalRest.TabIndex = 5;
            this.lblKcalRest.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKcalRest);
            this.Controls.Add(this.btnSnacks);
            this.Controls.Add(this.btnCena);
            this.Controls.Add(this.btnAlmuerzo);
            this.Controls.Add(this.btnDesayuno);
            this.Controls.Add(this.btnInfografias);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnInfografias;
        private System.Windows.Forms.Button btnDesayuno;
        private System.Windows.Forms.Button btnAlmuerzo;
        private System.Windows.Forms.Button btnCena;
        private System.Windows.Forms.Button btnSnacks;
        private System.Windows.Forms.Label lblKcalRest;
    }
}