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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (UN.Text == "Admin" && PW.Text == "Admin")
            {

                this.Hide();
                DragFiles adminProfile = new DragFiles();
                adminProfile.ShowDialog();
                this.Close();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
