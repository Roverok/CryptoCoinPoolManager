using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoCoinPoolManager
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BFGMinerPath = bfgMinerTextBox.Text;
            Properties.Settings.Default.CGMinerPath = cgMinerTextBox.Text;
            Properties.Settings.Default.CPUMinerPath = cpuMinerTextBox.Text;
            Properties.Settings.Default.CryptoCoinMainPath = coinMainFolderTextBox.Text;

            Properties.Settings.Default.Save();
        }

        private void coinsButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    coinMainFolderTextBox.Text = dialog.SelectedPath;
                }
            }
        }

        private void cgButton_Click(object sender, EventArgs e)
        {
            GetProgramPath(cgMinerTextBox, "CG Miner", "CGMiner.exe");
        }

        private void bfgButton_Click(object sender, EventArgs e)
        {
            GetProgramPath(cgMinerTextBox, "BFG Miner", "BFGMiner.exe");
        }

        private void cpuButton_Click(object sender, EventArgs e)
        {
            GetProgramPath(cgMinerTextBox, "CPU Miner", "CPUMiner.exe");
        }

        private void GetProgramPath(TextBox textBox, string fileDescription, string fileName)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = false;
                dialog.Filter = string.Format("{0}|{1}|All files|*.*", fileDescription, fileName);

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    textBox.Text = dialog.FileName;
                }
            }
        }
    }
}
