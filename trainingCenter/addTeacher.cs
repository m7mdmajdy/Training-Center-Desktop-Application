using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroSet_UI;

namespace trainingCenter
{
    public partial class addTeacher : MetroSet_UI.Forms.MetroSetForm
    {
        static EDPCenterEntities EDPDBContext = new EDPCenterEntities();
        List<Teacher> teachers;
        bool isValidName, isValidPhone, isValidAddress, isValidCash, isValidPercentage;

        public addTeacher()
        {
            InitializeComponent();
            teachers = EDPDBContext.Teachers.ToList();
            dataGridViewTeachers.DataSource = teachers;
            NormalizedDGV();
            //IQueryable<int> TeachersID = teachers.Select(d => d.T_ID);
        }

        private void materialButtonAdd_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                Teacher teacher = new Teacher { T_Name = textBox_TName.Text, T_Address = textBox_TAddress.Text, T_Percentage = Convert.ToDouble(textBox_TPercentage.Text) / 100.0d, T_Phone = textBox_TPhone.Text, T_Balance = textBox_TBalance.Text == "" ? 0 : int.Parse(textBox_TBalance.Text) };
                EDPDBContext.Teachers.Add(teacher);
                EDPDBContext.SaveChanges();
                teachers = EDPDBContext.Teachers.ToList();
                dataGridViewTeachers.DataSource = teachers;
            }
        }

        private void materialEdit_Click(object sender, EventArgs e)
        {
            if (textBox_TID.Text.Length == 0)
                MessageBox.Show("الرجاء اختيار مدرس من الجدول فى الاسفل");
            else
            {
                //if (IsValid())
                //{
                int id = int.Parse(textBox_TID.Text);
                Teacher teacher = EDPDBContext.Teachers.Where(t => t.T_ID == id).FirstOrDefault();

                teacher.T_Phone = textBox_TPhone.Text;
                teacher.T_Name = textBox_TName.Text;
                teacher.T_Address = textBox_TAddress.Text;
                teacher.T_Balance = int.Parse(textBox_TBalance.Text);
                teacher.T_Percentage = double.Parse(textBox_TPercentage.Text) / 100d;
                EDPDBContext.SaveChanges();
                dataGridViewTeachers.DataSource = EDPDBContext.Teachers.ToList();
                MessageBox.Show("تم تعديل بيانات المدرس بنجاح");
                //}

            }
        }

        private void materialDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل تريد حذف المدرس؟ لن يمكن استعادة بيانات العنصر المحذوف", "! تحذير", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = int.Parse(textBox_TID.Text);
                Teacher teacher = EDPDBContext.Teachers.Where(t => t.T_ID == id).FirstOrDefault();
                EDPDBContext.Teachers.Remove(teacher);
                EDPDBContext.SaveChanges();
                teachers = EDPDBContext.Teachers.ToList();
                dataGridViewTeachers.DataSource = teachers;
                MessageBox.Show("تم حذف بيانات المدرس بنجاح");
            }
        }

        private void materialButton6_Click(object sender, EventArgs e)
        {
            dataGridViewTeachers.DataSource = EDPDBContext.Teachers.ToList();
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            if (textBox_Filter.Text.Length == 0)
                MessageBox.Show("ادخل قيمة في البحث");
            else if (textBox_Filter.Text == "ادخل الكود او الاسم")
                MessageBox.Show("ادخل قيمة في البحث");
            else
            {
                int id;
                bool isNumber = int.TryParse(textBox_Filter.Text, out id);

                List<Teacher> teachers;
                if (isNumber)
                {
                    teachers = EDPDBContext.Teachers.Where(t => t.T_ID == id).ToList();
                }
                else
                {
                    teachers = EDPDBContext.Teachers.Where(t => t.T_Name.Contains(textBox_Filter.Text)).ToList();
                }
                if (teachers.Count > 0)
                    dataGridViewTeachers.DataSource = teachers;
                else
                    MessageBox.Show("لا توجد نتائج");
            }
        }

        private void dataGridViewTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0) return;
            DataGridViewRow row = dataGridViewTeachers.Rows[index];
            textBox_TID.Text = row.Cells[0].Value.ToString();
            textBox_TName.Text = row.Cells[1].Value.ToString();
            textBox_TPhone.Text = row.Cells[2].Value.ToString();
            textBox_TAddress.Text = row.Cells[3].Value.ToString();
            textBox_TBalance.Text = row.Cells[4].Value.ToString();
            textBox_TPercentage.Text = (Convert.ToDouble(row.Cells[5].Value) * 100).ToString();
        }

        private void dataGridViewTeachers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("ContentClick");
        }

        public void NormalizedDGV()
        {
            dataGridViewTeachers.Columns[8].Visible = false;
            dataGridViewTeachers.Columns[7].Visible = false;
            dataGridViewTeachers.Columns[6].Visible = false;
            //dataGridViewTeachers.AutoGenerateColumns = true;
            //dataGridViewTeachers.Columns.RemoveAt(dataGridViewTeachers.Columns.Count - 3 );
            //dataGridViewTeachers.Columns.RemoveAt(dataGridViewTeachers.Columns.Count - 2);
            //dataGridViewTeachers.Columns.RemoveAt(dataGridViewTeachers.Columns.Count - 1);
            ////dataGridViewTeachers.Columns.Remove("GroupName");
            //dataGridViewTeachers.Columns.Remove("Subject");
            //dataGridViewTeachers.Columns.Remove("AcademicYear");
        }
        public bool IsValid()
        {
            //checked validation
            isValidName = BL.Utilities.validateNameInArabic(textBox_TName.Text);
            isValidAddress = BL.Utilities.validateNameInArabic(textBox_TAddress.Text);
            isValidPhone = BL.Utilities.ValidatPhoneNumber(textBox_TPhone.Text);
            isValidCash = BL.Utilities.checkDoubleNumber(textBox_TBalance.Text);
            //try
            //{
            isValidPercentage = BL.Utilities.checkDoubleNumber(textBox_TBalance.Text) && double.Parse(textBox_TPercentage.Text) >= 0.0 && double.Parse(textBox_TPercentage.Text) <= 100.0 ? true : false;
            //}
            //catch (StringFormat e)
            //{
            //}
            //foreach (Label lbl in Controls)
            if (!isValidName)
            {
                lblNameValid.Visible = true;
                return false;
            }

            if (!isValidAddress)
            {
                lblAddressValid.Visible = true;
                return false;
            }

            if (!isValidPhone)
            {
                lblPhoneValid.Visible = true;
                return false;
            }

            if (!isValidPercentage)
            {
                lblPercentageValid.Visible = true;
                return false;
            }
            if (!isValidCash)
            {
                lblBalanceValidation.Visible = true;
                return false;
            }
            else
            {
                lblNameValid.Visible = false;
                lblAddressValid.Visible = false;
                lblPhoneValid.Visible = false;
                lblPercentageValid.Visible = false;
                lblBalanceValidation.Visible = false;
                return true;
            }
        }

        private void textBox_TName_Leave(object sender, EventArgs e)
        {
            isValidName = BL.Utilities.validateNameInArabic(textBox_TName.Text);
            if (isValidName)
                lblNameValid.Visible = false;
        }

        private void textBox_TPhone_Leave(object sender, EventArgs e)
        {
            isValidPhone = BL.Utilities.ValidatPhoneNumber(textBox_TPhone.Text);
            if (isValidPhone)
                lblPhoneValid.Visible = false;
        }
        private void textBox_TAddress_Leave(object sender, EventArgs e)
        {
            isValidAddress = BL.Utilities.validateNameInArabic(textBox_TAddress.Text);
            if (isValidAddress)
                lblAddressValid.Visible = false;
        }
        private void textBox_TPercentage_Leave(object sender, EventArgs e)
        {
            isValidPercentage = BL.Utilities.checkDoubleNumber(textBox_TBalance.Text) && double.Parse(textBox_TPercentage.Text) >= 0.0 && double.Parse(textBox_TPercentage.Text) <= 100.0 ? true : false;
            if (isValidPercentage)
                lblPercentageValid.Visible = false;
        }
        private void textBox_TBalance_Leave(object sender, EventArgs e)
        {
            isValidCash = BL.Utilities.checkDoubleNumber(textBox_TBalance.Text);
            if (isValidCash)
                lblBalanceValidation.Visible = false;
        }
    }
}
