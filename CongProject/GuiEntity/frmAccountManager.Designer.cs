namespace CongProject.GuiEntity
{
    partial class frmAccountManager
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
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Birthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Position = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IsLock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoleId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.cmbRole = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtPosition = new DevExpress.XtraEditors.TextEdit();
            this.dtBirthDay = new System.Windows.Forms.DateTimePicker();
            this.txtFullName = new DevExpress.XtraEditors.TextEdit();
            this.txtAccount = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkLock = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccount.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkLock.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.Location = new System.Drawing.Point(1, 194);
            this.grid.MainView = this.gridView1;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(595, 341);
            this.grid.TabIndex = 10;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.UserName,
            this.Birthday,
            this.Position,
            this.RoleName,
            this.IsLock,
            this.RoleId});
            this.gridView1.GridControl = this.grid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // UserName
            // 
            this.UserName.AppearanceCell.Options.UseTextOptions = true;
            this.UserName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UserName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.UserName.AppearanceHeader.Options.UseTextOptions = true;
            this.UserName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UserName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.UserName.Caption = "Tài khoản";
            this.UserName.FieldName = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.UserName.Visible = true;
            this.UserName.VisibleIndex = 0;
            // 
            // Birthday
            // 
            this.Birthday.AppearanceCell.Options.UseTextOptions = true;
            this.Birthday.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Birthday.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Birthday.AppearanceHeader.Options.UseTextOptions = true;
            this.Birthday.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Birthday.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Birthday.Caption = "Ngày sinh";
            this.Birthday.FieldName = "Birthday";
            this.Birthday.Name = "Birthday";
            this.Birthday.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.Birthday.Visible = true;
            this.Birthday.VisibleIndex = 1;
            // 
            // Position
            // 
            this.Position.AppearanceCell.Options.UseTextOptions = true;
            this.Position.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Position.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Position.AppearanceHeader.Options.UseTextOptions = true;
            this.Position.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Position.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Position.Caption = "Chức vụ";
            this.Position.FieldName = "Position";
            this.Position.Name = "Position";
            this.Position.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Position.Visible = true;
            this.Position.VisibleIndex = 2;
            // 
            // RoleName
            // 
            this.RoleName.AppearanceCell.Options.UseTextOptions = true;
            this.RoleName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RoleName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RoleName.AppearanceHeader.Options.UseTextOptions = true;
            this.RoleName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RoleName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RoleName.Caption = "Vai trò";
            this.RoleName.FieldName = "RoleName";
            this.RoleName.Name = "RoleName";
            this.RoleName.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.RoleName.Visible = true;
            this.RoleName.VisibleIndex = 3;
            // 
            // IsLock
            // 
            this.IsLock.Caption = "IsLock";
            this.IsLock.FieldName = "IsLock";
            this.IsLock.Name = "IsLock";
            this.IsLock.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            // 
            // RoleId
            // 
            this.RoleId.Caption = "RoleId";
            this.RoleId.FieldName = "RoleId";
            this.RoleId.Name = "RoleId";
            this.RoleId.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.Image = global::CongProject.Properties.Resources.Add_16x16;
            this.btnAdd.Location = new System.Drawing.Point(430, 79);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm tài khoản";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ImageOptions.Image = global::CongProject.Properties.Resources.Edit1_16x16;
            this.btnEdit.Location = new System.Drawing.Point(430, 109);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(105, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Sửa tài khoản";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cmbRole
            // 
            this.cmbRole.Location = new System.Drawing.Point(183, 141);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.cmbRole.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.cmbRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbRole.Properties.NullText = "";
            this.cmbRole.Properties.PopupView = this.gridLookUpEdit1View;
            this.cmbRole.Properties.ReadOnly = true;
            this.cmbRole.Size = new System.Drawing.Size(179, 20);
            this.cmbRole.TabIndex = 5;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(183, 111);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtPosition.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtPosition.Properties.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(179, 20);
            this.txtPosition.TabIndex = 4;
            // 
            // dtBirthDay
            // 
            this.dtBirthDay.CalendarForeColor = System.Drawing.Color.Black;
            this.dtBirthDay.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtBirthDay.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dtBirthDay.Enabled = false;
            this.dtBirthDay.Location = new System.Drawing.Point(183, 81);
            this.dtBirthDay.Name = "dtBirthDay";
            this.dtBirthDay.Size = new System.Drawing.Size(179, 21);
            this.dtBirthDay.TabIndex = 3;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(183, 53);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtFullName.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtFullName.Properties.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(179, 20);
            this.txtFullName.TabIndex = 2;
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(183, 26);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtAccount.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtAccount.Properties.ReadOnly = true;
            this.txtAccount.Size = new System.Drawing.Size(179, 20);
            this.txtAccount.TabIndex = 1;
            this.txtAccount.EditValueChanged += new System.EventHandler(this.txtAccount_EditValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Vai trò";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Chức vị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Họ tên";
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = global::CongProject.Properties.Resources.Trash_16x16;
            this.btnDelete.Location = new System.Drawing.Point(430, 139);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xóa tài khoản";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.chkLock);
            this.groupBox1.Controls.Add(this.txtAccount);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbRole);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPosition);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtBirthDay);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 191);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // chkLock
            // 
            this.chkLock.Location = new System.Drawing.Point(183, 167);
            this.chkLock.Name = "chkLock";
            this.chkLock.Properties.Caption = "Khóa";
            this.chkLock.Size = new System.Drawing.Size(75, 20);
            this.chkLock.TabIndex = 6;
            this.chkLock.CheckedChanged += new System.EventHandler(this.chkLock_CheckedChanged);
            this.chkLock.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.chkLock_EditValueChanging);
            // 
            // frmAccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 537);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid);
            this.Name = "frmAccountManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F3 - Quản lý tài khoản";
            this.Load += new System.EventHandler(this.frmAccountManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccount.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkLock.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.GridLookUpEdit cmbRole;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txtPosition;
        private System.Windows.Forms.DateTimePicker dtBirthDay;
        private DevExpress.XtraEditors.TextEdit txtFullName;
        private DevExpress.XtraEditors.TextEdit txtAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn UserName;
        private DevExpress.XtraGrid.Columns.GridColumn Birthday;
        private DevExpress.XtraGrid.Columns.GridColumn Position;
        private DevExpress.XtraGrid.Columns.GridColumn RoleName;
        private DevExpress.XtraGrid.Columns.GridColumn IsLock;
        private DevExpress.XtraGrid.Columns.GridColumn RoleId;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.CheckEdit chkLock;
    }
}