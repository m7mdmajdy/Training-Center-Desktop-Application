using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using trainingCenter.BL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace trainingCenter
{
    public partial class addStudentGroup : MetroSetForm
    {
        EDPCenterEntities context = new EDPCenterEntities();
        public addStudentGroup()
        {
            InitializeComponent();
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            MinimumSize = MaximumSize = Size;
        }
        private void addGroup_Load(object sender, EventArgs e)
        {
            comboBox3.SelectedIndex = 0;
            List<Student_Group> studentGroups = context.Student_Group.ToList();
            NewDataGrid(studentGroups);
            var groub = (from g in context.GroupNames select g).ToArray();
            comboBox1.DataSource = groub;
            comboBox1.ValueMember = "G_ID";
            comboBox1.DisplayMember = "G_Name";
            var student = (from g in context.Students select g).ToArray();
            comboBox2.DataSource = student;
            comboBox2.ValueMember = "St_ID";
            comboBox2.DisplayMember = "St_Name";
            textBox7.Enabled=false;
        }

        //بحث
        private void materialButton4_Click(object sender, EventArgs e)
        {
            EmptyTextBox();
            EnableCombobox();
            label15.Visible = false;
            if (textBox2.Text.Length == 0)
            {
                label15.Visible = true;
            }
            else
            {
                if (radioButton2.Checked)
                {
                    int studentID;
                    bool isNumber = int.TryParse(textBox2.Text, out studentID);
                    Student student;
                    if (isNumber)
                    {
                        student = (from g in context.Students where g.St_ID == studentID select g).FirstOrDefault();
                        if (student !=null)
                        {
                            textBox1.Text = student.St_ID.ToString();
                            comboBox2.SelectedValue = student.St_ID;

                        }
                        else
                        {
                            MessageBox.Show("لا يوجد طالب بهذا الكود", "خطأ في البحث", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        label15.Visible = true;
                        textBox2.Text = "";
                    }
                }
                else
                {
                    int groupID;
                    bool isNumber = int.TryParse(textBox2.Text, out groupID);
                    GroupName group;
                    if (isNumber)
                    {
                        group = (from g in context.GroupNames where g.G_ID == groupID select g).FirstOrDefault();
                        if (group != null)
                        {
                            textBox5.Text = group.G_ID.ToString();
                            comboBox1.SelectedValue = group.G_ID;
                        }
                        else
                        {
                            MessageBox.Show("لا توجد مجموعة بهذا الكود", "خطأ في البحث", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        label15.Visible = true;
                        textBox2.Text = "";
                    }
                }
            }
        }

        //عرض الكل
        private void materialButton3_Click(object sender, EventArgs e)
        {
            EnableCombobox();
            List<Student_Group> studentGroups = context.Student_Group.ToList();
            NewDataGrid(studentGroups);
            EmptyTextBox();
        }

        //الحذف
        private void materialButton5_Click(object sender, EventArgs e)
        {
            EnableCombobox();
            if (textBox1.Text.Length > 0 && textBox5.Text.Length > 0)
            {
                DialogResult dialogResult = MessageBox.Show("هل أنت متأكد من الحذف", "حذف الضيف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;
                    int id = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells[0].Value);
                    var studentG = (from gg in context.Student_Group where gg.St_ID == id select gg).FirstOrDefault();
                    context.Student_Group.Remove(studentG);
                    context.SaveChanges();
                    MessageBox.Show("تم الحذف بنجاح", "حذف طالب من مجموعة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<Student_Group> groups = context.Student_Group.ToList();
                    NewDataGrid(groups);
                    EmptyTextBox();
                }
            }
            else
            {
                MessageBox.Show("اختر طالب للحذف", "خطأ في الحذف", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //حجز الطالب
        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox5.Text.Length > 0)
            {
                int st_id = Convert.ToInt32(textBox1.Text);
                int g_id = Convert.ToInt32(textBox5.Text);
                Student_Group studentG = (from s in context.Student_Group
                                          where (s.St_ID == st_id & s.G_ID == g_id)
                                          select s).FirstOrDefault();
                if (studentG != null)
                {

                    MessageBox.Show("الطالب موجود بالفعل في هذه المجموعة", "خطأ في الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Student_Group st = new Student_Group()
                    {
                        G_ID = g_id,
                        St_ID = st_id,
                        Payment_Method = comboBox3.SelectedItem.ToString(),
                        St_Balance = int.Parse(textBox7.Text)
                    };
                    context.Student_Group.Add(st);
                    context.SaveChanges();
                    MessageBox.Show("تمت إضافة الطالب للمجموعة", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<Student_Group> groups = context.Student_Group.ToList();
                    NewDataGrid(groups);
                    EmptyTextBox();
                }
            }
            else MessageBox.Show("برجاء اختيار طالب و مجموعة", "خطأ في الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //التعديل
        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox5.Text.Length > 0)
            {
                int st_id = Convert.ToInt32(textBox1.Text);
                int g_id = Convert.ToInt32(textBox5.Text);
                Student_Group studentG = (from s in context.Student_Group
                                          where (s.St_ID == st_id & s.G_ID == g_id)
                                          select s).FirstOrDefault();
                if (studentG == null)
                {
                    MessageBox.Show("الطالب موجود بالفعل في هذه المجموعة", "خطأ في التعديل", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    EnableCombobox();
                }
                else
                {
                    studentG.Payment_Method = comboBox3.SelectedItem.ToString();
                    context.SaveChanges();
                    MessageBox.Show("تمت تعديل الطالب بنجاح", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<Student_Group> groups = context.Student_Group.ToList();
                    NewDataGrid(groups);
                    EnableCombobox();
                }
            }
            else
            {
                MessageBox.Show("برجاء اختيار طالب للتعديل", "خطأ في التعديل", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EnableCombobox();
            }
            EmptyTextBox();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text=comboBox2.SelectedValue.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox5.Text = comboBox1.SelectedValue.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[index];
                if (row.Cells[0].Value != null)
                {
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    // st_ID
                    int x = Convert.ToInt32(row.Cells[0].Value);
                    int GroupID = Convert.ToInt32(row.Cells[2].Value);
                    var s = (from a in context.Student_Group
                             where a.St_ID == x && a.G_ID== GroupID
                             select a).FirstOrDefault();
                    textBox1.Text = s.St_ID.ToString();
                    textBox5.Text = GroupID.ToString();
                    comboBox3.SelectedItem = s.Payment_Method.ToString();
                    textBox7.Text = s.St_Balance.ToString();
                    string St_name = row.Cells[1].Value.ToString();
                    comboBox2.SelectedValue = (from ss in context.Students
                                               where (ss.St_Name == St_name && ss.St_ID == x)
                                               select ss.St_ID).FirstOrDefault();
                    string name2 = row.Cells[3].Value.ToString();
                    comboBox1.SelectedValue = (from g in context.GroupNames
                                               where (g.G_Name == name2)
                                               select g.G_ID).FirstOrDefault();

                }
            }
            else
            {
                EmptyTextBox();

            }
        }

        private void NewDataGrid(List<Student_Group> studentGroups)
        {
            dataGridView1.Rows.Clear();
            foreach (Student_Group group in studentGroups)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = group.St_ID;
                row.Cells[1].Value = group.Student.St_Name;
                row.Cells[2].Value = group.G_ID;
                row.Cells[3].Value = group.GroupName.G_Name;
                row.Cells[4].Value = group.Payment_Method;
                row.Cells[5].Value = group.St_Balance;
                dataGridView1.Rows.Add(row);
            }
        }
        private void EnableCombobox()
        {
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
        }

        private void EmptyTextBox()
        {
            textBox1.Text = "";
            textBox5.Text = "";
            textBox7.Text = "0";
        }

        //الدفع
        private void btnIncome_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length>0 && textBox5.Text.Length>0)
            {
                MessageBox.Show("روح لمعاذ هات الفورم منه");
            }
            else
            {
                MessageBox.Show("اختر طالب للدفع");
            }
        }

        //السحب
        private void btnOutcome_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox5.Text.Length > 0)
            {
                if (textBox7.Text=="0")
                {
                    MessageBox.Show("لا يوجد رصيد لهذا الطالب" , "خطأ" , MessageBoxButtons.OK , MessageBoxIcon.Warning);
                }
                else
                {
                    int x = Convert.ToInt32(textBox1.Text);
                    Student student = (from s in context.Students
                                      where s.St_ID==x
                                      select s).FirstOrDefault();
                    addOutcome outcome = new addOutcome(student);
                    outcome.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("اختر طالب أولاً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}