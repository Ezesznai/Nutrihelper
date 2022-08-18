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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btn_musculo = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_defiagresiva = new System.Windows.Forms.Button();
            this.btn_volumensucio = new System.Windows.Forms.Button();
            this.btn_grasa = new System.Windows.Forms.Button();
            this.btn_mantener = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_musculo
            // 
            this.btn_musculo.BackColor = System.Drawing.Color.Black;
            this.btn_musculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_musculo.BackgroundImage")));
            this.btn_musculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_musculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_musculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_musculo.Location = new System.Drawing.Point(845, 152);
            this.btn_musculo.Name = "btn_musculo";
            this.btn_musculo.Size = new System.Drawing.Size(432, 77);
            this.btn_musculo.TabIndex = 2;
            this.btn_musculo.UseVisualStyleBackColor = false;
            this.btn_musculo.Click += new System.EventHandler(this.Btn_musculo_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.Transparent;
            this.btn_confirmar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_confirmar.BackgroundImage")));
            this.btn_confirmar.Location = new System.Drawing.Point(962, 604);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(315, 64);
            this.btn_confirmar.TabIndex = 4;
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.Btn_confirmar_Click);
            // 
            // btn_defiagresiva
            // 
            this.btn_defiagresiva.BackColor = System.Drawing.Color.Black;
            this.btn_defiagresiva.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_defiagresiva.BackgroundImage")));
            this.btn_defiagresiva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_defiagresiva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_defiagresiva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_defiagresiva.Location = new System.Drawing.Point(88, 328);
            this.btn_defiagresiva.Name = "btn_defiagresiva";
            this.btn_defiagresiva.Size = new System.Drawing.Size(435, 74);
            this.btn_defiagresiva.TabIndex = 5;
            this.btn_defiagresiva.UseVisualStyleBackColor = false;
            this.btn_defiagresiva.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_volumensucio
            // 
            this.btn_volumensucio.BackColor = System.Drawing.Color.Black;
            this.btn_volumensucio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_volumensucio.BackgroundImage")));
            this.btn_volumensucio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_volumensucio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volumensucio.Location = new System.Drawing.Point(858, 338);
            this.btn_volumensucio.Name = "btn_volumensucio";
            this.btn_volumensucio.Size = new System.Drawing.Size(449, 98);
            this.btn_volumensucio.TabIndex = 6;
            this.btn_volumensucio.UseVisualStyleBackColor = false;
            this.btn_volumensucio.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btn_grasa
            // 
            this.btn_grasa.BackColor = System.Drawing.Color.Transparent;
            this.btn_grasa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_grasa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_grasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_grasa.Location = new System.Drawing.Point(78, 152);
            this.btn_grasa.Name = "btn_grasa";
            this.btn_grasa.Size = new System.Drawing.Size(425, 77);
            this.btn_grasa.TabIndex = 7;
            this.btn_grasa.UseVisualStyleBackColor = false;
            this.btn_grasa.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // btn_mantener
            // 
            this.btn_mantener.BackColor = System.Drawing.Color.Black;
            this.btn_mantener.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_mantener.BackgroundImage")));
            this.btn_mantener.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mantener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mantener.Location = new System.Drawing.Point(529, 231);
            this.btn_mantener.Name = "btn_mantener";
            this.btn_mantener.Size = new System.Drawing.Size(311, 107);
            this.btn_mantener.TabIndex = 8;
            this.btn_mantener.UseVisualStyleBackColor = false;
            this.btn_mantener.Click += new System.EventHandler(this.Btn_mantener_Click_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btn_mantener);
            this.Controls.Add(this.btn_grasa);
            this.Controls.Add(this.btn_volumensucio);
            this.Controls.Add(this.btn_defiagresiva);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.btn_musculo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "Form3";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_musculo;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_defiagresiva;
        private System.Windows.Forms.Button btn_volumensucio;
        private System.Windows.Forms.Button btn_grasa;
        private System.Windows.Forms.Button btn_mantener;
    }
}