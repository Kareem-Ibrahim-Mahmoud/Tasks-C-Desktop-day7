using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskprog1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = (float.Parse(textBox1.Text) / 100).ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            int a;
            a = int.Parse(textBox1.Text);
            if (a == null)
            {
                throw new Exception("the Number empty...!");

            }
            else if (a <= 0)
            {
                throw new Exception("The Enter Number not eqal   + ....!");

            }
            else
            {


            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            textBox2.Text = (float.Parse(textBox1.Text) / 1000).ToString();
        

            /*

            if(radioButton1.Checked== true)
            {
                
               //radioButton1=  (textBox1 /int(1000));
                //radioButton1 = (textBox1 / 1000);

                textBox1 = textBox1 /1000;

                //textBox1 = textBox1 %1000;

            }
            else
            {
                MessageBox.Show("the error 201 ....!");
               
            }
            */

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = (float.Parse(textBox1.Text) / 10).ToString();

        }
    }
}
