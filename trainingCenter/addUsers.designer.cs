namespace trainingCenter
{
    partial class addUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonAdd = new MaterialSkin.Controls.MaterialButton();
            this.textBox_FixedSalary = new System.Windows.Forms.TextBox();
            this.textBox_UserPhone = new System.Windows.Forms.TextBox();
            this.textBox_Passphrase = new System.Windows.Forms.TextBox();
            this.textBox_UserFullName = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_UserID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRoleValidation = new System.Windows.Forms.Label();
            this.lblPhoneValidation = new System.Windows.Forms.Label();
            this.lblSalaryValidation = new System.Windows.Forms.Label();
            this.metroComboBox_Role = new MetroSet_UI.Controls.MetroSetComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUsers.AutoGenerateColumns = false;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(62)))));
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn});
            this.dataGridViewUsers.DataSource = this.userBindingSource;
            this.dataGridViewUsers.Location = new System.Drawing.Point(-5, 259);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewUsers.RowHeadersWidth = 51;
            this.dataGridViewUsers.RowTemplate.Height = 24;
            this.dataGridViewUsers.Size = new System.Drawing.Size(1196, 371);
            this.dataGridViewUsers.TabIndex = 10;
            this.dataGridViewUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellClick);
            this.dataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "كود المستخدم";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "Full_Name";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "الاسم بالكامل";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "اسم المستخدم";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "كود المستخدم السري";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "رقم التواصل";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "صلاحية المستخدم";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.Width = 125;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "المرتب الثابت";
            this.salaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.Width = 125;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(trainingCenter.User);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(62)))));
            this.groupBox1.Controls.Add(this.metroComboBox_Role);
            this.groupBox1.Controls.Add(this.materialButton3);
            this.groupBox1.Controls.Add(this.materialButton2);
            this.groupBox1.Controls.Add(this.materialButtonAdd);
            this.groupBox1.Controls.Add(this.textBox_FixedSalary);
            this.groupBox1.Controls.Add(this.textBox_UserPhone);
            this.groupBox1.Controls.Add(this.textBox_Passphrase);
            this.groupBox1.Controls.Add(this.textBox_UserFullName);
            this.groupBox1.Controls.Add(this.textBox_Username);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_UserID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblRoleValidation);
            this.groupBox1.Controls.Add(this.lblPhoneValidation);
            this.groupBox1.Controls.Add(this.lblSalaryValidation);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(-5, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1196, 258);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اضافة مستخدم جديد ";
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.BackColor = System.Drawing.Color.Maroon;
            this.materialButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(41, 167);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(1);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(64, 36);
            this.materialButton3.TabIndex = 19;
            this.materialButton3.Text = "حذف";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = true;
            this.materialButton3.UseVisualStyleBackColor = false;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(41, 105);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(1);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(64, 36);
            this.materialButton2.TabIndex = 20;
            this.materialButton2.Text = "تعديل";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialEdit_Click);
            // 
            // materialButtonAdd
            // 
            this.materialButtonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonAdd.Depth = 0;
            this.materialButtonAdd.HighEmphasis = true;
            this.materialButtonAdd.Icon = null;
            this.materialButtonAdd.Location = new System.Drawing.Point(41, 43);
            this.materialButtonAdd.Margin = new System.Windows.Forms.Padding(1);
            this.materialButtonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonAdd.Name = "materialButtonAdd";
            this.materialButtonAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonAdd.Size = new System.Drawing.Size(64, 36);
            this.materialButtonAdd.TabIndex = 21;
            this.materialButtonAdd.Text = "إضافة";
            this.materialButtonAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonAdd.UseAccentColor = false;
            this.materialButtonAdd.UseVisualStyleBackColor = true;
            this.materialButtonAdd.Click += new System.EventHandler(this.materialButtonAdd_Click);
            // 
            // textBox_FixedSalary
            // 
            this.textBox_FixedSalary.Location = new System.Drawing.Point(140, 171);
            this.textBox_FixedSalary.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_FixedSalary.Name = "textBox_FixedSalary";
            this.textBox_FixedSalary.Size = new System.Drawing.Size(214, 30);
            this.textBox_FixedSalary.TabIndex = 6;
            // 
            // textBox_UserPhone
            // 
            this.textBox_UserPhone.Location = new System.Drawing.Point(140, 108);
            this.textBox_UserPhone.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_UserPhone.Name = "textBox_UserPhone";
            this.textBox_UserPhone.Size = new System.Drawing.Size(214, 30);
            this.textBox_UserPhone.TabIndex = 5;
            // 
            // textBox_Passphrase
            // 
            this.textBox_Passphrase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Passphrase.Location = new System.Drawing.Point(508, 105);
            this.textBox_Passphrase.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_Passphrase.MaxLength = 30;
            this.textBox_Passphrase.Name = "textBox_Passphrase";
            this.textBox_Passphrase.Size = new System.Drawing.Size(517, 30);
            this.textBox_Passphrase.TabIndex = 2;
            this.textBox_Passphrase.UseSystemPasswordChar = true;
            // 
            // textBox_UserFullName
            // 
            this.textBox_UserFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_UserFullName.Location = new System.Drawing.Point(508, 170);
            this.textBox_UserFullName.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_UserFullName.MaxLength = 30;
            this.textBox_UserFullName.Name = "textBox_UserFullName";
            this.textBox_UserFullName.Size = new System.Drawing.Size(517, 30);
            this.textBox_UserFullName.TabIndex = 3;
            // 
            // textBox_Username
            // 
            this.textBox_Username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Username.Location = new System.Drawing.Point(508, 46);
            this.textBox_Username.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_Username.MaxLength = 30;
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(517, 30);
            this.textBox_Username.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(315, 269);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 27);
            this.label7.TabIndex = 20;
            this.label7.Text = "كـود المستخدم";
            this.label7.Visible = false;
            // 
            // textBox_UserID
            // 
            this.textBox_UserID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_UserID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_UserID.Enabled = false;
            this.textBox_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UserID.Location = new System.Drawing.Point(150, 265);
            this.textBox_UserID.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_UserID.Name = "textBox_UserID";
            this.textBox_UserID.Size = new System.Drawing.Size(163, 34);
            this.textBox_UserID.TabIndex = 21;
            this.textBox_UserID.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(361, 173);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 27);
            this.label6.TabIndex = 15;
            this.label6.Text = "المرتب الثابت";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(361, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 27);
            this.label5.TabIndex = 15;
            this.label5.Text = "رقم التواصل";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(361, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "صلاحية المستخدم";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1027, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "كود المستخدم السري";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1032, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "الإسم بالكامل";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1027, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم المسـتخدم";
            // 
            // lblRoleValidation
            // 
            this.lblRoleValidation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoleValidation.AutoSize = true;
            this.lblRoleValidation.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lblRoleValidation.ForeColor = System.Drawing.Color.Red;
            this.lblRoleValidation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRoleValidation.Location = new System.Drawing.Point(214, 79);
            this.lblRoleValidation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoleValidation.Name = "lblRoleValidation";
            this.lblRoleValidation.Size = new System.Drawing.Size(148, 23);
            this.lblRoleValidation.TabIndex = 22;
            this.lblRoleValidation.Text = "* اختر صلاحية للمستخدم";
            this.lblRoleValidation.Visible = false;
            // 
            // lblPhoneValidation
            // 
            this.lblPhoneValidation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhoneValidation.AutoSize = true;
            this.lblPhoneValidation.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lblPhoneValidation.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneValidation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPhoneValidation.Location = new System.Drawing.Point(210, 142);
            this.lblPhoneValidation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneValidation.Name = "lblPhoneValidation";
            this.lblPhoneValidation.Size = new System.Drawing.Size(148, 23);
            this.lblPhoneValidation.TabIndex = 14;
            this.lblPhoneValidation.Text = "* ادخل رقم هاتف صحيح";
            this.lblPhoneValidation.Visible = false;
            // 
            // lblSalaryValidation
            // 
            this.lblSalaryValidation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSalaryValidation.AutoSize = true;
            this.lblSalaryValidation.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lblSalaryValidation.ForeColor = System.Drawing.Color.Red;
            this.lblSalaryValidation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSalaryValidation.Location = new System.Drawing.Point(235, 205);
            this.lblSalaryValidation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalaryValidation.Name = "lblSalaryValidation";
            this.lblSalaryValidation.Size = new System.Drawing.Size(123, 23);
            this.lblSalaryValidation.TabIndex = 18;
            this.lblSalaryValidation.Text = "* ادخل قيمة صحيحة";
            this.lblSalaryValidation.Visible = false;
            // 
            // metroComboBox_Role
            // 
            this.metroComboBox_Role.AllowDrop = true;
            this.metroComboBox_Role.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroComboBox_Role.BackColor = System.Drawing.Color.Transparent;
            this.metroComboBox_Role.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroComboBox_Role.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroComboBox_Role.CausesValidation = false;
            this.metroComboBox_Role.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroComboBox_Role.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroComboBox_Role.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroComboBox_Role.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroComboBox_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroComboBox_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroComboBox_Role.FormattingEnabled = true;
            this.metroComboBox_Role.IsDerivedStyle = true;
            this.metroComboBox_Role.ItemHeight = 20;
            this.metroComboBox_Role.Items.AddRange(new object[] {
            "Super",
            "Secretary",
            "Manager",
            "Employee"});
            this.metroComboBox_Role.Location = new System.Drawing.Point(140, 46);
            this.metroComboBox_Role.Name = "metroComboBox_Role";
            this.metroComboBox_Role.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroComboBox_Role.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroComboBox_Role.Size = new System.Drawing.Size(214, 26);
            this.metroComboBox_Role.Style = MetroSet_UI.Enums.Style.Light;
            this.metroComboBox_Role.StyleManager = null;
            this.metroComboBox_Role.TabIndex = 23;
            this.metroComboBox_Role.ThemeAuthor = "Narwin";
            this.metroComboBox_Role.ThemeName = "MetroLite";
            // 
            // addUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 632);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.groupBox1);
            this.Name = "addUser";
            this.Text = "User";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Username;
        //private MetroFramework.Controls.MetroComboBox metroComboBox_Role;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Passphrase;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.TextBox textBox_UserPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_UserFullName;
        private System.Windows.Forms.TextBox textBox_FixedSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSalaryValidation;
        private System.Windows.Forms.Label lblPhoneValidation;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButtonAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_UserID;
        private System.Windows.Forms.Label lblRoleValidation;
        private MetroSet_UI.Controls.MetroSetComboBox metroComboBox_Role;
    }
}