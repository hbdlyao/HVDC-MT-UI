using System;
using System.Collections.Generic;
using Data = System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using cn.csg.dpcp.common;
using Hvdc.MT.mc.App;
using Hvdc.MT.mc.Solve;
using Hvdc.MT.HvdcCommon;
using System.IO;
using System.Collections;
using System.Reflection;
using System.Drawing;

namespace cn.csg.dpcp.ui.u3p
{
    public partial class U3pDataFromuMcUI : CfmBaseFrom
    {
        CmcResult pResult;
        CmcCasePack CasePack;
        CmcCasePack StationPack;
        //CmcCasePack PdSizePack;


        IDictionary<string, CmcCase> pCaseMap;
        IDictionary<string, CmcCase> pStationMap;
        //IDictionary<string, CmcCase> pPdSizeMap;

        IList<RecResultData> pDataList;

        private string excelFileName;

        //  查询数据缓存
        private Data.DataTable cacheDT = new Data.DataTable();
        // 保存表格列name
        private IList<DataGridViewColumn> columnList = new List<DataGridViewColumn>();

        private const string  SheetNameSeparator = "-";

        public U3pDataFromuMcUI()
        {
            InitializeComponent();
            Name = Constants.CxbUIDataFromU3p;
            //for (int i = 0; i < dgv.Columns.Count; i++)
            //{
            //    columnList.Add(dgv.Columns[i]);
            //}
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
            lstCase.Items.Clear();
            lstStation.Items.Clear();
        }


        // 站选择后加载数据
        private void lstStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv.Rows.Clear();

            string vStationId = lstStation.SelectedItem.ToString();

            CmcCase vCase = pStationMap[vStationId];

            pDataList = vCase.DataList();

            DataToGrid();
        }
  
        // 导出所有工况下的所有站
        private void btnExportAll_Click(object sender, EventArgs e)
        {
            //export(null, null);
        }

        //private void invkoDataToSheet(Excel._Worksheet sheet, IList<RecResultData> vDataList)
        //{
        //    fillSheetHead(sheet);
        //    Type type = typeof(RecResultData);
        //    type = new RecResultData().GetType();
        //    PropertyInfo[] ps = type.GetProperties();
        //    int rowIndex = 2;
        //    foreach (RecResultData vData in pDataList)
        //    {
        //        // UI中表格字段名与对象属性名一致
        //        // 用反射对象赋值
        //        foreach (PropertyInfo p in ps)
        //        {
        //            object obj = p.GetValue(vData, null);
        //            if (obj == null)
        //            {
        //                continue;
        //            }
        //            foreach (DataGridViewColumn col in columnList)
        //            {
        //                // 对象与属性属性名匹配
        //                if (col.Name.Equals(p.Name))
        //                {
        //                    sheet.Cells[rowIndex, col.Index + 1] = obj.ToString();
        //                }
        //            }
        //        }
        //        rowIndex++;
        //    }
        //}

        // 获取要导出页签集合

        // 填充excel中的页签数据
        private void DataToSheet(Excel._Worksheet sheet, IList<RecResultData> vDataList)
        {
            fillSheetHead(sheet);
            // 反射对象所有属性
            int rowIndex = 2;
            int colIndex = 1;
            foreach (RecResultData vData in pDataList)
            {
                sheet.Cells[rowIndex, colIndex++] = vData.PdPer;
                sheet.Cells[rowIndex, colIndex++] = vData.Uac;
                sheet.Cells[rowIndex, colIndex++] = vData.Uv;
                sheet.Cells[rowIndex, colIndex++] = vData.Udio;
                sheet.Cells[rowIndex, colIndex++] = vData.Ud;
                sheet.Cells[rowIndex, colIndex++] = vData.UdL;
                sheet.Cells[rowIndex, colIndex++] = vData.Id;
                sheet.Cells[rowIndex, colIndex++] = vData.Pd;
                sheet.Cells[rowIndex, colIndex++] = vData.Pconv;
                sheet.Cells[rowIndex, colIndex++] = vData.Qconv;
                sheet.Cells[rowIndex, colIndex++] = vData.TC;
                sheet.Cells[rowIndex, colIndex++] = vData.alphaOrgamma;
                sheet.Cells[rowIndex, colIndex++] = vData.miu;
                sheet.Cells[rowIndex, colIndex++] = vData.Qf_max;
                sheet.Cells[rowIndex, colIndex++] = vData.Qf_min;
                sheet.Cells[rowIndex, colIndex++] = vData.Udio_N;
                sheet.Cells[rowIndex, colIndex++] = vData.Uv_N;
                sheet.Cells[rowIndex, colIndex++] = vData.Tk_N;
                sheet.Cells[rowIndex, colIndex++] = vData.Tk;
                sheet.Cells[rowIndex, colIndex++] = vData.Ud6Valve;
                sheet.Cells[rowIndex, colIndex++] = vData.Pd6Valve;
                sheet.Cells[rowIndex, colIndex++] = vData.Pac6Valve;
                sheet.Cells[rowIndex, colIndex++] = vData.Qac6Valve;
                rowIndex++;
                colIndex = 1;
            }
        }

