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
        //Files input to be checked HEST2
        public static string[] inputToBeCheckedHest2;
        //Tests to perform in Hest 2
        public static string[] testsToPerformHest2;

        public static bool PassedHest2Test(string ExecuteOutput, string InputCheckPath)
        {
            string fileNameIn = Path.GetFileNameWithoutExtension(InputCheckPath);
            char numberFileInputChar = 's';
            string outPutPath = "";

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
                return true;
            }
            else
            {
                return false;
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

        public FileResultHest1(string fileOutPut, bool compiledSuccessfuly, string ErrorsFile)
        {
            Compiled = compiledSuccessfuly;
            FileOutput = fileOutPut;
            Errors = ErrorsFile;

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

        public FileResultHest2(string executionOutPut, bool hasErrors, string executionErrors, bool passedHest2, string inputBeingChecked)
        {

            Compiled = hasErrors;
            Errors = executionErrors;
            FileOutput = executionOutPut;
            Hest2PassedTest = passedHest2;
            InputBeingCheck = inputBeingChecked;
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
