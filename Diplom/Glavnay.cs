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
    public partial class Glavnay : Form
    {
        public Glavnay()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide(); 
            Algiritm1 A1  = new Algiritm1();
           A1.ShowDialog();
            Close(); 
             
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HELP H = new HELP();
            H.ShowDialog();
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            O_nas O = new O_nas();
            O.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Histori Hi = new Histori();
            Hi.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Hide();
            Algiritm2 A2 = new Algiritm2();
            A2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Algiritm3 A3 = new Algiritm3();
            A3.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            Algiritm4 A4 = new Algiritm4();
            A4.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            Algiritm4 A4 = new Algiritm4();
            A4.ShowDialog();
            Close();

        }

        private void Glavnay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
