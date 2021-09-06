using System;
using System.Linq;
using System.Windows.Forms;
using CongProject.Common;
using CongProject.Entities;

namespace CongProject.GuiEntity
{
    public partial class frmAccount : DevExpress.XtraEditors.XtraForm
    {
        private tblPermission _per_btnSave, _per_btnCancel;
        private string _formCode = "F0";
        public frmAccount()
        {
            InitializeComponent();
            InitData();
            InitPermission();
        }
        private void InitData()
        {
            LoadData();
        }
        private void InitPermission()
        {
            var component_btnSave = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnSave");
            if(component_btnSave != null)
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
        }
        private void LoadData()
        {
            cmbRole.Properties.ValueMember = "Id";
            cmbRole.Properties.DisplayMember = "Name";
            cmbRole.Properties.DataSource = Constants.appDbContext.tblRoles.Where(x => x.Name.Trim().ToLower() != "admin").ToDataTable<tblRole>();
        }
        private bool Isvalid()
        {
            if (string.IsNullOrWhiteSpace(txtAccount.Text))
            {
                MessageBox.Show("Tài khoản không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Họ tên không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(cmbRole.Text))
            {
                MessageBox.Show("Vai trò không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            var isExist = Constants.appDbContext.tblAccounts.Any(x => x.UserName == txtAccount.Text.Trim());
            if (isExist)
            {
                MessageBox.Show("Tài khoản đã tồn tại, vui lòng kiểm tra lại tài khoản!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Isvalid())
                return;

            Constants.appDbContext.tblAccounts.Add(new tblAccount { 
                UserName = txtAccount.Text.Trim(),
                FullName = txtFullName.Text.Trim(),
                Position = txtPosition.Text.Trim(),
                Team = (int)txtTeam.Value,
                Birthday = dtBirthDay.Value,
                RoleId = (int)cmbRole.EditValue,
                RoleName = cmbRole.Text,
                Password = StringCipher.Encrypt(Constants.DefaultPassword, Constants.SecretKey)
            });
            Constants.appDbContext.SaveChanges();
            MessageBox.Show("Đã lưu dữ liệu!");
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}