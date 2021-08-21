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
    public partial class Form_two : Form
    {
        public Form_two()
        {
            InitializeComponent();
        }

        private void Form_two_Load(object sender, EventArgs e)
        {
           
            textBox1.Text = Form_one.fname;
            textBox2.Text = Form_one.lname;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
