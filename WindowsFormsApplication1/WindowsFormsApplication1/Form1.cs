using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] names = new string[5];
            names[0] = "Deigo";
            names[1] = "Manny";
            names[2] = "Anne";
            names[3] = "Robert";
            names[4] = "Kevin";

            int ctr = 0;

            foreach (string d in names)
            {
                MessageBox.Show("The Result for array of name:" + names[ctr]);
                ctr++;
            }
        }
    }
}
