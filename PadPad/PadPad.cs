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

namespace PadPad
{
    public partial class PadPad : Form
    {
        public PadPad()
        {
            InitializeComponent();
            toolStrip1.Renderer = new ToolStripStripeRemoval(); //initialize ToolStripStripeRemoval class
        }

        public int line = 0;
        public int column = 0;

        public class ToolStripStripeRemoval : ToolStripSystemRenderer
        {
            public ToolStripStripeRemoval() { }

            protected override void //removes the ugly stripe
                OnRenderToolStripBorder (ToolStripRenderEventArgs e)
            {
                //ToolStripStripeRemoval
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear(); //clear text box
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear(); //clear text box
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog(); //create Open File dialog
            openfile.Title = "Open file.."; 
            if (openfile.ShowDialog() == DialogResult.OK) //if file selected is okay (not used by other applications, etc.)
            {
                richTextBox1.Clear(); //clear text box before loading
                using (StreamReader sr = new StreamReader(openfile.FileName)) //reads file
                {
                    richTextBox1.Text = sr.ReadToEnd(); 
                    sr.Close();
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openToolStripButton.PerformClick();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog(); //create Save File dialog
            savefile.Title = "Save file as.."; 
            if (savefile.ShowDialog() == DialogResult.OK) //if file selected is okay (not used by other applications, etc.)
            {
                StreamWriter txtoutput = new StreamWriter(savefile.FileName); //text output to save file name
                txtoutput.Write(richTextBox1.Text); //save text
                txtoutput.Close(); //closes output
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAsToolStripButton.PerformClick();
        }

        //print code here

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.Cut();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cutToolStripButton.PerformClick();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            if(richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyToolStripButton.PerformClick();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                // Determine if any text is selected in the text box.
                if (richTextBox1.SelectionLength > 0)
                {
                    richTextBox1.SelectionStart = richTextBox1.SelectionStart + richTextBox1.SelectionLength;
                }
                richTextBox1.Paste();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pasteToolStripButton.PerformClick();
        }

        private void undoStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undoStripButton1.PerformClick();
        }

        private void redoStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redoStripButton1.PerformClick();
        }

        private void selectAllButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectAllButton1.PerformClick();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //cursor map
        private void timer1_Tick(object sender, EventArgs e)
        {
            line = 1 + richTextBox1.GetLineFromCharIndex(richTextBox1.GetFirstCharIndexOfCurrentLine());
            column = 1 + richTextBox1.SelectionStart - richTextBox1.GetFirstCharIndexOfCurrentLine();
            toolStripStatusLabel1.Text = "Line: " + line.ToString();
            toolStripStatusLabel2.Text = "Column: " + column.ToString();
        }

        private void jumpToTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = 0; 
            richTextBox1.ScrollToCaret();
        }

        private void jumpToBottomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }

        private System.Drawing.Printing.PrintDocument docToPrint =
            new System.Drawing.Printing.PrintDocument();

        protected void printToolStripButton_Click(object sender, System.EventArgs e)
        {
            //PrintDialog associate with PrintDocument;
            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, 100, 20);
            e.Graphics.PageUnit = GraphicsUnit.Inch;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printToolStripButton.PerformClick();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Associate PrintPreviewDialog with PrintDocument.
            printPreviewDialog1.Document = printDocument1;

            // Show PrintPreview Dialog
            printPreviewDialog1.ShowDialog();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string text = richTextBox1.Text;
            Font printFont = new Font
                ("Liberation Sans", 12, FontStyle.Regular);

            // Draw the content.
            e.Graphics.DrawString(text, printFont,
                Brushes.Black, 10, 10);
        }

        private void paddy2019ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/EnrgyPC/PadPad");
        }
    }
}
