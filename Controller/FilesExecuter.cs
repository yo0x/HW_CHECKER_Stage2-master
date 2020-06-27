using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropFilesTest1
{
    static class FilesExecuterHest1
    {

        public static (string compilerOutPut, string execFileOutput) executeFile(string myFileToExec)
        {
            string fileCompOutPut = $"{ Path.GetTempPath() }\\comp.output";
            string fileExecOutPut = $"{ Path.GetTempPath() }\\file.output";
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string dirOutPutToCompiledFiles = $"{desktopPath}\\HwOutput";
            string commadToCompiler = "";
            string commadToExecuteFile = "";


            if (!Directory.Exists(dirOutPutToCompiledFiles))
            {
                Directory.CreateDirectory(dirOutPutToCompiledFiles);
            }

            if (Path.GetExtension(myFileToExec).Equals(".c"))
            {
                string commandCfiles = $"/c gcc -o {dirOutPutToCompiledFiles}\\{Path.GetFileNameWithoutExtension(myFileToExec)} {myFileToExec} 2> {fileCompOutPut}";
                string commandExeCompCFile = $"/c {dirOutPutToCompiledFiles}\\{Path.GetFileNameWithoutExtension(myFileToExec)}.exe > {fileExecOutPut}";
                commadToCompiler = commandCfiles;
                commadToExecuteFile = commandExeCompCFile;
            }
            else if (Path.GetExtension(myFileToExec).Equals(".py"))
            {
                string commandCfiles = $"/c python {myFileToExec} 2> {fileCompOutPut}";
                string commandExeCompCFile = $"/c python {myFileToExec} > {fileExecOutPut}";
                commadToCompiler = commandCfiles;
                commadToExecuteFile = commandExeCompCFile;
            }
            else if (Path.GetExtension(myFileToExec).Equals(".java"))
            {
                string commandCfiles = $"/c javac -d {dirOutPutToCompiledFiles} {myFileToExec} 2> {fileCompOutPut}";
                string commandExeCompCFile = $"/c java {dirOutPutToCompiledFiles}\\{Path.GetFileNameWithoutExtension(myFileToExec)}.class 2> {fileExecOutPut}";
                commadToCompiler = commandCfiles;
                commadToExecuteFile = commandExeCompCFile;
            }




            try
            {
                Process proc = new Process();
                Process procExecFile = new Process();
                proc.StartInfo.FileName = "cmd";
                proc.StartInfo.Arguments = commadToCompiler;
                proc.StartInfo.UseShellExecute = false;
                proc.Start();
                proc.WaitForExit();
                procExecFile.StartInfo.FileName = "cmd";
                procExecFile.StartInfo.Arguments = commadToExecuteFile;
                procExecFile.StartInfo.UseShellExecute = false;
                procExecFile.Start();
                procExecFile.WaitForExit();
                return (compilerOutPut: FilesTool.processFileOutPut(fileCompOutPut), execFileOutput: FilesTool.processFileOutPut(fileExecOutPut));
            }
            catch (Exception objException)
            {
                // Log the exception
                return (compilerOutPut: $"error {objException.ToString()}", execFileOutput: "error");
            }
        }

    }
}
