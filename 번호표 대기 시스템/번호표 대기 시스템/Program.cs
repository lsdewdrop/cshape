using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 번호표_대기_시스템
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 fm1 = new Form1();
            Form2 fm2 = new Form2();
            Form3 fm3 = new Form3();

            fm3.Show();
            fm2.Show();
            Application.Run(fm1);

            
        }
    }
}
