using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PadPad
{
    public partial class PadPad : Form
    {

        #region Editor and General

        private System.Drawing.Printing.PrintDocument docToPrint =
        new System.Drawing.Printing.PrintDocument();

        public PadPad()
        {
            InitializeComponent();
            toolStrip1.Renderer = new ToolStripStripeRemoval();
            toolStrip2.Renderer = new ToolStripStripeRemoval();
        }

        private void PadPad_Load(object sender, EventArgs e)
        {
            FontSize();
            InstalledFonts();
        }

        #endregion

        #region Methods

        void FontSize()
        {
            for (int fntSize = 10; fntSize <= 75; fntSize++)
            {
                toolStrip2FontSizeBox.Items.Add(fntSize.ToString());
            }
        }

        void InstalledFonts()
        {
            InstalledFontCollection fonts = new InstalledFontCollection();

            for (int i = 0; i < fonts.Families.Length; i++)
            {
                toolStrip2FontBox.Items.Add(fonts.Families[i].Name);
            }
        }

        #endregion


        #region MainMenu

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newToolStrip1Button.PerformClick();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openToolStrip1Button.PerformClick();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAsToolStrip1Button.PerformClick();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cutToolStrip1Button.PerformClick();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyToolStrip1Button.PerformClick();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pasteToolStrip1Button.PerformClick();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undoToolStrip1Button.PerformClick();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redoToolStrip1Button.PerformClick();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectAllToolStrip1Button.PerformClick();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void jumpToTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Document.SelectionStart = 0;
            Document.ScrollToCaret();
        }

        private void jumpToBottomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Document.SelectionStart = Document.Text.Length;
            Document.ScrollToCaret();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printToolStrip1Button.PerformClick();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Associate PrintPreviewDialog with PrintDocument.
            printPreviewDialog1.Document = printDocument1;

            // Show PrintPreview Dialog
            printPreviewDialog1.ShowDialog();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options optionsMenu = new Options();

            optionsMenu.Show();
        }

        #endregion


        #region Toolbar1

        private void newToolStrip1Button_Click(object sender, EventArgs e)
        {
            Document.Clear(); //clear text box
        }

        private void openToolStrip1Button_Click(object sender, EventArgs e)
        {
            if (openWork.ShowDialog() == DialogResult.OK) //if file selected is okay (not used by other applications, etc.)
            {
                Document.Clear();
                Document.LoadFile(openWork.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveToolStrip1Button_Click(object sender, EventArgs e)
        {
            if (saveWork.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Document.SaveFile(saveWork.FileName, RichTextBoxStreamType.PlainText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cutToolStrip1Button_Click(object sender, EventArgs e)
        {
            if (Document.SelectedText != "")
            {
                Document.Cut();
            }
        }

        private void copyToolStrip1Button_Click(object sender, EventArgs e)
        {
            if (Document.SelectionLength > 0)
            {
                Document.Copy();
            }
        }

        private void pasteToolStrip1Button_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                //Determine if any text is selected in the text box.
                if (Document.SelectionLength > 0)
                {
                    Document.SelectionStart = Document.SelectionStart + Document.SelectionLength;
                }
                Document.Paste();
            }
        }

        private void undoToolStrip1Button_Click(object sender, EventArgs e)
        {
            Document.Undo();
        }

        private void redoToolStrip1Button_Click(object sender, EventArgs e)
        {
            Document.Redo();
        }

        private void selectAllToolStrip1Button_Click(object sender, EventArgs e)
        {
            Document.SelectAll();
        }

        protected void printToolStripButton_Click(object sender, System.EventArgs e)
        {
            //PrintDialog associate with PrintDocument;
            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        #endregion


        #region Toolbar2

        private void toolStrip2ZoomIn_Click(object sender, EventArgs e)
        {
            if (Document.ZoomFactor == 63)
            {
                return;
            }
            else
            {
                Document.ZoomFactor = Document.ZoomFactor + 1;
            }
        }

        private void toolStrip2ZoomOut_Click(object sender, EventArgs e)
        {
            if (Document.ZoomFactor == 1)
            {
                return;
            }
            else
            {
                Document.ZoomFactor = Document.ZoomFactor - 1;
            }
        }

        //need to find another way of combining font styles

        private void toolStrip2BoldButton_Click(object sender, EventArgs e)
        {
            Font bfont = new Font(Document.Font, FontStyle.Bold);
            Font ifont = new Font(Document.Font, FontStyle.Italic);
            Font rfont = new Font(Document.Font, FontStyle.Regular);
            Font ibfont = new Font(Document.Font, FontStyle.Bold | FontStyle.Italic);

            if (Document.SelectedText.Length != 0)
            {
                if (Document.SelectionFont.Bold)
                {
                    Document.SelectionFont = rfont;
                }
                else if (Document.SelectionFont.Italic)
                {
                    Document.SelectionFont = ibfont; //set bold and italic
                }
                else
                {
                    Document.SelectionFont = bfont;
                }
            }
            else
                return;
        }

        private void toolStrip2ItalicButton_Click(object sender, EventArgs e)
        {
            Font bfont = new Font(Document.Font, FontStyle.Bold);
            Font ifont = new Font(Document.Font, FontStyle.Italic);
            Font rfont = new Font(Document.Font, FontStyle.Regular);
            Font ibfont = new Font(Document.Font, FontStyle.Bold | FontStyle.Italic);

            if (Document.SelectedText.Length != 0)
            {
                if (Document.SelectionFont.Italic)
                {
                    Document.SelectionFont = rfont;
                }
                else if (Document.SelectionFont.Bold)
                {
                    Document.SelectionFont = ibfont; //set bold and italic
                }
                else
                {
                    Document.SelectionFont = ifont;
                }
            }
            else
                return;
        }

        private void toolStrip2UnderlineButton_Click(object sender, EventArgs e)
        {
            Font bfont = new Font(Document.Font, FontStyle.Bold);
            Font ifont = new Font(Document.Font, FontStyle.Italic);
            Font rfont = new Font(Document.Font, FontStyle.Regular);
            Font ufont = new Font(Document.Font, FontStyle.Underline);
            Font ubfont = new Font(Document.Font, FontStyle.Bold | FontStyle.Underline);
            Font iufont = new Font(Document.Font, FontStyle.Italic | FontStyle.Underline);

            if (Document.SelectedText.Length != 0)
            {
                if (Document.SelectionFont.Underline)
                {
                    Document.SelectionFont = rfont;
                }
                else if (Document.SelectionFont.Bold)
                {
                    Document.SelectionFont = ubfont; //set underline and bold
                }
                else if (Document.SelectionFont.Italic)
                {
                    Document.SelectionFont = iufont; //set italic and underline
                }
                else
                {
                    Document.SelectionFont = ufont;
                }
            }
            else
                return;
        }

        private void toolStrip2StrikethroughButton_Click(object sender, EventArgs e)
        {
            Font bfont = new Font(Document.Font, FontStyle.Bold);
            Font ifont = new Font(Document.Font, FontStyle.Italic);
            Font rfont = new Font(Document.Font, FontStyle.Regular);
            Font sfont = new Font(Document.Font, FontStyle.Strikeout);
            Font bsfont = new Font(Document.Font, FontStyle.Bold | FontStyle.Strikeout);

            if (Document.SelectedText.Length != 0)
            {
                if (Document.SelectionFont.Strikeout)
                {
                    Document.SelectionFont = rfont;
                }
                else if (Document.SelectionFont.Bold)
                {
                    Document.SelectionFont = bsfont; //set underline and bold
                }
                else
                {
                    Document.SelectionFont = sfont;
                }
            }
            else
                return;
        }

        private void toolStrip2AlignLeft_Click(object sender, EventArgs e)
        {
            Document.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStrip2AlignCenter_Click(object sender, EventArgs e)
        {
            Document.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStrip2AlignRight_Click(object sender, EventArgs e)
        {
            Document.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStrip2Uppercase_Click(object sender, EventArgs e)
        {
            Document.SelectedText = Document.SelectedText.ToUpper();
        }

        private void toolStrip2Lowercase_Click(object sender, EventArgs e)
        {
            Document.SelectedText = Document.SelectedText.ToLower();
        }

        #endregion

        #region ContextMenu

        private void boldContextMenu_Click(object sender, EventArgs e)
        {
            toolStrip2BoldButton.PerformClick();
        }

        private void italicContextMenu_Click(object sender, EventArgs e)
        {
            toolStrip2ItalicButton.PerformClick();
        }

        private void underlineContextMenu_Click(object sender, EventArgs e)
        {
            toolStrip2UnderlineButton.PerformClick();
        }

        private void strikethroughContextMenu_Click(object sender, EventArgs e)
        {
            toolStrip2StrikethroughButton.PerformClick();
        }

        private void cutContextMenu_Click(object sender, EventArgs e)
        {
            cutToolStrip1Button.PerformClick();
        }

        private void copyContextMenu_Click(object sender, EventArgs e)
        {
            copyToolStrip1Button.PerformClick();
        }

        private void pasteContextMenu_Click(object sender, EventArgs e)
        {
            pasteToolStrip1Button.PerformClick();
        }

        private void selectAllContextMenu_Click(object sender, EventArgs e)
        {
            selectAllToolStrip1Button.PerformClick();
        }

        #endregion

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

        //cursor map
        private void timer1_Tick(object sender, EventArgs e)
        {
            line = 1 + Document.GetLineFromCharIndex(Document.GetFirstCharIndexOfCurrentLine());
            column = 1 + Document.SelectionStart - Document.GetFirstCharIndexOfCurrentLine();
            statusLabel1.Text = "Line: " + line.ToString();
            statusLabel2.Text = "Column: " + column.ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(Document.Text, Document.Font, Brushes.Black, 100, 20);
            e.Graphics.PageUnit = GraphicsUnit.Inch;
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string text = Document.Text;
            Font printFont = new Font
                ("Liberation Sans", 12, FontStyle.Regular);

            // Draw the content.
            e.Graphics.DrawString(text, printFont,
                Brushes.Black, 10, 10);
        }

        private void toolStrip2FontBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font ComboFonts = null;

            try
            {
                ComboFonts = Document.SelectionFont;
                Document.SelectionFont = new Font(toolStrip2FontBox.Text, Document.SelectionFont.Size, Document.SelectionFont.Style);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void toolStrip2FontSizeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Document.SelectionFont = new Font(toolStrip2FontSizeBox.SelectedItem.ToString(), int.Parse(toolStrip2FontSizeBox.SelectedItem.ToString()),                                                          Document.SelectionFont.Style);
        }
    }
}
