using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                int nb = 80;
                long[] my_arr = new long[nb+1];
                my_arr[0] = 0; my_arr[1] = 1;   //定義起始f(0) 與 f(1)

                for (int i = 2; i < nb+1; i++)
                {
                    my_arr[i] = (my_arr[i - 1] + my_arr[i - 2]);
                }
                for (int i = 1; i < nb+1; i++)
                {
                    tb_show.Text += "f(" + (i).ToString() + ") = " + (my_arr[i]).ToString() + "\r\n";
                }
            }
            catch { my_error(); }
            
        }



        private void my_error(){
            MessageBox.Show("Error!", "Error!");
        }


    }
}
