using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
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
                textBox2.Text = "ادخل الكود او الاسم";

            EDPCenterEntities x = new EDPCenterEntities();
            List<Daily_Transaction> daily_Transactions = x.Daily_Transaction.ToList();
            List<Total_Transaction> total_Transactions= x.Total_Transaction.ToList();
          
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
                    Date= Convert.ToDateTime(dateTimePicker1.Text),
                    Transaction_Type = transactionType
                };
                Total_Transaction total_Transaction = new Total_Transaction()
                {
                    Name = nameBox.Text,
                    Price = price,
                    Date= Convert.ToDateTime(dateTimePicker1.Text),
                    Transaction_Type = transactionType
                };
                eDPCenterEntities.Daily_Transaction.Add(daily_Transaction);
                eDPCenterEntities.Total_Transaction.Add(total_Transaction);
                eDPCenterEntities.SaveChanges();
                MessageBox.Show("تم اضافة البند");

            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (checkValidation())
            {
                DateTime date = Convert.ToDateTime(dateTimePicker1.Text);
                double price = double.Parse(numberBox.Text);
                Daily_Transaction daily_Transaction = eDPCenterEntities.Daily_Transaction.Where(x => x.Name== nameBox.Text && x.Date == date).FirstOrDefault();
                
                if (daily_Transaction != null)
                {
                   daily_Transaction.Name = nameBox.Text;
                    daily_Transaction.Price = price;
                    daily_Transaction.Date= date;
                    eDPCenterEntities.SaveChanges();

                    MessageBox.Show("تم تعديل البند");
                };
                Total_Transaction total_Transaction = eDPCenterEntities.Total_Transaction.Where(x => x.Name== nameBox.Text && x.Date == date).FirstOrDefault();
                if (daily_Transaction != null)
                {
                    total_Transaction.Name = nameBox.Text;
                    total_Transaction.Price = price;
                    total_Transaction.Date= date;
                    eDPCenterEntities.SaveChanges();

                   
                };
            }
        }


    }

}
