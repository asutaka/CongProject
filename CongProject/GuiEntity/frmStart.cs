using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CongProject.Common;
using CongProject.Model;
using System.Data.SqlClient;
using CongProject.DAL;

namespace CongProject.GuiEntity
{
    public partial class frmStart : XtraForm
    {
        private UserConfigModel _model = null;
        public frmStart()
        {
            InitializeComponent();
            InitData();
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