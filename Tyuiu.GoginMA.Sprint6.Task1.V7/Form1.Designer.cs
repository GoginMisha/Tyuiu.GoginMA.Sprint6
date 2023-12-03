
namespace Tyuiu.GoginMA.Sprint6.Task1.V7
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
            this.groupBox_Input = new System.Windows.Forms.GroupBox();
            this.groupBox_Condition = new System.Windows.Forms.GroupBox();
            this.groupBox_Output = new System.Windows.Forms.GroupBox();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.textBoxStartStep = new System.Windows.Forms.TextBox();
            this.textBoxStopStep = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label_start = new System.Windows.Forms.Label();
            this.label_stop = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.groupBox_Input.SuspendLayout();
            this.groupBox_Condition.SuspendLayout();
            this.groupBox_Output.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Input
            // 
            this.groupBox_Input.Controls.Add(this.label_stop);
            this.groupBox_Input.Controls.Add(this.label_start);
            this.groupBox_Input.Controls.Add(this.textBoxStopStep);
            this.groupBox_Input.Controls.Add(this.textBoxStartStep);
            this.groupBox_Input.Location = new System.Drawing.Point(12, 322);
            this.groupBox_Input.Name = "groupBox_Input";
            this.groupBox_Input.Size = new System.Drawing.Size(237, 100);
            this.groupBox_Input.TabIndex = 0;
            this.groupBox_Input.TabStop = false;
            this.groupBox_Input.Text = "Ввод данных";
            // 
            // groupBox_Condition
            // 
            this.groupBox_Condition.Controls.Add(this.textBoxCondition);
            this.groupBox_Condition.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Condition.Name = "groupBox_Condition";
            this.groupBox_Condition.Size = new System.Drawing.Size(478, 294);
            this.groupBox_Condition.TabIndex = 0;
            this.groupBox_Condition.TabStop = false;
            this.groupBox_Condition.Text = "Условие";
            // 
            // groupBox_Output
            // 
            this.groupBox_Output.Controls.Add(this.label_result);
            this.groupBox_Output.Controls.Add(this.textBoxResult);
            this.groupBox_Output.Location = new System.Drawing.Point(508, 12);
            this.groupBox_Output.Name = "groupBox_Output";
            this.groupBox_Output.Size = new System.Drawing.Size(271, 410);
            this.groupBox_Output.TabIndex = 0;
            this.groupBox_Output.TabStop = false;
            this.groupBox_Output.Text = "Вывод данных";
            // 
            // textBoxCondition
            // 
            this.textBoxCondition.Location = new System.Drawing.Point(7, 20);
            this.textBoxCondition.Multiline = true;
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.ReadOnly = true;
            this.textBoxCondition.Size = new System.Drawing.Size(465, 268);
            this.textBoxCondition.TabIndex = 0;
            this.textBoxCondition.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в виде таблицы." +
    "\r\n";
            // 
            // textBoxStartStep
            // 
            this.textBoxStartStep.Location = new System.Drawing.Point(7, 63);
            this.textBoxStartStep.Name = "textBoxStartStep";
            this.textBoxStartStep.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartStep.TabIndex = 0;
            // 
            // textBoxStopStep
            // 
            this.textBoxStopStep.Location = new System.Drawing.Point(131, 63);
            this.textBoxStopStep.Name = "textBoxStopStep";
            this.textBoxStopStep.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopStep.TabIndex = 0;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxResult.Location = new System.Drawing.Point(10, 45);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(255, 359);
            this.textBoxResult.TabIndex = 0;
            // 
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.Location = new System.Drawing.Point(7, 44);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(67, 13);
            this.label_start.TabIndex = 1;
            this.label_start.Text = "Старт шага:";
            // 
            // label_stop
            // 
            this.label_stop.AutoSize = true;
            this.label_stop.Location = new System.Drawing.Point(128, 44);
            this.label_stop.Name = "label_stop";
            this.label_stop.Size = new System.Drawing.Size(69, 13);
            this.label_stop.TabIndex = 1;
            this.label_stop.Text = "Конец шага:";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(7, 20);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(62, 13);
            this.label_result.TabIndex = 1;
            this.label_result.Text = "Результат:";
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonHelp.Location = new System.Drawing.Point(268, 340);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 65);
            this.buttonHelp.TabIndex = 1;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone.Location = new System.Drawing.Point(367, 340);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(117, 65);
            this.buttonDone.TabIndex = 1;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.groupBox_Condition);
            this.Controls.Add(this.groupBox_Output);
            this.Controls.Add(this.groupBox_Input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 7 | Гогин М. А.";
            this.groupBox_Input.ResumeLayout(false);
            this.groupBox_Input.PerformLayout();
            this.groupBox_Condition.ResumeLayout(false);
            this.groupBox_Condition.PerformLayout();
            this.groupBox_Output.ResumeLayout(false);
            this.groupBox_Output.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Input;
        private System.Windows.Forms.Label label_stop;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.TextBox textBoxStopStep;
        private System.Windows.Forms.TextBox textBoxStartStep;
        private System.Windows.Forms.GroupBox groupBox_Condition;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.GroupBox groupBox_Output;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonDone;
    }
}

