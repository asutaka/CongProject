using System;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;
using CongProject.Common;
using CongProject.Entities;

namespace CongProject.GuiEntity
{
    public partial class frmAccountEdit : DevExpress.XtraEditors.XtraForm
    {
        private int _id;
        private bool _isResetPassword;
        private tblPermission _per_btnSave, _per_btnCancel, _per_linkResetPassword;
        private string _formCode = "F2";
        public frmAccountEdit(int id)
        {
            InitializeComponent();
            _id = id;
            InitData();
            InitPermission();
        }

        private void InitData()
        {
            LoadData();
            var entity = Constants.appDbContext.tblAccounts.Find(_id);
            txtAccount.Text = entity.UserName;
            txtFullName.Text = entity.FullName;
            txtPosition.Text = entity.Position;
            dtBirthDay.Value = entity.Birthday;
            cmbRole.EditValue = entity.RoleId;
            txtTeam.Value = entity.Team;
        }

        private void LoadData()
        {
            cmbRole.Properties.ValueMember = "Id";
            cmbRole.Properties.DisplayMember = "Name";
            cmbRole.Properties.DataSource = Constants.appDbContext.tblRoles.Where(x => x.Name.Trim().ToLower() != "admin").ToDataTable<tblRole>();
        }
        private void InitPermission()
        {
            var component_btnSave = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnSave");
            if (component_btnSave != null)
            {
                _per_btnSave = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnSave.Id);
                if (_per_btnSave != null)
                    btnSave.Visible = _per_btnSave.Read;
            }

            var component_btnCancel = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnCancel");
            if (component_btnCancel != null)
            {
                _per_btnCancel = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnCancel.Id);
                if (_per_btnCancel != null)
                    btnCancel.Visible = _per_btnCancel.Read;
            }

            var component_linkResetPassword = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "linkResetPassword");
            if (component_linkResetPassword != null)
            {
                _per_linkResetPassword = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_linkResetPassword.Id);
                if (_per_linkResetPassword != null)
                    linkResetPassword.Visible = _per_linkResetPassword.Read;
            }
        }
        private void linkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(MessageBox.Show("Reset mật khẩu về mặc định?", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _isResetPassword = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var entity = Constants.appDbContext.tblAccounts.Find(_id);
                if (txtFullName.Enabled)
                    entity.FullName = txtFullName.Text.Trim();
                if (txtPosition.Enabled)
                    entity.Position = txtPosition.Text.Trim();
                if (dtBirthDay.Enabled)
                    entity.Birthday = dtBirthDay.Value;
                if (cmbRole.Enabled)
                {
                    entity.RoleId = (int)cmbRole.EditValue;
                    entity.RoleName = cmbRole.Text;
                }
                entity.Team = (int)txtTeam.Value;
                if (_isResetPassword)
                {
                    entity.Password = StringCipher.Encrypt(Constants.DefaultPassword, Constants.SecretKey);
                }
                Constants.appDbContext.SaveChanges();
                MessageBox.Show("Đã lưu dữ liệu!");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(DbEntityValidationException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}