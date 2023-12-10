using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.GoginMA.Sprint6.Task5.V13.Lib;

namespace Tyuiu.GoginMA.Sprint6.Task5.V13
{
    public partial class FormMain_GMA : Form
    {
        public FormMain_GMA()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\Misha\source\repos\Tyuiu.GoginMA.Sprint6\Tyuiu.GoginMA.Sprint6.Task5.V13\bin\Debug\InPutFileTask5V13.txt";

        private void buttonDone_GMA_Click(object sender, EventArgs e)
        {
            dataGridViewNums_GMA.ColumnCount = 2;
            dataGridViewNums_GMA.Columns[0].Width = 20;
            dataGridViewNums_GMA.Columns[1].Width = 50;
            this.chartDiag_GMA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_GMA.ChartAreas[0].AxisY.Title = "Ось Y";
            chartDiag_GMA.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_GMA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_GMA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_GMA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_GMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУБ-23-1 Гогин Михаил Александрович", "Сообщение");
        }
    }
}
