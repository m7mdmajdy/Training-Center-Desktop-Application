namespace trainingCenter
{
    partial class AddCostes
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
            this.metroSetButton4 = new MetroSet_UI.Controls.MetroSetButton();
            this.dgvCostes = new System.Windows.Forms.DataGridView();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbCostesID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCostesName = new System.Windows.Forms.ComboBox();
            this.lblValidCostspayment = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbCostspayment = new System.Windows.Forms.TextBox();
            this.btnEdite = new MaterialSkin.Controls.MaterialButton();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.subId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.metroSetButton4.Location = new System.Drawing.Point(22, 31);
            this.metroSetButton4.Name = "metroSetButton4";
            this.metroSetButton4.NormalBorderColor = System.Drawing.Color.Transparent;
            this.metroSetButton4.NormalColor = System.Drawing.Color.Transparent;
            this.metroSetButton4.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton4.PressBorderColor = System.Drawing.Color.Transparent;
            this.metroSetButton4.PressColor = System.Drawing.Color.Transparent;
            this.metroSetButton4.PressTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton4.Size = new System.Drawing.Size(75, 53);
            this.metroSetButton4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButton4.StyleManager = null;
            this.metroSetButton4.TabIndex = 9;
            this.metroSetButton4.Text = "ï";
            this.metroSetButton4.ThemeAuthor = "Narwin";
            this.metroSetButton4.ThemeName = "MetroLite";
            // 
            // dgvCostes
            // 
            this.dgvCostes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(62)))));
            this.dgvCostes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCostes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subId,
            this.subName,
            this.Column1});
            this.dgvCostes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(74)))));
            this.dgvCostes.Location = new System.Drawing.Point(4, 342);
            this.dgvCostes.Name = "dgvCostes";
            this.dgvCostes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvCostes.RowHeadersWidth = 51;
            this.dgvCostes.Size = new System.Drawing.Size(1233, 322);
            this.dgvCostes.TabIndex = 8;
            this.dgvCostes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCostes_CellClick);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Calibri", 27.75F);
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(1031, 36);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(206, 45);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "اسعار الخدمات";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.label2.Location = new System.Drawing.Point(1155, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "إسم الخدمة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.label1.Location = new System.Drawing.Point(1155, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "كود الخدمة";
            // 
            // txtbCostesID
            // 
            this.txtbCostesID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtbCostesID.Enabled = false;
            this.txtbCostesID.Location = new System.Drawing.Point(923, 40);
            this.txtbCostesID.Name = "txtbCostesID";
            this.txtbCostesID.Size = new System.Drawing.Size(212, 27);
            this.txtbCostesID.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCostesName);
            this.groupBox1.Controls.Add(this.lblValidCostspayment);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtbCostspayment);
            this.groupBox1.Controls.Add(this.btnEdite);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtbCostesID);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(4, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1233, 245);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "البيانات";
            // 
            // cbCostesName
            // 
            this.cbCostesName.FormattingEnabled = true;
            this.cbCostesName.Location = new System.Drawing.Point(923, 111);
            this.cbCostesName.Name = "cbCostesName";
            this.cbCostesName.Size = new System.Drawing.Size(212, 28);
            this.cbCostesName.TabIndex = 18;
            this.cbCostesName.SelectionChangeCommitted += new System.EventHandler(this.cbCostesName_SelectionChangeCommitted);
            // 
            // lblValidCostspayment
            // 
            this.lblValidCostspayment.AutoSize = true;
            this.lblValidCostspayment.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lblValidCostspayment.ForeColor = System.Drawing.Color.Red;
            this.lblValidCostspayment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblValidCostspayment.Location = new System.Drawing.Point(965, 158);
            this.lblValidCostspayment.Name = "lblValidCostspayment";
            this.lblValidCostspayment.Size = new System.Drawing.Size(128, 20);
            this.lblValidCostspayment.TabIndex = 13;
            this.lblValidCostspayment.Text = "ادخل السعر كقيمة رقمية";
            this.lblValidCostspayment.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.label3.Location = new System.Drawing.Point(1153, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "سعر الخدمة";
            // 
            // txtbCostspayment
            // 
            this.txtbCostspayment.Location = new System.Drawing.Point(923, 181);
            this.txtbCostspayment.Name = "txtbCostspayment";
            this.txtbCostspayment.Size = new System.Drawing.Size(212, 27);
            this.txtbCostspayment.TabIndex = 11;
            this.txtbCostspayment.Enter += new System.EventHandler(this.txtbCostspayment_Enter);
            this.txtbCostspayment.Leave += new System.EventHandler(this.txtbCostspayment_Leave);
            // 
            // btnEdite
            // 
            this.btnEdite.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdite.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEdite.Depth = 0;
            this.btnEdite.HighEmphasis = true;
            this.btnEdite.Icon = null;
            this.btnEdite.Location = new System.Drawing.Point(41, 176);
            this.btnEdite.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEdite.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdite.Name = "btnEdite";
            this.btnEdite.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEdite.Size = new System.Drawing.Size(64, 36);
            this.btnEdite.TabIndex = 9;
            this.btnEdite.Text = "تعديل";
            this.btnEdite.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEdite.UseAccentColor = false;
            this.btnEdite.UseVisualStyleBackColor = true;
            this.btnEdite.Click += new System.EventHandler(this.btnEdite_Click);
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.Silver;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(1175, 8);
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
            this.metroSetControlBox1.TabIndex = 5;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroDark";
            // 
            // subId
            // 
            this.subId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.subId.HeaderText = "كود الخدمة";
            this.subId.MinimumWidth = 6;
            this.subId.Name = "subId";
            this.subId.ReadOnly = true;
            this.subId.Width = 99;
            // 
            // subName
            // 
            this.subName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subName.HeaderText = "اسم الخدمة";
            this.subName.MinimumWidth = 6;
            this.subName.Name = "subName";
            this.subName.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "سعر الخدمة";
            this.Column1.Name = "Column1";
            this.Column1.Width = 300;
            // 
            // AddCostes
            // 
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(62)))));
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.metroSetButton4);
            this.Controls.Add(this.dgvCostes);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroSetControlBox1);
            this.Name = "AddCostes";
            this.SmallLineColor1 = System.Drawing.Color.Transparent;
            this.SmallLineColor2 = System.Drawing.Color.Transparent;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddCostes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetButton metroSetButton4;
        private System.Windows.Forms.DataGridView dgvCostes;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbCostesID;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private System.Windows.Forms.Label lblValidCostspayment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbCostspayment;
        private System.Windows.Forms.ComboBox cbCostesName;
        private MaterialSkin.Controls.MaterialButton btnEdite;
        private System.Windows.Forms.DataGridViewTextBoxColumn subId;
        private System.Windows.Forms.DataGridViewTextBoxColumn subName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}