using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomainCheckerAutomation
{
    public partial class Form1 : Form
    {
        string currentPathWork = "";
        long countLine = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void InitializeButton()
        {

        }
        private void OpenResultFolder()
        {
            string currentPath = Path.Combine(Directory.GetCurrentDirectory(), "Results");
            try
            {
                Process.Start("explorer.exe",currentPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private string OpenFileWorking()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "Text files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 1;
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName.ToString();
                }
            }
            return currentPathWork;
        }
        private void CountLines()
        {
            using(StreamReader sr = new StreamReader(currentPathWork))
            {
                while ((sr.ReadLine()) != null)
                {
                    countLine++;
                }
            }
            totalLb.Text = $"Total : {countLine}";
        }
        private void LoadingWorkingFile()
        {
            using(StreamReader  sr = new StreamReader(currentPathWork))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    consoleTb.AppendText($"{line}\n");
                    Thread.Sleep(1000);
                }
                consoleTb.AppendText("All Done !");
            }
        }
        private void ClearData()
        {
            countLine = 0;
            totalLb.Text = $"Total : 0";
            currentPathWork = "";
        }
        // event function
        private void userProxyCbox_CheckedChanged(object sender, EventArgs e)
        {
            if (userProxyCbox.Checked)
            {
                programProxyCBox.Checked = false;
            }
        }

        private void programProxyCBox_CheckedChanged(object sender, EventArgs e)
        {
            if(programProxyCBox.Checked)
            {
                userProxyCbox.Checked = false;
            }
        }

        private void fileBtn_Click(object sender, EventArgs e)
        {
            OpenResultFolder();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ClearData();
            currentPathWork = OpenFileWorking();
            CountLines();
            consoleTb.Text = currentPathWork;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            LoadingWorkingFile();
        }
    }
}
