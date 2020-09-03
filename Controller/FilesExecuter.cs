using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCheckApp
{


    public static class FilesExecuterHest1
    {

        public static (string compilerOutPut, bool compiledSuccessfully) compileFile(string myFileToExec)
        {
            string fileCompOutPut = $"{ Path.GetTempPath() }\\comp.output";
            string fileExecOutPut = $"{ Path.GetTempPath() }\\file.output";
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string dirOutPutToCompiledFiles = $"{desktopPath}\\HwOutput";
            string commadToCompiler = "";
            string argumentsToCompiler = "";
            string cComp = "gcc.exe";
            string JavaComp = "javac.exe";
            string PythonComp = "python.exe";
            string compilerUsed = "";
            if (!Directory.Exists(dirOutPutToCompiledFiles))
            {
                Directory.CreateDirectory(dirOutPutToCompiledFiles);
            }
            using (Process myProcess = new Process())
            {


                if (Path.GetExtension(myFileToExec).Equals(".c"))
                {
                    string commandCfiles = $" -o {dirOutPutToCompiledFiles}\\{Path.GetFileNameWithoutExtension(myFileToExec)} {myFileToExec}";
                    argumentsToCompiler = commandCfiles;
                    compilerUsed = cComp;

                }
                else if (Path.GetExtension(myFileToExec).Equals(".py"))
                {
                    string commandCfiles = $"{myFileToExec}";
                    argumentsToCompiler = commandCfiles;
                    compilerUsed = PythonComp;
              
                }
                else if (Path.GetExtension(myFileToExec).Equals(".java"))
                {
                    string commandCfiles = $"-d {dirOutPutToCompiledFiles} {myFileToExec}";
                    argumentsToCompiler = commandCfiles;
                    compilerUsed = JavaComp;
                }


                myProcess.StartInfo.FileName = compilerUsed;
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.RedirectStandardError = true;
                myProcess.StartInfo.RedirectStandardInput = true;
                myProcess.StartInfo.RedirectStandardOutput = true;
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.StartInfo.Arguments = argumentsToCompiler;
                myProcess.Start();
                if (myProcess.StandardOutput.ReadToEnd().Equals(null))
                {
                    return ("Done", true);
                }
                else
                {
                    return (myProcess.StandardError.ReadToEnd(), false);
                }

            }
        }


        public static (string compilerOutPut, string execFileOutput, bool compiledSuccessfully) executeFile(string myFileToExec)
        {
            using (Process myProcess = new Process())
            {
                myProcess.StartInfo.FileName = myFileToExec;
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.RedirectStandardError = true;
               // myProcess.StartInfo.RedirectStandardInput = true;
                myProcess.StartInfo.RedirectStandardOutput = true;
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.Start();
                if(myProcess.StandardOutput.ReadToEnd().Equals(null))
                {
                    return (myProcess.StandardError.ReadToEnd(), myProcess.StandardOutput.ReadToEnd(), true);

                }else
                {
                    return (myProcess.StandardError.ReadToEnd() , myProcess.StandardOutput.ReadToEnd(), false);

                }

            }
        }

        //public static (string compilerOutPut, string execFileOutput, bool compiledSuccessfully) executeFile(string myFileToExec)
        //{
        //    string fileCompOutPut = $"{ Path.GetTempPath() }\\comp.output";
        //    string fileExecOutPut = $"{ Path.GetTempPath() }\\file.output";
        //    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        //    string dirOutPutToCompiledFiles = $"{desktopPath}\\HwOutput";
        //    string commadToCompiler = "";
        //    string commadToExecuteFile = "";


        //    if (!Directory.Exists(dirOutPutToCompiledFiles))
        //    {
        //        Directory.CreateDirectory(dirOutPutToCompiledFiles);
        //    }

        //    if (Path.GetExtension(myFileToExec).Equals(".c"))
        //    {
        //        string commandCfiles = $"/c gcc -o {dirOutPutToCompiledFiles}\\{Path.GetFileNameWithoutExtension(myFileToExec)} {myFileToExec} 2> {fileCompOutPut}";
        //        string commandExeCompCFile = $"/c {dirOutPutToCompiledFiles}\\{Path.GetFileNameWithoutExtension(myFileToExec)}.exe > {fileExecOutPut}";
        //        commadToCompiler = commandCfiles;
        //        commadToExecuteFile = commandExeCompCFile;
        //    }
        //    else if (Path.GetExtension(myFileToExec).Equals(".py"))
        //    {
        //        string commandCfiles = $"/c python {myFileToExec} 2> {fileCompOutPut}";
        //        string commandExeCompCFile = $"/c python {myFileToExec} > {fileExecOutPut}";
        //        commadToCompiler = commandCfiles;
        //        commadToExecuteFile = commandExeCompCFile;
        //    }
        //    else if (Path.GetExtension(myFileToExec).Equals(".java"))
        //    {
        //        string commandCfiles = $"/c javac -d {dirOutPutToCompiledFiles} {myFileToExec} 2> {fileCompOutPut}";
        //        string commandExeCompCFile = $"/c java {dirOutPutToCompiledFiles}\\{Path.GetFileNameWithoutExtension(myFileToExec)}.class 2> {fileExecOutPut}";
        //        commadToCompiler = commandCfiles;
        //        commadToExecuteFile = commandExeCompCFile;
        //    }




        //    try
        //    {
        //        Process proc = new Process();
        //        Process procExecFile = new Process();
        //        proc.StartInfo.FileName = "cmd";
        //        proc.StartInfo.Arguments = commadToCompiler;
        //        proc.StartInfo.UseShellExecute = false;
        //        proc.Start();
        //        proc.WaitForExit();
        //        procExecFile.StartInfo.FileName = "cmd";
        //        procExecFile.StartInfo.Arguments = commadToExecuteFile;
        //        procExecFile.StartInfo.UseShellExecute = false;
        //        procExecFile.Start();
        //        procExecFile.WaitForExit();


        //        if (FilesTool.processFileOutPut(fileExecOutPut).Equals(""))
        //        {
        //            return (compilerOutPut: FilesTool.processFileOutPut(fileCompOutPut), execFileOutput: FilesTool.processFileOutPut(fileExecOutPut), compiledSuccessfully: true);
        //        }
        //        else
        //        {
        //            return (compilerOutPut: FilesTool.processFileOutPut(fileCompOutPut), execFileOutput: FilesTool.processFileOutPut(fileExecOutPut), compiledSuccessfully: false);
        //        }

               
        //    }
        //    catch (Exception objException)
        //    {
        //        // Log the exception
        //        return (compilerOutPut: $"error {objException.ToString()}", execFileOutput: "error", false);
        //    }
        //}

    }

    public static class FilesExecuterHest2
    {

        //public static string executeFile(string myFileToExec, string fileParameters)
        //{

        //}


        //public static string executeFile(string myFileToExec, string fileParameters)
        //{
        //    string fileCompOutPut = $"{ Path.GetTempPath() }\\comp.output";
        //    string fileExecOutPut = $"{ Path.GetTempPath() }\\file.output";
        //    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        //    string dirOutPutToCompiledFiles = $"{desktopPath}\\HwOutput";
        //   // string commadToCompiler = "";
        //    string commadToExecuteFile = "";


        //    if (!Directory.Exists(dirOutPutToCompiledFiles))
        //    {
        //        Directory.CreateDirectory(dirOutPutToCompiledFiles);
        //    }

        //    if (Path.GetExtension(myFileToExec).Equals(".c"))
        //    {
        //      //  string commandCfiles = $"/c gcc -o {dirOutPutToCompiledFiles}\\{Path.GetFileNameWithoutExtension(myFileToExec)} {myFileToExec} 2> {fileCompOutPut}";
        //        string commandExeCompCFile = $"/c {dirOutPutToCompiledFiles}\\{Path.GetFileNameWithoutExtension(myFileToExec)}.exe {fileParameters} > {fileExecOutPut}";
        //   //     commadToCompiler = commandCfiles;
        //        commadToExecuteFile = commandExeCompCFile;
        //    }
        //    else if (Path.GetExtension(myFileToExec).Equals(".py"))
        //    {
        //     //   string commandCfiles = $"/c python {myFileToExec} 2> {fileCompOutPut}";
        //        string commandExeCompCFile = $"/c python {myFileToExec} {fileParameters} > {fileExecOutPut}";
        //    //    commadToCompiler = commandCfiles;
        //        commadToExecuteFile = commandExeCompCFile;
        //    }
        //    else if (Path.GetExtension(myFileToExec).Equals(".java"))
        //    {
        //       // string commandCfiles = $"/c javac -d {dirOutPutToCompiledFiles} {myFileToExec} 2> {fileCompOutPut}";
        //        string commandExeCompCFile = $"/c java {dirOutPutToCompiledFiles}\\{Path.GetFileNameWithoutExtension(myFileToExec)} {fileParameters} 2> {fileExecOutPut}";

        //        //string commandExeCompCFile = $"/c java {dirOutPutToCompiledFiles}\\{Path.GetFileNameWithoutExtension(myFileToExec)}.class {fileParameters} 2> {fileExecOutPut}";
        //       // commadToCompiler = commandCfiles;
        //        commadToExecuteFile = commandExeCompCFile;
        //    }





        //    try
        //    {
        //        //Process proc = new Process();
        //        Process procExecFile = new Process();
        //        //proc.StartInfo.FileName = "cmd";
        //        //proc.StartInfo.Arguments = commadToCompiler;
        //        //proc.StartInfo.UseShellExecute = false;
        //        //proc.Start();
        //        //proc.WaitForExit();
        //        procExecFile.StartInfo.FileName = "cmd";
        //        procExecFile.StartInfo.Arguments = commadToExecuteFile;
        //        procExecFile.StartInfo.UseShellExecute = false;
        //        procExecFile.Start();
        //        procExecFile.WaitForExit();

        //        if (FilesTool.processFileOutPut(fileExecOutPut).Equals(fileParameters))
        //        {
        //            return FilesTool.processFileOutPut(fileCompOutPut);
        //        }
        //        else
        //        {
        //            return $"Error: {FilesTool.processFileOutPut(fileCompOutPut)}";

        //        }


        //    }
        //    catch (Exception objException)
        //    {
        //        // Log the exception
        //        return $"error {objException.ToString()}";
        //    }
        //}
        public static (string compilerOutPut, bool compiledSuccessfully) compileFile(string myFileToExec)
        {
            string fileCompOutPut = $"{ Path.GetTempPath() }\\comp.output";
            string fileExecOutPut = $"{ Path.GetTempPath() }\\file.output";
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string dirOutPutToCompiledFiles = $"{desktopPath}\\HwOutput";
            string commadToCompiler = "";
            string argumentsToCompiler = "";
            string cComp = "gcc.exe";
            string JavaComp = "javac.exe";
            string PythonComp = "python.exe";
            if (!Directory.Exists(dirOutPutToCompiledFiles))
            {
                Directory.CreateDirectory(dirOutPutToCompiledFiles);
            }
            using (Process myProcess = new Process())
            {
                

                if (Path.GetExtension(myFileToExec).Equals(".c"))
                {
                    string commandCfiles = $" -o {dirOutPutToCompiledFiles}\\{Path.GetFileNameWithoutExtension(myFileToExec)} {myFileToExec}";
                    argumentsToCompiler = commandCfiles;

                }
                else if (Path.GetExtension(myFileToExec).Equals(".py"))
                {
                    string commandCfiles = $"{myFileToExec}";
                    argumentsToCompiler = commandCfiles;
                }
                else if (Path.GetExtension(myFileToExec).Equals(".java"))
                {
                    string commandCfiles = $"-d {dirOutPutToCompiledFiles} {myFileToExec}";
                    argumentsToCompiler = commandCfiles;
                }


                myProcess.StartInfo.FileName = myFileToExec;
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.RedirectStandardError = true;
                myProcess.StartInfo.RedirectStandardInput = true;
                myProcess.StartInfo.RedirectStandardOutput = true;
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.StartInfo.Arguments = argumentsToCompiler;
                myProcess.Start();
                if (myProcess.StandardOutput.ReadToEnd().Equals(null))
                {
                    return ("Done",true);
                }
                else
                {
                    return (myProcess.StandardError.ReadToEnd(),false);
                }

            }
        }
        public static (string compilerOutPut, string execFileOutput, bool compiledSuccessfully) executeFile(string myFileToExec)
        {
            using (Process myProcess = new Process())
            {
                myProcess.StartInfo.FileName = myFileToExec;
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.RedirectStandardError = true;
                // myProcess.StartInfo.RedirectStandardInput = true;
                myProcess.StartInfo.RedirectStandardOutput = true;
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.Start();
                if (myProcess.StandardOutput.ReadToEnd().Equals(null))
                {
                    return (myProcess.StandardError.ReadToEnd(), myProcess.StandardOutput.ReadToEnd(), true);

                }
                else
                {
                    return (myProcess.StandardError.ReadToEnd(), myProcess.StandardOutput.ReadToEnd(), false);

                }

            }
        }

        //        public static (string compilerOutPut, bool compiledSuccessfully) compileFile(string myFileToExec)
        //        {
        //            string fileCompOutPut = $"{ Path.GetTempPath() }\\comp.output";
        //            string fileExecOutPut = $"{ Path.GetTempPath() }\\file.output";
        //            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        //            string dirOutPutToCompiledFiles = $"{desktopPath}\\HwOutput";
        //            string commadToCompiler = "";
        ////            string commadToExecuteFile = "";


        //            if (!Directory.Exists(dirOutPutToCompiledFiles))
        //            {
        //                Directory.CreateDirectory(dirOutPutToCompiledFiles);
        //            }

        //            if (Path.GetExtension(myFileToExec).Equals(".c"))
        //            {
        //                string commandCfiles = $"/c gcc -o {dirOutPutToCompiledFiles}\\{Path.GetFileNameWithoutExtension(myFileToExec)} {myFileToExec} 2> {fileCompOutPut}";
        //                //string commandExeCompCFile = $"/c {dirOutPutToCompiledFiles}\\{Path.GetFileNameWithoutExtension(myFileToExec)}.exe {fileParameters} > {fileExecOutPut}";
        //                commadToCompiler = commandCfiles;

        //                //commadToExecuteFile = commandExeCompCFile;
        //            }
        //            else if (Path.GetExtension(myFileToExec).Equals(".py"))
        //            {
        //                string commandCfiles = $"/c python {myFileToExec} 2> {fileCompOutPut}";
        //                //string commandExeCompCFile = $"/c python {myFileToExec} {fileParameters} > {fileExecOutPut}";
        //                commadToCompiler = commandCfiles;
        //                //commadToExecuteFile = commandExeCompCFile;
        //            }
        //            else if (Path.GetExtension(myFileToExec).Equals(".java"))
        //            {
        //                string commandCfiles = $"/c javac -d {dirOutPutToCompiledFiles} {myFileToExec} 2> {fileCompOutPut}";
        //                //string commandExeCompCFile = $"/c java {dirOutPutToCompiledFiles}\\{Path.GetFileNameWithoutExtension(myFileToExec)} {fileParameters} 2> {fileExecOutPut}";

        //                //string commandExeCompCFile = $"/c java {dirOutPutToCompiledFiles}\\{Path.GetFileNameWithoutExtension(myFileToExec)}.class {fileParameters} 2> {fileExecOutPut}";
        //                commadToCompiler = commandCfiles;
        //                //commadToExecuteFile = commandExeCompCFile;
        //            }





        //            try
        //            {
        //                ProcessStartInfo a = new ProcessStartInfo();
        //                Process proc = new Process();
        //               // Process procExecFile = new Process();
        //                proc.StartInfo.FileName = "cmd";
        //                proc.StartInfo.Arguments = commadToCompiler;
        //                proc.StartInfo.UseShellExecute = false;
        //                proc.Start();
        //                proc.WaitForExit();
        //                //procExecFile.StartInfo.FileName = "cmd";
        //                //procExecFile.StartInfo.Arguments = commadToExecuteFile;
        //                //procExecFile.StartInfo.UseShellExecute = false;
        //                //procExecFile.Start();
        //                //procExecFile.WaitForExit();
        //                if(FilesTool.processFileOutPut(fileCompOutPut).Equals(""))
        //                {
        //                    return (compilerOutPut: FilesTool.processFileOutPut(fileCompOutPut), compiledSuccessfully: true);
        //                }
        //                else
        //                {
        //                    return (compilerOutPut: $"Error: {FilesTool.processFileOutPut(fileCompOutPut)}", compiledSuccessfully: false);

        //                }
        //            }
        //            catch (Exception objException)
        //            {
        //                return (compilerOutPut: $"Error found: {objException.ToString()}", compiledSuccessfully: false);
        //                // Log the exception

        //            }
        //        }
    }
}
