using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class HELP : Form
    {
        public HELP()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
         
            richTextBox1.Text = Text + "";
        }

        private void HELP_Load(object sender, EventArgs e)
        {

        }
    }
}
