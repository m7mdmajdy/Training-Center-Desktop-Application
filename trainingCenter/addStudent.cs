using trainingCenter.BL;
using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trainingCenter
{
    public partial class addStudent : MetroSetForm
    {
        public addStudent()
        {
           
            InitializeComponent();


        }

        private void addStudent_Load(object sender, EventArgs e)
        {

            this.TopMost = true;

            this.FormBorderStyle = FormBorderStyle.None;

            this.WindowState = FormWindowState.Maximized;
        }

        private void stuNameBox_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(stuNameBox.Text)|| stuNameBox.Text=="")
            {
                label12.Visible = true;
            }
            else if (!Regex.IsMatch(stuNameBox.Text, @"^[\u0621-\u064A_ ]+$"))

            {
                label12.Visible = true;
            }
            else
            {
                label12.Visible = false;
            }


        }
    }
}
