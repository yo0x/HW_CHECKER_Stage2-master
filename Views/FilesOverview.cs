using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DropFilesTest1
{
    public partial class FilesOverview : Form
    {
        public FilesOverview()
        {
            InitializeComponent();
        }

        private void FilesOverview_Load(object sender, EventArgs e)
        {
            OrderedFiles myOrderedFiles = new OrderedFiles();
            myOrderedFiles = FilesClassifer.classiferProgLang(FilesTool.filesToCheck);
            label4NumCfiles.Text = Convert.ToString(myOrderedFiles.cFiles.Count);
            label4NumJavaFiles.Text = Convert.ToString(myOrderedFiles.javaFiles.Count);
            label4NumPythonFiles.Text = Convert.ToString(myOrderedFiles.pythonFiles.Count);
        }

        private void Button1Cfiles_Click(object sender, EventArgs e)
        {
            OrderedFiles myOrderedFiles = new OrderedFiles();
            myOrderedFiles = FilesClassifer.classiferProgLang(FilesTool.filesToCheck);
            foreach (string item in myOrderedFiles.cFiles)
            {
                MessageBox.Show($"{FilesExecuter.cfilesExe(item)}");
            }
        }
    }
}
