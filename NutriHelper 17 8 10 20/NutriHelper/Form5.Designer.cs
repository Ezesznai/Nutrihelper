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
            this.lblKcalRest = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
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
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblKcalRest);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKcalRest;
        private System.Windows.Forms.Button btnInfo;
    }
}