﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.GoginMA.Sprint6.Task4.V15.Lib;

namespace Tyuiu.GoginMA.Sprint6.Task4.V15
{
    public partial class FormMain_GMA : Form
    {
        public FormMain_GMA()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_GMA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_GMA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_GMA.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_GMA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_GMA.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxResult_GMA.Text = "";
                chartFunction_GMA.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_GMA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_GMA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_GMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы АСОиУБ-23-1 Гогин Михаил Александрович", "Сообщение");
        }

        private void buttonSave_GMA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V15.txt";
                File.WriteAllText(path, textBoxResult_GMA.Text);
                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
