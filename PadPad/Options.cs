using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadPad
{
    public partial class Options : Form
    {
        PadPad PadPad = new PadPad();

        public Options()
        {
            InitializeComponent();
        }

        private void lightModeCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

            //doesn't work yet

            //if (lightModeCheckBox1.Checked == true)
            //{
            //    BackColor = Properties.Settings.Default.LightMode;
            //    ForeColor = Properties.Settings.Default.DarkMode;
            //    ApplyButton1.BackColor = Properties.Settings.Default.LightMode;
            //    ApplyButton1.ForeColor = Properties.Settings.Default.DarkMode;
            //    PadPad.menuStrip1.BackColor = Properties.Settings.Default.LightMode;
            //    PadPad.menuStrip1.ForeColor = Properties.Settings.Default.DarkMode;
            //    PadPad.fileToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
            //    PadPad.fileToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
            //    PadPad.newToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
            //    PadPad.newToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
            //    PadPad.openToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
            //    PadPad.openToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
            //    PadPad.saveToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
            //    PadPad.saveToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
            //    PadPad.printToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
            //    PadPad.printToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
            //    PadPad.printPreviewToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
            //    PadPad.printPreviewToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
            //    PadPad.exitToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
            //    PadPad.exitToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
            //    PadPad.toolStrip1.BackColor = Properties.Settings.Default.LightMode;
            //    PadPad.toolStrip1.ForeColor = Properties.Settings.Default.DarkMode;

            //    Properties.Settings.Default.ActiveMode = "Light Mode";
            //}
            //else
            //{
            //    BackColor = Properties.Settings.Default.DarkMode;
            //    ForeColor = Properties.Settings.Default.LightMode;
            //    ApplyButton1.BackColor = Properties.Settings.Default.DarkMode;
            //    ApplyButton1.ForeColor = Properties.Settings.Default.LightMode;

            //    Properties.Settings.Default.ActiveMode = "Dark Mode";
            //}

        }

        private void ApplyButton1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }


        private void ConfirmButton1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Hide();
        }

        private void CancelButton1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
