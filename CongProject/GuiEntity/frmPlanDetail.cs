using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CongProject.Common;
using CongProject.Entities;
using Newtonsoft.Json;
using System.IO;
using System.Threading;
using System.Diagnostics;
using DocumentFormat.OpenXml.Packaging;
using System.Text.RegularExpressions;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CongProject.GuiEntity
{
    public partial class frmPlanDetail : XtraForm
    {
        private DateTime _dtFrom, _dtTo;
        public frmPlanDetail()
        {
            InitializeComponent();
            LoadData();
        }
        public frmPlanDetail(DateTime dtFrom, DateTime dtTo)
        {
            InitializeComponent();
            _dtFrom = dtFrom.AddDays(-1);
            _dtTo = dtTo.AddDays(1);
            LoadData();
        }
        private void LoadData()
        {
            LoadDataPlan();
        }
        private void LoadDataPlan()
        {
            grid.BeginUpdate();
            grid.DataSource = Constants.appDbContext.tblPlans.Where(x => (_dtFrom == DateTime.MinValue || x.PlanDate > _dtFrom) && (_dtTo == DateTime.MinValue || x.PlanDate < _dtTo)).ToDataTable<tblPlan>();
            grid.EndUpdate();
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

                    var bod = wordDoc.MainDocumentPart.Document.Body;
                    var tableProperties = bod.Descendants<TableProperties>();
                    foreach (var tProp in tableProperties)
                    {
                        if (tProp.TableCaption.Val.Equals("#TABLE#"))
                        {
                            var table = (Table)tProp.Parent;
                            table = InsertTableValue(table);
                        }
                        break;
                    }

                }
                return stream.ToArray();
            }
        }
        private Table InsertTableValue(Table table)
        {
            var reg = new Regex("[*'\"_&#^@]");
            var entities = from plan in Constants.appDbContext.tblPlans
                      join report in Constants.appDbContext.tblReports on plan.Id equals report.PlanId
                      where (_dtFrom == null || _dtFrom == DateTime.MinValue || plan.PlanDate >= _dtFrom) && ( _dtTo == null || _dtTo == DateTime.MinValue || plan.PlanDate <= _dtTo)
                      select new { plan.Group, plan.RiskValue, report.Result };
            if (!entities.Any())
                return table;
            var results = entities.GroupBy(s => new { s.Group, s.RiskValue })
                            .Select(g => new
                            {
                                Group = g.Key.Group,
                                RiskValue = g.Key.RiskValue,
                                Dem = g.Count(),
                                Result = g.Select(x => x.Result).Distinct().ToList()
                            });
            var index = 1;
            var lstOutput = new List<OutputModel>();
            foreach (var item in results.Select(x => x.Group).Distinct())
            {
                int phongNgua = 0, kiemTra = 0, cheAp = 0;
                var lstResult = new List<string>();
                foreach (var itemDetail in results)
                {
                    if(itemDetail.Group == item)
                    {
                        if (itemDetail.RiskValue.ToLower().Contains("ngừa"))
                        {
                            phongNgua += itemDetail.Dem;
                        }
                        else if (itemDetail.RiskValue.ToLower().Contains("kiểm tra")
                            || itemDetail.RiskValue.ToLower().Contains("phát hiện"))
                        {
                            kiemTra += itemDetail.Dem;
                        }
                        else
                            cheAp += itemDetail.Dem;
                        var lstExcept = itemDetail.Result.Except(lstResult);
                        if (lstExcept.Any())
                        {
                            lstResult.AddRange(lstExcept);
                        }
                    }
                }
                lstOutput.Add(new OutputModel
                {
                    STT = index++,
                    Team = item.ToString(),
                    PhongNgua = phongNgua,
                    KiemTra = kiemTra,
                    CheAp = cheAp,
                    KetQua = string.Join(",", lstResult.ToArray())
                }); 
            }

            foreach (var item in lstOutput)
            {
                var tr = new TableRow();
                tr.Append(new TableCell(
                    new ParagraphProperties(new Justification() { Val = JustificationValues.Center }),
                    new Paragraph(new Run(new Text(item.STT.ToString())))));
                tr.Append(new TableCell(
                    new ParagraphProperties(new Justification() { Val = JustificationValues.Left }),
                    new Paragraph(new Run(new Text(item.Team.ToString())))));
                tr.Append(new TableCell(
                    new ParagraphProperties(new Justification() { Val = JustificationValues.Center }),
                    new Paragraph(new Run(new Text(item.PhongNgua.To2Digit().ToString())))));
                tr.Append(new TableCell(
                    new ParagraphProperties(new Justification() { Val = JustificationValues.Center }),
                    new Paragraph(new Run(new Text(item.KiemTra.To2Digit().ToString())))));
                tr.Append(new TableCell(
                   new ParagraphProperties(new Justification() { Val = JustificationValues.Center }),
                   new Paragraph(new Run(new Text(item.CheAp.To2Digit().ToString())))));
                tr.Append(new TableCell(
                   new ParagraphProperties(new Justification() { Val = JustificationValues.Left }),
                   new Paragraph(new Run(new Text(item.KetQua)))));
                table.Append(tr);
            }
            ////Tong Tien
            //SummaryRow("Tổng tiền", data.Item2);
            ////VAT
            //SummaryRow("Thuế VAT", 0);
            ////Result
            //SummaryRow("Tổng tiền đã bao gồm VAT", data.Item2);
            return table;

            //void SummaryRow(string fieldName, long val)
            //{
            //    var cellFirstProperty = new TableCellProperties();
            //    cellFirstProperty.Append(new HorizontalMerge()
            //    {
            //        Val = MergedCellValues.Restart
            //    });
            //    var cellNextProperty = new TableCellProperties();
            //    cellNextProperty.Append(new HorizontalMerge()
            //    {
            //        Val = MergedCellValues.Continue
            //    });
            //    var cellLastProperty = new TableCellProperties();
            //    cellLastProperty.Append(new HorizontalMerge()
            //    {
            //        Val = MergedCellValues.Continue
            //    });
            //    //create a run for the bold text
            //    var run1 = new Run();
            //    run1.Append(new Text(fieldName));
            //    //create runproperties and append a "Bold" to them
            //    var run1Properties = new RunProperties();
            //    run1Properties.Append(new Bold());
            //    //set the first runs RunProperties to the RunProperties containing the bold
            //    run1.RunProperties = run1Properties;

            //    var tableCell1 = new TableCell(new Paragraph(run1));
            //    tableCell1.Append(cellFirstProperty);
            //    var tableCell2 = new TableCell(new Paragraph(new Run(new Text())));
            //    tableCell2.Append(cellNextProperty);
            //    var tableCell3 = new TableCell(new Paragraph(new Run(new Text())));
            //    tableCell3.Append(cellLastProperty);

            //    var tr = new TableRow();
            //    tr.Append(tableCell1);
            //    tr.Append(tableCell2);
            //    tr.Append(tableCell3);
            //    tr.Append(new TableCell(new ParagraphProperties(new Justification() { Val = JustificationValues.Right }),
            //        new Paragraph(new Run(new Text(val.ToString("N0", CultureInfo.InvariantCulture))))));
            //    table.Append(tr);
            //}
        }
        private string ReplaceParameter(string docText)
        {
            var TuNgay = _dtFrom.ToString("dd/MM/yyyy");
            var DenNgay = _dtTo.ToString("dd/MM/yyyy");
            var valTuNgay = "«TuNgay»";
            var valDenNgay = "«DenNgay»";

            docText = Regex.Replace(docText, "&", "&amp;");
            docText = Regex.Replace(docText, valTuNgay, TuNgay);
            docText = Regex.Replace(docText, valDenNgay, DenNgay);
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
        private void mniDetail_Click(object sender, EventArgs e)
        {
            var arrRow = gridView1.GetSelectedRows();
            if (!arrRow.Any())
                return;
            var planId = int.Parse(gridView1.GetRowCellValue(arrRow[0], "Id").ToString());
            if(new frmPlanEdit(planId).ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void mniDelete_Click(object sender, EventArgs e)
        {
            var arrRow = gridView1.GetSelectedRows();
            if (!arrRow.Any())
                return;
            var KeHoachSo = gridView1.GetRowCellValue(arrRow[0], "KeHoachSo");

            if (MessageBox.Show($"Xoá kế hoạch '{KeHoachSo}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var planId = int.Parse(gridView1.GetRowCellValue(arrRow[0], "Id").ToString());
                var entity = Constants.appDbContext.tblPlans.Find(planId);
                var jsonObj = JsonConvert.SerializeObject(entity);
                Constants.appDbContext.tblLogs.Add(new tblLog { Action = (int)enumAction.DELETE, TableName = "tblPlan", Account = 0, CreatedTime = DateTime.Now, Object = jsonObj });
                Constants.appDbContext.tblPlans.Remove(entity);
                Constants.appDbContext.SaveChanges();
                MessageBox.Show("Đã lưu dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var arrRow = gridView1.GetSelectedRows();
            if (!arrRow.Any())
                return;
            var planId = int.Parse(gridView1.GetRowCellValue(arrRow[0], "Id").ToString());
            if (new frmPlanEdit(planId).ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void mnuReport_Click(object sender, EventArgs e)
        {
            var arrRow = gridView1.GetSelectedRows();
            if (!arrRow.Any())
                return;
            var planId = int.Parse(gridView1.GetRowCellValue(arrRow[0], "Id").ToString());
            if(new frmReport(DateTime.Now.AddYears(-1), DateTime.Now.AddDays(7), planId).ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0)
                return;
            var status = int.Parse(gridView1.GetRowCellValue(e.FocusedRowHandle, "Status").ToString());
            mnuReport.Visible = status == 0;
        }

        private void mnuExport_Click(object sender, EventArgs e)
        {
            //KillProcess();
            if ($"{Directory.GetCurrentDirectory()}\\Tmp\\Temp.docx".FileIsOpen())
            {
                MessageBox.Show("Đóng file Temp.docx trước khi tiếp tục!");
                return;
            }
            var data = File.ReadAllBytes($"{Directory.GetCurrentDirectory()}\\Template\\TemplateReport.docx");
            var storageData = SearchAndReplace(data);
            SaveFile(storageData, $"{Directory.GetCurrentDirectory()}\\Tmp\\Temp.docx").Wait();
        }

        private void mnu_Opening(object sender, CancelEventArgs e)
        {
            var arrRow = gridView1.GetSelectedRows();
            if (arrRow.Count() == 0)
                e.Cancel = true;
        }
    }
    public class OutputModel
    {
        public int STT { get; set; }
        public string Team { get; set; }
        public int PhongNgua { get; set; }
        public int KiemTra { get; set; }
        public int CheAp { get; set; }
        public string KetQua { get; set; }
    }
}