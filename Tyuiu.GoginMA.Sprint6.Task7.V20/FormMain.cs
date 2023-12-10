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
using Tyuiu.GoginMA.Sprint6.Task7.V20.Lib;

namespace Tyuiu.GoginMA.Sprint6.Task7.V20
{
    public partial class FormMain_GMA : Form
    {
        public FormMain_GMA()
        {
            InitializeComponent();
            openFileDialogTask_GMA.Filter = "Значения, разделененые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_GMA.Filter = "Значения, разделененые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows = 10;
        static int columns = 10;
        static string openFilePath;
        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string file = File.ReadAllText(filePath);
            file = file.Replace('\n', '\r');
            string[] line = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = line.Length;
            int colums = line[0].Split(';').Length;
            int[,] arrayValues = new int[rows, colums];

            for (int r = 0; r < rows; r++)
            {
                string[] values = line[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(values[c]);
                }
            }
            return arrayValues;
        }

        private void buttonOpenFile_GMA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_GMA.ShowDialog();
            openFilePath = openFileDialogTask_GMA.FileName;
            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);
            dataGridViewIn_GMA.ColumnCount = columns;
            dataGridViewIn_GMA.RowCount = rows;
            dataGridViewOut_GMA.ColumnCount = columns;
            dataGridViewOut_GMA.RowCount = rows;
            for (int w = 0; w < columns; w++)
            {
                dataGridViewIn_GMA.Columns[w].Width = 25;
                dataGridViewOut_GMA.Columns[w].Width = 25;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_GMA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_GMA.Enabled = true;
        }

        private void buttonDone_GMA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOut_GMA.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            buttonSave_GMA.Enabled = true;
        }

        private void buttonSave_GMA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_GMA.FileName = "OutPutFileTask7V20.csv";
            saveFileDialogMatrix_GMA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_GMA.ShowDialog();

            string path = saveFileDialogMatrix_GMA.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_GMA.RowCount;
            int colums = dataGridViewOut_GMA.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (j != colums - 1)
                    {
                        str = str + dataGridViewOut_GMA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_GMA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        private void buttonOpenFile_GMA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_GMA.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_GMA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_GMA.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_GMA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_GMA.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_GMA_Click(object sender, EventArgs e)
        {
            FormAbout_GMA formAbout = new FormAbout_GMA();
            formAbout.ShowDialog();
        }

        private void buttonHelp_GMA_Click_1(object sender, EventArgs e)
        {
            FormAbout_GMA formAbout = new FormAbout_GMA();
            formAbout.ShowDialog();
        }
    }
}
