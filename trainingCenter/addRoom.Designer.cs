namespace trainingCenter
{
    partial class addRoom
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
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lbcapacity = new System.Windows.Forms.Label();
            this.lbsearch = new System.Windows.Forms.Label();
            this.lbroom = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btndelete = new MaterialSkin.Controls.MaterialButton();
            this.btnupdate = new MaterialSkin.Controls.MaterialButton();
            this.btnall = new MaterialSkin.Controls.MaterialButton();
            this.btnsearch = new MaterialSkin.Controls.MaterialButton();
            this.btnadd = new MaterialSkin.Controls.MaterialButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroSetButton4 = new MetroSet_UI.Controls.MetroSetButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.Silver;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(1183, 2);
            this.metroSetControlBox1.MaximizeBox = false;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroDark";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.lbcapacity);
            this.groupBox1.Controls.Add(this.lbsearch);
            this.groupBox1.Controls.Add(this.lbroom);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btnall);
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1225, 231);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "البيانات";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(3, 194);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(38, 27);
            this.txtCode.TabIndex = 49;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCode.Visible = false;
            // 
            // lbcapacity
            // 
            this.lbcapacity.AutoSize = true;
            this.lbcapacity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcapacity.ForeColor = System.Drawing.Color.Red;
            this.lbcapacity.Location = new System.Drawing.Point(987, 185);
            this.lbcapacity.Name = "lbcapacity";
            this.lbcapacity.Size = new System.Drawing.Size(78, 16);
            this.lbcapacity.TabIndex = 48;
            this.lbcapacity.Text = "ادخل سعة القاعة";
            // 
            // lbsearch
            // 
            this.lbsearch.AutoSize = true;
            this.lbsearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsearch.ForeColor = System.Drawing.Color.Red;
            this.lbsearch.Location = new System.Drawing.Point(230, 37);
            this.lbsearch.Name = "lbsearch";
            this.lbsearch.Size = new System.Drawing.Size(108, 16);
            this.lbsearch.TabIndex = 47;
            this.lbsearch.Text = "ادخل كود او اسم القاعة";
            // 
            // lbroom
            // 
            this.lbroom.AutoSize = true;
            this.lbroom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbroom.ForeColor = System.Drawing.Color.Red;
            this.lbroom.Location = new System.Drawing.Point(956, 79);
            this.lbroom.Name = "lbroom";
            this.lbroom.Size = new System.Drawing.Size(137, 16);
            this.lbroom.TabIndex = 46;
            this.lbroom.Text = "ادخل اسم القاعة باللغة العربية";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(905, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 27);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btndelete
            // 
            this.btndelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btndelete.BackColor = System.Drawing.Color.Maroon;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btndelete.Depth = 0;
            this.btndelete.HighEmphasis = true;
            this.btndelete.Icon = null;
            this.btndelete.Location = new System.Drawing.Point(760, 165);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btndelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btndelete.Name = "btndelete";
            this.btndelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btndelete.Size = new System.Drawing.Size(64, 36);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "حذف";
            this.btndelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btndelete.UseAccentColor = true;
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnupdate.Depth = 0;
            this.btnupdate.HighEmphasis = true;
            this.btnupdate.Icon = null;
            this.btnupdate.Location = new System.Drawing.Point(760, 104);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnupdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnupdate.Size = new System.Drawing.Size(64, 36);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "تعديل";
            this.btnupdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnupdate.UseAccentColor = false;
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnall
            // 
            this.btnall.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnall.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnall.Depth = 0;
            this.btnall.HighEmphasis = true;
            this.btnall.Icon = null;
            this.btnall.Location = new System.Drawing.Point(163, 125);
            this.btnall.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnall.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnall.Name = "btnall";
            this.btnall.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnall.Size = new System.Drawing.Size(80, 36);
            this.btnall.TabIndex = 9;
            this.btnall.Text = "عرض الكل";
            this.btnall.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnall.UseAccentColor = false;
            this.btnall.UseVisualStyleBackColor = true;
            this.btnall.Click += new System.EventHandler(this.btnall_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnsearch.Depth = 0;
            this.btnsearch.HighEmphasis = true;
            this.btnsearch.Icon = null;
            this.btnsearch.Location = new System.Drawing.Point(337, 125);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnsearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnsearch.Size = new System.Drawing.Size(64, 36);
            this.btnsearch.TabIndex = 9;
            this.btnsearch.Text = "بحث";
            this.btnsearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnsearch.UseAccentColor = false;
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnadd
            // 
            this.btnadd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnadd.Depth = 0;
            this.btnadd.HighEmphasis = true;
            this.btnadd.Icon = null;
            this.btnadd.Location = new System.Drawing.Point(760, 43);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnadd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnadd.Name = "btnadd";
            this.btnadd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnadd.Size = new System.Drawing.Size(64, 36);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "إضافة";
            this.btnadd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnadd.UseAccentColor = false;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1133, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "السعــــــة";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(163, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(238, 27);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1133, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم القاعة";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(905, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1148, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 36);
            this.label4.TabIndex = 1;
            this.label4.Text = "القاعــــات";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(62)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.RoomName,
            this.RoomCapacity});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(74)))));
            this.dataGridView1.Location = new System.Drawing.Point(18, 343);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 34;
            this.dataGridView1.Size = new System.Drawing.Size(1225, 351);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "كود القاعة";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // RoomName
            // 
            this.RoomName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoomName.HeaderText = "اسم القاعة";
            this.RoomName.Name = "RoomName";
            this.RoomName.ReadOnly = true;
            // 
            // RoomCapacity
            // 
            this.RoomCapacity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoomCapacity.HeaderText = "سعة القاعة";
            this.RoomCapacity.Name = "RoomCapacity";
            this.RoomCapacity.ReadOnly = true;
            // 
            // metroSetButton4
            // 
            this.metroSetButton4.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton4.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton4.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton4.Font = new System.Drawing.Font("Wingdings", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.metroSetButton4.HoverBorderColor = System.Drawing.Color.Transparent;
            this.metroSetButton4.HoverColor = System.Drawing.Color.Transparent;
            this.metroSetButton4.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton4.IsDerivedStyle = false;
            this.metroSetButton4.Location = new System.Drawing.Point(33, 3);
            this.metroSetButton4.Name = "metroSetButton4";
            this.metroSetButton4.NormalBorderColor = System.Drawing.Color.Transparent;
            this.metroSetButton4.NormalColor = System.Drawing.Color.Transparent;
            this.metroSetButton4.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton4.PressBorderColor = System.Drawing.Color.Transparent;
            this.metroSetButton4.PressColor = System.Drawing.Color.Transparent;
            this.metroSetButton4.PressTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton4.Size = new System.Drawing.Size(45, 83);
            this.metroSetButton4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButton4.StyleManager = null;
            this.metroSetButton4.TabIndex = 4;
            this.metroSetButton4.Text = "ï";
            this.metroSetButton4.ThemeAuthor = "Narwin";
            this.metroSetButton4.ThemeName = "MetroLite";
            // 
            // addRoom
            // 
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(62)))));
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.metroSetButton4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.label4);
            this.Name = "addRoom";
            this.SmallLineColor1 = System.Drawing.Color.Transparent;
            this.SmallLineColor2 = System.Drawing.Color.Transparent;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.addRoom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton btnadd;
        private MaterialSkin.Controls.MaterialButton btndelete;
        private MaterialSkin.Controls.MaterialButton btnupdate;
        private MaterialSkin.Controls.MaterialButton btnall;
        private MaterialSkin.Controls.MaterialButton btnsearch;
        private System.Windows.Forms.TextBox textBox3;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbcapacity;
        private System.Windows.Forms.Label lbsearch;
        private System.Windows.Forms.Label lbroom;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomCapacity;
    }
}

