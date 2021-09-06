using System;
using System.Windows.Forms;
using CongProject.Common;
using System.Linq;
using CongProject.Entities;
using Newtonsoft.Json;

namespace CongProject.GuiEntity
{
    public partial class frmRoleManager : DevExpress.XtraEditors.XtraForm
    {
        public frmRoleManager()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            grid.BeginUpdate();
            grid.DataSource = Constants.appDbContext.tblRoles.Where(x => x.Name.ToLower().Trim() != "admin").ToDataTable<tblRole>();
            grid.EndUpdate();
        }
        private void mnuAdd_Click(object sender, EventArgs e)
        {
            if(new frmRole().ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void mnuEdit_Click(object sender, EventArgs e)
        {
            var arrRow = gridView1.GetSelectedRows();
            if (!arrRow.Any())
                return;
            var roleId = int.Parse(gridView1.GetRowCellValue(arrRow[0], "Id").ToString());
            if (new frmRole(roleId).ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void mnuDelete_Click(object sender, EventArgs e)
        {
            var arrRow = gridView1.GetSelectedRows();
            if (!arrRow.Any())
                return;
            var roleName = gridView1.GetRowCellValue(arrRow[0], "RoleName");

            if (MessageBox.Show($"Xoá vai trò '{roleName}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var roleId = int.Parse(gridView1.GetRowCellValue(arrRow[0], "Id").ToString());
                var entity = Constants.appDbContext.tblRoles.Find(roleId);
                Constants.appDbContext.tblRoles.Remove(entity);
                Constants.appDbContext.tblLogs.Add(new tblLog { Action = (int)enumAction.DELETE, TableName = "tblRole", Account = 0, CreatedTime = DateTime.Now, Object = JsonConvert.SerializeObject(entity) });
                Constants.appDbContext.SaveChanges();
                MessageBox.Show("Đã lưu dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }
        private void mnu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var arrRow = gridView1.GetSelectedRows();
            mnuDelete.Enabled = arrRow.Any();
            mnuEdit.Enabled = arrRow.Any();
        }
    }
}