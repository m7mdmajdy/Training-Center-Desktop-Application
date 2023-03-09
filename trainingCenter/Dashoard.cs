using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trainingCenter.BL;

namespace trainingCenter
{
    public partial class Dashboard : MetroSetForm
    {
        

        EDPCenterEntities eDPCenterEntities;
        public Dashboard()
        {
            InitializeComponent();
            eDPCenterEntities = new EDPCenterEntities();

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(25, 90, 200);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(13,71, 161);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1.Size = new Size(this.Width,this.Height);
            addStudent addStudent = new addStudent ();
            addStudent.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addGroup addGroup = new addGroup ();
            addGroup.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addSubject addSubjectadd = new addSubject ();
            addSubjectadd.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addAcademicYear addyear = new addAcademicYear ();
            addyear.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            StudentAttendance studentAttendance = new StudentAttendance ();
            studentAttendance.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            GestWorkSpaceAttend gestWorkSpaceAttend = new GestWorkSpaceAttend ();
            gestWorkSpaceAttend.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AddCostes addCostesadd = new AddCostes ();
            addCostesadd.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            totalIncomes totalIncomes = new totalIncomes();
            totalIncomes.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            addSchedule addSchedule = new addSchedule ();
            addSchedule.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            addoutcomes addoutcomesadd = new addoutcomes ();
            addoutcomesadd.ShowDialog();
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(25, 90, 200);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(13, 71, 161);
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(25, 90, 200);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(13, 71, 161);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(25, 90, 200);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(13, 71, 161);
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            button7.BackColor = Color.FromArgb(25, 90, 200);
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.FromArgb(13, 71, 161);
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(25, 90, 200);
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(13, 71, 161);
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button13.BackColor = Color.FromArgb(13, 71, 161);
        }

        private void button13_MouseHover(object sender, EventArgs e)
        {
            button13.BackColor = Color.FromArgb(25, 90, 200);
        }

        private void button15_MouseHover(object sender, EventArgs e)
        {
            button15.BackColor = Color.FromArgb(25, 90, 200);
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            button15.BackColor = Color.FromArgb(13, 71, 161);
        }

        private void button12_MouseHover(object sender, EventArgs e)
        {
            button12.BackColor = Color.FromArgb(25, 90, 200);
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button12.BackColor = Color.FromArgb(13, 71, 161);
        }

        private void button11_MouseHover(object sender, EventArgs e)
        {
            button11.BackColor = Color.FromArgb(25, 90, 200);
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.BackColor = Color.FromArgb(13, 71, 161);
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {
            button10.BackColor = Color.FromArgb(25, 90, 200);
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.BackColor = Color.FromArgb(13, 71, 161);
        }
    }
}
