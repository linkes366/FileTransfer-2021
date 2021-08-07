using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upload_File
{
    public partial class TestForm : Form
    {
        //Functions personal = new Functions();
        public TestForm()
        {
            InitializeComponent();
        }

        private void test_popup_Click(object sender, EventArgs e)
        {
            bool test;
            test = Functions.popupMessage("is popupWorking?", "hey look new name");
            Functions.popupMessage("returned " + test.ToString(), "true/false");
        }
    }
}
