
namespace Tyuiu.GoginMA.Sprint6.Task7.V20
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.groupBoxTask_GMA = new System.Windows.Forms.GroupBox();
            this.groupBoxInPut_GMA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut_GMA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_GMA = new System.Windows.Forms.TextBox();
            this.dataGridViewIn_GMA = new System.Windows.Forms.DataGridView();
            this.dataGridViewOut_GMA = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_GMA = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton_GMA = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_GMA = new System.Windows.Forms.SaveFileDialog();
            this.buttonHelp_GMA = new System.Windows.Forms.Button();
            this.buttonSave_GMA = new System.Windows.Forms.Button();
            this.buttonDone_GMA = new System.Windows.Forms.Button();
            this.buttonOpenFile_GMA = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBoxTask_GMA.SuspendLayout();
            this.groupBoxInPut_GMA.SuspendLayout();
            this.groupBoxOutPut_GMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_GMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_GMA)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonHelp_GMA);
            this.panel1.Controls.Add(this.buttonSave_GMA);
            this.panel1.Controls.Add(this.buttonDone_GMA);
            this.panel1.Controls.Add(this.buttonOpenFile_GMA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 83);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxTask_GMA);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 88);
            this.panel2.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 171);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 240);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBoxInPut_GMA);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 171);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 240);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBoxOutPut_GMA);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(386, 171);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(398, 240);
            this.panel4.TabIndex = 3;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(386, 171);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 240);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // groupBoxTask_GMA
            // 
            this.groupBoxTask_GMA.Controls.Add(this.textBoxTask_GMA);
            this.groupBoxTask_GMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_GMA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_GMA.Name = "groupBoxTask_GMA";
            this.groupBoxTask_GMA.Size = new System.Drawing.Size(784, 88);
            this.groupBoxTask_GMA.TabIndex = 0;
            this.groupBoxTask_GMA.TabStop = false;
            this.groupBoxTask_GMA.Text = "Условие:";
            // 
            // groupBoxInPut_GMA
            // 
            this.groupBoxInPut_GMA.Controls.Add(this.dataGridViewIn_GMA);
            this.groupBoxInPut_GMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut_GMA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_GMA.Name = "groupBoxInPut_GMA";
            this.groupBoxInPut_GMA.Size = new System.Drawing.Size(383, 240);
            this.groupBoxInPut_GMA.TabIndex = 0;
            this.groupBoxInPut_GMA.TabStop = false;
            this.groupBoxInPut_GMA.Text = "Ввод:";
            // 
            // groupBoxOutPut_GMA
            // 
            this.groupBoxOutPut_GMA.Controls.Add(this.dataGridViewOut_GMA);
            this.groupBoxOutPut_GMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_GMA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_GMA.Name = "groupBoxOutPut_GMA";
            this.groupBoxOutPut_GMA.Size = new System.Drawing.Size(398, 240);
            this.groupBoxOutPut_GMA.TabIndex = 0;
            this.groupBoxOutPut_GMA.TabStop = false;
            this.groupBoxOutPut_GMA.Text = "Вывод:";
            // 
            // textBoxTask_GMA
            // 
            this.textBoxTask_GMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_GMA.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_GMA.Multiline = true;
            this.textBoxTask_GMA.Name = "textBoxTask_GMA";
            this.textBoxTask_GMA.ReadOnly = true;
            this.textBoxTask_GMA.Size = new System.Drawing.Size(778, 69);
            this.textBoxTask_GMA.TabIndex = 0;
            this.textBoxTask_GMA.Text = resources.GetString("textBoxTask_GMA.Text");
            // 
            // dataGridViewIn_GMA
            // 
            this.dataGridViewIn_GMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_GMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn_GMA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewIn_GMA.Name = "dataGridViewIn_GMA";
            this.dataGridViewIn_GMA.ReadOnly = true;
            this.dataGridViewIn_GMA.Size = new System.Drawing.Size(377, 221);
            this.dataGridViewIn_GMA.TabIndex = 0;
            // 
            // dataGridViewOut_GMA
            // 
            this.dataGridViewOut_GMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_GMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOut_GMA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOut_GMA.Name = "dataGridViewOut_GMA";
            this.dataGridViewOut_GMA.ReadOnly = true;
            this.dataGridViewOut_GMA.Size = new System.Drawing.Size(392, 221);
            this.dataGridViewOut_GMA.TabIndex = 0;
            // 
            // openFileDialogTask_GMA
            // 
            this.openFileDialogTask_GMA.FileName = "openFileDialogTask_GMA";
            // 
            // toolTipButton_GMA
            // 
            this.toolTipButton_GMA.IsBalloon = true;
            this.toolTipButton_GMA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_GMA.ToolTipTitle = "Подсказка";
            // 
            // buttonHelp_GMA
            // 
            this.buttonHelp_GMA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_GMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_GMA.Image = global::Tyuiu.GoginMA.Sprint6.Task7.V20.Properties.Resources.help;
            this.buttonHelp_GMA.Location = new System.Drawing.Point(690, 12);
            this.buttonHelp_GMA.Name = "buttonHelp_GMA";
            this.buttonHelp_GMA.Size = new System.Drawing.Size(82, 65);
            this.buttonHelp_GMA.TabIndex = 0;
            this.buttonHelp_GMA.UseVisualStyleBackColor = true;
            this.buttonHelp_GMA.Click += new System.EventHandler(this.buttonHelp_GMA_Click_1);
            // 
            // buttonSave_GMA
            // 
            this.buttonSave_GMA.Enabled = false;
            this.buttonSave_GMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_GMA.Image = global::Tyuiu.GoginMA.Sprint6.Task7.V20.Properties.Resources.page_save;
            this.buttonSave_GMA.Location = new System.Drawing.Point(189, 12);
            this.buttonSave_GMA.Name = "buttonSave_GMA";
            this.buttonSave_GMA.Size = new System.Drawing.Size(82, 65);
            this.buttonSave_GMA.TabIndex = 0;
            this.buttonSave_GMA.UseVisualStyleBackColor = true;
            this.buttonSave_GMA.Click += new System.EventHandler(this.buttonSave_GMA_Click);
            this.buttonSave_GMA.MouseEnter += new System.EventHandler(this.buttonSave_GMA_MouseEnter);
            // 
            // buttonDone_GMA
            // 
            this.buttonDone_GMA.Enabled = false;
            this.buttonDone_GMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_GMA.Image = global::Tyuiu.GoginMA.Sprint6.Task7.V20.Properties.Resources.page_white_go;
            this.buttonDone_GMA.Location = new System.Drawing.Point(101, 12);
            this.buttonDone_GMA.Name = "buttonDone_GMA";
            this.buttonDone_GMA.Size = new System.Drawing.Size(82, 65);
            this.buttonDone_GMA.TabIndex = 0;
            this.buttonDone_GMA.UseVisualStyleBackColor = true;
            this.buttonDone_GMA.Click += new System.EventHandler(this.buttonDone_GMA_Click);
            this.buttonDone_GMA.MouseEnter += new System.EventHandler(this.buttonDone_GMA_MouseEnter);
            // 
            // buttonOpenFile_GMA
            // 
            this.buttonOpenFile_GMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_GMA.Image = global::Tyuiu.GoginMA.Sprint6.Task7.V20.Properties.Resources.folder_page;
            this.buttonOpenFile_GMA.Location = new System.Drawing.Point(13, 12);
            this.buttonOpenFile_GMA.Name = "buttonOpenFile_GMA";
            this.buttonOpenFile_GMA.Size = new System.Drawing.Size(82, 65);
            this.buttonOpenFile_GMA.TabIndex = 0;
            this.buttonOpenFile_GMA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_GMA.Click += new System.EventHandler(this.buttonOpenFile_GMA_Click);
            this.buttonOpenFile_GMA.MouseEnter += new System.EventHandler(this.buttonOpenFile_GMA_MouseEnter);
            // 
            // FormMain_GMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain_GMA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 20 | Гогин М. А.";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBoxTask_GMA.ResumeLayout(false);
            this.groupBoxTask_GMA.PerformLayout();
            this.groupBoxInPut_GMA.ResumeLayout(false);
            this.groupBoxOutPut_GMA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_GMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_GMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHelp_GMA;
        private System.Windows.Forms.Button buttonSave_GMA;
        private System.Windows.Forms.Button buttonDone_GMA;
        private System.Windows.Forms.Button buttonOpenFile_GMA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.GroupBox groupBoxTask_GMA;
        private System.Windows.Forms.TextBox textBoxTask_GMA;
        private System.Windows.Forms.GroupBox groupBoxInPut_GMA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_GMA;
        private System.Windows.Forms.DataGridView dataGridViewIn_GMA;
        private System.Windows.Forms.DataGridView dataGridViewOut_GMA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_GMA;
        private System.Windows.Forms.ToolTip toolTipButton_GMA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_GMA;
    }
}

