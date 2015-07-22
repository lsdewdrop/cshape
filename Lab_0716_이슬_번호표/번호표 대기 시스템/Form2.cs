using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 번호표_대기_시스템
{
    public partial class Form2 : Form
    {

        int i = 0;
        private static Form2 instance;

        public Form2()
        {
            InitializeComponent();
            instance = this;
        }
       
        public static Form2 getinstance
        {
            get { return instance; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            Form1.getinstance.degi.Enqueue(i);
            textBox1.Text = Convert.ToString(Form1.getinstance.degi.Count);
            Form3.getinstance.textBox3.Text = Convert.ToString(Form1.getinstance.degi.Count);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
