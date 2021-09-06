using System;
using System.Data;
using DevExpress.XtraEditors;
using CongProject.Common;
using System.IO;
using DocumentFormat.OpenXml.Packaging;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Threading;
using System.Linq;
using CongProject.Entities;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace CongProject.GuiEntity
{
    public partial class frmPlan : XtraForm
    {
        private tblPermission _per_btnAddSolution, _per_btnAddRisk, _per_btnAddResource, _per_btnAddUser, _per_btnSave, _per_btnCancel, _per_btnView, _per_lblTemplate;
        private string _formCode = "F9";
        public frmPlan()
        {
            InitializeComponent();
            InitData();
            InitPermission();
        }
        private void InitData()
        {
            var KeHoachSo = Constants.appDbContext.tblPlans.OrderByDescending(x => x.PlanDate).ThenByDescending(x => x.KeHoachSo).Select(x => x.KeHoachSo).Take(1).FirstOrDefault();
            if (KeHoachSo == null)
                txtNo.Text = "1";
            else
            {
                var strSplit = KeHoachSo.Split('/');
                var val = int.Parse(strSplit[0]);
                val++;
                txtNo.Text = $"{val}";
            }
            LoadData();
            cmbLoaiYeuCau.SelectedIndex = 0;
        }
        private void InitPermission()
        {
            var component_btnAddSolution = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnAddSolution");
            if (component_btnAddSolution != null)
            {
                _per_btnAddSolution = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnAddSolution.Id);
                if (_per_btnAddSolution != null)
                    btnAddSolution.Visible = _per_btnAddSolution.Read;
            }

            var component_btnAddRisk = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnAddRisk");
            if (component_btnAddRisk != null)
            {
                _per_btnAddRisk = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnAddRisk.Id);
                if (_per_btnAddRisk != null)
                    btnAddRisk.Visible = _per_btnAddRisk.Read;
            }

            var component_btnAddResource = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnAddResource");
            if (component_btnAddResource != null)
            {
                _per_btnAddResource = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnAddResource.Id);
                if (_per_btnAddResource != null)
                    btnAddResource.Visible = _per_btnAddResource.Read;
            }

            var component_btnAddUser = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnAddUser");
            if (component_btnAddUser != null)
            {
                _per_btnAddUser = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnAddUser.Id);
                if (_per_btnAddUser != null)
                    btnAddUser.Visible = _per_btnAddUser.Read;
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

            var component_btnView = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnView");
            if (component_btnView != null)
            {
                _per_btnView = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnView.Id);
                if (_per_btnView != null)
                    btnView.Visible = _per_btnView.Read;
            }

            var component_lblTemplate = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "lblTemplate");
            if (component_lblTemplate != null)
            {
                _per_lblTemplate = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_lblTemplate.Id);
                if (_per_lblTemplate != null)
                    lblTemplate.Visible = _per_lblTemplate.Read;
            }
        }
        private void LoadData()
        {
            LoadDataSolution();
            LoadDataRisk();
            LoadDataResource();
            LoadDataUser();
        }
        private void RefreshForm()
        {
            this.Controls.Clear();
            InitializeComponent();
            InitData();
        }
        private void LoadDataSolution()
        {
            cmbSolution.Properties.DataSource = Constants.appDbContext.tblSolutions.ToDataTable<tblSolution>();
            cmbSolution.Properties.ValueMember = "Id";
            cmbSolution.Properties.DisplayMember = "Name";
        }
        private void LoadDataRisk()
        {
            cmbRisk.Properties.DataSource = Constants.appDbContext.tblRisks.ToDataTable<tblRisk>();
            cmbRisk.Properties.ValueMember = "Id";
            cmbRisk.Properties.DisplayMember = "Name";
        }
        private void LoadDataResource()
        {
            cmbResource.Properties.DataSource = Constants.appDbContext.tblResources.ToDataTable<tblResource>();
            cmbResource.Properties.ValueMember = "Id";
            cmbResource.Properties.DisplayMember = "Name";
        }
        private void LoadDataUser()
        {
            cmbUser.Properties.DataSource = Constants.appDbContext.tblUsers.ToDataTable<tblUser>();
            cmbUser.Properties.ValueMember = "Id";
            cmbUser.Properties.DisplayMember = "Name";
        }
        private async Task SaveFile(byte[] data, string fileName)
        {
            try
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    await stream.WriteAsync(data, 0, data.Length);
                    File.WriteAllBytes(fileName, stream.ToArray());
                }
                Process.Start(fileName);
            }
            catch (Exception ex)
            {
                NLogLogger.PublishException(ex, ex.Message);
            }
        }
        private byte[] SearchAndReplace(byte[] byteArray)
        {
            try
            {
                using (var stream = new MemoryStream())
                {
                    stream.Seek(0, SeekOrigin.Begin);
                    stream.Flush();
                    stream.Write(byteArray, 0, (int)byteArray.Length);
                    using (var wordDoc = WordprocessingDocument.Open(stream, true))
                    {
                        string docText = null;
                        using (var sr = new StreamReader(wordDoc.MainDocumentPart.GetStream()))
                        {
                            docText = sr.ReadToEnd();
                        }
                        //Replace Text
                        docText = ReplaceParameter(docText);
                        using (var sw = new StreamWriter(wordDoc.MainDocumentPart.GetStream(FileMode.Create)))
                        {
                            sw.Write(docText);
                        }

                    }
                    return stream.ToArray();
                }
            }
            catch (Exception ex)
            {
                NLogLogger.PublishException(ex, ex.Message);
            }
            return new byte[1];
        }
        private string ReplaceParameter(string docText)
        {
            try
            {
                var dt = dtCreate.Value;
                var dtDuKien = dtPlan.Value;
                var So = txtNo.Text.Trim();
                var DoiSo = Constants.entityAccount.Team.ToString();
                var NgayThang = $"ngày {dt.Day.To2Digit()} tháng {dt.Month.To2Digit()} năm {dt.Year}";
                var NoiDungKH = txtContentPlan.Text.Replace("\n", "<w:br/>").Trim();
                var NoiDungYC = txtContentRequire.Text.Replace("\n", "<w:br/>").Trim();
                var PhuongPhapTienHanh = $"- {cmbSolution.Text.Replace(".,", ".<w:br/>-")}";
                var DuKienTinhHuong = $"- {cmbRisk.Text.Replace(".,", ".<w:br/>-")}";
                var PhuongTien = $"- {cmbResource.Text.Replace(",", "<w:br/>-")}";
                var LucLuong = $"- {cmbUser.Text.Replace(",", "<w:br/>-")}";
                var ChuanHoaNgay = dtDuKien.Minute == 0 ? $"{dtDuKien.Hour} giờ," : $"{dtDuKien.Hour} giờ {dtDuKien.Minute},";
                var DuKien = $"{ChuanHoaNgay} ngày {dtDuKien.Day.To2Digit()} tháng {dtDuKien.Month.To2Digit()} năm {dtDuKien.Year}";
                var DonViPhoiHop = txtGroup.Text.Trim();
                var DiaDiem = txtDistrict.Text.Trim();
                var NguoiSoanThao = Constants.entityAccount.FullName.ToShortName();

                var valSo = "«So»";
                var valDoiSo = "«DoiSo»";
                var valNgayThang = "«NgayThang»";
                var valNoiDungKH = "«NoiDungKH»";
                var valNoiDungYC = "«NoiDungYC»";
                var valPhuongPhapTienHanh = "«PhuongPhapTienHanh»";
                var valDuKienTinhHuong = "«DuKienTinhHuong»";
                var valPhuongTien = "«PhuongTien»";
                var valLucLuongThamGia = "«LucLuongThamGia»";
                var valDonViPhoiHop = "«DonViPhoiHop»";
                var valThoiGianDuKien = "«ThoiGianDuKien»";
                var valDiaDiem = "«DiaDiem»";
                var valNguoiSoanThao = "«NguoiSoanThao»";

                docText = Regex.Replace(docText, "&", "&amp;");
                docText = Regex.Replace(docText, valSo, So);
                docText = Regex.Replace(docText, valDoiSo, DoiSo);
                docText = Regex.Replace(docText, valNgayThang, NgayThang);
                docText = Regex.Replace(docText, valNoiDungKH, NoiDungKH);
                docText = Regex.Replace(docText, valNoiDungYC, NoiDungYC);
                docText = Regex.Replace(docText, valPhuongPhapTienHanh, PhuongPhapTienHanh);
                docText = Regex.Replace(docText, valDuKienTinhHuong, DuKienTinhHuong);
                docText = Regex.Replace(docText, valPhuongTien, PhuongTien);
                docText = Regex.Replace(docText, valLucLuongThamGia, LucLuong);
                docText = Regex.Replace(docText, valDonViPhoiHop, DonViPhoiHop);
                docText = Regex.Replace(docText, valThoiGianDuKien, DuKien);
                docText = Regex.Replace(docText, valDiaDiem, DiaDiem);
                docText = Regex.Replace(docText, valNguoiSoanThao, NguoiSoanThao);
                return docText;
            }
            catch (Exception ex)
            {
                NLogLogger.PublishException(ex, ex.Message);
            }
            return string.Empty;
        }
        private bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(txtNo.Text))
            {
                XtraMessageBox.Show("Số kế hoạch không được để trống!", "Cảnh báo");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtContentPlan.Text))
            {
                XtraMessageBox.Show("Nội dung kế hoạch không được để trống!", "Cảnh báo");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtContentRequire.Text))
            {
                XtraMessageBox.Show("Nội dung yêu cầu không được để trống!", "Cảnh báo");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(cmbSolution.Text))
            {
                XtraMessageBox.Show("Phương pháp tiến hành không được để trống!", "Cảnh báo");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(cmbRisk.Text))
            {
                XtraMessageBox.Show("Dự kiến tình huống không được để trống!", "Cảnh báo");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(cmbResource.Text))
            {
                XtraMessageBox.Show("Phương tiện không được để trống!", "Cảnh báo");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(cmbUser.Text))
            {
                XtraMessageBox.Show("Lực lượng tham gia không được để trống!", "Cảnh báo");
                return false;
            }
            return true;
        }
        private void KillProcessWord()
        {
            try
            {
                Process[] pname = Process.GetProcessesByName("WINWORD");
                bool flag = false;
                if (pname.Length > 0)
                    flag = true;
                foreach (var item in pname)
                {
                    item.Kill();
                }
                if (flag)
                    Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                NLogLogger.PublishException(ex, ex.Message);
            }
        }
        private void KillProcessExcel()
        {
            try
            {
                Process[] pname = Process.GetProcessesByName("EXCEL");
                bool flag = false;
                if (pname.Length > 0)
                    flag = true;
                foreach (var item in pname)
                {
                    item.Kill();
                }
                if (flag)
                    Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                NLogLogger.PublishException(ex, ex.Message);
            }
        }
        private void btnAddSolution_Click(object sender, EventArgs e)
        {
            try
            {
                KillProcessExcel();
                var dt = new DataTable().GetDataImport("PhuongPhap");
                Constants.appDbContext.tblSolutions.RemoveRange(Constants.appDbContext.tblSolutions);
                Constants.appDbContext.SaveChanges();
                Constants.appDbContext.Database.ExecuteSqlCommand("TRUNCATE TABLE tblSolutions");
                Constants.appDbContext.SaveChanges();
                Constants.appDbContext.tblSolutions.AddRange(dt.AsEnumerable().Select(x => new tblSolution { Name = x[0].ToString() }));
                Constants.appDbContext.SaveChanges();
                RefreshForm();
            }
            catch (Exception ex)
            {
                NLogLogger.PublishException(ex, ex.Message);
            }
        }

        private void txtTemplate_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                KillProcessExcel();
                var data = File.ReadAllBytes($"{Directory.GetCurrentDirectory()}\\Template\\TemplateImport.xlsx");
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                SaveFile(data, $"{path}\\TemplateImport.xlsx").Wait();
            }
            catch (Exception ex)
            {
                NLogLogger.PublishException(ex, ex.Message);
            }
        }

        private void btnAddRisk_Click(object sender, EventArgs e)
        {
            try
            {
                KillProcessExcel();
                var dt = new DataTable().GetDataImport("TinhHuong");
                Constants.appDbContext.tblRisks.RemoveRange(Constants.appDbContext.tblRisks);
                Constants.appDbContext.SaveChanges();
                Constants.appDbContext.Database.ExecuteSqlCommand("TRUNCATE TABLE tblRisks");
                Constants.appDbContext.SaveChanges();
                Constants.appDbContext.tblRisks.AddRange(dt.AsEnumerable().Select(x => new tblRisk { Name = x[0].ToString() }));
                Constants.appDbContext.SaveChanges();
                RefreshForm();
            }
            catch (Exception ex)
            {
                NLogLogger.PublishException(ex, ex.Message);
            }
        }
        private void btnAddResource_Click(object sender, EventArgs e)
        {
            try
            {
                KillProcessExcel();
                var dt = new DataTable().GetDataImport("PhuongTien");
                Constants.appDbContext.tblResources.RemoveRange(Constants.appDbContext.tblResources);
                Constants.appDbContext.SaveChanges();
                Constants.appDbContext.Database.ExecuteSqlCommand("TRUNCATE TABLE tblResources");
                Constants.appDbContext.SaveChanges();
                Constants.appDbContext.tblResources.AddRange(dt.AsEnumerable().Select(x => new tblResource { Name = x[0].ToString() }));
                Constants.appDbContext.SaveChanges();
                RefreshForm();
            }
            catch (Exception ex)
            {
                NLogLogger.PublishException(ex, ex.Message);
            }
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                KillProcessExcel();
                var dt = new DataTable().GetDataImport("NhanSu");
                Constants.appDbContext.tblUsers.RemoveRange(Constants.appDbContext.tblUsers);
                Constants.appDbContext.SaveChanges();
                Constants.appDbContext.Database.ExecuteSqlCommand("TRUNCATE TABLE tblUsers");
                Constants.appDbContext.SaveChanges();
                Constants.appDbContext.tblUsers.AddRange(dt.AsEnumerable().Select(x => new tblUser { Name = x[0].ToString() }));
                Constants.appDbContext.SaveChanges();
                RefreshForm();
            }
            catch(Exception ex)
            {
                NLogLogger.PublishException(ex, ex.Message);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValid())
                    return;
                var createBy = Constants.entityAccount.UserName;
                var team = Constants.entityAccount.Team;
                saveFileDialog1.FileName = $"Kế hoạch {txtNo.Text.Trim()}_KH-Đ{team}.docx";
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    KillProcessWord();

                    var model = new tblPlan
                    {
                        KeHoachSo = txtNo.Text.Trim(),
                        PlanDate = dtCreate.Value,
                        PlanContent = txtContentPlan.Text.Trim(),
                        RequireContent = txtContentRequire.Text.Trim(),
                        SolutionKey = cmbSolution.EditValue.ToString(),
                        SolutionValue = cmbSolution.Text,
                        RiskKey = cmbRisk.EditValue.ToString(),
                        RiskValue = cmbRisk.Text,
                        ResourceKey = cmbResource.EditValue.ToString(),
                        ResourceValue = cmbResource.Text,
                        UserKey = cmbUser.EditValue.ToString(),
                        UserValue = cmbUser.Text,
                        Group = txtGroup.Text.Trim(),
                        ImpDate = dtPlan.Value,
                        District = txtDistrict.Text.Trim(),
                        Status = 0,
                        Status_Text = "Kế hoạch",
                        ModifiedDate = DateTime.Now,
                        CreatedBy = createBy,
                        Team = team,
                        DonViYeuCau = txtDonViYC.Text.Trim(),
                        LoaiYeuCau = cmbLoaiYeuCau.SelectedIndex
                    };
                    Constants.appDbContext.tblPlans.Add(model);
                    Constants.appDbContext.tblLogs.Add(new tblLog { Action = (int)enumAction.ADD, TableName = "tblPlan", Account = 0, CreatedTime = DateTime.Now, Object = JsonConvert.SerializeObject(model) });
                    Constants.appDbContext.SaveChanges();
                    var data = File.ReadAllBytes($"{Directory.GetCurrentDirectory()}\\Template\\TemplateKeHoach.docx");
                    var storageData = SearchAndReplace(data);
                    SaveFile(storageData, saveFileDialog1.FileName).Wait();
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                NLogLogger.PublishException(ex, ex.Message);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                //KillProcess();
                if ($"{Directory.GetCurrentDirectory()}\\Tmp\\Temp.docx".FileIsOpen())
                {
                    MessageBox.Show("Đóng file Temp.docx trước khi tiếp tục!");
                    return;
                }
                var data = File.ReadAllBytes($"{Directory.GetCurrentDirectory()}\\Template\\TemplateKeHoach.docx");
                var storageData = SearchAndReplace(data);
                SaveFile(storageData, $"{Directory.GetCurrentDirectory()}\\Tmp\\Temp.docx").Wait();
            }
            catch(Exception ex)
            {
                NLogLogger.PublishException(ex, ex.Message);
            }
        }
    }
}