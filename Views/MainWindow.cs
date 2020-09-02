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
using System.Diagnostics.CodeAnalysis;

namespace HomeWorkCheckApp
{
    /// <summary>Main Window Class <c>Point</c> All the events logic here and access to models.
    /// </summary>
    ///
    public partial class MainWindow : Form
    {

        List<Panel> listPanel = new List<Panel>();
        List<FileResultHest1> RevisionResultCfiles = new List<FileResultHest1>();
        List<FileResultHest1> RevisionResultJavaFiles = new List<FileResultHest1>();
        List<FileResultHest1> RevisionResultPythonFiles = new List<FileResultHest1>();

        List<FileResultHest2> RevisionResultCfilesHest2 = new List<FileResultHest2>();
        List<FileResultHest2> RevisionResultJavaFilesHest2 = new List<FileResultHest2>();
        List<FileResultHest2> RevisionResultPythonFilesHest2 = new List<FileResultHest2>();
        OrderedFiles MyOF = new OrderedFiles();
        bool isHest1;
        //int IndexFile = 0;
        int PanelIndex;
        [ExcludeFromCodeCoverage]
        public MainWindow()
        {
            InitializeComponent();
        }
        [ExcludeFromCodeCoverage]
        private void ListBox1DragFiles_DragEnter(object sender, DragEventArgs e)
        {
            string[] filesDrop = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            FilesTool.filesToCheck = new string[filesDrop.Length];
            FilesTool.filesToCheck = filesDrop;
            foreach (string item in filesDrop)
            {
                var name = Path.GetFileName(item.ToString());
                listBox1DragFiles.Items.Add(name);
            }
        }
        [ExcludeFromCodeCoverage]
        private void MainWindow_Load(object sender, EventArgs e)
        {
            listPanel.Add(PanelSignIn);
            listPanel.Add(panelDragFiles);
            listPanel.Add(panelFilesOverView);
            listPanel.Add(panelSelectMode);
            // listPanel.Add(Hest2Panel);
            listPanel.Add(panelResultsWindow);
            listPanel[PanelIndex].BringToFront();

        }//Add panels to List Order.
        [ExcludeFromCodeCoverage]
        private void ButtonNextPanel_Click(object sender, EventArgs e)
        {
            NextPanelBehav();
        }//Next event button.
        [ExcludeFromCodeCoverage]
        private void ButtonExitPro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        [ExcludeFromCodeCoverage]
        private void ButtonBackSFW_Click(object sender, EventArgs e)
        {
            PrevPanel();
            buttonNextPanel.Visible = true;
        }
        /// <summary>method <c>NextPanelBehav</c> forwards or backwards the panel order toggling visibility.</summary>
        [ExcludeFromCodeCoverage]
        public void NextPanelBehav()
        {
            switch (PanelIndex)
            {
                //Login Panel
                case 0:
                    NextPanel();
                    buttonExitProgramEND.Visible = false;
                    buttonNextPanel.Visible = true;

                    break;
                //Drag Files panel
                case 1:

                    if (listBox1DragFiles.Items.Count == 0)
                    {
                        MessageBox.Show("Please Drag files before continuing.","Alert",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                    }
                    else
                    {

                        NextPanel();

                        buttonExitPro.Visible = false;
                        buttonBackSFW.Visible = true;
                        MyOF = ClasssifiesAndLoadsFiles();
                        checkBoxCfiles.Text = $" {Convert.ToString(MyOF.cFiles.Count)} C-Files";
                        checkBoxPythonFiles.Text = $" {Convert.ToString(MyOF.pythonFiles.Count)} Python Files";
                        checkBoxJavaFiles.Text = $" {Convert.ToString(MyOF.javaFiles.Count)} Java Files";
                       // checkBoxCMakeFiles.Text = $" {Convert.ToString(MyOF.javaFiles.Count)} Java Files";
                    }
                  
                    break;
                //Select files to be Checked panel.
                case 2:
                    if(checkBoxCfiles.Checked == false && checkBoxJavaFiles.Checked == false && checkBoxPythonFiles.Checked == false)
                    {
                        MessageBox.Show("Please select files before continuing.", "Alert",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                    }else
                    {
                        NextPanel();
                        //PopulateResultsPreview();
                        buttonNextPanel.Visible = false;
                    }
                   

                    break;
                //Select HEST1 OR HEST2
                case 3:
                    NextPanel();
                    PopulateResultsPreview();

                    buttonExitProgramEND.Visible = true;

                    break;
                //Generate report to excel.
                case 4:
                    break;
                default:
                    break;
            }


        }
        /// <summary>method <c>NextPanel</c> makes next panel visible.</summary>
        /// 
        [ExcludeFromCodeCoverage]
        public void NextPanel()
        {
            if (PanelIndex < listPanel.Count - 1)
                listPanel[++PanelIndex].BringToFront();
        }
        /// <summary>method <c>PrevPanel</c> makes previous panel visible.</summary>
        /// 
        [ExcludeFromCodeCoverage]
        public void PrevPanel()
        {
            if (PanelIndex > 0)
                listPanel[--PanelIndex].BringToFront();
        }
        [ExcludeFromCodeCoverage]
        private void Button1EnterProg_Click(object sender, EventArgs e)
        {
            NextPanelBehav();

        }
        [ExcludeFromCodeCoverage]
        private void ButtonSelectedHest1_Click(object sender, EventArgs e)//HEST 1 selection button.
        {
            /// <summary>method <c>draw</c> renders the point.</summary>

            Hest2Panel.Visible = false;
            ExecCheckedFiles();
            label5SummaryFilesHEST1HEST2.Text = "RESULTS FOR THE HEST-1 METHOD.";
            NextPanelBehav();
            // NextPanelBehav();


        }
        [ExcludeFromCodeCoverage]
        private void ButtonExitProgramEND_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        [ExcludeFromCodeCoverage]
        private void ButtonSelectedHEST2_Click(object sender, EventArgs e)
        {
            //            NextPanelBehav();
            Hest2Panel.BringToFront();
            Hest2Panel.Visible = true;
            label5SummaryFilesHEST1HEST2.Text = "RESULTS FOR THE HEST-2 METHOD.";
        }
        [ExcludeFromCodeCoverage]
        private void ListBox1DragFiles_DragEnter_1(object sender, DragEventArgs e)
        {
            string[] filesDrop = (string[])e.Data.GetData(DataFormats.FileDrop, false);
           // string[] filesDropToProccess = new string[filesDrop.Length];
            //FilesTool.filesToCheck = new string[filesDrop.Length];
            //FilesTool.filesToCheck = filesDrop;

            List<string> list = new List<string>();
            foreach (string item in filesDrop)
            {
                if(Directory.Exists(item))
                {
                    string[] FilesInDir = Directory.GetFiles(item);
                    foreach (string file in FilesInDir)
                    {
                        var name = Path.GetFileName(file.ToString());
                        list.Add(file);
                        listBox1DragFiles.Items.Add(name);
                    }
                }
                if (File.Exists(item))
                {
                    var name = Path.GetFileName(item.ToString());
                    list.Add(item);
                    listBox1DragFiles.Items.Add(name);
                }
               
            }
            FilesTool.filesToCheck = list.ToArray();
            CountFilesDragged();
        }
        /// <summary>method <c>ClasssifiesAndLoadsFiles</c>gets files from listBox drop and returns a myOrderedFiles instance.</summary>
        [ExcludeFromCodeCoverage]
        public OrderedFiles ClasssifiesAndLoadsFiles()
        {
            /// <summary>method <c>draw</c> renders the point.</summary>
            OrderedFiles myOrderedFiles = new OrderedFiles();
            myOrderedFiles = LanguageRecognizion.classifierProgLang(FilesTool.filesToCheck);
            // label4NumCfiles.Text = Convert.ToString(myOrderedFiles.cFiles.Count);
            return myOrderedFiles;
        }
        /// <summary>method <c>executeGivenFiles</c>execute all files in myOrderedFiles</summary>
        [ExcludeFromCodeCoverage]
        private void executeGivenFiles(int caseSwitch)
        {
            /// <summary>method <c>draw</c> renders the point.</summary>

            OrderedFiles myOrderedFiles = new OrderedFiles();
            myOrderedFiles = LanguageRecognizion.classifierProgLang(FilesTool.filesToCheck);
            switch (caseSwitch)
            {
                case 1:
                    foreach (string item in myOrderedFiles.cFiles)
                    {

                        if (isHest1)
                        {
                            (string compilerOutPut, string execFileOutput) = FilesExecuterHest1.executeFile(item);
                            //.executeFile(item);

                            // MessageBox.Show($"Compiler out put:{compilerOutPut}   \n\n   exeFileOutPut:{execFileOutput}");
                            RevisionResultCfiles.Add(new FileResultHest1(compilerOutPut, execFileOutput));

                        }
                        else
                        {
                            //(string compilerOutPut, string execFileOutput) = FilesExecuterHest2.executeFile(item, textBox1InputParameters.Text);
                            //.executeFile(item);
                            // MessageBox.Show($"Compiler out put:{compilerOutPut}   \n\n   exeFileOutPut:{execFileOutput}");
                            //RevisionResultCfiles.Add(new FileResultHest1(compilerOutPut, execFileOutput, textBoxHEST2ExpectedOutPut.Text));

                            foreach (string inputCheck in FilesTool.inputToBeCheckedHest2)
                            {
                                
                                (string compilerOutPut, string execFileOutput) = FilesExecuterHest2.executeFile(item, FilesTool.processFileOutPut(inputCheck));
                                RevisionResultCfilesHest2.Add(new FileResultHest2(compilerOutPut, execFileOutput, inputCheck));
                            }
    
                        }

                    }
                    break;
                case 2:
                    foreach (string item in myOrderedFiles.javaFiles)
                    {

                        if (isHest1)
                        {
                            (string compilerOutPut, string execFileOutput) = FilesExecuterHest1.executeFile(item);
                            //.executeFile(item);

                            // MessageBox.Show($"Compiler out put: {compilerOutPut}   \r\n\n   exeFileOutPut:{execFileOutput}");
                            RevisionResultJavaFiles.Add(new FileResultHest1(compilerOutPut, execFileOutput));
                        }
                        else
                        {
                            //(string compilerOutPut, string execFileOutput) = FilesExecuterHest2.executeFile(item, textBox1InputParameters.Text);
                            //.executeFile(item);

                            // MessageBox.Show($"Compiler out put:{compilerOutPut}   \n\n   exeFileOutPut:{execFileOutput}");
                            //RevisionResultJavaFiles.Add(new FileResultHest1(compilerOutPut, execFileOutput, textBoxHEST2ExpectedOutPut.Text));
                            foreach (string inputCheck in FilesTool.inputToBeCheckedHest2)
                            {

                                (string compilerOutPut, string execFileOutput) = FilesExecuterHest2.executeFile(item, FilesTool.processFileOutPut(inputCheck));
                                RevisionResultJavaFilesHest2.Add(new FileResultHest2(compilerOutPut, execFileOutput, inputCheck));
                            }
                        }



                    }
                    break;
                case 3:
                    foreach (string item in myOrderedFiles.pythonFiles)
                    {

                        if (isHest1)
                        {
                            (string compilerOutPut, string execFileOutput) = FilesExecuterHest1.executeFile(item);
                            //.executeFile(item);

                            // MessageBox.Show($"Compiler out put:{compilerOutPut}   \n\n   exeFileOutPut:{execFileOutput}");
                            RevisionResultPythonFiles.Add(new FileResultHest1(compilerOutPut, execFileOutput));
                        }
                        else
                        {
                            //(string compilerOutPut, string execFileOutput) = FilesExecuterHest2.executeFile(item, textBox1InputParameters.Text);
                            //.executeFile(item);

                            // MessageBox.Show($"Compiler out put:{compilerOutPut}   \n\n   exeFileOutPut:{execFileOutput}");

                            // RevisionResultPythonFiles.Add(new FileResultHest1(compilerOutPut, execFileOutput, textBoxHEST2ExpectedOutPut.Text));
                            foreach (string inputCheck in FilesTool.inputToBeCheckedHest2)
                            {

                                (string compilerOutPut, string execFileOutput) = FilesExecuterHest2.executeFile(item, FilesTool.processFileOutPut(inputCheck));
                                RevisionResultPythonFilesHest2.Add(new FileResultHest2(compilerOutPut, execFileOutput, inputCheck));
                            }
                        }




                    }
                    break;
                default:
                    Console.WriteLine("Error, contact support");
                    break;
            }




        }
        /// <summary>method <c>ExecCheckedFiles</c>executes files that where selected in the CheckBoxes.</summary>
        [ExcludeFromCodeCoverage]
        private void ExecCheckedFiles()
        {

            if (checkBoxCfiles.Checked == true)
                executeGivenFiles(1);
            if (checkBoxPythonFiles.Checked == true)
                executeGivenFiles(3);
            if (checkBoxJavaFiles.Checked == true)
                executeGivenFiles(2);


        }


        /// <summary>method <c>ResultsToExcel</c>Writes the results into a Excel file.</summary>
        [ExcludeFromCodeCoverage]
        private void ResultsToExcel(List<FileResultHest1> myListToExcel)
        {
            /// <summary>method <c>draw</c> renders the point.</summary>

            DataTable tableFromList = ConvertListToDataTable(myListToExcel);
            //using (var reader = FastMember.ObjectReader.Create( myListToExcel))
            //{
            //    table.Load(reader);
            //}
            using (Syncfusion.XlsIO.ExcelEngine excelEngine = new Syncfusion.XlsIO.ExcelEngine())
            {
                Syncfusion.XlsIO.IApplication application = excelEngine.Excel;
                application.DefaultVersion = Syncfusion.XlsIO.ExcelVersion.Excel2016;

                //Create a new workbook
                Syncfusion.XlsIO.IWorkbook workbook = application.Workbooks.Create(1);
                Syncfusion.XlsIO.IWorksheet sheet = workbook.Worksheets[0];

                //Create a dataset from XML file
                //DataSet customersDataSet = new DataSet();
                //customersDataSet.ReadXml(Path.GetFullPath(@"../../Data/Employees.xml"));

                //Create datatable from the dataset
                // DataTable dataTable = new DataTable();
                // dataTable = customersDataSet.Tables[0];

                //Import data from the data table with column header, at first row and first column, 
                //and by its column type.
                sheet.ImportDataTable(tableFromList, true, 1, 1, true);

                //Creating Excel table or list object and apply style to the table
                Syncfusion.XlsIO.IListObject Table = sheet.ListObjects.Create("Employee_PersonalDetails", sheet.UsedRange);

                Table.BuiltInTableStyle = Syncfusion.XlsIO.TableBuiltInStyles.TableStyleMedium14;

                //Autofit the columns
                sheet.UsedRange.AutofitColumns();

                //Save the file in the given path
                Stream excelStream = File.Create(Path.GetFullPath($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\OutPutExcel.xlsx"));
                workbook.SaveAs(excelStream);
                excelStream.Dispose();
            }

        }

        [ExcludeFromCodeCoverage]
        private void ResultsToExcelHest2(List<FileResultHest2> myListToExcel)
        {
            /// <summary>method <c>draw</c> renders the point.</summary>

            DataTable tableFromList = ConvertListToDataTableHest2(myListToExcel);
            //using (var reader = FastMember.ObjectReader.Create( myListToExcel))
            //{
            //    table.Load(reader);
            //}
            using (Syncfusion.XlsIO.ExcelEngine excelEngine = new Syncfusion.XlsIO.ExcelEngine())
            {
                Syncfusion.XlsIO.IApplication application = excelEngine.Excel;
                application.DefaultVersion = Syncfusion.XlsIO.ExcelVersion.Excel2016;

                //Create a new workbook
                Syncfusion.XlsIO.IWorkbook workbook = application.Workbooks.Create(1);
                Syncfusion.XlsIO.IWorksheet sheet = workbook.Worksheets[0];
                sheet[1, 1].Text = "File Name";
                sheet[1, 2].Text = "StudentID";
                sheet[1, 3].Text = "File Name";
                sheet[1, 4].Text = "Departament";
                sheet[1, 5].Text = "Compiled Successfully";
                sheet[1, 6].Text = "Compiler errors";
                sheet[1, 7].Text = "File's output";
                sheet[1, 8].Text = "Expected Output";
                sheet[1, 9].Text = "Passed HEST2";

                //Create a dataset from XML file
                //DataSet customersDataSet = new DataSet();
                //customersDataSet.ReadXml(Path.GetFullPath(@"../../Data/Employees.xml"));

                //Create datatable from the dataset
                // DataTable dataTable = new DataTable();
                // dataTable = customersDataSet.Tables[0];

                //Import data from the data table with column header, at first row and first column, 
                //and by its column type.
                sheet.ImportDataTable(tableFromList, true, 1, 1, true);

                //Creating Excel table or list object and apply style to the table
                Syncfusion.XlsIO.IListObject Table = sheet.ListObjects.Create("Employee_PersonalDetails", sheet.UsedRange);

                Table.BuiltInTableStyle = Syncfusion.XlsIO.TableBuiltInStyles.TableStyleMedium14;

                //Autofit the columns
                sheet.UsedRange.AutofitColumns();

                //Save the file in the given path
                Stream excelStream = File.Create(Path.GetFullPath($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\OutPutExcel.xlsx"));
                workbook.SaveAs(excelStream);
                excelStream.Dispose();
            }

        }
        /// <summary>method <c>PopulateResultsPreview</c>files up the data in the correct labels. Number of files to be checked.</summary>
        [ExcludeFromCodeCoverage]
        private void PopulateResultsPreview()
        {

            int CerrorIndex = 0;
            int PythonErrorIndex = 0;
            int JavaErrorIndex = 0;


            label9NumCFilesChecked.Text = $" {Convert.ToString(MyOF.cFiles.Count)}";
           // label10NumCmakeFilesBuilt.Text = $" 0";
            label10NumPythonFilesChecked.Text = $" {Convert.ToString(MyOF.pythonFiles.Count)}";
            label9NumJavaFilesChecked.Text = $" {Convert.ToString(MyOF.javaFiles.Count)}";
            foreach (FileResultHest1 item in RevisionResultCfiles)
            {
                if (item.Errors.Length > 0) { ++CerrorIndex; }

            }
            foreach (var item in RevisionResultPythonFiles)
            {
                if (item.Errors.Length > 0) { ++PythonErrorIndex; }

            }
            foreach (var item in RevisionResultJavaFiles)
            {
                if (item.Errors.Length > 0) { ++JavaErrorIndex; }

            }
            labelErrorsCfiles.Text = $"{Convert.ToString(CerrorIndex)}";
            labelErrorPython.Text = $"{Convert.ToString(PythonErrorIndex)}";
            labelErrorJavaFiles.Text = $"{Convert.ToString(JavaErrorIndex)}";


        }
        /// <summary>method <c>ConvertListToDataTable</c>Return dataTable with all values to be written into the Excel File.</summary>
        [ExcludeFromCodeCoverage]
        private void CountFilesDragged()
        {
            labelNumberFilesDragged.Text = listBox1DragFiles.Items.Count.ToString();
        }
        [ExcludeFromCodeCoverage]
        static DataTable ConvertListToDataTable(List<FileResultHest1> list)
        {
            // New table.
            DataTable table = new DataTable();
            
            // Get max columns.
            int columns = 8;

            //foreach (var element in list)
            //{
            //    if (element > columns)
            //    {
            //        columns = element.Length;
            //    }
            //}

            // Add columns.
            for (int i = 0; i < columns; i++)
            {
                table.Columns.Add();
            }
            table.Rows.Add("File name", "StudentID", "Department", "Compiled Successfully", "Errors", "File's output");
            // Add rows.
            foreach (var array in list)
            {
                table.Rows.Add(array.FileName, array.StudenId, array.Department, array.Compiled.ToString(), array.Errors, array.FileOutput);
            }

            return table;
        }

        [ExcludeFromCodeCoverage]
        static DataTable ConvertListToDataTableHest2(List<FileResultHest2> list)
        {
            // New table.
            DataTable table = new DataTable();

            // Get max columns.
            int columns = 8;

            //foreach (var element in list)
            //{
            //    if (element > columns)
            //    {
            //        columns = element.Length;
            //    }
            //}

            // Add columns.
            for (int i = 0; i < columns; i++)
            {
                table.Columns.Add();
            }
            //table.Rows.Add("File name", "StudentID", "Department", "Compiled Successfully", "Compiler errors", "File's output");
            // Add rows.
            foreach (var array in list)
            {
                table.Rows.Add(array.FileName, array.StudenId, array.Department, array.Compiled.ToString(), array.Errors, array.FileOutput, array.UserDefinedExpectedOutPut,array.Hest2PassedTest);
            }

            return table;
        }

        [ExcludeFromCodeCoverage]
        private void Button4GenerateReport_Click(object sender, EventArgs e)
        {
            ResultsToExcel(RevisionResultCfiles);
        }


        [ExcludeFromCodeCoverage]
        private void Button1Hest2EvalueateFiles_Click(object sender, EventArgs e)
        {
            this.isHest1 = false;
            ExecCheckedFiles();
            NextPanelBehav();

        }

        private void listBox2Hest2Output_DragEnter(object sender, DragEventArgs e)
        {
            string[] filesDrop = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            // string[] filesDropToProccess = new string[filesDrop.Length];
            //FilesTool.filesToCheck = new string[filesDrop.Length];
            //FilesTool.filesToCheck = filesDrop;

            List<string> list = new List<string>();
            foreach (string item in filesDrop)
            {
                if (Directory.Exists(item))
                {
                    string[] FilesInDir = Directory.GetFiles(item);
                    foreach (string file in FilesInDir)
                    {
                        var name = Path.GetFileName(file.ToString());
                        list.Add(file);
                        listBox2Hest2Output.Items.Add(name);
                    }
                }
                if (File.Exists(item))
                {
                    var name = Path.GetFileName(item.ToString());
                    list.Add(item);
                    listBox2Hest2Output.Items.Add(name);
                }
            }
            FilesTool.testsToPerformHest2 = list.ToArray();
        }

        private void listBox1Hest2InputParam_DragEnter(object sender, DragEventArgs e)
        {
            string[] filesDrop = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            // string[] filesDropToProccess = new string[filesDrop.Length];
            //FilesTool.filesToCheck = new string[filesDrop.Length];
            //FilesTool.filesToCheck = filesDrop;

            List<string> list = new List<string>();
            foreach (string item in filesDrop)
            {
                if (Directory.Exists(item))
                {
                    string[] FilesInDir = Directory.GetFiles(item);
                    foreach (string file in FilesInDir)
                    {
                        var name = Path.GetFileName(file.ToString());
                        list.Add(file);
                       listBox1Hest2InputParam.Items.Add(name);
                    }
                }
                if (File.Exists(item))
                {
                    var name = Path.GetFileName(item.ToString());
                    list.Add(item);
                    listBox1Hest2InputParam.Items.Add(name);
                }
            }
            FilesTool.inputToBeCheckedHest2 = list.ToArray();
        }

        private void listBox1Hest2InputParam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1ClearListBoxHest2In_Click(object sender, EventArgs e)
        {
            listBox1Hest2InputParam.Items.Clear();
        }

        private void button1ClearListBoxHest2Output_Click(object sender, EventArgs e)
        {
            listBox2Hest2Output.Items.Clear();

        }

        private void button1ClearFilesDragger_Click(object sender, EventArgs e)
        {
            listBox1DragFiles.Items.Clear();
        }
    }
}
