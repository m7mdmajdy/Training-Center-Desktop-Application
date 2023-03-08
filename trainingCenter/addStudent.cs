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

namespace trainingCenter
{
    public partial class addStudent : MetroSetForm
    {
        bool isValidName;
        bool isValidPhone;
        //bool isValidSchoolName;
        //bool isValidAge;
        bool isValidParentPhone;
        //bool isValidAddress;
        bool isValidLanguage;
        bool isValidYear;

        EDPCenterEntities eDPCenterEntities;
        public addStudent()
        {

            InitializeComponent();
            eDPCenterEntities = new EDPCenterEntities();

        }
         private bool checkValidation()
        {
            //checked validation
            isValidName = Utilities.validateNameInArabic(stuNameBox.Text);
            isValidPhone = Utilities.ValidatPhoneNumber(phoneBox.Text);
            //isValidSchoolName = Utilities.validateNameInArabic(schoolNameBox.Text);
            //isValidAge = ageUpDownMenu.Value >5 && ageUpDownMenu.Value <25;
            isValidParentPhone = Utilities.ValidatPhoneNumber(parentPhoneBox.Text);
            //isValidAddress = Utilities.validateNameInArabic(addressBox.Text);
            isValidLanguage =Utilities.checkDropDownList(languageBox.SelectedItem);
            isValidYear = Utilities.checkDropDownList(academicYearBox.SelectedItem);

            if (!isValidName)
            {
                label12.Visible = true;
                return false;
            }
             if(!isValidPhone)
            {
                label13.Visible = true;
                return false;
            }
            if (!isValidYear)
            {
                label15.Visible = true;
                return false;
            }

            if (!isValidParentPhone)
            {
                label14.Visible = true;
                return false;
            }
            
             if(!isValidLanguage)
            {
                label16.Visible = true;
                return false;
            }
            else
            {
                label12.Visible = false;
                label13.Visible = false;
                label15.Visible = false;
                label14.Visible = false;
                label16.Visible = false;
                return true;
            }
            

        }
        private void addStudent_Load(object sender, EventArgs e)
        {
            /*this.TopMost = true;

            this.FormBorderStyle = FormBorderStyle.None;

            this.WindowState = FormWindowState.Maximized;*/

            if (textBox2.Text.Length == 0)
                textBox2.Text = "ادخل الكود او الاسم";

            EDPCenterEntities x = new EDPCenterEntities();
            List<Student> studs = x.Students.ToList();
            NewDataGrid(studs);

        }

      

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (checkValidation())
            {
                string gender = radioButton2.Checked ? "أنثي" : "ذكر";
                Student student = new Student()
                {
                    St_Name = stuNameBox.Text,
                    St_Phone = phoneBox.Text,
                    St_Parent_Phone = parentPhoneBox.Text,
                    St_Gender = gender,
                    St_Address = addressBox.Text,
                    St_Age = Convert.ToInt32(ageUpDownMenu.Value),
                    St_Grade = academicYearBox.Text,
                    St_Language = languageBox.Text,
                    St_School_Name = schoolNameBox.Text,
                };
                eDPCenterEntities.Students.Add(student);
                eDPCenterEntities.SaveChanges();
                MessageBox.Show("تم اضافة الطالب");
                List<Student> students = eDPCenterEntities.Students.ToList();
                NewDataGrid(students);
            }


        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            // check if search field is empty
            if (textBox2.Text.Length == 0)
                MessageBox.Show("ادخل قيمة في البحث");
            else if(textBox2.Text == "ادخل الكود او الاسم")
                    MessageBox.Show("ادخل قيمة في البحث");
            else
            {
                int studId;
                bool isNumber = int.TryParse(textBox2.Text, out studId);

                List<Student> students;
                if (isNumber)
                {
                    students = eDPCenterEntities.Students.Where(a => a.St_ID == studId).ToList();

                }
                else
                {
                    students = eDPCenterEntities.Students.Where(a => a.St_Name.Contains(textBox2.Text)).ToList();
                }
                if (students.Count > 0)
                    NewDataGrid(students);
                else
                    MessageBox.Show("لا توجد نتائج");
            }
        }

       
        private void NewDataGrid(List<Student> students)
        {
            stu_IDBox.Text = "";
            stuNameBox.Text = "";
            schoolNameBox.Text = "";
            phoneBox.Text = "";
            parentPhoneBox.Text = "";
            ageUpDownMenu.Value = 0;
            languageBox.Text = "";
            academicYearBox.Text = "";
            addressBox.Text = "";
            textBox2.Text = "";
            radioButton1.Checked = true;

            dataGridView1.Rows.Clear();

            foreach (Student stud in students)
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



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // To determine row number         

            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[index];
                if (row.Cells[0].Value != null)
                {
                    stu_IDBox.Text = row.Cells[0].Value.ToString();
                    stuNameBox.Text = row.Cells[1].Value.ToString();
                    phoneBox.Text = row.Cells[2].Value.ToString();
                    parentPhoneBox.Text = row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : "";
                    if (row.Cells[4].Value.ToString() == "أنثي")
                    {
                        radioButton2.Checked = true;
                    }
                    else
                    {
                        radioButton1.Checked = true;
                    }
                    addressBox.Text = row.Cells[5].Value != null ? row.Cells[5].Value.ToString() : "";
                    ageUpDownMenu.Text = row.Cells[6].Value.ToString();
                    academicYearBox.Text = row.Cells[7].Value.ToString();
                    schoolNameBox.Text = row.Cells[8].Value != null ? row.Cells[8].Value.ToString() : "";
                    languageBox.Text = row.Cells[9].Value.ToString();
                }
                else
                {
                    MessageBox.Show("لا توجد قيمة");
                }
            }



        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (stu_IDBox.Text.Length == 0)
                MessageBox.Show("الرجاء اختيار طالب من الجدول فى الاسفل");
            else
            {
                if (checkValidation())
                {
                    int studId = int.Parse(stu_IDBox.Text);
                    Student student = eDPCenterEntities.Students.Where(x => x.St_ID == studId).FirstOrDefault();

                    string gender = radioButton2.Checked ? "أنثي" : "ذكر";

                    student.St_Name = stuNameBox.Text;
                    student.St_Phone = phoneBox.Text;
                    student.St_Parent_Phone = parentPhoneBox.Text;
                    student.St_Gender = gender;
                    student.St_Address = addressBox.Text;
                    student.St_Age = int.Parse(ageUpDownMenu.Value.ToString());
                    student.St_Grade = academicYearBox.Text;
                    student.St_Language = languageBox.Text;
                    student.St_School_Name = schoolNameBox.Text;

                    eDPCenterEntities.SaveChanges();

                    NewDataGrid(eDPCenterEntities.Students.ToList());
                    MessageBox.Show("تم تعديل بيانات الطالب");
                }
                
            }

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("التأكيد على حذف الطالب؟", "! تحذير" , MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int studId = int.Parse(stu_IDBox.Text);
                Student student = eDPCenterEntities.Students.Where(x => x.St_ID == studId).FirstOrDefault();
                eDPCenterEntities.Students.Remove(student);
                eDPCenterEntities.SaveChanges();
                NewDataGrid(eDPCenterEntities.Students.ToList());
                MessageBox.Show(" ! تم حذف الطالب");
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }

        }

        private void materialButton6_Click(object sender, EventArgs e)
        {
            NewDataGrid(eDPCenterEntities.Students.ToList());
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if(textBox2.Text.Length == 0 )
                textBox2.Text = "ادخل الكود او الاسم";
        }


        // validate when leaving dield 
        private void stuNameBox_Leave(object sender, EventArgs e)
        {
            isValidName = Utilities.validateNameInArabic(stuNameBox.Text);
            if (isValidName)
            {
                label12.Visible = false;

            }
            
        }

        private void phoneBox_Leave(object sender, EventArgs e)
        {
            isValidPhone = Utilities.ValidatPhoneNumber(phoneBox.Text);
            if (isValidPhone)
            {
                label13.Visible = false;
            }
        }

        private void academicYearBox_Leave(object sender, EventArgs e)
        {
            isValidYear = Utilities.checkDropDownList(academicYearBox.SelectedItem);
            if (isValidYear)
            {
                label15.Visible = false;
            }
        }

        private void parentPhoneBox_Leave(object sender, EventArgs e)
        {
            if (isValidParentPhone)
            {
                label14.Visible = false;
            }
        }

        private void languageBox_Leave(object sender, EventArgs e)
        {
            isValidLanguage =Utilities.checkDropDownList(languageBox.SelectedItem);
            if (isValidLanguage)
            {
                label16.Visible = false;
            }
        }
    }
}
