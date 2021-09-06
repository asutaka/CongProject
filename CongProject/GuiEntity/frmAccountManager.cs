using System;
using System.Windows.Forms;
using CongProject.Common;
using System.Linq;
using CongProject.Entities;

namespace CongProject.GuiEntity
{
    public partial class frmAccountManager : DevExpress.XtraEditors.XtraForm
    {
        private int _id;
        private bool _isActive = false;
        private int _rowSelect = -1;
        private int _rowSave = -1;
        private tblPermission _per_btnAdd, _per_btnEdit, _per_btnDelete, _per_chkLock;
        private string _formCode = "F3";
        public frmAccountManager()
        {
            InitializeComponent();
            InitPermission();
        }
        private void InitData()
        {
            LoadData();
        }
        private void LoadData()
        {
            _rowSave = _rowSelect;

            cmbRole.Properties.ValueMember = "Id";
            cmbRole.Properties.DisplayMember = "Name";
            cmbRole.Properties.DataSource = Constants.appDbContext.tblRoles.ToDataTable<tblRole>();

            grid.BeginUpdate();
            grid.DataSource = Constants.appDbContext.tblAccounts.Where(x => x.UserName.ToLower() != "admin").ToDataTable<tblAccount>();
            grid.EndUpdate();
        }
        private void InitPermission()
        {
            var component_btnAdd = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnAdd");
            if (component_btnAdd != null)
            {
                _per_btnAdd = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnAdd.Id);
                if (_per_btnAdd != null)
                    btnAdd.Visible = _per_btnAdd.Read;
            }

            var component_btnEdit = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnEdit");
            if (component_btnEdit != null)
            {
                _per_btnEdit = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnEdit.Id);
                if (_per_btnEdit != null)
                    btnEdit.Visible = _per_btnEdit.Read;
            }

            var component_btnDelete = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnDelete");
            if (component_btnDelete != null)
            {
                _per_btnDelete = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnDelete.Id);
                if (_per_btnDelete != null)
                    btnDelete.Visible = _per_btnDelete.Read;
            }

            var component_chkLock = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "chkLock");
            if (component_chkLock != null)
            {
                _per_chkLock = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_chkLock.Id);
                if (_per_chkLock != null)
                    chkLock.Visible = _per_chkLock.Read;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(new frmAccount().ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (new frmAccountEdit(_id).ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Xoá tài khoản {txtAccount.Text}?", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var entity = Constants.appDbContext.tblAccounts.Find(_id);
                Constants.appDbContext.tblAccounts.Remove(entity);
                Constants.appDbContext.SaveChanges();
                MessageBox.Show("Đã lưu dữ liệu!");
                LoadData();
            }
        }

        private void txtAccount_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAccount.Text))
            {
                chkLock.Checked = false;
                chkLock.Enabled = false;
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0)
                return;
            _isActive = false;
            _id = int.Parse(gridView1.GetRowCellValue(e.FocusedRowHandle, "Id").ToString());
            txtAccount.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "UserName").ToString();
            txtFullName.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "FullName").ToString();
            dtBirthDay.Value = DateTime.Parse(gridView1.GetRowCellValue(e.FocusedRowHandle, "Birthday").ToString());
            txtPosition.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "Position").ToString();
            cmbRole.EditValue = int.Parse(gridView1.GetRowCellValue(e.FocusedRowHandle, "RoleId").ToString());
            chkLock.Checked = bool.Parse(gridView1.GetRowCellValue(e.FocusedRowHandle, "IsLock").ToString());
            _rowSelect = e.FocusedRowHandle;
            _isActive = true;
        }

        private void frmAccountManager_Load(object sender, EventArgs e)
        {
            InitData();
            _isActive = true;
        }

        private void chkLock_CheckedChanged(object sender, EventArgs e)
        {
            if (!_isActive)
                return;
            var entity = Constants.appDbContext.tblAccounts.Find(_id);
            entity.IsLock = chkLock.Checked;
            Constants.appDbContext.SaveChanges();
            MessageBox.Show("Đã lưu dữ liệu!");
            LoadData();
            if(_rowSave > -1)
                gridView1.FocusedRowHandle = _rowSave;
        }

        private void chkLock_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (!_isActive)
                return;
            if (chkLock.Checked)
            {
                if (MessageBox.Show($"Mở khoá tài khoản {txtAccount.Text}?", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    return;
                }
            }
            else
            {
                if (MessageBox.Show($"Khoá tài khoản {txtAccount.Text}?", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    return;
                }
            }
            e.Cancel = true;
        }
    }
}