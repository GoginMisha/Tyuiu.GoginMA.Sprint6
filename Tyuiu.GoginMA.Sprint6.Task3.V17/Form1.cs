using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GoginMA.Sprint6.Task3.V17.Lib;

namespace Tyuiu.GoginMA.Sprint6.Task3.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] { { 22, 32, -16, 24, 27 }, { 3, -20, 24, -20, 25 }, { 21, 17, -8, -19, 17 }, { 8, 22, 28, 27, 19 }, { 11, 20, 12, 27, 29 } };

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] result = ds.Calculate(matrix);

            int rows = result.GetLength(0);
            int columns = result.GetLength(1);

            dataGridViewResult.ColumnCount = columns;
            dataGridViewResult.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {

                dataGridViewResult.Columns[i].Width = 25;

            }

            for (int i = 0; i < rows; i++)
            {
                dataGridViewResult.Rows[i].Height = 25;
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult.Rows[i].Cells[j].Value = Convert.ToString(result[i, j]);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            dataGridViewMatrix.ColumnCount = columns;
            dataGridViewMatrix.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУБ-23-1 Гогин Михаил Александрович", "Сообщение");
        }
    }
}
