
namespace Tyuiu.GoginMA.Sprint6.Task6.V10
{
    partial class FormMain_GMA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_GMA));
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBoxTask_GMA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_GMA = new System.Windows.Forms.TextBox();
            this.groupBoxInPutData_GMA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPutData_GMA = new System.Windows.Forms.GroupBox();
            this.textBoxLoadFromFile_GMA = new System.Windows.Forms.TextBox();
            this.textBoxResult_GMA = new System.Windows.Forms.TextBox();
            this.buttonDone_GMA = new System.Windows.Forms.Button();
            this.openFileDialogTask_GMA = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_GMA = new System.Windows.Forms.ToolTip(this.components);
            this.buttonHelp_GMA = new System.Windows.Forms.Button();
            this.buttonOpenFile_GMA = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBoxTask_GMA.SuspendLayout();
            this.groupBoxInPutData_GMA.SuspendLayout();
            this.groupBoxOutPutData_GMA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonHelp_GMA);
            this.panel1.Controls.Add(this.buttonDone_GMA);
            this.panel1.Controls.Add(this.buttonOpenFile_GMA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 70);
            this.panel1.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 70);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 341);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxTask_GMA);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 77);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBoxInPutData_GMA);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(362, 264);
            this.panel3.TabIndex = 3;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(365, 147);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 264);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBoxOutPutData_GMA);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(368, 147);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(416, 264);
            this.panel4.TabIndex = 5;
            // 
            // groupBoxTask_GMA
            // 
            this.groupBoxTask_GMA.Controls.Add(this.textBoxTask_GMA);
            this.groupBoxTask_GMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_GMA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_GMA.Name = "groupBoxTask_GMA";
            this.groupBoxTask_GMA.Size = new System.Drawing.Size(781, 77);
            this.groupBoxTask_GMA.TabIndex = 0;
            this.groupBoxTask_GMA.TabStop = false;
            this.groupBoxTask_GMA.Text = "Условие:";
            // 
            // textBoxTask_GMA
            // 
            this.textBoxTask_GMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_GMA.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_GMA.Multiline = true;
            this.textBoxTask_GMA.Name = "textBoxTask_GMA";
            this.textBoxTask_GMA.ReadOnly = true;
            this.textBoxTask_GMA.Size = new System.Drawing.Size(775, 58);
            this.textBoxTask_GMA.TabIndex = 0;
            this.textBoxTask_GMA.Text = resources.GetString("textBoxTask_GMA.Text");
            // 
            // groupBoxInPutData_GMA
            // 
            this.groupBoxInPutData_GMA.Controls.Add(this.textBoxLoadFromFile_GMA);
            this.groupBoxInPutData_GMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPutData_GMA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPutData_GMA.Name = "groupBoxInPutData_GMA";
            this.groupBoxInPutData_GMA.Size = new System.Drawing.Size(362, 264);
            this.groupBoxInPutData_GMA.TabIndex = 1;
            this.groupBoxInPutData_GMA.TabStop = false;
            this.groupBoxInPutData_GMA.Text = "Ввод:";
            // 
            // groupBoxOutPutData_GMA
            // 
            this.groupBoxOutPutData_GMA.Controls.Add(this.textBoxResult_GMA);
            this.groupBoxOutPutData_GMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPutData_GMA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPutData_GMA.Name = "groupBoxOutPutData_GMA";
            this.groupBoxOutPutData_GMA.Size = new System.Drawing.Size(416, 264);
            this.groupBoxOutPutData_GMA.TabIndex = 0;
            this.groupBoxOutPutData_GMA.TabStop = false;
            this.groupBoxOutPutData_GMA.Text = "Вывод:";
            // 
            // textBoxLoadFromFile_GMA
            // 
            this.textBoxLoadFromFile_GMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLoadFromFile_GMA.Location = new System.Drawing.Point(3, 16);
            this.textBoxLoadFromFile_GMA.Multiline = true;
            this.textBoxLoadFromFile_GMA.Name = "textBoxLoadFromFile_GMA";
            this.textBoxLoadFromFile_GMA.ReadOnly = true;
            this.textBoxLoadFromFile_GMA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLoadFromFile_GMA.Size = new System.Drawing.Size(356, 245);
            this.textBoxLoadFromFile_GMA.TabIndex = 0;
            // 
            // textBoxResult_GMA
            // 
            this.textBoxResult_GMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_GMA.Location = new System.Drawing.Point(3, 16);
            this.textBoxResult_GMA.Multiline = true;
            this.textBoxResult_GMA.Name = "textBoxResult_GMA";
            this.textBoxResult_GMA.ReadOnly = true;
            this.textBoxResult_GMA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_GMA.Size = new System.Drawing.Size(410, 245);
            this.textBoxResult_GMA.TabIndex = 0;
            // 
            // buttonDone_GMA
            // 
            this.buttonDone_GMA.Enabled = false;
            this.buttonDone_GMA.Image = global::Tyuiu.GoginMA.Sprint6.Task6.V10.Properties.Resources.page_white_go;
            this.buttonDone_GMA.Location = new System.Drawing.Point(93, 12);
            this.buttonDone_GMA.Name = "buttonDone_GMA";
            this.buttonDone_GMA.Size = new System.Drawing.Size(75, 52);
            this.buttonDone_GMA.TabIndex = 0;
            this.toolTip_GMA.SetToolTip(this.buttonDone_GMA, "Производит поиск слов в файле и выводит слова, в которых встречается w");
            this.buttonDone_GMA.UseVisualStyleBackColor = true;
            this.buttonDone_GMA.Click += new System.EventHandler(this.buttonDone_GMA_Click);
            // 
            // openFileDialogTask_GMA
            // 
            this.openFileDialogTask_GMA.FileName = "openFileDialog1";
            // 
            // toolTip_GMA
            // 
            this.toolTip_GMA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_GMA.ToolTipTitle = "Подсказка";
            // 
            // buttonHelp_GMA
            // 
            this.buttonHelp_GMA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_GMA.Image = global::Tyuiu.GoginMA.Sprint6.Task6.V10.Properties.Resources.help;
            this.buttonHelp_GMA.Location = new System.Drawing.Point(697, 12);
            this.buttonHelp_GMA.Name = "buttonHelp_GMA";
            this.buttonHelp_GMA.Size = new System.Drawing.Size(75, 52);
            this.buttonHelp_GMA.TabIndex = 0;
            this.toolTip_GMA.SetToolTip(this.buttonHelp_GMA, "Сведение о программе\r\n");
            this.buttonHelp_GMA.UseVisualStyleBackColor = true;
            this.buttonHelp_GMA.Click += new System.EventHandler(this.buttonHelp_GMA_Click);
            // 
            // buttonOpenFile_GMA
            // 
            this.buttonOpenFile_GMA.Image = global::Tyuiu.GoginMA.Sprint6.Task6.V10.Properties.Resources.folder_page;
            this.buttonOpenFile_GMA.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_GMA.Name = "buttonOpenFile_GMA";
            this.buttonOpenFile_GMA.Size = new System.Drawing.Size(75, 52);
            this.buttonOpenFile_GMA.TabIndex = 0;
            this.toolTip_GMA.SetToolTip(this.buttonOpenFile_GMA, "Выберите нужный файл для обработки\r\n");
            this.buttonOpenFile_GMA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_GMA.Click += new System.EventHandler(this.buttonOpenFile_GMA_Click);
            // 
            // FormMain_GMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain_GMA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 10 | Гогин М. А.";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBoxTask_GMA.ResumeLayout(false);
            this.groupBoxTask_GMA.PerformLayout();
            this.groupBoxInPutData_GMA.ResumeLayout(false);
            this.groupBoxInPutData_GMA.PerformLayout();
            this.groupBoxOutPutData_GMA.ResumeLayout(false);
            this.groupBoxOutPutData_GMA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHelp_GMA;
        private System.Windows.Forms.Button buttonDone_GMA;
        private System.Windows.Forms.Button buttonOpenFile_GMA;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxTask_GMA;
        private System.Windows.Forms.TextBox textBoxTask_GMA;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBoxInPutData_GMA;
        private System.Windows.Forms.TextBox textBoxLoadFromFile_GMA;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_GMA;
        private System.Windows.Forms.TextBox textBoxResult_GMA;
        private System.Windows.Forms.ToolTip toolTip_GMA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_GMA;
    }
}

