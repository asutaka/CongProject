using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CongProject.Common;
using CongProject.Entities;

namespace CongProject.GuiEntity
{
    public partial class frmPermission : XtraForm
    {
        private tblPermission _per_btnSave;
        private string _formCode = "F8";
        public frmPermission()
        {
            InitializeComponent();
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
        }
        private void InitData()
        {
            LoadDataCombobox();
        }
        private void LoadDataCombobox()
        {
            cmbRole.Properties.ValueMember = "Id";
            cmbRole.Properties.DisplayMember = "Name";
            cmbRole.Properties.DataSource = Constants.appDbContext.tblRoles.Where(x => x.Name.ToLower() != "admin").ToDataTable<tblRole>();
        }
        private void LoadData()
        {
            var lstResult = (from p in Constants.appDbContext.tblPermissions
                              join c in Constants.appDbContext.tblComponents on p.ComponentId equals c.Id
                              where p.RoleId == (int)cmbRole.EditValue 
                              select new
                              {
                                  p.Id,
                                  p.RoleId,
                                  c.Name,
                                  c.ComponentType,
                                  c.FormCode,
                                  p.Read,
                                  p.Write,
                                  c.Description
                              });
            var dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("RoleId", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("ComponentType", typeof(int));
            dt.Columns.Add("FormCode", typeof(string));
            dt.Columns.Add("Read", typeof(bool));
            dt.Columns.Add("Write", typeof(bool));
            dt.Columns.Add("Description", typeof(string));
            foreach (var item in lstResult)
            {
                var dr = dt.NewRow();
                dr["Id"] = item.Id;
                dr["RoleId"] = item.RoleId;
                dr["Name"] = item.Name;
                dr["ComponentType"] = item.ComponentType;
                dr["FormCode"] = item.FormCode;
                dr["Read"] = item.Read;
                dr["Write"] = item.Write;
                dr["Description"] = item.Description;
                dt.Rows.Add(dr);
            }

            grid.BeginUpdate();
            grid.DataSource = dt;
            grid.EndUpdate();
        }

        private void cmbRole_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var dt = gridView1.GetDataTable();
            foreach (var item in dt.AsEnumerable())
            {
                var entity = Constants.appDbContext.tblPermissions.Find((int)item["Id"]);
                if(entity != null)
                {
                    entity.Read = (bool)item["Read"];
                    entity.Write = (bool)item["Write"];
                }
            }
            Constants.appDbContext.SaveChanges();
            MessageBox.Show("Đã lưu dữ liệu!","Thông báo");
            LoadData();
        }
    }
}