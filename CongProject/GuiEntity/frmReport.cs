using System;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using CongProject.Common;
using CongProject.Entities;
using System.Linq;
using System.Diagnostics;
using System.Threading;
using System.IO;
using DocumentFormat.OpenXml.Packaging;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace CongProject.GuiEntity
{
    public partial class frmReport : XtraForm
    {
        private tblPermission _per_btnSave, _per_btnCancel, _per_btnView;
        private string _formCode = "F12";
        private DateTime _dtFrom, _dtTo;
        private int _planId;
        public frmReport(DateTime dtFrom, DateTime dtTo, int planId = -1)
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Word Doc (*.docx)|*.docx";
            _dtFrom = dtFrom.AddDays(-1);
            _dtTo = dtTo.AddDays(1);
            _planId = planId;
            LoadData();
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
        private void LoadData()
        {
            LoadDataPlan();
        }
        private void LoadDataPlan()
        {
            cmbKeHoachSo.Properties.DataSource = Constants.appDbContext.tblPlans.Where(x => x.PlanDate > _dtFrom && x.PlanDate < _dtTo && x.Status == 0).ToDataTable<tblPlan>();
            cmbKeHoachSo.Properties.ValueMember = "Id";
            cmbKeHoachSo.Properties.DisplayMember = "KeHoachSo";
            cmbKeHoachSo.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            if(_planId >= 0)
            {
                cmbKeHoachSo.EditValue = _planId;
            }
        }
        private bool IsValid()
        {
            if (cmbKeHoachSo.EditValue == null
                || string.IsNullOrWhiteSpace(cmbKeHoachSo.Text))
            {
                XtraMessageBox.Show("Chưa chọn kế hoạch báo cáo!", "Cảnh báo");
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
            var KeHoachSo = cmbKeHoachSo.Text;
            var DoiSo = $"{Constants.entityAccount.Team.ToString()}";
            var NgayKH = $"{lblNgayLapKeHoach.Text}";
            var DonviYC = $"{lblDonViYC.Text}";
            var NgayThang = $"ngày {dt.Day.To2Digit()} tháng {dt.Month.To2Digit()} năm {dt.Year}";
            var PhuongPhapTienHanh = $"- {txtSolution.Text.Replace("\n", "<w:br/>- ")}";
            var LucLuong = $"- {txtUser.Text.Replace("\n", "<w:br/>- ")}";
            var KetQuaThucHien = $"- {txtResult.Text.Replace("\n", "<w:br/>- ")}";
            var ThoiGianDuKien = txtDistrict.Text.Trim();
            var DeXuat = txtDeXuat.Text.Trim();
            if (string.IsNullOrWhiteSpace(DeXuat))
                DeXuat = "Các thiết bị trên được sửa chữa, thay thế phải qua kiểm tra an toàn an ninh thông tin trước khi đưa vào sử dụng. chịu trách nhiệm bảo quản, sử dụng dữ liệu trên các thiết bị nêu trên theo đúng quy định về bảo vệ bí mật nhà nước. Đội kính báo cáo và xin ý kiến chỉ đạo của Đồng chí./.";

            var valDoiSo = "«DoiSo»";
            var valNgayKH = "«NgayKH»";
            var valDonviYC = "«DonviYC»";
            var valKeHoachSo = "«KeHoachSo»";
            var valNgayThang = "«NgayThang»";
            var valLucLuongThamGia = "«LucLuongThamGia»";
            var valThoiGianDuKien = "«ThoiGianThucHien»";
            var valPhuongPhapTienHanh = "«PhuongPhapTienHanh»";
            var valKetQuaThucHien = "«KetQuaThucHien»";
            var valDeXuat = "«DeXuat»";

            docText = Regex.Replace(docText, "&", "&amp;");
            docText = Regex.Replace(docText, valKeHoachSo, KeHoachSo);
            docText = Regex.Replace(docText, valNgayKH, NgayKH);
            docText = Regex.Replace(docText, valDonviYC, DonviYC);
            docText = Regex.Replace(docText, valDoiSo, DoiSo);
            docText = Regex.Replace(docText, valNgayThang, NgayThang);
            docText = Regex.Replace(docText, valPhuongPhapTienHanh, PhuongPhapTienHanh);
            docText = Regex.Replace(docText, valKetQuaThucHien, KetQuaThucHien);
            docText = Regex.Replace(docText, valLucLuongThamGia, LucLuong);
            docText = Regex.Replace(docText, valThoiGianDuKien, ThoiGianDuKien);
            docText = Regex.Replace(docText, valDeXuat, DeXuat);
            return docText;
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
        private void cmbKeHoachSo_EditValueChanged(object sender, EventArgs e)
        {
            if(cmbKeHoachSo.EditValue != null)
            {
                var entity = Constants.appDbContext.tblPlans.FirstOrDefault(x => x.KeHoachSo == cmbKeHoachSo.Text);
                var dateFormat = entity.PlanDate.Minute == 0 ? $"{entity.PlanDate.Hour}h, ngày {entity.PlanDate.ToString("dd/MM/yyyy")}, tại {entity.District}"
                                                                : $"{entity.PlanDate.Hour}h {entity.PlanDate.Minute}, ngày {entity.PlanDate.ToString("dd/MM/yyyy")}, tại {entity.District}";
                txtDistrict.Text = dateFormat;
                txtUser.Text = entity.UserValue.Replace(", ","\n");
                txtSolution.Text = string.Empty;//entity.SolutionValue.Replace(", ","\n");
                txtResult.Text = string.Empty;
                lblNgayLapKeHoach.Text = entity.PlanDate.ToString("dd-MM-yyyy");
                lblDonViYC.Text = entity.DonViYeuCau;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValid())
                return;
            saveFileDialog1.FileName = $"Báo cáo kế hoạch {cmbKeHoachSo.Text}_KH-Đ{Constants.entityAccount.Team}";
            if(saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                KillProcess();
                var entity = Constants.appDbContext.tblPlans.Find(int.Parse(cmbKeHoachSo.EditValue.ToString()));
                entity.Status = (int)enumPlanStatus.COMPLETE;
                entity.Status_Text = "Hoàn thành";
                var model = new tblReport
                {
                    PlanId = entity.Id,
                    KeHoachSo = entity.KeHoachSo,
                    District = txtDistrict.Text.Trim(),
                    SolutionValue = txtSolution.Text.Trim(),
                    UserValue = txtUser.Text.Trim(),
                    Result = txtResult.Text.Trim(),
                    ReportDate = DateTime.Now,
                    DeXuat = txtDeXuat.Text.Trim()
                };
                Constants.appDbContext.tblReports.Add(model);
                Constants.appDbContext.tblLogs.Add(new tblLog { Action = (int)enumAction.ADD, TableName = "tblReport", Account = 0, CreatedTime = DateTime.Now, Object = JsonConvert.SerializeObject(model) });
                Constants.appDbContext.SaveChanges();
                var data = File.ReadAllBytes($"{Directory.GetCurrentDirectory()}\\Template\\TemplateKetQua.docx");
                var storageData = SearchAndReplace(data);
                SaveFile(storageData, saveFileDialog1.FileName).Wait();
                DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            //KillProcess();
            if ($"{Directory.GetCurrentDirectory()}\\Tmp\\Temp.docx".FileIsOpen())
            {
                MessageBox.Show("Đóng file Temp.docx trước khi tiếp tục!");
                return;
            }
            var data = File.ReadAllBytes($"{Directory.GetCurrentDirectory()}\\Template\\TemplateKetQua.docx");
            var storageData = SearchAndReplace(data);
            SaveFile(storageData, $"{Directory.GetCurrentDirectory()}\\Tmp\\Temp.docx").Wait();
        }
       
    }
}