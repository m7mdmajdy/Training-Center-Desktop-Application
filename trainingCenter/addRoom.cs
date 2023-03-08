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
    
    public partial class addRoom : MetroSetForm
    {
        EDPCenterEntities context = new EDPCenterEntities();
        public addRoom()
        {
            InitializeComponent();
        }
        private void addRoom_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            List<Room> r = context.Rooms.ToList();
            NewDataGrid(r);
            Hidinglabel(); 
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            Hidinglabel();
            Room room = new Room();
            bool n1 = false;
            bool n2 = false;
            if (Utilities.validateNameWithNumberInArabic(textBox1.Text))
            {
                room.Room_Name= textBox1.Text;
                n1= true;
            }
            else
            {
                lbroom.Visible= true;
            }
            if (Utilities.ValidateIntegerNumbers(textBox2.Text))
            {
                room.Room_Capacity = Convert.ToInt32(textBox2.Text);
                n2 = true;
            }
            else
            {
                lbcapacity.Visible= true;
            }

            if (n1 && n2 )
            {
                DialogResult dialogResult = MessageBox.Show("هل أنت متأكد من الإضافة", "إضافة قاعة", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    lbroom.Visible = false;
                    lbcapacity.Visible = false;
                    context.Rooms.Add(room);
                    context.SaveChanges();
                    MessageBox.Show("تم إضافة القاعة بنجاح", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.Rows.Clear();
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = room.Room_ID;
                    row.Cells[1].Value = room.Room_Name;
                    row.Cells[2].Value = room.Room_Capacity;
                    dataGridView1.Rows.Add(row);
                    textBox1.Text = "";
                    textBox2.Text = "";
                }                            
            }
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            Hidinglabel();
            if (textBox3.Text.Length == 0)
            {
                lbsearch.Visible = true;
            }
            else
            {
                int roomid;
                bool isNumber = int.TryParse(textBox3.Text, out roomid);
                List<Room> list = new List<Room>();

                if (isNumber)
                {
                    list = (from r in context.Rooms where r.Room_ID == roomid select r).ToList();
                }
                else
                {
                    list = (from rr in context.Rooms where rr.Room_Name.Contains(textBox3.Text) select rr).ToList();
                }
                if (list.Count > 0)
                {
                    lbsearch.Visible = false;
                    NewDataGrid(list);
                    textBox3.Text = "";
                }
                else
                {
                    MessageBox.Show("لا توجد قاعة بهذا الاسم", "القاعات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridView1.Rows.Clear();
                }
            }
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            Hidinglabel();
            int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells[0].Value);
            if (id > 0)
            {
                if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && txtCode.Text.Length > 0)
                {
                    var room = (from r in context.Rooms where r.Room_ID == id select r).FirstOrDefault();
                    DialogResult dialogResult = MessageBox.Show("هل أنت متأكد من الحذف", "حذف قاعة", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.OK)
                    {
                        context.Rooms.Remove(room);
                        context.SaveChanges();
                        MessageBox.Show("تم حذف القاعة بنجاح", "حذف قاعة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        List<Room> rooms = context.Rooms.ToList();
                        NewDataGrid(rooms);
                    }
                }
                else
                { MessageBox.Show("اختر قاعة للحذف", "خطأ في الحذف", MessageBoxButtons.OK, MessageBoxIcon.Warning);}
            }
            else
            { MessageBox.Show("اختر قاعة للحذف", "خطأ في الحذف", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private void btnall_Click(object sender, EventArgs e)
        {
            Hidinglabel();
            List<Room> r = context.Rooms.ToList();
            NewDataGrid(r);
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            Hidinglabel();

            int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells[0].Value);            
                if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && txtCode.Text.Length > 0)
                {
                    var room = (from r in context.Rooms where r.Room_ID == id select r).FirstOrDefault();
                    bool n1 = false;
                    bool n2 = false;
                    if (Utilities.validateNameWithNumberInArabic(textBox1.Text))
                    {
                        room.Room_Name = textBox1.Text;
                        n1 = true;
                    }
                    else
                    {
                        lbroom.Visible = true;
                    }
                    if (Utilities.ValidateIntegerNumbers(textBox2.Text))
                    {
                        room.Room_Capacity = Convert.ToInt32(textBox2.Text);
                        n2 = true;
                    }
                    else
                    {
                        lbcapacity.Visible = true;
                    }
                    if (n1 && n2)
                    {
                        lbroom.Visible = false;
                        lbcapacity.Visible = false;
                        context.SaveChanges();
                        MessageBox.Show("تم تعديل القاعة بنجاح", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        txtCode.Text = "";
                        List<Room> rooms = context.Rooms.ToList();
                        NewDataGrid(rooms);
                    }
                }
                else
                {MessageBox.Show("اختر قاعة للتعديل", "خطأ في التعديل", MessageBoxButtons.OK, MessageBoxIcon.Warning);}    
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[index];
                if (row.Cells[0].Value != null)
                {  
                    textBox1.Text = row.Cells[1].Value.ToString();
                    textBox2.Text = row.Cells[2].Value.ToString();
                    txtCode.Text = row.Cells[0].Value.ToString();                    
                }
                else
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            } 
        }
        private void NewDataGrid(List<Room> rooms)
        {
            dataGridView1.Rows.Clear();

            foreach (Room room in rooms)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = room.Room_ID;
                row.Cells[1].Value = room.Room_Name;
                row.Cells[2].Value = room.Room_Capacity;
                dataGridView1.Rows.Add(row);
            }
        }
        private void Hidinglabel()
        {
            lbsearch.Visible=false;
            lbcapacity.Visible=false;
            lbroom.Visible=false;
        }
    }
}
