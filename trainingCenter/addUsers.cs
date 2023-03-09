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
    public partial class addUser : MetroSet_UI.Forms.MetroSetForm
    {
        static EDPCenterEntities EDPDBContext = new EDPCenterEntities();
        List<User> users;
        bool isValidPhone, isValidSalary, isValidRole;
        public addUser()
        {
            InitializeComponent();
            users = EDPDBContext.Users.ToList();
            dataGridViewUsers.DataSource = users;
            metroComboBox_Role.SelectedIndex = metroComboBox_Role.Items.Count - 1;
            //dataGridViewUsers.Columns[3].;
            //textBox_Passphrase.UseSystemPasswordChar = true;
        }

        private void materialButtonAdd_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                User user = new User { Username = textBox_Username.Text, Password = textBox_Passphrase.Text, Full_Name = textBox_UserFullName.Text, Role = metroComboBox_Role.SelectedItem.ToString(), Phone = textBox_UserPhone.Text, Salary = Convert.ToDouble(textBox_FixedSalary.Text)};
                EDPDBContext.Users.Add(user);
                EDPDBContext.SaveChanges();
                users = EDPDBContext.Users.ToList();
                dataGridViewUsers.DataSource = users;
            }
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("التأكيد على حذف المستخدم؟", "! تحذير", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = int.Parse(textBox_UserID.Text);
                User user = EDPDBContext.Users.Where(u => u.ID == id).FirstOrDefault();
                EDPDBContext.Users.Remove(user);
                EDPDBContext.SaveChanges();
                users = EDPDBContext.Users.ToList();
                dataGridViewUsers.DataSource = users;
                MessageBox.Show(" ! تم حذف المستخدم");
            }
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0) return;
            DataGridViewRow row = dataGridViewUsers.Rows[index];

            textBox_UserID.Text = row.Cells[0].Value.ToString();
            textBox_UserFullName.Text = row.Cells[1].Value.ToString();
            textBox_Username.Text = row.Cells[2].Value.ToString();
            textBox_Passphrase.Text = row.Cells[3].Value.ToString();
            textBox_UserPhone.Text = row.Cells[4].Value.ToString();
            if (!string.IsNullOrEmpty(row.Cells[5].Value.ToString()))
                metroComboBox_Role.Text = row.Cells[5].Value.ToString();
            if (!string.IsNullOrEmpty(row.Cells[6].Value.ToString()))
                textBox_FixedSalary.Text = row.Cells[6].Value.ToString();
        }

        private void materialEdit_Click(object sender, EventArgs e)
        {
            if (textBox_UserID.Text.Length == 0)
                MessageBox.Show("الرجاء اختيار مستخدم من الجدول فى الاسفل");
            else
            {
                //if (IsValid())
                //{
                int id = int.Parse(textBox_UserID.Text);
                User user = EDPDBContext.Users.Where(u => u.ID == id).FirstOrDefault();
                user.Username = textBox_Username.Text;
                user.Password = textBox_Passphrase.Text;
                user.Full_Name = textBox_UserFullName.Text;
                user.Phone = textBox_UserPhone.Text;
                user.Role = metroComboBox_Role.Text;
                user.Salary = double.Parse(textBox_FixedSalary.Text);
                EDPDBContext.SaveChanges();
                dataGridViewUsers.DataSource = EDPDBContext.Users.ToList();
                MessageBox.Show("تم تعديل بيانات المستخدم بنجاح");
                //}

            }
        }

            public bool IsValid()
        {
            //checked validation
            isValidSalary = textBox_FixedSalary.Text != "" ? BL.Utilities.checkDoubleNumber(textBox_FixedSalary.Text) : true;
            isValidPhone = textBox_UserPhone.Text != "" ? BL.Utilities.ValidatPhoneNumber(textBox_UserPhone.Text) : true;
            isValidRole = !string.IsNullOrEmpty(metroComboBox_Role.Text);
            //if (!isValidName)
            //{
            //    lblNameValid.Visible = true;
            //    return false;
            //}
            if (!isValidPhone)
            {
                lblPhoneValidation.Visible = true;
                return false;
            }
            if (!isValidSalary)
            {
                lblSalaryValidation.Visible = true;
                return false;
            }
            if (!isValidRole)
            {
                lblRoleValidation.Visible = true;
                return false;
            }
            else
            {
                lblPhoneValidation.Visible = false;
                lblSalaryValidation.Visible = false;
                return true;
            }
        }

    }
}
