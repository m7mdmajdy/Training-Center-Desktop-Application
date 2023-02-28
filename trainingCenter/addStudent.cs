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
            bool isValid;
            isValid = Utilities.validateNameInArabic(stuNameBox.Text);
            if (isValid)
            {
                label12.Visible = false;
            }
            else
            {
                label12.Visible = true;
            }
        }
    }
}
