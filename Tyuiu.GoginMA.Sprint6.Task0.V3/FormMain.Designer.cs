
namespace Tyuiu.GoginMA.Sprint6.Task0.V3
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
            this.groupBox_Condition = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula = new System.Windows.Forms.PictureBox();
            this.textBoxTask = new System.Windows.Forms.Label();
            this.groupBox_Input = new System.Windows.Forms.GroupBox();
            this.label_A = new System.Windows.Forms.Label();
            this.textBoxVarX_KeyPress = new System.Windows.Forms.TextBox();
            this.groupBox_Output = new System.Windows.Forms.GroupBox();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.label_Result = new System.Windows.Forms.Label();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBox_Condition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).BeginInit();
            this.groupBox_Input.SuspendLayout();
            this.groupBox_Output.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Condition
            // 
            this.groupBox_Condition.Controls.Add(this.pictureBoxFormula);
            this.groupBox_Condition.Controls.Add(this.textBoxTask);
            this.groupBox_Condition.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Condition.Name = "groupBox_Condition";
            this.groupBox_Condition.Size = new System.Drawing.Size(746, 222);
            this.groupBox_Condition.TabIndex = 0;
            this.groupBox_Condition.TabStop = false;
            this.groupBox_Condition.Text = "Условие";
            // 
            // pictureBoxFormula
            // 
            this.pictureBoxFormula.Image = global::Tyuiu.GoginMA.Sprint6.Task0.V3.Properties.Resources.image;
            this.pictureBoxFormula.Location = new System.Drawing.Point(273, 108);
            this.pictureBoxFormula.Name = "pictureBoxFormula";
            this.pictureBoxFormula.Size = new System.Drawing.Size(123, 70);
            this.pictureBoxFormula.TabIndex = 1;
            this.pictureBoxFormula.TabStop = false;
            // 
            // textBoxTask
            // 
            this.textBoxTask.AutoSize = true;
            this.textBoxTask.Location = new System.Drawing.Point(6, 26);
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(553, 26);
            this.textBoxTask.TabIndex = 0;
            this.textBoxTask.Text = "Дано выражение,\r\n вычислить его значение при x = 3, результат вывести в TextBox. " +
    "Округлить до трёх знаков после запятой.";
            // 
            // groupBox_Input
            // 
            this.groupBox_Input.Controls.Add(this.label_A);
            this.groupBox_Input.Controls.Add(this.textBoxVarX_KeyPress);
            this.groupBox_Input.Location = new System.Drawing.Point(12, 254);
            this.groupBox_Input.Name = "groupBox_Input";
            this.groupBox_Input.Size = new System.Drawing.Size(351, 138);
            this.groupBox_Input.TabIndex = 1;
            this.groupBox_Input.TabStop = false;
            this.groupBox_Input.Text = "Ввод данных";
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.Location = new System.Drawing.Point(116, 72);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(84, 13);
            this.label_A.TabIndex = 1;
            this.label_A.Text = "Переменная X:";
            // 
            // textBoxVarX_KeyPress
            // 
            this.textBoxVarX_KeyPress.Location = new System.Drawing.Point(119, 88);
            this.textBoxVarX_KeyPress.Name = "textBoxVarX_KeyPress";
            this.textBoxVarX_KeyPress.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarX_KeyPress.TabIndex = 0;
            this.textBoxVarX_KeyPress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_KeyPress_KeyPress);
            // 
            // groupBox_Output
            // 
            this.groupBox_Output.Controls.Add(this.textBox_Result);
            this.groupBox_Output.Controls.Add(this.label_Result);
            this.groupBox_Output.Location = new System.Drawing.Point(401, 254);
            this.groupBox_Output.Name = "groupBox_Output";
            this.groupBox_Output.Size = new System.Drawing.Size(357, 138);
            this.groupBox_Output.TabIndex = 2;
            this.groupBox_Output.TabStop = false;
            this.groupBox_Output.Text = "Вывод данных";
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(34, 88);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ReadOnly = true;
            this.textBox_Result.Size = new System.Drawing.Size(194, 20);
            this.textBox_Result.TabIndex = 1;
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.Location = new System.Drawing.Point(31, 69);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(62, 13);
            this.label_Result.TabIndex = 0;
            this.label_Result.Text = "Результат:";
            // 
            // buttonDone
            // 
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone.Location = new System.Drawing.Point(633, 398);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(125, 34);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(591, 398);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(36, 34);
            this.buttonHelp.TabIndex = 4;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBox_Output);
            this.Controls.Add(this.groupBox_Input);
            this.Controls.Add(this.groupBox_Condition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 3 | Гогин М. А.";
            this.groupBox_Condition.ResumeLayout(false);
            this.groupBox_Condition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).EndInit();
            this.groupBox_Input.ResumeLayout(false);
            this.groupBox_Input.PerformLayout();
            this.groupBox_Output.ResumeLayout(false);
            this.groupBox_Output.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Condition;
        private System.Windows.Forms.PictureBox pictureBoxFormula;
        private System.Windows.Forms.Label textBoxTask;
        private System.Windows.Forms.GroupBox groupBox_Input;
        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.TextBox textBoxVarX_KeyPress;
        private System.Windows.Forms.GroupBox groupBox_Output;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonHelp;
    }
}

