using CongProject.Common;
using CongProject.Entities;
using System.Linq;
using System.Windows.Forms;

namespace CongProject.GuiEntity
{
    public partial class frmRole : DevExpress.XtraEditors.XtraForm
    {
        private tblPermission _per_btnSave, _per_btnCancel;
        private string _formCode = "F14";
        private int _id;
        public frmRole()
        {
            InitializeComponent();
            InitPermission();
        }
        public frmRole(int id)
        {
            InitializeComponent();
            _id = id;
            InitData();
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
            if (_id > 0)
            {
                var entity = Constants.appDbContext.tblRoles.Find(_id);
                txtRole.Text = entity.Name;
            }
        }
        private bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(txtRole.Text))
            {
                MessageBox.Show("Vai trò không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            var isExist = Constants.appDbContext.tblRoles.Any(x => x.Name == txtRole.Text.Trim());
            if (isExist)
            {
                MessageBox.Show("Tên vai trò đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (!IsValid())
                return;
            var entity = Constants.appDbContext.tblRoles.Find(_id);
            if(entity != null)
            {
                entity.Name = txtRole.Text.Trim();
            }
            else
            {
                Constants.appDbContext.tblRoles.Add(new Entities.tblRole { Name = txtRole.Text.Trim() });
            }
            Constants.appDbContext.SaveChanges();
            MessageBox.Show("Đã lưu dữ liệu!");
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}