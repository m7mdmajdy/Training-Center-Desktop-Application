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


namespace trainingCenter
{
    public partial class ScheduleForm : MetroSetForm
    {
       
        EDPCenterEntities eDPCenterEntities;
        List<Schedule> AllSchedules;
        public ScheduleForm()
        {
            InitializeComponent();
            eDPCenterEntities = new EDPCenterEntities();
            AllSchedules = eDPCenterEntities.Schedules.ToList();
            
        }

        private void addSchedule_Load_1(object sender, EventArgs e)
        {
            List<Teacher> TeacherNames = eDPCenterEntities.Teachers.ToList();
            comboBox1.DataSource = TeacherNames;
            comboBox1.ValueMember = "T_ID";
            comboBox1.DisplayMember = "T_Name";
            NewDataGrid(eDPCenterEntities.Schedules.ToList());

            var weekS = comboBox5.Text;
            var st_time = dateTimePicker2.Value.TimeOfDay;
            var en_time = dateTimePicker3.Value.TimeOfDay;
            List<Room> rooms = (from r in eDPCenterEntities.Rooms
                                select r).ToList();
                               
            comboBox3.DataSource = rooms;
            comboBox3.ValueMember = "Room_ID";
            comboBox3.DisplayMember = "Room_Name";
            NewDataGrid(eDPCenterEntities.Schedules.ToList());

            var week = new[]
        {
            new { Text = "السبت", Value = 0 },
            new { Text = "الاحد", Value = 1 },
            new { Text = "الاثنين", Value = 2 },
            new { Text = "الثلاثاء", Value =  3},
            new { Text = "الاربعاء", Value = 4 },
            new { Text = "الخميس", Value = 5 },
            new { Text ="الجمعه", Value = 6 },

        };
            comboBox5.DataSource = week;
            comboBox5.ValueMember = "Value";
            comboBox5.DisplayMember = "Text";
        }
        ///edit
        private void materialButton2_Click(object sender, EventArgs e)
        {
            int TId = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            int groupId = Convert.ToInt32(comboBox2.SelectedValue.ToString());
            int subId = Convert.ToInt32(comboBox4.SelectedValue.ToString());
            int roomId = Convert.ToInt32(comboBox3.SelectedValue.ToString());
            var st_time = dateTimePicker2.Value.TimeOfDay;
            var en_time = dateTimePicker3.Value.TimeOfDay;
            var weekS = comboBox5.Text;
            if (txt1.Text.Length>0)
            {
                var schodul = (from b in eDPCenterEntities.Schedules
                               where (b.Room_ID == roomId &&
                               (st_time >= b.Start_Time && st_time <= b.End_Time)
                               && b.week.Contains(txt1.Text))
                               select b).FirstOrDefault();
                if(schodul==null)
                {
                    int id = Convert.ToInt32(txt1.Text);
                    Schedule s = eDPCenterEntities.Schedules.Where(c => c.Schedule_ID == id).FirstOrDefault();
                    s.Teacher_ID = TId;
                    s.Group_ID = groupId;
                    s.Subject_ID = subId;
                    s.Room_ID = roomId;
                    s.week = weekS;
                    s.Start_Time = dateTimePicker2.Value.TimeOfDay;
                    s.End_Time = dateTimePicker3.Value.TimeOfDay;
                    s.date = dateTimePicker1.Value;
                    eDPCenterEntities.SaveChanges();
                    txt1.Text = "";
                    MessageBox.Show("تم التعديل");
                    List<Schedule> schedules = eDPCenterEntities.Schedules.ToList();
                    NewDataGrid(schedules);
                }
                else
                {
                    MessageBox.Show("القاعه ليسة متاحه في هذا الوقت");
                }
            }
            else
            {
                MessageBox.Show("اختار الاول");
            }
        }
        private void NewDataGrid(List<Schedule> schedules)
        {
            txt1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value= DateTime.Now;
            dateTimePicker3.Value= DateTime.Now;

            dataGridView1.Rows.Clear();

            foreach (Schedule schedule in schedules)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = schedule.Schedule_ID.ToString();
                row.Cells[1].Value = schedule.Teacher.T_Name.ToString();
                row.Cells[2].Value = schedule.GroupName.G_Name.ToString();
                row.Cells[3].Value = schedule.Room.Room_Name.ToString();
                row.Cells[4].Value = schedule.Subject.Sub_Name.ToString();
                row.Cells[5].Value = schedule.date.ToString();
                row.Cells[6].Value = schedule.Start_Time.ToString();
                row.Cells[7].Value = schedule.End_Time.ToString();
                row.Cells[8].Value = schedule.week.ToString();
                dataGridView1.Rows.Add(row);
            }
        }

