using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Paret_windows
{
    
    public partial class Form_one : Form
    {
        public static string fname { get; set; }
        public static string lname { get; set; }
        public Form_one()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            fname = textBox1.Text; lname = textBox2.Text;
             Form_two two = new Form_two();
            two.Show();
        }

        private void Form_one_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
