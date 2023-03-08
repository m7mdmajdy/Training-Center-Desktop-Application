using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trainingCenter.BL;

namespace trainingCenter
{
    public partial class addSchedule : MetroSetForm
    {
        bool isValidName;
        bool isValidNumber;

        EDPCenterEntities eDPCenterEntities;
        List<Schedule> AllSchedules;
        public addSchedule()
        {
            InitializeComponent();
            eDPCenterEntities = new EDPCenterEntities();
            AllSchedules=eDPCenterEntities.Schedules.ToList();

            // set date to current date
            
            dateTimePicker1.Text = DateTime.Now.ToString();
        }

        // validate fields
        /*private bool checkValidation()
        {
            *//*isValidName = Utilities.validateNameInArabic(nameBox.Text);
            isValidNumber = Utilities.checkDoubleNumber(numberBox.Text);

            if (!isValidName)
            {
                label3.Visible = true;
                return false;
            }
            if (!isValidNumber)
            {
                label12.Visible = true;
                return false;
            }
            else
            {
                label3.Visible = false;
                label12.Visible = false;
                return true;
            }*//*



        }*/

        private void nameBox_Leave(object sender, EventArgs e)
        {
            if (!isValidName)
            {
                label3.Visible = false;

            }
        }

        private void numberBox_Leave(object sender, EventArgs e)
        {
            if (!isValidNumber)
            {
               // label12.Visible = false;

            }

        }


        private void addSchedule_Load_1(object sender, EventArgs e)
        {
            List<Schedule> schedules = eDPCenterEntities.Schedules.ToList();
            NewDataGrid(schedules);
        }


        private void materialButton1_Click(object sender, EventArgs e)
        {

            string theDate = dateTimePicker1.Value.ToString("M/d/yyyy");
            List<string> dates = AllSchedules.Select(x => x.date.ToString()).ToList();
            List<Schedule> schedules = AllSchedules.Where(x => x.date.ToString().Contains(theDate)).ToList();
            NewDataGrid(schedules);
            nameBox.Text = "";



        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("التأكيد على تصفية اليوم ؟", "! تحذير", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (Daily_Transaction daily_Transaction in eDPCenterEntities.Daily_Transaction)
                {

                    eDPCenterEntities.Total_Transaction.Add(new Total_Transaction
                    {
                        Date = daily_Transaction.Date,
                        Price = daily_Transaction.Price,
                        Person_ID = daily_Transaction.Person_ID,
                        Name = daily_Transaction.Name,
                        Transaction_Type = daily_Transaction.Transaction_Type,
                    });

                    eDPCenterEntities.Daily_Transaction.Remove(daily_Transaction);
                }
                eDPCenterEntities.SaveChanges();
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
            }
        }


        private void NewDataGrid(List<Schedule> schedules)
        {
            dataGridView1.Rows.Clear();

            foreach (Schedule schedule in schedules)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = schedule.Teacher.T_Name.ToString();
                row.Cells[1].Value = schedule.GroupName.G_Name.ToString();
                row.Cells[2].Value = schedule.Room.Room_Name.ToString();
                row.Cells[3].Value = schedule.Subject.Sub_Name.ToString();
                row.Cells[4].Value = schedule.date.ToString();
                dataGridView1.Rows.Add(row);
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            
        }

        private void materialButton7_Click(object sender, EventArgs e)
        {
           /* if (dateTimePicker2.Visible == true)
            {
                List<Daily_Transaction> daily_Transactions;
                string theDate = dateTimePicker2.Value.ToString("M/d/yyyy");
                daily_Transactions = eDPCenterEntities.Daily_Transaction.ToList().Where(a=>a.Date.ToString().Contains(theDate)).ToList();
                if (daily_Transactions.Count > 0)
                    NewDataGrid(daily_Transactions);
                else
                    MessageBox.Show("لا توجد نتائج");
            }
            else
            {
                NewDataGrid(eDPCenterEntities.Daily_Transaction.ToList());
            }
            textBox2.Visible = false;
            dateTimePicker2.Visible = true;*/
        }

        private void materialButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[index];
                if (row.Cells[0].Value != null)
                {
                    nameBox.Text = row.Cells[1].Value.ToString();
                    DateTime tempDate = Convert.ToDateTime(row.Cells[3].Value.ToString());
                    numberBox.Text = row.Cells[5].Value.ToString();
                    productBox.Text = row.Cells[0].Value.ToString();
                }
                else
                {
                    MessageBox.Show("لا توجد قيمة");
                }
            }*/

        }

        private void materialButton5_Click_1(object sender, EventArgs e)
        {
            NewDataGrid(eDPCenterEntities.Schedules.ToList());
            dateTimePicker1.Value= DateTime.Now;
            nameBox.Text = "";
        }

        private void materialButton6_Click_1(object sender, EventArgs e)
        {
            if (nameBox.Text.Length > 0)
            {
                label3.Visible = false;

                List<Schedule> schedules =
                    AllSchedules.Where(x => x.Teacher.T_Name.Contains( nameBox.Text)).ToList();
                NewDataGrid(schedules);
            }
            else
            {
                label3.Visible = true;
            }
        }
    }
    
}
