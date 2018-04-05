using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EADmockTest
{
    public partial class Form1 : Form
    {
        //public static string fname = "";
        //public static string lname = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        Person p1 = new Person();
        private void button1_Click(object sender, EventArgs e)
        {
            p1.fname = firstnameBox.Text;
            p1.lname = lastnameBox.Text;

            Invoice inv = new Invoice();
            inv.Show();

        }
    }
}
