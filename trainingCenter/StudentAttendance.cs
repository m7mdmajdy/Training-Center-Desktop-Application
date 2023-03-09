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
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity;

namespace trainingCenter
{
    public partial class StudentAttendance : MetroSetForm
    {
        
        EDPCenterEntities eDPCenterEntities;
        public StudentAttendance()
        {

            InitializeComponent();
            eDPCenterEntities = new EDPCenterEntities();
            MinimumSize = MaximumSize = Size;

        }

        private void StudentAttendance_Load(object sender, EventArgs e)
        {
            List<Teacher> TeacherNames = eDPCenterEntities.Teachers.ToList();
            comboBox2.DataSource = TeacherNames;
            comboBox2.ValueMember = "T_ID";
            comboBox2.DisplayMember = "T_Name";
            NewDataGrid(eDPCenterEntities.Attendences.ToList());

            //adjust color of Data Grid View
            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[5].DefaultCellStyle.ForeColor = Color.Black;
            //dataGridView1.Columns[6].DefaultCellStyle.ForeColor = Color.Black;
           // dataGridView1.Columns[7].DefaultCellStyle.ForeColor = Color.Black;


        }


        private void NewDataGrid(List<Subject> subjects)
        {
            dataGridView1.Rows.Clear();

            foreach (Subject subject in subjects)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = subject.Sub_ID;
                row.Cells[1].Value = subject.Sub_Name;
                dataGridView1.Rows.Add(row);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var temp = Convert.ToInt32(comboBox2.SelectedValue.ToString());
            List<GroupName> groupNames = eDPCenterEntities.GroupNames.Where(m => m.Teacher_ID == temp).ToList();
            comboBox3.DataSource = groupNames;
            comboBox3.ValueMember = "G_ID";
            comboBox3.DisplayMember = "G_Name";
        }
        
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var teacher = Convert.ToInt32(comboBox2.SelectedValue.ToString());
            var groupId = Convert.ToInt32(comboBox3.SelectedValue.ToString());

            //List<Student_Group> student_Groups = eDPCenterEntities.Student_Group.Where(m => m.G_ID == group).ToList();

            List<Student> studnet = (from g in eDPCenterEntities.Student_Group
                                     from s in eDPCenterEntities.Students
                                     where g.St_ID == s.St_ID && g.G_ID == groupId
                                     select s).ToList();


            comboBox1.DataSource = studnet;
            comboBox1.ValueMember = "St_Id";
            comboBox1.DisplayMember = "St_Name";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int studentId = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            string phone = eDPCenterEntities.Students.Where(x=>x.St_ID==studentId).Select(x=>x.St_Phone).FirstOrDefault();
            if (phone != null)
            {
                textBox2.Text = phone;
            }
            stu_IDBox.Text=studentId.ToString();
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            addStudent addStudent = new addStudent();
            addStudent.Show();
        }

