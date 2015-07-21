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
    public partial class Form1 : Form
    {
        public Queue degi = new Queue();
        private static Form1 instance;
        
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        public static Form1 getinstance
        {
            
            get { return instance; }
        }

        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
