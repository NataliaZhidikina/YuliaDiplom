using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Diplom
{
    public partial class Algiritm4 : Form
    {
        public Algiritm4()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            label1.Text = null;
            label2.Text = null;
            label3.Text = null;
            label4.Text = null;
            label5.Text = null;
            label6.Text = null;
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

        private void button10_Click(object sender, EventArgs e)
        {
            Histori4 Hi4 = new Histori4();
            Hi4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HELP4 H4 = new HELP4();
            H4.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Glavnay G = new Glavnay();
            G.ShowDialog();
        }

        private void Algiritm4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
           
            int[] arrTaxtBox = new int[6];

            textBox1.Text = CheckIfNull(textBox1.Text);
            arrTaxtBox[0] = int.Parse(textBox1.Text);
            textBox2.Text = CheckIfNull(textBox2.Text);
            arrTaxtBox[1] = int.Parse(textBox2.Text);

            textBox3.Text = CheckIfNull(textBox3.Text);
            arrTaxtBox[2] = int.Parse(textBox3.Text);
            textBox4.Text = CheckIfNull(textBox4.Text);
            arrTaxtBox[3] = int.Parse(textBox4.Text);

            textBox5.Text = CheckIfNull(textBox5.Text);
            arrTaxtBox[4] = int.Parse(textBox5.Text);
            textBox6.Text = CheckIfNull(textBox6.Text);
            arrTaxtBox[5] = int.Parse(textBox6.Text);

            label1.Text = arrTaxtBox[0].ToString();
            label2.Text = arrTaxtBox[1].ToString();
            label3.Text = arrTaxtBox[2].ToString();

            label4.Text = arrTaxtBox[3].ToString();
            label5.Text = arrTaxtBox[4].ToString();
            label6.Text = arrTaxtBox[5].ToString();

           
            int n, buf, count;
            count = 0;
            n = 6;
         
            for (int k = n - 1; k > 0; k--)
            {
                count++;
                label7.Text = "Крок " + count + "!";
                for (int i = 0; i < k; i++)
                {

                    if (arrTaxtBox[i] > arrTaxtBox[i + 1])
                    {
                        buf = arrTaxtBox[i];
                        arrTaxtBox[i] = arrTaxtBox[i + 1];
                        arrTaxtBox[i + 1] = buf;

                    }
                    label1.Text = arrTaxtBox[0].ToString();
                    label2.Text = arrTaxtBox[1].ToString();
                    label3.Text = arrTaxtBox[2].ToString();

                    label4.Text = arrTaxtBox[3].ToString();
                    label5.Text = arrTaxtBox[4].ToString();
                    label6.Text = arrTaxtBox[5].ToString();
                    await Task.Delay(1000);
                }
            }

        }

        private static String CheckIfNull(String str)
       {
            if (String.IsNullOrEmpty(str))
                str = "0";
            return str;
       }
    }
}
