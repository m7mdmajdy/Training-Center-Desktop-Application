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
using System.Windows.Controls;
using System.Windows.Forms;
using trainingCenter.BL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace trainingCenter
{
    public partial class GestWorkSpaceAttend : MetroSetForm
    {
        EDPCenterEntities context = new EDPCenterEntities();
        public GestWorkSpaceAttend()
        {
            InitializeComponent();
        }
        private void addGroup_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            MinimumSize = MaximumSize = Size;
        }
        //حساب التكلفه
        public void CostValue(Guest_WorkSpace_Attend guest)
        {
            DateTime dt = DateTime.Now;
            var cost1 = (from c in context.Costs
                         where c.Name == "الساعة الأولى لقاعة الإستذكار"
                         select c.Payment).FirstOrDefault();
            var cost2 = (from c in context.Costs
                         where c.Name == "الساعة بعد الساعة الأولى لقاعة الإستذكار"
                         select c.Payment).FirstOrDefault();
            double? minute = 0.0;
            int? hour = 0;
            double? cost = 0.0;

            hour = dateTimePicker3.Value.Hour - guest.Start_Time.Value.Hours;
            if (hour > 1)
            {
                minute = dateTimePicker3.Value.Minute;

                if (minute > 20)
                {
                    cost = (cost1 + ((hour) * cost2));
                }
                else
                {
                    cost = (cost1 + ((hour - 1) * cost2));
                }
            }
            else if (hour == 0)
            {
                minute = dateTimePicker3.Value.Minute;

                if (minute >30)
                {
                    cost = cost1;
                }
                else
                {
                    cost = cost1/2;
                }
            }
            else
            {
                cost = cost1;
            }
            textBox4.Text = textBox7.Text = cost.ToString();
        }
        //object guest in today
        public Guest_WorkSpace_Attend ObjectGuest()
        {
            Guest_WorkSpace_Attend guest;
            if (textBox1.Text.Length > 0)
            {
                int ID = int.Parse(textBox1.Text);
                DateTime dt = DateTime.Now;
                guest = (from g in context.Guest_WorkSpace_Attend
                         where g.Guest_ID == ID && g.Day.Day == dt.Day
                         select g).FirstOrDefault();
                return guest;
            }
            else
            {
                return guest = new Guest_WorkSpace_Attend();
            }

        }
        /// list من حضور الضيوف
        public List<Guest_WorkSpace_Attend> listOfAttendGuest()
        {
            DateTime dt = DateTime.Now;
            List<Guest_WorkSpace_Attend> guests = context.Guest_WorkSpace_Attend.Where(g => g.Day.Day == dt.Day).ToList();
            return guests;

        }
        private void NewDataGrid(List<Guest_WorkSpace_Attend> guestAttend)
        {
            dataGridView1.Rows.Clear();

            foreach (Guest_WorkSpace_Attend group in guestAttend)
            {
                int x = group.Guest_ID;
                var name = (from g in context.Guest_workspace
                           where g.ID== x
                           select g.Name).FirstOrDefault();
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = group.Guest_ID;
                row.Cells[1].Value = name;
                row.Cells[2].Value = group.Start_Time;
                row.Cells[3].Value = group.End_Time;
                row.Cells[4].Value = group.Cost;
                row.Cells[5].Value = group.Discount;
                row.Cells[6].Value = group.Payment;

                dataGridView1.Rows.Add(row);
            }
        }
        private void btnAttend_Click(object sender, EventArgs e)
        {
            NewDataGrid(listOfAttendGuest());
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox3.Text = textBox4.Text = textBox7.Text = "";
            textBox6.Text = 0.ToString();
            dateTimePicker2.Value = dateTimePicker3.Value = DateTime.Now;
            label15.Visible = false;
            if (textBox2.Text.Length == 0)
            {
                label15.Visible = true;
            }
            else
            {
                int guestID;
                bool isNumber = int.TryParse(textBox2.Text, out guestID);
                Guest_workspace guest;

                if (isNumber)
                {
                    guest = (from g in context.Guest_workspace where g.ID == guestID select g).FirstOrDefault();
                }
                else
                {
                    guest = (from gg in context.Guest_workspace where gg.Name.Contains(textBox2.Text) select gg).FirstOrDefault();
                }
                if (guest != null)
                {
                    Guest_WorkSpace_Attend guest_A = (from g in context.Guest_WorkSpace_Attend
                                                      where (g.Guest_ID == guest.ID && g.Day.Day == DateTime.Now.Day)
                                                      select g).FirstOrDefault();

                    textBox1.Text = guest.ID.ToString();
                    textBox3.Text = guest.Name;
                    if (guest_A != null)
                    {
                        textBox4.Text = guest_A.Cost.ToString();
                        textBox6.Text = guest_A.Discount.ToString();
                        textBox7.Text = guest_A.Payment.ToString();
                        dateTimePicker2.Text = guest_A.Start_Time.ToString();
                        dateTimePicker3.Text = guest_A.End_Time.ToString();
                    }

                }
                else
                {
                    MessageBox.Show("لا يوجد عميل بهذا الاسم أو الكود", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value.TimeOfDay == DateTime.Now.TimeOfDay)
            {
                MessageBox.Show("اختر العميل أولاً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Text = "";
            }
            else
            {
                if (textBox1.Text.Length > 0 && textBox3.Text.Length > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("هل أنت متأكد من الحذف", "حذف عميل", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.OK)
                    {
                        int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;
                        int id = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells[0].Value);
                        int id1 = Convert.ToInt32(textBox1.Text);
                        var guest = (from gg in context.Guest_WorkSpace_Attend where (gg.Guest_ID == id || gg.Guest_ID == id1) select gg).FirstOrDefault();
                        context.Guest_WorkSpace_Attend.Remove(guest);
                        context.SaveChanges();
                        MessageBox.Show("تم حذف العميل بنجاح", "حذف العميل", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                        NewDataGrid(listOfAttendGuest());
                        textBox1.Text = textBox3.Text = textBox4.Text = textBox7.Text = "";
                        textBox6.Text = 0.ToString();
                        dateTimePicker2.Value = dateTimePicker3.Value = DateTime.Now;
                    }

                }
                else
                {
                    MessageBox.Show("اختر العميل أولاً", "خطأ في الحذف", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox3.Text.Length > 0)
            {
                int id = Convert.ToInt32(textBox1.Text);
                var guest = ObjectGuest();
                if (guest != null)
                {
                    MessageBox.Show("هذا العميل موجود بالفعل", "خطأ في الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var attentGest = new Guest_WorkSpace_Attend()
                    {

                        Guest_ID = id,
                        Start_Time = dateTimePicker2.Value.TimeOfDay,
                        Day = DateTime.Now,
                        Discount = 0

                    };
                    context.Guest_WorkSpace_Attend.Add(attentGest);
                    context.SaveChanges();
                    MessageBox.Show("تم بدء الجلسة", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NewDataGrid(listOfAttendGuest());
                    textBox1.Text = textBox3.Text = "";
                }
            }

            else
            {
                MessageBox.Show("ابحث عن العميل أولاً", "خطأ في الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Length > 0)
            {
                MessageBox.Show("لقد غادر العميل مسبقاً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Guest_WorkSpace_Attend guest_A = ObjectGuest();

                if (textBox1.Text.Length > 0 && textBox3.Text.Length > 0)
                {
                    if (guest_A != null)
                    {
                        guest_A.End_Time = dateTimePicker3.Value.TimeOfDay;
                        context.SaveChanges();
                        NewDataGrid(listOfAttendGuest());
                        CostValue(guest_A);
                        MessageBox.Show("تم تسجيل مغادرة العميل", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("إبدأ الجلسة أولاً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("اختر العميل أولاً لإنهاء الجلسة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            Guest_WorkSpace_Attend guest_A = ObjectGuest();

            if (textBox1.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0)
            {
                if (guest_A.Payment != null)
                {
                    MessageBox.Show("تم الدفع مسبقاً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = textBox3.Text = textBox4.Text = textBox7.Text = "";
                    textBox6.Text = 0.ToString();
                    dateTimePicker2.Value = dateTimePicker3.Value = DateTime.Now;
                }
                else
                {
                    Guest_WorkSpace_Attend guest = ObjectGuest();
                    guest.Cost = Convert.ToDouble(textBox4.Text);
                    guest.Discount = Convert.ToDouble(textBox6.Text);
                    guest.Payment = Convert.ToDouble(textBox7.Text);
                    int x = guest.Guest_ID;
                    var name = (from g in context.Guest_workspace
                                where g.ID == x
                                select g.Name).FirstOrDefault();
                    Daily_Transaction daily = new Daily_Transaction()
                    {
                        Person_ID = guest.Guest_ID,
                        Name = name,
                        Price = Convert.ToDouble(textBox7.Text),
                        Transaction_Type = "إيرادات",
                        Date = DateTime.Now
                    };
                    context.Daily_Transaction.Add(daily);
                    context.SaveChanges();
                    NewDataGrid(listOfAttendGuest());
                    MessageBox.Show("تم تسجيل عملية الدفع", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = textBox3.Text = textBox4.Text = textBox7.Text = "";
                    textBox6.Text = 0.ToString();
                    dateTimePicker2.Value = dateTimePicker3.Value = DateTime.Now;
                }

            }
            else { MessageBox.Show("اختر عن العميل أولاً ثم اضغط على إنهاء الجلسة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[index];
                if (row.Cells[0].Value != null)
                {
                    textBox1.Text = row.Cells[0].Value.ToString();
                    textBox3.Text = row.Cells[1].Value.ToString();
                    dateTimePicker2.Text = row.Cells[2].Value.ToString();
                    if (row.Cells[3].Value != null)
                    {
                        dateTimePicker3.Text = row.Cells[3].Value.ToString();
                        if (row.Cells[4].Value != null)
                        {
                            textBox4.Text = row.Cells[4].Value.ToString();
                            textBox6.Text = row.Cells[5].Value.ToString();
                            textBox7.Text = row.Cells[6].Value.ToString();
                        }
                        else
                        {textBox4.Text = textBox7.Text = "";}
                    }
                    else
                    {
                        dateTimePicker3.Text = DateTime.Now.ToString();
                        textBox4.Text = textBox7.Text = "";
                    }
                }
            }
            else
            {                
                textBox1.Text = textBox3.Text = textBox4.Text = textBox7.Text = "";
                dateTimePicker2.Value = dateTimePicker3.Value = DateTime.Now;
            }

        }        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox3.Text = textBox4.Text = textBox7.Text = "";
            textBox6.Text = 0.ToString();
            dateTimePicker2.Value = dateTimePicker3.Value = DateTime.Now;
        }
        private void btnDis_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (textBox4.Text.Length > 0)
                {
                    Guest_WorkSpace_Attend guest_A = ObjectGuest();
                    if (guest_A.Payment != null)
                    {
                        MessageBox.Show("تم الدفع مسبقاً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (textBox6.Text.Length > 0)
                        {
                            double discount;
                            if (double.TryParse(textBox6.Text, out discount))
                            {
                                double? cost = Convert.ToDouble(textBox4.Text);
                                double? payment = cost - discount;
                                textBox7.Text = payment.ToString();
                            }
                            else
                            {
                                MessageBox.Show("ادخل قيمة رقمية للخصم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("ادخل قيمة رقمية للخصم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("اضفط على إنهاء الجلسة أولاً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else MessageBox.Show("ادخل العميل أولاً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            addGestWorkSpace addGest = new addGestWorkSpace();
            addGest.ShowDialog();
        }
    }
}