﻿using System;
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
                    string commandPyFiles = $" {myFileToCompile}";
                    argumentsToCompiler = commandPyFiles;
                    compilerUsed = PythonComp;
                   // string compiledPythonFile = $"{dirOutPutToCompiledFiles}\\{Path.GetFileNameWithoutExtension(myFileToCompile)}.py";
                    compiledFileToExec = myFileToCompile;

                }
                else if (Path.GetExtension(myFileToCompile).Equals(".java"))
                {
                    string commandJavaFiles = $"-d {dirOutPutToCompiledFiles} {myFileToCompile}";
                    argumentsToCompiler = commandJavaFiles;
                    compilerUsed = JavaComp;
                    string cmpiledJavaFilePath = $"{dirOutPutToCompiledFiles}\\{Path.GetFileNameWithoutExtension(myFileToCompile)}";
                    compiledFileToExec = cmpiledJavaFilePath;
                }


                myProcess.StartInfo.FileName = compilerUsed;
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.RedirectStandardError = true;
                myProcess.StartInfo.RedirectStandardInput = true;
                myProcess.StartInfo.RedirectStandardOutput = true;
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.StartInfo.Arguments = argumentsToCompiler;
                myProcess.Start();
                string debuggError = myProcess.StandardError.ReadToEnd();
                if (debuggError.Equals(""))
                {
                    return ("Compiled Successfuly", true, compiledFileToExec);
                }
                else
                {
                    return (debuggError, false, "Error check logs.");

                }

            }
        }


        public static (string compilerOutPutStdErros, string execFileOutputStdOutput, bool compiledSuccessfully) executeFile(string myFileToExec)
        {
            //string cComp = "gcc.exe";
            string JavaComp = "java.exe";
            string PythonComp = "python.exe";
            string compilerUsed = "";
            string argumentsToCompiler = "";


            if (Path.GetExtension(myFileToExec).Equals(".exe"))
            {
               
                compilerUsed = myFileToExec;
                argumentsToCompiler = $"";



            }
            else if (Path.GetExtension(myFileToExec).Equals(".py"))
            {
                
                compilerUsed = PythonComp;
                argumentsToCompiler = $" {myFileToExec}";



            }
            else 
            {
               
                compilerUsed = JavaComp;
                argumentsToCompiler = $" {myFileToExec}";


            }

            using (Process myProcess = new Process())
            {
                myProcess.StartInfo.FileName = compilerUsed;
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.RedirectStandardError = true;
                myProcess.StartInfo.RedirectStandardInput = true;
                myProcess.StartInfo.RedirectStandardOutput = true;
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.StartInfo.Arguments = argumentsToCompiler;

                myProcess.Start();
                string debuggError = myProcess.StandardError.ReadToEnd();

                if (debuggError.Equals(""))
                {
                    return (debuggError, myProcess.StandardOutput.ReadToEnd(), true);

                }else
                {
                    return (debuggError, myProcess.StandardOutput.ReadToEnd(), false);

                }
                //myProcess.WaitForInputIdle();
                myProcess.WaitForExit(4000);
                //Check to see if the process is still running.
                if (myProcess.HasExited == false)
                    //Process is still running.
                    //Test to see if the process is hung up.
                    if (myProcess.Responding)
                        //Process was responding; close the main window.
                        myProcess.CloseMainWindow();
                    else
                        //Process was not responding; force the process to close.
                        myProcess.Kill();
                System.Windows.Forms.MessageBox.Show("Code continuing...");

            }
        }
    }

    public static class FilesExecuterHest2
    {
        static string[] InputsParsed;


        public static (string compilerOutPut, bool compiledSuccessfully, string pathCompiledFile) compileFile(string myFileToExec)
        {
            string fileCompOutPut = $"{ Path.GetTempPath() }\\comp.output";
            string fileExecOutPut = $"{ Path.GetTempPath() }\\file.output";
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string dirOutPutToCompiledFiles = $"{desktopPath}\\HwOutput";
            string argumentsToCompiler = "";
            string cComp = "gcc.exe";
            string JavaComp = "javac.exe";
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
                else if (Path.GetExtension(myFileToExec).Equals(".java"))
                {
                    CompilerUsed = JavaComp;

                    string commandCfiles = $"-d {dirOutPutToCompiledFiles} {myFileToExec}";
                    argumentsToCompiler = commandCfiles;
                    string compiledJavaFile = $"{dirOutPutToCompiledFiles}\\{Path.GetFileNameWithoutExtension(myFileToExec)}";
                    compiledFileToExec = compiledJavaFile;
                }
                //Add support to more files here...


                myProcess.StartInfo.FileName = CompilerUsed;
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.RedirectStandardError = true;
                myProcess.StartInfo.RedirectStandardInput = true;
                myProcess.StartInfo.RedirectStandardOutput = true;
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.StartInfo.Arguments = argumentsToCompiler;
                myProcess.Start();
                string debuggError = myProcess.StandardError.ReadToEnd();

                if (debuggError.Equals(""))
                {
                    return ("Done",true, compiledFileToExec);
                }
                else
                {
                    return (debuggError, false,"Error no Compiled filed.");
                }

            }
        }
        public static (string execFileOutput, bool ExecutedNoErrors, string errorOnExecution) executeFile(string myFileToExec, string hest2Test)
        {
            string JavaComp = "java.exe";
            string PythonComp = "python.exe";
            string compilerUsed = "";
            //string inputToPassHest2 = "";
            string hest2TestIput = FilesTool.processFileOutPut(hest2Test);
            string ArgsToFile = "";


            if (Path.GetExtension(myFileToExec).Equals(".exe"))
            {

                compilerUsed = myFileToExec;



            }
            else if (Path.GetExtension(myFileToExec).Equals(".py"))
            {

                compilerUsed = PythonComp;
                ArgsToFile = $"{myFileToExec}";



            }
            else
            {

                compilerUsed = JavaComp;
                ArgsToFile = $" -classpath {Path.GetDirectoryName(myFileToExec)} {Path.GetFileNameWithoutExtension(myFileToExec)}";
                 


            }

            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = compilerUsed;
            start.Arguments = string.Format("\"{0}\"", ArgsToFile);
            start.UseShellExecute = false;// Do not use OS shell
            start.CreateNoWindow = true; // We don't need new window
            start.RedirectStandardOutput = true;// Any output, generated by application will be redirected back
            start.RedirectStandardInput = true;
            start.RedirectStandardError = true; // Any error in standard output will be redirected back (for example exceptions)
            using (Process process = Process.Start(start))
            {
                using (StreamWriter writer = process.StandardInput)
                {
                    foreach (string inline in ParseMyInput(hest2Test))
                    {
                        writer.WriteLine(inline);
                    }
                }
                using (StreamReader reader = process.StandardOutput)
                {
                    string stderr = process.StandardError.ReadToEnd(); // Here are the exceptions from our Python script
                    string result = reader.ReadToEnd(); // Here is the result of StdOut(for example: print "test")
                    if (result.Length > 0)
                    {
                        return (execFileOutput: result, ExecutedNoErrors: true, errorOnExecution: stderr);
                    }
                    else
                    {
                        return (execFileOutput: result, ExecutedNoErrors: false, errorOnExecution: stderr);

                    }

                }
            }

            //using (Process myProcess = new Process())
            //{
            //    myProcess.StartInfo.FileName = compilerUsed;
            //    myProcess.StartInfo.UseShellExecute = false;
            //    myProcess.StartInfo.RedirectStandardError = true;
            //     myProcess.StartInfo.RedirectStandardInput = true;
            //    myProcess.StartInfo.RedirectStandardOutput = true;
            //    myProcess.StartInfo.CreateNoWindow = true;
            //    myProcess.StartInfo.Arguments = ArgsToFile;
            //    myProcess.Start();

            //    StreamWriter myStreamWriter = myProcess.StandardInput;

            //    string devOUT = "";
            //    foreach (string inline in ParseMyInput(hest2Test))
            //    {
            //        myStreamWriter.WriteLine(inline);
            //    }
            //    devOUT = myProcess.StandardOutput.ReadToEnd();
            //    string debuggError = myProcess.StandardError.ReadToEnd();
            //    //myProcess.WaitForInputIdle();
            //    myProcess.WaitForExit(4000);
            //    //Check to see if the process is still running.
            //    if (myProcess.HasExited == false)
            //        //Process is still running.
            //        //Test to see if the process is hung up.
            //        System.Windows.Forms.MessageBox.Show("Hanged...");

            //        if (myProcess.Responding)
            //    //Process was responding; close the main window.
            //    {
            //        myProcess.CloseMainWindow();
            //       // System.Windows.Forms.MessageBox.Show("responding...");

            //    }

            //    else
            //    {
            //        //Process was not responding; force the process to close.
            //        System.Windows.Forms.MessageBox.Show("killed...");

            //        myProcess.Kill();
            //    }
              
            //  //  System.Windows.Forms.MessageBox.Show("Code continuing...");
            //    if (devOUT.Length > 0)
            //    {
            //        return (execFileOutput: devOUT, ExecutedNoErrors: true, errorOnExecution: debuggError);
            //    }
            //    else
            //    {
            //        return (execFileOutput: devOUT, ExecutedNoErrors: false, errorOnExecution: debuggError);

            //    }




            //}
        }

     
        public static string[] ParseMyInput(string fileToBP)
        {


            int counter = 0;
            string line;

            List<string> list = new List<string>();

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(fileToBP);
            while ((line = file.ReadLine()) != null)
            {
                list.Add(line);
                counter++;
            }

            file.Close();
            InputsParsed = list.ToArray();
            return InputsParsed;


        }
    }

}
