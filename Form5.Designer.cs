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
			this.lbl_kcalrestante = new System.Windows.Forms.Label();
			this.btnInfo = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.lblJWT = new System.Windows.Forms.Label();
			this.lbl_hora = new System.Windows.Forms.Label();
			this.lbl_infodesayuno = new System.Windows.Forms.Label();
			this.lbl_infoalmuerzo = new System.Windows.Forms.Label();
			this.lbl_infosnacks = new System.Windows.Forms.Label();
			this.lbl_infocena = new System.Windows.Forms.Label();
			this.btn_resumendesayuno = new System.Windows.Forms.Button();
			this.btn_almuerzo = new System.Windows.Forms.Button();
			this.btn_snacks = new System.Windows.Forms.Button();
			this.btn_cena = new System.Windows.Forms.Button();
			this.lbl_kcalconsumidas = new System.Windows.Forms.Label();
			this.lbl_total = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_kcalrestante
			// 
			this.lbl_kcalrestante.AutoSize = true;
			this.lbl_kcalrestante.BackColor = System.Drawing.Color.Transparent;
			this.lbl_kcalrestante.Location = new System.Drawing.Point(72, 30);
			this.lbl_kcalrestante.Name = "lbl_kcalrestante";
			this.lbl_kcalrestante.Size = new System.Drawing.Size(0, 13);
			this.lbl_kcalrestante.TabIndex = 0;
			this.lbl_kcalrestante.Click += new System.EventHandler(this.LblKcalRest_Click);
			// 
			// btnInfo
			// 
			this.btnInfo.Location = new System.Drawing.Point(-19, 308);
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
			this.lblJWT.Size = new System.Drawing.Size(0, 13);
			this.lblJWT.TabIndex = 7;
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
			this.lbl_infodesayuno.BackColor = System.Drawing.Color.Aqua;
			this.lbl_infodesayuno.Location = new System.Drawing.Point(397, 30);
			this.lbl_infodesayuno.Name = "lbl_infodesayuno";
			this.lbl_infodesayuno.Size = new System.Drawing.Size(0, 13);
			this.lbl_infodesayuno.TabIndex = 9;
			this.lbl_infodesayuno.Visible = false;
			this.lbl_infodesayuno.Click += new System.EventHandler(this.Lbl_infodesayuno_Click);
			// 
			// lbl_infoalmuerzo
			// 
			this.lbl_infoalmuerzo.AutoSize = true;
			this.lbl_infoalmuerzo.BackColor = System.Drawing.Color.Aqua;
			this.lbl_infoalmuerzo.Location = new System.Drawing.Point(608, 30);
			this.lbl_infoalmuerzo.Name = "lbl_infoalmuerzo";
			this.lbl_infoalmuerzo.Size = new System.Drawing.Size(0, 13);
			this.lbl_infoalmuerzo.TabIndex = 10;
			this.lbl_infoalmuerzo.Visible = false;
			// 
			// lbl_infosnacks
			// 
			this.lbl_infosnacks.AutoSize = true;
			this.lbl_infosnacks.BackColor = System.Drawing.Color.Aqua;
			this.lbl_infosnacks.Location = new System.Drawing.Point(444, 126);
			this.lbl_infosnacks.Name = "lbl_infosnacks";
			this.lbl_infosnacks.Size = new System.Drawing.Size(0, 13);
			this.lbl_infosnacks.TabIndex = 11;
			this.lbl_infosnacks.Visible = false;
			// 
			// lbl_infocena
			// 
			this.lbl_infocena.AutoSize = true;
			this.lbl_infocena.BackColor = System.Drawing.Color.Aqua;
			this.lbl_infocena.Location = new System.Drawing.Point(608, 158);
			this.lbl_infocena.Name = "lbl_infocena";
			this.lbl_infocena.Size = new System.Drawing.Size(0, 13);
			this.lbl_infocena.TabIndex = 12;
			this.lbl_infocena.Visible = false;
			// 
			// btn_resumendesayuno
			// 
			this.btn_resumendesayuno.BackColor = System.Drawing.Color.Transparent;
			this.btn_resumendesayuno.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_resumendesayuno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_resumendesayuno.Location = new System.Drawing.Point(229, 121);
			this.btn_resumendesayuno.Name = "btn_resumendesayuno";
			this.btn_resumendesayuno.Size = new System.Drawing.Size(29, 22);
			this.btn_resumendesayuno.TabIndex = 14;
			this.btn_resumendesayuno.UseVisualStyleBackColor = false;
			this.btn_resumendesayuno.Click += new System.EventHandler(this.Btn_resumendesayuno_Click);
			// 
			// btn_almuerzo
			// 
			this.btn_almuerzo.BackColor = System.Drawing.Color.Transparent;
			this.btn_almuerzo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_almuerzo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_almuerzo.Location = new System.Drawing.Point(228, 168);
			this.btn_almuerzo.Name = "btn_almuerzo";
			this.btn_almuerzo.Size = new System.Drawing.Size(29, 22);
			this.btn_almuerzo.TabIndex = 15;
			this.btn_almuerzo.Tag = "";
			this.btn_almuerzo.UseVisualStyleBackColor = false;
			this.btn_almuerzo.Click += new System.EventHandler(this.Btn_almuerzo_Click);
			// 
			// btn_snacks
			// 
			this.btn_snacks.BackColor = System.Drawing.Color.Transparent;
			this.btn_snacks.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_snacks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_snacks.Location = new System.Drawing.Point(228, 227);
			this.btn_snacks.Name = "btn_snacks";
			this.btn_snacks.Size = new System.Drawing.Size(29, 22);
			this.btn_snacks.TabIndex = 16;
			this.btn_snacks.Tag = "";
			this.btn_snacks.UseVisualStyleBackColor = false;
			this.btn_snacks.Click += new System.EventHandler(this.Btn_snacks_Click);
			// 
			// btn_cena
			// 
			this.btn_cena.BackColor = System.Drawing.Color.Transparent;
			this.btn_cena.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_cena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_cena.Location = new System.Drawing.Point(228, 282);
			this.btn_cena.Name = "btn_cena";
			this.btn_cena.Size = new System.Drawing.Size(29, 22);
			this.btn_cena.TabIndex = 17;
			this.btn_cena.Tag = "";
			this.btn_cena.UseVisualStyleBackColor = false;
			this.btn_cena.Click += new System.EventHandler(this.Btn_cena_Click);
			// 
			// lbl_kcalconsumidas
			// 
			this.lbl_kcalconsumidas.AutoSize = true;
			this.lbl_kcalconsumidas.BackColor = System.Drawing.Color.Aqua;
			this.lbl_kcalconsumidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lbl_kcalconsumidas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lbl_kcalconsumidas.Location = new System.Drawing.Point(537, 241);
			this.lbl_kcalconsumidas.Name = "lbl_kcalconsumidas";
			this.lbl_kcalconsumidas.Size = new System.Drawing.Size(0, 13);
			this.lbl_kcalconsumidas.TabIndex = 18;
			// 
			// lbl_total
			// 
			this.lbl_total.AutoSize = true;
			this.lbl_total.Location = new System.Drawing.Point(608, 53);
			this.lbl_total.Name = "lbl_total";
			this.lbl_total.Size = new System.Drawing.Size(0, 13);
			this.lbl_total.TabIndex = 19;
			// 
			// Form5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lbl_total);
			this.Controls.Add(this.lbl_kcalconsumidas);
			this.Controls.Add(this.btn_cena);
			this.Controls.Add(this.btn_snacks);
			this.Controls.Add(this.btn_almuerzo);
			this.Controls.Add(this.btn_resumendesayuno);
			this.Controls.Add(this.lbl_infocena);
			this.Controls.Add(this.lbl_infosnacks);
			this.Controls.Add(this.lbl_infoalmuerzo);
			this.Controls.Add(this.lbl_infodesayuno);
			this.Controls.Add(this.lbl_hora);
			this.Controls.Add(this.lblJWT);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnInfo);
			this.Controls.Add(this.lbl_kcalrestante);
			this.DoubleBuffered = true;
			this.Name = "Form5";
			this.Text = " ";
			this.Load += new System.EventHandler(this.Form5_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kcalrestante;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblJWT;
		private System.Windows.Forms.Label lbl_hora;
		private System.Windows.Forms.Label lbl_infodesayuno;
		private System.Windows.Forms.Label lbl_infoalmuerzo;
		private System.Windows.Forms.Label lbl_infosnacks;
		private System.Windows.Forms.Label lbl_infocena;
		private System.Windows.Forms.Button btn_resumendesayuno;
		private System.Windows.Forms.Button btn_almuerzo;
		private System.Windows.Forms.Button btn_snacks;
		private System.Windows.Forms.Button btn_cena;
		private System.Windows.Forms.Label lbl_kcalconsumidas;
		private System.Windows.Forms.Label lbl_total;
	}
}