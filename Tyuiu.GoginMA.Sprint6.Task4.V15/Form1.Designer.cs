
namespace Tyuiu.GoginMA.Sprint6.Task4.V15
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
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxTask_GMA = new System.Windows.Forms.GroupBox();
            this.groupBoxInPutData_GMA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPutData_GMA = new System.Windows.Forms.GroupBox();
            this.buttonDone_GMA = new System.Windows.Forms.Button();
            this.buttonSave_GMA = new System.Windows.Forms.Button();
            this.buttonHelp_GMA = new System.Windows.Forms.Button();
            this.textBoxTask_GMA = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_GMA = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_GMA = new System.Windows.Forms.TextBox();
            this.textBoxResult_GMA = new System.Windows.Forms.TextBox();
            this.labelVarA_GMA = new System.Windows.Forms.Label();
            this.labelVarB_GMA = new System.Windows.Forms.Label();
            this.chartFunction_GMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_GMA.SuspendLayout();
            this.groupBoxInPutData_GMA.SuspendLayout();
            this.groupBoxOutPutData_GMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_GMA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_GMA
            // 
            this.groupBoxTask_GMA.Controls.Add(this.textBoxTask_GMA);
            this.groupBoxTask_GMA.Location = new System.Drawing.Point(13, 0);
            this.groupBoxTask_GMA.Name = "groupBoxTask_GMA";
            this.groupBoxTask_GMA.Size = new System.Drawing.Size(367, 75);
            this.groupBoxTask_GMA.TabIndex = 0;
            this.groupBoxTask_GMA.TabStop = false;
            this.groupBoxTask_GMA.Text = "Условие:";
            // 
            // groupBoxInPutData_GMA
            // 
            this.groupBoxInPutData_GMA.Controls.Add(this.labelVarB_GMA);
            this.groupBoxInPutData_GMA.Controls.Add(this.labelVarA_GMA);
            this.groupBoxInPutData_GMA.Controls.Add(this.textBoxStopStep_GMA);
            this.groupBoxInPutData_GMA.Controls.Add(this.textBoxStartStep_GMA);
            this.groupBoxInPutData_GMA.Location = new System.Drawing.Point(386, 0);
            this.groupBoxInPutData_GMA.Name = "groupBoxInPutData_GMA";
            this.groupBoxInPutData_GMA.Size = new System.Drawing.Size(249, 75);
            this.groupBoxInPutData_GMA.TabIndex = 0;
            this.groupBoxInPutData_GMA.TabStop = false;
            this.groupBoxInPutData_GMA.Text = "Ввод данных:";
            // 
            // groupBoxOutPutData_GMA
            // 
            this.groupBoxOutPutData_GMA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxOutPutData_GMA.Controls.Add(this.textBoxResult_GMA);
            this.groupBoxOutPutData_GMA.Location = new System.Drawing.Point(12, 81);
            this.groupBoxOutPutData_GMA.Name = "groupBoxOutPutData_GMA";
            this.groupBoxOutPutData_GMA.Size = new System.Drawing.Size(241, 531);
            this.groupBoxOutPutData_GMA.TabIndex = 0;
            this.groupBoxOutPutData_GMA.TabStop = false;
            this.groupBoxOutPutData_GMA.Text = "Вывод:";
            // 
            // buttonDone_GMA
            // 
            this.buttonDone_GMA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_GMA.Location = new System.Drawing.Point(641, 12);
            this.buttonDone_GMA.Name = "buttonDone_GMA";
            this.buttonDone_GMA.Size = new System.Drawing.Size(104, 63);
            this.buttonDone_GMA.TabIndex = 1;
            this.buttonDone_GMA.Text = "Выполнить";
            this.buttonDone_GMA.UseVisualStyleBackColor = false;
            this.buttonDone_GMA.Click += new System.EventHandler(this.buttonDone_GMA_Click);
            // 
            // buttonSave_GMA
            // 
            this.buttonSave_GMA.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSave_GMA.Location = new System.Drawing.Point(751, 12);
            this.buttonSave_GMA.Name = "buttonSave_GMA";
            this.buttonSave_GMA.Size = new System.Drawing.Size(104, 63);
            this.buttonSave_GMA.TabIndex = 1;
            this.buttonSave_GMA.Text = "Сохранить";
            this.buttonSave_GMA.UseVisualStyleBackColor = false;
            this.buttonSave_GMA.Click += new System.EventHandler(this.buttonSave_GMA_Click);
            // 
            // buttonHelp_GMA
            // 
            this.buttonHelp_GMA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_GMA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_GMA.Location = new System.Drawing.Point(861, 12);
            this.buttonHelp_GMA.Name = "buttonHelp_GMA";
            this.buttonHelp_GMA.Size = new System.Drawing.Size(104, 63);
            this.buttonHelp_GMA.TabIndex = 1;
            this.buttonHelp_GMA.Text = "Справка";
            this.buttonHelp_GMA.UseVisualStyleBackColor = false;
            this.buttonHelp_GMA.Click += new System.EventHandler(this.buttonHelp_GMA_Click);
            // 
            // textBoxTask_GMA
            // 
            this.textBoxTask_GMA.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_GMA.Multiline = true;
            this.textBoxTask_GMA.Name = "textBoxTask_GMA";
            this.textBoxTask_GMA.ReadOnly = true;
            this.textBoxTask_GMA.Size = new System.Drawing.Size(354, 49);
            this.textBoxTask_GMA.TabIndex = 0;
            this.textBoxTask_GMA.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.\r\nРезультат вывести в te" +
    "xtBox, построить график функции и сохранить в файл OutPutFileTask.txt по нажатию" +
    " кнопки.\r\n";
            // 
            // textBoxStartStep_GMA
            // 
            this.textBoxStartStep_GMA.Location = new System.Drawing.Point(16, 34);
            this.textBoxStartStep_GMA.Name = "textBoxStartStep_GMA";
            this.textBoxStartStep_GMA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartStep_GMA.TabIndex = 0;
            // 
            // textBoxStopStep_GMA
            // 
            this.textBoxStopStep_GMA.Location = new System.Drawing.Point(133, 34);
            this.textBoxStopStep_GMA.Name = "textBoxStopStep_GMA";
            this.textBoxStopStep_GMA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopStep_GMA.TabIndex = 0;
            // 
            // textBoxResult_GMA
            // 
            this.textBoxResult_GMA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxResult_GMA.Location = new System.Drawing.Point(8, 20);
            this.textBoxResult_GMA.Multiline = true;
            this.textBoxResult_GMA.Name = "textBoxResult_GMA";
            this.textBoxResult_GMA.ReadOnly = true;
            this.textBoxResult_GMA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_GMA.Size = new System.Drawing.Size(233, 505);
            this.textBoxResult_GMA.TabIndex = 0;
            // 
            // labelVarA_GMA
            // 
            this.labelVarA_GMA.AutoSize = true;
            this.labelVarA_GMA.Location = new System.Drawing.Point(16, 20);
            this.labelVarA_GMA.Name = "labelVarA_GMA";
            this.labelVarA_GMA.Size = new System.Drawing.Size(67, 13);
            this.labelVarA_GMA.TabIndex = 1;
            this.labelVarA_GMA.Text = "Старт шага:";
            // 
            // labelVarB_GMA
            // 
            this.labelVarB_GMA.AutoSize = true;
            this.labelVarB_GMA.Location = new System.Drawing.Point(130, 18);
            this.labelVarB_GMA.Name = "labelVarB_GMA";
            this.labelVarB_GMA.Size = new System.Drawing.Size(69, 13);
            this.labelVarB_GMA.TabIndex = 1;
            this.labelVarB_GMA.Text = "Конец шага:";
            // 
            // chartFunction_GMA
            // 
            this.chartFunction_GMA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartFunction_GMA.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction_GMA.Legends.Add(legend2);
            this.chartFunction_GMA.Location = new System.Drawing.Point(275, 82);
            this.chartFunction_GMA.Name = "chartFunction_GMA";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_GMA.Series.Add(series2);
            this.chartFunction_GMA.Size = new System.Drawing.Size(679, 530);
            this.chartFunction_GMA.TabIndex = 2;
            this.chartFunction_GMA.Text = "chartFunction";
            title2.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.ForeColor = System.Drawing.Color.RoyalBlue;
            title2.Name = "TitleFunction";
            title2.Text = "График функции";
            this.chartFunction_GMA.Titles.Add(title2);
            // 
            // FormMain_GMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 624);
            this.Controls.Add(this.chartFunction_GMA);
            this.Controls.Add(this.buttonHelp_GMA);
            this.Controls.Add(this.buttonSave_GMA);
            this.Controls.Add(this.buttonDone_GMA);
            this.Controls.Add(this.groupBoxOutPutData_GMA);
            this.Controls.Add(this.groupBoxInPutData_GMA);
            this.Controls.Add(this.groupBoxTask_GMA);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain_GMA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 15 | Гогин М. А.";
            this.groupBoxTask_GMA.ResumeLayout(false);
            this.groupBoxTask_GMA.PerformLayout();
            this.groupBoxInPutData_GMA.ResumeLayout(false);
            this.groupBoxInPutData_GMA.PerformLayout();
            this.groupBoxOutPutData_GMA.ResumeLayout(false);
            this.groupBoxOutPutData_GMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_GMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_GMA;
        private System.Windows.Forms.GroupBox groupBoxInPutData_GMA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_GMA;
        private System.Windows.Forms.Button buttonDone_GMA;
        private System.Windows.Forms.Button buttonSave_GMA;
        private System.Windows.Forms.Button buttonHelp_GMA;
        private System.Windows.Forms.TextBox textBoxTask_GMA;
        private System.Windows.Forms.Label labelVarB_GMA;
        private System.Windows.Forms.Label labelVarA_GMA;
        private System.Windows.Forms.TextBox textBoxStopStep_GMA;
        private System.Windows.Forms.TextBox textBoxStartStep_GMA;
        private System.Windows.Forms.TextBox textBoxResult_GMA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_GMA;
    }
}

