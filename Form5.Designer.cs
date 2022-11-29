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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
			this.lblKcalRest = new System.Windows.Forms.Label();
			this.btnInfo = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.lblJWT = new System.Windows.Forms.Label();
			this.lbl_hora = new System.Windows.Forms.Label();
			this.lbl_infodesayuno = new System.Windows.Forms.Label();
			this.lbl_infoalmuerzo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblKcalRest
			// 
			this.lblKcalRest.AutoSize = true;
			this.lblKcalRest.Location = new System.Drawing.Point(25, 44);
			this.lblKcalRest.Name = "lblKcalRest";
			this.lblKcalRest.Size = new System.Drawing.Size(91, 13);
			this.lblKcalRest.TabIndex = 0;
			this.lblKcalRest.Text = "............................";
			this.lblKcalRest.Click += new System.EventHandler(this.LblKcalRest_Click);
			// 
			// btnInfo
			// 
			this.btnInfo.Location = new System.Drawing.Point(40, 222);
			this.btnInfo.Name = "btnInfo";
			this.btnInfo.Size = new System.Drawing.Size(91, 33);
			this.btnInfo.TabIndex = 1;
			this.btnInfo.Text = "Infografias";
			this.btnInfo.UseVisualStyleBackColor = true;
			this.btnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(322, 106);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = " Desayuno";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(322, 171);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Almuerzo";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(322, 231);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "Cena";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(322, 287);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 5;
			this.button4.Text = "Snacks";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4_Click);
			// 
			// lblJWT
			// 
			this.lblJWT.AutoSize = true;
			this.lblJWT.Location = new System.Drawing.Point(37, 9);
			this.lblJWT.Name = "lblJWT";
			this.lblJWT.Size = new System.Drawing.Size(35, 13);
			this.lblJWT.TabIndex = 7;
			this.lblJWT.Text = "label1";
			this.lblJWT.Click += new System.EventHandler(this.Label1_Click);
			// 
			// lbl_hora
			// 
			this.lbl_hora.AutoSize = true;
			this.lbl_hora.Location = new System.Drawing.Point(721, 13);
			this.lbl_hora.Name = "lbl_hora";
			this.lbl_hora.Size = new System.Drawing.Size(0, 13);
			this.lbl_hora.TabIndex = 8;
			this.lbl_hora.Click += new System.EventHandler(this.Label1_Click_1);
			// 
			// lbl_infodesayuno
			// 
			this.lbl_infodesayuno.AutoSize = true;
			this.lbl_infodesayuno.Location = new System.Drawing.Point(501, 50);
			this.lbl_infodesayuno.Name = "lbl_infodesayuno";
			this.lbl_infodesayuno.Size = new System.Drawing.Size(0, 13);
			this.lbl_infodesayuno.TabIndex = 9;
			this.lbl_infodesayuno.Click += new System.EventHandler(this.Lbl_infodesayuno_Click);
			// 
			// lbl_infoalmuerzo
			// 
			this.lbl_infoalmuerzo.AutoSize = true;
			this.lbl_infoalmuerzo.Location = new System.Drawing.Point(537, 156);
			this.lbl_infoalmuerzo.Name = "lbl_infoalmuerzo";
			this.lbl_infoalmuerzo.Size = new System.Drawing.Size(0, 13);
			this.lbl_infoalmuerzo.TabIndex = 10;
			// 
			// Form5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lbl_infoalmuerzo);
			this.Controls.Add(this.lbl_infodesayuno);
			this.Controls.Add(this.lbl_hora);
			this.Controls.Add(this.lblJWT);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnInfo);
			this.Controls.Add(this.lblKcalRest);
			this.DoubleBuffered = true;
			this.Name = "Form5";
			this.Text = " ";
			this.Load += new System.EventHandler(this.Form5_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKcalRest;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblJWT;
		private System.Windows.Forms.Label lbl_hora;
		private System.Windows.Forms.Label lbl_infodesayuno;
		private System.Windows.Forms.Label lbl_infoalmuerzo;
	}
}