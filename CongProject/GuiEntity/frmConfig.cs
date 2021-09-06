using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CongProject.Common;
using CongProject.Model;
using System.Data.SqlClient;
using CongProject.DAL;
using CongProject.Entities;
using System.Linq;

namespace CongProject.GuiEntity
{
    public partial class frmConfig : XtraForm
    {
        private UserConfigModel _model = null;
        private tblPermission _per_btnTest, _per_btnSave, _per_btnCancel, _per_btnConfig;
        private string _formCode = "F4";
        public frmConfig()
        {
            InitializeComponent();
            InitData();
            InitPermission();
        }
        private void InitPermission()
        {
            var component_btnTest = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnTest");
            if (component_btnTest != null)
            {
                _per_btnTest = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnTest.Id);
                if (_per_btnTest != null)
                    btnTest.Visible = _per_btnTest.Read;
            }

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
        }
        private void InitData()
        {
            _model = 0.LoadJson();
            txtIP.Text = _model.Connection.IP;
            txtDatabase.Text = _model.Connection.Database;
            txtUserID.Text = _model.Connection.UserId;
            txtPassword.Text = StringCipher.Decrypt(_model.Connection.Password, Constants.SecretKey);
        }
        private bool CheckValid()
        {
            _model.Connection = new ConnectionModel
            {
                IP = txtIP.Text.Trim(),
                Database = txtDatabase.Text.Trim(),
                UserId = txtUserID.Text.Trim(),
                Password = StringCipher.Encrypt(txtPassword.Text.Trim(), Constants.SecretKey)
            };
            try
            {

                new SqlConnection(_model.Connection.ToConnectionString()).Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (!CheckValid())
            {
                MessageBox.Show("Thiết lập không đúng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("Chuỗi kết nối hợp lệ!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValid())
            {
                MessageBox.Show("Thiết lập không đúng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Data.connectionString = 0.LoadJson().Connection.ToConnectionString();
            _model.UpdateJson();
            MessageBox.Show("Đã lưu dữ liệu", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}