        private void stu_IDBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
            if (e.KeyChar.Equals((char)13))
            {
                int studentId;
                bool isNum = int.TryParse(stu_IDBox.Text, out studentId);
                if (studentId>0&&isNum)
                {
                    Student student = eDPCenterEntities.Students.Where(x => x.St_ID == studentId).FirstOrDefault();
                    if(student != null)
                    {
                        textBox2.Text=student.St_Phone;
                        int groupId = Convert.ToInt32(comboBox3.SelectedValue.ToString());
                        int studId = Convert.ToInt32(Convert.ToInt32(stu_IDBox.Text));
                        bool isPaid = false;

                        Student_Group studentPaid = eDPCenterEntities.Student_Group.Where(x=>x.G_ID==groupId && x.St_ID==studentId).FirstOrDefault();
                        if(studentPaid == null)
                        {
                            Attendence attendence = new Attendence
                            {
                                G_ID = groupId,
                                St_ID = studId,
                                Att_Date = DateTime.Now,
                                Payment_State = false,
                            };
                            eDPCenterEntities.Attendences.Add(attendence);
                            eDPCenterEntities.SaveChanges();
                        }
                        else
                        {
                            if (studentPaid.Payment_Method == "الشهر")
                            {
                                ////// Must implement minus price of session

                                /*double? coursePrice = eDPCenterEntities.GroupNames.Where(x => x.G_ID == groupId).FirstOrDefault().G_PriceOfSession;
                                studentPaid.St_Balance -= coursePrice;*/


                                double? priceOfSession = eDPCenterEntities.GroupNames.Find(groupId).G_PriceOfSession;
                                studentPaid.St_Balance -= priceOfSession;
                                double? balance = eDPCenterEntities.Student_Group.Where(x=>x.St_ID==studId && x.G_ID == groupId).FirstOrDefault().St_Balance;
                                isPaid = balance > priceOfSession ? true: false;
                            }
                            else
                            {
                                isPaid=false;
                            }
                            eDPCenterEntities.Entry(studentPaid).State=EntityState.Modified;
                            Attendence attendence = new Attendence
                            {
                                G_ID = groupId,
                                St_ID = studId,
                                Att_Date = DateTime.Now,
                                Payment_State = isPaid,
                            };
                            eDPCenterEntities.Attendences.Add(attendence);
                            eDPCenterEntities.SaveChanges();

                        }
                    }
                    else
                    {
                        MessageBox.Show("لا يوجد طالب بهذا الكود");
                    }
                    NewDataGrid(eDPCenterEntities.Attendences.Take(150).ToList());
                }
                else
                {
                    MessageBox.Show("برجاء ادخال قيمة صحيحة");
                }
            }
            
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            int studentId;
            bool isNum = int.TryParse(stu_IDBox.Text, out studentId);
            if (studentId > 0 && isNum)
            {
                Student student = eDPCenterEntities.Students.Where(x => x.St_ID == studentId).FirstOrDefault();
                if (student != null)
                {
                    textBox2.Text = student.St_Phone;
                    int groupId = Convert.ToInt32(comboBox3.SelectedValue.ToString());
                    int studId = Convert.ToInt32(Convert.ToInt32(stu_IDBox.Text));
                    bool isPaid = false;

                    Student_Group studentPaid = eDPCenterEntities.Student_Group.Where(x => x.G_ID == groupId && x.St_ID == studentId).FirstOrDefault();
                    if (studentPaid == null)
                    {
                        Attendence attendence = new Attendence
                        {
                            G_ID = groupId,
                            St_ID = studId,
                            Att_Date = DateTime.Now,
                            Payment_State = false,
                        };
                        eDPCenterEntities.Attendences.Add(attendence);
                        eDPCenterEntities.SaveChanges();
                    }
                    else
                    {
                        if (studentPaid.Payment_Method == "الشهر")
                        {

                            ////// Must implement minus price of session
                            double? priceOfSession = eDPCenterEntities.GroupNames.Find(groupId).G_PriceOfSession;
                            studentPaid.St_Balance -= priceOfSession;
                            double? balance = eDPCenterEntities.Student_Group.Where(x => x.St_ID == studId && x.G_ID == groupId).FirstOrDefault().St_Balance;
                            isPaid = balance > priceOfSession ? true : false;
                        }
                        else
                        {
                            isPaid = false;
                        }
                        Attendence attendence = new Attendence
                        {
                            G_ID = groupId,
                            St_ID = studId,
                            Att_Date = DateTime.Now,
                            Payment_State = isPaid,
                        };
                        eDPCenterEntities.Attendences.Add(attendence);
                        eDPCenterEntities.SaveChanges();

                    }
                }
                else
                {
                    MessageBox.Show("لا يوجد طالب بهذا الكود");
                }
                NewDataGrid(eDPCenterEntities.Attendences.Take(150).ToList());
            }
            else
            {
                MessageBox.Show("برجاء ادخال قيمة صحيحة");
            }
        }

        private void NewDataGrid(List<Attendence> attendences)
        {

            dataGridView1.Rows.Clear();
            foreach (Attendence attendence in attendences)
            {
                string studName = eDPCenterEntities.Students.Where(x => x.St_ID == attendence.St_ID).FirstOrDefault().St_Name;
                GroupName groupName = eDPCenterEntities.GroupNames.Where(x=>x.G_ID == attendence.G_ID).FirstOrDefault();
                Teacher teacherName = eDPCenterEntities.Teachers.Where(x => x.T_ID == groupName.Teacher_ID).FirstOrDefault();

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = attendence.St_ID;
                row.Cells[1].Value = studName;
                row.Cells[2].Value = teacherName.T_Name;
                row.Cells[3].Value = groupName.G_Name;
                row.Cells[4].Value = attendence.Att_Date;
                row.Cells[5].Value = attendence.Payment_State;

                if (row.Cells[5].Value.ToString() == "False")
                {
                    row.DefaultCellStyle.BackColor = Color.DarkRed;
                    row.DefaultCellStyle.ForeColor = Color.LightGray;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }


                dataGridView1.Rows.Add(row);



            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[index];
                if (row.Cells[0].Value != null)
                {
                    
                    int studId=Convert.ToInt32(row.Cells[0].Value);
                    string attDate=row.Cells[4].Value.ToString();

                    Attendence attendence = 
                        eDPCenterEntities
                        .Attendences.ToList()
                        .Where(a=>a.Att_Date.ToString() ==attDate && a.St_ID == studId)
                        .FirstOrDefault();
                    studentPayment stPayment = new studentPayment(attendence);
                    stPayment.ShowDialog();

                }
                else
                {
                    MessageBox.Show("لا توجد قيمة");
                }
            }
        }
    }
}
