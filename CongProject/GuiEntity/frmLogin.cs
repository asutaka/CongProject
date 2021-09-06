using System;
using System.Windows.Forms;
using CongProject.Common;
using CongProject.Model;
using System.Linq;
using CongProject.Entities;

namespace CongProject.GuiEntity
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private frmMain _frm;
        private UserConfigModel _model = null;
        private tblPermission _per_btnLogin, _per_chkSavePassword;
        private string _formCode = "F5";
        public frmLogin(frmMain frm)
        {
            InitializeComponent();
            this._frm = frm;
            InitData();
            InitPermission();
        }
        private void InitPermission()
        {
            var component_btnLogin = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnLogin");
            if (component_btnLogin != null)
            {
                _per_btnLogin = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnLogin.Id);
                if (_per_btnLogin != null)
                    btnLogin.Visible = _per_btnLogin.Read;
            }

            var component_chkSavePassword = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "chkSavePassword");
            if (component_chkSavePassword != null)
            {
                _per_chkSavePassword = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_chkSavePassword.Id);
                if (_per_chkSavePassword != null)
                    chkSavePassword.Visible = _per_chkSavePassword.Read;
            }
        }
        private void InitData()
        {
            _model = 0.LoadJson();
            txtUserName.Text = _model.Login.UserName;
            txtPassword.Text = StringCipher.Decrypt(_model.Login.Password, Constants.SecretKey);
        }
        private bool CheckExistUser()
        {
            var entity = Constants.appDbContext.tblAccounts.FirstOrDefault(x => x.UserName == txtUserName.Text.Trim());
            if (entity == null)
                return false;
            if (entity.IsLock)
                return false;

            var decrypt = StringCipher.Decrypt(entity.Password, Constants.SecretKey);
            if (txtPassword.Text.Trim() == decrypt)
            {
                Constants.entityAccount.Id = entity.Id;
                Constants.entityAccount.UserName = entity.UserName;
                Constants.entityAccount.Password = decrypt;
                Constants.entityAccount.RoleId = entity.RoleId;
                Constants.entityAccount.RoleName = entity.RoleName;
                Constants.entityAccount.Position = entity.Position;
                Constants.entityAccount.Team = entity.Team;
                Constants.entityAccount.FullName = entity.FullName;
                Constants.entityAccount.Birthday = entity.Birthday;
                Constants.entityAccount.IsLock = entity.IsLock;
                return true;
            }
            return false;
        }
        private void Login()
        {
            if (!CheckExistUser())
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng, đăng nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Text = string.Empty;
                return;
            }
            if (txtPassword.Text.ToString() == Constants.DefaultPassword)
            {
                if (new frmResetPassword().ShowDialog() == DialogResult.OK)
                {
                    txtPassword.EditValue = null;
                    txtPassword.Focus();
                }
                return;
            }
            if (chkSavePassword.Checked)
            {
                _model.Login = new LoginModel
                {
                    UserName = txtUserName.Text.Trim(),
                    Password = StringCipher.Encrypt(txtPassword.Text.Trim(), Constants.SecretKey)
                };
            }
            else
            {
                _model.Login = new LoginModel
                {
                    UserName = string.Empty,
                    Password = string.Empty
                };
            }
            _model.UpdateJson();
            _frm.SetLogin();
            this.Close();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}