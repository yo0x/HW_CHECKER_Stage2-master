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

        public static (string compilerOutPut, bool compiledSuccessfully, string fileToExec) compileFile(string myFileToCompile)
        {
            string fileCompOutPut = $"{ Path.GetTempPath() }\\comp.output";
            string fileExecOutPut = $"{ Path.GetTempPath() }\\file.output";
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string dirOutPutToCompiledFiles = $"{desktopPath}\\HwOutput";
            //string commadToCompiler = "";
            string argumentsToCompiler = "";
            string cComp = "gcc.exe";
            string JavaComp = "javac.exe";
            string PythonComp = "python.exe";
            string compilerUsed = "";
            string compiledFileToExec = "";
            if (!Directory.Exists(dirOutPutToCompiledFiles))
            {
                Directory.CreateDirectory(dirOutPutToCompiledFiles);
            }
            using (Process myProcess = new Process())
            {


                if (Path.GetExtension(myFileToCompile).Equals(".c"))
                {
                    string commandCfiles = $" -o {dirOutPutToCompiledFiles}\\{Path.GetFileNameWithoutExtension(myFileToCompile)} {myFileToCompile}";
                    argumentsToCompiler = commandCfiles;
                    compilerUsed = cComp;
                    string compiledCFile = $"{dirOutPutToCompiledFiles}\\{Path.GetFileNameWithoutExtension(myFileToCompile)}.exe";
                    compiledFileToExec = compiledCFile;

                }
                else if (Path.GetExtension(myFileToCompile).Equals(".py"))
                {
                    string commandCfiles = $"{myFileToCompile}";
                    argumentsToCompiler = commandCfiles;
                    compilerUsed = PythonComp;
                    string compiledCFile = $"{dirOutPutToCompiledFiles}\\{Path.GetFileNameWithoutExtension(myFileToCompile)}";
                    compiledFileToExec = compiledCFile;

                }
                else if (Path.GetExtension(myFileToCompile).Equals(".java"))
                {
                    string commandCfiles = $"-d {dirOutPutToCompiledFiles} {myFileToCompile}";
                    argumentsToCompiler = commandCfiles;
                    compilerUsed = JavaComp;
                    string compiledCFile = $"{dirOutPutToCompiledFiles}\\{Path.GetFileNameWithoutExtension(myFileToCompile)}.class";
                    compiledFileToExec = compiledCFile;
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
                    return ("Compiled Successfuly", true, compiledFileToExec);
                }
                else
                {
                    return (myProcess.StandardError.ReadToEnd(), false, "Error check logs.");

                }

            }
        }


        public static (string compilerOutPutStdErros, string execFileOutputStdOutput, bool compiledSuccessfully) executeFile(string myFileToExec)
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
        public static (string compilerOutPut, bool compiledSuccessfully, string pathCompiledFile) compileFile(string myFileToExec)
        {
            string fileCompOutPut = $"{ Path.GetTempPath() }\\comp.output";
            string fileExecOutPut = $"{ Path.GetTempPath() }\\file.output";
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string dirOutPutToCompiledFiles = $"{desktopPath}\\HwOutput";
            //string commadToCompiler = "";
            string argumentsToCompiler = "";
            string cComp = "gcc.exe";
            string JavaComp = "javac.exe";
            string PythonComp = "python.exe";
            string compiledFileToExec = "";
            string CompilerUsed = "";
            if (!Directory.Exists(dirOutPutToCompiledFiles))
            {
                Directory.CreateDirectory(dirOutPutToCompiledFiles);
            }
            using (Process myProcess = new Process())
            {
                

                if (Path.GetExtension(myFileToExec).Equals(".c"))
                {
                    CompilerUsed = cComp;
                    string commandCfiles = $" -o {dirOutPutToCompiledFiles}\\{Path.GetFileNameWithoutExtension(myFileToExec)} {myFileToExec}";
                    argumentsToCompiler = commandCfiles;
                    string compiledCFile = $"{dirOutPutToCompiledFiles}\\{Path.GetFileNameWithoutExtension(myFileToExec)}.exe";
                    compiledFileToExec = compiledCFile;

                }
                else if (Path.GetExtension(myFileToExec).Equals(".py"))
                {
                    CompilerUsed = PythonComp;

                    string commandCfiles = $"{myFileToExec}";
                    argumentsToCompiler = commandCfiles;
                    string compiledPyhonFile = $"{dirOutPutToCompiledFiles}\\{Path.GetFileNameWithoutExtension(myFileToExec)}.exe";
                    compiledFileToExec = compiledPyhonFile;

                }
                else if (Path.GetExtension(myFileToExec).Equals(".java"))
                {
                    CompilerUsed = JavaComp;

                    string commandCfiles = $"-d {dirOutPutToCompiledFiles} {myFileToExec}";
                    argumentsToCompiler = commandCfiles;
                    string compiledJavaFile = $"{dirOutPutToCompiledFiles}\\{Path.GetFileNameWithoutExtension(myFileToExec)}.exe";
                    compiledFileToExec = compiledJavaFile;
                }


                myProcess.StartInfo.FileName = CompilerUsed;
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.RedirectStandardError = true;
                myProcess.StartInfo.RedirectStandardInput = true;
                myProcess.StartInfo.RedirectStandardOutput = true;
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.StartInfo.Arguments = argumentsToCompiler;
                myProcess.Start();
                if (myProcess.StandardOutput.ReadToEnd().Equals(null))
                {
                    return ("Done",true, compiledFileToExec);
                }
                else
                {
                    return (myProcess.StandardError.ReadToEnd(),false,"Error no Compiled filed.");
                }

            }
        }
        public static (string execFileOutput, bool ExecutedNoErrors, string errorOnExecution) executeFile(string myFileToExec, string hest2Test)
        {
            using (Process myProcess = new Process())
            {
                myProcess.StartInfo.FileName = myFileToExec;
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.RedirectStandardError = true;
                 myProcess.StartInfo.RedirectStandardInput = true;
                myProcess.StartInfo.RedirectStandardOutput = true;
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.Start();

                StreamWriter myStreamWriter = myProcess.StandardInput;

                // Prompt the user for input text lines to sort.
                // Write each line to the StandardInput stream of
                // the sort command.
                String inputText = hest2Test;
                int numLines = 0;
                do
                {

                    inputText = Console.ReadLine();
                    if (inputText.Length > 0)
                    {
                        numLines++;
                        myStreamWriter.WriteLine(inputText);
                    }
                } while (inputText.Length > 0);
                myStreamWriter.Close();
                myProcess.WaitForExit();

                if (myProcess.StandardError.ReadToEnd().Equals(null))
                {
                    return (execFileOutput: myProcess.StandardOutput.ReadToEnd(), ExecutedNoErrors: true, errorOnExecution: myProcess.StandardError.ReadToEnd());
                }
                else
                {
                    return (execFileOutput: myProcess.StandardOutput.ReadToEnd(), ExecutedNoErrors: false, errorOnExecution: myProcess.StandardError.ReadToEnd());

                }
                // Wait for the sort process to write the sorted text lines.




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
