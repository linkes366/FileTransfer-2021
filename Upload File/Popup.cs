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
    public partial class Popup : Form
    {
        public bool ok_Clicked { get; private set; }
        public Popup(string title, string message)
        {
            InitializeComponent();
            Text = title;
            Message.Text = message;
        }

        private void Popup_Load(object sender, EventArgs e)
        {

        }

        private void Ok_Click(object sender, EventArgs e)
        {
            ok_Clicked = true;
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ok_Clicked = false;
            this.Close();
        }
    }
}
