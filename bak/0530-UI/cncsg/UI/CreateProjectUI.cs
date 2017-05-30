using cn.csg.dpcp.common;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace cn.csg.dpcp.ui
{
    public partial class CreateProjectUI : Form
    {
        // 返回新建工程结果，1=新建成功，-1=新建失败或者取消新建
        private int result = -1;
        public CreateProjectUI()
        {
            InitializeComponent();
        }

        public int Result
        {
            get { return result; }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                validate();
                string filename = openSrcDbTemplate(); // 包含路径 + 文件名
                if (filename != null && !string.Empty.Equals(filename))
                {
                    copyDbFile(filename);
                    MessageBox.Show("新建换流站成功");
                    result = 1;
                    Close();
                }
            }
            catch (Exception ex)
            {
                result = -1;
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void validate()
        {
            if (txtProjectName.Text == null || string.Empty.Equals(txtProjectName.Text))
            {
                throw new Exception("请输入工程名称");
            }
            if (lstStation.Items.Count < 2)
            {
                throw new Exception("换流站个数不能小于2");
            }
        }

        private string openSrcDbTemplate()
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Title = "请选择新增的数据库文件名";
            fileDialog.Filter = "数据库(*.accdb)|*.accdb";
            fileDialog.RestoreDirectory = true;
            fileDialog.FilterIndex = 2;
            fileDialog.CheckFileExists = false;
            fileDialog.CheckPathExists = false;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(fileDialog.FileName))
                {
                    throw new Exception("目标文件已存在，不能覆盖，请输入新的文件名");
                }
            }
            return fileDialog.FileName;
        }

        private void saveProject()
        {
            //CNewProjectVo vo = new CNewProjectVo();
            //vo.ProjectName = txtProjectName.Text;
            //vo.StationCount = lstStation.Items.Count;
            //CProjectDAL dal = new CProjectDAL();
            //bool isExist = dal.IsProjectExist(vo);
            //if (isExist)
            //{
            //    throw new Exception("已存在相同的工程名称");
            //}
            //dal.SaveProject(vo);
        }

        // 将模板数据库文件复制为新建工程文件
        private void copyDbFile(string filename)
        {
            StringBuilder templateFile = new StringBuilder(); // access来源文件template.access

            // 从template文件复制一份                                             
            string[] filenames = filename.Split(Path.DirectorySeparatorChar);
            for (int i = 0; i < filenames.Length; i++)
            {
                // 文件名替换成为同目录下的template.accdb
                if (i == filenames.Length - 1)
                {
                    templateFile.Append("template.accdb");
                    break;
                }
                templateFile.Append(filenames[i]);
                templateFile.Append(Path.DirectorySeparatorChar);
            }

            //System.IO.File.Copy(srcFile.ToString(), fileDialog.FileName, false);
            DBConfig.Remove(Constants.AccessDBPath);
            //DBConfig.dbConfig.Add(Constants.AccessDBPath, fileDialog.FileName);
            DBConfig.AddCreateNewDbFlag(filename, templateFile.ToString());
            createMcDevices();
            createXbDevice();
            createZkDevice();
            create3pDevice();
            //saveProject();
        }

        // 根据添加换流站数目生成相应数目的设备
        // 设备包含交流系统、交流滤波器、换流变压器、换流器、接地极Ground
        private void createMcDevices()
        {
            foreach (ListViewItem i in lstStation.Items)
            {
                // create AcFilter
                //CMCAcFilterVo acFilter = new CMCAcFilterVo();
                //acFilter.StationName = i.SubItems[1].Text;
                //acFilter.DeviceID = acFilter.StationName + "_ACF";
                //acFilter.DeviceName = acFilter.DeviceID;
                //// devicetype = 12
                //acFilter.NodeNames[0] = acFilter.StationName;
                //// test
                ////acFilter.StationName = acFilter.NodeNames[0];
                //CMCDeviceDataSet.AcFilter.VoList.Add(acFilter);

                //// create AcSystem
                //CMCAcSystemVo acSystem = new CMCAcSystemVo();
                //acSystem.StationName = i.SubItems[1].Text;
                //acSystem.DeviceID = acSystem.StationName + "_ACSYS";
                //acSystem.DeviceName = acSystem.DeviceID;
                //// devicetype = 11
                //acSystem.NodeNames[0] = acSystem.StationName;
                //// 测试用
                //acSystem.StationName = acSystem.NodeNames[0];
                //// test
                ////acSystem.StationName = acSystem.NodeNames[0];
                //CMCDeviceDataSet.AcSystem.VoList.Add(acSystem);

                //// create CMCTransformer
                //CMCTransformerVo transVo = new CMCTransformerVo();
                //transVo.StationName = i.SubItems[1].Text;
                //transVo.DeviceID = transVo.StationName + "_ACTRANS";
                //transVo.DeviceName = transVo.DeviceID;
                //// devicetype = 13
                //transVo.NodeNames[0] = transVo.StationName;
                //transVo.NodeNames[1] = transVo.StationName;
                //// test
                ////transVo.StationName = transVo.NodeNames[0] + "-----" + transVo.NodeNames[1];
                //CMCDeviceDataSet.Transformer.VoList.Add(transVo);

                //// create CMCConvertor
                //CMCConvertorVo convertorVo = new CMCConvertorVo();
                //convertorVo.StationName = i.SubItems[1].Text;
                //convertorVo.DeviceID = convertorVo.StationName;
                //convertorVo.DeviceName = convertorVo.DeviceID;
                //// devicetype = 14
                //convertorVo.NodeNames[0] = convertorVo.StationName + "_High";//首端：与直流线相连
                //convertorVo.NodeNames[1] = convertorVo.StationName + "_Low";//末端：与接地线（中性点）相连
                //// test
                ////convertorVo.StationName = convertorVo.NodeNames[0] + "-----" + convertorVo.NodeNames[1];
                //CMCDeviceDataSet.Convertor.VoList.Add(convertorVo);

                //// create GroundLine
                //CMCGroundLineVo groundLVo = new CMCGroundLineVo();
                //groundLVo.StationName = i.SubItems[1].Text;
                //groundLVo.DeviceID = groundLVo.StationName + "_ACGNDL";
                //groundLVo.DeviceName = groundLVo.DeviceID;
                //// devicetype = 16
                //groundLVo.NodeNames[0] = groundLVo.StationName + "_Low";          //首端：与换流器底端相连
                //groundLVo.NodeNames[1] = groundLVo.StationName + "_GNDLine1";   //末端：与接地极相连
                //// test
                ////groundLVo.StationName = groundLVo.NodeNames[0] + "-----" + groundLVo.NodeNames[1];
                //CMCDeviceDataSet.GroundLine.VoList.Add(groundLVo);

                //// create AcSystem
                //CMCGroundVo groundVo = new CMCGroundVo();
                //groundVo.StationName = i.SubItems[1].Text;
                //groundVo.DeviceID = groundVo.StationName + "_ACGND";
                //groundVo.DeviceName = groundVo.DeviceID;
                //// devicetype = 17
                //groundVo.NodeNames[0] = groundVo.StationName + "_GNDLine1"; //与接地线末端相连
                //// test
                ////groundVo.StationName = groundVo.NodeNames[0];
                //CMCDeviceDataSet.Ground.VoList.Add(groundVo);
            }
        }

        private void createXbDevice()
        {

        }

        private void createZkDevice()
        {

        }

        private void create3pDevice()
        {

        }

        private void CreateProjectUI_Load(object sender, EventArgs e)
        {
            cboStationType.SelectedIndex = 0;
            cboCtrlType.SelectedIndex = 0;
            initListView();
        }

        // 初始化表格
        private void initListView()
        {
        }

        // 添加换流站
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProjectName.Text == null || string.Empty.Equals(txtStationName.Text))
            {
                MessageBox.Show("请输入换流站名称");
                return;
            }
            if (lstStation.Items[txtStationName.Text] != null)
            {
                MessageBox.Show("换流站名称已存在");
                return;
            }
            ListViewItem item = new ListViewItem();
            item.Text = (lstStation.Items.Count + 1) + "";
            item.Name = txtStationName.Text;
            item.SubItems.Add(txtStationName.Text);
            item.SubItems.Add(cboStationType.SelectedItem.ToString());
            item.SubItems.Add(cboCtrlType.SelectedItem.ToString());


            lstStation.Items.Add(item);
        }

        // 删除换流站
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstStation.SelectedItems.Count > 0)
            {
                int count = lstStation.Items.Count; // 所有换流站个数
                ListViewItem item = lstStation.SelectedItems[0];
                int seq = int.Parse(item.Text);
                foreach (ListViewItem i in lstStation.Items)
                {
                    if (int.Parse(i.Text) > seq)
                    {
                        i.Text = int.Parse(i.Text) - 1 + "";
                    }
                }
                lstStation.Items.Remove(item);
            }
        }

        // 更新选择项
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (lstStation.SelectedItems.Count > 0)
            {
                ListViewItem item = lstStation.SelectedItems[0];
                item.SubItems[1].Text = txtStationName.Text;
                item.SubItems[2].Text = cboStationType.SelectedItem.ToString();
                item.SubItems[3].Text = cboCtrlType.SelectedItem.ToString();
            }
        }

        // 
        private void lstStation_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            txtStationName.Text = e.Item.SubItems[1].Text;
            cboStationType.SelectedItem = e.Item.SubItems[2].Text;
            cboCtrlType.SelectedItem = e.Item.SubItems[3].Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
