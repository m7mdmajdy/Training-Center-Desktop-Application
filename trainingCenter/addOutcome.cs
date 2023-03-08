using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using trainingCenter.BL;

namespace trainingCenter
{

    public partial class addOutcome : MetroSetForm
    {
        EDPCenterEntities context = new EDPCenterEntities();
        public addOutcome()
        {
            InitializeComponent();
        }
        private Student student;
        public addOutcome(Student s)
        {
            InitializeComponent();
            student = s;
        }

        private void addRoom_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            MaximumSize = MinimumSize = Size;
            textBox1.ReadOnly = true;
            txt2.ReadOnly= true;
            txt3.ReadOnly = true;

            textBox1.Text=student.St_ID.ToString();
            txt2.Text=student.St_Name;

           var studentgroup = (from g in context.Student_Group
                                where g.St_ID == student.St_ID
                                select  g).ToList();
            
            comboBox1.DataSource = studentgroup;           
            comboBox1.ValueMember = "St_Balance";
            comboBox1.DisplayMember = "G_ID";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            txt3.Text = comboBox1.SelectedValue.ToString();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (txt4.Text.Length>0)
            {                
                double money;
                bool Isvalid = double.TryParse(txt4.Text, out money);
                if (Isvalid)
                {
                    if (money <= Convert.ToInt32(txt3.Text))
                    {
                        var stid = Convert.ToInt32(textBox1.Text);
                        var gid = Convert.ToInt32(comboBox1.Text);
                        var s = (from g in context.Student_Group
                                 where g.St_ID == stid && g.G_ID == gid
                                 select g).FirstOrDefault();
                        s.St_Balance -= money;
                        Daily_Transaction daily = new Daily_Transaction()
                        {
                            Person_ID = stid,
                            Name = student.St_Name,
                            Price = money,
                            Transaction_Type = "مصروفات",
                            Date = DateTime.Now
                        };
                        context.Daily_Transaction.Add(daily);
                        context.SaveChanges();                        
                        MessageBox.Show("تم سحب المبلغ بنجاح" , "عملية ناجحة" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("المبلغ المسحوب اكبر من الرصيد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            else
                {
                    MessageBox.Show("ادخل قيمة صحيحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("ادخل قيمة المبلغ المطلوب سحبه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}
