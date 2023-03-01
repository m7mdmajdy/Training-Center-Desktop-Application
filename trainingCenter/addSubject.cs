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

namespace trainingCenter
{
    public partial class addSubject : MetroSetForm
    {
        EDPCenterEntities eDPCenterEntities;
        public addSubject()
        {
            InitializeComponent();
            eDPCenterEntities = new EDPCenterEntities();

        }

        
        private void addSubject_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

            this.FormBorderStyle = FormBorderStyle.None;

            this.WindowState = FormWindowState.Maximized;
            List<Subject> subjects = eDPCenterEntities.Subjects.ToList();
            NewDataGrid(subjects);
            if (textBox2.Text.Length == 0)
                textBox2.Text = "ادخل الكود او الاسم";

        }



        private void NewDataGrid(List<Subject> subjects)
        {
            subIdBox.Text = "";
            subNameBox.Text = "";
            textBox2.Text = "";

            dataGridView1.Rows.Clear();

            foreach (Subject subject in subjects)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = subject.Sub_ID;
                row.Cells[1].Value = subject.Sub_Name;
                dataGridView1.Rows.Add(row);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (subNameBox.Text.Length > 0)
            {
                eDPCenterEntities.Subjects.Add(new Subject { Sub_Name = subNameBox.Text });
                eDPCenterEntities.SaveChanges();
                List<Subject> subjects= eDPCenterEntities.Subjects.ToList();
                NewDataGrid(subjects);
                MessageBox.Show("تم اضافة المادة");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[index];

            subIdBox.Text = row.Cells[0].Value.ToString();
            subNameBox.Text = row.Cells[1].Value.ToString();
            
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

            if (subIdBox.Text.Length == 0)
                MessageBox.Show("الرجاء اختيار المادة من الجدول فى الاسفل");
            else
            {
                int subId = int.Parse(subIdBox.Text);
                Subject subject = eDPCenterEntities.Subjects.Where(x => x.Sub_ID == subId).FirstOrDefault();

                subject.Sub_Name = subNameBox.Text;
                eDPCenterEntities.SaveChanges();

                NewDataGrid(eDPCenterEntities.Subjects.ToList());
                MessageBox.Show("تم تعديل بيانات المادة");
            }

            
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("التأكيد على حذف المادة؟", "! تحذير", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int studId = int.Parse(subIdBox.Text);
                Subject subject = eDPCenterEntities.Subjects.Where(x => x.Sub_ID == studId).FirstOrDefault();
                eDPCenterEntities.Subjects.Remove(subject);
                eDPCenterEntities.SaveChanges();
                NewDataGrid(eDPCenterEntities.Subjects.ToList());
                MessageBox.Show(" ! تم حذف المادة");
            }
            else if (dialogResult == DialogResult.No)
            {

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
                int subId;
                bool isNumber = int.TryParse(textBox2.Text, out subId);

                List<Subject> subjects;
                if (isNumber)
                {
                    subjects = eDPCenterEntities.Subjects.Where(a => a.Sub_ID == subId).ToList();

                }
                else
                {
                    subjects = eDPCenterEntities.Subjects.Where(a => a.Sub_Name.Contains(textBox2.Text)).ToList();/*
                    subjects = eDPCenterEntities.Subjects.Where(a => a.Sub_Name == textBox2.Text).ToList();*/
                }
                if (subjects.Count > 0)
                    NewDataGrid(subjects);
                else
                    MessageBox.Show("لا توجد نتائج");
            }
        }

        private void materialButton6_Click(object sender, EventArgs e)
        {
            NewDataGrid(eDPCenterEntities.Subjects.ToList());
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
                textBox2.Text = "ادخل الكود او الاسم";
        }
    }

}
