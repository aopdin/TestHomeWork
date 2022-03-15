using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("*","Title",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            Test_ch2.TestHand();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //及格和不及格
            MessageBox.Show("if...else...及格和不及格");

            if (Convert.ToInt16(textBox1.Text) >= 60)
            {
                MessageBox.Show("及格");
            }
            else
            {
                MessageBox.Show("不及格");
            }

            //switch() 英文測試
            MessageBox.Show("switch() 英文測試");
            switch (Convert.ToInt32(textBox2.Text))
            {
                case 1:
                    MessageBox.Show(textBox2.Text + " 的英文為 " + "ONE");
                    break;
                case 2:
                    MessageBox.Show(textBox2.Text + " 的英文為 " + "TWO");
                    break;
                default:
                    MessageBox.Show("不在範圍內");
                    break;
            }

            //for() 回圈 9x9
            MessageBox.Show("for() 回圈 9x9");

            int Total = 0;

            if(Convert.ToInt32(textBox1.Text) > Convert.ToInt32(textBox2.Text))
            {
                for (int i=Convert.ToInt32(textBox1.Text); i>Convert.ToInt32(textBox2.Text); i-=2)
                {
                    Total += i;
                }
            }
            else if(Convert.ToInt32(textBox1.Text) < Convert.ToInt32(textBox2.Text))
            {
                for (int i = Convert.ToInt32(textBox1.Text); i<= Convert.ToInt32(textBox2.Text); i+=2)
                {
                    Total += i;
                }
            }
            else
            {
                MessageBox.Show("for()...exit");
            }
            MessageBox.Show(Total.ToString());

            //foreach() 陣列
            MessageBox.Show("foreach() 陣列");

            string[] Names = new string[] {"張大明","孫小美","小丸子" };

            foreach (string Str in Names)
                MessageBox.Show(Str);

            //while()
            int ix = 0;

            while(ix < 20)
            {
                ix++;
            }
            MessageBox.Show("while() " + ix.ToString());

            ix = 0;

            //do...while()
            do
            {
                ix++;            
            } while (ix < 20);
            MessageBox.Show("do...while() " + ix.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("123");
        }
    }

    public static class Test_ch2
    {
        public static void TestHand()
        {
            byte X = 200;                            
                       
            try
            {
               checked
                {
                    X++;
                }
                MessageBox.Show(X.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("溢位","Title");
                MessageBox.Show(ex.Message);                
            }            
            
        }        
    }
}
