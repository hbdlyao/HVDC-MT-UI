using cn.csg.dpcp.dal.mc;
using cn.csg.dpcp.model.dataset;
using cn.csg.dpcp.model.vo.mc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Data = System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Reflection;
using cn.csg.dpcp.common;
using System.Collections;

namespace cn.csg.dpcp.ui.mc
{
    public partial class MCResultUI : DpcpBaseForm
    {
        //  查询数据缓存
        private Data.DataTable cacheDT = new Data.DataTable();
        // 保存表格列name
        private IList<DataGridViewColumn> columnList = new List<DataGridViewColumn>();

        private const string  SheetNameSeparator = "-";

        public MCResultUI()
        {
            InitializeComponent();
            Name = Constants.MC_CResult;
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                columnList.Add(dgv.Columns[i]);
            }
        }

        private void dataGridViewX1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y, dgv.RowHeadersWidth - 4, e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dgv.RowHeadersDefaultCellStyle.Font,
                rectangle, dgv.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void MCCalcResultUI_Load(object sender, EventArgs e)
        {
            lstOrder.Items.Clear();
            lstStation.Items.Clear();
            // 加载工况
            CMCDeviceDataSet.Result.VoList = new List<CMCResultVo>();
            CMCResultDAL dal = new CMCResultDAL();
            if (CMCDeviceDataSet.Result.VoList == null || CMCDeviceDataSet.Result.VoList.Count < 1)
            {
                CMCDeviceDataSet.Result.VoList = new List<CMCResultVo>();
                dal.QueryList(CMCDeviceDataSet.Result.tableName, CMCDeviceDataSet.Result.VoList);
            }
            if (CMCDeviceDataSet.Result.VoList.Count < 1)
            {
                MessageBox.Show("未查询到计算数据");
                return;
            }
            loadOrder();
        }

        // 加载工况列表
        private void loadOrder()
        {
            foreach (CMCResultVo vo in CMCDeviceDataSet.Result.VoList)
            {
                if (!lstOrder.Items.Contains(vo.CaseID))
                {
                    lstOrder.Items.Add(vo.CaseID);
                }
            }
        }

