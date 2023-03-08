using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using trainingCenter.BL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace trainingCenter
{
    public partial class AttendenceInstructers : MetroSetForm
    {
        //All Var @ Form
        #region Global Var
        EDPCenterEntities eDPCenterEntities;
        bool isValiddiscount;
        double pp = 0.0;
        double CostperHouer = 0;
        double discouent = 0;
        #endregion
        //Constractor
        #region Constractor
        public AttendenceInstructers()
        {
            InitializeComponent();
            eDPCenterEntities = new EDPCenterEntities();
        } 
        #endregion
        //When Form Load
        #region FormLoad
        private void AttInstractur_Load(object sender, EventArgs e)
        {
            #region fullscreen
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            // this.WindowState = FormWindowState.Maximized;
            #endregion

            #region [نص البحث]
            if (txtbAttinstrSearch.Text.Length == 0)
                txtbAttinstrSearch.Text = "ادخل الكود او الاسم";
            #endregion

            #region TO get row data from DB & Added in form
            EDPCenterEntities x = new EDPCenterEntities();
            List<Instructor_Attendence> Attins = x.Instructor_Attendence.ToList();
            #region rooms id
            List<Room> rooms = x.Rooms.ToList();
            foreach (var item in rooms)
            {
                cbRoomName.Items.Add(item.Room_Name);
            }

            #region [تكلفة الساعة]

            Cost costinstructour = eDPCenterEntities.Costs.Where(a => a.Name == "ساعة المدرب").FirstOrDefault();
            if (costinstructour==null)
            {
                DialogResult result = MessageBox.Show("لا توجد قيمة بجدول اسعار الخدمات لـ ساعة المدرب قم بادخال قيمة اولاً",
                        "لا يوجد سعر لساعة المدرب "
                            , MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                   AddCostes addCoste = new AddCostes();
                    addCoste.ShowDialog();
                }
            }
            else
                CostperHouer = costinstructour.Payment;

            #endregion
            #endregion
            NewDataGrid(Attins);
            #endregion

        }
        #endregion
        //Check TXTB Validation
        #region checkValidation Functaion
        public bool checkValidation()
        {

            bool isValidNameAR = Utilities.validateNameInArabic(txtbAttinstrSearch.Text);
            bool isValidnumber = int.TryParse(txtbAttinstrSearch.Text, out int number);

            if (isValidNameAR|| isValidnumber)
            {
                lblarbicsearchvalid.Visible = false;

                return true;
            }
               
            else
            {
                lblarbicsearchvalid.Visible = true;
                return false;
            }
             
        }
        #endregion
        //زر البحث
        #region button [البحث]
        private void btbSearch_Click(object sender, EventArgs e)
        {
            // check if search field is empty
            if (txtbAttinstrSearch.Text.Length == 0)
                MessageBox.Show("ادخل قيمة في البحث");
            else if (txtbAttinstrSearch.Text == "ادخل الكود او الاسم")
                MessageBox.Show("ادخل قيمة في البحث");
            //get Data from DB
            else if(checkValidation())
            {
                int InstId;
                bool isNumber = int.TryParse(txtbAttinstrSearch.Text, out InstId);

                List<Instructor> instructors;
                if (isNumber)
                    instructors = eDPCenterEntities.Instructors.Where(a => a.ID == InstId).ToList();
                else
                instructors = eDPCenterEntities.Instructors.Where(a => a.Name.Contains(txtbAttinstrSearch.Text)).ToList();
                if (instructors.Count > 0)
                    DataInTextBoxs(instructors);
                else
                {

                    DialogResult result = MessageBox.Show("هل تريد أضافتة كمدرب جديد",
                        "هذا المدرب غير موجود بقاعدة البيانات "
                            , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        addInstructor addInstruct = new addInstructor();
                        addInstruct.ShowDialog();
                    }
                    else if (result == DialogResult.No)
                    {
                        //no...
                    }
                }
            }
        }
        #region [مربع البحث النص]
        private void txtbCostsSearch_Enter(object sender, EventArgs e)
        {
            txtbAttinstrSearch.Text = "";
        }

        private void txtbCostsSearch_Leave(object sender, EventArgs e)
        {
            if (txtbAttinstrSearch.Text == "")
                txtbAttinstrSearch.Text = "ادخل الكود او الاسم";
        }

        #endregion

        #endregion
        //الاختيار بالضغط على خلية
        #region dataGridView1_CellClick
        private void dgvCostes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row;
            // To determine row number
            if (e.RowIndex >= 0)
            {
                row = (DataGridViewRow)dgvAttInstractur.Rows[index];
                txtattid.Text= row.Cells[0].Value?.ToString() ?? "";
                txtbinstractourID.Text = row.Cells[1].Value?.ToString() ?? "";
                txtbInstructorName.Text = row.Cells[2].Value?.ToString() ?? "";
                txtbdiscount.Text = row.Cells[3].Value?.ToString() ?? "";
                cbRoomName.Text = row.Cells[4].Value?.ToString() ?? "";           //room
                txtbStartTime.Text = row.Cells[5].Value?.ToString() ?? "";            //start time
                txtbEndTime.Text = row.Cells[6].Value?.ToString();           //End_Time
                txtbpaymentreq.Text = row.Cells[7].Value?.ToString() ?? "";           //cost
                #region colercell
                if (txtbpaymentreq.Text == "0" && txtbEndTime.Text != "")
                {
                    txtbdiscount.BackColor = Color.YellowGreen;
                    txtbdiscount.Enabled = true;
                }
                else
                {
                    txtbdiscount.BackColor = Color.Gainsboro;
                    txtbdiscount.Enabled = false;

                } 
                #endregion

            }

            else
                MessageBox.Show("الرجاء اختيار مدرب من الجدول فى الاسفل");
            index = 0;
            row = (DataGridViewRow)dgvAttInstractur.Rows[index];
            
        }
        #endregion
        //text box leave validation
        #region [TextBoxLeave(discount)Validation]
        //private void txtbdiscount_Leave(object sender, EventArgs e)
        //{
        //    checkValidation();
        //}
        #endregion 
        //Add data of instractor In TXTB
        #region Dataintext func
        private void DataInTextBoxs(List<Instructor> instructors)
        {
            txtbinstractourID.Text = "";
            txtbInstructorName.Text = "";
            txtbdiscount.Text = "";
            txtbStartTime.Text = "";
            txtbEndTime.Text = "";
            txtbpaymentreq.Text = "";
            //////
            foreach (Instructor instru in instructors)
            {
                txtbinstractourID.Text = instru.ID.ToString();
                txtbInstructorName.Text = instru.Name.ToString();

            }
        }
        #endregion
        //NEWdatagrid FUN
        #region NewdataGrid Function
        private void NewDataGrid(List<Instructor_Attendence> Attinstr)
        {

            txtattid.Text = "";
            txtbinstractourID.Text = "";
            txtbInstructorName.Text = "";
            txtbdiscount.Text = "";
            cbRoomName.Text = "";
            txtbStartTime.Text = "";
            txtbEndTime.Text = "";
            dgvAttInstractur.Rows.Clear();

            
            foreach (Instructor_Attendence attinst in Attinstr)
            {
                Room rooms = eDPCenterEntities.Rooms.Where(a => a.Room_ID == attinst.Room_ID).FirstOrDefault();
                DataGridViewRow row = (DataGridViewRow)dgvAttInstractur.Rows[0].Clone();
                if (attinst.Day.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy"))
                {
                    row.Cells[0].Value = attinst.Instructor_Attendance_ID;    //id
                    row.Cells[1].Value = attinst.Instructor_ID;               //id
                    row.Cells[2].Value = attinst.Instructor.Name;             //name
                    row.Cells[3].Value = attinst.Discount;                 //discount
                    row.Cells[4].Value = rooms.Room_Name;            //room
                    row.Cells[5].Value = attinst.Start_Time;        //start time
                    row.Cells[6].Value = attinst.End_Time;          //End_Time
                    row.Cells[7].Value = attinst.Cost;              //cost
                    
                    dgvAttInstractur.Rows.Add(row);

                    #region Row BKColer
                    if (row.Cells[6].Value == null && row.Cells[7].Value.ToString() == "0")
                    {
                        row.DefaultCellStyle.BackColor = Color.SkyBlue;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (row.Cells[7].Value.ToString() == "0")
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.YellowGreen;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    } 
                    #endregion
                }
            }
        }
        #endregion
        //OLDdataGrid Fun
        #region OLDDataGrid Function
        private void OLDDataGrid(List<Instructor_Attendence> Attinstr)
        {
            dgvAttInstractur.Rows.Clear();

            foreach (Instructor_Attendence attinst in Attinstr)
            {
                Room rooms = eDPCenterEntities.Rooms.Where(a => a.Room_ID == attinst.Room_ID).FirstOrDefault();
                DataGridViewRow row = (DataGridViewRow)dgvAttInstractur.Rows[0].Clone();
                if (attinst.Day.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy"))/*&& attinst.End_Time == null)*/
                {
                    row.Cells[0].Value = attinst.Instructor_Attendance_ID;    //id
                    row.Cells[1].Value = attinst.Instructor_ID;               //id
                    row.Cells[2].Value = attinst.Instructor.Name;             //name
                    row.Cells[3].Value = attinst.Discount;                 //discount
                    row.Cells[4].Value = rooms.Room_Name;            //room
                    row.Cells[5].Value = attinst.Start_Time;        //start time
                    row.Cells[6].Value = attinst.End_Time;          //End_Time
                    row.Cells[7].Value = attinst.Cost;              //cost

                    dgvAttInstractur.Rows.Add(row);
                    #region Row BKColer
                    if (row.Cells[6].Value == null && row.Cells[7].Value.ToString() == "0")
                    {
                        row.DefaultCellStyle.BackColor = Color.SkyBlue;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (row.Cells[7].Value.ToString() == "0")
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.YellowGreen;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    #endregion
                }
            }
        }
        #endregion
        // زر أضافة مدرب جديد
        #region [زر اضافة مدرب جديد]
        private void btnnewinstractor_Click(object sender, EventArgs e)
        {
            addInstructor addInstruct = new addInstructor();
            addInstruct.ShowDialog();
        }

        #endregion
        // زر بدأ جلسة
        #region زر بداء الجلسة
        private void btnstartclass_Click(object sender, EventArgs e)
        {
            //&& txtbStartTime.Text==""
            if (txtbinstractourID.Text.Length > 0 && txtbStartTime.Text.Length == 0 && cbRoomName.Text.Length > 0&& !roomrepeat())
            {
                ////////////////////
                Room rooms = eDPCenterEntities.Rooms.Where(a => a.Room_Name == cbRoomName.Text).FirstOrDefault();
                Instructor_Attendence attinst = new Instructor_Attendence()
                {
                    Instructor_ID = int.Parse(txtbinstractourID.Text),
                    Start_Time = DateTime.Now,
                    End_Time = null,
                    Day = DateTime.Now,
                    Room_ID = rooms.Room_ID,
                    Cost = 0,
                    Discount = 0
                };

                eDPCenterEntities.Instructor_Attendence.Add(attinst);
                eDPCenterEntities.SaveChanges();
                MessageBox.Show("تم تحضير المدرب");
                List<Instructor_Attendence> attinstt = eDPCenterEntities.Instructor_Attendence.ToList();
                NewDataGrid(attinstt);
                ///////////////////////////////
            }
            else
            {
                if (cbRoomName.Text.Length <= 0)
                {
                    lblroomviled.Visible = true;
                }
                else
                    lblroomviled.Visible = false;
                if (txtbStartTime.Text.Length != 0)
                 {
                   MessageBox.Show("لا يمكنك اختيار مدرب للحضور من سجلات الحضور يجب اختياره من صندوق البحث",
                            "يجب الاختيار من صندوق البحث ");
                }
                    
             if (txtbinstractourID.Text.Length == 0)
             MessageBox.Show("برجاء اختيار مدرب من صندوق البحث");
                     
            }

        }
        #endregion
        //زر انهاء جلسة
        #region [زر انهاء الجلسه]
        private void btnEndtclass_Click(object sender, EventArgs e)
        {
            if (txtbEndTime.Text.Length==0&& txtbinstractourID.Text.Length>0)
            {

                DialogResult result = MessageBox.Show("هل تريد انهاء الجلسة",
                            "انهاءالجلسة للمدرب "
                                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ////////////////////////////////
                    txtbdiscount.Enabled = true;
                    txtbdiscount.BackColor = Color.YellowGreen;
                    txtbEndTime.Text = DateTime.Now.ToString();        /// Put End Time in TXTB
                    int idatt = int.Parse(txtattid.Text);
                    Instructor_Attendence instatt = eDPCenterEntities.Instructor_Attendence.Where(a => a.Instructor_Attendance_ID == idatt).FirstOrDefault();
                    instatt.End_Time = DateTime.Now;
                    eDPCenterEntities.SaveChanges();
                    txtbpaymentreq.Text = paymentrequer(txtbStartTime.Text, txtbEndTime.Text).ToString();
                    OLDDataGrid(eDPCenterEntities.Instructor_Attendence.ToList());
                    ///////////////////////////////
                }
                else if (result == DialogResult.No)
                {
                    //no...
                }
            }
            else
                MessageBox.Show("برجاء اختيار مدرب لم يتم انهاء جلستة من قبل");
        }
        #endregion
        //زر الدفع
        #region [زر الدفع]
        private void btnpayment_Click(object sender, EventArgs e)
        {
            
                if (txtbdiscount.Text.Length>0&& txtbEndTime.Text.Length>0&& txtbdiscount.Enabled == true)
                {
                    if (double.TryParse( txtbdiscount.Text,out double x))
                    {
                    ////////////////////
                    DialogResult result = MessageBox.Show("هل تريد الدفع", "الدفع ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        txtbdiscount.Enabled = false;
                        txtbdiscount.BackColor = Color.Gainsboro;
                        discouent = x;
                        int idatt = int.Parse(txtattid.Text);
                        Instructor_Attendence instatt = eDPCenterEntities.Instructor_Attendence.Where(a => a.Instructor_Attendance_ID == idatt).FirstOrDefault();
                        txtbpaymentreq.Text = paymentrequer(txtbStartTime.Text, txtbEndTime.Text).ToString();
                        instatt.Cost = paymentrequer(txtbStartTime.Text, txtbEndTime.Text);
                        instatt.Discount = discouent;
                        eDPCenterEntities.SaveChanges();
                        OLDDataGrid(eDPCenterEntities.Instructor_Attendence.ToList());
                    }
                    else if (result == DialogResult.No)
                    {
                        //no...
                    }
                    ////////////////////
                }
                    else
                        lblValidDisscountpayment.Visible = true;
                }
                else
                    MessageBox.Show("برجاء إنهاء الجلسة اولاً");
            
        }
        #endregion
        // NotRepet Valiad FUN
        #region NotRepeted valid fun
        private bool Notrepeted()
        {

            int insiddfromtxt = int.Parse(txtbinstractourID.Text);
            List<Instructor_Attendence> instruatt;
            instruatt = eDPCenterEntities.Instructor_Attendence.Where(a => a.Instructor_ID == insiddfromtxt).ToList();
            int roomid = 0;
            string endtime = "";
            foreach (var item in instruatt)
            {
                roomid = item.Room_ID;
                endtime = item.End_Time.ToString();
            }
            if (instruatt.Count > 0 && cbRoomName.Text == roomid.ToString() && endtime == "")

                return false;

            else
                return true;
        }
        #endregion
        //Payment Fun
        #region PaymentFunc
        private double paymentrequer(string startdate, string enddate)
        {
            double intervail = (DateTime.Parse(enddate) - DateTime.Parse(startdate)).TotalHours;
            double payment = 0;
            payment = (intervail * CostperHouer) - discouent;
            return payment;
        }



        #endregion
        //check room avalable
        #region Check Room Avlbelite
        private bool roomrepeat()
        {

            string roomname = cbRoomName.SelectedItem.ToString();
            for (int i = 1; i < (dgvAttInstractur.Rows.Count - 1); i++)
            {
                if (dgvAttInstractur.Rows[i].Cells[4].Value.ToString() == roomname)
                {
                    if (dgvAttInstractur.Rows[i].Cells[6].Value == null)
                    {
                        MessageBox.Show("برجاء اختيار غرفة اخرى فارغة");
                        return true;
                    }
                }

            }
            return false;
        }
        #endregion

        

        
    }
}
