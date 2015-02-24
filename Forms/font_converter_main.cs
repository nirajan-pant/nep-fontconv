using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Nepali_Font_Converter.UnicodeToFont;
using Nepali_Font_Converter.NormalFontToUnicode.CharacterReposition;
using Nepali_Font_Converter.NormalFontToUnicode.FontMappingToUnicode;
using System.IO;
using System.Net.Mail;
using System.Diagnostics;

namespace Nepali_Font_Converter
{
    public partial class font_converter_main : Form
    {
        bool uToFconversion = true;
        public font_converter_main()
        {
            InitializeComponent();
            cbFontType.SelectedIndex = 0;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            String text = tbInputText.Text;
            String outText = "";
            if (uToFconversion == true)
            {
                UpdateProgressSafe(5);
                switch (cbFontType.SelectedIndex)
                {
                    case 0:
                        outText = new ToPreeti().convertToRFont(reposCharacterU2F(text));
                        UpdateProgressSafe(95);
                        tbOutputText.Font = new Font("Preeti", 16);
                        break;
                    case 1:
                        outText = new ToKantipur().convertToRFont(reposCharacterU2F(text));
                        UpdateProgressSafe(95);
                        tbOutputText.Font = new Font("Kantipur", 16);
                        break;
                }
            }
            else if (uToFconversion == false)
            {
                UpdateProgressSafe(5);
                switch (cbFontType.SelectedIndex)
                {
                    case 0:
                        outText = new PreetiToUnicode().convertPreetiToUnicode(text);
                        outText = reposCharacterF2U(outText);
                        UpdateProgressSafe(95);
                        tbOutputText.Font = new Font("Arial Unicode MS", 16);
                        break;
                    case 1:
                        outText = new KantipurToUnicode().convertKantipurToUnicode(text);
                        outText = reposCharacterF2U(outText);
                        UpdateProgressSafe(95);
                        tbOutputText.Font = new Font("Arial Unicode MS", 16);
                        break;
                }
            }
            if (outText != null)
            {
                tbOutputText.Text = outText;
                UpdateProgressSafe(100);
                MessageBox.Show("Conversion Completed Successfully.");
                UpdateProgressSafe(0);
            }
        }

        public String reposCharacterU2F(String text)
        {
            text = new RepositionIkar().reposIkar(text);
            conversionProgressBar.Increment(+10);
            text = new RepositionReph().reposReph(text);
            conversionProgressBar.Increment(+10);
            return text;
        }

        public String reposCharacterF2U(String text)
        {
            text = new ReposRephF2U().reposReph(text);
            conversionProgressBar.Increment(+10);
            text = new RepositionIkarF2U().reposIkar(text);
            conversionProgressBar.Increment(+10);
            return text;
        }

