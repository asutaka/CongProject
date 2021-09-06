namespace CongProject.GuiEntity
{
    partial class frmPlanEdit
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
            this.dtCreate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbUser = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.cmbResource = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.cmbRisk = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.cmbSolution = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtDistrict = new DevExpress.XtraEditors.TextEdit();
            this.txtGroup = new DevExpress.XtraEditors.TextEdit();
            this.txtContentRequire = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtContentPlan = new System.Windows.Forms.RichTextBox();
            this.dtPlan = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNo = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.cmbLoaiYeuCau = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDonViYC = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbResource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRisk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSolution.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistrict.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonViYC.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtCreate
            // 
            this.dtCreate.Location = new System.Drawing.Point(183, 106);
            this.dtCreate.Name = "dtCreate";
            this.dtCreate.Size = new System.Drawing.Size(149, 21);
            this.dtCreate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày tạo kế hoạch";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbLoaiYeuCau);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtDonViYC);
            this.groupBox1.Controls.Add(this.cmbUser);
            this.groupBox1.Controls.Add(this.cmbResource);
            this.groupBox1.Controls.Add(this.cmbRisk);
            this.groupBox1.Controls.Add(this.cmbSolution);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnView);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtDistrict);
            this.groupBox1.Controls.Add(this.txtGroup);
            this.groupBox1.Controls.Add(this.txtContentRequire);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtContentPlan);
            this.groupBox1.Controls.Add(this.dtPlan);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNo);
            this.groupBox1.Controls.Add(this.dtCreate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 586);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kế hoạch";
            // 
            // cmbUser
            // 
            this.cmbUser.Location = new System.Drawing.Point(183, 373);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbUser.Size = new System.Drawing.Size(625, 20);
            this.cmbUser.TabIndex = 11;
            // 
            // cmbResource
            // 
            this.cmbResource.Location = new System.Drawing.Point(183, 334);
            this.cmbResource.Name = "cmbResource";
            this.cmbResource.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbResource.Size = new System.Drawing.Size(625, 20);
            this.cmbResource.TabIndex = 9;
            // 
            // cmbRisk
            // 
            this.cmbRisk.Location = new System.Drawing.Point(183, 296);
            this.cmbRisk.Name = "cmbRisk";
            this.cmbRisk.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbRisk.Size = new System.Drawing.Size(625, 20);
            this.cmbRisk.TabIndex = 8;
            // 
            // cmbSolution
            // 
            this.cmbSolution.Location = new System.Drawing.Point(183, 260);
            this.cmbSolution.Name = "cmbSolution";
            this.cmbSolution.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSolution.Size = new System.Drawing.Size(625, 20);
            this.cmbSolution.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = global::CongProject.Properties.Resources.Cancel_21x21;
            this.btnCancel.Location = new System.Drawing.Point(652, 538);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnView
            // 
            this.btnView.ImageOptions.Image = global::CongProject.Properties.Resources.search;
            this.btnView.Location = new System.Drawing.Point(733, 538);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 22;
            this.btnView.Text = "Xem";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = global::CongProject.Properties.Resources.Save_16x16;
            this.btnSave.Location = new System.Drawing.Point(571, 538);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Lưu lại";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDistrict
            // 
            this.txtDistrict.Location = new System.Drawing.Point(183, 489);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(625, 20);
            this.txtDistrict.TabIndex = 15;
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(183, 410);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(625, 20);
            this.txtGroup.TabIndex = 13;
            // 
            // txtContentRequire
            // 
            this.txtContentRequire.Location = new System.Drawing.Point(183, 196);
            this.txtContentRequire.Name = "txtContentRequire";
            this.txtContentRequire.Size = new System.Drawing.Size(625, 50);
            this.txtContentRequire.TabIndex = 6;
            this.txtContentRequire.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(336, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(211, 25);
            this.label12.TabIndex = 21;
            this.label12.Text = "Xây dựng kế hoạch";
            // 
            // txtContentPlan
            // 
            this.txtContentPlan.Location = new System.Drawing.Point(183, 134);
            this.txtContentPlan.Name = "txtContentPlan";
            this.txtContentPlan.Size = new System.Drawing.Size(625, 50);
            this.txtContentPlan.TabIndex = 5;
            this.txtContentPlan.Text = "";
            // 
            // dtPlan
            // 
            this.dtPlan.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dtPlan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPlan.Location = new System.Drawing.Point(183, 448);
            this.dtPlan.Name = "dtPlan";
            this.dtPlan.Size = new System.Drawing.Size(149, 21);
            this.dtPlan.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 492);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Địa điểm ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 454);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Thời gian dự kiến ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Đơn vị phối hợp ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Lực lượng tham gia ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Phương tiện, vật tư ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Dự kiến tình huống ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Phương pháp tiến hành ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nội dung yêu cầu ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nội dung kế hoạch ";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(183, 80);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(149, 20);
            this.txtNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kế hoạch số ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmbLoaiYeuCau
            // 
            this.cmbLoaiYeuCau.FormattingEnabled = true;
            this.cmbLoaiYeuCau.Items.AddRange(new object[] {
            "Kiểm tra",
            "Phòng ngừa ",
            "Chế áp"});
            this.cmbLoaiYeuCau.Location = new System.Drawing.Point(468, 104);
            this.cmbLoaiYeuCau.Name = "cmbLoaiYeuCau";
            this.cmbLoaiYeuCau.Size = new System.Drawing.Size(340, 21);
            this.cmbLoaiYeuCau.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(383, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Loại yêu cầu";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(383, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Đơn vị yêu cầu";
            // 
            // txtDonViYC
            // 
            this.txtDonViYC.Location = new System.Drawing.Point(468, 80);
            this.txtDonViYC.Name = "txtDonViYC";
            this.txtDonViYC.Size = new System.Drawing.Size(340, 20);
            this.txtDonViYC.TabIndex = 2;
            // 
            // frmPlanEdit
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 584);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmPlanEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F11 - Kế hoạch";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbResource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRisk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSolution.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistrict.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonViYC.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtPlan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtNo;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnView;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtDistrict;
        private DevExpress.XtraEditors.TextEdit txtGroup;
        private System.Windows.Forms.RichTextBox txtContentRequire;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox txtContentPlan;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cmbSolution;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cmbUser;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cmbResource;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cmbRisk;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox cmbLoaiYeuCau;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.TextEdit txtDonViYC;
    }
}