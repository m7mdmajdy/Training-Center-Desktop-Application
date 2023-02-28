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
            /*this.TopMost = true;

            this.FormBorderStyle = FormBorderStyle.None;

            this.WindowState = FormWindowState.Maximized;*/


            EDPCenterEntities x = new EDPCenterEntities();
            List<Student> studs = x.Students.ToList();
            foreach(Student stud in studs)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = stud.St_ID;
                row.Cells[1].Value = stud.St_Name;
                row.Cells[2].Value = stud.St_Phone;
                row.Cells[3].Value = stud.St_Parent_Phone;
                row.Cells[4].Value = stud.St_Gender;
                row.Cells[5].Value = stud.St_Address;
                row.Cells[6].Value = stud.St_Age;
                row.Cells[7].Value = stud.St_Grade;
                row.Cells[8].Value = stud.St_School_Name;
                row.Cells[9].Value = stud.St_Language;
                dataGridView1.Rows.Add(row);
            }

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

        private void materialButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
