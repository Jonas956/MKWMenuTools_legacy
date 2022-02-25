using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        string name = "hallo";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string strCmdText;
           

            strCmdText = "/c wszst ex MenuSingle.szs";

            System.Diagnostics.Process.Start("CMD.exe", strCmdText);

        }

        private void CTGPMenuSingle_Click(object sender, EventArgs e)
        {
          string strCTGPMenuSingle;


            strCTGPMenuSingle = "/c Xcopy /E /I /Y CTGPPatch MenuSingle.d & wszst c -o MenuSingle.d & rd /Q /S MenuSingle.d";

            System.Diagnostics.Process.Start("CMD.exe", strCTGPMenuSingle);
         
        }

        private void DolphinMenuSingle_Click(object sender, EventArgs e)
        {

        }
    }
}
