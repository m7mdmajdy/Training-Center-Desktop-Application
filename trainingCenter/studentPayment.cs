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
using System.Runtime.CompilerServices;

namespace trainingCenter
{
    public partial class studentPayment : MetroSetForm
    {
        bool isValidCash;
        Student student;
        Student_Group stGroupName;
        Attendence _Attendence;
        Student_Group student_Group;
        string transaction_type = "إيرادات";

        EDPCenterEntities eDPCenterEntities;
        public studentPayment(Attendence attendence)
        {
            InitializeComponent();
            eDPCenterEntities = new EDPCenterEntities();
            _Attendence = attendence;
            student_Group = eDPCenterEntities.Student_Group.Where(x => x.St_ID == _Attendence.St_ID && x.G_ID == _Attendence.G_ID).FirstOrDefault();
        }
        private bool checkValidation()
        {

            isValidCash = Utilities.checkDoubleNumber(cashTextBox.Text);
            if (isValidCash)
            {
                cashValidation.Visible = false;
                return true;
            }
            else
            {
                cashValidation.Visible = true;
                return false;
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (checkValidation())
            {



                DialogResult dialogResult = MessageBox.Show("التأكيد على الدفع؟", "! تحذير", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    student_Group.St_Balance += double.Parse(cashTextBox.Text);
                    Daily_Transaction daily_Transactions = new Daily_Transaction();
                    daily_Transactions.Person_ID = student_Group.St_ID;
                    daily_Transactions.Name = $"دفع الطالب {student_Group.Student.St_Name} لمجموعة {student_Group.GroupName.G_Name}";
                    daily_Transactions.Price = double.Parse(cashTextBox.Text);
                    daily_Transactions.Transaction_Type = transaction_type;
                    daily_Transactions.Date = DateTime.Now;
                    eDPCenterEntities.Daily_Transaction.Add(daily_Transactions);
                    eDPCenterEntities.SaveChanges();
                    this.Close();


                }
            }
        }

        private void studentPayment_Load(object sender, EventArgs e)
        {
            /*stu_IDBox.Text = student.St_ID.ToString();
            stuNameBox.Text = student.St_Name;
            groupNameBox.Text = stGroupName.G_ID.ToString();
            balanceBox.Text = stGroupName.St_Balance.ToString();*/

            string groupName = eDPCenterEntities.GroupNames.Where(x=>x.G_ID==_Attendence.G_ID).FirstOrDefault().G_Name;
            string studentName = eDPCenterEntities.Students.Where(x=>x.St_ID==_Attendence.St_ID).FirstOrDefault().St_Name;
            stuNameBox.Text = studentName;
            groupNameBox.Text= groupName;
            stu_IDBox.Text = _Attendence.St_ID.ToString();
            balanceBox.Text = student_Group.St_Balance.ToString();
        }

         
    }
}
