
namespace Tyuiu.GoginMA.Sprint6.Task2.V25
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.labelStopStep = new System.Windows.Forms.Label();
            this.labelStartStep = new System.Windows.Forms.Label();
            this.textBoxStopStep = new System.Windows.Forms.TextBox();
            this.textBoxStartStep = new System.Windows.Forms.TextBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.dataGridViewFunction = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxCondition.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.Controls.Add(this.textBoxCondition);
            this.groupBoxCondition.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(416, 315);
            this.groupBoxCondition.TabIndex = 0;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "Условие";
            // 
            // textBoxCondition
            // 
            this.textBoxCondition.Location = new System.Drawing.Point(7, 20);
            this.textBoxCondition.Multiline = true;
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.ReadOnly = true;
            this.textBoxCondition.Size = new System.Drawing.Size(403, 289);
            this.textBoxCondition.TabIndex = 0;
            this.textBoxCondition.Text = "Протабулировать функции на заданном диапазоне.\r\nРезультат вывести в DataGridView " +
    "и построить график функции.\r\n";
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.labelStopStep);
            this.groupBoxInput.Controls.Add(this.labelStartStep);
            this.groupBoxInput.Controls.Add(this.textBoxStopStep);
            this.groupBoxInput.Controls.Add(this.textBoxStartStep);
            this.groupBoxInput.Location = new System.Drawing.Point(13, 334);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(220, 104);
            this.groupBoxInput.TabIndex = 0;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод данных";
            // 
            // labelStopStep
            // 
            this.labelStopStep.AutoSize = true;
            this.labelStopStep.Location = new System.Drawing.Point(110, 44);
            this.labelStopStep.Name = "labelStopStep";
            this.labelStopStep.Size = new System.Drawing.Size(69, 13);
            this.labelStopStep.TabIndex = 1;
            this.labelStopStep.Text = "Конец шага:";
            // 
            // labelStartStep
            // 
            this.labelStartStep.AutoSize = true;
            this.labelStartStep.Location = new System.Drawing.Point(6, 44);
            this.labelStartStep.Name = "labelStartStep";
            this.labelStartStep.Size = new System.Drawing.Size(67, 13);
            this.labelStartStep.TabIndex = 1;
            this.labelStartStep.Text = "Старт шага:";
            // 
            // textBoxStopStep
            // 
            this.textBoxStopStep.Location = new System.Drawing.Point(113, 60);
            this.textBoxStopStep.Name = "textBoxStopStep";
            this.textBoxStopStep.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopStep.TabIndex = 0;
            // 
            // textBoxStartStep
            // 
            this.textBoxStartStep.Location = new System.Drawing.Point(7, 60);
            this.textBoxStartStep.Name = "textBoxStartStep";
            this.textBoxStartStep.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartStep.TabIndex = 0;
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.dataGridViewFunction);
            this.groupBoxOutput.Controls.Add(this.labelResult);
            this.groupBoxOutput.Location = new System.Drawing.Point(435, 13);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(200, 425);
            this.groupBoxOutput.TabIndex = 0;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Вывод данных";
            // 
            // dataGridViewFunction
            // 
            this.dataGridViewFunction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.fx});
            this.dataGridViewFunction.Location = new System.Drawing.Point(10, 36);
            this.dataGridViewFunction.Name = "dataGridViewFunction";
            this.dataGridViewFunction.RowHeadersVisible = false;
            this.dataGridViewFunction.Size = new System.Drawing.Size(184, 383);
            this.dataGridViewFunction.TabIndex = 2;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // fx
            // 
            this.fx.HeaderText = "F(X)";
            this.fx.Name = "fx";
            this.fx.Width = 50;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(7, 20);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(62, 13);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "Результат:";
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonHelp.Location = new System.Drawing.Point(239, 359);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 61);
            this.buttonHelp.TabIndex = 1;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.Green;
            this.buttonDone.Location = new System.Drawing.Point(331, 359);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(92, 61);
            this.buttonDone.TabIndex = 1;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            this.buttonDone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_MouseDown);
            this.buttonDone.MouseEnter += new System.EventHandler(this.buttonDone_MouseEnter);
            this.buttonDone.MouseLeave += new System.EventHandler(this.buttonDone_MouseLeave);
            // 
            // chartFunction
            // 
            chartArea6.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartFunction.Legends.Add(legend6);
            this.chartFunction.Location = new System.Drawing.Point(700, 82);
            this.chartFunction.Name = "chartFunction";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartFunction.Series.Add(series6);
            this.chartFunction.Size = new System.Drawing.Size(516, 300);
            this.chartFunction.TabIndex = 2;
            this.chartFunction.Text = "График функции";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 450);
            this.Controls.Add(this.chartFunction);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.groupBoxCondition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 25 | Гогин М. А.";
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxCondition.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.Label labelStopStep;
        private System.Windows.Forms.Label labelStartStep;
        private System.Windows.Forms.TextBox textBoxStopStep;
        private System.Windows.Forms.TextBox textBoxStartStep;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.DataGridView dataGridViewFunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn fx;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}

