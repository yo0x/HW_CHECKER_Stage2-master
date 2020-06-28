namespace DropFilesTest1
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panelDragFiles = new System.Windows.Forms.Panel();
            this.label1DragFiles = new System.Windows.Forms.Label();
            this.listBox1DragFiles = new System.Windows.Forms.ListBox();
            this.buttonNextPanel = new System.Windows.Forms.Button();
            this.panelFilesOverView = new System.Windows.Forms.Panel();
            this.groupBoxFilesToBuild = new System.Windows.Forms.GroupBox();
            this.checkBoxCMakeFiles = new System.Windows.Forms.CheckBox();
            this.labelCmakeFiles = new System.Windows.Forms.Label();
            this.groupBoxFilesToBeChecked = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxCfiles = new System.Windows.Forms.CheckBox();
            this.checkBoxJavaFiles = new System.Windows.Forms.CheckBox();
            this.checkBoxPythonFiles = new System.Windows.Forms.CheckBox();
            this.label1SummaryFiles = new System.Windows.Forms.Label();
            this.buttonBackSFW = new System.Windows.Forms.Button();
            this.panelSelectMode = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSelectedHest1 = new System.Windows.Forms.Button();
            this.buttonSelectedHEST2 = new System.Windows.Forms.Button();
            this.groupBoxFilesSummary = new System.Windows.Forms.GroupBox();
            this.labelCfilesMakeSummary = new System.Windows.Forms.Label();
            this.labelJavaFilesSummary = new System.Windows.Forms.Label();
            this.labelPythonFilesSummary = new System.Windows.Forms.Label();
            this.labelCfilesSummary = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSelectMode = new System.Windows.Forms.Label();
            this.panelResultsWindow = new System.Windows.Forms.Panel();
            this.groupBox2SummaryReport = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.labelErrorCbuildFiles = new System.Windows.Forms.Label();
            this.label10NumCmakeFilesBuilt = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelErrorsCfiles = new System.Windows.Forms.Label();
            this.label9NumCFilesChecked = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.labelErrorPython = new System.Windows.Forms.Label();
            this.label10NumPythonFilesChecked = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.labelErrorJavaFiles = new System.Windows.Forms.Label();
            this.label9NumJavaFilesChecked = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelFilesChecked = new System.Windows.Forms.Label();
            this.label5SummaryFilesHEST1HEST2 = new System.Windows.Forms.Label();
            this.button4GenerateReport = new System.Windows.Forms.Button();
            this.buttonNewRevision = new System.Windows.Forms.Button();
            this.buttonExitProgramEND = new System.Windows.Forms.Button();
            this.buttonExitPro = new System.Windows.Forms.Button();
            this.PanelSignIn = new System.Windows.Forms.Panel();
            this.button1EnterProg = new System.Windows.Forms.Button();
            this.panelDragFiles.SuspendLayout();
            this.panelFilesOverView.SuspendLayout();
            this.groupBoxFilesToBuild.SuspendLayout();
            this.groupBoxFilesToBeChecked.SuspendLayout();
            this.panelSelectMode.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxFilesSummary.SuspendLayout();
            this.panelResultsWindow.SuspendLayout();
            this.groupBox2SummaryReport.SuspendLayout();
            this.PanelSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDragFiles
            // 
            this.panelDragFiles.Controls.Add(this.label1DragFiles);
            this.panelDragFiles.Controls.Add(this.listBox1DragFiles);
            this.panelDragFiles.Location = new System.Drawing.Point(12, 12);
            this.panelDragFiles.Name = "panelDragFiles";
            this.panelDragFiles.Size = new System.Drawing.Size(984, 636);
            this.panelDragFiles.TabIndex = 4;
            // 
            // label1DragFiles
            // 
            this.label1DragFiles.AutoSize = true;
            this.label1DragFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1DragFiles.Location = new System.Drawing.Point(291, 76);
            this.label1DragFiles.Name = "label1DragFiles";
            this.label1DragFiles.Size = new System.Drawing.Size(377, 29);
            this.label1DragFiles.TabIndex = 6;
            this.label1DragFiles.Text = "DRAG FILES TO BE CHECKED";
            // 
            // listBox1DragFiles
            // 
            this.listBox1DragFiles.AllowDrop = true;
            this.listBox1DragFiles.FormattingEnabled = true;
            this.listBox1DragFiles.Location = new System.Drawing.Point(87, 158);
            this.listBox1DragFiles.Name = "listBox1DragFiles";
            this.listBox1DragFiles.Size = new System.Drawing.Size(821, 394);
            this.listBox1DragFiles.TabIndex = 4;
            this.listBox1DragFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox1DragFiles_DragEnter_1);
            // 
            // buttonNextPanel
            // 
            this.buttonNextPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNextPanel.Location = new System.Drawing.Point(770, 676);
            this.buttonNextPanel.Name = "buttonNextPanel";
            this.buttonNextPanel.Size = new System.Drawing.Size(226, 41);
            this.buttonNextPanel.TabIndex = 5;
            this.buttonNextPanel.Text = "Next";
            this.buttonNextPanel.UseVisualStyleBackColor = true;
            this.buttonNextPanel.Visible = false;
            this.buttonNextPanel.Click += new System.EventHandler(this.ButtonNextPanel_Click);
            // 
            // panelFilesOverView
            // 
            this.panelFilesOverView.Controls.Add(this.groupBoxFilesToBuild);
            this.panelFilesOverView.Controls.Add(this.groupBoxFilesToBeChecked);
            this.panelFilesOverView.Controls.Add(this.label1SummaryFiles);
            this.panelFilesOverView.Location = new System.Drawing.Point(12, 12);
            this.panelFilesOverView.Name = "panelFilesOverView";
            this.panelFilesOverView.Size = new System.Drawing.Size(984, 636);
            this.panelFilesOverView.TabIndex = 5;
            // 
            // groupBoxFilesToBuild
            // 
            this.groupBoxFilesToBuild.Controls.Add(this.checkBoxCMakeFiles);
            this.groupBoxFilesToBuild.Controls.Add(this.labelCmakeFiles);
            this.groupBoxFilesToBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBoxFilesToBuild.Location = new System.Drawing.Point(74, 356);
            this.groupBoxFilesToBuild.Name = "groupBoxFilesToBuild";
            this.groupBoxFilesToBuild.Size = new System.Drawing.Size(834, 194);
            this.groupBoxFilesToBuild.TabIndex = 10;
            this.groupBoxFilesToBuild.TabStop = false;
            this.groupBoxFilesToBuild.Text = "C files to build";
            // 
            // checkBoxCMakeFiles
            // 
            this.checkBoxCMakeFiles.AutoSize = true;
            this.checkBoxCMakeFiles.Location = new System.Drawing.Point(342, 130);
            this.checkBoxCMakeFiles.Name = "checkBoxCMakeFiles";
            this.checkBoxCMakeFiles.Size = new System.Drawing.Size(159, 30);
            this.checkBoxCMakeFiles.TabIndex = 9;
            this.checkBoxCMakeFiles.Text = "C-Make Files";
            this.checkBoxCMakeFiles.UseVisualStyleBackColor = true;
            // 
            // labelCmakeFiles
            // 
            this.labelCmakeFiles.AutoSize = true;
            this.labelCmakeFiles.Location = new System.Drawing.Point(87, 44);
            this.labelCmakeFiles.Name = "labelCmakeFiles";
            this.labelCmakeFiles.Size = new System.Drawing.Size(398, 52);
            this.labelCmakeFiles.TabIndex = 8;
            this.labelCmakeFiles.Text = "0  \"C-Make\" files have been recognized.\r\nPlease check box in order to build them";
            // 
            // groupBoxFilesToBeChecked
            // 
            this.groupBoxFilesToBeChecked.Controls.Add(this.label2);
            this.groupBoxFilesToBeChecked.Controls.Add(this.checkBoxCfiles);
            this.groupBoxFilesToBeChecked.Controls.Add(this.checkBoxJavaFiles);
            this.groupBoxFilesToBeChecked.Controls.Add(this.checkBoxPythonFiles);
            this.groupBoxFilesToBeChecked.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBoxFilesToBeChecked.Location = new System.Drawing.Point(74, 134);
            this.groupBoxFilesToBeChecked.Name = "groupBoxFilesToBeChecked";
            this.groupBoxFilesToBeChecked.Size = new System.Drawing.Size(834, 190);
            this.groupBoxFilesToBeChecked.TabIndex = 9;
            this.groupBoxFilesToBeChecked.TabStop = false;
            this.groupBoxFilesToBeChecked.Text = "Files to be checked";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(550, 52);
            this.label2.TabIndex = 6;
            this.label2.Text = "The following files have been recognized by the system.\r\nPlease choose files to b" +
    "e checked.";
            // 
            // checkBoxCfiles
            // 
            this.checkBoxCfiles.AutoSize = true;
            this.checkBoxCfiles.Location = new System.Drawing.Point(92, 126);
            this.checkBoxCfiles.Name = "checkBoxCfiles";
            this.checkBoxCfiles.Size = new System.Drawing.Size(100, 30);
            this.checkBoxCfiles.TabIndex = 7;
            this.checkBoxCfiles.Text = "C-Files";
            this.checkBoxCfiles.UseVisualStyleBackColor = true;
            // 
            // checkBoxJavaFiles
            // 
            this.checkBoxJavaFiles.AutoSize = true;
            this.checkBoxJavaFiles.Location = new System.Drawing.Point(671, 126);
            this.checkBoxJavaFiles.Name = "checkBoxJavaFiles";
            this.checkBoxJavaFiles.Size = new System.Drawing.Size(129, 30);
            this.checkBoxJavaFiles.TabIndex = 7;
            this.checkBoxJavaFiles.Text = "Java Files";
            this.checkBoxJavaFiles.UseVisualStyleBackColor = true;
            // 
            // checkBoxPythonFiles
            // 
            this.checkBoxPythonFiles.AutoSize = true;
            this.checkBoxPythonFiles.Location = new System.Drawing.Point(342, 126);
            this.checkBoxPythonFiles.Name = "checkBoxPythonFiles";
            this.checkBoxPythonFiles.Size = new System.Drawing.Size(151, 30);
            this.checkBoxPythonFiles.TabIndex = 7;
            this.checkBoxPythonFiles.Text = "Python Files";
            this.checkBoxPythonFiles.UseVisualStyleBackColor = true;
            // 
            // label1SummaryFiles
            // 
            this.label1SummaryFiles.AutoSize = true;
            this.label1SummaryFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1SummaryFiles.Location = new System.Drawing.Point(384, 59);
            this.label1SummaryFiles.Name = "label1SummaryFiles";
            this.label1SummaryFiles.Size = new System.Drawing.Size(217, 29);
            this.label1SummaryFiles.TabIndex = 6;
            this.label1SummaryFiles.Text = "Recognized Files";
            // 
            // buttonBackSFW
            // 
            this.buttonBackSFW.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonBackSFW.Location = new System.Drawing.Point(12, 676);
            this.buttonBackSFW.Name = "buttonBackSFW";
            this.buttonBackSFW.Size = new System.Drawing.Size(226, 41);
            this.buttonBackSFW.TabIndex = 5;
            this.buttonBackSFW.Text = "Back";
            this.buttonBackSFW.UseVisualStyleBackColor = true;
            this.buttonBackSFW.Visible = false;
            this.buttonBackSFW.Click += new System.EventHandler(this.ButtonBackSFW_Click);
            // 
            // panelSelectMode
            // 
            this.panelSelectMode.Controls.Add(this.groupBox1);
            this.panelSelectMode.Controls.Add(this.groupBoxFilesSummary);
            this.panelSelectMode.Controls.Add(this.labelSelectMode);
            this.panelSelectMode.Location = new System.Drawing.Point(12, 12);
            this.panelSelectMode.Name = "panelSelectMode";
            this.panelSelectMode.Size = new System.Drawing.Size(984, 636);
            this.panelSelectMode.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonSelectedHest1);
            this.groupBox1.Controls.Add(this.buttonSelectedHEST2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.Location = new System.Drawing.Point(42, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(891, 295);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please select a checking method:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(566, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 51);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hest 2, will let you choose the kind of \r\noutput that is expected....\r\n\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(84, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 68);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hest 1 checks the files for execution \r\nand output only.\r\nIf any C-Files were sel" +
    "ected, the system \r\nwill try to build them and execute them.\r\n";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // buttonSelectedHest1
            // 
            this.buttonSelectedHest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSelectedHest1.Location = new System.Drawing.Point(87, 31);
            this.buttonSelectedHest1.Name = "buttonSelectedHest1";
            this.buttonSelectedHest1.Size = new System.Drawing.Size(243, 166);
            this.buttonSelectedHest1.TabIndex = 8;
            this.buttonSelectedHest1.Text = "HEST1 AND BUILD C-FILES";
            this.buttonSelectedHest1.UseVisualStyleBackColor = true;
            this.buttonSelectedHest1.Click += new System.EventHandler(this.ButtonSelectedHest1_Click);
            // 
            // buttonSelectedHEST2
            // 
            this.buttonSelectedHEST2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSelectedHEST2.Location = new System.Drawing.Point(563, 31);
            this.buttonSelectedHEST2.Name = "buttonSelectedHEST2";
            this.buttonSelectedHEST2.Size = new System.Drawing.Size(243, 166);
            this.buttonSelectedHEST2.TabIndex = 8;
            this.buttonSelectedHEST2.Text = "HEST2\r\n";
            this.buttonSelectedHEST2.UseVisualStyleBackColor = true;
            this.buttonSelectedHEST2.Click += new System.EventHandler(this.ButtonSelectedHEST2_Click);
            // 
            // groupBoxFilesSummary
            // 
            this.groupBoxFilesSummary.Controls.Add(this.labelCfilesMakeSummary);
            this.groupBoxFilesSummary.Controls.Add(this.labelJavaFilesSummary);
            this.groupBoxFilesSummary.Controls.Add(this.labelPythonFilesSummary);
            this.groupBoxFilesSummary.Controls.Add(this.labelCfilesSummary);
            this.groupBoxFilesSummary.Controls.Add(this.label1);
            this.groupBoxFilesSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBoxFilesSummary.Location = new System.Drawing.Point(42, 107);
            this.groupBoxFilesSummary.Name = "groupBoxFilesSummary";
            this.groupBoxFilesSummary.Size = new System.Drawing.Size(891, 175);
            this.groupBoxFilesSummary.TabIndex = 7;
            this.groupBoxFilesSummary.TabStop = false;
            this.groupBoxFilesSummary.Text = "File\'s summary:";
            // 
            // labelCfilesMakeSummary
            // 
            this.labelCfilesMakeSummary.AutoSize = true;
            this.labelCfilesMakeSummary.Location = new System.Drawing.Point(680, 116);
            this.labelCfilesMakeSummary.Name = "labelCfilesMakeSummary";
            this.labelCfilesMakeSummary.Size = new System.Drawing.Size(158, 26);
            this.labelCfilesMakeSummary.TabIndex = 1;
            this.labelCfilesMakeSummary.Text = "# C-Make Files";
            // 
            // labelJavaFilesSummary
            // 
            this.labelJavaFilesSummary.AutoSize = true;
            this.labelJavaFilesSummary.Location = new System.Drawing.Point(501, 118);
            this.labelJavaFilesSummary.Name = "labelJavaFilesSummary";
            this.labelJavaFilesSummary.Size = new System.Drawing.Size(76, 26);
            this.labelJavaFilesSummary.TabIndex = 1;
            this.labelJavaFilesSummary.Text = "# Java";
            // 
            // labelPythonFilesSummary
            // 
            this.labelPythonFilesSummary.AutoSize = true;
            this.labelPythonFilesSummary.Location = new System.Drawing.Point(285, 118);
            this.labelPythonFilesSummary.Name = "labelPythonFilesSummary";
            this.labelPythonFilesSummary.Size = new System.Drawing.Size(98, 26);
            this.labelPythonFilesSummary.TabIndex = 1;
            this.labelPythonFilesSummary.Text = "# Python";
            // 
            // labelCfilesSummary
            // 
            this.labelCfilesSummary.AutoSize = true;
            this.labelCfilesSummary.Location = new System.Drawing.Point(56, 118);
            this.labelCfilesSummary.Name = "labelCfilesSummary";
            this.labelCfilesSummary.Size = new System.Drawing.Size(99, 26);
            this.labelCfilesSummary.TabIndex = 1;
            this.labelCfilesSummary.Text = "# C-Files";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "The following number of files have been selected:\r\n";
            // 
            // labelSelectMode
            // 
            this.labelSelectMode.AutoSize = true;
            this.labelSelectMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelSelectMode.Location = new System.Drawing.Point(372, 47);
            this.labelSelectMode.Name = "labelSelectMode";
            this.labelSelectMode.Size = new System.Drawing.Size(263, 29);
            this.labelSelectMode.TabIndex = 6;
            this.labelSelectMode.Text = "CHEKING METHODS\r\n";
            // 
            // panelResultsWindow
            // 
            this.panelResultsWindow.Controls.Add(this.groupBox2SummaryReport);
            this.panelResultsWindow.Controls.Add(this.label5SummaryFilesHEST1HEST2);
            this.panelResultsWindow.Controls.Add(this.button4GenerateReport);
            this.panelResultsWindow.Controls.Add(this.buttonNewRevision);
            this.panelResultsWindow.Location = new System.Drawing.Point(12, 12);
            this.panelResultsWindow.Name = "panelResultsWindow";
            this.panelResultsWindow.Size = new System.Drawing.Size(984, 636);
            this.panelResultsWindow.TabIndex = 7;
            // 
            // groupBox2SummaryReport
            // 
            this.groupBox2SummaryReport.Controls.Add(this.label16);
            this.groupBox2SummaryReport.Controls.Add(this.labelErrorCbuildFiles);
            this.groupBox2SummaryReport.Controls.Add(this.label10NumCmakeFilesBuilt);
            this.groupBox2SummaryReport.Controls.Add(this.label15);
            this.groupBox2SummaryReport.Controls.Add(this.labelErrorsCfiles);
            this.groupBox2SummaryReport.Controls.Add(this.label9NumCFilesChecked);
            this.groupBox2SummaryReport.Controls.Add(this.label17);
            this.groupBox2SummaryReport.Controls.Add(this.labelErrorPython);
            this.groupBox2SummaryReport.Controls.Add(this.label10NumPythonFilesChecked);
            this.groupBox2SummaryReport.Controls.Add(this.label18);
            this.groupBox2SummaryReport.Controls.Add(this.labelErrorJavaFiles);
            this.groupBox2SummaryReport.Controls.Add(this.label9NumJavaFilesChecked);
            this.groupBox2SummaryReport.Controls.Add(this.label8);
            this.groupBox2SummaryReport.Controls.Add(this.label9);
            this.groupBox2SummaryReport.Controls.Add(this.label7);
            this.groupBox2SummaryReport.Controls.Add(this.label6);
            this.groupBox2SummaryReport.Controls.Add(this.label10);
            this.groupBox2SummaryReport.Controls.Add(this.label5);
            this.groupBox2SummaryReport.Controls.Add(this.labelFilesChecked);
            this.groupBox2SummaryReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox2SummaryReport.Location = new System.Drawing.Point(50, 149);
            this.groupBox2SummaryReport.Name = "groupBox2SummaryReport";
            this.groupBox2SummaryReport.Size = new System.Drawing.Size(869, 253);
            this.groupBox2SummaryReport.TabIndex = 7;
            this.groupBox2SummaryReport.TabStop = false;
            this.groupBox2SummaryReport.Text = "SUMMARY RESULTS";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(716, 121);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 24);
            this.label16.TabIndex = 0;
            this.label16.Text = "#";
            // 
            // labelErrorCbuildFiles
            // 
            this.labelErrorCbuildFiles.AutoSize = true;
            this.labelErrorCbuildFiles.Location = new System.Drawing.Point(423, 121);
            this.labelErrorCbuildFiles.Name = "labelErrorCbuildFiles";
            this.labelErrorCbuildFiles.Size = new System.Drawing.Size(20, 24);
            this.labelErrorCbuildFiles.TabIndex = 0;
            this.labelErrorCbuildFiles.Text = "#";
            // 
            // label10NumCmakeFilesBuilt
            // 
            this.label10NumCmakeFilesBuilt.AutoSize = true;
            this.label10NumCmakeFilesBuilt.Location = new System.Drawing.Point(252, 121);
            this.label10NumCmakeFilesBuilt.Name = "label10NumCmakeFilesBuilt";
            this.label10NumCmakeFilesBuilt.Size = new System.Drawing.Size(20, 24);
            this.label10NumCmakeFilesBuilt.TabIndex = 0;
            this.label10NumCmakeFilesBuilt.Text = "#";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(716, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 24);
            this.label15.TabIndex = 0;
            this.label15.Text = "#";
            // 
            // labelErrorsCfiles
            // 
            this.labelErrorsCfiles.AutoSize = true;
            this.labelErrorsCfiles.Location = new System.Drawing.Point(423, 81);
            this.labelErrorsCfiles.Name = "labelErrorsCfiles";
            this.labelErrorsCfiles.Size = new System.Drawing.Size(20, 24);
            this.labelErrorsCfiles.TabIndex = 0;
            this.labelErrorsCfiles.Text = "#";
            // 
            // label9NumCFilesChecked
            // 
            this.label9NumCFilesChecked.AutoSize = true;
            this.label9NumCFilesChecked.Location = new System.Drawing.Point(252, 81);
            this.label9NumCFilesChecked.Name = "label9NumCFilesChecked";
            this.label9NumCFilesChecked.Size = new System.Drawing.Size(20, 24);
            this.label9NumCFilesChecked.TabIndex = 0;
            this.label9NumCFilesChecked.Text = "#";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(716, 162);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 24);
            this.label17.TabIndex = 0;
            this.label17.Text = "#";
            // 
            // labelErrorPython
            // 
            this.labelErrorPython.AutoSize = true;
            this.labelErrorPython.Location = new System.Drawing.Point(423, 162);
            this.labelErrorPython.Name = "labelErrorPython";
            this.labelErrorPython.Size = new System.Drawing.Size(20, 24);
            this.labelErrorPython.TabIndex = 0;
            this.labelErrorPython.Text = "#";
            // 
            // label10NumPythonFilesChecked
            // 
            this.label10NumPythonFilesChecked.AutoSize = true;
            this.label10NumPythonFilesChecked.Location = new System.Drawing.Point(252, 162);
            this.label10NumPythonFilesChecked.Name = "label10NumPythonFilesChecked";
            this.label10NumPythonFilesChecked.Size = new System.Drawing.Size(20, 24);
            this.label10NumPythonFilesChecked.TabIndex = 0;
            this.label10NumPythonFilesChecked.Text = "#";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(716, 195);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 24);
            this.label18.TabIndex = 0;
            this.label18.Text = "#";
            // 
            // labelErrorJavaFiles
            // 
            this.labelErrorJavaFiles.AutoSize = true;
            this.labelErrorJavaFiles.Location = new System.Drawing.Point(423, 195);
            this.labelErrorJavaFiles.Name = "labelErrorJavaFiles";
            this.labelErrorJavaFiles.Size = new System.Drawing.Size(20, 24);
            this.labelErrorJavaFiles.TabIndex = 0;
            this.labelErrorJavaFiles.Text = "#";
            // 
            // label9NumJavaFilesChecked
            // 
            this.label9NumJavaFilesChecked.AutoSize = true;
            this.label9NumJavaFilesChecked.Location = new System.Drawing.Point(252, 195);
            this.label9NumJavaFilesChecked.Name = "label9NumJavaFilesChecked";
            this.label9NumJavaFilesChecked.Size = new System.Drawing.Size(20, 24);
            this.label9NumJavaFilesChecked.TabIndex = 0;
            this.label9NumJavaFilesChecked.Text = "#";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "JAVA FILES:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(86, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "C-FILES BUILT:";
            this.label9.Click += new System.EventHandler(this.Label7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "PYTHON FILES:";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "C-FILES:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(623, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "SUSPECTED FROUD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "ERRORS FOUND:";
            // 
            // labelFilesChecked
            // 
            this.labelFilesChecked.AutoSize = true;
            this.labelFilesChecked.Location = new System.Drawing.Point(67, 40);
            this.labelFilesChecked.Name = "labelFilesChecked";
            this.labelFilesChecked.Size = new System.Drawing.Size(162, 24);
            this.labelFilesChecked.TabIndex = 0;
            this.labelFilesChecked.Text = "FILES CHECKED:";
            // 
            // label5SummaryFilesHEST1HEST2
            // 
            this.label5SummaryFilesHEST1HEST2.AutoSize = true;
            this.label5SummaryFilesHEST1HEST2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5SummaryFilesHEST1HEST2.Location = new System.Drawing.Point(248, 72);
            this.label5SummaryFilesHEST1HEST2.Name = "label5SummaryFilesHEST1HEST2";
            this.label5SummaryFilesHEST1HEST2.Size = new System.Drawing.Size(468, 29);
            this.label5SummaryFilesHEST1HEST2.TabIndex = 6;
            this.label5SummaryFilesHEST1HEST2.Text = "RESULTS FOR THE HEST-1 METHOD";
            // 
            // button4GenerateReport
            // 
            this.button4GenerateReport.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4GenerateReport.Location = new System.Drawing.Point(361, 420);
            this.button4GenerateReport.Name = "button4GenerateReport";
            this.button4GenerateReport.Size = new System.Drawing.Size(243, 110);
            this.button4GenerateReport.TabIndex = 5;
            this.button4GenerateReport.Text = "GENERATE DETAIL  REPORT";
            this.button4GenerateReport.UseVisualStyleBackColor = true;
            // 
            // buttonNewRevision
            // 
            this.buttonNewRevision.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNewRevision.Location = new System.Drawing.Point(361, 556);
            this.buttonNewRevision.Name = "buttonNewRevision";
            this.buttonNewRevision.Size = new System.Drawing.Size(243, 38);
            this.buttonNewRevision.TabIndex = 5;
            this.buttonNewRevision.Text = "NEW REVISION";
            this.buttonNewRevision.UseVisualStyleBackColor = true;
            // 
            // buttonExitProgramEND
            // 
            this.buttonExitProgramEND.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonExitProgramEND.Location = new System.Drawing.Point(770, 676);
            this.buttonExitProgramEND.Name = "buttonExitProgramEND";
            this.buttonExitProgramEND.Size = new System.Drawing.Size(226, 41);
            this.buttonExitProgramEND.TabIndex = 5;
            this.buttonExitProgramEND.Text = "EXIT";
            this.buttonExitProgramEND.UseVisualStyleBackColor = true;
            this.buttonExitProgramEND.Visible = false;
            this.buttonExitProgramEND.Click += new System.EventHandler(this.ButtonExitProgramEND_Click);
            // 
            // buttonExitPro
            // 
            this.buttonExitPro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonExitPro.Location = new System.Drawing.Point(12, 676);
            this.buttonExitPro.Name = "buttonExitPro";
            this.buttonExitPro.Size = new System.Drawing.Size(226, 41);
            this.buttonExitPro.TabIndex = 5;
            this.buttonExitPro.Text = "EXIT";
            this.buttonExitPro.UseVisualStyleBackColor = true;
            this.buttonExitPro.Click += new System.EventHandler(this.ButtonExitPro_Click);
            // 
            // PanelSignIn
            // 
            this.PanelSignIn.Controls.Add(this.button1EnterProg);
            this.PanelSignIn.Location = new System.Drawing.Point(12, 12);
            this.PanelSignIn.Name = "PanelSignIn";
            this.PanelSignIn.Size = new System.Drawing.Size(984, 636);
            this.PanelSignIn.TabIndex = 8;
            // 
            // button1EnterProg
            // 
            this.button1EnterProg.Location = new System.Drawing.Point(389, 444);
            this.button1EnterProg.Name = "button1EnterProg";
            this.button1EnterProg.Size = new System.Drawing.Size(159, 86);
            this.button1EnterProg.TabIndex = 0;
            this.button1EnterProg.Text = "Enter";
            this.button1EnterProg.UseVisualStyleBackColor = true;
            this.button1EnterProg.Click += new System.EventHandler(this.Button1EnterProg_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panelSelectMode);
            this.Controls.Add(this.panelResultsWindow);
            this.Controls.Add(this.panelFilesOverView);
            this.Controls.Add(this.panelDragFiles);
            this.Controls.Add(this.PanelSignIn);
            this.Controls.Add(this.buttonExitPro);
            this.Controls.Add(this.buttonBackSFW);
            this.Controls.Add(this.buttonNextPanel);
            this.Controls.Add(this.buttonExitProgramEND);
            this.Name = "MainWindow";
            this.Text = "KINNERET COLLEGE - HOME WORK CHECKER by EYA TEAM";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panelDragFiles.ResumeLayout(false);
            this.panelDragFiles.PerformLayout();
            this.panelFilesOverView.ResumeLayout(false);
            this.panelFilesOverView.PerformLayout();
            this.groupBoxFilesToBuild.ResumeLayout(false);
            this.groupBoxFilesToBuild.PerformLayout();
            this.groupBoxFilesToBeChecked.ResumeLayout(false);
            this.groupBoxFilesToBeChecked.PerformLayout();
            this.panelSelectMode.ResumeLayout(false);
            this.panelSelectMode.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxFilesSummary.ResumeLayout(false);
            this.groupBoxFilesSummary.PerformLayout();
            this.panelResultsWindow.ResumeLayout(false);
            this.panelResultsWindow.PerformLayout();
            this.groupBox2SummaryReport.ResumeLayout(false);
            this.groupBox2SummaryReport.PerformLayout();
            this.PanelSignIn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDragFiles;
        private System.Windows.Forms.Label label1DragFiles;
        private System.Windows.Forms.Button buttonNextPanel;
        private System.Windows.Forms.ListBox listBox1DragFiles;
        private System.Windows.Forms.Panel panelFilesOverView;
        private System.Windows.Forms.GroupBox groupBoxFilesToBuild;
        private System.Windows.Forms.CheckBox checkBoxCMakeFiles;
        private System.Windows.Forms.Label labelCmakeFiles;
        private System.Windows.Forms.GroupBox groupBoxFilesToBeChecked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxCfiles;
        private System.Windows.Forms.CheckBox checkBoxJavaFiles;
        private System.Windows.Forms.CheckBox checkBoxPythonFiles;
        private System.Windows.Forms.Label label1SummaryFiles;
        private System.Windows.Forms.Button buttonBackSFW;
        private System.Windows.Forms.Panel panelSelectMode;
        private System.Windows.Forms.Label labelSelectMode;
        private System.Windows.Forms.GroupBox groupBoxFilesSummary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSelectedHest1;
        private System.Windows.Forms.Button buttonSelectedHEST2;
        private System.Windows.Forms.Label labelCfilesMakeSummary;
        private System.Windows.Forms.Label labelJavaFilesSummary;
        private System.Windows.Forms.Label labelPythonFilesSummary;
        private System.Windows.Forms.Label labelCfilesSummary;
        private System.Windows.Forms.Panel panelResultsWindow;
        private System.Windows.Forms.GroupBox groupBox2SummaryReport;
        private System.Windows.Forms.Label labelFilesChecked;
        private System.Windows.Forms.Label label5SummaryFilesHEST1HEST2;
        private System.Windows.Forms.Button buttonExitProgramEND;
        private System.Windows.Forms.Button button4GenerateReport;
        private System.Windows.Forms.Button buttonNewRevision;
        private System.Windows.Forms.Label label9NumCFilesChecked;
        private System.Windows.Forms.Label label10NumPythonFilesChecked;
        private System.Windows.Forms.Label label9NumJavaFilesChecked;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10NumCmakeFilesBuilt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelErrorCbuildFiles;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelErrorsCfiles;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelErrorPython;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelErrorJavaFiles;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonExitPro;
        private System.Windows.Forms.Panel PanelSignIn;
        private System.Windows.Forms.Button button1EnterProg;
    }
}

