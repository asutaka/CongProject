using System;
using System.Linq;
using System.Windows.Forms;
using CongProject.Common;
using CongProject.Entities;

namespace CongProject.GuiEntity
{
    public partial class frmResetPassword : DevExpress.XtraEditors.XtraForm
    {
        private tblPermission _per_btnSave, _per_btnCancel, _per_btnView;
        private string _formCode = "F13";
        public frmResetPassword()
        {
            InitializeComponent();
            InitPermission();
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
        }
        private bool IsValid()
        {
            if(txtNewPassword.Text.Trim() != txtConfirm.Text)
            {
                MessageBox.Show("Mật khẩu mới không khớp nhau", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if(txtNewPassword.Text.Trim().Length < 5)
            {
                MessageBox.Show("Mật khẩu mới không được nhỏ hơn 5 ký tự", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValid())
                return;
            var entity = Constants.appDbContext.tblAccounts.Find(Constants.entityAccount.Id);
            entity.Password = StringCipher.Encrypt(txtNewPassword.Text.Trim(), Constants.SecretKey);
            Constants.appDbContext.SaveChanges();
            Constants.entityAccount = entity;
            MessageBox.Show("Đã lưu dữ liệu!");
            this.Close();
        }
    }
}