using System;
using System.Linq;
using CongProject.Common;
using CongProject.Entities;
using DevExpress.XtraEditors;

namespace CongProject.GuiEntity
{
    public partial class frmMainManager : XtraForm
    {
        private tblPermission _per_btnAccount, _per_btnRole, _per_btnRolePermission;
        private string _formCode = "F7";
        public frmMainManager()
        {
            InitializeComponent();
            InitPermission();
        }

        private void InitPermission()
        {
            var component_btnAccount = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnAccount");
            if (component_btnAccount != null)
            {
                _per_btnAccount = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnAccount.Id);
                if (_per_btnAccount != null)
                    btnAccount.Visible = _per_btnAccount.Read;
            }

            var component_btnRole = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnRole");
            if (component_btnRole != null)
            {
                _per_btnRole = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnRole.Id);
                if (_per_btnRole != null)
                    btnRole.Visible = _per_btnRole.Read;
            }

            var component_btnRolePermission = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnRolePermission");
            if (component_btnRolePermission != null)
            {
                _per_btnRolePermission = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnRolePermission.Id);
                if (_per_btnRolePermission != null)
                    btnRolePermission.Visible = _per_btnRolePermission.Read;
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            new frmAccountManager().ShowDialog();
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            new frmRoleManager().ShowDialog();
        }

        private void btnRolePermission_Click(object sender, EventArgs e)
        {
            new frmPermission().ShowDialog();
        }
    }
}