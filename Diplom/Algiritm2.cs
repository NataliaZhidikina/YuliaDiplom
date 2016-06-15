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
    public partial class Algiritm2 : Form
    {
        public Algiritm2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 3;

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 14)
                e.Handled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.MaxLength = 3;

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 13)
                e.Handled = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.MaxLength = 3;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 12)
                e.Handled = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.MaxLength = 3;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 12)
                e.Handled = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.MaxLength = 3;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 12)
                e.Handled = true;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.MaxLength = 3;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 12)
                e.Handled = true;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox8.MaxLength = 3;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 12)
                e.Handled = true;
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            HELP2 H2 = new HELP2();
            H2.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Glavnay G = new Glavnay();
            G.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Histori2 Hi2 = new Histori2();
            Hi2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            textBox8.Text = null;
            label1.Text = null;
            label2.Text = null;
            label3.Text = null;
            label4.Text = null;
            label5.Text = null;
            label6.Text = null;
            label7.Text = null;
            label8.Text = null;
            label9.Text = null;
            label10.Text = null;
            label11.Text = null;
            label12.Text = null;
            label13.Text = null;
            label14.Text = null;
            label15.Text = null;
            label16.Text = null;
            label17.Text = null;
            label18.Text = null;
            label19.Text = null;
            label20.Text = null;
            label21.Text = null;
            label22.Text = null;
            label23.Text = null;
            label24.Text = null;
            label25.Text = null;
            label26.Text = null;
            label27.Text = null;
            label28.Text = null;
            label29.Text = null;
            label30.Text = null;
            label31.Text = null;
            label32.Text = null;
            groupBox8.BackColor = Color.Aquamarine;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random RandomClass = new Random();
            int num1, num2, num3, num4, num5, num6, num7, num8;
            num1 = RandomClass.Next(1, 49);
            num2 = RandomClass.Next(1, 49);
            num3 = RandomClass.Next(1, 49);
            num4 = RandomClass.Next(1, 49);
            num5 = RandomClass.Next(1, 49);
            num6 = RandomClass.Next(1, 49);
            num7 = RandomClass.Next(1, 49);
            num8 = RandomClass.Next(1, 49);

            textBox1.Text = num1.ToString();
            textBox2.Text = num2.ToString();
            textBox3.Text = num3.ToString();
            textBox4.Text = num4.ToString();
            textBox5.Text = num5.ToString();
            textBox6.Text = num6.ToString();
            textBox7.Text = num5.ToString();
            textBox8.Text = num6.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 7)
                e.Handled = true;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
         
            button10.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button2.Focus();
           

            if (String.IsNullOrEmpty(textBox1.Text))
                label1.Text = "0";
            else label1.Text = textBox1.Text;
            if (String.IsNullOrEmpty(textBox2.Text))
                label2.Text = "0";
            else label2.Text = textBox2.Text;

            if (String.IsNullOrEmpty(textBox3.Text))
                label3.Text = "0";
            else label3.Text = textBox3.Text;

            if (String.IsNullOrEmpty(textBox4.Text))
                label4.Text = "0";
            else label4.Text = textBox4.Text;

            if (String.IsNullOrEmpty(textBox5.Text))
                label5.Text = "0";
            else label5.Text = textBox5.Text;

            if (String.IsNullOrEmpty(textBox6.Text))
                label6.Text = "0";
            else label6.Text = textBox6.Text;

            if (String.IsNullOrEmpty(textBox7.Text))
                label7.Text = "0";
            else label7.Text = textBox7.Text;

            if (String.IsNullOrEmpty(textBox8.Text))
                label8.Text = "0";
            else label8.Text = textBox8.Text;
            ////

            int L1 = Convert.ToInt32(label1.Text);
            int L2 = Convert.ToInt32(label2.Text);
            int L3 = Convert.ToInt32(label3.Text);
            int L4 = Convert.ToInt32(label4.Text);
            int L5 = Convert.ToInt32(label5.Text);
            int L6 = Convert.ToInt32(label6.Text);
            int L7 = Convert.ToInt32(label7.Text);
            int L8 = Convert.ToInt32(label8.Text);
            //
            await Task.Delay(500);
            label1.BackColor = Color.Yellow;
            await Task.Delay(500);
            label2.BackColor = Color.Yellow;
            await Task.Delay(500);
            groupBox2.BackColor = Color.Lime;
            label9.BackColor = Color.Lime;
            label10.BackColor = Color.Lime;
            if (L1 <= L2)
            {
                await Task.Delay(500);
                label9.ForeColor = Color.Blue;
                label9.Text = L1.ToString();
                await Task.Delay(500);
                label10.ForeColor = Color.Blue;
                label10.Text = L2.ToString();
                await Task.Delay(500);

            }
            else
            {
                await Task.Delay(500);
                label9.Text = L2.ToString();
                label9.ForeColor = Color.Blue;
                await Task.Delay(500);
                label10.Text = L1.ToString();
                label10.ForeColor = Color.Blue;
                await Task.Delay(500);
            }
            await Task.Delay(500);
            label1.ForeColor = Color.DarkSlateGray;
            label2.ForeColor = Color.DarkSlateGray;
            label9.ForeColor = Color.DarkSlateGray;
            label10.ForeColor = Color.DarkSlateGray;
            label1.BackColor = Color.Aquamarine;
            label2.BackColor = Color.Aquamarine;
            label9.BackColor = Color.Aquamarine;
            label10.BackColor = Color.Aquamarine;
            groupBox2.BackColor = Color.Aquamarine;
            //
            await Task.Delay(500);
            label3.BackColor = Color.Yellow;
            await Task.Delay(500);
            label4.BackColor = Color.Yellow;
            await Task.Delay(500);
            groupBox3.BackColor = Color.Lime;
            label11.BackColor = Color.Lime;
            label12.BackColor = Color.Lime;
            if (L3 <= L4)
            {
                await Task.Delay(500);
                label11.ForeColor = Color.Blue;
                label11.Text = L3.ToString();
                await Task.Delay(500);
                label12.ForeColor = Color.Blue;
                label12.Text = L4.ToString();
            }
            else
            {
                await Task.Delay(500);
                label11.ForeColor = Color.Blue;
                label11.Text = L4.ToString();
                await Task.Delay(500);
                label12.ForeColor = Color.Blue;
                label12.Text = L3.ToString();
            }
            await Task.Delay(500);
            label3.ForeColor = Color.DarkSlateGray;
            label4.ForeColor = Color.DarkSlateGray;
            label11.ForeColor = Color.DarkSlateGray;
            label12.ForeColor = Color.DarkSlateGray;
            label3.BackColor = Color.Aquamarine;
            label4.BackColor = Color.Aquamarine;
            label11.BackColor = Color.Aquamarine;
            label12.BackColor = Color.Aquamarine;
            groupBox3.BackColor = Color.Aquamarine;
            //
            await Task.Delay(500);
            label5.BackColor = Color.Yellow;
            await Task.Delay(500);
            label6.BackColor = Color.Yellow;
            await Task.Delay(500);
            groupBox4.BackColor = Color.Lime;
            label13.BackColor = Color.Lime;
            label14.BackColor = Color.Lime;
            if (L5 <= L6)
            {
                await Task.Delay(500);
                label13.ForeColor = Color.Blue;
                label13.Text = L5.ToString();
                await Task.Delay(500);
                label14.ForeColor = Color.Blue;
                label14.Text = L6.ToString();
            }
            else {
                await Task.Delay(500);
                label13.ForeColor = Color.Blue;
                label13.Text = L6.ToString();
                await Task.Delay(500);
                label14.ForeColor = Color.Blue;
                label14.Text = L5.ToString();
            }
            await Task.Delay(500);
            label5.ForeColor = Color.DarkSlateGray;
            label6.ForeColor = Color.DarkSlateGray;
            label13.ForeColor = Color.DarkSlateGray;
            label14.ForeColor = Color.DarkSlateGray;
            label5.BackColor = Color.Aquamarine;
            label6.BackColor = Color.Aquamarine;
            label13.BackColor = Color.Aquamarine;
            label14.BackColor = Color.Aquamarine;
            groupBox4.BackColor = Color.Aquamarine;
            //
            await Task.Delay(500);
            label7.BackColor = Color.Yellow;
            await Task.Delay(500);
            label8.BackColor = Color.Yellow;
            await Task.Delay(500);
            groupBox5.BackColor = Color.Lime;
            label15.BackColor = Color.Lime;
            label16.BackColor = Color.Lime;
            if (L7 <= L8)
            {
                await Task.Delay(500);
                label15.ForeColor = Color.Blue;
                label15.Text = L7.ToString();
                await Task.Delay(500);
                label16.ForeColor = Color.Blue;
                label16.Text = L8.ToString();
            }
            else {
                await Task.Delay(500);
                label15.ForeColor = Color.Blue;
                label15.Text = L8.ToString();
                await Task.Delay(500);
                label16.ForeColor = Color.Blue;
                label16.Text = L7.ToString();
            }
            await Task.Delay(500);
            label7.ForeColor = Color.DarkSlateGray;
            label8.ForeColor = Color.DarkSlateGray;
            label15.ForeColor = Color.DarkSlateGray;
            label16.ForeColor = Color.DarkSlateGray;
            label7.BackColor = Color.Aquamarine;
            label8.BackColor = Color.Aquamarine;
            label15.BackColor = Color.Aquamarine;
            label16.BackColor = Color.Aquamarine;
            groupBox5.BackColor = Color.Aquamarine;


            //
            //
            //
            //
            //
            int L9 = Convert.ToInt32(label9.Text);
            int L10 = Convert.ToInt32(label10.Text);
            int L11 = Convert.ToInt32(label11.Text);
            int L12 = Convert.ToInt32(label12.Text);
            int L13 = Convert.ToInt32(label13.Text);
            int L14 = Convert.ToInt32(label14.Text);
            int L15 = Convert.ToInt32(label15.Text);
            int L16 = Convert.ToInt32(label16.Text);


            await Task.Delay(500);
            label9.BackColor = Color.Yellow;
            await Task.Delay(500);
            label10.BackColor = Color.Yellow;
            await Task.Delay(500);
            await Task.Delay(500);
            label11.BackColor = Color.Yellow;
            await Task.Delay(500);
            label12.BackColor = Color.Yellow;
            await Task.Delay(500);
            groupBox6.BackColor = Color.Lime;
            label17.BackColor = Color.Lime;
            label18.BackColor = Color.Lime;
            label19.BackColor = Color.Lime;
            label20.BackColor = Color.Lime;
            if (L9 <= L11)
            {
                await Task.Delay(500);
                label17.ForeColor = Color.Blue;
                label17.Text = L9.ToString();
                if (L10 <= L11)
                {
                    await Task.Delay(500);
                    label18.ForeColor = Color.Blue;
                    label18.Text = L10.ToString();
                    await Task.Delay(500);
                    label19.ForeColor = Color.Blue;
                    label19.Text = L11.ToString();
                    await Task.Delay(500);
                    label20.ForeColor = Color.Blue;
                    label20.Text = L12.ToString();
                }
                else
                {
                    await Task.Delay(500);
                    label18.ForeColor = Color.Blue;
                    label18.Text = L11.ToString();

                    if (L10 <= L12)
                    {
                        await Task.Delay(500);
                        label19.ForeColor = Color.Blue;
                        label19.Text = L10.ToString();
                        await Task.Delay(500);
                        label20.ForeColor = Color.Blue;
                        label20.Text = L12.ToString();
                    }
                    else
                    {
                        await Task.Delay(500);
                        label19.ForeColor = Color.Blue;
                        label19.Text = L12.ToString();
                        await Task.Delay(500);
                        label20.ForeColor = Color.Blue;
                        label20.Text = L10.ToString();
                        
                    }
                }
            }
            else
            {
                await Task.Delay(500);
                label17.ForeColor = Color.Blue;
                label17.Text = L11.ToString();
                if (L9 <= L12)
                {
                    await Task.Delay(500);
                    label18.ForeColor = Color.Blue;
                    label18.Text = L9.ToString();
                    if (L10 <= L12)
                    {
                        await Task.Delay(500);
                        label19.ForeColor = Color.Blue;
                        label19.Text = L10.ToString();
                        await Task.Delay(500);
                        label20.ForeColor = Color.Blue;
                        label20.Text = L12.ToString();
                    }
                    else
                    {
                        await Task.Delay(500);
                        label19.ForeColor = Color.Blue;
                        label19.Text = L12.ToString();
                        await Task.Delay(500);
                        label20.ForeColor = Color.Blue;
                        label20.Text = L10.ToString();
                        
                    }
                }

            
            
                else
                {
                    await Task.Delay(500);
                    label18.ForeColor = Color.Blue;
                    label18.Text = L12.ToString();
                    await Task.Delay(500);
                    label19.ForeColor = Color.Blue;
                    label19.Text = L11.ToString();
                    await Task.Delay(500);
                    label20.ForeColor = Color.Blue;
                    label20.Text = L10.ToString();
                }
            }
            await Task.Delay(500);
            label9.ForeColor = Color.DarkSlateGray;
            label10.ForeColor = Color.DarkSlateGray;
            label11.ForeColor = Color.DarkSlateGray;
            label12.ForeColor = Color.DarkSlateGray; 
            label9.BackColor = Color.Aquamarine;
            label10.BackColor = Color.Aquamarine;
            label11.BackColor = Color.Aquamarine;
            label12.BackColor = Color.Aquamarine;
            label17.BackColor = Color.Aquamarine;
            label18.BackColor = Color.Aquamarine;
            label19.BackColor = Color.Aquamarine;
            label20.BackColor = Color.Aquamarine;
            groupBox6.BackColor = Color.Aquamarine;
            label17.ForeColor = Color.DarkSlateGray;
            label18.ForeColor = Color.DarkSlateGray;
            label19.ForeColor = Color.DarkSlateGray;
            label20.ForeColor = Color.DarkSlateGray;







            //
            await Task.Delay(500);
            label13.BackColor = Color.Yellow;
            await Task.Delay(500);
            label14.BackColor = Color.Yellow;
            await Task.Delay(500);
            await Task.Delay(500);
            label15.BackColor = Color.Yellow;
            await Task.Delay(500);
            label16.BackColor = Color.Yellow;
            await Task.Delay(500);
            groupBox7.BackColor = Color.Lime;
            label21.BackColor = Color.Lime;
            label22.BackColor = Color.Lime;
            label23.BackColor = Color.Lime;
            label24.BackColor = Color.Lime;
            if (L13 <= L15)
            {
                await Task.Delay(500);
                label21.ForeColor = Color.Blue;
                label21.Text = L13.ToString();
                if (L14 <= L15)
                {
                    await Task.Delay(500);
                    label22.ForeColor = Color.Blue;
                    label22.Text = L14.ToString();
                    await Task.Delay(500);
                    label23.ForeColor = Color.Blue;
                    label23.Text = L15.ToString();
                    await Task.Delay(500);
                    label24.ForeColor = Color.Blue;
                    label24.Text = L16.ToString();
                }
                else
                {
                    await Task.Delay(500);
                    label22.ForeColor = Color.Blue;
                    label22.Text = L15.ToString();
                    if (L14 <= L16)
                    {
                        await Task.Delay(500);
                        label23.ForeColor = Color.Blue;
                        label23.Text = L14.ToString();
                        await Task.Delay(500);
                        label24.ForeColor = Color.Blue;
                        label24.Text = L16.ToString();
                    }
                    else
                    {
                        await Task.Delay(500);
                        label23.ForeColor = Color.Blue;
                        label23.Text = L16.ToString();
                        await Task.Delay(500);
                        label24.ForeColor = Color.Blue;
                        label24.Text = L14.ToString();
                    }
                }
            }
            else
            {
                await Task.Delay(500);
                label21.ForeColor = Color.Blue;
                label21.Text = L15.ToString();
                if (L13 <= L16)
                {
                    await Task.Delay(500);
                    label22.ForeColor = Color.Blue;
                    label22.Text = 139.ToString();
                    if (L14 <= L16)
                    {
                        await Task.Delay(500);
                        label23.ForeColor = Color.Blue;
                        label23.Text = L14.ToString();
                        await Task.Delay(500);
                        label24.ForeColor = Color.Blue;
                        label24.Text = L16.ToString();
                    }
                    else
                    {
                        await Task.Delay(500);
                        label23.ForeColor = Color.Blue;
                        label23.Text = L16.ToString();
                        await Task.Delay(500);
                        label24.Text = L14.ToString();
                    }
                }
                else
                {
                    await Task.Delay(500);
                    label22.Text = L16.ToString();
                    label22.ForeColor = Color.Blue;
                    await Task.Delay(500);
                    label23.ForeColor = Color.Blue;
                    label23.Text = L13.ToString();
                    await Task.Delay(500);
                    label24.ForeColor = Color.Blue;
                    label24.Text = L14.ToString();
                }
            }
            await Task.Delay(500);
            label13.ForeColor = Color.DarkSlateGray;
            label14.ForeColor = Color.DarkSlateGray;
            label15.ForeColor = Color.DarkSlateGray;
            label16.ForeColor = Color.DarkSlateGray;
            label13.BackColor = Color.Aquamarine;
            label14.BackColor = Color.Aquamarine;
            label15.BackColor = Color.Aquamarine;
            label16.BackColor = Color.Aquamarine;
            label21.BackColor = Color.Aquamarine;
            label22.BackColor = Color.Aquamarine;
            label23.BackColor = Color.Aquamarine;
            label24.BackColor = Color.Aquamarine;
            groupBox7.BackColor = Color.Aquamarine;
            label21.ForeColor = Color.DarkSlateGray;
            label22.ForeColor = Color.DarkSlateGray;
            label23.ForeColor = Color.DarkSlateGray;
            label24.ForeColor = Color.DarkSlateGray;
            //
            //
            //
            await Task.Delay(500);

            label17.BackColor = Color.Yellow;
            await Task.Delay(500);
            label18.BackColor = Color.Yellow;
            await Task.Delay(500);
            label19.BackColor = Color.Yellow;
            await Task.Delay(500);
            label20.BackColor = Color.Yellow;
            await Task.Delay(500);
            label21.BackColor = Color.Yellow;
            await Task.Delay(500);
            label22.BackColor = Color.Yellow;
            await Task.Delay(500);
            label23.BackColor = Color.Yellow;
            await Task.Delay(500);
            label24.BackColor = Color.Yellow;
            await Task.Delay(500);
            groupBox8.BackColor = Color.Lime;

            List<int> arg1 = new List<int>();
            arg1.Add(int.Parse(label17.Text));
            arg1.Add(int.Parse(label18.Text));
            arg1.Add(int.Parse(label19.Text));
            arg1.Add(int.Parse(label20.Text));

            arg1.Add(int.Parse(label21.Text));
            arg1.Add(int.Parse(label22.Text));
            arg1.Add(int.Parse(label23.Text));
            arg1.Add(int.Parse(label24.Text));
            arg1.Sort();
            await Task.Delay(500);
            label25.ForeColor = Color.Blue;
            label25.Text = arg1[0].ToString();
            await Task.Delay(500);
            label26.ForeColor = Color.Blue;
            label26.Text = arg1[1].ToString();
            await Task.Delay(500);
            label27.ForeColor = Color.Blue;
            label27.Text = arg1[2].ToString();
            await Task.Delay(500);
            label28.ForeColor = Color.Blue;
            label28.Text = arg1[3].ToString();
            await Task.Delay(500);
            label29.ForeColor = Color.Blue;
            label29.Text = arg1[4].ToString();
            await Task.Delay(500);
            label30.ForeColor = Color.Blue;
            label30.Text = arg1[5].ToString();
            await Task.Delay(500);
            label31.ForeColor = Color.Blue;
            label31.Text = arg1[6].ToString();
            await Task.Delay(500);
            label32.ForeColor = Color.Blue;
            label32.Text = arg1[7].ToString();

            await Task.Delay(500);
            label25.ForeColor = Color.DarkSlateGray;
            label26.ForeColor = Color.DarkSlateGray;
            label27.ForeColor = Color.DarkSlateGray;
            label28.ForeColor = Color.DarkSlateGray;
            label29.ForeColor = Color.DarkSlateGray;
            label30.ForeColor = Color.DarkSlateGray;
            label31.ForeColor = Color.DarkSlateGray;
            label32.ForeColor = Color.DarkSlateGray;

            label17.BackColor = Color.Aquamarine;
            label18.BackColor = Color.Aquamarine;
            label19.BackColor = Color.Aquamarine;
            label20.BackColor = Color.Aquamarine;
            label21.BackColor = Color.Aquamarine;
            label22.BackColor = Color.Aquamarine;
            label23.BackColor = Color.Aquamarine;
            label24.BackColor = Color.Aquamarine;

            groupBox8.BackColor = Color.Orange;
          

        }



        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            textBox2.MaxLength = 3;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Algiritm2_Load(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Algiritm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

} 