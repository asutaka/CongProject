using System;
using DevExpress.XtraEditors;
using CongProject.Common;
using System.IO;
using DocumentFormat.OpenXml.Packaging;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Threading;
using CongProject.Entities;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Linq;

namespace CongProject.GuiEntity
{
    public partial class frmPlanEdit : XtraForm
    {
        private tblPermission _per_btnSave, _per_btnCancel, _per_btnView;
        private string _formCode = "F11";
        private int _id;
        public frmPlanEdit(int id)
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

            var component_btnView = Constants.appDbContext.tblComponents.FirstOrDefault(x => x.FormCode == _formCode && x.Name == "btnView");
            if (component_btnView != null)
            {
                _per_btnView = Constants.appDbContext.tblPermissions.FirstOrDefault(x => x.RoleId == Constants.entityAccount.RoleId & x.ComponentId == component_btnView.Id);
                if (_per_btnView != null)
                    btnView.Visible = _per_btnView.Read;
            }
        }
        private void InitData()
        {
            LoadData();
            var entity = Constants.appDbContext.tblPlans.Find(_id);
            if(entity == null)
            {
                MessageBox.Show("Bản ghi không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            txtNo.Text = entity.KeHoachSo;
            dtCreate.Value = entity.PlanDate;
            txtContentPlan.Text = entity.PlanContent;
            txtContentRequire.Text = entity.RequireContent;

            txtGroup.Text = entity.Group;
            dtPlan.Value = entity.ImpDate;
            txtDistrict.Text = entity.District;
            cmbSolution.SetEditValue(entity.SolutionKey);
            cmbRisk.SetEditValue(entity.RiskKey);
            cmbResource.SetEditValue(entity.ResourceKey);
            cmbUser.SetEditValue(entity.UserKey);
            txtDonViYC.Text = entity.DonViYeuCau;
            cmbLoaiYeuCau.SelectedIndex = entity.LoaiYeuCau;
        }
        private void LoadData()
        {
            LoadDataSolution();
            LoadDataRisk();
            LoadDataResource();
            LoadDataUser();
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
            using (MemoryStream stream = new MemoryStream())
            {
                await stream.WriteAsync(data, 0, data.Length);
                File.WriteAllBytes(fileName, stream.ToArray());
            }
            Process.Start(fileName);
        }
        private byte[] SearchAndReplace(byte[] byteArray)
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
        private string ReplaceParameter(string docText)
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
        private void KillProcess()
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValid())
                return;
            saveFileDialog1.FileName = $"Kế hoạch {txtNo.Text.Trim()}_KH-Đ{Constants.entityAccount.Team}.docx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                KillProcess();
                var createBy = Constants.entityAccount.UserName;
                var team = Constants.entityAccount.Team;
                var entity = Constants.appDbContext.tblPlans.Find(_id);
                entity.KeHoachSo = txtNo.Text.Trim();
                entity.PlanDate = dtCreate.Value;
                entity.PlanContent = txtContentPlan.Text.Trim();
                entity.RequireContent = txtContentRequire.Text.Trim();
                entity.SolutionKey = cmbSolution.EditValue.ToString();
                entity.SolutionValue = cmbSolution.Text;
                entity.RiskKey = cmbRisk.EditValue.ToString();
                entity.RiskValue = cmbRisk.Text;
                entity.ResourceKey = cmbResource.EditValue.ToString();
                entity.ResourceValue = cmbResource.Text;
                entity.UserKey = cmbUser.EditValue.ToString();
                entity.UserValue = cmbUser.Text;
                entity.Group = txtGroup.Text.Trim();
                entity.ImpDate = dtPlan.Value;
                entity.District = txtDistrict.Text.Trim();
                entity.Status = (int)enumPlanStatus.PLAN;
                entity.Status_Text = "Kế hoạch";
                entity.ModifiedDate = DateTime.Now;
                entity.CreatedBy = createBy;
                entity.Team = team;
                entity.DonViYeuCau = txtDonViYC.Text.Trim();
                entity.LoaiYeuCau = cmbLoaiYeuCau.SelectedIndex;
                Constants.appDbContext.tblLogs.Add(new tblLog { Action = (int)enumAction.EDIT, TableName = "tblPlan", Account = 0, CreatedTime = DateTime.Now, Object = JsonConvert.SerializeObject(entity) });
                Constants.appDbContext.SaveChanges();
                var data = File.ReadAllBytes($"{Directory.GetCurrentDirectory()}\\Template\\TemplateKeHoach.docx");
                var storageData = SearchAndReplace(data);
                SaveFile(storageData, saveFileDialog1.FileName).Wait();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            KillProcess();
            var data = File.ReadAllBytes($"{Directory.GetCurrentDirectory()}\\Template\\TemplateKeHoach.docx");
            var storageData = SearchAndReplace(data);
            SaveFile(storageData, $"{Directory.GetCurrentDirectory()}\\Tmp\\Temp.docx").Wait();
        }
    }
}