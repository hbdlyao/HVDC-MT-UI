using System.Windows.Forms;
using cn.csg.dpcp.common;
using cn.csg.dpcp.dal.mc;
using cn.csg.dpcp.model.dataset;
using Hvdc.MT.mc.App;
using Hvdc.MT.mc.Rw;
using System.IO;
using Hvdc.MT.Project.App;

namespace cn.csg.dpcp.ui
{
    public class CProjectHelper
    {
        public void OpenProject(FrmMain frm)
        {
            if (frm.UiStatus != UIStatusEnum.EMPTY && frm.UiStatus != UIStatusEnum.CLOSE)
            {
                DialogResult result = isSave();
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                else if (result == DialogResult.Yes)
                {
                    SaveProject(frm);
                }
            }

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "请选择数据库文件";
            fileDialog.Filter = "数据库(*.accdb)|*.accdb";
            fileDialog.RestoreDirectory = true;
            fileDialog.FilterIndex = 2;
            fileDialog.CheckFileExists = false;
            fileDialog.CheckPathExists = false;
            if (fileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            DBConfig.Remove(Constants.AccessDBPath);
            DBConfig.Add(Constants.AccessDBPath, fileDialog.FileName);

            // 获取选择的数据库所在目录
            string fileNameNotDir = fileDialog.SafeFileName; // 文件目录不包含路劲
            int dbNameIndex = fileDialog.FileName.LastIndexOf(fileNameNotDir);  
            string dbDir = fileDialog.FileName.Remove(dbNameIndex);

            CHvdcParams.SetDbfFile(dbDir);

        }

        public void CloseProject(FrmMain frm)
        {
            EmptyProject(frm);
        }

        public void EmptyProject(FrmMain frm)
        {
            if (frm.UiStatus != UIStatusEnum.EMPTY && frm.UiStatus != UIStatusEnum.CLOSE)
            {
                DialogResult result = isSave();
                if (result == DialogResult.Yes)
                {
                    SaveProject(frm);
                }
                
            }
        }

        public void CreateProject(FrmMain frm)
        {
            if (frm.UiStatus != UIStatusEnum.EMPTY && frm.UiStatus != UIStatusEnum.CLOSE)
            {
                DialogResult result = isSave();
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                else if (result == DialogResult.Yes)
                {
                    SaveProject(frm);
                    
                }
            }
            CreateProjectUI ui = new CreateProjectUI();
            ui.ShowDialog();

        }

        public void SaveProject(FrmMain frm)
        {
            if (frm.UiStatus == UIStatusEnum.EMPTY || frm.UiStatus == UIStatusEnum.CLOSE)
            {
                return;
            }
            save(frm);
            MessageBox.Show("保存工程成功");
        }

        private DialogResult isSave()
        {
            DialogResult result = MessageBox.Show("是否保存当前工程？", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            return result;
        }

        private void save(FrmMain frm)
        {
            string createNewDbPath = DBConfig.get(DBConfig.CreateNewDBPath);
            string srcDbTemplatePath = DBConfig.get(DBConfig.SrcDbTemplatePath);
            if (createNewDbPath != null)
            {
               bool isTemplateExist = System.IO.File.Exists(srcDbTemplatePath);
                if (!isTemplateExist)
                {
                    MessageBox.Show("选定的目录下没有template.accdb文件","", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DBConfig.RemoveCreateNewDbFlag();
                    return;
                }
                DBConfig.CopyNewDbFromTemplate();
                // 创建新数据文件后数据库连接指向新文件
                DBConfig.Remove(Constants.AccessDBPath);
                DBConfig.Add(Constants.AccessDBPath, DBConfig.get(DBConfig.CreateNewDBPath));
                DBConfig.RemoveCreateNewDbFlag();
            }

            CMCAcFilterDAL mcAcFilterDal = new CMCAcFilterDAL();
            mcAcFilterDal.SaveList(CMCDeviceDataSet.AcFilter);

            MCCAcSystemDAL mcSystemDal = new MCCAcSystemDAL();
            mcSystemDal.SaveList(CMCDeviceDataSet.AcSystem);
        }

        public void ResetProject()
        {

        }

    }
}
