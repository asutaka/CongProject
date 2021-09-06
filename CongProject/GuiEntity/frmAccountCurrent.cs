using System;
using System.Linq;
using System.Windows.Forms;
using CongProject.Common;
using CongProject.Entities;

namespace CongProject.GuiEntity
{
    public partial class frmAccountCurrent : DevExpress.XtraEditors.XtraForm
    {
        private tblPermission _per_btnSave, _per_btnCancel, _per_btnEditFullName, _per_btnEditBirthday, _per_btnEditPosition, _per_btnEditRole, _per_linkChangePassword, _per_btnOk; 
        private string _formCode = "F1";
        public frmAccountCurrent()
        {
            InitializeComponent();
            InitData();
            InitPermission();
        }
        private void InitData()
        {
            LoadData();
            txtAccount.Text = Constants.entityAccount.UserName;
            txtFullName.Text = Constants.entityAccount.FullName;
            dtBirthDay.Value = Constants.entityAccount.Birthday;
            txtPosition.Text = Constants.entityAccount.Position;
            cmbRole.EditValue = Constants.entityAccount.RoleId;
            txtTeam.Value = Constants.entityAccount.Team;
        }
        private void LoadData()
        {
            cmbRole.Properties.ValueMember = "Id";
            cmbRole.Properties.DisplayMember = "Name";
            if(Constants.entityAccount.Id == 1)
                cmbRole.Properties.DataSource = Constants.appDbContext.tblRoles.ToDataTable<tblRole>();
            else cmbRole.Properties.DataSource = Constants.appDbContext.tblRoles.Where(x => x.Name.Trim().ToLower() != "admin").ToDataTable<tblRole>();
        }
        private void InitPermission()
        {
            //var component_btnSave = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnSave");
            //if (component_btnSave != null)
            //{
            //    _per_btnSave = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnSave.Id);
            //    if (_per_btnSave != null)
            //        btnSave.Visible = _per_btnSave.Read;
            //}

            //var component_btnCancel = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnCancel");
            //if (component_btnCancel != null)
            //{
            //    _per_btnCancel = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnCancel.Id);
            //    if (_per_btnCancel != null)
            //        btnCancel.Visible = _per_btnCancel.Read;
            //}

            var component_btnEditFullName = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnEditFullName");
            if (component_btnEditFullName != null)
            {
                _per_btnEditFullName = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnEditFullName.Id);
                if (_per_btnEditFullName != null)
                    btnEditFullName.Visible = _per_btnEditFullName.Read;
            }

            var component_btnEditBirthday = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnEditBirthday");
            if (component_btnEditBirthday != null)
            {
                _per_btnEditBirthday = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnEditBirthday.Id);
                if (_per_btnEditBirthday != null)
                    btnEditBirthday.Visible = _per_btnEditBirthday.Read;
            }

            var component_btnEditPosition = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnEditPosition");
            if (component_btnEditPosition != null)
            {
                _per_btnEditPosition = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnEditPosition.Id);
                if (_per_btnEditPosition != null)
                    btnEditPosition.Visible = _per_btnEditPosition.Read;
            }

            var component_btnEditRole = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnEditRole");
            if (component_btnEditRole != null)
            {
                _per_btnEditRole = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnEditRole.Id);
                if (_per_btnEditRole != null)
                    btnEditRole.Visible = _per_btnEditRole.Read;
            }

            var component_linkChangePassword = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "linkChangePassword");
            if (component_linkChangePassword != null)
            {
                _per_linkChangePassword = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_linkChangePassword.Id);
                if (_per_linkChangePassword != null)
                    linkChangePassword.Visible = _per_linkChangePassword.Read;
            }

            var component_btnOk = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnOk");
            if (component_btnOk != null)
            {
                _per_btnOk = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnOk.Id);
                if (_per_btnOk != null)
                    btnOk.Visible = _per_btnOk.Read;
            }
        }
        private void btnEditFullName_Click(object sender, EventArgs e)
        {
            txtFullName.Enabled = true;
            btnCancel.Visible = true;
            btnSave.Visible = true;
            btnOk.Visible = false;
        }

        private void btnTeam_Click(object sender, EventArgs e)
        {
            txtTeam.Enabled = true;
            btnCancel.Visible = true;
            btnSave.Visible = true;
            btnOk.Visible = false;
        }

        private void btnEditBirthday_Click(object sender, EventArgs e)
        {
            dtBirthDay.Enabled = true;
            btnCancel.Visible = true;
            btnSave.Visible = true;
            btnOk.Visible = false;
        }

        private void btnEditPosition_Click(object sender, EventArgs e)
        {
            txtPosition.Enabled = true;
            btnCancel.Visible = true;
            btnSave.Visible = true;
            btnOk.Visible = false;
        }

        private void btnEditRole_Click(object sender, EventArgs e)
        {
            cmbRole.Enabled = true;
            btnCancel.Visible = true;
            btnSave.Visible = true;
            btnOk.Visible = false;
        }

        private void linkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmResetPassword().ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var entity = Constants.appDbContext.tblAccounts.Find(Constants.entityAccount.Id);
            if (txtFullName.Enabled)
                entity.FullName = txtFullName.Text.Trim();
            if (txtPosition.Enabled)
                entity.Position = txtPosition.Text.Trim();
            if (txtTeam.Enabled)
                entity.Team = (int)txtTeam.Value;
            if (dtBirthDay.Enabled)
                entity.Birthday = dtBirthDay.Value;
            if (cmbRole.Enabled)
            {
                entity.RoleId = (int)cmbRole.EditValue;
                entity.RoleName = cmbRole.Text;
            }
            Constants.appDbContext.SaveChanges();
            Constants.entityAccount = entity;
            DialogResult = DialogResult.OK;
            MessageBox.Show("Đã lưu dữ liệu!");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}