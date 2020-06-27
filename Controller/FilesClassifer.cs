using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DropFilesTest1
{
    static class FilesTool
    {
        public static string[] filesToCheck;

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

    class OrderedFiles
    {
        public List<string> cFiles = new List<string>();
        public List<string> pythonFiles = new List<string>();
        public List<string> javaFiles = new List<string>();
    }
    static class LanguageRecognizion
    {




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
