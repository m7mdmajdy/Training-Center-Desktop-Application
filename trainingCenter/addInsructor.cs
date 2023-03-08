using trainingCenter.BL;
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
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Reflection;


namespace trainingCenter

{
    public partial class addInstructor : MetroSetForm
    {
        EDPCenterEntities eDPCenterEntities;
        bool isValidName;
        bool isValidPhone;
        public addInstructor()
        {
            InitializeComponent();
            eDPCenterEntities = new EDPCenterEntities();
        }

        #region checkValidation Functaion
        public bool checkValidation()
        {

            isValidName = Utilities.validateNameInArabic(txtbInstructorName.Text);
            isValidPhone = Utilities.ValidatPhoneNumber(txtbInstructorPhone.Text);

            if (!isValidName)
            {
                lblValidNameArabic.Visible = true;
                return false;
            }
            if (!isValidPhone)
            {
                lblValidPhoneNumber.Visible = true;
                return false;
            }
            else
            {
                lblValidNameArabic.Visible = false;
                lblValidPhoneNumber.Visible = false;
                return true;
            }


        }
        #endregion

        #region FormLoad
        private void addInstructor_Load(object sender, EventArgs e)
        {
            #region fullscreen
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            // this.WindowState = FormWindowState.Maximized;
            #endregion

            #region [نص البحث]
            if (txtbInstractureSearch.Text.Length == 0)
                txtbInstractureSearch.Text = "ادخل الكود او الاسم";
            #endregion

            #region TO get row data from DB &Added in dgv form
            EDPCenterEntities x = new EDPCenterEntities();
            List<Instructor> instr = x.Instructors.ToList();
            NewDataGrid(instr); 
            #endregion

        } 
        #endregion

        #region button [اضافه]
        private void addinstructor_btbevent(object sender, EventArgs e)
        {
            if (checkValidation())
            {
                string Name  = txtbInstructorName.Text;
                string phone = txtbInstructorPhone.Text;
                Instructor instructory = eDPCenterEntities.Instructors.Where(x => x.Name == Name).Where(y => y.Phone == phone).FirstOrDefault();

                if (instructory==null)
                {
                    Instructor instructor = new Instructor()
                    {
                        Name = txtbInstructorName.Text,
                        Phone = txtbInstructorPhone.Text
                    };
                    eDPCenterEntities.Instructors.Add(instructor);
                    eDPCenterEntities.SaveChanges();
                    MessageBox.Show("تم اضافة المدرب");
                    List<Instructor> instructors = eDPCenterEntities.Instructors.ToList();
                    NewDataGrid(instructors); 
                }
                else
                    MessageBox.Show("هذا المدرب موجود بالفعل في قواعد البيانات");
            }
        }
        #endregion
        
        #region button [البحث]
        private void btnserche(object sender, EventArgs e)
        {
            // check if search field is empty
            if (txtbInstractureSearch.Text.Length == 0)
                MessageBox.Show("ادخل قيمة في البحث");
            else if (txtbInstractureSearch.Text == "ادخل الكود او الاسم")
                MessageBox.Show("ادخل قيمة في البحث");
            //get Data from DB
            else
            {
                int InstId;
                bool isNumber = int.TryParse(txtbInstractureSearch.Text, out InstId);

                List<Instructor> instructor;
                if (isNumber)
                {
                    instructor = eDPCenterEntities.Instructors.Where(a => a.ID == InstId).ToList();

                }
                else
                {
                    instructor = eDPCenterEntities.Instructors.Where(a => a.Name.Contains(txtbInstractureSearch.Text)).ToList();
                }
                if (instructor.Count > 0)
                    NewDataGrid(instructor);
                else
                    MessageBox.Show("لا توجد نتائج");
            }
        }
        #endregion
       
