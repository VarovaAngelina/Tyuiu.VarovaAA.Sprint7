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
using Tyuiu.VarovaAA.Sprint7.Project.V12.Lib;
namespace Tyuiu.VarovaAA.Sprint7.Project.V12
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //
        }

        private void buttonShowShopInfo_VAA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Users\User\source\repos\Tyuiu.VarovaAA.Sprint7.Project.V12\Tyuiu.VarovaAA.Sprint7.Project.V12\bin\Release\ShopsInPutFile.csv";
                textBoxShopInfo_VAA.Text = ds.CollectTextFromFile(path, Convert.ToString(textBoxName_VAA.Text), 1) + Environment.NewLine + ds.CollectTextFromFile(path, Convert.ToString(textBoxName_VAA.Text), 2) + Environment.NewLine + ds.CollectTextFromFile(path, Convert.ToString(textBoxName_VAA.Text), 3) + Environment.NewLine + ds.CollectTextFromFile(path, Convert.ToString(textBoxName_VAA.Text), 4);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxShopInfo_VAA_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void buttonShowModels_VAA_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(textBoxName_VAA.Text);
            try
            {
                string path = $@"C:\Users\User\source\repos\Tyuiu.VarovaAA.Sprint7.Project.V12\Tyuiu.VarovaAA.Sprint7.Project.V12\bin\Release\{name}InPutFile.csv";
                string fileData = File.ReadAllText(path);
                fileData = fileData.Replace('\n', '\r');
                string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

                int rows = lines.Length;
                int columns = lines[0].Split(';').Length;

                for (int i = 1; i < rows; i++)
                {
                    textBoxShowModels_VAA.Text += ds.CollectTextFromFileInt(path, i, 0) + Environment.NewLine;
                }
                textBoxShowModels_VAA.Text += "--------------------" + Environment.NewLine;
                buttonDone_VAA.Enabled = true;
                textBoxModel_VAA.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_VAA_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(textBoxName_VAA.Text);
            try
            {
                string path = $@"C:\Users\User\source\repos\Tyuiu.VarovaAA.Sprint7.Project.V12\Tyuiu.VarovaAA.Sprint7.Project.V12\bin\Release\{name}InPutFile.csv";
                if (radioButtonDiagonal_VAA.Checked)
                {
                    textBoxRes_VAA.Text = ds.CollectTextFromFile(path, Convert.ToString(textBoxModel_VAA.Text), 1);
                }
                if (radioButtonScreenSize_VAA.Checked)
                {
                    textBoxRes_VAA.Text = ds.CollectTextFromFile(path, Convert.ToString(textBoxModel_VAA.Text), 2);
                }
                if (radioButtonRAM_VAA.Checked)
                {
                    textBoxRes_VAA.Text = ds.CollectTextFromFile(path, Convert.ToString(textBoxModel_VAA.Text), 3);
                }
                if (radioButtonSSD_VAA.Checked)
                {
                    textBoxRes_VAA.Text = ds.CollectTextFromFile(path, Convert.ToString(textBoxModel_VAA.Text), 4);
                }
                if (radioButtonProcessor_VAA.Checked)
                {
                    textBoxRes_VAA.Text = ds.CollectTextFromFile(path, Convert.ToString(textBoxModel_VAA.Text), 5);
                }
                if (radioButtonProcessorFrequency_VAA.Checked)
                {
                    textBoxRes_VAA.Text = ds.CollectTextFromFile(path, Convert.ToString(textBoxModel_VAA.Text), 6);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_VAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
