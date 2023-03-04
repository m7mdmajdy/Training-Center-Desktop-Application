using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using trainingCenter.BL;

namespace trainingCenter
{
    public partial class totalIncomes : MetroSetForm
    {
        bool isValidName;
        bool isValidNumber;
        string transactionType = "مصروفات";

        EDPCenterEntities eDPCenterEntities;
        public totalIncomes()
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
                label3.Visible =true;
                return false;
            }
            if (!isValidNumber)
            {
                label12.Visible =true;
                return false;
            }
            else
            {
                label3.Visible =false;
                label12.Visible =false;
                return true;
            }



        }

        private void nameBox_Leave(object sender, EventArgs e)
        {
            if (!isValidName)
            {
                label3.Visible =false;
              
            }
        }

        private void numberBox_Leave(object sender, EventArgs e)
        {
            if (!isValidNumber)
            {
                label12.Visible =false;
               
            }

        }


        private void addoutcomes_Load(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
                textBox2.Text = "ادخل التاريخ (الشهر-اليوم-السنة) او البند";

            List<Total_Transaction> total_Transactions= eDPCenterEntities.Total_Transaction.ToList();
            NewDataGrid(total_Transactions);
            if (textBox2.Text.Length == 0)
                textBox2.Text = "ادخل التاريخ (الشهر-اليوم-السنة) او البند";

        }


        private void materialButton1_Click(object sender, EventArgs e)
        {

            if (checkValidation())
            {
                double price = double.Parse(numberBox.Text);
                Total_Transaction total_Transaction = new Total_Transaction()
                {
                    Name = nameBox.Text,
                    Price = price,
                    Date = Convert.ToDateTime(dateTimePicker1.Text),
                    Transaction_Type = transactionType

                };
                eDPCenterEntities.Total_Transaction.Add(total_Transaction);
                eDPCenterEntities.SaveChanges();
                MessageBox.Show("تم اضافة البند");
                List<Total_Transaction> total_Transactions = eDPCenterEntities.Total_Transaction.ToList();
                NewDataGrid(total_Transactions);

            }
        }





        private void NewDataGrid(List<Total_Transaction> total_Transactions)
        {
            nameBox.Text = "";
            numberBox.Text = "";
            textBox2.Text = "ادخل اسم البند";

            dataGridView1.Rows.Clear();

            foreach (Total_Transaction total_Transaction in total_Transactions)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = total_Transaction.ID;
                row.Cells[1].Value = total_Transaction.Name;
                row.Cells[2].Value = total_Transaction.Person_ID;
                row.Cells[3].Value = total_Transaction.Date.ToString();
                row.Cells[4].Value = total_Transaction.Transaction_Type;
                row.Cells[5].Value = total_Transaction.Price;
                dataGridView1.Rows.Add(row);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[index];

            nameBox.Text = row.Cells[1].Value.ToString();
            numberBox.Text = row.Cells[5].Value.ToString();
            productBox.Text = row.Cells[0].Value.ToString();
            DateTime tempDate = Convert.ToDateTime(row.Cells[3].Value.ToString());
            dateTimePicker1.Value = tempDate;
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (checkValidation())
            {
                DateTime date = Convert.ToDateTime(dateTimePicker1.Text);
                double price = double.Parse(numberBox.Text);
                double productNo = double.Parse(productBox.Text);
                Total_Transaction total_Transaction = eDPCenterEntities.Total_Transaction.Where(x => x.ID == productNo).FirstOrDefault();

                if (total_Transaction != null)
                {
                    total_Transaction.Name = nameBox.Text;
                    total_Transaction.Price = price;
                    total_Transaction.Date = date;
                    eDPCenterEntities.SaveChanges();
                    NewDataGrid(eDPCenterEntities.Total_Transaction.ToList());
                    MessageBox.Show("تم تعديل البند");
                }
                else
                {
                    MessageBox.Show("فشل التعديل");
                }
            }
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
                    List<Total_Transaction> total_Transactions;
                    total_Transactions = eDPCenterEntities.Total_Transaction.Where(a => a.Name.Contains(textBox2.Text)).ToList();
                    if (total_Transactions.Count > 0)
                        NewDataGrid(total_Transactions);
                    else
                        MessageBox.Show("لا توجد نتائج");
                }
            }
            else
            {
                NewDataGrid(eDPCenterEntities.Total_Transaction.ToList());
            }
            textBox2.Visible = true;
            dateTimePicker2.Visible = false;
        }

        private void materialButton7_Click(object sender, EventArgs e)
        {
            if (dateTimePicker2.Visible == true)
            {
                List<Total_Transaction> total_Transactions;
                string theDate = dateTimePicker2.Value.ToString("M/d/yyyy");
                total_Transactions = eDPCenterEntities.Total_Transaction.ToList().Where(a => a.Date.ToString().Contains(theDate)).ToList();
                if (total_Transactions.Count > 0)
                    NewDataGrid(total_Transactions);
                else
                    MessageBox.Show("لا توجد نتائج");
            }
            else
            {
                NewDataGrid(eDPCenterEntities.Total_Transaction.ToList());
            }
            textBox2.Visible = false;
            dateTimePicker2.Visible = true;
        }

        private void materialButton6_Click(object sender, EventArgs e)
        {
            NewDataGrid(eDPCenterEntities.Total_Transaction.ToList());
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
    }

}
