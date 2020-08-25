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
namespace HomeWorkCheckApp
{
    /// <summary>Main Window Class <c>Point</c> All the events logic here and access to models.
    /// </summary>
    ///
    public partial class MainWindow : Form
    {

        List<Panel> listPanel = new List<Panel>();
        List<FileResult> RevisionResultCfiles = new List<FileResult>();
        List<FileResult> RevisionResultJavaFiles = new List<FileResult>();
        List<FileResult> RevisionResultPythonFiles = new List<FileResult>();
        OrderedFiles MyOF = new OrderedFiles();
        bool isHest1;
        //int IndexFile = 0;
        int PanelIndex;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button1CheckFiles_Click(object sender, EventArgs e)
        {

        }
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
        private void ButtonNextPanel_Click(object sender, EventArgs e)
        {
            NextPanelBehav();
        }//Next event button.
        private void ButtonExitPro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ButtonBackSFW_Click(object sender, EventArgs e)
        {
            PrevPanel();
            buttonNextPanel.Visible = true;
        }
        /// <summary>method <c>NextPanelBehav</c> forwards or backwards the panel order toggling visibility.</summary>
        public void NextPanelBehav()
        {
            switch (PanelIndex)
            {
                //Login Panel
                case 0:
                    NextPanel();
                    buttonNextPanel.Visible = true;
                    buttonExitProgramEND.Visible = false;
                    break;
                //Drag Files panel
                case 1:
                    NextPanel();
                    buttonExitPro.Visible = false;
                    buttonBackSFW.Visible = true;
                    MyOF = ClasssifiesAndLoadsFiles();
                    checkBoxCfiles.Text = $" {Convert.ToString(MyOF.cFiles.Count)} C-Files";
                    checkBoxPythonFiles.Text = $" {Convert.ToString(MyOF.pythonFiles.Count)} Python Files";
                    checkBoxJavaFiles.Text = $" {Convert.ToString(MyOF.javaFiles.Count)} Java Files";
                    checkBoxCMakeFiles.Text = $" {Convert.ToString(MyOF.javaFiles.Count)} Java Files";
                    break;
                //Select files to be Checked panel.
                case 2:
                    NextPanel();
                    //PopulateResultsPreview();
                    buttonNextPanel.Visible = false;

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
        public void NextPanel()
        {
            if (PanelIndex < listPanel.Count - 1)
                listPanel[++PanelIndex].BringToFront();
        }
        /// <summary>method <c>PrevPanel</c> makes previous panel visible.</summary>
        public void PrevPanel()
        {
            if (PanelIndex > 0)
                listPanel[--PanelIndex].BringToFront();
        }

        private void Button1EnterProg_Click(object sender, EventArgs e)
        {
            NextPanelBehav();

        }
        private void ButtonSelectedHest1_Click(object sender, EventArgs e)//HEST 1 selection button.
        {
            /// <summary>method <c>draw</c> renders the point.</summary>
            Hest2Panel.Visible = false;
            ExecCheckedFiles();
            label5SummaryFilesHEST1HEST2.Text = "RESULTS FOR THE HEST-1 METHOD.";
            NextPanelBehav();
            // NextPanelBehav();


        }
        private void ButtonExitProgramEND_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ButtonSelectedHEST2_Click(object sender, EventArgs e)
        {
            //            NextPanelBehav();
            Hest2Panel.BringToFront();
            Hest2Panel.Visible = true;
            label5SummaryFilesHEST1HEST2.Text = "RESULTS FOR THE HEST-2 METHOD.";
        }
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

        private OrderedFiles ClasssifiesAndLoadsFiles()
        {
            /// <summary>method <c>draw</c> renders the point.</summary>
            OrderedFiles myOrderedFiles = new OrderedFiles();
            myOrderedFiles = LanguageRecognizion.classifierProgLang(FilesTool.filesToCheck);
            // label4NumCfiles.Text = Convert.ToString(myOrderedFiles.cFiles.Count);
            return myOrderedFiles;
        }
        /// <summary>method <c>executeGivenFiles</c>execute all files in myOrderedFiles</summary>
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
                            RevisionResultCfiles.Add(new FileResult(compilerOutPut, execFileOutput));

                        }
                        else
                        {
                            (string compilerOutPut, string execFileOutput) = FilesExecuterHest2.executeFile(item, textBox1InputParameters.Text);
                            //.executeFile(item);

                            // MessageBox.Show($"Compiler out put:{compilerOutPut}   \n\n   exeFileOutPut:{execFileOutput}");
                            RevisionResultCfiles.Add(new FileResult(compilerOutPut, execFileOutput, textBoxHEST2ExpectedOutPut.Text));
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
                            RevisionResultJavaFiles.Add(new FileResult(compilerOutPut, execFileOutput));
                        }
                        else
                        {
                            (string compilerOutPut, string execFileOutput) = FilesExecuterHest2.executeFile(item, textBox1InputParameters.Text);
                            //.executeFile(item);

                            // MessageBox.Show($"Compiler out put:{compilerOutPut}   \n\n   exeFileOutPut:{execFileOutput}");
                            RevisionResultJavaFiles.Add(new FileResult(compilerOutPut, execFileOutput, textBoxHEST2ExpectedOutPut.Text));
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
                            RevisionResultPythonFiles.Add(new FileResult(compilerOutPut, execFileOutput));
                        }
                        else
                        {
                            (string compilerOutPut, string execFileOutput) = FilesExecuterHest2.executeFile(item, textBox1InputParameters.Text);
                            //.executeFile(item);

                            // MessageBox.Show($"Compiler out put:{compilerOutPut}   \n\n   exeFileOutPut:{execFileOutput}");

                        RevisionResultPythonFiles.Add(new FileResult(compilerOutPut, execFileOutput, textBoxHEST2ExpectedOutPut.Text));
                        }




                    }
                    break;
                default:
                    Console.WriteLine("Error, contact support");
                    break;
            }




        }
        /// <summary>method <c>ExecCheckedFiles</c>executes files that where selected in the CheckBoxes.</summary>
        private void ExecCheckedFiles()
        {

            if (checkBoxCfiles.Checked == true)
                executeGivenFiles(1);
            if (checkBoxPythonFiles.Checked == true)
                executeGivenFiles(3);
            if (checkBoxJavaFiles.Checked == true)
                executeGivenFiles(2);


        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
        /// <summary>method <c>ResultsToExcel</c>Writes the results into a Excel file.</summary>
        private void ResultsToExcel(List<FileResult> myListToExcel)
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
        /// <summary>method <c>PopulateResultsPreview</c>files up the data in the correct labels. Number of files to be checked.</summary>
        private void PopulateResultsPreview()
        {

            int CerrorIndex = 0;
            int PythonErrorIndex = 0;
            int JavaErrorIndex = 0;


            label9NumCFilesChecked.Text = $" {Convert.ToString(MyOF.cFiles.Count)}";
            label10NumCmakeFilesBuilt.Text = $" 0";
            label10NumPythonFilesChecked.Text = $" {Convert.ToString(MyOF.pythonFiles.Count)}";
            label9NumJavaFilesChecked.Text = $" {Convert.ToString(MyOF.javaFiles.Count)}";
            foreach (FileResult item in RevisionResultCfiles)
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

        private void CountFilesDragged()
        {
            labelNumberFilesDragged.Text = listBox1DragFiles.Items.Count.ToString();
        }
        static DataTable ConvertListToDataTable(List<FileResult> list)
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
            table.Rows.Add("File name", "StudentID", "Department", "Compiled Successfully", "Errors", "File's output", "Passed HEST2?", "HEST2 - Expected OutPut");
            // Add rows.
            foreach (var array in list)
            {
                table.Rows.Add(array.FileName, array.StudenId, array.Department, array.Compiled.ToString(), array.Errors, array.FileOutput, array.Hest2PassedTest,array.UserDefinedExpectedOutPut);
            }

            return table;
        }

        private void Button4GenerateReport_Click(object sender, EventArgs e)
        {
            ResultsToExcel(RevisionResultCfiles);
        }

        private void LabelCmakeFiles_Click(object sender, EventArgs e)
        {

        }

        private void Button1Hest2EvalueateFiles_Click(object sender, EventArgs e)
        {
            this.isHest1 = false;
            ExecCheckedFiles();
            NextPanelBehav();

        }

      
    }
}
