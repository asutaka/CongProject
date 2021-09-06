namespace CongProject.GuiEntity
{
    partial class frmPermission
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
            this.RoleId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ComponentType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FormCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Read = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Write = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbRole = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.Location = new System.Drawing.Point(2, 102);
            this.grid.MainView = this.gridView1;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(649, 491);
            this.grid.TabIndex = 0;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.RoleId,
            this.Name,
            this.ComponentType,
            this.FormCode,
            this.Read,
            this.Write,
            this.Description});
            this.gridView1.GridControl = this.grid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // RoleId
            // 
            this.RoleId.Caption = "RoleId";
            this.RoleId.FieldName = "RoleId";
            this.RoleId.Name = "RoleId";
            this.RoleId.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // Name
            // 
            this.Name.AppearanceHeader.Options.UseTextOptions = true;
            this.Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Name.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Name.Caption = "Đối tượng";
            this.Name.FieldName = "Name";
            this.Name.Name = "Name";
            this.Name.OptionsColumn.AllowEdit = false;
            this.Name.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Name.Visible = true;
            this.Name.VisibleIndex = 0;
            this.Name.Width = 123;
            // 
            // ComponentType
            // 
            this.ComponentType.AppearanceCell.Options.UseTextOptions = true;
            this.ComponentType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ComponentType.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ComponentType.AppearanceHeader.Options.UseTextOptions = true;
            this.ComponentType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ComponentType.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ComponentType.Caption = "Loại";
            this.ComponentType.FieldName = "ComponentType";
            this.ComponentType.Name = "ComponentType";
            this.ComponentType.OptionsColumn.AllowEdit = false;
            this.ComponentType.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.ComponentType.Visible = true;
            this.ComponentType.VisibleIndex = 1;
            this.ComponentType.Width = 98;
            // 
            // FormCode
            // 
            this.FormCode.AppearanceCell.Options.UseTextOptions = true;
            this.FormCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FormCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.FormCode.AppearanceHeader.Options.UseTextOptions = true;
            this.FormCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FormCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.FormCode.Caption = "Mã form";
            this.FormCode.FieldName = "FormCode";
            this.FormCode.Name = "FormCode";
            this.FormCode.OptionsColumn.AllowEdit = false;
            this.FormCode.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.FormCode.Visible = true;
            this.FormCode.VisibleIndex = 2;
            // 
            // Read
            // 
            this.Read.AppearanceCell.Options.UseTextOptions = true;
            this.Read.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Read.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Read.AppearanceHeader.Options.UseTextOptions = true;
            this.Read.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Read.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Read.Caption = "Đọc";
            this.Read.FieldName = "Read";
            this.Read.Name = "Read";
            this.Read.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.Read.Visible = true;
            this.Read.VisibleIndex = 3;
            this.Read.Width = 40;
            // 
            // Write
            // 
            this.Write.AppearanceCell.Options.UseTextOptions = true;
            this.Write.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Write.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Write.AppearanceHeader.Options.UseTextOptions = true;
            this.Write.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Write.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Write.Caption = "Ghi";
            this.Write.FieldName = "Write";
            this.Write.Name = "Write";
            this.Write.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.Write.Visible = true;
            this.Write.VisibleIndex = 4;
            this.Write.Width = 40;
            // 
            // Description
            // 
            this.Description.AppearanceHeader.Options.UseTextOptions = true;
            this.Description.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Description.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Description.Caption = "Mô tả";
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            this.Description.OptionsColumn.AllowEdit = false;
            this.Description.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Description.Visible = true;
            this.Description.VisibleIndex = 5;
            this.Description.Width = 323;
            // 
            // cmbRole
            // 
            this.cmbRole.EditValue = "";
            this.cmbRole.Location = new System.Drawing.Point(81, 44);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbRole.Properties.DisplayMember = "Name";
            this.cmbRole.Properties.NullText = "";
            this.cmbRole.Properties.PopupView = this.gridLookUpEdit1View;
            this.cmbRole.Properties.ValueMember = "Id";
            this.cmbRole.Size = new System.Drawing.Size(217, 20);
            this.cmbRole.TabIndex = 1;
            this.cmbRole.EditValueChanged += new System.EventHandler(this.cmbRole_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Vai trò";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Vai trò";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.cmbRole);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(2, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 101);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vai trò";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.ImageOptions.Image = global::CongProject.Properties.Resources.Check_16x16;
            this.btnSave.Location = new System.Drawing.Point(549, 72);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu thay đổi";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 595);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F8 - Phân quyền";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GridLookUpEdit cmbRole;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn RoleId;
        private DevExpress.XtraGrid.Columns.GridColumn Name;
        private DevExpress.XtraGrid.Columns.GridColumn Read;
        private DevExpress.XtraGrid.Columns.GridColumn Write;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraGrid.Columns.GridColumn ComponentType;
        private DevExpress.XtraGrid.Columns.GridColumn FormCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}