        // 根据工况选择加载站名列表
        private void lstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstStation.Items.Clear();
            string caseId = lstOrder.SelectedItem.ToString();
            foreach (CMCResultVo vo in CMCDeviceDataSet.Result.VoList)
            {
                if (vo.CaseID.Equals(caseId))
                {
                    lstStation.Items.Add(vo.StationName);
                }
            }
        }

        // 站选择后加载数据
        private void lstStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv.Columns.Clear();
            string caseId = lstOrder.SelectedItem.ToString();
            string station = lstStation.SelectedItem.ToString();
            CMCResultDAL dal = new CMCResultDAL();
            Data.DataTable dt = dal.QueryResult(caseId, station);
            dgv.DataSource = dt;
            // 将保存的列明重新回填表格
            foreach (DataGridViewColumn col1 in columnList)
            {
                foreach (DataGridViewColumn col2 in dgv.Columns)
                {
                    if (col1.HeaderText.Equals(col2.HeaderText))
                    {
                        col2.Name = col1.Name;
                    }
                }
            }

            // 从缓存中取，取不到则去数据库查
            //Data.DataRow[] rows = cacheDT.Select("CaseID='" + caseId + "' and StationName='" + station + "'");
            //if (rows == null || rows.Length == 0)
            //{
            //    // 第一次查询加入缓存
            //    CMCResultDAL dal = new CMCResultDAL();
            //    Data.DataTable dt = dal.QueryResult(caseId, station);
            //    dataGridViewX1.DataSource = dt;
            //    cacheDT.Merge(dt);
            //}
            //else
            //{
            //    // 读缓存
            //    Data.DataTable dt = new Data.DataTable();
            //    foreach (Data.DataRow row in rows)
            //    {
            //        dt.Rows.Add(row);
            //    }
            //    dataGridViewX1.DataSource = dt;
            //}
        }

        // 导出所有工况下的所有站
        private void btnExportAll_Click(object sender, EventArgs e)
        {
            export(null, null);
        }

        // 获取要导出页签集合
        private IList<string> getExportSheetsName(IList<CMCResultVo> voList)
        {
            IList<string> sheetsList = new List<string>();
            foreach (CMCResultVo vo in voList)
            {
                string sheetName = vo.CaseID + SheetNameSeparator + vo.StationName;
                if (!sheetsList.Contains(sheetName))
                {
                    sheetsList.Add(sheetName);
                }
            }
            return sheetsList;
        }

        // 填充excel中的页签数据
        private void fillSheetData(Excel._Worksheet sheet, IList<CMCResultVo> voList)
        {
            fillSheetHead(sheet);
            IList<CMCResultVo> exprotList = new List<CMCResultVo>();
            // 反射对象所有属性
            Type type = typeof(CMCResultVo);
            PropertyInfo[] ps = type.GetProperties();

            // 从第二行开始填值
            int rowIndex = 2;
            //int colIndex = 1;
            foreach (CMCResultVo vo in voList)
            {
                // 根据工况和站名的页签名过滤出数据
                if (!(vo.CaseID + SheetNameSeparator + vo.StationName).Equals(sheet.Name))
                {
                    continue;
                }
                // UI中表格字段名与对象属性名一致
                // 用反射对象赋值
                foreach (PropertyInfo p in ps)
                {
                    object obj = p.GetValue(vo, null);
                    if (obj == null)
                    {
                        continue;
                    }
                    foreach (DataGridViewColumn col in columnList)
                    {
                        // 对象与属性属性名匹配
                        if (col.Name.Equals(p.Name))
                        {
                            sheet.Cells[rowIndex, col.Index + 1] = obj.ToString();
                        }
                    }
                }
                rowIndex++;
                
            }

        }

        // 填充页签中的表头
        private void fillSheetHead(Excel._Worksheet sheet)
        {
            for (int i = 0; i < columnList.Count - 1; i++)
            {
                sheet.Cells[1, i + 1] = "'" + columnList[i].HeaderText;
                ((Excel.Range)sheet.Rows[1, Missing.Value]).Interior.Color = Color.LightYellow ;
                
                
            }
        }

        // 导出选择工况包含当前工况下的所有站
        private void btnExportSelected_Click(object sender, EventArgs e)
        {
            if (lstOrder.SelectedItem == null)
            {
                MessageBox.Show("请选择工况");
                return;
            }
            if (lstStation.SelectedItem == null)
            {
                MessageBox.Show("请选择站名");
                return;
            }
            export(lstOrder.SelectedItem.ToString(), lstStation.SelectedItem.ToString());
        }

        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="caseId">工况</param>
        /// <param name="station">站名</param>
        private void export(string caseId, string station)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            //dlg.CheckFileExists = true;
            //默然文件后缀      
            dlg.DefaultExt = "xlsx";
            //文件后缀列表      
            dlg.Filter = "EXCEL文件(*.XLSX)|*.xlsx ";
            //默然路径是系统当前路径      
            dlg.InitialDirectory = Directory.GetCurrentDirectory();
            //打开保存对话框      
            if (dlg.ShowDialog() == DialogResult.Cancel) return;
            //返回文件路径      
            string fileNameString = dlg.FileName;
            //验证strFileName是否为空或值无效
            if (fileNameString == null || fileNameString.Trim().Equals(string.Empty))
            { return; }

            Excel.Application excel = new Excel.Application();
            if (excel == null)
            {
                MessageBox.Show("未能创建Excel\n可能未安装Offic");
                return;
            }
            excel.Visible = false;
            excel.DisplayAlerts = false;
            excel.Caption = "主回路计算数据";
            Excel.Workbooks wb = excel.Workbooks;
            Excel._Workbook book = wb.Add(true);
            //book.Sheets.Delete();

            CMCResultDAL dal = new CMCResultDAL();
            IList<CMCResultVo> voList = dal.QueryExportList(caseId, station);

            // 导出的sheet名集合
            IList<string> exportSheetsName = getExportSheetsName(voList);
            book.Sheets.Add(Type.Missing, Type.Missing, exportSheetsName.Count, Type.Missing);
            Excel.Sheets sheets = book.Sheets;

            int index = 0;
            IEnumerator ie = sheets.GetEnumerator();
            while (ie.MoveNext())
            {
                Excel.Worksheet sheet = ie.Current as Excel.Worksheet;
                if (index == exportSheetsName.Count)
                {
                    sheet.Delete();
                    break;
                }
                sheet.Name = exportSheetsName[index];
                fillSheetData(sheet, voList);
                index++;
            }

            book.SaveAs(fileNameString, 51, Type.Missing, Missing.Value, Missing.Value,
                Missing.Value, Excel.XlSaveAsAccessMode.xlShared, Missing.Value, Missing.Value, Missing.Value,
                Missing.Value, Missing.Value);

            book.Close();
            wb.Close();
            excel.Quit();
            MessageBox.Show("导出成功");
        }
    }
}
