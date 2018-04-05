using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        //variables to capture data entered
        public static string idValue = "";
        public static string nameValue = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //store textbox values in variables
            idValue = textBox1.Text;
            nameValue = textBox2.Text;
            //create form3
            Form3 f3 = new Form3();
            //display form3
            f3.Show();
        }
    }
}
