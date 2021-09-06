namespace CongProject.GuiEntity
{
    partial class frmAccountCurrent
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbRole = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditRole = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditPosition = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditBirthday = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditFullName = new DevExpress.XtraEditors.SimpleButton();
            this.txtPosition = new DevExpress.XtraEditors.TextEdit();
            this.dtBirthDay = new System.Windows.Forms.DateTimePicker();
            this.txtFullName = new DevExpress.XtraEditors.TextEdit();
            this.txtAccount = new DevExpress.XtraEditors.TextEdit();
            this.linkChangePassword = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnTeam = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTeam = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.txtTeam);
            this.groupBox1.Controls.Add(this.btnTeam);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbRole);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnEditRole);
            this.groupBox1.Controls.Add(this.btnEditPosition);
            this.groupBox1.Controls.Add(this.btnEditBirthday);
            this.groupBox1.Controls.Add(this.btnEditFullName);
            this.groupBox1.Controls.Add(this.txtPosition);
            this.groupBox1.Controls.Add(this.dtBirthDay);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.txtAccount);
            this.groupBox1.Controls.Add(this.linkChangePassword);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // cmbRole
            // 
            this.cmbRole.Enabled = false;
            this.cmbRole.Location = new System.Drawing.Point(120, 209);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbRole.Properties.NullText = "";
            this.cmbRole.Properties.PopupView = this.gridLookUpEdit1View;
            this.cmbRole.Size = new System.Drawing.Size(179, 20);
            this.cmbRole.TabIndex = 10;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = global::CongProject.Properties.Resources.Check_16x16;
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSave.Location = new System.Drawing.Point(143, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Lưu lại";
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEditRole
            // 
            this.btnEditRole.ImageOptions.Image = global::CongProject.Properties.Resources.Edit1_16x16;
            this.btnEditRole.Location = new System.Drawing.Point(300, 209);
            this.btnEditRole.Name = "btnEditRole";
            this.btnEditRole.Size = new System.Drawing.Size(23, 20);
            this.btnEditRole.TabIndex = 11;
            this.btnEditRole.Click += new System.EventHandler(this.btnEditRole_Click);
            // 
            // btnEditPosition
            // 
            this.btnEditPosition.ImageOptions.Image = global::CongProject.Properties.Resources.Edit1_16x16;
            this.btnEditPosition.Location = new System.Drawing.Point(300, 146);
            this.btnEditPosition.Name = "btnEditPosition";
            this.btnEditPosition.Size = new System.Drawing.Size(23, 20);
            this.btnEditPosition.TabIndex = 7;
            this.btnEditPosition.Click += new System.EventHandler(this.btnEditPosition_Click);
            // 
            // btnEditBirthday
            // 
            this.btnEditBirthday.ImageOptions.Image = global::CongProject.Properties.Resources.Edit1_16x16;
            this.btnEditBirthday.Location = new System.Drawing.Point(300, 116);
            this.btnEditBirthday.Name = "btnEditBirthday";
            this.btnEditBirthday.Size = new System.Drawing.Size(23, 20);
            this.btnEditBirthday.TabIndex = 5;
            this.btnEditBirthday.Click += new System.EventHandler(this.btnEditBirthday_Click);
            // 
            // btnEditFullName
            // 
            this.btnEditFullName.ImageOptions.Image = global::CongProject.Properties.Resources.Edit1_16x16;
            this.btnEditFullName.Location = new System.Drawing.Point(300, 88);
            this.btnEditFullName.Name = "btnEditFullName";
            this.btnEditFullName.Size = new System.Drawing.Size(23, 20);
            this.btnEditFullName.TabIndex = 3;
            this.btnEditFullName.Click += new System.EventHandler(this.btnEditFullName_Click);
            // 
            // txtPosition
            // 
            this.txtPosition.Enabled = false;
            this.txtPosition.Location = new System.Drawing.Point(120, 146);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(179, 20);
            this.txtPosition.TabIndex = 6;
            // 
            // dtBirthDay
            // 
            this.dtBirthDay.Enabled = false;
            this.dtBirthDay.Location = new System.Drawing.Point(120, 116);
            this.dtBirthDay.Name = "dtBirthDay";
            this.dtBirthDay.Size = new System.Drawing.Size(179, 21);
            this.dtBirthDay.TabIndex = 4;
            // 
            // txtFullName
            // 
            this.txtFullName.Enabled = false;
            this.txtFullName.Location = new System.Drawing.Point(120, 88);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(179, 20);
            this.txtFullName.TabIndex = 2;
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(120, 61);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtAccount.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtAccount.Properties.ReadOnly = true;
            this.txtAccount.Size = new System.Drawing.Size(179, 20);
            this.txtAccount.TabIndex = 1;
            // 
            // linkChangePassword
            // 
            this.linkChangePassword.AutoSize = true;
            this.linkChangePassword.Location = new System.Drawing.Point(42, 249);
            this.linkChangePassword.Name = "linkChangePassword";
            this.linkChangePassword.Size = new System.Drawing.Size(70, 13);
            this.linkChangePassword.TabIndex = 12;
            this.linkChangePassword.TabStop = true;
            this.linkChangePassword.Text = "Đổi mật khẩu";
            this.linkChangePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChangePassword_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vai trò";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chức vị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = global::CongProject.Properties.Resources.Cancel_21x21;
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.Location = new System.Drawing.Point(224, 294);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.ImageOptions.Image = global::CongProject.Properties.Resources.Check_16x16;
            this.btnOk.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnOk.Location = new System.Drawing.Point(224, 294);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 22;
            this.btnOk.Text = "Đồng ý";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnTeam
            // 
            this.btnTeam.ImageOptions.Image = global::CongProject.Properties.Resources.Edit1_16x16;
            this.btnTeam.Location = new System.Drawing.Point(300, 177);
            this.btnTeam.Name = "btnTeam";
            this.btnTeam.Size = new System.Drawing.Size(23, 20);
            this.btnTeam.TabIndex = 9;
            this.btnTeam.Click += new System.EventHandler(this.btnTeam_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Đội";
            // 
            // txtTeam
            // 
            this.txtTeam.Enabled = false;
            this.txtTeam.Location = new System.Drawing.Point(120, 176);
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.Size = new System.Drawing.Size(179, 21);
            this.txtTeam.TabIndex = 8;
            // 
            // frmAccountCurrent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 336);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAccountCurrent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F1 - Tài khoản";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtPosition;
        private System.Windows.Forms.DateTimePicker dtBirthDay;
        private DevExpress.XtraEditors.TextEdit txtFullName;
        private DevExpress.XtraEditors.TextEdit txtAccount;
        private System.Windows.Forms.LinkLabel linkChangePassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnEditRole;
        private DevExpress.XtraEditors.SimpleButton btnEditPosition;
        private DevExpress.XtraEditors.SimpleButton btnEditBirthday;
        private DevExpress.XtraEditors.SimpleButton btnEditFullName;
        private DevExpress.XtraEditors.GridLookUpEdit cmbRole;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton btnTeam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtTeam;
    }
}