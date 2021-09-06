namespace CongProject.GuiEntity
{
    partial class frmReport
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
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUser = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSolution = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbKeHoachSo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KeHoachSo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PlanDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtDistrict = new DevExpress.XtraEditors.TextEdit();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtCreate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblNgayLapKeHoach = new System.Windows.Forms.Label();
            this.lblDonViYC = new System.Windows.Forms.Label();
            this.txtDeXuat = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKeHoachSo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistrict.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Thời gian/địa điểm ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Kết quả thực hiện";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.txtDeXuat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblDonViYC);
            this.groupBox1.Controls.Add(this.lblNgayLapKeHoach);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSolution);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbKeHoachSo);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnView);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtDistrict);
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtCreate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 581);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kế hoạch";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(183, 211);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(625, 76);
            this.txtUser.TabIndex = 4;
            this.txtUser.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Lực lượng tham gia";
            // 
            // txtSolution
            // 
            this.txtSolution.Location = new System.Drawing.Point(183, 293);
            this.txtSolution.Name = "txtSolution";
            this.txtSolution.Size = new System.Drawing.Size(625, 76);
            this.txtSolution.TabIndex = 5;
            this.txtSolution.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nội dung kiểm tra";
            // 
            // cmbKeHoachSo
            // 
            this.cmbKeHoachSo.EditValue = "  ";
            this.cmbKeHoachSo.Location = new System.Drawing.Point(183, 132);
            this.cmbKeHoachSo.Name = "cmbKeHoachSo";
            this.cmbKeHoachSo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbKeHoachSo.Properties.NullText = "";
            this.cmbKeHoachSo.Properties.PopupView = this.gridView4;
            this.cmbKeHoachSo.Size = new System.Drawing.Size(149, 20);
            this.cmbKeHoachSo.TabIndex = 1;
            this.cmbKeHoachSo.EditValueChanged += new System.EventHandler(this.cmbKeHoachSo_EditValueChanged);
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.KeHoachSo,
            this.PlanDate});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
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
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = global::CongProject.Properties.Resources.Cancel_21x21;
            this.btnCancel.Location = new System.Drawing.Point(652, 540);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnView
            // 
            this.btnView.ImageOptions.Image = global::CongProject.Properties.Resources.search;
            this.btnView.Location = new System.Drawing.Point(733, 540);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 22;
            this.btnView.Text = "Xem";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = global::CongProject.Properties.Resources.Save_16x16;
            this.btnSave.Location = new System.Drawing.Point(571, 540);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Lưu lại";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDistrict
            // 
            this.txtDistrict.Location = new System.Drawing.Point(183, 185);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(625, 20);
            this.txtDistrict.TabIndex = 3;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(183, 375);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(625, 76);
            this.txtResult.TabIndex = 6;
            this.txtResult.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(336, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 25);
            this.label12.TabIndex = 21;
            this.label12.Text = "Báo cáo kết quả";
            // 
            // dtCreate
            // 
            this.dtCreate.Location = new System.Drawing.Point(183, 158);
            this.dtCreate.Name = "dtCreate";
            this.dtCreate.Size = new System.Drawing.Size(149, 21);
            this.dtCreate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày lập báo cáo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kế hoạch số ";
            // 
            // lblNgayLapKeHoach
            // 
            this.lblNgayLapKeHoach.AutoSize = true;
            this.lblNgayLapKeHoach.Location = new System.Drawing.Point(390, 164);
            this.lblNgayLapKeHoach.Name = "lblNgayLapKeHoach";
            this.lblNgayLapKeHoach.Size = new System.Drawing.Size(101, 13);
            this.lblNgayLapKeHoach.TabIndex = 34;
            this.lblNgayLapKeHoach.Text = "lblNgayLapKeHoach";
            this.lblNgayLapKeHoach.Visible = false;
            // 
            // lblDonViYC
            // 
            this.lblDonViYC.AutoSize = true;
            this.lblDonViYC.Location = new System.Drawing.Point(506, 164);
            this.lblDonViYC.Name = "lblDonViYC";
            this.lblDonViYC.Size = new System.Drawing.Size(57, 13);
            this.lblDonViYC.TabIndex = 35;
            this.lblDonViYC.Text = "lblDonViYC";
            this.lblDonViYC.Visible = false;
            // 
            // txtDeXuat
            // 
            this.txtDeXuat.Location = new System.Drawing.Point(183, 458);
            this.txtDeXuat.Name = "txtDeXuat";
            this.txtDeXuat.Size = new System.Drawing.Size(625, 76);
            this.txtDeXuat.TabIndex = 36;
            this.txtDeXuat.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Đề xuất";
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 584);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F12 - Báo cáo kết quả";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKeHoachSo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistrict.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnView;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtDistrict;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtSolution;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.GridLookUpEdit cmbKeHoachSo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn KeHoachSo;
        private DevExpress.XtraGrid.Columns.GridColumn PlanDate;
        private System.Windows.Forms.RichTextBox txtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblNgayLapKeHoach;
        private System.Windows.Forms.Label lblDonViYC;
        private System.Windows.Forms.RichTextBox txtDeXuat;
        private System.Windows.Forms.Label label5;
    }
}