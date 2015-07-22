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

namespace 번호표_대기_시스템
{
    public partial class Form3 : Form
    {
        private static Form3 instance;
        

        public Form3()
        {
            InitializeComponent();
            instance = this;
        }

        public static Form3 getinstance
        {
            get { return instance; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.getinstance.degi.Count == 0)
            {
                textBox1.Text = "NOT";
            }
            else
            {
                object temp = Form1.getinstance.degi.Dequeue();
                textBox1.Text = Convert.ToString(temp);
                textBox3.Text = Convert.ToString(Form1.getinstance.degi.Count);
                Form1.getinstance.richTextBox1.Text += temp + "번 호출 ------- 1번 창구\n";
                Form2.getinstance.textBox1.Text = Convert.ToString(Form1.getinstance.degi.Count);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Form1.getinstance.degi.Count == 0)
            {
                textBox2.Text = "NOT";
            }
            else
            {
                object temp = Form1.getinstance.degi.Dequeue();
                textBox2.Text = Convert.ToString(temp);
                textBox3.Text = Convert.ToString(Form1.getinstance.degi.Count);
                Form1.getinstance.richTextBox1.Text += temp + "번 호출 ------- 2번 창구\n";
                Form2.getinstance.textBox1.Text = Convert.ToString(Form1.getinstance.degi.Count);
            }
        }
    }
}
