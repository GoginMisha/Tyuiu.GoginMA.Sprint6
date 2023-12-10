
namespace Tyuiu.GoginMA.Sprint6.Task5.V13
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_GMA = new System.Windows.Forms.Panel();
            this.buttonHelp_GMA = new System.Windows.Forms.Button();
            this.buttonOpenFile_GMA = new System.Windows.Forms.Button();
            this.buttonDone_GMA = new System.Windows.Forms.Button();
            this.groupBoxTask_GMA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_GMA = new System.Windows.Forms.TextBox();
            this.panelLeft_GMA = new System.Windows.Forms.Panel();
            this.groupBoxResult_GMA = new System.Windows.Forms.GroupBox();
            this.dataGridViewNums_GMA = new System.Windows.Forms.DataGridView();
            this.panelRight_GMA = new System.Windows.Forms.Panel();
            this.chartDiag_GMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelTop_GMA.SuspendLayout();
            this.groupBoxTask_GMA.SuspendLayout();
            this.panelLeft_GMA.SuspendLayout();
            this.groupBoxResult_GMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_GMA)).BeginInit();
            this.panelRight_GMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_GMA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_GMA
            // 
            this.panelTop_GMA.Controls.Add(this.buttonHelp_GMA);
            this.panelTop_GMA.Controls.Add(this.buttonOpenFile_GMA);
            this.panelTop_GMA.Controls.Add(this.buttonDone_GMA);
            this.panelTop_GMA.Controls.Add(this.groupBoxTask_GMA);
            this.panelTop_GMA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_GMA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_GMA.Name = "panelTop_GMA";
            this.panelTop_GMA.Size = new System.Drawing.Size(784, 100);
            this.panelTop_GMA.TabIndex = 0;
            // 
            // buttonHelp_GMA
            // 
            this.buttonHelp_GMA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_GMA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonHelp_GMA.Location = new System.Drawing.Point(632, 20);
            this.buttonHelp_GMA.Name = "buttonHelp_GMA";
            this.buttonHelp_GMA.Size = new System.Drawing.Size(94, 67);
            this.buttonHelp_GMA.TabIndex = 2;
            this.buttonHelp_GMA.Text = "Справка";
            this.buttonHelp_GMA.UseVisualStyleBackColor = false;
            this.buttonHelp_GMA.Click += new System.EventHandler(this.buttonHelp_GMA_Click);
            // 
            // buttonOpenFile_GMA
            // 
            this.buttonOpenFile_GMA.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOpenFile_GMA.Location = new System.Drawing.Point(521, 20);
            this.buttonOpenFile_GMA.Name = "buttonOpenFile_GMA";
            this.buttonOpenFile_GMA.Size = new System.Drawing.Size(94, 67);
            this.buttonOpenFile_GMA.TabIndex = 2;
            this.buttonOpenFile_GMA.Text = "Открыть файл";
            this.buttonOpenFile_GMA.UseVisualStyleBackColor = false;
            this.buttonOpenFile_GMA.Click += new System.EventHandler(this.buttonOpenFile_GMA_Click);
            // 
            // buttonDone_GMA
            // 
            this.buttonDone_GMA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_GMA.Location = new System.Drawing.Point(412, 20);
            this.buttonDone_GMA.Name = "buttonDone_GMA";
            this.buttonDone_GMA.Size = new System.Drawing.Size(94, 67);
            this.buttonDone_GMA.TabIndex = 2;
            this.buttonDone_GMA.Text = "Выполнить";
            this.buttonDone_GMA.UseVisualStyleBackColor = false;
            this.buttonDone_GMA.Click += new System.EventHandler(this.buttonDone_GMA_Click);
            // 
            // groupBoxTask_GMA
            // 
            this.groupBoxTask_GMA.Controls.Add(this.textBoxTask_GMA);
            this.groupBoxTask_GMA.Location = new System.Drawing.Point(4, 4);
            this.groupBoxTask_GMA.Name = "groupBoxTask_GMA";
            this.groupBoxTask_GMA.Size = new System.Drawing.Size(391, 86);
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
            this.textBoxTask_GMA.Size = new System.Drawing.Size(385, 67);
            this.textBoxTask_GMA.TabIndex = 0;
            this.textBoxTask_GMA.Text = "Прочитать данные из файла InPutFileTask5V13.txt. Вывести в dataGridView. Вывести " +
    "все числа, меньше 10. Построить диаграмму по этим значениям.\r\n";
            // 
            // panelLeft_GMA
            // 
            this.panelLeft_GMA.Controls.Add(this.groupBoxResult_GMA);
            this.panelLeft_GMA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_GMA.Location = new System.Drawing.Point(0, 100);
            this.panelLeft_GMA.Name = "panelLeft_GMA";
            this.panelLeft_GMA.Size = new System.Drawing.Size(200, 311);
            this.panelLeft_GMA.TabIndex = 0;
            // 
            // groupBoxResult_GMA
            // 
            this.groupBoxResult_GMA.Controls.Add(this.dataGridViewNums_GMA);
            this.groupBoxResult_GMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_GMA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_GMA.Name = "groupBoxResult_GMA";
            this.groupBoxResult_GMA.Size = new System.Drawing.Size(200, 311);
            this.groupBoxResult_GMA.TabIndex = 0;
            this.groupBoxResult_GMA.TabStop = false;
            this.groupBoxResult_GMA.Text = "Вывод данных:";
            // 
            // dataGridViewNums_GMA
            // 
            this.dataGridViewNums_GMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums_GMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNums_GMA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewNums_GMA.Name = "dataGridViewNums_GMA";
            this.dataGridViewNums_GMA.ReadOnly = true;
            this.dataGridViewNums_GMA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewNums_GMA.Size = new System.Drawing.Size(194, 292);
            this.dataGridViewNums_GMA.TabIndex = 0;
            // 
            // panelRight_GMA
            // 
            this.panelRight_GMA.Controls.Add(this.chartDiag_GMA);
            this.panelRight_GMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_GMA.Location = new System.Drawing.Point(200, 100);
            this.panelRight_GMA.Name = "panelRight_GMA";
            this.panelRight_GMA.Size = new System.Drawing.Size(584, 311);
            this.panelRight_GMA.TabIndex = 0;
            // 
            // chartDiag_GMA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDiag_GMA.ChartAreas.Add(chartArea2);
            this.chartDiag_GMA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartDiag_GMA.Legends.Add(legend2);
            this.chartDiag_GMA.Location = new System.Drawing.Point(0, 0);
            this.chartDiag_GMA.Name = "chartDiag_GMA";
            this.chartDiag_GMA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartDiag_GMA.Series.Add(series2);
            this.chartDiag_GMA.Size = new System.Drawing.Size(584, 311);
            this.chartDiag_GMA.TabIndex = 0;
            this.chartDiag_GMA.Text = "chart1";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 100);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 311);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // FormMain_GMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelRight_GMA);
            this.Controls.Add(this.panelLeft_GMA);
            this.Controls.Add(this.panelTop_GMA);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain_GMA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 13 | Гогин М. А.";
            this.panelTop_GMA.ResumeLayout(false);
            this.groupBoxTask_GMA.ResumeLayout(false);
            this.groupBoxTask_GMA.PerformLayout();
            this.panelLeft_GMA.ResumeLayout(false);
            this.groupBoxResult_GMA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_GMA)).EndInit();
            this.panelRight_GMA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_GMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_GMA;
        private System.Windows.Forms.GroupBox groupBoxTask_GMA;
        private System.Windows.Forms.TextBox textBoxTask_GMA;
        private System.Windows.Forms.Panel panelLeft_GMA;
        private System.Windows.Forms.GroupBox groupBoxResult_GMA;
        private System.Windows.Forms.Panel panelRight_GMA;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button buttonHelp_GMA;
        private System.Windows.Forms.Button buttonOpenFile_GMA;
        private System.Windows.Forms.Button buttonDone_GMA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_GMA;
        private System.Windows.Forms.DataGridView dataGridViewNums_GMA;
    }
}