       //select from datagridview
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[index];
                if (row.Cells[0].Value != null)
                {
                    txt1.Text = row.Cells[0].Value.ToString();
                    comboBox1.Text = row.Cells[1].Value.ToString();
                    comboBox2.Text = row.Cells[2].Value.ToString();
                    comboBox4.Text = row.Cells[3].Value.ToString();
                    comboBox3.Text = row.Cells[4].Value.ToString();
                    dateTimePicker1.Text = row.Cells[5].Value.ToString();
                    dateTimePicker2.Text = row.Cells[6].Value.ToString();
                    dateTimePicker3.Text = row.Cells[7].Value.ToString();
                    comboBox5.Text = row.Cells[8].Value.ToString();
                }
                else
                {
                    MessageBox.Show("لا توجد قيمة");
                }
            }

        }

        //Select from compbox teacher
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            List<GroupName> groupNames = eDPCenterEntities.GroupNames.Where(m => m.Teacher_ID == temp).ToList();
            comboBox2.DataSource = groupNames;
            comboBox2.ValueMember = "G_ID";
            comboBox2.DisplayMember = "G_Name";

            Teacher teachers = (from s in eDPCenterEntities.Teachers
                                where s.T_ID == temp
                                select s).FirstOrDefault();
            List<Subject> subjects = teachers.Subjects.ToList();
            comboBox4.DataSource = subjects;
            comboBox4.ValueMember = "Sub_ID";
            comboBox4.DisplayMember = "Sub_Name";
        }

        // add 
        private void btnadd_Click(object sender, EventArgs e)
        {
            int TId = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            int groupId = Convert.ToInt32(comboBox2.SelectedValue.ToString());
            int subId = Convert.ToInt32(comboBox4.SelectedValue.ToString());
            int roomId = Convert.ToInt32(comboBox3.SelectedValue.ToString());
            var st_time = dateTimePicker2.Value.TimeOfDay;
            var en_time = dateTimePicker3.Value.TimeOfDay;
            var weekS = comboBox5.Text;
            if(comboBox1.Text.Length>0&&comboBox2.Text.Length>0&&comboBox3.Text.Length>0&&comboBox4.Text.Length>0&&comboBox5.Text.Length>0)
            {
                int id = Convert.ToInt32(txt1.Text);
                Schedule sch = eDPCenterEntities.Schedules.Where(c => c.Schedule_ID == id).FirstOrDefault();
                if (sch==null)
                {
                    if (en_time > st_time)
                    {
                        var schodul = (from s in eDPCenterEntities.Schedules
                                       where (s.Room_ID == roomId &&
                                       (st_time >= s.Start_Time && st_time <= s.End_Time)
                                       && s.week.Contains(txt1.Text))
                                       select s).FirstOrDefault();
                        if (schodul == null)
                        {
                            Schedule s = new Schedule()
                            {
                                Teacher_ID = TId,
                                Group_ID = groupId,
                                Subject_ID = subId,
                                Room_ID = roomId,
                                week = weekS,
                                Start_Time = dateTimePicker2.Value.TimeOfDay,
                                End_Time = dateTimePicker3.Value.TimeOfDay,
                                date = dateTimePicker1.Value
                            };
                            eDPCenterEntities.Schedules.Add(s);
                            eDPCenterEntities.SaveChanges();
                            MessageBox.Show("تم حجز");
                            List<Schedule> schedules = eDPCenterEntities.Schedules.ToList();
                            NewDataGrid(schedules);
                        }
                        else { MessageBox.Show("القاعه ليسه متاحه في هذا الوقت"); }

                    }
                    else { MessageBox.Show("ادخل الوقت بشكل صحيح"); }

                }
                else 
                {
                    MessageBox.Show("تم اضافه هذا المعاد مسبقا");
                }
            }
            else { MessageBox.Show("قم بادخال البيانات"); }

        }

        //delete
        private void materialButton3_Click(object sender, EventArgs e)
        {
            if (txt1.Text.Length > 0)
            {
                DialogResult dialogResult = MessageBox.Show("هل أنت متأكد من الحذف", "حذف الضيف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    int id = Convert.ToInt32(txt1.Text);
                    Schedule s = eDPCenterEntities.Schedules.Where(c => c.Schedule_ID == id).FirstOrDefault();
                    eDPCenterEntities.Schedules.Remove(s);
                    eDPCenterEntities.SaveChanges();
                    List<Schedule> schedules = eDPCenterEntities.Schedules.ToList();
                    NewDataGrid(schedules);
                }
            }
            else
            {
                MessageBox.Show("اختار الاول");
            }
        }
    }
}
