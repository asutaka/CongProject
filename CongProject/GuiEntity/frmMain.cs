using CongProject.Common;
using System;
using System.Windows.Forms;
using System.Linq;
using CongProject.Entities;
using System.Diagnostics;
using System.IO;

namespace CongProject.GuiEntity
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        private tblPermission _per_btnLogin, _per_lblFullName, _per_lblLogout, _per_btnConfig, _per_btnReportFirst, _per_btnDetailFirst, _per_btnDetailAll, _per_btnPlanLast, _per_btnReportLast, _per_btnDetailLast;
        private string _formCode = "F6";
        public frmMain()
        {
            InitializeComponent();
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

            var component_lblFullName = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "lblFullName");
            if (component_lblFullName != null)
            {
                _per_lblFullName = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_lblFullName.Id);
                if (_per_lblFullName != null)
                    lblFullName.Visible = _per_lblFullName.Read;
            }

            var component_lblLogout = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "lblLogout");
            if (component_lblLogout != null)
            {
                _per_lblLogout = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_lblLogout.Id);
                if (_per_lblLogout != null)
                    lblLogout.Visible = _per_lblLogout.Read;
            }

            var component_btnReportFirst = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnReportFirst");
            if (component_btnReportFirst != null)
            {
                _per_btnReportFirst = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnReportFirst.Id);
                if (_per_btnReportFirst != null)
                    btnReportFirst.Visible = _per_btnReportFirst.Read;
            }

            var component_btnDetailFirst = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnDetailFirst");
            if (component_btnDetailFirst != null)
            {
                _per_btnDetailFirst = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnDetailFirst.Id);
                if (_per_btnDetailFirst != null)
                    btnDetailFirst.Visible = _per_btnDetailFirst.Read;
            }

            var component_btnDetailAll = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnDetailAll");
            if (component_btnDetailAll != null)
            {
                _per_btnDetailAll = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnDetailAll.Id);
                if (_per_btnDetailAll != null)
                    btnDetailAll.Visible = _per_btnDetailAll.Read;
            }

            var component_btnPlanLast = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnPlanLast");
            if (component_btnPlanLast != null)
            {
                _per_btnPlanLast = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnPlanLast.Id);
                if (_per_btnPlanLast != null)
                    btnPlanLast.Visible = _per_btnPlanLast.Read;
            }

            var component_btnReportLast = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnReportLast");
            if (component_btnReportLast != null)
            {
                _per_btnReportLast = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnReportLast.Id);
                if (_per_btnReportLast != null)
                    btnReportLast.Visible = _per_btnReportLast.Read;
            }

            var component_btnDetailLast = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnDetailLast");
            if (component_btnDetailLast != null)
            {
                _per_btnDetailLast = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnDetailLast.Id);
                if (_per_btnDetailLast != null)
                    btnDetailLast.Visible = _per_btnDetailLast.Read;
            }

            var component_btnPlan = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnPlan");
            if (component_btnPlan != null)
            {
                var entityPermission = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnDetailLast.Id);
                if (entityPermission != null)
                    btnPlan.Enabled = entityPermission.Read;
            }

            var component_btnResult = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnResult");
            if (component_btnResult != null)
            {
                var entityPermission = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnDetailLast.Id);
                if (entityPermission != null)
                    btnResult.Enabled = entityPermission.Read;
            }

            var component_btnReport = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnReport");
            if (component_btnReport != null)
            {
                var entityPermission = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnDetailLast.Id);
                if (entityPermission != null)
                    btnReport.Enabled = entityPermission.Read;
            }

            var component_btnPermission = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnPermission");
            if (component_btnPermission != null)
            {
                var entityPermission = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnDetailLast.Id);
                if (entityPermission != null)
                    btnPermission.Enabled = entityPermission.Read;
            }

            var component_btnFile = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnFile");
            if (component_btnFile != null)
            {
                var entityPermission = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnDetailLast.Id);
                if (entityPermission != null)
                    btnFile.Enabled = entityPermission.Read;
            }

            var component_btnNetwork = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnNetwork");
            if (component_btnNetwork != null)
            {
                var entityPermission = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnDetailLast.Id);
                if (entityPermission != null)
                    btnNetwork.Enabled = entityPermission.Read;
            }
        }
        private void InitData()
        {
            var firstTimeCurrentWeek = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
            var lastTimeCurrentWeek = firstTimeCurrentWeek.AddDays(6);
            var firstTimeLastWeek = firstTimeCurrentWeek.AddDays(-7);
            var lastTimeLastWeek = firstTimeLastWeek.AddDays(6);
            dtFromLast.Value = firstTimeCurrentWeek;
            dtToLast.Value = lastTimeCurrentWeek;
            dtFromFirst.Value = firstTimeLastWeek;
            dtToFirst.Value = lastTimeLastWeek;

            var lastFirstDiv = firstTimeLastWeek.AddDays(-1);
            var lastLastDiv = lastTimeLastWeek.AddDays(1);
            var lastPlan = Constants.appDbContext.tblPlans.Where(x => x.PlanDate > lastFirstDiv && x.PlanDate < lastLastDiv);
            var lastPlanCount = lastPlan.Count();
            var lastReportCount = lastPlan.Where(x => x.Status == (int)enumPlanStatus.COMPLETE).Count();
            var lastLossReportCount = lastPlanCount - lastReportCount;
            lblFirstPlan.Text = lastPlanCount.To2Digit();
            lblFirstReport.Text = lastReportCount.To2Digit();
            lblFirstLossReport.Text = lastLossReportCount.To2Digit();

            var currentFirstDiv = firstTimeCurrentWeek.AddDays(-1);
            var currentLastDiv = lastTimeCurrentWeek.AddDays(1);
            var currentPlan = Constants.appDbContext.tblPlans.Where(x => x.PlanDate > currentFirstDiv && x.PlanDate < currentLastDiv);
            var currentPlanCount = currentPlan.Count();
            var currentReportCount = currentPlan.Where(x => x.Status == (int)enumPlanStatus.COMPLETE).Count();
            var currentLossReportCount = currentPlanCount - currentReportCount;
            lblLastPlan.Text = currentPlanCount.To2Digit();
            lblLastReport.Text = currentReportCount.To2Digit();
            lblLastLossReport.Text = currentLossReportCount.To2Digit();
        }
        public void SetLogin()
        {
            btnLogin.Visible = false;
            groupBox1.Visible = true;
            lblAccount.Text = Constants.entityAccount.UserName;
            lblFullName.Text = Constants.entityAccount.FullName;
            lblPosition.Text = Constants.entityAccount.Position;
            lblRole.Text = Constants.entityAccount.RoleName;

            pnlFirstPlan.Visible = false;
            pnlFirstReport.Visible = false;
            pnlFirstLossReport.Visible = false;
            pnlLastPlan.Visible = false;
            pnlLastReport.Visible = false;
            pnlLastLossReport.Visible = false;
            InitPermission();
        }
        private void lblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupBox1.Visible = false;
            btnLogin.Visible = true;

            pnlFirstPlan.Visible = true;
            pnlFirstReport.Visible = true;
            pnlFirstLossReport.Visible = true;
            pnlLastPlan.Visible = true;
            pnlLastReport.Visible = true;
            pnlLastLossReport.Visible = true;
            new frmLogin(this).ShowDialog();
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            new frmPlan().Show();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            new frmReport(dtFromLast.Value, dtToLast.Value).Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            new frmPlanDetail(dtFromLast.Value, dtToLast.Value).Show();
        }

        private void btnPermission_Click(object sender, EventArgs e)
        {
            new frmMainManager().Show();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            var root = Directory.GetCurrentDirectory();
            Process.Start($"{root}//Template");
        }

        private void btnNetwork_Click(object sender, EventArgs e)
        {
            new frmConfig().Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            new frmLogin(this).ShowDialog();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            new frmConfig().Show();
        }

        private void btnDetailAll_Click(object sender, EventArgs e)
        {
            new frmPlanDetail().Show();
        }

        private void btnPlanLast_Click(object sender, EventArgs e)
        {
            new frmPlan().Show();
        }

        private void dtReportFirst_Click(object sender, EventArgs e)
        {
            new frmReport(dtFromFirst.Value, dtToFirst.Value).Show();
        }

        private void btnReportLast_Click(object sender, EventArgs e)
        {
            new frmReport(dtFromLast.Value, dtToLast.Value).Show();
        }

        private void btnDetailFirst_Click(object sender, EventArgs e)
        {
            new frmPlanDetail(dtFromFirst.Value, dtToFirst.Value).Show();
        }

        private void btnDetailLast_Click(object sender, EventArgs e)
        {
            new frmPlanDetail(dtFromLast.Value, dtToLast.Value).Show();
        }

        private void lblFullName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(new frmAccountCurrent().ShowDialog() == DialogResult.OK)
            {
                SetLogin();
            }
        }
    }
}