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

            if (lightModeCheckBox1.Checked == true)
            {
                BackColor = Properties.Settings.Default.LightMode;
                ForeColor = Properties.Settings.Default.DarkMode;
                ApplyButton1.BackColor = Properties.Settings.Default.LightMode;
                ApplyButton1.ForeColor = Properties.Settings.Default.DarkMode;
                ConfirmButton1.BackColor = Properties.Settings.Default.LightMode;
                ConfirmButton1.ForeColor = Properties.Settings.Default.DarkMode;
                CancelButton1.BackColor = Properties.Settings.Default.LightMode;
                CancelButton1.ForeColor = Properties.Settings.Default.DarkMode;

                PadPad.toolStrip1.BackColor = Properties.Settings.Default.LightMode;
                PadPad.toolStrip1.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.menuStrip1.BackColor = Properties.Settings.Default.LightMode;
                PadPad.menuStrip1.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.fileToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
                PadPad.fileToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.newToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
                PadPad.newToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.openToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
                PadPad.openToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.saveToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
                PadPad.saveToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.printToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
                PadPad.printToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.printPreviewToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
                PadPad.printPreviewToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.exitToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
                PadPad.exitToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.editToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
                PadPad.editToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.undoToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
                PadPad.undoToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.redoToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
                PadPad.redoToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.cutToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
                PadPad.cutToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.copyToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
                PadPad.copyToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.pasteToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
                PadPad.pasteToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.selectAllToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
                PadPad.selectAllToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.toolsToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
                PadPad.toolsToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.insertToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
                PadPad.insertToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.pictureToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
                PadPad.pictureToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.spreadsheetToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
                PadPad.spreadsheetToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.customizeToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
                PadPad.customizeToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.optionsToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
                PadPad.optionsToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.searchToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
                PadPad.searchToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.findToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
                PadPad.findToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.findAndReplaceToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
                PadPad.findAndReplaceToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.jumpToBottomToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
                PadPad.jumpToBottomToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.jumpToTopToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
                PadPad.jumpToTopToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.creditsToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
                PadPad.creditsToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.paddy2019ToolStripMenuItem.BackColor = Properties.Settings.Default.LightMode;
                PadPad.paddy2019ToolStripMenuItem.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.newToolStrip1Button.BackColor = Properties.Settings.Default.LightMode;
                PadPad.newToolStrip1Button.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.openToolStrip1Button.BackColor = Properties.Settings.Default.LightMode;
                PadPad.openToolStrip1Button.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.saveAsToolStrip1Button.BackColor = Properties.Settings.Default.LightMode;
                PadPad.saveAsToolStrip1Button.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.printToolStrip1Button.BackColor = Properties.Settings.Default.LightMode;
                PadPad.printToolStrip1Button.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.toolStrip1Separator1.BackColor = Properties.Settings.Default.LightMode;
                PadPad.toolStrip1Separator1.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.cutToolStrip1Button.BackColor = Properties.Settings.Default.LightMode;
                PadPad.cutToolStrip1Button.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.copyToolStrip1Button.BackColor = Properties.Settings.Default.LightMode;
                PadPad.copyToolStrip1Button.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.pasteToolStrip1Button.BackColor = Properties.Settings.Default.LightMode;
                PadPad.pasteToolStrip1Button.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.toolStrip1Separator2.BackColor = Properties.Settings.Default.LightMode;
                PadPad.toolStrip1Separator2.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.undoToolStrip1Button.BackColor = Properties.Settings.Default.LightMode;
                PadPad.undoToolStrip1Button.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.redoToolStrip1Button.BackColor = Properties.Settings.Default.LightMode;
                PadPad.redoToolStrip1Button.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.selectAllToolStrip1Button.BackColor = Properties.Settings.Default.LightMode;
                PadPad.selectAllToolStrip1Button.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.pasteToolStrip1Button.BackColor = Properties.Settings.Default.LightMode;
                PadPad.pasteToolStrip1Button.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.Document.BackColor = Properties.Settings.Default.LightMode;
                PadPad.Document.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.contextMenu.BackColor = Properties.Settings.Default.LightMode;
                PadPad.contextMenu.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.statusStrip1.BackColor = Properties.Settings.Default.LightMode;
                PadPad.statusStrip1.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.statusLabel1.BackColor = Properties.Settings.Default.LightMode;
                PadPad.statusLabel1.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.statusLabel2.BackColor = Properties.Settings.Default.LightMode;
                PadPad.statusLabel2.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.VersionLabel1.BackColor = Properties.Settings.Default.LightMode;
                PadPad.VersionLabel1.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.strikethroughContextMenu.BackColor = Properties.Settings.Default.LightMode;
                PadPad.strikethroughContextMenu.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.italicContextMenu.BackColor = Properties.Settings.Default.LightMode;
                PadPad.italicContextMenu.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.underlineContextMenu.BackColor = Properties.Settings.Default.LightMode;
                PadPad.underlineContextMenu.ForeColor = Properties.Settings.Default.DarkMode;
                PadPad.strikethroughContextMenu.BackColor = Properties.Settings.Default.LightMode;
                PadPad.strikethroughContextMenu.ForeColor = Properties.Settings.Default.DarkMode;

                Properties.Settings.Default.ActiveMode = "Light";
            }
            else
            {
                BackColor = Properties.Settings.Default.DarkMode;
                ForeColor = Properties.Settings.Default.LightMode;
                ApplyButton1.BackColor = Properties.Settings.Default.DarkMode;
                ApplyButton1.ForeColor = Properties.Settings.Default.LightMode;
                ConfirmButton1.BackColor = Properties.Settings.Default.DarkMode;
                ConfirmButton1.ForeColor = Properties.Settings.Default.LightMode;
                CancelButton1.BackColor = Properties.Settings.Default.DarkMode;
                CancelButton1.ForeColor = Properties.Settings.Default.LightMode;

                PadPad.toolStrip1.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.toolStrip1.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.menuStrip1.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.menuStrip1.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.fileToolStripMenuItem.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.fileToolStripMenuItem.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.newToolStripMenuItem.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.newToolStripMenuItem.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.openToolStripMenuItem.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.openToolStripMenuItem.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.saveToolStripMenuItem.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.saveToolStripMenuItem.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.printToolStripMenuItem.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.printToolStripMenuItem.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.printPreviewToolStripMenuItem.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.printPreviewToolStripMenuItem.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.exitToolStripMenuItem.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.exitToolStripMenuItem.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.editToolStripMenuItem.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.editToolStripMenuItem.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.undoToolStripMenuItem.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.undoToolStripMenuItem.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.redoToolStripMenuItem.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.redoToolStripMenuItem.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.cutToolStripMenuItem.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.cutToolStripMenuItem.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.copyToolStripMenuItem.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.copyToolStripMenuItem.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.pasteToolStripMenuItem.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.pasteToolStripMenuItem.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.selectAllToolStripMenuItem.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.selectAllToolStripMenuItem.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.toolsToolStripMenuItem.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.toolsToolStripMenuItem.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.insertToolStripMenuItem.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.insertToolStripMenuItem.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.pictureToolStripMenuItem.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.pictureToolStripMenuItem.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.spreadsheetToolStripMenuItem.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.spreadsheetToolStripMenuItem.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.customizeToolStripMenuItem.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.customizeToolStripMenuItem.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.optionsToolStripMenuItem.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.optionsToolStripMenuItem.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.searchToolStripMenuItem.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.searchToolStripMenuItem.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.findToolStripMenuItem.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.findToolStripMenuItem.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.findAndReplaceToolStripMenuItem.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.findAndReplaceToolStripMenuItem.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.jumpToBottomToolStripMenuItem.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.jumpToBottomToolStripMenuItem.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.jumpToTopToolStripMenuItem.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.jumpToTopToolStripMenuItem.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.creditsToolStripMenuItem.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.creditsToolStripMenuItem.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.paddy2019ToolStripMenuItem.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.paddy2019ToolStripMenuItem.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.newToolStrip1Button.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.newToolStrip1Button.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.openToolStrip1Button.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.openToolStrip1Button.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.saveAsToolStrip1Button.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.saveAsToolStrip1Button.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.printToolStrip1Button.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.printToolStrip1Button.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.toolStrip1Separator1.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.toolStrip1Separator1.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.cutToolStrip1Button.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.cutToolStrip1Button.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.copyToolStrip1Button.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.copyToolStrip1Button.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.pasteToolStrip1Button.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.pasteToolStrip1Button.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.toolStrip1Separator2.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.toolStrip1Separator2.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.undoToolStrip1Button.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.undoToolStrip1Button.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.redoToolStrip1Button.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.redoToolStrip1Button.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.selectAllToolStrip1Button.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.selectAllToolStrip1Button.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.pasteToolStrip1Button.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.pasteToolStrip1Button.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.Document.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.Document.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.contextMenu.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.contextMenu.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.statusStrip1.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.statusStrip1.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.statusLabel1.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.statusLabel1.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.statusLabel2.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.statusLabel2.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.VersionLabel1.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.VersionLabel1.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.strikethroughContextMenu.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.strikethroughContextMenu.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.italicContextMenu.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.italicContextMenu.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.underlineContextMenu.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.underlineContextMenu.ForeColor = Properties.Settings.Default.LightMode;
                PadPad.strikethroughContextMenu.BackColor = Properties.Settings.Default.DarkMode;
                PadPad.strikethroughContextMenu.ForeColor = Properties.Settings.Default.LightMode;

                Properties.Settings.Default.ActiveMode = "Dark";
            }

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
