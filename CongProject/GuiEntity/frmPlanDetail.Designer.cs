namespace CongProject.GuiEntity
{
    partial class frmPlanDetail
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
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.mnu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mniDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KeHoachSo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PlanDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PlanContent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RequireContent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SolutionKey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SolutionValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RiskKey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RiskValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ResourceKey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ResourceValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserKey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Group = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ImpDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.District = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status_Text = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.mnu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.ContextMenuStrip = this.mnu;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.gridView1;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(998, 674);
            this.grid.TabIndex = 0;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // mnu
            // 
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniDetail,
            this.mniDelete,
            this.mnuReport,
            this.mnuExport});
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(168, 92);
            this.mnu.Opening += new System.ComponentModel.CancelEventHandler(this.mnu_Opening);
            // 
            // mniDetail
            // 
            this.mniDetail.Image = global::CongProject.Properties.Resources.Infomation_16x16;
            this.mniDetail.Name = "mniDetail";
            this.mniDetail.Size = new System.Drawing.Size(167, 22);
            this.mniDetail.Text = "Xem chi tiết";
            this.mniDetail.Click += new System.EventHandler(this.mniDetail_Click);
            // 
            // mniDelete
            // 
            this.mniDelete.Image = global::CongProject.Properties.Resources.Trash_16x16;
            this.mniDelete.Name = "mniDelete";
            this.mniDelete.Size = new System.Drawing.Size(167, 22);
            this.mniDelete.Text = "Xóa";
            this.mniDelete.Click += new System.EventHandler(this.mniDelete_Click);
            // 
            // mnuReport
            // 
            this.mnuReport.Image = global::CongProject.Properties.Resources.Check_16x16;
            this.mnuReport.Name = "mnuReport";
            this.mnuReport.Size = new System.Drawing.Size(167, 22);
            this.mnuReport.Text = "Báo cáo kế hoạch";
            this.mnuReport.Click += new System.EventHandler(this.mnuReport_Click);
            // 
            // mnuExport
            // 
            this.mnuExport.Image = global::CongProject.Properties.Resources.work_16x16;
            this.mnuExport.Name = "mnuExport";
            this.mnuExport.Size = new System.Drawing.Size(167, 22);
            this.mnuExport.Text = "Xuất Word";
            this.mnuExport.Click += new System.EventHandler(this.mnuExport_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.KeHoachSo,
            this.PlanDate,
            this.PlanContent,
            this.RequireContent,
            this.SolutionKey,
            this.SolutionValue,
            this.RiskKey,
            this.RiskValue,
            this.ResourceKey,
            this.ResourceValue,
            this.UserKey,
            this.UserValue,
            this.Group,
            this.ImpDate,
            this.District,
            this.Status,
            this.Status_Text});
            this.gridView1.GridControl = this.grid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            // 
            // KeHoachSo
            // 
            this.KeHoachSo.AppearanceCell.Options.UseTextOptions = true;
            this.KeHoachSo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.KeHoachSo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.KeHoachSo.AppearanceHeader.Options.UseTextOptions = true;
            this.KeHoachSo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.KeHoachSo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.KeHoachSo.Caption = "Kế hoạch số";
            this.KeHoachSo.FieldName = "KeHoachSo";
            this.KeHoachSo.Name = "KeHoachSo";
            this.KeHoachSo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.KeHoachSo.Visible = true;
            this.KeHoachSo.VisibleIndex = 0;
            this.KeHoachSo.Width = 158;
            // 
            // PlanDate
            // 
            this.PlanDate.AppearanceCell.Options.UseTextOptions = true;
            this.PlanDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PlanDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.PlanDate.AppearanceHeader.Options.UseTextOptions = true;
            this.PlanDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PlanDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.PlanDate.Caption = "Ngày lập kế hoạch";
            this.PlanDate.FieldName = "PlanDate";
            this.PlanDate.Name = "PlanDate";
            this.PlanDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.PlanDate.Visible = true;
            this.PlanDate.VisibleIndex = 1;
            this.PlanDate.Width = 176;
            // 
            // PlanContent
            // 
            this.PlanContent.AppearanceHeader.Options.UseTextOptions = true;
            this.PlanContent.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PlanContent.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.PlanContent.Caption = "PlanContent";
            this.PlanContent.FieldName = "PlanContent";
            this.PlanContent.Name = "PlanContent";
            this.PlanContent.UnboundType = DevExpress.Data.UnboundColumnType.String;
            // 
            // RequireContent
            // 
            this.RequireContent.AppearanceHeader.Options.UseTextOptions = true;
            this.RequireContent.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RequireContent.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RequireContent.Caption = "RequireContent";
            this.RequireContent.FieldName = "RequireContent";
            this.RequireContent.Name = "RequireContent";
            this.RequireContent.UnboundType = DevExpress.Data.UnboundColumnType.String;
            // 
            // SolutionKey
            // 
            this.SolutionKey.Caption = "SolutionKey";
            this.SolutionKey.FieldName = "SolutionKey";
            this.SolutionKey.Name = "SolutionKey";
            // 
            // SolutionValue
            // 
            this.SolutionValue.AppearanceHeader.Options.UseTextOptions = true;
            this.SolutionValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SolutionValue.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SolutionValue.Caption = "SolutionValue";
            this.SolutionValue.FieldName = "SolutionValue";
            this.SolutionValue.Name = "SolutionValue";
            this.SolutionValue.UnboundType = DevExpress.Data.UnboundColumnType.String;
            // 
            // RiskKey
            // 
            this.RiskKey.Caption = "RiskKey";
            this.RiskKey.FieldName = "RiskKey";
            this.RiskKey.Name = "RiskKey";
            // 
            // RiskValue
            // 
            this.RiskValue.AppearanceHeader.Options.UseTextOptions = true;
            this.RiskValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RiskValue.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RiskValue.Caption = "RiskValue";
            this.RiskValue.FieldName = "RiskValue";
            this.RiskValue.Name = "RiskValue";
            this.RiskValue.UnboundType = DevExpress.Data.UnboundColumnType.String;
            // 
            // ResourceKey
            // 
            this.ResourceKey.Caption = "ResourceKey";
            this.ResourceKey.FieldName = "ResourceKey";
            this.ResourceKey.Name = "ResourceKey";
            // 
            // ResourceValue
            // 
            this.ResourceValue.AppearanceHeader.Options.UseTextOptions = true;
            this.ResourceValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ResourceValue.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ResourceValue.Caption = "ResourceValue";
            this.ResourceValue.FieldName = "ResourceValue";
            this.ResourceValue.Name = "ResourceValue";
            this.ResourceValue.UnboundType = DevExpress.Data.UnboundColumnType.String;
            // 
            // UserKey
            // 
            this.UserKey.Caption = "UserKey";
            this.UserKey.FieldName = "UserKey";
            this.UserKey.Name = "UserKey";
            // 
            // UserValue
            // 
            this.UserValue.AppearanceHeader.Options.UseTextOptions = true;
            this.UserValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UserValue.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.UserValue.Caption = "Cán bộ";
            this.UserValue.FieldName = "UserValue";
            this.UserValue.Name = "UserValue";
            this.UserValue.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.UserValue.Visible = true;
            this.UserValue.VisibleIndex = 2;
            this.UserValue.Width = 314;
            // 
            // Group
            // 
            this.Group.AppearanceHeader.Options.UseTextOptions = true;
            this.Group.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Group.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Group.Caption = "Group";
            this.Group.FieldName = "Group";
            this.Group.Name = "Group";
            this.Group.UnboundType = DevExpress.Data.UnboundColumnType.String;
            // 
            // ImpDate
            // 
            this.ImpDate.AppearanceCell.Options.UseTextOptions = true;
            this.ImpDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ImpDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ImpDate.AppearanceHeader.Options.UseTextOptions = true;
            this.ImpDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ImpDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ImpDate.Caption = "Ngày triển khai";
            this.ImpDate.FieldName = "ImpDate";
            this.ImpDate.Name = "ImpDate";
            this.ImpDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.ImpDate.Visible = true;
            this.ImpDate.VisibleIndex = 3;
            this.ImpDate.Width = 187;
            // 
            // District
            // 
            this.District.AppearanceHeader.Options.UseTextOptions = true;
            this.District.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.District.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.District.Caption = "Địa điểm";
            this.District.FieldName = "District";
            this.District.Name = "District";
            this.District.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.District.Visible = true;
            this.District.VisibleIndex = 4;
            this.District.Width = 529;
            // 
            // Status
            // 
            this.Status.Caption = "Status";
            this.Status.FieldName = "Status";
            this.Status.Name = "Status";
            // 
            // Status_Text
            // 
            this.Status_Text.AppearanceCell.Options.UseTextOptions = true;
            this.Status_Text.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Status_Text.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Status_Text.AppearanceHeader.Options.UseTextOptions = true;
            this.Status_Text.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Status_Text.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Status_Text.Caption = "Trạng thái";
            this.Status_Text.FieldName = "Status_Text";
            this.Status_Text.Name = "Status_Text";
            this.Status_Text.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Status_Text.Visible = true;
            this.Status_Text.VisibleIndex = 5;
            this.Status_Text.Width = 189;
            // 
            // frmPlanDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 674);
            this.Controls.Add(this.grid);
            this.Name = "frmPlanDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F10  - Kế hoạch chi tiết";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.mnu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn KeHoachSo;
        private DevExpress.XtraGrid.Columns.GridColumn PlanDate;
        private DevExpress.XtraGrid.Columns.GridColumn PlanContent;
        private DevExpress.XtraGrid.Columns.GridColumn RequireContent;
        private DevExpress.XtraGrid.Columns.GridColumn SolutionKey;
        private DevExpress.XtraGrid.Columns.GridColumn SolutionValue;
        private DevExpress.XtraGrid.Columns.GridColumn RiskKey;
        private DevExpress.XtraGrid.Columns.GridColumn RiskValue;
        private DevExpress.XtraGrid.Columns.GridColumn ResourceKey;
        private DevExpress.XtraGrid.Columns.GridColumn ResourceValue;
        private DevExpress.XtraGrid.Columns.GridColumn UserKey;
        private DevExpress.XtraGrid.Columns.GridColumn UserValue;
        private DevExpress.XtraGrid.Columns.GridColumn Group;
        private DevExpress.XtraGrid.Columns.GridColumn ImpDate;
        private DevExpress.XtraGrid.Columns.GridColumn District;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraGrid.Columns.GridColumn Status_Text;
        private System.Windows.Forms.ContextMenuStrip mnu;
        private System.Windows.Forms.ToolStripMenuItem mniDetail;
        private System.Windows.Forms.ToolStripMenuItem mniDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuReport;
        private System.Windows.Forms.ToolStripMenuItem mnuExport;
    }
}