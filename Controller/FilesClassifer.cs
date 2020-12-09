using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HomeWorkCheckApp
{
    /// <summary>Class <c>FilesTool</c> Allows to handle different functionality from the files to be checked.
    /// </summary>
    ///
    public static class FilesTool
    {
        public static string[] filesToCheck;
        public static string[] studentIDS;
        //Files input to be checked HEST2
        public static string[] inputToBeCheckedHest2;
        //Tests to perform in Hest 2
        public static string[] testsToPerformHest2;

        public static (bool isEqualhest2, string ExpectedOutPutHest2) PassedHest2Test(string ExecuteOutput, string InputCheckPath)
        {
            string fileNameIn = Path.GetFileNameWithoutExtension(InputCheckPath);
            char numberFileInputChar = 's';
            string outPutPath = "";
            string outPutExepectedTest = "";

            for (int i = 0; i < fileNameIn.Length; i++)
            {
                if (Char.IsDigit(fileNameIn[i]))
                {
                    numberFileInputChar = fileNameIn[i];
                    break;
                }

            }


            foreach (string item in testsToPerformHest2)
            {
                string a = Path.GetFileNameWithoutExtension(item);
                for (int i = 0; i < a.Length; i++)
                {
                    if (Char.IsDigit(a[i]) && numberFileInputChar.Equals(a[i]))
                    {
                        outPutPath = item;
                        outPutExepectedTest = processFileOutPut(item);
                        break;
                    }

                }
            }

            string OutPutPathContent = processFileOutPut(outPutPath);


            string normalized1 = Regex.Replace(OutPutPathContent, @"\s", "");
            string normalized2 = Regex.Replace(ExecuteOutput, @"\s", "");

            bool stringEquals = String.Equals(
                normalized1,
                normalized2,
                StringComparison.OrdinalIgnoreCase);

            if (stringEquals)
            {
                return (true, outPutExepectedTest);
            }
            else
            {
                return (false, outPutExepectedTest);
            }
        }
        /// <summary>method <c>processFileOutPut</c> returns the text of the file being read.</summary>

        public static string processFileOutPut(string myFilePath)
        {

            // This text is added only once to the file.
            if (!File.Exists(myFilePath))
            {
                // Create a file to write to.
                MessageBox.Show($"File: {myFilePath}. \r Does not Exist. \r Please Contact the EYA Support Team");
                return "404";
            }
            // Open the file to read from.
            string readText = File.ReadAllText(myFilePath);
            return readText;
        }

        public static string[] RenameDraggedFiles(string[] myDraggedFiles)
        {
            string desktopPathEnv = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}";
            string HwOutputFiles = $"{desktopPathEnv}\\noheb";
            _ = Directory.CreateDirectory(HwOutputFiles);
            List<string> tempFiles = new List<string>();
           
            
            
            
            foreach (string item in myDraggedFiles)
            {
                var resultStudenIdNoHeb = Regex.Replace(item, @"\p{IsHebrew}", string.Empty);
                var resultStudenNoHebNoSpaces = Regex.Replace(resultStudenIdNoHeb, @"\s+", String.Empty);
                var fileNameWithEx = Path.GetFileName(item);
                string newItemLocation = resultStudenNoHebNoSpaces.Replace(desktopPathEnv, HwOutputFiles);
               // string newItemLocationCompletePath = $"{ newItemLocation }\\{fileNameWithEx}";
                Directory.Move(item, newItemLocation);
                //_ = Directory.CreateDirectory(newItemLocation);

                if (Directory.Exists(newItemLocation))
                {
                    string[] FilesInDir = Directory.GetFiles(newItemLocation);

                    foreach (var item2 in FilesInDir)
                    {
                        string lastFolderNameStudenID = new DirectoryInfo(newItemLocation).Name;

                        var fileNoHeb = Regex.Replace(Path.GetFileName(item2), @"\p{IsHebrew}", string.Empty);
                        var FileNoHenbAndNoSpaces = Regex.Replace(fileNoHeb, @"\s+", String.Empty);
                        var fileNewPath = $"{HwOutputFiles}\\{lastFolderNameStudenID}\\{FileNoHenbAndNoSpaces}";
                        //if (!item2.Equals(fileNewPath))
                        File.Move(item2, fileNewPath);
                        tempFiles.Add(fileNewPath);

                    }
                }
                else
                {
                    File.Move(item, newItemLocation);


                    tempFiles.Add(item);


                }




                tempFiles.Add(item);
            }

            return tempFiles.ToArray();
        }
    }
    /// <summary>Class <c>OrderedFiles</c> Data Structure for the files to be organized. 
    /// </summary>
    ///
    public class OrderedFiles
    {
        public List<string> cFiles = new List<string>();
        public List<string> pythonFiles = new List<string>();
        public List<string> javaFiles = new List<string>();
    }
    /// <summary>Class <c>FileResultHest1</c> Data Structure for the test results. 
    /// </summary>
    ///
    public class FileResultHest1
    {
        public string FileName { get; set; }
        public string StudenId { get; set; }
        public string Department { get; set; }
        public bool Compiled { get; set; }
        public string Errors { get; set; }
        public string FileOutput { get; set; }

        public FileResultHest1() { }

        public FileResultHest1(string fileOutPut, bool compiledSuccessfuly, string ErrorsFile, string myFileName, string myStudentID, string myDept)
        {
            Compiled = compiledSuccessfuly;
            FileOutput = fileOutPut;
            Errors = ErrorsFile;
            FileName = myFileName;
            StudenId = myStudentID;
            Department = myDept;

        }


    }
    public class FileResultHest2
    {
        public string FileName { get; set; }
        public string StudenId { get; set; }
        public string Department { get; set; }
        public bool Compiled { get; set; }
        public string Errors { get; set; }
        public string FileOutput { get; set; }
        public bool Hest2PassedTest { get; set; }
        public string UserDefinedExpectedOutPut { get; set; }
        public string InputBeingCheck { get; set; }

        public FileResultHest2() { }

        public FileResultHest2(string executionOutPut, bool hasErrors, string executionErrors, bool passedHest2, string inputBeingChecked, string myFileName, string myStudenID, string ExepecetedOutPutFile, string myDepartment)
        {

            Compiled = hasErrors;
            Errors = executionErrors;
            FileOutput = executionOutPut;
            Hest2PassedTest = passedHest2;
            InputBeingCheck = inputBeingChecked;
            FileName = myFileName;
            StudenId = myStudenID;
            UserDefinedExpectedOutPut = ExepecetedOutPutFile;
            Department = myDepartment;
        }


    }
    public static class LanguageRecognizion
    {


        /// <summary>method <c>classifierProgLang</c> orders by extension.</summary>


        public static OrderedFiles classifierProgLang(string[] myFilesToOrder)
        {
            OrderedFiles orderedFilesByLang = new OrderedFiles();
            orderedFilesByLang.cFiles = new List<string>();
            foreach (string item in myFilesToOrder)
            {
                if (Path.GetExtension(item).Equals(".c"))
                {
                    orderedFilesByLang.cFiles.Add(item);
                }
                if (Path.GetExtension(item).Equals(".py"))
                {
                    orderedFilesByLang.pythonFiles.Add(item);
                }
                if (Path.GetExtension(item).Equals(".java"))
                {
                    orderedFilesByLang.javaFiles.Add(item);
                }
            }


            return orderedFilesByLang;
        }
    }
    //public class Input
}
