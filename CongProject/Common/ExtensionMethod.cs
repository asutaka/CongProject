using CongProject.Model;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using ExcelDataReader;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace CongProject.Common
{
    public static class ExtensionMethod
    {
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }
        public static DataTable ToDataTable<T>(this IQueryable items)
        {
            Type type = typeof(T);

            var props = TypeDescriptor.GetProperties(type)
                                      .Cast<PropertyDescriptor>()
                                      .Where(propertyInfo => propertyInfo.PropertyType.Namespace.Equals("System"))
                                      .Where(propertyInfo => propertyInfo.IsReadOnly == false)
                                      .ToArray();

            var table = new DataTable();

            foreach (var propertyInfo in props)
            {
                table.Columns.Add(propertyInfo.Name, Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType);
            }

            foreach (var item in items)
            {
                table.Rows.Add(props.Select(property => property.GetValue(item)).ToArray());
            }

            return table;
        }
        public static void InitJson(this int val)
        {
            string path = $"{Directory.GetCurrentDirectory()}\\user.json";
            var isExist = File.Exists(path);
            if (!isExist)
            {
                var model = new UserConfigModel
                {
                    Connection = new ConnectionModel
                    {
                        IP = string.Empty,
                        Database = string.Empty,
                        UserId = string.Empty,
                        Password = string.Empty
                    },
                    Login = new LoginModel
                    {
                        UserName = string.Empty,
                        Password = string.Empty
                    },
                };
                string json = JsonConvert.SerializeObject(model);

                //write string to file
                File.WriteAllText(path, json);
            }
        }
        public static UserConfigModel LoadJson(this int val)
        {
            string path = $"{Directory.GetCurrentDirectory()}\\user.json";
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                var result = JsonConvert.DeserializeObject<UserConfigModel>(json);
                return result;
            }
        }
        public static void UpdateJson(this UserConfigModel _model)
        {
            string path = $"{Directory.GetCurrentDirectory()}\\user.json";
            string json = JsonConvert.SerializeObject(_model);

            //write string to file
            File.WriteAllText(path, json);
        }
        public static string ToConnectionString(this ConnectionModel model)
        {
            string result = $"Server={model.IP};Database={model.Database};User Id={model.UserId};Password={StringCipher.Decrypt(model.Password, Constants.SecretKey)};;MultipleActiveResultSets=True;";
            return result;
        }
        public static int ToInt(this string str)
        {
            var result = 0;
            if(!string.IsNullOrWhiteSpace(str))
                result = int.Parse(str);
            return result;
        }
        public static bool ToBoolean(this string str)
        {
            var result = false;
            if (!string.IsNullOrWhiteSpace(str))
            {
                if (str.ToLower().Equals("false"))
                    result = false;
                else if (str.ToLower().Equals("true"))
                    result = true;
                else
                    result = int.Parse(str) > 0;
            }
            return result;
        }
        public static string To2Digit(this int val)
        {
            if (val < 10)
                return $"0{val}";
            return val.ToString();
        }
        public static DataTable GetDataImport(this DataTable dt, string sheetName)
        {
            string filePath = string.Empty;
            OpenFileDialog file = new OpenFileDialog(); //open dialog to choose file  
            if (file.ShowDialog() == DialogResult.OK) //if there is a file choosen by the user  
            {
                filePath = file.FileName; //get the path of the file  

                FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
                IExcelDataReader excelReader;

                //1. Reading Excel file
                if (Path.GetExtension(filePath).ToUpper() == ".XLS")
                {
                    //1.1 Reading from a binary Excel file ('97-2003 format; *.xls)
                    excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
                }
                else
                {
                    //1.2 Reading from a OpenXml Excel file (2007 format; *.xlsx)
                    excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                }
                //2. DataSet - The result of each spreadsheet will be created in the result.Tables
                DataSet result = excelReader.AsDataSet();
                foreach (DataTable item in result.Tables)
                {
                    if (item.TableName == sheetName)
                    {
                        dt = item;
                        break;
                    }
                }
                stream.Close();
                return dt;
            }
            return dt;
        }

        public static (string, string) GetCustomDisplay(this object sender)
        {
            var sb = new StringBuilder();
            var sb2 = new StringBuilder();
            GridCheckMarksSelection gridCheckMark = sender is GridLookUpEdit ? (sender as GridLookUpEdit).Properties.Tag as GridCheckMarksSelection :
                                                                                    (sender as RepositoryItemGridLookUpEdit).Tag as GridCheckMarksSelection;

            if (gridCheckMark == null) return(null, null);
            foreach (DataRowView f in gridCheckMark.Selection)
            {
                if (sb.ToString().Length > 0) { sb.Append(","); sb2.Append(", "); }
                DataRow row = ((DataRowView)f).Row;

                sb.Append(row[0]);
                sb2.Append(row[1]);
            }
            return (sb.ToString(), sb2.ToString());
        }

        public static string GetSelectionChanged(this object sender)
        {
            StringBuilder sb = new StringBuilder();
            foreach (DataRowView f in (sender as GridCheckMarksSelection).Selection)
            {
                if (sb.ToString().Length > 0) { sb.Append(", "); }
                DataRow row = ((DataRowView)f).Row;
                sb.Append(row[1]);
            }
            return sb.ToString();
        }

        public static DataTable GetDataTable(this GridView view)
        {
            DataTable dt = new DataTable();
            foreach (GridColumn c in view.Columns)
                dt.Columns.Add(c.FieldName, c.ColumnType);
            for (int r = 0; r < view.RowCount; r++)
            {
                object[] rowValues = new object[dt.Columns.Count];
                for (int c = 0; c < dt.Columns.Count; c++)
                    rowValues[c] = view.GetRowCellValue(r, dt.Columns[c].ColumnName);
                dt.Rows.Add(rowValues);
            }
            return dt;
        }
        public static string ToShortName(this string val)
        {
            if (string.IsNullOrWhiteSpace(val) || !val.Contains(" "))
                return val;
            var lstSplit = val.Split(' ');
            var lastName = lstSplit.ElementAt(lstSplit.Count() - 1);
            var strOutput = new StringBuilder();
            for (int i = 0; i < lstSplit.Count() - 1; i++)
            {
                strOutput.Append(lstSplit.ElementAt(i).ToUpper().First().ToString()+'.');
            }
            strOutput.Append(lastName);
            return strOutput.ToString();
        }

        public static bool FileIsOpen(this string path)
        {
            FileStream a = null;

            try
            {
                a = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.None);
                return false;
            }
            catch (IOException ex)
            {
                return true;
            }

            finally
            {
                if (a != null)
                {
                    a.Close();
                    a.Dispose();
                }
            }
        }
    }
}
