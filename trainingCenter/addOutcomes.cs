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
    public partial class addoutcomes : MetroSetForm
    {
        bool isValidName;
        bool isValidNumber;
        string transactionType = "مصروفات";

        EDPCenterEntities eDPCenterEntities;
        public addoutcomes()
        {
            InitializeComponent();
            eDPCenterEntities = new EDPCenterEntities();

            // set date to current date
            dateTimePicker1.Text = DateTime.Now.ToString();
        }

        // validate fields
        private bool checkValidation()
        {
            isValidName = Utilities.validateNameInArabic(nameBox.Text);
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
            }



        }

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
                label12.Visible = false;

            }

        }


        private void addoutcomes_Load(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
                textBox2.Text = "ادخل التاريخ (الشهر-اليوم-السنة) او البند";

            List<Daily_Transaction> daily_Transactions = eDPCenterEntities.Daily_Transaction.ToList();
            NewDataGrid(daily_Transactions);
            if (textBox2.Text.Length == 0)
                textBox2.Text = "ادخل التاريخ (الشهر-اليوم-السنة) او البند";

        }


        private void materialButton1_Click(object sender, EventArgs e)
        {

            if (checkValidation())
            {
                double price = double.Parse(numberBox.Text);
                Daily_Transaction daily_Transaction = new Daily_Transaction()
                {
                    Name = nameBox.Text,
                    Price = price,
                    Date = Convert.ToDateTime(dateTimePicker1.Text),
                    Transaction_Type = transactionType

                };
                eDPCenterEntities.Daily_Transaction.Add(daily_Transaction);
                eDPCenterEntities.SaveChanges();
                MessageBox.Show("تم اضافة البند");
                List<Daily_Transaction> daily_Transactions = eDPCenterEntities.Daily_Transaction.ToList();
                NewDataGrid(daily_Transactions);

            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (checkValidation())
            {
                DateTime date = Convert.ToDateTime(dateTimePicker1.Text);
                double price = double.Parse(numberBox.Text);
                double productNo = double.Parse(productBox.Text);
                Daily_Transaction daily_Transaction = eDPCenterEntities.Daily_Transaction.Where(x => x.ID == productNo).FirstOrDefault();

                if (daily_Transaction != null)
                {
                    daily_Transaction.Name = nameBox.Text;
                    daily_Transaction.Price = price;
                    daily_Transaction.Date = date;
                    eDPCenterEntities.SaveChanges();
                    NewDataGrid(eDPCenterEntities.Daily_Transaction.ToList());
                    MessageBox.Show("تم تعديل البند");
                }
                else
                {
                    MessageBox.Show("فشل التعديل");
                }
            }
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


        private void NewDataGrid(List<Daily_Transaction> daily_Transactions)
        {
            nameBox.Text = "";
            numberBox.Text = "";
            textBox2.Text = "ادخل اسم البند";

            dataGridView1.Rows.Clear();

            foreach (Daily_Transaction daily_Transaction in daily_Transactions)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = daily_Transaction.ID;
                row.Cells[1].Value = daily_Transaction.Name;
                row.Cells[2].Value = daily_Transaction.Person_ID;
                row.Cells[3].Value = daily_Transaction.Date.ToString();
                row.Cells[4].Value = daily_Transaction.Transaction_Type;
                row.Cells[5].Value = daily_Transaction.Price;
                dataGridView1.Rows.Add(row);
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
                textBox2.Text = "ادخل اسم البند";
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == true)
            {
                if (textBox2.Text.Length == 0)
                    MessageBox.Show("ادخل اسم البند");
                else if (textBox2.Text == "ادخل اسم البند")
                    MessageBox.Show("ادخل اسم البند");
                else
                {
                    List<Daily_Transaction> daily_Transactions;
                    daily_Transactions = eDPCenterEntities.Daily_Transaction.Where(a => a.Name.Contains(textBox2.Text)).ToList();
                    if (daily_Transactions.Count > 0)
                        NewDataGrid(daily_Transactions);
                    else
                        MessageBox.Show("لا توجد نتائج");
                }
            }
            else
            {
                NewDataGrid(eDPCenterEntities.Daily_Transaction.ToList());
            }
            textBox2.Visible = true;
            dateTimePicker2.Visible = false;
        }

        private void materialButton7_Click(object sender, EventArgs e)
        {
            if (dateTimePicker2.Visible == true)
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
            dateTimePicker2.Visible = true;
        }

        private void materialButton6_Click(object sender, EventArgs e)
        {
            NewDataGrid(eDPCenterEntities.Daily_Transaction.ToList());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[index];

            nameBox.Text = row.Cells[1].Value.ToString();
            DateTime tempDate = Convert.ToDateTime(row.Cells[3].Value.ToString());
            numberBox.Text = row.Cells[5].Value.ToString();
            productBox.Text = row.Cells[0].Value.ToString();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {

        }
    }
    
}
