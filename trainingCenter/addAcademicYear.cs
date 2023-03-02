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
    public partial class addAcademicYear : MetroSetForm
    {
        bool isValidYear;

        EDPCenterEntities eDPCenterEntities;
        public addAcademicYear()
        {
            InitializeComponent();
            eDPCenterEntities = new EDPCenterEntities();

        }

        public bool checkValidation()
        {
            isValidYear = Utilities.checkDropDownList(academicYearBox.SelectedItem);
            if (!isValidYear)
            {
                label15.Visible = true;
                return false;
            }
            else
            {
                return true;
            }
        }
            private void NewDataGrid(List<AcademicYear> academicYears)
        {
            yearIdBox.Text = "";
            academicYearBox.SelectionStart = academicYearBox.Text.Length;
            textBox2.Text = "";

            dataGridView1.Rows.Clear();

            foreach (AcademicYear academicYear in academicYears)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = academicYear.ID;
                row.Cells[1].Value = academicYear.Name;
                dataGridView1.Rows.Add(row);
            }
        }
        private void addAcademicYear_Load(object sender, EventArgs e)
        {
            /*this.TopMost = true;

            this.FormBorderStyle = FormBorderStyle.None;

            this.WindowState = FormWindowState.Maximized;*/
            List<AcademicYear> academicYears = eDPCenterEntities.AcademicYears.ToList();
            NewDataGrid(academicYears);
            if (textBox2.Text.Length == 0)
                textBox2.Text = "ادخل الكود او الاسم";
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (checkValidation())
            {
                // check if the year already exsist in database
                var query = eDPCenterEntities.AcademicYears.Where(x => x.Name == academicYearBox.Text).FirstOrDefault();
                if (query!=null)
                {
                    MessageBox.Show("الصف الدراسى موجود بالفعل");
                }
                else
                {
                    
                    eDPCenterEntities.AcademicYears.Add(new AcademicYear { Name = academicYearBox.Text });
                    eDPCenterEntities.SaveChanges();
                    List<AcademicYear> academicYears = eDPCenterEntities.AcademicYears.ToList();
                    NewDataGrid(academicYears);
                    MessageBox.Show("تم اضافة الصف الدراسي");
                }
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

            if (yearIdBox.Text.Length == 0)
                MessageBox.Show("الرجاء اختيار الصف الدراسي من الجدول فى الاسفل");
            else
            {
                if (checkValidation())
                {
                    var query = eDPCenterEntities.AcademicYears.Where(x => x.Name == academicYearBox.Text).FirstOrDefault();
                    if (query!=null)
                    {
                        MessageBox.Show("الصف الدراسى موجود بالفعل");
                    }
                    else
                    {
                        int yearId = int.Parse(yearIdBox.Text);
                        AcademicYear academicYear = eDPCenterEntities.AcademicYears.Where(x => x.ID == yearId).FirstOrDefault();

                        academicYear.Name = academicYearBox.Text;
                        eDPCenterEntities.SaveChanges();

                        NewDataGrid(eDPCenterEntities.AcademicYears.ToList());
                        MessageBox.Show("تم تعديل بيانات الصف الدراسي");
                    }
                    
                }
                
            }
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("التأكيد على حذف المادة؟", "! تحذير", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int yearId = int.Parse(yearIdBox.Text);
                AcademicYear academicYear = eDPCenterEntities.AcademicYears.Where(x => x.ID == yearId).FirstOrDefault();
                eDPCenterEntities.AcademicYears.Remove(academicYear);
                eDPCenterEntities.SaveChanges();
                NewDataGrid(eDPCenterEntities.AcademicYears.ToList());
                MessageBox.Show(" ! تم حذف الصف الدراسي");
            }
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
                MessageBox.Show("ادخل قيمة في البحث");
            else if (textBox2.Text == "ادخل الكود او الاسم")
                MessageBox.Show("ادخل قيمة في البحث");
            else
            {
                int yearId;
                bool isNumber = int.TryParse(textBox2.Text, out yearId);

                List<AcademicYear> academicYears;
                if (isNumber)
                {
                    academicYears = eDPCenterEntities.AcademicYears.Where(a => a.ID == yearId).ToList();

                }
                else
                {
                    academicYears = eDPCenterEntities.AcademicYears.Where(a => a.Name.Contains(textBox2.Text)).ToList();/*
                    subjects = eDPCenterEntities.Subjects.Where(a => a.Sub_Name == textBox2.Text).ToList();*/
                }
                if (academicYears.Count > 0)
                    NewDataGrid(academicYears);
                else
                    MessageBox.Show("لا توجد نتائج");
            }
        }

        private void materialButton6_Click(object sender, EventArgs e)
        {
            NewDataGrid(eDPCenterEntities.AcademicYears.ToList());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[index];

            yearIdBox.Text = row.Cells[0].Value.ToString();
            academicYearBox.Text = row.Cells[1].Value.ToString();
        }
    }
}
