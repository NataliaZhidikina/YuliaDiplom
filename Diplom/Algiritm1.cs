using System;
using System.Threading;
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
    public partial class Algiritm1 : Form
    {
        public Algiritm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Glavnay G = new Glavnay();
            G.ShowDialog();
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HELP1 H1 = new HELP1();
            H1.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 3;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.MaxLength = 3;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 7)
                e.Handled = true;

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 9)
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 10)
                e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 11)
                e.Handled = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 12)
                e.Handled = true;
        }

        private void textBox4_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 13)
                e.Handled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Histori1 Hi1 = new Histori1();
            Hi1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            label6.Text = null;
            label3.Text = null;
            label1.Text = null;
            label5.Text = null;
            label4.Text = null;
            label2.Text = null;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random RandomClass = new Random();
            int num1, num2, num3, num4, num5, num6;
            num1 = RandomClass.Next(1, 49);
            num2 = RandomClass.Next(1, 49);
            num3 = RandomClass.Next(1, 49);
            num4 = RandomClass.Next(1, 49);
            num5 = RandomClass.Next(1, 49);
            num6 = RandomClass.Next(1, 49);

            textBox1.Text = num1.ToString();
            textBox2.Text = num2.ToString();
            textBox3.Text = num3.ToString();
            textBox4.Text = num4.ToString();
            textBox5.Text = num5.ToString();
            textBox6.Text = num6.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
       //     sortTextBoxValue(this);

       // }
       // private static String CheckIfNull(String str)
       // {
       //     if (String.IsNullOrEmpty(str))
       //         str = "0";
       //     return str;

       // }
       //private static void sortTextBoxValue(Control parent)
       // {
       //     List<TextBox> textBoxs= new List<TextBox>();
       //     List<String> stringlist = new List<String>();
       //     List<Label> labels = new List<Label>();
       //     foreach (Control c in parent.Controls)
       //     {
       //         if (c.GetType() == typeof(TextBox))
       //         {
       //             c.Text = CheckIfNull(c.Text);
       //             textBoxs.Add((TextBox)c);
       //             stringlist.Add("");
       //         }
       //         //if (c.GetType() == typeof(Label))
       //         //{   labels.Add((Label)c);
       //         //}
       //         if (c.GetType() == typeof(GroupBox))
       //             sortTextBoxValue(c);
       //     }
            
       //     fillStrings(stringlist, textBoxs);
       //     stringlist = sortStrings(stringlist);
       //     labels = sortLabels(labels);
       //     fillLabeles(labels, stringlist);
       //     textBoxs = null;
       //     labels = null;
       // }
       // //void timer_Ticker(object sender , EventArgs e)
       // //{
       // //    labels[i].Text = fillOneLabele(stringList, i);
       // //}

       // private static void fillLabeles(List<Label> labels, List<string> stringList)
       // {
       //     for (int i = 0; i < labels.Count; i++)
       //     {
       //         labels[i].Text = fillOneLabele(stringList, i);
       //         //System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();


       //         //timer.Interval = 1;
       //         //timer.Enabled = true;
       //     }
       // }

        
       // private static string fillOneLabele( List<string> stringList, int number)
       // {
       //     for (int i = 0; i < stringList.Count; i++)
       //     {   if(number == i)
       //         return stringList[i];
       //     }
       //     return "";
        }

        private static void fillStrings(List<string> stringlist, List<TextBox> textBoxs)
        {
            for (int i = 0; i < textBoxs.Count; i++)
            {
                stringlist[i] = textBoxs[i].Text;
            }

        }

       

        private static List<string> sortStrings(List<string> Stringlist)
        {
            for (int i = 1; i < Stringlist.Count; i++)
            {
                int cur = Convert.ToInt32(Stringlist[i]);
                int j = i;
                while (j > 0 && cur < Convert.ToInt32(Stringlist[j - 1]))
                {
                    Stringlist[j] = Stringlist[j - 1];
                    j--;
                }
                
                Stringlist[j] = cur.ToString();
            }

        
            return Stringlist;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 3;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.MaxLength = 3;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.MaxLength = 3;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.MaxLength = 3;
        }

        private void Algiritm1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void Algiritm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
