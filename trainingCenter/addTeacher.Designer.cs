namespace trainingCenter
{
    partial class addTeacher
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_TID = new System.Windows.Forms.TextBox();
            this.lblBalanceValidation = new System.Windows.Forms.Label();
            this.textBox_TBalance = new System.Windows.Forms.TextBox();
            this.lblPhoneValid = new System.Windows.Forms.Label();
            this.lblPercentageValid = new System.Windows.Forms.Label();
            this.lblAddressValid = new System.Windows.Forms.Label();
            this.lblNameValid = new System.Windows.Forms.Label();
            this.materialDelete = new MaterialSkin.Controls.MaterialButton();
            this.textBox_TPercentage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_TName = new System.Windows.Forms.TextBox();
            this.textBox_Filter = new System.Windows.Forms.TextBox();
            this.textBox_TAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialEdit = new MaterialSkin.Controls.MaterialButton();
            this.materialButton6 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton5 = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonAdd = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_TPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tPercentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTeachers = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 18;
            this.label1.Text = "كـود المـدرس";
            this.label1.Visible = false;
            // 
            // textBox_TID
            // 
            this.textBox_TID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_TID.Enabled = false;
            this.textBox_TID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TID.Location = new System.Drawing.Point(43, 193);
            this.textBox_TID.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_TID.Name = "textBox_TID";
            this.textBox_TID.Size = new System.Drawing.Size(163, 34);
            this.textBox_TID.TabIndex = 19;
            this.textBox_TID.Visible = false;
            // 
            // lblBalanceValidation
            // 
            this.lblBalanceValidation.AutoSize = true;
            this.lblBalanceValidation.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lblBalanceValidation.ForeColor = System.Drawing.Color.Red;
            this.lblBalanceValidation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBalanceValidation.Location = new System.Drawing.Point(481, 147);
            this.lblBalanceValidation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBalanceValidation.Name = "lblBalanceValidation";
            this.lblBalanceValidation.Size = new System.Drawing.Size(125, 23);
            this.lblBalanceValidation.TabIndex = 17;
            this.lblBalanceValidation.Text = "* ادخل نقدية صحيحة";
            this.lblBalanceValidation.Visible = false;
            // 
            // textBox_TBalance
            // 
            this.textBox_TBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TBalance.Location = new System.Drawing.Point(380, 112);
            this.textBox_TBalance.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_TBalance.MaxLength = 16;
            this.textBox_TBalance.Name = "textBox_TBalance";
            this.textBox_TBalance.Size = new System.Drawing.Size(222, 34);
            this.textBox_TBalance.TabIndex = 5;
            // 
            // lblPhoneValid
            // 
            this.lblPhoneValid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhoneValid.AutoSize = true;
            this.lblPhoneValid.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lblPhoneValid.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneValid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPhoneValid.Location = new System.Drawing.Point(1060, 228);
            this.lblPhoneValid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneValid.Name = "lblPhoneValid";
            this.lblPhoneValid.Size = new System.Drawing.Size(148, 23);
            this.lblPhoneValid.TabIndex = 13;
            this.lblPhoneValid.Text = "* ادخل رقم هاتف صحيح";
            this.lblPhoneValid.Visible = false;
            // 
            // lblPercentageValid
            // 
            this.lblPercentageValid.AutoSize = true;
            this.lblPercentageValid.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lblPercentageValid.ForeColor = System.Drawing.Color.Red;
            this.lblPercentageValid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPercentageValid.Location = new System.Drawing.Point(446, 71);
            this.lblPercentageValid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPercentageValid.Name = "lblPercentageValid";
            this.lblPercentageValid.Size = new System.Drawing.Size(160, 23);
            this.lblPercentageValid.TabIndex = 12;
            this.lblPercentageValid.Text = "* ادخل النسبة بين 0 , 100";
            this.lblPercentageValid.Visible = false;
            // 
            // lblAddressValid
            // 
            this.lblAddressValid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddressValid.AutoSize = true;
            this.lblAddressValid.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lblAddressValid.ForeColor = System.Drawing.Color.Red;
            this.lblAddressValid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAddressValid.Location = new System.Drawing.Point(1045, 147);
            this.lblAddressValid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddressValid.Name = "lblAddressValid";
            this.lblAddressValid.Size = new System.Drawing.Size(163, 23);
            this.lblAddressValid.TabIndex = 11;
            this.lblAddressValid.Text = "* ادخل عنوان باللغة العربية";
            this.lblAddressValid.Visible = false;
            // 
            // lblNameValid
            // 
            this.lblNameValid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameValid.AutoSize = true;
            this.lblNameValid.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lblNameValid.ForeColor = System.Drawing.Color.Red;
            this.lblNameValid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNameValid.Location = new System.Drawing.Point(1018, 71);
            this.lblNameValid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameValid.Name = "lblNameValid";
            this.lblNameValid.Size = new System.Drawing.Size(190, 23);
            this.lblNameValid.TabIndex = 10;
            this.lblNameValid.Text = "* ادخل إسم صحيح باللغة العربية";
            this.lblNameValid.Visible = false;
            // 
            // materialDelete
            // 
            this.materialDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialDelete.BackColor = System.Drawing.Color.Maroon;
            this.materialDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialDelete.Depth = 0;
            this.materialDelete.HighEmphasis = true;
            this.materialDelete.Icon = null;
            this.materialDelete.Location = new System.Drawing.Point(43, 76);
            this.materialDelete.Margin = new System.Windows.Forms.Padding(1);
            this.materialDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDelete.Name = "materialDelete";
            this.materialDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialDelete.Size = new System.Drawing.Size(64, 36);
            this.materialDelete.TabIndex = 9;
            this.materialDelete.Text = "حذف";
            this.materialDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialDelete.UseAccentColor = true;
            this.materialDelete.UseVisualStyleBackColor = false;
            // 
            // textBox_TPercentage
            // 
            this.textBox_TPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TPercentage.Location = new System.Drawing.Point(380, 35);
            this.textBox_TPercentage.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_TPercentage.Name = "textBox_TPercentage";
            this.textBox_TPercentage.Size = new System.Drawing.Size(222, 34);
            this.textBox_TPercentage.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1211, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "الإســــــم";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1211, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "العنــــــــوان";
            // 
            // textBox_TName
            // 
            this.textBox_TName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_TName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TName.Location = new System.Drawing.Point(763, 35);
            this.textBox_TName.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_TName.Name = "textBox_TName";
            this.textBox_TName.Size = new System.Drawing.Size(441, 34);
            this.textBox_TName.TabIndex = 1;
            // 
            // textBox_Filter
            // 
            this.textBox_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Filter.Location = new System.Drawing.Point(43, 34);
            this.textBox_Filter.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_Filter.Name = "textBox_Filter";
            this.textBox_Filter.Size = new System.Drawing.Size(260, 34);
            this.textBox_Filter.TabIndex = 6;
            this.textBox_Filter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_TAddress
            // 
            this.textBox_TAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_TAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TAddress.Location = new System.Drawing.Point(763, 112);
            this.textBox_TAddress.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_TAddress.Name = "textBox_TAddress";
            this.textBox_TAddress.Size = new System.Drawing.Size(441, 34);
            this.textBox_TAddress.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(607, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 27);
            this.label8.TabIndex = 15;
            this.label8.Text = "الرصيد الحالي";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(62)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_TID);
            this.groupBox1.Controls.Add(this.lblBalanceValidation);
            this.groupBox1.Controls.Add(this.textBox_TBalance);
            this.groupBox1.Controls.Add(this.lblPhoneValid);
            this.groupBox1.Controls.Add(this.lblPercentageValid);
            this.groupBox1.Controls.Add(this.lblAddressValid);
            this.groupBox1.Controls.Add(this.lblNameValid);
            this.groupBox1.Controls.Add(this.materialDelete);
            this.groupBox1.Controls.Add(this.materialEdit);
            this.groupBox1.Controls.Add(this.materialButton6);
            this.groupBox1.Controls.Add(this.materialButton5);
            this.groupBox1.Controls.Add(this.materialButtonAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_TPhone);
            this.groupBox1.Controls.Add(this.textBox_TPercentage);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_TName);
            this.groupBox1.Controls.Add(this.textBox_Filter);
            this.groupBox1.Controls.Add(this.textBox_TAddress);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1345, 274);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اضافة مدرس ";
            // 
            // materialEdit
            // 
            this.materialEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialEdit.Depth = 0;
            this.materialEdit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.materialEdit.HighEmphasis = true;
            this.materialEdit.Icon = null;
            this.materialEdit.Location = new System.Drawing.Point(142, 76);
            this.materialEdit.Margin = new System.Windows.Forms.Padding(1);
            this.materialEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialEdit.Name = "materialEdit";
            this.materialEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialEdit.Size = new System.Drawing.Size(64, 36);
            this.materialEdit.TabIndex = 9;
            this.materialEdit.Text = "تعديل";
            this.materialEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialEdit.UseAccentColor = false;
            this.materialEdit.UseVisualStyleBackColor = true;
            // 
            // materialButton6
            // 
            this.materialButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton6.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton6.Depth = 0;
            this.materialButton6.HighEmphasis = true;
            this.materialButton6.Icon = null;
            this.materialButton6.Location = new System.Drawing.Point(43, 131);
            this.materialButton6.Margin = new System.Windows.Forms.Padding(1);
            this.materialButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton6.Name = "materialButton6";
            this.materialButton6.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton6.Size = new System.Drawing.Size(80, 36);
            this.materialButton6.TabIndex = 9;
            this.materialButton6.Text = "عرض الكل";
            this.materialButton6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton6.UseAccentColor = false;
            this.materialButton6.UseVisualStyleBackColor = true;
            // 
            // materialButton5
            // 
            this.materialButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton5.Depth = 0;
            this.materialButton5.HighEmphasis = true;
            this.materialButton5.Icon = null;
            this.materialButton5.Location = new System.Drawing.Point(239, 131);
            this.materialButton5.Margin = new System.Windows.Forms.Padding(1);
            this.materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton5.Name = "materialButton5";
            this.materialButton5.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton5.Size = new System.Drawing.Size(64, 36);
            this.materialButton5.TabIndex = 9;
            this.materialButton5.Text = "بحث";
            this.materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton5.UseAccentColor = false;
            this.materialButton5.UseVisualStyleBackColor = true;
            // 
            // materialButtonAdd
            // 
            this.materialButtonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonAdd.Depth = 0;
            this.materialButtonAdd.HighEmphasis = true;
            this.materialButtonAdd.Icon = null;
            this.materialButtonAdd.Location = new System.Drawing.Point(239, 76);
            this.materialButtonAdd.Margin = new System.Windows.Forms.Padding(1);
            this.materialButtonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonAdd.Name = "materialButtonAdd";
            this.materialButtonAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonAdd.Size = new System.Drawing.Size(64, 36);
            this.materialButtonAdd.TabIndex = 9;
            this.materialButtonAdd.Text = "إضافة";
            this.materialButtonAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonAdd.UseAccentColor = false;
            this.materialButtonAdd.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1211, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "رقم الهاتف";
            // 
            // textBox_TPhone
            // 
            this.textBox_TPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_TPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TPhone.Location = new System.Drawing.Point(763, 193);
            this.textBox_TPhone.Margin = new System.Windows.Forms.Padding(1);
            this.textBox_TPhone.MaxLength = 16;
            this.textBox_TPhone.Name = "textBox_TPhone";
            this.textBox_TPhone.Size = new System.Drawing.Size(441, 34);
            this.textBox_TPhone.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(607, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 27);
            this.label6.TabIndex = 1;
            this.label6.Text = "نسبة المدرس %";
            // 
            // tPercentageDataGridViewTextBoxColumn
            // 
            this.tPercentageDataGridViewTextBoxColumn.DataPropertyName = "T_Percentage";
            this.tPercentageDataGridViewTextBoxColumn.HeaderText = "نسبة الحصة";
            this.tPercentageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tPercentageDataGridViewTextBoxColumn.Name = "tPercentageDataGridViewTextBoxColumn";
            this.tPercentageDataGridViewTextBoxColumn.ReadOnly = true;
            this.tPercentageDataGridViewTextBoxColumn.Width = 125;
            // 
            // tBalanceDataGridViewTextBoxColumn
            // 
            this.tBalanceDataGridViewTextBoxColumn.DataPropertyName = "T_Balance";
            this.tBalanceDataGridViewTextBoxColumn.HeaderText = "الرصيد الحالي";
            this.tBalanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tBalanceDataGridViewTextBoxColumn.Name = "tBalanceDataGridViewTextBoxColumn";
            this.tBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.tBalanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // tAddressDataGridViewTextBoxColumn
            // 
            this.tAddressDataGridViewTextBoxColumn.DataPropertyName = "T_Address";
            this.tAddressDataGridViewTextBoxColumn.HeaderText = "عنوان المدرس";
            this.tAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tAddressDataGridViewTextBoxColumn.Name = "tAddressDataGridViewTextBoxColumn";
            this.tAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.tAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // tPhoneDataGridViewTextBoxColumn
            // 
            this.tPhoneDataGridViewTextBoxColumn.DataPropertyName = "T_Phone";
            this.tPhoneDataGridViewTextBoxColumn.HeaderText = "رقم التواصل";
            this.tPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tPhoneDataGridViewTextBoxColumn.Name = "tPhoneDataGridViewTextBoxColumn";
            this.tPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.tPhoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // tNameDataGridViewTextBoxColumn
            // 
            this.tNameDataGridViewTextBoxColumn.DataPropertyName = "T_Name";
            this.tNameDataGridViewTextBoxColumn.HeaderText = "اسم المدرس";
            this.tNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tNameDataGridViewTextBoxColumn.Name = "tNameDataGridViewTextBoxColumn";
            this.tNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.tNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // tIDDataGridViewTextBoxColumn
            // 
            this.tIDDataGridViewTextBoxColumn.DataPropertyName = "T_ID";
            this.tIDDataGridViewTextBoxColumn.HeaderText = "كود المدرس";
            this.tIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tIDDataGridViewTextBoxColumn.Name = "tIDDataGridViewTextBoxColumn";
            this.tIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTeachers
            // 
            this.dataGridViewTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTeachers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(62)))));
            this.dataGridViewTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tIDDataGridViewTextBoxColumn,
            this.tNameDataGridViewTextBoxColumn,
            this.tPhoneDataGridViewTextBoxColumn,
            this.tAddressDataGridViewTextBoxColumn,
            this.tBalanceDataGridViewTextBoxColumn,
            this.tPercentageDataGridViewTextBoxColumn});
            this.dataGridViewTeachers.Location = new System.Drawing.Point(3, 275);
            this.dataGridViewTeachers.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridViewTeachers.Name = "dataGridViewTeachers";
            this.dataGridViewTeachers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewTeachers.RowHeadersWidth = 51;
            this.dataGridViewTeachers.RowTemplate.Height = 24;
            this.dataGridViewTeachers.Size = new System.Drawing.Size(1341, 462);
            this.dataGridViewTeachers.TabIndex = 10;
            // 
            // addTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 741);
            this.Controls.Add(this.dataGridViewTeachers);
            this.Controls.Add(this.groupBox1);
            this.Name = "addTeacher";
            this.Text = "addTeacher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_TID;
        private System.Windows.Forms.Label lblBalanceValidation;
        private System.Windows.Forms.TextBox textBox_TBalance;
        private System.Windows.Forms.Label lblPhoneValid;
        private System.Windows.Forms.Label lblPercentageValid;
        private System.Windows.Forms.Label lblAddressValid;
        private System.Windows.Forms.Label lblNameValid;
        private MaterialSkin.Controls.MaterialButton materialDelete;
        private System.Windows.Forms.TextBox textBox_TPercentage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_TName;
        private System.Windows.Forms.TextBox textBox_Filter;
        private System.Windows.Forms.TextBox textBox_TAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton materialEdit;
        private MaterialSkin.Controls.MaterialButton materialButton6;
        private MaterialSkin.Controls.MaterialButton materialButton5;
        private MaterialSkin.Controls.MaterialButton materialButtonAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_TPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPercentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewTeachers;
    }
}