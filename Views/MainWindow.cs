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
namespace DropFilesTest1
{
    public partial class MainWindow : Form
    {

        List<Panel> listPanel = new List<Panel>();
        List<FileResult> RevisionResultCfiles = new List<FileResult>();
        List<FileResult> RevisionResultJavaFiles = new List<FileResult>();
        List<FileResult> RevisionResultPythonFiles = new List<FileResult>();
        OrderedFiles MyOF = new OrderedFiles();

        int IndexFile = 0;
        int PanelIndex;
        public MainWindow()
        {
            InitializeComponent();
        }

   
        private void RichTextBoxDropFiles_DragDrop(object sender, DragEventArgs e)
        {
           
            
        }
        private void Button1CheckFiles_Click(object sender, EventArgs e)
        {
            FilesOverview fo = new FilesOverview();
            fo.Show();
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
        private void Label2_Click(object sender, EventArgs e)
        {

        }
        private void Label7_Click(object sender, EventArgs e)
        {

        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            listPanel.Add(PanelSignIn);
            listPanel.Add(panelDragFiles);
            listPanel.Add(panelFilesOverView);
            listPanel.Add(panelSelectMode);
            listPanel.Add(panelResultsWindow);
            listPanel[PanelIndex].BringToFront();

        }
        private void ButtonNextPanel_Click(object sender, EventArgs e)
        {
            NextPanelBehav();
        }
        private void ButtonExitPro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ButtonBackSFW_Click(object sender, EventArgs e)
        {
            PrevPanel();
        }
        public void NextPanelBehav()
        {
            switch (PanelIndex)
            {
                case 0:
                    NextPanel();
                    buttonNextPanel.Visible = true;
                    buttonExitProgramEND.Visible = false;
                    break;
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
                case 2:
                    NextPanel();
                    //PopulateResultsPreview();
                    buttonNextPanel.Visible = false;

                    break;
                case 3:
                    NextPanel();
                    PopulateResultsPreview();

                    buttonExitProgramEND.Visible = true;

                    break;
                case 4:
                    break;
                default:
                    break;
            }

         
        }
        public void NextPanel()
        {
            if (PanelIndex < listPanel.Count - 1)
                listPanel[++PanelIndex].BringToFront();
        }
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
            ExecCheckedFiles();
            label5SummaryFilesHEST1HEST2.Text = "RESULTS FOR THE HEST-1 METHOD.";
            NextPanelBehav();

        }
        private void ButtonExitProgramEND_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ButtonSelectedHEST2_Click(object sender, EventArgs e)
        {
            NextPanelBehav();
            label5SummaryFilesHEST1HEST2.Text = "RESULTS FOR THE HEST-2 METHOD.";
        }
        private void ListBox1DragFiles_DragEnter_1(object sender, DragEventArgs e)
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
        private OrderedFiles ClasssifiesAndLoadsFiles()
        {
            OrderedFiles myOrderedFiles = new OrderedFiles();
            myOrderedFiles = LanguageRecognizion.classifierProgLang(FilesTool.filesToCheck);
            // label4NumCfiles.Text = Convert.ToString(myOrderedFiles.cFiles.Count);
            return myOrderedFiles;
        }
        private void executeGivenFiles(int caseSwitch)
        {
            OrderedFiles myOrderedFiles = new OrderedFiles();
            myOrderedFiles = LanguageRecognizion.classifierProgLang(FilesTool.filesToCheck);
            switch (caseSwitch)
            {
                case 1:
                    foreach (string item in myOrderedFiles.cFiles)
                    {
                        (string compilerOutPut, string execFileOutput) = FilesExecuterHest1.executeFile(item);
                        //.executeFile(item);

                        // MessageBox.Show($"Compiler out put:{compilerOutPut}   \n\n   exeFileOutPut:{execFileOutput}");
                        RevisionResultCfiles.Add(new FileResult(compilerOutPut, execFileOutput));

                    }
                    break;
                case 2:
                    foreach (string item in myOrderedFiles.javaFiles)
                    {
                        (string compilerOutPut, string execFileOutput) = FilesExecuterHest1.executeFile(item);
                        //.executeFile(item);

                        // MessageBox.Show($"Compiler out put: {compilerOutPut}   \r\n\n   exeFileOutPut:{execFileOutput}");
                        RevisionResultJavaFiles.Add(new FileResult(compilerOutPut, execFileOutput));


                    }
                    break;
                case 3:
                    foreach (string item in myOrderedFiles.pythonFiles)
                    {
                        (string compilerOutPut, string execFileOutput) = FilesExecuterHest1.executeFile(item);
                        //.executeFile(item);

                        // MessageBox.Show($"Compiler out put:{compilerOutPut}   \n\n   exeFileOutPut:{execFileOutput}");
                        RevisionResultPythonFiles.Add(new FileResult(compilerOutPut, execFileOutput));


                    }
                    break;
                default:
                    Console.WriteLine("Error, contact support");
                    break;
            }




        }
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
        private void ResultsToExcel()
        {
        DataTable table = new DataTable();
            using (var reader = FastMember.ObjectReader.Create(RevisionResultCfiles))
            {
                table.Load(reader);
            }
            using (Syncfusion.XlsIO.ExcelEngine excelEngine = new Syncfusion.XlsIO.ExcelEngine())
            {
                Syncfusion.XlsIO.IApplication application = excelEngine.Excel;
                application.DefaultVersion = Syncfusion.XlsIO.ExcelVersion.Excel2016;

                //Create a new workbook
                Syncfusion.XlsIO.IWorkbook workbook = application.Workbooks.Create(1);
                Syncfusion.XlsIO.IWorksheet sheet = workbook.Worksheets[0];

                //Create a dataset from XML file
                DataSet customersDataSet = new DataSet();
                customersDataSet.ReadXml(Path.GetFullPath(@"../../Data/Employees.xml"));

                //Create datatable from the dataset
                DataTable dataTable = new DataTable();
                dataTable = customersDataSet.Tables[0];

                //Import data from the data table with column header, at first row and first column, 
                //and by its column type.
                sheet.ImportDataTable(dataTable, true, 1, 1, true);

                //Creating Excel table or list object and apply style to the table
                Syncfusion.XlsIO.IListObject Table = sheet.ListObjects.Create("Employee_PersonalDetails", sheet.UsedRange);

                Table.BuiltInTableStyle = Syncfusion.XlsIO.TableBuiltInStyles.TableStyleMedium14;

                //Autofit the columns
                sheet.UsedRange.AutofitColumns();

                //Save the file in the given path
                Stream excelStream = File.Create(Path.GetFullPath(@"Output.xlsx"));
                workbook.SaveAs(excelStream);
                excelStream.Dispose();
            }

        } 
        private void PopulateResultsPreview()
        {
            int CerrorIndex =0;
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
            labelErrorsCfiles .Text = $"{Convert.ToString(CerrorIndex)}";
            labelErrorPython.Text = $"{Convert.ToString(PythonErrorIndex)}";
            labelErrorJavaFiles.Text = $"{Convert.ToString(JavaErrorIndex)}";


        }

    }
}
