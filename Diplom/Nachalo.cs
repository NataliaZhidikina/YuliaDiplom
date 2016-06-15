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
    public partial class Nachalo : Form
    {
        public Nachalo()
        {
            InitializeComponent();
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += .06;
            if (this.Opacity == 6)
            {
                timer1.Stop();
            }

        }

        private void Nachalo_Load(object sender, EventArgs e)
        {

        }
    }
}
