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
        string transaction_type = "إيرادات";

        EDPCenterEntities eDPCenterEntities;
        public studentPayment(Student _student , Student_Group _stGroupName)
        {

            InitializeComponent();
            eDPCenterEntities = new EDPCenterEntities();
            student = _student;
            stGroupName = _stGroupName;
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

                stGroupName.St_Balance += double.Parse(cashTextBox.Text);
                Daily_Transaction daily_Transactions = new Daily_Transaction();
                daily_Transactions.Person_ID = student.St_ID;
                daily_Transactions.Name = $"{stGroupName.GroupName.G_Name} لمجموعة {student.St_Name} مدفوعات طالب";
                daily_Transactions.Price = double.Parse(cashTextBox.Text);
                daily_Transactions.Transaction_Type = transaction_type;
                daily_Transactions.Date = DateTime.Now;
            }
        }

        private void studentPayment_Load(object sender, EventArgs e)
        {
            stu_IDBox.Text = student.St_ID.ToString();
            stuNameBox.Text = student.St_Name;
            groupNameBox.Text = stGroupName.G_ID.ToString();
            balanceBox.Text = stGroupName.St_Balance.ToString();
        }

         
    }
}
