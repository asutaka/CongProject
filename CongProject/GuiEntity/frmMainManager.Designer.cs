namespace CongProject.GuiEntity
{
    partial class frmMainManager
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
            this.btnAccount = new DevExpress.XtraEditors.SimpleButton();
            this.btnRole = new DevExpress.XtraEditors.SimpleButton();
            this.btnRolePermission = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnAccount
            // 
            this.btnAccount.Location = new System.Drawing.Point(90, 59);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(115, 23);
            this.btnAccount.TabIndex = 1;
            this.btnAccount.Text = "Tài khoản";
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnRole
            // 
            this.btnRole.Location = new System.Drawing.Point(90, 100);
            this.btnRole.Name = "btnRole";
            this.btnRole.Size = new System.Drawing.Size(115, 23);
            this.btnRole.TabIndex = 3;
            this.btnRole.Text = "Vai trò";
            this.btnRole.Click += new System.EventHandler(this.btnRole_Click);
            // 
            // btnRolePermission
            // 
            this.btnRolePermission.Location = new System.Drawing.Point(90, 139);
            this.btnRolePermission.Name = "btnRolePermission";
            this.btnRolePermission.Size = new System.Drawing.Size(115, 23);
            this.btnRolePermission.TabIndex = 4;
            this.btnRolePermission.Text = "Vai trò - quyền hạn";
            this.btnRolePermission.Click += new System.EventHandler(this.btnRolePermission_Click);
            // 
            // frmMainManager
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Controls.Add(this.btnRolePermission);
            this.Controls.Add(this.btnRole);
            this.Controls.Add(this.btnAccount);
            this.Name = "frmMainManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F7 - Quản lý";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAccount;
        private DevExpress.XtraEditors.SimpleButton btnRole;
        private DevExpress.XtraEditors.SimpleButton btnRolePermission;
    }
}