        private void fillSheetHead(Excel._Worksheet sheet)
        {
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                sheet.Cells[1, i + 1] = "'" + dgv.Columns[i].HeaderText;
                ((Excel.Range)sheet.Rows[1, Missing.Value]).Interior.Color = Color.LightYellow;
            }
        }

        // 导出选择工况包含当前工况下的所有站
        private void btnExportSelected_Click(object sender, EventArgs e)
        {
            SaveToExcel_One();           
        }

        private void SaveToExcel_One()
        {
            Excel.Application vExcel = createExcel();
            Excel.Workbooks wb = vExcel.Workbooks;
            Excel._Workbook book = wb.Add(true);

            // 导出的sheet名集合
            //IList<string> exportSheetsName = getExportSheetsName(pDataList);

            book.Sheets.Add(Type.Missing, Type.Missing, StationPack.ChildCount(), Type.Missing);
            Excel.Sheets sheets = book.Sheets;

            string caseId = lstCase.SelectedItem.ToString();
            IEnumerator ie = sheets.GetEnumerator();

            foreach(KeyValuePair<string,CmcCase> vPair in pStationMap)
            //while (ie.MoveNext())
            {
                ie.MoveNext();
                Excel.Worksheet sheet = ie.Current as Excel.Worksheet;
                //if (index == exportSheetsName.Count)
                //{
                //    sheet.Delete();
                //    break;
                //}
                sheet.Name = vPair.Key;

                DataToSheet(sheet, vPair.Value.DataList());

                

            }

            //
            book.SaveAs(excelFileName, 51, Type.Missing, Missing.Value, Missing.Value,
                Missing.Value, Excel.XlSaveAsAccessMode.xlShared, Missing.Value, Missing.Value, Missing.Value,
                Missing.Value, Missing.Value);

            book.Close();
            wb.Close();
            vExcel.Quit();


            MessageBox.Show("导出成功");

        }

        private Excel.Application createExcel()
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
            if (dlg.ShowDialog() == DialogResult.Cancel)
            {
                return null;
            }
            //返回文件路径      
            excelFileName = dlg.FileName;
            //验证strFileName是否为空或值无效
            if (excelFileName == null || excelFileName.Trim().Equals(string.Empty))
            { return null; }

            Excel.Application excel = new Excel.Application();
            if (excel == null)
            {
                MessageBox.Show("未能创建Excel\n可能未安装Offic");
                return null;
            }
            excel.Visible = false;
            excel.DisplayAlerts = false;
            excel.Caption = "主回路计算数据";
            
            return excel;

        }

        private void OnLoad()
        {
            lstCase.Items.Clear();
            lstStation.Items.Clear();
            dgv.Rows.Clear();

            //
            pResult = CmcVars.pResult;
            pResult.Clear();

            //Load Result
            string vCalName = "南网多端mc计算";
            CmcMvcs.LoadCase_FromMC(vCalName);
            //

            CasePack = pResult.getCasePack(vCalName);
            pCaseMap = CasePack.Children();

            //
            CaseToList();
        }
        // 加载工况列表
        private void CaseToList()
        {
            lstCase.Items.Clear();
            foreach (KeyValuePair<string, CmcCase> vPair in pCaseMap)
            {
                lstCase.Items.Add(vPair.Value.DataName);                
            }
        }

        // 根据工况选择加载站名列表
        private void lstCase_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstStation.Items.Clear();

            string vCaseId = lstCase.SelectedItem.ToString();

            StationPack = pCaseMap[vCaseId] as CmcCasePack;

            pStationMap = StationPack.Children();

            StationToList();

            if (lstStation.Items.Count > 0)
            {
                lstStation.SelectedIndex = 0;
            }
        }

        private void StationToList()
        {
            lstStation.Items.Clear();
            foreach (KeyValuePair<string, CmcCase> vPair in pStationMap)
            {
                lstStation.Items.Add(vPair.Value.DataName);
            }
        }

        private void DataToGrid()
        {

            foreach (RecResultData vData in pDataList)
            {
                dgv.Rows.Add(
                    new object[] {
                        vData.PdPer, vData.Uac, vData.Uv, vData.Udio, vData.Ud, vData.UdL, vData.Id, vData.Pd, vData.Pconv
                        , vData.Qconv, vData.TC, vData.alphaOrgamma, vData.miu, vData.Qf_max, vData.Qf_min, vData.Udio_N
                        , vData.Uv_N, vData.Tk_N, vData.Tk, vData.Ud6Valve, vData.Pd6Valve, vData.Pac6Valve, vData.Qac6Valve
                    }
                );
            }
            
        }

        /// <summary>
        /// 工况查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCoundQ_Click(object sender, EventArgs e)
        {
            if (StringUtil.IsEmpty(txtCase.Text))
            {
                MessageBox.Show("请输入要查询的工况");
                return;
            }
            bool isContains = false;
            foreach (string vCase in lstCase.Items)
            {
                if (vCase.Equals(txtCase.Text))
                {
                    isContains = true;
                }
            }
            if (!isContains)
            {
                MessageBox.Show("查询的工况不在列表中");
                return;
            }
            lstCase.SelectedItem = txtCase.Text;
        }

        /// <summary>
        /// 读入数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            OnLoad();
        }
    }
}
