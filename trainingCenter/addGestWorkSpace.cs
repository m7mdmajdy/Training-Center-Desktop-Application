using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trainingCenter.BL;

namespace trainingCenter
{
    public partial class addGestWorkSpace : MetroSetForm
    {
        EDPCenterEntities context = new EDPCenterEntities();
        public addGestWorkSpace()
        {
            InitializeComponent();
        }

        private void addGestWorkSpace_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            MinimumSize = MaximumSize = Size;
            List<Guest_workspace> g = context.Guest_workspace.ToList();
            NewDataGrid(g);
            Hidinglabel();
        }

        private void btnall_Click(object sender, EventArgs e)
        {
            Hidinglabel();
            List<Guest_workspace> g = context.Guest_workspace.ToList();
            NewDataGrid(g);
        }       

        private void btndelete_Click(object sender, EventArgs e)
        {
            Hidinglabel();
            int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells[0].Value);
            if (id>0)
            {
                if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && txtCode.Text.Length > 0)
                {

                    var guest = (from g in context.Guest_workspace where g.ID == id select g).FirstOrDefault();
                    DialogResult dialogResult = MessageBox.Show("هل أنت متأكد من الحذف", "حذف قاعة", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.OK)
                    {
                        context.Guest_workspace.Remove(guest);
                        context.SaveChanges();
                        MessageBox.Show("تم حذف العميل بنجاح", "حذف عميل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        List<Guest_workspace> g = context.Guest_workspace.ToList();
                        NewDataGrid(g);
                    }
                    else
                    { }
                }
                else
                {
                    MessageBox.Show("اختر عميل للحذف", "خطأ في الحذف", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("اختر عميل للحذف", "خطأ في الحذف", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Hidinglabel();
            Guest_workspace guest = new Guest_workspace();
            bool n1 = false;
            bool n2 = false;
            if (Utilities.validateNameWithNumberInArabic(textBox1.Text))
            {
                guest.Name = textBox1.Text;
                n1 = true;
            }
            else
            {
                lbName.Visible = true;
            }
            if (Utilities.ValidatPhoneNumber(textBox2.Text))
            {
                guest.Phone = textBox2.Text;
                n2 = true;
            }
            else
            {
                lbPhone.Visible = true;
            }
            if (txtCode.Text.Length == 0)
            {
                if (n1 && n2)
                {
                    lbName.Visible = false;
                    lbPhone.Visible = false;
                    context.Guest_workspace.Add(guest);
                    context.SaveChanges();
                    MessageBox.Show("تم إضافة العميل بنجاح", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.Rows.Clear();
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = guest.ID;
                    row.Cells[1].Value = guest.Name;
                    row.Cells[2].Value = guest.Phone;
                    dataGridView1.Rows.Add(row);
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
            else
            {
                MessageBox.Show("هذا العميل موجود بالفعل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Hidinglabel();
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && txtCode.Text.Length > 0)
            {
                int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;
                int id = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells[0].Value);
                var guest = (from g in context.Guest_workspace where g.ID == id select g).FirstOrDefault();
                bool n1 = false;
                bool n2 = false;
                if (Utilities.validateNameWithNumberInArabic(textBox1.Text))
                {
                    guest.Name = textBox1.Text;
                    n1 = true;
                }
                else
                {
                    lbName.Visible = true;
                }
                if (Utilities.ValidatPhoneNumber(textBox2.Text))
                {
                    guest.Phone = textBox2.Text;
                    n2 = true;
                }
                else
                {
                    lbPhone.Visible = true;
                }
                if (n1 && n2)
                {
                    lbName.Visible = false;
                    lbPhone.Visible = false;
                    context.SaveChanges();
                    MessageBox.Show("تم تعديل العميل بنجاح", "عملية ناجحة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    txtCode.Text = "";
                    List<Guest_workspace> g = context.Guest_workspace.ToList();
                    NewDataGrid(g);
                }
            }
            else
            {MessageBox.Show("اختر عميل للتعديل", "خطأ في التعديل", MessageBoxButtons.OK, MessageBoxIcon.Warning);}
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
                int guestid;
                bool isNumber = int.TryParse(textBox3.Text, out guestid);
                List<Guest_workspace> list = new List<Guest_workspace>();

                if (isNumber)
                {
                    list = (from g in context.Guest_workspace where g.ID == guestid select g).ToList();
                }
                else
                {
                    list = (from gg in context.Guest_workspace where gg.Name.Contains(textBox3.Text) select gg).ToList();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells[0].Value);
            if (id > 0)
            {
                var guest = (from g in context.Guest_workspace where g.ID == id select g).FirstOrDefault();
                textBox1.Text = guest.Name;
                textBox2.Text = guest.Phone.ToString();
                txtCode.Text = guest.ID.ToString();
            }

        }
        private void NewDataGrid(List<Guest_workspace> guest)
        {
            dataGridView1.Rows.Clear();

            foreach (var item in guest)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = item.ID;
                row.Cells[1].Value = item.Name;
                row.Cells[2].Value = item.Phone;
                dataGridView1.Rows.Add(row);
            }
        }
        private void Hidinglabel()
        {
            lbsearch.Visible = false;
            lbName.Visible = false;
            lbPhone.Visible = false;
        }

       
    }
}
