namespace NutriHelper
{
	partial class Form10
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
			this.btn_empezar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_empezar
			// 
			this.btn_empezar.BackColor = System.Drawing.Color.Transparent;
			this.btn_empezar.FlatAppearance.BorderSize = 0;
			this.btn_empezar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btn_empezar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btn_empezar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_empezar.Location = new System.Drawing.Point(492, 644);
			this.btn_empezar.Name = "btn_empezar";
			this.btn_empezar.Size = new System.Drawing.Size(456, 76);
			this.btn_empezar.TabIndex = 0;
			this.btn_empezar.UseVisualStyleBackColor = false;
			this.btn_empezar.Click += new System.EventHandler(this.Btn_empezar_Click);
			// 
			// Form10
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1370, 749);
			this.Controls.Add(this.btn_empezar);
			this.Name = "Form10";
			this.Text = "Form10";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_empezar;
	}
}