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
using System.IO.Compression;
using System.Text.RegularExpressions;

namespace HomeWorkCheckApp
{
    /// <summary>Main Window Class <c>Point</c> All the events logic here and access to models.
    /// </summary>
    ///
    public partial class MainWindow : Form
    {
        List<Panel> listPanel = new List<Panel>();
        List<FileResultHest1> RevisionResultCfilesHest1 = new List<FileResultHest1>();
        List<FileResultHest1> RevisionResultJavaFilesHest1 = new List<FileResultHest1>();
        List<FileResultHest1> RevisionResultPythonFilesHest1 = new List<FileResultHest1>();
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
                        MessageBox.Show("Please Drag files before continuing.", "Alert",
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
                    if (checkBoxCfiles.Checked == false && checkBoxJavaFiles.Checked == false && checkBoxPythonFiles.Checked == false)
                    {
                        MessageBox.Show("Please select files before continuing.", "Alert",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                    }
                    else
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
        private async void ButtonSelectedHest1_ClickAsync(object sender, EventArgs e)//HEST 1 selection button.
        {
            this.isHest1 = false;
            progressBar1.Visible = true;
            label15WorkingOn.Visible = true;
            progressBar1.Style = ProgressBarStyle.Marquee;
            isHest1 = true;
            Hest2Panel.Visible = false;
            await Task.Run(() => ExecCheckedFiles());
            progressBar1.Visible = false;
            label15WorkingOn.Visible = false;
            label5SummaryFilesHEST1HEST2.Text = "RESULTS FOR THE HEST-1 METHOD.";
            NextPanelBehav();


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
            isHest1 = false;
            Hest2Panel.BringToFront();
            Hest2Panel.Visible = true;
            label5SummaryFilesHEST1HEST2.Text = "RESULTS FOR THE HEST-2 METHOD.";
        }
        [ExcludeFromCodeCoverage]
        private void ListBox1DragFiles_DragEnter_1(object sender, DragEventArgs e)
        {
            string[] filesDrop = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string[] droppedFilesNoHeb = FilesTool.RenameDraggedFiles(filesDrop);

            string HwOutputFiles = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\HwOutput";
            List<string> list = new List<string>();
            //TEST
            List<string> listIDS = new List<string>();
            foreach (string item in droppedFilesNoHeb)
            {

                if (Directory.Exists(item))
                {
                    string[] FilesInDir = Directory.GetFiles(item);
                    foreach (string fileInDir in FilesInDir)
                    {

                        string lastFolderNameStudenID = Path.GetFileName(Path.GetDirectoryName(fileInDir.ToString()));
                        var resultStudenIdNoHeb = Regex.Replace(lastFolderNameStudenID, @"\p{IsHebrew}", string.Empty);
                        var resultStudenNoHebNoSpaces = Regex.Replace(resultStudenIdNoHeb, @"\s+", String.Empty);

                        var name = Path.GetFileName(fileInDir.ToString());
                        if (Path.GetExtension(fileInDir).Equals(".zip"))
                        {

                            try
                            {
                                string folferUnzipFile = $"{HwOutputFiles}\\{resultStudenNoHebNoSpaces}";
                                ZipFile.ExtractToDirectory(fileInDir, folferUnzipFile);
                                //string unzipFilePath = $"{folferUnzipFile}\\{Path.GetFileName(file)}";
                                string[] FilesInDirUnzip = Directory.GetFiles(folferUnzipFile);
                                foreach (string pathUnzipFile in FilesInDirUnzip)
                                {
                                    list.Add(pathUnzipFile);
                                    listIDS.Add(Path.GetFileNameWithoutExtension(fileInDir));
                                    listBox1DragFiles.Items.Add(pathUnzipFile);
                                }



                            }
                            catch (Exception objException)
                            {

                                MessageBox.Show(objException.ToString(), "Alert",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            }


                        }
                        else
                        {
                            list.Add(fileInDir);
                            listIDS.Add(Path.GetFileNameWithoutExtension(item));

                            listBox1DragFiles.Items.Add(fileInDir);
                        }

                    }
                }
                if (File.Exists(item))
                {
                    string lastFolderNameStudenID = Path.GetFileName(Path.GetDirectoryName(item.ToString()));
                    var resultStudenIdNoHeb = Regex.Replace(lastFolderNameStudenID, @"\p{IsHebrew}", string.Empty);
                    var resultStudenNoHebNoSpaces = Regex.Replace(resultStudenIdNoHeb, @"\s+", String.Empty);

                    string StudentAndFileName = $"{lastFolderNameStudenID}\\{resultStudenNoHebNoSpaces}";

                    if (Path.GetExtension(item).Equals(".zip"))
                    {

                        ZipFile.ExtractToDirectory(item, $"{HwOutputFiles}\\{resultStudenNoHebNoSpaces}");
                        list.Add($"{HwOutputFiles}\\{resultStudenNoHebNoSpaces}\\{Path.GetFileName(item)}");
                        listIDS.Add(Path.GetFileNameWithoutExtension(item));
                    }
                    else
                    {

                        list.Add(item);//Adds unzip file path to list.
                        if ((Path.GetExtension(item).Contains(".c")) || (Path.GetExtension(item).Contains(".java")) || (Path.GetExtension(item).Contains(".py")))
                        {
                            listIDS.Add(Path.GetFileNameWithoutExtension(item));//Adds student IDS to list.
                        }

                        listBox1DragFiles.Items.Add(StudentAndFileName);
                    }
                }

            }
            FilesTool.filesToCheck = list.ToArray();
            FilesTool.studentIDS = listIDS.ToArray();
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
            int counterIDSstudensHest1 = 0;
            switch (caseSwitch)
            {
                case 1:
                    foreach (string item in myOrderedFiles.cFiles)
                    {
                        string lastFolderNameStudenID = Path.GetFileName(Path.GetDirectoryName(item.ToString()));
                        string IdNumberStuden = Path.GetFileNameWithoutExtension(item);

                        if (isHest1)
                        {

                            (string compilerOutPutComp, bool compiledOk, string compiledFileToCheck) = FilesExecuterHest1.compileFile(item);

                            if (compiledOk)
                            {
                                (string compilerOutPutExec, string execFileOutput, bool compiledSuccsesfully) = FilesExecuterHest1.executeFile(compiledFileToCheck);
                                RevisionResultCfilesHest1.Add(new FileResultHest1(execFileOutput, compiledSuccsesfully, compilerOutPutExec, item, FilesTool.studentIDS[counterIDSstudensHest1], "Kinneret Computer Science"));
                                counterIDSstudensHest1++;
                            }
                            else
                            {
                                RevisionResultCfilesHest1.Add(new FileResultHest1("None", compiledOk, compilerOutPutComp, item, FilesTool.studentIDS[counterIDSstudensHest1], "CS Kinneret"));
                                counterIDSstudensHest1++;

                            }



                        }
                        else//HEST2
                        {
                            //(string compilerOutPut, string execFileOutput) = FilesExecuterHest2.executeFile(item, textBox1InputParameters.Text);
                            //.executeFile(item);
                            // MessageBox.Show($"Compiler out put:{compilerOutPut}   \n\n   exeFileOutPut:{execFileOutput}");
                            //RevisionResultCfilesHest1.Add(new FileResultHest1(compilerOutPut, execFileOutput, textBoxHEST2ExpectedOutPut.Text));
                            (string OutputFromFile, bool wasSuccessfull, string CompiledFilePath) = FilesExecuterHest2.compileFile(item);
                            if (wasSuccessfull)
                            {
                                foreach (string inputCheck in FilesTool.inputToBeCheckedHest2)
                                {
                                    //string s = FilesTool.processFileOutPut(inputCheck);

                                    (string execOutput, bool hasErrors, string ErrorsOnExec) = FilesExecuterHest2.executeFile(CompiledFilePath, inputCheck);

                                    (bool PassedTEstHest2, string ExpectedTestOutPut) = FilesTool.PassedHest2Test(execOutput, inputCheck);
                                    //bool PassedTEstHest2
                                    RevisionResultCfilesHest2.Add(new FileResultHest2(execOutput, hasErrors, ErrorsOnExec, PassedTEstHest2, Path.GetFileName(inputCheck), item, FilesTool.studentIDS[counterIDSstudensHest1], ExpectedTestOutPut, "Computer Science"));
                                    counterIDSstudensHest1++;

                                }
                            }
                            else
                            {
                                RevisionResultCfilesHest2.Add(new FileResultHest2("none", wasSuccessfull, OutputFromFile, false, "none", item, FilesTool.studentIDS[counterIDSstudensHest1], "None", "Computer Science"));
                                counterIDSstudensHest1++;

                            }


                        }

                    }
                    break;
                case 2:
                    foreach (string item in myOrderedFiles.javaFiles)
                    {
                        string lastFolderNameStudenID = Path.GetFileName(Path.GetDirectoryName(item.ToString()));
                        string IdNumberStuden = Path.GetFileNameWithoutExtension(item);

                        if (isHest1)
                        {

                            (string compilerOutPutComp, bool compiledOk, string compiledFileToCheck) = FilesExecuterHest1.compileFile(item);

                            if (compiledOk)
                            {
                                (string compilerOutPutExec, string execFileOutput, bool compiledSuccsesfully) = FilesExecuterHest1.executeFile(compiledFileToCheck);
                                RevisionResultJavaFilesHest1.Add(new FileResultHest1(execFileOutput, compiledSuccsesfully, compilerOutPutExec, item, FilesTool.studentIDS[counterIDSstudensHest1], "Kinneret Computer Science"));
                                counterIDSstudensHest1++;

                            }
                            else
                            {
                                RevisionResultJavaFilesHest1.Add(new FileResultHest1("None", compiledOk, compilerOutPutComp, item, FilesTool.studentIDS[counterIDSstudensHest1], "CS Kinneret"));
                                counterIDSstudensHest1++;

                            }



                        }
                        else
                        {
                           
                            (string OutputFromFile, bool wasSuccessfull, string CompiledFilePath) = FilesExecuterHest2.compileFile(item);
                            if (wasSuccessfull)
                            {
                                foreach (string inputCheck in FilesTool.inputToBeCheckedHest2)
                                {
                                    //string s = FilesTool.processFileOutPut(inputCheck);

                                    (string execOutput, bool HasNoErrors, string ErrorsOnExec) = FilesExecuterHest2.executeFile(CompiledFilePath, inputCheck);

                                    (bool PassedTEstHest2, string ExpectedTestOutPut) = FilesTool.PassedHest2Test(execOutput, inputCheck);
                                    RevisionResultJavaFilesHest2.Add(new FileResultHest2(execOutput, HasNoErrors, ErrorsOnExec, PassedTEstHest2, Path.GetFileName(inputCheck), item, FilesTool.studentIDS[counterIDSstudensHest1], ExpectedTestOutPut, "Computer Science"));

                                }
                                counterIDSstudensHest1++;

                            }
                            else
                            {
                                RevisionResultJavaFilesHest2.Add(new FileResultHest2("none", wasSuccessfull, OutputFromFile, false, "none", item, FilesTool.studentIDS[counterIDSstudensHest1], "None", "Computer Science"));
                                counterIDSstudensHest1++;

                            }

                        }



                    }
                    break;
                case 3:
                    foreach (string item in myOrderedFiles.pythonFiles)
                    {
                        string lastFolderNameStudenID = Path.GetFileName(Path.GetDirectoryName(item.ToString()));
                        string IdNumberStuden = Path.GetFileNameWithoutExtension(item);


                        if (isHest1)
                        {


                            (string compilerOutPutExec, string execFileOutput, bool compiledSuccsesfully) = FilesExecuterHest1.executeFile(item);
                            if(compiledSuccsesfully)
                            {
                                RevisionResultPythonFilesHest1.Add(new FileResultHest1(execFileOutput, compiledSuccsesfully, compilerOutPutExec, item, FilesTool.studentIDS[counterIDSstudensHest1], "Cs Kinneret"));
                                counterIDSstudensHest1++;

                            }
                            else
                            {
                                RevisionResultPythonFilesHest1.Add(new FileResultHest1("None", compiledSuccsesfully, execFileOutput, item, FilesTool.studentIDS[counterIDSstudensHest1], "CS kinneret"));
                                counterIDSstudensHest1++;
                            }

                        }
                        else
                        {

                            foreach (string inputCheck in FilesTool.inputToBeCheckedHest2)
                            {

                                (string execOutput, bool hasErrors, string ErrorsOnExec) = FilesExecuterHest2.executeFile(item, inputCheck);
                                if (hasErrors)
                                {
                                    (bool PassedTEstHest2, string ExpectedTestOutPut) = FilesTool.PassedHest2Test(execOutput, inputCheck);
                                    RevisionResultPythonFilesHest2.Add(new FileResultHest2(execOutput, hasErrors, ErrorsOnExec, PassedTEstHest2, Path.GetFileName(inputCheck), item, FilesTool.studentIDS[counterIDSstudensHest1], ExpectedTestOutPut, "Computer Science"));
                                    counterIDSstudensHest1++;
                                }

                                else
                                {
                                    RevisionResultPythonFilesHest2.Add(new FileResultHest2("none", hasErrors, execOutput, false, "none", item, FilesTool.studentIDS[counterIDSstudensHest1], "None", "Computer Science"));
                                    counterIDSstudensHest1++;

                                }
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

        /// <summary>method <c>ResultsToExcelHest1</c>Writes the results into a Excel file.</summary>
        [ExcludeFromCodeCoverage]
        private void ResultsToExcelHest1(List<FileResultHest1> myListToExcel, string fileType)
        {
            /// <summary>method <c>draw</c> renders the point.</summary>

            DataTable tableFromList = ConvertListToDataTableHest1(myListToExcel);
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
                //   sheet[1, 3].Text = "File Name";
                sheet[1, 3].Text = "Departament";
                sheet[1, 4].Text = "Compiled Successfully";
                sheet[1, 5].Text = "Compiler errors";
                sheet[1, 6].Text = "File's output";
                // sheet[1, 8].Text = "Expected Output";
                // sheet[1, 9].Text = "Passed HEST2";

                //Create a dataset from XML file
                //DataSet customersDataSet = new DataSet();
                //customersDataSet.ReadXml(Path.GetFullPath(@"../../Data/Employees.xml"));

                //Create datatable from the dataset
                // DataTable dataTable = new DataTable();
                // dataTable = customersDataSet.Tables[0];

                //Import data from the data table with column header, at first row and first column, 
                //and by its column type.
                sheet.ImportDataTable(tableFromList, false, 2, 1, true);

                //Creating Excel table or list object and apply style to the table
                Syncfusion.XlsIO.IListObject Table = sheet.ListObjects.Create("Employee_PersonalDetails", sheet.UsedRange);

                Table.BuiltInTableStyle = Syncfusion.XlsIO.TableBuiltInStyles.TableStyleMedium14;

                //Autofit the columns
                sheet.UsedRange.AutofitColumns();

                //Save the file in the given path
                Stream excelStream = File.Create(Path.GetFullPath($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\OutPutExcelHest1_{fileType}.xlsx"));
                workbook.SaveAs(excelStream);
                excelStream.Dispose();
            }

        }
        [ExcludeFromCodeCoverage]
        private void ResultsToExcelHest2(List<FileResultHest2> myListToExcel, string fileType)
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
                sheet[1, 3].Text = "Departament";
                sheet[1, 4].Text = "Compiled Successfully";
                sheet[1, 5].Text = "Compiler errors";
                sheet[1, 6].Text = "File's output";
                sheet[1, 7].Text = "Expected Output";
                sheet[1, 8].Text = "Passed HEST2";
                sheet[1, 9].Text = "Test file";



                //Create a dataset from XML file
                //DataSet customersDataSet = new DataSet();
                //customersDataSet.ReadXml(Path.GetFullPath(@"../../Data/Employees.xml"));

                //Create datatable from the dataset
                // DataTable dataTable = new DataTable();
                // dataTable = customersDataSet.Tables[0];

                //Import data from the data table with column header, at first row and first column, 
                //and by its column type.
                sheet.ImportDataTable(tableFromList, false, 2, 1, true);

                //Creating Excel table or list object and apply style to the table
                Syncfusion.XlsIO.IListObject Table = sheet.ListObjects.Create("Employee_PersonalDetails", sheet.UsedRange);

                Table.BuiltInTableStyle = Syncfusion.XlsIO.TableBuiltInStyles.TableStyleMedium14;

                //Autofit the columns
                sheet.UsedRange.AutofitColumns();

                //Save the file in the given path
                Stream excelStream = File.Create(Path.GetFullPath($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\OutPutExcelHest2_{fileType}.xlsx"));
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
            foreach (FileResultHest1 item in RevisionResultCfilesHest1)
            {
                if (item.Errors.Length > 0) { ++CerrorIndex; }

            }
            foreach (var item in RevisionResultPythonFilesHest1)
            {
                if (item.Errors.Length > 0) { ++PythonErrorIndex; }

            }
            foreach (var item in RevisionResultJavaFilesHest1)
            {
                if (item.Errors.Length > 0) { ++JavaErrorIndex; }

            }
            labelErrorsCfiles.Text = $"{Convert.ToString(CerrorIndex)}";
            labelErrorPython.Text = $"{Convert.ToString(PythonErrorIndex)}";
            labelErrorJavaFiles.Text = $"{Convert.ToString(JavaErrorIndex)}";


        }
        /// <summary>method <c>ConvertListToDataTableHest1</c>Return dataTable with all values to be written into the Excel File.</summary>
        [ExcludeFromCodeCoverage]
        private void CountFilesDragged()
        {
            labelNumberFilesDragged.Text = listBox1DragFiles.Items.Count.ToString();
        }
        [ExcludeFromCodeCoverage]
        static DataTable ConvertListToDataTableHest1(List<FileResultHest1> list)
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
            // table.Rows.Add("File name", "StudentID", "Department", "Compiled Successfully", "Errors", "File's output");
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
            int columns = 9;

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
            // table.Rows.Add("File name", "StudentID", "Department", "Compiled Successfully", "Compiler errors", "File's output");
            // Add rows.
            foreach (var array in list)
            {
                table.Rows.Add(array.FileName, array.StudenId, array.Department, array.Compiled.ToString(), array.Errors, array.FileOutput, array.UserDefinedExpectedOutPut, array.Hest2PassedTest, array.InputBeingCheck);
            }

            return table;
        }
        [ExcludeFromCodeCoverage]
        private void Button4GenerateReport_Click(object sender, EventArgs e)
        {
            if (isHest1)
            {
                if (checkBoxCfiles.Checked)
                {
                    ResultsToExcelHest1(RevisionResultCfilesHest1, "CFiles");
                }
                if (checkBoxJavaFiles.Checked)
                {
                    ResultsToExcelHest1(RevisionResultJavaFilesHest1, "JavaFiles");
                }
                if (checkBoxPythonFiles.Checked)
                {
                    ResultsToExcelHest1(RevisionResultPythonFilesHest1, "PyhonFiles");
                }


            }
            else
            {

                if (checkBoxCfiles.Checked)
                {
                    ResultsToExcelHest2(RevisionResultCfilesHest2, "CFiles_HEST2");
                }
                if (checkBoxJavaFiles.Checked)
                {
                    ResultsToExcelHest2(RevisionResultJavaFilesHest2, "JavaFiles_HEST2");
                }
                if (checkBoxPythonFiles.Checked)
                {
                    ResultsToExcelHest2(RevisionResultPythonFilesHest2, "PyhtonFiles_HEST2");
                }
            }
        }
        [ExcludeFromCodeCoverage]
        private async void Button1Hest2EvalueateFiles_ClickAsync(object sender, EventArgs e)
        {
            this.isHest1 = false;
            progressBar1.Visible = true;
            label15WorkingOn.Visible = true;
            progressBar1.Style = ProgressBarStyle.Marquee;
            //btnImport.Enabled = false;
            await Task.Run(() => ExecCheckedFiles());
            progressBar1.Visible = false;
            label15WorkingOn.Visible = false;
            //ExecCheckedFiles();
            NextPanelBehav();

        }
        [ExcludeFromCodeCoverage]

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
        [ExcludeFromCodeCoverage]

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
        [ExcludeFromCodeCoverage]

        private void button1ClearListBoxHest2In_Click(object sender, EventArgs e)
        {
            listBox1Hest2InputParam.Items.Clear();
        }
        [ExcludeFromCodeCoverage]

        private void button1ClearListBoxHest2Output_Click(object sender, EventArgs e)
        {
            listBox2Hest2Output.Items.Clear();

        }
        [ExcludeFromCodeCoverage]

        private void button1ClearFilesDragger_Click(object sender, EventArgs e)
        {
            listBox1DragFiles.Items.Clear();
        }


    }
}
