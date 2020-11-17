using System.Diagnostics.CodeAnalysis;

namespace HomeWorkCheckApp
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
        [ExcludeFromCodeCoverage]
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
        /// 
        [ExcludeFromCodeCoverage]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panelDragFiles = new System.Windows.Forms.Panel();
            this.button1ClearFilesDragger = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.labelNumberFilesDragged = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label1DragFiles = new System.Windows.Forms.Label();
            this.listBox1DragFiles = new System.Windows.Forms.ListBox();
            this.buttonNextPanel = new System.Windows.Forms.Button();
            this.panelFilesOverView = new System.Windows.Forms.Panel();
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
            this.labelSelectMode = new System.Windows.Forms.Label();
            this.panelResultsWindow = new System.Windows.Forms.Panel();
            this.groupBox2SummaryReport = new System.Windows.Forms.GroupBox();
            this.labelErrorsCfiles = new System.Windows.Forms.Label();
            this.label9NumCFilesChecked = new System.Windows.Forms.Label();
            this.labelErrorPython = new System.Windows.Forms.Label();
            this.label10NumPythonFilesChecked = new System.Windows.Forms.Label();
            this.labelErrorJavaFiles = new System.Windows.Forms.Label();
            this.label9NumJavaFilesChecked = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelFilesChecked = new System.Windows.Forms.Label();
            this.label5SummaryFilesHEST1HEST2 = new System.Windows.Forms.Label();
            this.button4GenerateReport = new System.Windows.Forms.Button();
            this.buttonExitProgramEND = new System.Windows.Forms.Button();
            this.buttonExitPro = new System.Windows.Forms.Button();
            this.PanelSignIn = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.button1EnterProg = new System.Windows.Forms.Button();
            this.Hest2Panel = new System.Windows.Forms.Panel();
            this.button1Hest2EvalueateFiles = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1ClearListBoxHest2Output = new System.Windows.Forms.Button();
            this.button1ClearListBoxHest2In = new System.Windows.Forms.Button();
            this.listBox2Hest2Output = new System.Windows.Forms.ListBox();
            this.listBox1Hest2InputParam = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label15WorkingOn = new System.Windows.Forms.Label();
            this.panelDragFiles.SuspendLayout();
            this.panelFilesOverView.SuspendLayout();
            this.groupBoxFilesToBeChecked.SuspendLayout();
            this.panelSelectMode.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelResultsWindow.SuspendLayout();
            this.groupBox2SummaryReport.SuspendLayout();
            this.PanelSignIn.SuspendLayout();
            this.Hest2Panel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDragFiles
            // 
            this.panelDragFiles.Controls.Add(this.button1ClearFilesDragger);
            this.panelDragFiles.Controls.Add(this.label21);
            this.panelDragFiles.Controls.Add(this.labelNumberFilesDragged);
            this.panelDragFiles.Controls.Add(this.label19);
            this.panelDragFiles.Controls.Add(this.label1DragFiles);
            this.panelDragFiles.Controls.Add(this.listBox1DragFiles);
            this.panelDragFiles.Location = new System.Drawing.Point(12, 12);
            this.panelDragFiles.Name = "panelDragFiles";
            this.panelDragFiles.Size = new System.Drawing.Size(984, 636);
            this.panelDragFiles.TabIndex = 4;
            // 
            // button1ClearFilesDragger
            // 
            this.button1ClearFilesDragger.Location = new System.Drawing.Point(444, 575);
            this.button1ClearFilesDragger.Name = "button1ClearFilesDragger";
            this.button1ClearFilesDragger.Size = new System.Drawing.Size(75, 23);
            this.button1ClearFilesDragger.TabIndex = 10;
            this.button1ClearFilesDragger.Text = "Clear";
            this.button1ClearFilesDragger.UseVisualStyleBackColor = true;
            this.button1ClearFilesDragger.Click += new System.EventHandler(this.button1ClearFilesDragger_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(284, 127);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(367, 13);
            this.label21.TabIndex = 9;
            this.label21.Text = "Only ZIP and file are allowed. Do not drag ZIP that contains more ZIP within.\r\n";
            // 
            // labelNumberFilesDragged
            // 
            this.labelNumberFilesDragged.AutoSize = true;
            this.labelNumberFilesDragged.Location = new System.Drawing.Point(211, 580);
            this.labelNumberFilesDragged.Name = "labelNumberFilesDragged";
            this.labelNumberFilesDragged.Size = new System.Drawing.Size(10, 13);
            this.labelNumberFilesDragged.TabIndex = 8;
            this.labelNumberFilesDragged.Text = "-";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(84, 580);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(122, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "Number of files dragged:";
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
            this.listBox1DragFiles.BackColor = System.Drawing.SystemColors.ScrollBar;
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
            this.panelFilesOverView.Controls.Add(this.groupBoxFilesToBeChecked);
            this.panelFilesOverView.Controls.Add(this.label1SummaryFiles);
            this.panelFilesOverView.Location = new System.Drawing.Point(12, 12);
            this.panelFilesOverView.Name = "panelFilesOverView";
            this.panelFilesOverView.Size = new System.Drawing.Size(984, 636);
            this.panelFilesOverView.TabIndex = 5;
            // 
            // groupBoxFilesToBeChecked
            // 
            this.groupBoxFilesToBeChecked.Controls.Add(this.label2);
            this.groupBoxFilesToBeChecked.Controls.Add(this.checkBoxCfiles);
            this.groupBoxFilesToBeChecked.Controls.Add(this.checkBoxJavaFiles);
            this.groupBoxFilesToBeChecked.Controls.Add(this.checkBoxPythonFiles);
            this.groupBoxFilesToBeChecked.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBoxFilesToBeChecked.Location = new System.Drawing.Point(74, 257);
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
    "e checked by HES1 or HEST2.";
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
            this.groupBox1.Location = new System.Drawing.Point(48, 165);
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
            // 
            // buttonSelectedHest1
            // 
            this.buttonSelectedHest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSelectedHest1.Location = new System.Drawing.Point(87, 31);
            this.buttonSelectedHest1.Name = "buttonSelectedHest1";
            this.buttonSelectedHest1.Size = new System.Drawing.Size(243, 166);
            this.buttonSelectedHest1.TabIndex = 8;
            this.buttonSelectedHest1.Text = "HEST1 (EXECUTE AND BUILD C-FILES)";
            this.buttonSelectedHest1.UseVisualStyleBackColor = true;
            this.buttonSelectedHest1.Click += new System.EventHandler(this.ButtonSelectedHest1_ClickAsync);
            // 
            // buttonSelectedHEST2
            // 
            this.buttonSelectedHEST2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSelectedHEST2.Location = new System.Drawing.Point(563, 31);
            this.buttonSelectedHEST2.Name = "buttonSelectedHEST2";
            this.buttonSelectedHEST2.Size = new System.Drawing.Size(243, 166);
            this.buttonSelectedHEST2.TabIndex = 8;
            this.buttonSelectedHEST2.Text = "HEST2\r\n (PASS PARAMETERS AND CHECK OUTPUT)";
            this.buttonSelectedHEST2.UseVisualStyleBackColor = true;
            this.buttonSelectedHEST2.Click += new System.EventHandler(this.ButtonSelectedHEST2_Click);
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
            this.panelResultsWindow.Location = new System.Drawing.Point(12, 12);
            this.panelResultsWindow.Name = "panelResultsWindow";
            this.panelResultsWindow.Size = new System.Drawing.Size(984, 636);
            this.panelResultsWindow.TabIndex = 7;
            // 
            // groupBox2SummaryReport
            // 
            this.groupBox2SummaryReport.Controls.Add(this.labelErrorsCfiles);
            this.groupBox2SummaryReport.Controls.Add(this.label9NumCFilesChecked);
            this.groupBox2SummaryReport.Controls.Add(this.labelErrorPython);
            this.groupBox2SummaryReport.Controls.Add(this.label10NumPythonFilesChecked);
            this.groupBox2SummaryReport.Controls.Add(this.labelErrorJavaFiles);
            this.groupBox2SummaryReport.Controls.Add(this.label9NumJavaFilesChecked);
            this.groupBox2SummaryReport.Controls.Add(this.label8);
            this.groupBox2SummaryReport.Controls.Add(this.label7);
            this.groupBox2SummaryReport.Controls.Add(this.label6);
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
            // labelErrorsCfiles
            // 
            this.labelErrorsCfiles.AutoSize = true;
            this.labelErrorsCfiles.Location = new System.Drawing.Point(704, 81);
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
            // labelErrorPython
            // 
            this.labelErrorPython.AutoSize = true;
            this.labelErrorPython.Location = new System.Drawing.Point(704, 130);
            this.labelErrorPython.Name = "labelErrorPython";
            this.labelErrorPython.Size = new System.Drawing.Size(20, 24);
            this.labelErrorPython.TabIndex = 0;
            this.labelErrorPython.Text = "#";
            // 
            // label10NumPythonFilesChecked
            // 
            this.label10NumPythonFilesChecked.AutoSize = true;
            this.label10NumPythonFilesChecked.Location = new System.Drawing.Point(252, 130);
            this.label10NumPythonFilesChecked.Name = "label10NumPythonFilesChecked";
            this.label10NumPythonFilesChecked.Size = new System.Drawing.Size(20, 24);
            this.label10NumPythonFilesChecked.TabIndex = 0;
            this.label10NumPythonFilesChecked.Text = "#";
            // 
            // labelErrorJavaFiles
            // 
            this.labelErrorJavaFiles.AutoSize = true;
            this.labelErrorJavaFiles.Location = new System.Drawing.Point(704, 189);
            this.labelErrorJavaFiles.Name = "labelErrorJavaFiles";
            this.labelErrorJavaFiles.Size = new System.Drawing.Size(20, 24);
            this.labelErrorJavaFiles.TabIndex = 0;
            this.labelErrorJavaFiles.Text = "#";
            // 
            // label9NumJavaFilesChecked
            // 
            this.label9NumJavaFilesChecked.AutoSize = true;
            this.label9NumJavaFilesChecked.Location = new System.Drawing.Point(252, 189);
            this.label9NumJavaFilesChecked.Name = "label9NumJavaFilesChecked";
            this.label9NumJavaFilesChecked.Size = new System.Drawing.Size(20, 24);
            this.label9NumJavaFilesChecked.TabIndex = 0;
            this.label9NumJavaFilesChecked.Text = "#";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "JAVA FILES:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "PYTHON FILES:";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(626, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "ERRORS FOUND HEST1:";
            // 
            // labelFilesChecked
            // 
            this.labelFilesChecked.AutoSize = true;
            this.labelFilesChecked.Location = new System.Drawing.Point(74, 38);
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
            this.button4GenerateReport.Location = new System.Drawing.Point(358, 466);
            this.button4GenerateReport.Name = "button4GenerateReport";
            this.button4GenerateReport.Size = new System.Drawing.Size(243, 110);
            this.button4GenerateReport.TabIndex = 5;
            this.button4GenerateReport.Text = "GENERATE DETAIL  REPORT";
            this.button4GenerateReport.UseVisualStyleBackColor = true;
            this.button4GenerateReport.Click += new System.EventHandler(this.Button4GenerateReport_Click);
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
            this.PanelSignIn.Controls.Add(this.label20);
            this.PanelSignIn.Controls.Add(this.button1EnterProg);
            this.PanelSignIn.Location = new System.Drawing.Point(12, 12);
            this.PanelSignIn.Name = "PanelSignIn";
            this.PanelSignIn.Size = new System.Drawing.Size(984, 636);
            this.PanelSignIn.TabIndex = 8;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label20.Location = new System.Drawing.Point(203, 177);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(545, 52);
            this.label20.TabIndex = 1;
            this.label20.Text = "Welcome to HomeWorkApp Checker.\r\nYou have been granted acces to out amazing app.\r" +
    "\n";
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
            // Hest2Panel
            // 
            this.Hest2Panel.Controls.Add(this.button1Hest2EvalueateFiles);
            this.Hest2Panel.Controls.Add(this.groupBox3);
            this.Hest2Panel.Controls.Add(this.label12);
            this.Hest2Panel.Controls.Add(this.label11);
            this.Hest2Panel.Location = new System.Drawing.Point(12, 12);
            this.Hest2Panel.Name = "Hest2Panel";
            this.Hest2Panel.Size = new System.Drawing.Size(984, 636);
            this.Hest2Panel.TabIndex = 6;
            // 
            // button1Hest2EvalueateFiles
            // 
            this.button1Hest2EvalueateFiles.Location = new System.Drawing.Point(389, 580);
            this.button1Hest2EvalueateFiles.Name = "button1Hest2EvalueateFiles";
            this.button1Hest2EvalueateFiles.Size = new System.Drawing.Size(232, 42);
            this.button1Hest2EvalueateFiles.TabIndex = 5;
            this.button1Hest2EvalueateFiles.Text = "Evaluate files";
            this.button1Hest2EvalueateFiles.UseVisualStyleBackColor = true;
            this.button1Hest2EvalueateFiles.Click += new System.EventHandler(this.Button1Hest2EvalueateFiles_ClickAsync);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.button1ClearListBoxHest2Output);
            this.groupBox3.Controls.Add(this.button1ClearListBoxHest2In);
            this.groupBox3.Controls.Add(this.listBox2Hest2Output);
            this.groupBox3.Controls.Add(this.listBox1Hest2InputParam);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(99, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(846, 414);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "I/O Configurations";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(285, 401);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(267, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "NOTE: file in1.txt will be test against out1.txt and so on.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(555, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Only TXT file of the form: out1.txt out2.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Only TXT file of the form: in1.txt in2.txt";
            // 
            // button1ClearListBoxHest2Output
            // 
            this.button1ClearListBoxHest2Output.Location = new System.Drawing.Point(600, 360);
            this.button1ClearListBoxHest2Output.Name = "button1ClearListBoxHest2Output";
            this.button1ClearListBoxHest2Output.Size = new System.Drawing.Size(75, 23);
            this.button1ClearListBoxHest2Output.TabIndex = 8;
            this.button1ClearListBoxHest2Output.Text = "Clear";
            this.button1ClearListBoxHest2Output.UseVisualStyleBackColor = true;
            this.button1ClearListBoxHest2Output.Click += new System.EventHandler(this.button1ClearListBoxHest2Output_Click);
            // 
            // button1ClearListBoxHest2In
            // 
            this.button1ClearListBoxHest2In.Location = new System.Drawing.Point(188, 360);
            this.button1ClearListBoxHest2In.Name = "button1ClearListBoxHest2In";
            this.button1ClearListBoxHest2In.Size = new System.Drawing.Size(75, 23);
            this.button1ClearListBoxHest2In.TabIndex = 8;
            this.button1ClearListBoxHest2In.Text = "Clear";
            this.button1ClearListBoxHest2In.UseVisualStyleBackColor = true;
            this.button1ClearListBoxHest2In.Click += new System.EventHandler(this.button1ClearListBoxHest2In_Click);
            // 
            // listBox2Hest2Output
            // 
            this.listBox2Hest2Output.AllowDrop = true;
            this.listBox2Hest2Output.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox2Hest2Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2Hest2Output.FormattingEnabled = true;
            this.listBox2Hest2Output.Location = new System.Drawing.Point(455, 84);
            this.listBox2Hest2Output.Name = "listBox2Hest2Output";
            this.listBox2Hest2Output.Size = new System.Drawing.Size(365, 260);
            this.listBox2Hest2Output.TabIndex = 7;
            this.listBox2Hest2Output.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox2Hest2Output_DragEnter);
            // 
            // listBox1Hest2InputParam
            // 
            this.listBox1Hest2InputParam.AllowDrop = true;
            this.listBox1Hest2InputParam.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox1Hest2InputParam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1Hest2InputParam.FormattingEnabled = true;
            this.listBox1Hest2InputParam.Location = new System.Drawing.Point(29, 84);
            this.listBox1Hest2InputParam.Name = "listBox1Hest2InputParam";
            this.listBox1Hest2InputParam.Size = new System.Drawing.Size(365, 260);
            this.listBox1Hest2InputParam.TabIndex = 7;
            this.listBox1Hest2InputParam.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1Hest2InputParam_DragEnter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label14.Location = new System.Drawing.Point(554, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(174, 25);
            this.label14.TabIndex = 6;
            this.label14.Text = "OUTPUT FILES";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.Location = new System.Drawing.Point(144, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 25);
            this.label13.TabIndex = 5;
            this.label13.Text = "INPUT FILES";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.Location = new System.Drawing.Point(70, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(267, 24);
            this.label12.TabIndex = 1;
            this.label12.Text = "Testing user defined output";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.Location = new System.Drawing.Point(68, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 34);
            this.label11.TabIndex = 0;
            this.label11.Text = "HEST 2";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(401, 654);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(234, 27);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Visible = false;
            // 
            // label15WorkingOn
            // 
            this.label15WorkingOn.AutoSize = true;
            this.label15WorkingOn.Location = new System.Drawing.Point(437, 690);
            this.label15WorkingOn.Name = "label15WorkingOn";
            this.label15WorkingOn.Size = new System.Drawing.Size(164, 13);
            this.label15WorkingOn.TabIndex = 9;
            this.label15WorkingOn.Text = "WORKING ON IT, HOLD TIGHT";
            this.label15WorkingOn.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label15WorkingOn);
            this.Controls.Add(this.Hest2Panel);
            this.Controls.Add(this.panelSelectMode);
            this.Controls.Add(this.panelDragFiles);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panelResultsWindow);
            this.Controls.Add(this.panelFilesOverView);
            this.Controls.Add(this.PanelSignIn);
            this.Controls.Add(this.buttonExitPro);
            this.Controls.Add(this.buttonBackSFW);
            this.Controls.Add(this.buttonNextPanel);
            this.Controls.Add(this.buttonExitProgramEND);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "KINNERET COLLEGE - HOME WORK CHECKER by EYA TEAM";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panelDragFiles.ResumeLayout(false);
            this.panelDragFiles.PerformLayout();
            this.panelFilesOverView.ResumeLayout(false);
            this.panelFilesOverView.PerformLayout();
            this.groupBoxFilesToBeChecked.ResumeLayout(false);
            this.groupBoxFilesToBeChecked.PerformLayout();
            this.panelSelectMode.ResumeLayout(false);
            this.panelSelectMode.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelResultsWindow.ResumeLayout(false);
            this.panelResultsWindow.PerformLayout();
            this.groupBox2SummaryReport.ResumeLayout(false);
            this.groupBox2SummaryReport.PerformLayout();
            this.PanelSignIn.ResumeLayout(false);
            this.PanelSignIn.PerformLayout();
            this.Hest2Panel.ResumeLayout(false);
            this.Hest2Panel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDragFiles;
        private System.Windows.Forms.Label label1DragFiles;
        private System.Windows.Forms.Button buttonNextPanel;
        private System.Windows.Forms.ListBox listBox1DragFiles;
        private System.Windows.Forms.Panel panelFilesOverView;
        private System.Windows.Forms.GroupBox groupBoxFilesToBeChecked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxCfiles;
        private System.Windows.Forms.CheckBox checkBoxJavaFiles;
        private System.Windows.Forms.CheckBox checkBoxPythonFiles;
        private System.Windows.Forms.Label label1SummaryFiles;
        private System.Windows.Forms.Button buttonBackSFW;
        private System.Windows.Forms.Panel panelSelectMode;
        private System.Windows.Forms.Label labelSelectMode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSelectedHest1;
        private System.Windows.Forms.Button buttonSelectedHEST2;
        private System.Windows.Forms.Panel panelResultsWindow;
        private System.Windows.Forms.GroupBox groupBox2SummaryReport;
        private System.Windows.Forms.Label labelFilesChecked;
        private System.Windows.Forms.Label label5SummaryFilesHEST1HEST2;
        private System.Windows.Forms.Button buttonExitProgramEND;
        private System.Windows.Forms.Button button4GenerateReport;
        private System.Windows.Forms.Label label9NumCFilesChecked;
        private System.Windows.Forms.Label label10NumPythonFilesChecked;
        private System.Windows.Forms.Label label9NumJavaFilesChecked;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelErrorsCfiles;
        private System.Windows.Forms.Label labelErrorPython;
        private System.Windows.Forms.Label labelErrorJavaFiles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonExitPro;
        private System.Windows.Forms.Panel PanelSignIn;
        private System.Windows.Forms.Button button1EnterProg;
        private System.Windows.Forms.Panel Hest2Panel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1Hest2EvalueateFiles;
        private System.Windows.Forms.Label labelNumberFilesDragged;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ListBox listBox2Hest2Output;
        private System.Windows.Forms.ListBox listBox1Hest2InputParam;
        private System.Windows.Forms.Button button1ClearListBoxHest2Output;
        private System.Windows.Forms.Button button1ClearListBoxHest2In;
        private System.Windows.Forms.Button button1ClearFilesDragger;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label15WorkingOn;
    }
}