        #region button[تعديل]
        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (txtbInstructorID.Text.Length == 0)
                MessageBox.Show("الرجاء اختيار مدرب من الجدول فى الاسفل");
            else
            {
                if (checkValidation())
                {

                    int InstId = int.Parse(txtbInstructorID.Text);
                    Instructor instructor = eDPCenterEntities.Instructors.Where(x => x.ID == InstId).FirstOrDefault();
                    instructor.Name = txtbInstructorName.Text;
                    instructor.Phone = txtbInstructorPhone.Text;

                    eDPCenterEntities.SaveChanges();
                    NewDataGrid(eDPCenterEntities.Instructors.ToList());
                    MessageBox.Show("تم تعديل بيانات المدرب");
                }

            }
        }
        #endregion
         
        #region Button [حذف]
        private void materialButton3_Click(object sender, EventArgs e)
        {
            if (txtbInstructorID.Text.Length == 0)
                MessageBox.Show("الرجاء اختيار مدرب من الجدول فى الاسفل");
            else
            {
                DialogResult dialogResult = MessageBox.Show("التأكيد على حذف المدرب؟", "! تحذير", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int InstId = int.Parse(txtbInstructorID.Text);
                    Instructor instructor = eDPCenterEntities.Instructors.Where(x => x.ID == InstId).FirstOrDefault();
                    eDPCenterEntities.Instructors.Remove(instructor);
                    eDPCenterEntities.SaveChanges();
                    NewDataGrid(eDPCenterEntities.Instructors.ToList());
                    MessageBox.Show(" ! تم حذف المدرب");
                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }
        }
        #endregion

        #region dataGridView1_CellClick
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row ;
            // To determine row number
            if (e.RowIndex >= 0)
            {
                row = (DataGridViewRow)dgvInstructure.Rows[index];
                txtbInstructorID.Text = row.Cells[0].Value?.ToString() ?? "";
                txtbInstructorName.Text = row.Cells[1].Value?.ToString() ?? "";
                txtbInstructorPhone.Text = row.Cells[2].Value?.ToString() ?? "";
            }
            else
                MessageBox.Show("الرجاء اختيار مدرب من الجدول فى الاسفل");
               index = 0;
               row = (DataGridViewRow)dgvInstructure.Rows[index];
        }
        #endregion

        #region [مربع البحث النص]
        private void txtbSearch_Enter(object sender, EventArgs e)
        {
            txtbInstractureSearch.Text = "";
        }
        private void txtbSearch_Leave(object sender, EventArgs e)
        {
            if(txtbInstractureSearch.Text=="")
            txtbInstractureSearch.Text = "ادخل الكود او الاسم";
        }
        #endregion
        
        #region Button[عرض الكل]
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            NewDataGrid(eDPCenterEntities.Instructors.ToList());
        }
        #endregion

        #region [TextBoxLeave(Name,Phone)Validation]
        private void instructorName_Leave(object sender, EventArgs e)
        {
            //isValidName = Utilities.validateNameInArabic(txtbInstructorName.Text);
            //if (isValidName)
            //    lblValidNameArabic.Visible = false;
            //    lblValidNameArabic.Visible = true;
            checkValidation();
        }

        private void phoneinstructor_Leave(object sender, EventArgs e)
        {
            //isValidPhone = Utilities.ValidatPhoneNumber(txtbInstructorPhone.Text);
            //if (isValidPhone)
            //    lblValidPhoneNumber.Visible = false;
            //    lblValidPhoneNumber.Visible = true;
            checkValidation();
        }
        #endregion

        #region NewdataGrid Function
        private void NewDataGrid(List<Instructor> instructors)
        {
            txtbInstructorID.Text = "";
            txtbInstructorName.Text = "";
            txtbInstructorPhone.Text = "";
            dgvInstructure.Rows.Clear();

            foreach (Instructor instr in instructors)
            {
                DataGridViewRow row = (DataGridViewRow)dgvInstructure.Rows[0].Clone();
                row.Cells[0].Value = instr.ID;
                row.Cells[1].Value = instr.Name;
                row.Cells[2].Value = instr.Phone;
                dgvInstructure.Rows.Add(row);
            }
        }
        #endregion

        #region WhenLeaveTXT
        private void txtbInstructorName_Enter(object sender, EventArgs e)
        {
            txtbInstructorName.Text = "";
        }

        private void txtbInstructorPhone_Enter(object sender, EventArgs e)
        {
            txtbInstructorPhone.Text = "";
        } 
        #endregion
    }
}
