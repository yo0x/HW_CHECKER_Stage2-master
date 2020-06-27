using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace DropFilesTest1
{
    public partial class wnd_dropFiles : Form
    {
        public wnd_dropFiles()
        {
            InitializeComponent();
        }

        private void Wnd_dropFiles_Load(object sender, EventArgs e)
        {
          
        }

        private void RichTextBoxDropFiles_DragDrop(object sender, DragEventArgs e)
        {
           
            
        }

       
        private void Button1CheckFiles_Click(object sender, EventArgs e)
        {
            FilesOverview fo = new FilesOverview();
            fo.Show();
        }

        private void ListBox1DragFiles_DragEnter(object sender, DragEventArgs e)
        {
            string[] filesDrop = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            FilesTool.filesToCheck = new string[filesDrop.Length];
            FilesTool.filesToCheck = filesDrop;
            foreach (string item in filesDrop)
            {
                var name = Path.GetFileName(item.ToString());
                listBox1DragFiles.Items.Add(name);
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
