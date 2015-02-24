namespace Nepali_Font_Converter
{
    partial class font_converter_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(font_converter_main));
            this.btnConvert = new System.Windows.Forms.Button();
            this.cbFontType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConversionType = new System.Windows.Forms.Label();
            this.lblSelectFont = new System.Windows.Forms.Label();
            this.conversionProgressBar = new System.Windows.Forms.ProgressBar();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemF2UConversion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemU2FConversion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFontColor = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportProblem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.tbInputText = new System.Windows.Forms.TextBox();
            this.tbOutputText = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            this.sfdOutputSave = new System.Windows.Forms.SaveFileDialog();
            this.ofdFileIn = new System.Windows.Forms.OpenFileDialog();
            this.fontColorDialog = new System.Windows.Forms.ColorDialog();
            this.mnuWordDocEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStrip.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            resources.ApplyResources(this.btnConvert, "btnConvert");
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // cbFontType
            // 
            this.cbFontType.FormattingEnabled = true;
            this.cbFontType.Items.AddRange(new object[] {
            resources.GetString("cbFontType.Items"),
            resources.GetString("cbFontType.Items1")});
            resources.ApplyResources(this.cbFontType, "cbFontType");
            this.cbFontType.Name = "cbFontType";
            this.cbFontType.SelectedIndexChanged += new System.EventHandler(this.cbFontType_SelectedIndexChanged);
            this.cbFontType.Click += new System.EventHandler(this.cbFontType_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblConversionType
            // 
            resources.ApplyResources(this.lblConversionType, "lblConversionType");
            this.lblConversionType.Name = "lblConversionType";
            // 
            // lblSelectFont
            // 
            resources.ApplyResources(this.lblSelectFont, "lblSelectFont");
            this.lblSelectFont.Name = "lblSelectFont";
            // 
            // conversionProgressBar
            // 
            resources.ApplyResources(this.conversionProgressBar, "conversionProgressBar");
            this.conversionProgressBar.Name = "conversionProgressBar";
            this.conversionProgressBar.Click += new System.EventHandler(this.conversionProgressBar_Click);
            // 
            // mnuStrip
            // 
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem1,
            this.helpToolStripMenuItem1});
            resources.ApplyResources(this.mnuStrip, "mnuStrip");
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenFile,
            this.toolStripSeparator,
            this.mnuSaveAs,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem2});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            resources.ApplyResources(this.fileToolStripMenuItem1, "fileToolStripMenuItem1");
            // 
            // mnuOpenFile
            // 
            resources.ApplyResources(this.mnuOpenFile, "mnuOpenFile");
            this.mnuOpenFile.Name = "mnuOpenFile";
            this.mnuOpenFile.Click += new System.EventHandler(this.mnuOpenFile_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            resources.ApplyResources(this.toolStripSeparator, "toolStripSeparator");
            // 
            // mnuSaveAs
            // 
            this.mnuSaveAs.Name = "mnuSaveAs";
            resources.ApplyResources(this.mnuSaveAs, "mnuSaveAs");
            this.mnuSaveAs.Click += new System.EventHandler(this.mnuSaveAs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            resources.ApplyResources(this.exitToolStripMenuItem2, "exitToolStripMenuItem2");
            this.exitToolStripMenuItem2.Click += new System.EventHandler(this.exitToolStripMenuItem2_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.toolStripSeparator4,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator5,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            resources.ApplyResources(this.undoToolStripMenuItem, "undoToolStripMenuItem");
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // cutToolStripMenuItem
            // 
            resources.ApplyResources(this.cutToolStripMenuItem, "cutToolStripMenuItem");
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            resources.ApplyResources(this.copyToolStripMenuItem, "copyToolStripMenuItem");
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            resources.ApplyResources(this.pasteToolStripMenuItem, "pasteToolStripMenuItem");
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            resources.ApplyResources(this.selectAllToolStripMenuItem, "selectAllToolStripMenuItem");
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem1
            // 
            this.toolsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemF2UConversion,
            this.mnuItemU2FConversion,
            this.mnuFontColor,
            this.mnuWordDocEditor});
            this.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
            resources.ApplyResources(this.toolsToolStripMenuItem1, "toolsToolStripMenuItem1");
            // 
            // mnuItemF2UConversion
            // 
            this.mnuItemF2UConversion.Checked = true;
            this.mnuItemF2UConversion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuItemF2UConversion.Name = "mnuItemF2UConversion";
            resources.ApplyResources(this.mnuItemF2UConversion, "mnuItemF2UConversion");
            this.mnuItemF2UConversion.Click += new System.EventHandler(this.mnuItemF2UConversion_Click);
            // 
            // mnuItemU2FConversion
            // 
            this.mnuItemU2FConversion.Name = "mnuItemU2FConversion";
            resources.ApplyResources(this.mnuItemU2FConversion, "mnuItemU2FConversion");
            this.mnuItemU2FConversion.Click += new System.EventHandler(this.mnuItemU2FConversion_Click);
            // 
            // mnuFontColor
            // 
            this.mnuFontColor.Name = "mnuFontColor";
            resources.ApplyResources(this.mnuFontColor, "mnuFontColor");
            this.mnuFontColor.Click += new System.EventHandler(this.mnuFontColor_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReportProblem,
            this.toolStripSeparator6,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            resources.ApplyResources(this.helpToolStripMenuItem1, "helpToolStripMenuItem1");
            // 
            // mnuReportProblem
            // 
            this.mnuReportProblem.Name = "mnuReportProblem";
            resources.ApplyResources(this.mnuReportProblem, "mnuReportProblem");
            this.mnuReportProblem.Click += new System.EventHandler(this.mnuReportProblem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.mnuAboutUs_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // tbInputText
            // 
            resources.ApplyResources(this.tbInputText, "tbInputText");
            this.tbInputText.Name = "tbInputText";
            // 
            // tbOutputText
            // 
            resources.ApplyResources(this.tbOutputText, "tbOutputText");
            this.tbOutputText.Name = "tbOutputText";
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.tbInputText);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbOutputText);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.conversionProgressBar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnConvert, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbFontType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSelectFont, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // mnuWordDocEditor
            // 
            this.mnuWordDocEditor.Name = "mnuWordDocEditor";
            resources.ApplyResources(this.mnuWordDocEditor, "mnuWordDocEditor");
            this.mnuWordDocEditor.Click += new System.EventHandler(this.mnuWordDocEditor_Click);
            // 
            // font_converter_main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mnuStrip);
            this.Controls.Add(this.lblConversionType);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.mnuStrip;
            this.Name = "font_converter_main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ComboBox cbFontType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConversionType;
        private System.Windows.Forms.Label lblSelectFont;
        private System.Windows.Forms.ProgressBar conversionProgressBar;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbInputText;
        private System.Windows.Forms.TextBox tbOutputText;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuItemF2UConversion;
        private System.Windows.Forms.ToolStripMenuItem mnuItemU2FConversion;
        private System.Windows.Forms.ToolStripMenuItem mnuFontColor;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuReportProblem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Timer timerProgress;
        private System.Windows.Forms.SaveFileDialog sfdOutputSave;
        private System.Windows.Forms.OpenFileDialog ofdFileIn;
        private System.Windows.Forms.ColorDialog fontColorDialog;
        private System.Windows.Forms.ToolStripMenuItem mnuWordDocEditor;
    }
}

