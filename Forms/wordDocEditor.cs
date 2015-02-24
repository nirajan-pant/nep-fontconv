using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;


namespace Nepali_Font_Converter.Forms
{
    public partial class wordDocEditor : Form
    {
        public wordDocEditor()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string file_info = openFile();
            if (file_info.Length > 0)
            {
                //MessageBox.Show(file_info);
                //changeFontTypeInWord(file_info);
                //openDocument(file_info);
                SearchReplace(file_info);
            }
            else
            {
                //MessageBox.Show("File not selected");
            } //Do file cannot open dialog
        }

        public string openFile()
        {
            FileInfo fi = null;
            string full_path = "";
            try 
	        {	        
                ofdDocEditor.Filter = "All Supported Documents (*.txt, *.doc, *.docx)|*.txt;*.doc;*.docx";
                ofdDocEditor.Title = "Open Document";
                ofdDocEditor.FileName = null;
                DialogResult result = ofdDocEditor.ShowDialog();
                if ((result == DialogResult.OK) && (ofdDocEditor.FileName.Length > 0))
                {
                    //check input file extension
                    fi = new FileInfo(ofdDocEditor.FileName);
                    full_path = fi.FullName;
                }
	        }
	        catch (Exception)
	        {
		
		        throw;
	        }
            return full_path;
        }
      
        private void openDocument(String file_path)
        {
            Word.Application app = new Word.Application();
            Word.Document doc = app.Documents.Open(file_path);
            app.Visible = false;
            doc.Activate();
            Word.Words wds = doc.Sections[1].Range.Words;

            //Iterate the word need to change font
            foreach (Word.Range wd in wds)
            {
                //if (wd.Text.Equals("<") || wd.Text.Equals(">") || wd.Text.Equals("name") || wd.Text.Equals("address") || wd.Text.Equals("city") || wd.Text.Equals("state") || wd.Text.Equals("zip") || wd.Text.Equals("company"))
                //{
                //    wd.Font.Color = Word.WdColor.wdColorBlue;
                //}

                ////Try if it works
                if(wd.Text.Equals(" "))
                {
                    continue;
                    //Do nothing
                }
                else if (wd.Font.Name.Equals("Preeti"))
                {
                   wd.Text.Replace(wd.Text, "NULL");
                }

                //Try finish
            }
            FindAndReplace(app, "<name>", "Ram prasad");
            FindAndReplace(app, "<address>", "00 Main street");

            doc.Save();
            doc.Close();
            app.Quit();
            MessageBox.Show("Task Completed.");
        }

        private void FindAndReplace(Microsoft.Office.Interop.Word.Application WordApp, object findText, object replaceWithText)
        {
          object matchCase = true;
          object matchWholeWord = true;
          object matchWildCards = false;
          object matchSoundsLike = false;
          object nmatchAllWordForms = false;
          object forward = true;
          object format = false;
          object matchKashida = false;
          object matchDiacritics = false;
          object matchAlefHamza = false;
          object matchControl = false;
          object read_only = false;
          object visible = true;
          object replace = 2;
          object wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue;
          object replaceAll = Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll;
          WordApp.Selection.Find.Execute(ref findText, ref matchCase, ref matchWholeWord, ref matchWildCards, ref matchSoundsLike,
          ref nmatchAllWordForms, ref forward,
          ref wrap, ref format, ref replaceWithText,
          ref replaceAll, ref matchKashida,
          ref matchDiacritics, ref matchAlefHamza,
          ref matchControl);
        }

        private void SearchReplace(String file_path)
        {
            Microsoft.Office.Interop.Word._Application word;
            Microsoft.Office.Interop.Word._Document document;
            word = new Microsoft.Office.Interop.Word.Application();
            word.Visible = false;
            document = word.Documents.Open(file_path);
            document.Activate();
            object findStr = "hello"; // Find Text in Word Document
            
            while (word.Selection.Find.Execute(ref findStr))  //If Found...
             {
                //change font and format of matched words
                word.Selection.Font.Name = "Arial"; //change font to Arial
            }
            document.Close();
            MessageBox.Show("Task Completed.");
        }
    }
}