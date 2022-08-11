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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btn_musculo = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_volumensucio = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_musculo
            // 
            this.btn_musculo.Location = new System.Drawing.Point(385, 202);
            this.btn_musculo.Name = "btn_musculo";
            this.btn_musculo.Size = new System.Drawing.Size(162, 59);
            this.btn_musculo.TabIndex = 2;
            this.btn_musculo.Text = "Ganar musculo y poca grasa";
            this.btn_musculo.UseVisualStyleBackColor = true;
            this.btn_musculo.Click += new System.EventHandler(this.Btn_musculo_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(878, 461);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(210, 47);
            this.btn_confirmar.TabIndex = 4;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.Btn_confirmar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(88, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(425, 74);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_volumensucio
            // 
            this.btn_volumensucio.BackColor = System.Drawing.Color.Transparent;
            this.btn_volumensucio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volumensucio.Location = new System.Drawing.Point(861, 338);
            this.btn_volumensucio.Name = "btn_volumensucio";
            this.btn_volumensucio.Size = new System.Drawing.Size(418, 73);
            this.btn_volumensucio.TabIndex = 6;
            this.btn_volumensucio.UseVisualStyleBackColor = false;
            this.btn_volumensucio.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btn_volumensucio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.btn_musculo);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_musculo;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_volumensucio;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}