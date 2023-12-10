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
using Tyuiu.GoginMA.Sprint6.Task6.V10.Lib;

namespace Tyuiu.GoginMA.Sprint6.Task6.V10
{
    public partial class FormMain_GMA : Form
    {
        public FormMain_GMA()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_GMA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_GMA.ShowDialog();
            openFilePath = openFileDialogTask_GMA.FileName;
            textBoxLoadFromFile_GMA.Text = File.ReadAllText(openFilePath);
            groupBoxInPutData_GMA.Text = groupBoxInPutData_GMA + " " + openFileDialogTask_GMA.FileName;
            buttonDone_GMA.Enabled = true;
        }

        private void buttonDone_GMA_Click(object sender, EventArgs e)
        {
            textBoxResult_GMA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_GMA_Click(object sender, EventArgs e)
        {
            FormAbout_GMA formAbout = new FormAbout_GMA();
            formAbout.ShowDialog();
        }
    }
}
