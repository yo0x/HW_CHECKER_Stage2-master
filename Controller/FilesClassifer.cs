using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DropFilesTest1
{
    static class FilesTool
    {
       public static string[] filesToCheck;

    }

    class OrderedFiles
    {
        public  List<string> cFiles = new List<string>();
        public List<string> pythonFiles = new List<string>();
        public List<string> javaFiles = new List<string>();
    }
    static class FilesClassifer
    {
       



        public static OrderedFiles classiferProgLang(string[] myFilesToOrder)
        {
            OrderedFiles orderedFilesByLang = new OrderedFiles();
            orderedFilesByLang.cFiles = new List<string>();
            foreach (string item in myFilesToOrder)
            {
                if(Path.GetFileName(item).Contains(".c"))
                {
                    orderedFilesByLang.cFiles.Add(item);
                }
                if (Path.GetFileName(item).Contains(".py"))
                {
                    orderedFilesByLang.pythonFiles.Add(item);
                }
                if (Path.GetFileName(item).Contains(".java"))
                {
                    orderedFilesByLang.javaFiles.Add(item);
                }
            }


            return orderedFilesByLang;
        }
    }
}
