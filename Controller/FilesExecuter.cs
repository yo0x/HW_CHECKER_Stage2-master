using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropFilesTest1
{
    static class FilesExecuter
    {
        //private static string AppPath => Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
        //private static DirectoryInfo myDir = new DirectoryInfo(AppPath);
        //private static string dataDir = myDir.Parent.Parent.FullName.ToString();
        //public static string xmlDishPath = $"{dataDir}\\Data\\Dishes.xml";

        public  static string cfilesExe(string myFileToExec)
        {

            string fileOutPut;
            string command = $"gcc -o {Path.GetDirectoryName(myFileToExec)}\\{Path.GetFileNameWithoutExtension(myFileToExec)} {myFileToExec}";

            try
            {
                // create the ProcessStartInfo using "cmd" as the program to be run,
                // and "/c " as the parameters.
                // Incidentally, /c tells cmd that we want it to execute the command that follows,
                // and then exit.
                ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + command);

                // The following commands are needed to redirect the standard output.
                // This means that it will be redirected to the Process.StandardOutput StreamReader.
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                // Do not create the black window.
                procStartInfo.CreateNoWindow = true;
                // Now we create a process, assign its ProcessStartInfo and start it
                Process proc = new Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                proc.WaitForExit();
                // Get the output into a string
                string result = proc.StandardOutput.ReadToEnd();
                // Display the command output.
                Console.WriteLine(result);
                return (result);
            }
            catch (Exception objException)
            {
                // Log the exception
                return "l";
            }


            





            //// Start the child process.
            //Process p = new Process();
            //// Redirect the output stream of the child process.
            //p.StartInfo.UseShellExecute = false;
            //p.StartInfo.RedirectStandardOutput = true;
            //p.StartInfo.FileName = "YOURBATCHFILE.bat";
            //p.Start();
            //// Do not wait for the child process to exit before
            //// reading to the end of its redirected stream.
            //// p.WaitForExit();
            //// Read the output stream first and then wait.
            //string output = p.StandardOutput.ReadToEnd();
            //p.WaitForExit();


        }

        //public void execCopFile(string fileToExe)
        //{

            
        //}
    }
}