        private void toolStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        // set font id combobox state is changed
        private void cbFontType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uToFconversion == false)
            {
                if (cbFontType.SelectedIndex == 0)
                {
                    tbInputText.Font = new Font("Preeti", 16);
                    tbOutputText.Font = new Font("Arial", 14);
                }
                else
                {
                    tbInputText.Font = new Font("Kantipur", 16);
                    tbOutputText.Font = new Font("Arial", 14);
                }
            }
            else if (uToFconversion == true)
            {
                tbInputText.Font = new Font("Arial", 14);
            }
        }
        // code for undo
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbOutputText.Focused && tbOutputText.CanUndo == true)
            {
                tbOutputText.Paste();
            }
            else if (tbInputText.Focused && tbInputText.CanUndo == true)
            {
                tbInputText.Paste();
            }            
            if (tbOutputText.CanUndo == true)
            {
                tbOutputText.Undo();
            }
        }
        // if mnuItemF2UConversion_Click change to Normal Nepali Font to Unicode Nepali Font Conversion
        private void mnuItemF2UConversion_Click(object sender, EventArgs e)
        {
            labelF2U();
        }
        //set Normal Nepali Font to Unicode Nepali Font Conversion layout
        public void labelF2U()
        {
            mnuItemU2FConversion.Checked = false;
            mnuItemF2UConversion.Checked = true;
            lblConversionType.Text = "Normal Nepali Font to Unicode Nepali Font Conversion";
            lblSelectFont.Text = "Select Input Font";
            tbInputText.Font = new Font("Preeti", 16);
            uToFconversion = false;  // set uToFconversion flag=flase, which defines which layout to use while convet button is clicked      
        }
        // set Unicode Nepali Font to Normal Nepali Font Conversion layout
        public void labelU2F()
        {
            mnuItemU2FConversion.Checked = true;            
            mnuItemF2UConversion.Checked = false;
            lblConversionType.Text = "Unicode Nepali Font to Normal Nepali Font Conversion";
            lblSelectFont.Text = "Select Output Font";
            tbInputText.Font = new Font("Arial", 14);
            uToFconversion = true;   // set uToFconversion flag=true      
        }
        // if mnuItemU2FConversion_Click change to Unicode Nepali Font to Normal Nepali Font Conversion
        private void mnuItemU2FConversion_Click(object sender, EventArgs e)
        {
            labelU2F();
        }

        private void conversionProgressBar_Click(object sender, EventArgs e)
        {
            //conversionProgressBar.Increment(+1);
        }

        void UpdateProgressSafe(int value)
        {
            this.conversionProgressBar.Value = value;
        }
        // save output menu activities
        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            sfdOutputSave.Filter = "Text file (*.txt)|*.txt|Rich Text Document (*.rtf)|*.rtf";
            sfdOutputSave.Title = "Save Converted Text As";
            DialogResult Result = sfdOutputSave.ShowDialog();//Show the dialog to save the file.
            //Test result and determine whether the user selected a file name from the saveFileDialog.
            if ((Result == DialogResult.OK) && (sfdOutputSave.FileName.Length > 0))
            {
                //Save the contents of the richTextBox into the file.
                // create a writer and open the file
                FileInfo fi = new FileInfo(sfdOutputSave.FileName);
                String dirName = fi.DirectoryName;// \\ the directory's full path
                String fileName = fi.Name;// \\ the file name
                String extension = fi.Extension;// \\ the file extension
                //var bytes = Encoding.UTF8.GetBytes(tbOutputText.Text);
                //System.IO.File.WriteAllText(@dirName + "\\" + fileName, tbOutputText.Text);
                if (uToFconversion == true)
                    System.IO.File.WriteAllText(@dirName + "\\" + fileName, tbOutputText.Text, Encoding.ASCII);
                else
                    System.IO.File.WriteAllText(@dirName + "\\" + fileName, tbOutputText.Text, UnicodeEncoding.Unicode);//Encoding.GetEncoding(28591));
            }
        }
        // exit menu click action
        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // open file click action
        public void openTextFile()
        {
            String inText = "";
            ofdFileIn.Filter = "Text file (*.txt)|*.txt|Microsoft Office Document (*.doc)|*.doc";
            ofdFileIn.Title = "Open text file";
            DialogResult result = ofdFileIn.ShowDialog();
            if ((result == DialogResult.OK) && (ofdFileIn.FileName.Length > 0))
            {
                //check input file extension
                FileInfo fi = new FileInfo(ofdFileIn.FileName);
                String dirName = fi.DirectoryName;// \\ the directory's full path
                String fileName = fi.Name;// \\ the file name
                String extension = fi.Extension;// \\ the file extension
                //MessageBox.Show(extension);
                //check complete
                if (extension.Equals(".doc")||extension.Equals(".DOC"))
                { 
                    OfficeFileReader.OfficeFileReader objOFR = new OfficeFileReader.OfficeFileReader();
                    objOFR.GetText(ofdFileIn.FileName, ref inText);
                    Console.WriteLine(inText);                
                }
                else if (extension.Equals(".txt"))
                { 
                    inText = File.ReadAllText(@ofdFileIn.FileName);
                }
                ofdFileIn.FileName = null;
            }
            //MessageBox.Show(inText);
            tbInputText.Text = inText;
        }
        // open file menu click action
        private void mnuOpenFile_Click(object sender, EventArgs e)
        {
            openTextFile();
        }
        // about menu click action
        private void mnuAboutUs_Click(object sender, EventArgs e)
        {
            AboutUs ab = new AboutUs();
            ab.StartPosition = FormStartPosition.CenterParent;
            ab.ShowDialog(this);
        }
        // font color menu action
        private void mnuFontColor_Click(object sender, EventArgs e)
        {
            fontColorDialog.AllowFullOpen = true;
            fontColorDialog.AnyColor = true;
            fontColorDialog.SolidColorOnly = false;
            fontColorDialog.Color = Color.Red;

            if (fontColorDialog.ShowDialog() == DialogResult.OK)
            {
                tbInputText.ForeColor = fontColorDialog.Color;
                tbOutputText.ForeColor = fontColorDialog.Color;
                //button3.ForeColor = fontColorDialog.Color;
            }
        }
        // menu visit site click action
        private void mnuReportProblem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("http://facebook.com/nirajan.pant");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // paste menu click or Ctrl+V activities
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbOutputText.Focused && Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                tbOutputText.Paste();
            }
            else if (tbInputText.Focused && Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                tbInputText.Paste();
            }             
        }
        // cut menu click or Ctrl+X activities
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbOutputText.Focused && tbOutputText.SelectedText != "")
            {
                tbOutputText.Cut();
            }
            else if (tbInputText.Focused && tbInputText.SelectedText != "")
            {
                tbInputText.Cut();
            }            
        }
        // copy menu or Ctrl+C activities
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbOutputText.Focused && tbOutputText.SelectionLength > 0)
            {
                tbOutputText.Copy();
            }
            else if (tbInputText.Focused && tbInputText.SelectionLength > 0)
            {
                tbInputText.Copy();
            }
        }
        // select all menu item click or Ctrl+A activities
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbOutputText.Focused)
                tbOutputText.SelectAll();
            else if(tbInputText.Focused)
                tbInputText.SelectAll();
        }
        // set conversion layout on form load
        private void Form1_Load(object sender, EventArgs e)
        {
            labelF2U();
        }

        private void mnuWordDocEditor_Click(object sender, EventArgs e)
        {
            new Nepali_Font_Converter.Forms.wordDocEditor().ShowDialog();
        }
    }
}
