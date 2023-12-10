
namespace Tyuiu.GoginMA.Sprint6.Task7.V20
{
    partial class FormAbout_GMA
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
            this.labelInfo_GMA = new System.Windows.Forms.Label();
            this.buttonOK_GMA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInfo_GMA
            // 
            this.labelInfo_GMA.AutoSize = true;
            this.labelInfo_GMA.Location = new System.Drawing.Point(12, 9);
            this.labelInfo_GMA.Name = "labelInfo_GMA";
            this.labelInfo_GMA.Size = new System.Drawing.Size(259, 78);
            this.labelInfo_GMA.TabIndex = 0;
            this.labelInfo_GMA.Text = "Разработчик: Гогин М. А.\r\nгруппа АСОиУБ-23-1\r\n\r\nПрограмма разработана в рамках из" +
    "учения C#\r\n\r\nВнутреннее имя: Tyuiu.GoginMA.Sprint6.Task6.V10\r\n";
            // 
            // buttonOK_GMA
            // 
            this.buttonOK_GMA.Location = new System.Drawing.Point(187, 90);
            this.buttonOK_GMA.Name = "buttonOK_GMA";
            this.buttonOK_GMA.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_GMA.TabIndex = 1;
            this.buttonOK_GMA.Text = "OK";
            this.buttonOK_GMA.UseVisualStyleBackColor = true;
            this.buttonOK_GMA.Click += new System.EventHandler(this.buttonOK_GMA_Click);
            // 
            // FormAbout_GMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 121);
            this.Controls.Add(this.buttonOK_GMA);
            this.Controls.Add(this.labelInfo_GMA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout_GMA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo_GMA;
        private System.Windows.Forms.Button buttonOK_GMA;
    }
}