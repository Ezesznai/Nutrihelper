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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
			this.lbl_kcal = new System.Windows.Forms.Label();
			this.lbl_imc = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_kcal
			// 
			this.lbl_kcal.AutoSize = true;
			this.lbl_kcal.Location = new System.Drawing.Point(687, 545);
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
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1202, 297);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(156, 40);
			this.button1.TabIndex = 3;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1370, 749);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lbl_imc);
			this.Controls.Add(this.lbl_kcal);
			this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form4";
			this.Text = " ";
			this.Load += new System.EventHandler(this.Form4_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_kcal;
        private System.Windows.Forms.Label lbl_imc;
        private System.Windows.Forms.Button button1;
    }
}