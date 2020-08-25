using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace HomeWorkCheckApp
{
    /// <summary>Class <c>FilesTool</c> Allows to handle different functionality from the files to be checked.
    /// </summary>
    ///
    static class FilesTool
    {
        public static string[] filesToCheck;
        /// <summary>method <c>processFileOutPut</c> returns the text of the file being read.</summary>

        public static string processFileOutPut(string myFilePath)
        {

            // This text is added only once to the file.
            if (!File.Exists(myFilePath))
            {
                // Create a file to write to.
                MessageBox.Show($"File: {myFilePath}. \r Does not Exist. \r Please Contact the EYA Support Team");

            }
            // Open the file to read from.
            string readText = File.ReadAllText(myFilePath);
            return readText;
        }

    }
    /// <summary>Class <c>OrderedFiles</c> Data Structure for the files to be organized. 
    /// </summary>
    ///
    class OrderedFiles
    {
        public List<string> cFiles = new List<string>();
        public List<string> pythonFiles = new List<string>();
        public List<string> javaFiles = new List<string>();
    }
    /// <summary>Class <c>FileResult</c> Data Structure for the test results. 
    /// </summary>
    ///
    class FileResult
    {
        public string FileName { get; set; }
        public string StudenId { get; set; }
        public string Department { get; set; }
        public bool Compiled { get; set; }
        public string Errors { get; set; }
        public string FileOutput { get; set; }
        public bool Hest2PassedTest { get; set; }
        public string UserDefinedExpectedOutPut { get; set; }

        public FileResult() { }
        public FileResult(string MyFileName, string myStudenId,string myDept, bool Comp, string MyErr, string FileOut)
        {
            FileName = MyFileName;
            StudenId = myStudenId;
            Department = myDept;
            Compiled = Comp;
            Errors = MyErr;
            FileOutput = FileOut;
            PassHest2();
        }
        public FileResult(string MyErr, string FileOut)
        {
            Errors = MyErr;
            FileOutput = FileOut;
            PassHest2();

        }
        public FileResult(string MyErr, string FileOut, string UserDefinedOutPut)
        {
            Errors = MyErr;
            FileOutput = FileOut;
            UserDefinedExpectedOutPut = UserDefinedOutPut;
            PassHest2();

        }

        public void PassHest2()
        {
            if (UserDefinedExpectedOutPut.Equals(FileOutput))
            {
                Hest2PassedTest = true;
            }
            else
            {
                Hest2PassedTest = false;
            }
        }
    }
   

    /// <summary>Class <c>LanguageRecognizion</c> Divides files by language and adds them to the correspondent list. 
    /// </summary>
    ///
    static class LanguageRecognizion
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
}
