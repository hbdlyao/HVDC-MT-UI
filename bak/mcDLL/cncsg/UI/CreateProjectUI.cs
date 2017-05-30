using cn.csg.dpcp.common;
using cn.csg.dpcp.dal.pro;
using cn.csg.dpcp.model.dataset;
using cn.csg.dpcp.model.vo;
using cn.csg.dpcp.model.vo.mc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cn.csg.dpcp.ui
{
    public partial class CreateProjectUI : Form
    {
        private StringBuilder srcFile = new StringBuilder(); // access来源文件template.access

        public CreateProjectUI()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (lstStation.Items.Count < 2)
            {
                MessageBox.Show("换流站个数不能小于2");
                return;
            }
            if (txtProjectName.Text == null || string.Empty.Equals(txtProjectName.Text))
            {
                MessageBox.Show("请输入工程名称");
                return;
            }

            copyDbFile();
            MessageBox.Show("新建换流站成功");
            this.Close();
        }

        private void saveProject()
        {
            CNewProjectVo vo = new CNewProjectVo();
            vo.ProjectName = txtProjectName.Text;
            vo.StationCount = lstStation.Items.Count;
            CProjectDAL dal = new CProjectDAL();
            bool isExist = dal.IsProjectExist(vo);
            if (isExist)
            {
                MessageBox.Show("已存在相同的工程名称");
                return;
            }
            dal.SaveProject(vo);
        }

        // 将模板数据库文件复制为新建工程文件
        private void copyDbFile()
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
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

            if (System.IO.File.Exists(fileDialog.FileName))
            {
                MessageBox.Show("目标文件已存在，不能覆盖，请输入新的文件名");
                return;
            }

            // 从template文件复制一份
            string[] filenames = fileDialog.FileName.Split(Path.DirectorySeparatorChar);
            for (int i = 0; i < filenames.Length; i++)
            {
                // 文件名替换成为同目录下的template.accdb
                if (i == filenames.Length - 1)
                {
                    srcFile.Append("template.accdb");
                    break;
                }
                srcFile.Append(filenames[i]);
                srcFile.Append(Path.DirectorySeparatorChar);
            }

            //System.IO.File.Copy(srcFile.ToString(), fileDialog.FileName, false);
            DBConfig.Remove(Constants.AccessDBPath);
            //DBConfig.dbConfig.Add(Constants.AccessDBPath, fileDialog.FileName);

            DBConfig.AddCreateNewDbFlag(fileDialog.FileName, srcFile.ToString());
            createMCDevices();
            //saveProject();
        }

        // 根据添加换流站数目生成相应数目的设备
        // 设备包含交流系统、交流滤波器、换流变压器、换流器、接地极Ground
        private void createMCDevices()
        {
            foreach (ListViewItem i in lstStation.Items)
            {
                // create AcFilter
                CMCAcFilterVo acFilter = new CMCAcFilterVo();
                acFilter.StationName = i.SubItems[1].Text;
                acFilter.DeviceID = acFilter.StationName + "_ACF";
                acFilter.DeviceName = acFilter.DeviceID;
                // devicetype = 12
                acFilter.NodeNames[0] = acFilter.StationName;
                // test
                //acFilter.StationName = acFilter.NodeNames[0];
                CMCDeviceDataSet.AcFilter.VoList.Add(acFilter);

                // create AcSystem
                CMCAcSystemVo acSystem = new CMCAcSystemVo();
                acSystem.StationName = i.SubItems[1].Text;
                acSystem.DeviceID = acSystem.StationName + "_ACSYS";
                acSystem.DeviceName = acSystem.DeviceID;
                // devicetype = 11
                acSystem.NodeNames[0] = acSystem.StationName;
                // 测试用
                acSystem.StationName = acSystem.NodeNames[0];
                // test
                //acSystem.StationName = acSystem.NodeNames[0];
                CMCDeviceDataSet.AcSystem.VoList.Add(acSystem);

                // create CMCTransformer
                CMCTransformerVo transVo = new CMCTransformerVo();
                transVo.StationName = i.SubItems[1].Text;
                transVo.DeviceID = transVo.StationName + "_ACTRANS";
                transVo.DeviceName = transVo.DeviceID;
                // devicetype = 13
                transVo.NodeNames[0] = transVo.StationName;
                transVo.NodeNames[1] = transVo.StationName;
                // test
                //transVo.StationName = transVo.NodeNames[0] + "-----" + transVo.NodeNames[1];
                CMCDeviceDataSet.Transformer.VoList.Add(transVo);

                // create CMCConvertor
                CMCConvertorVo convertorVo = new CMCConvertorVo();
                convertorVo.StationName = i.SubItems[1].Text;
                convertorVo.DeviceID = convertorVo.StationName;
                convertorVo.DeviceName = convertorVo.DeviceID;
                // devicetype = 14
                convertorVo.NodeNames[0] = convertorVo.StationName+ "_High";//首端：与直流线相连
                convertorVo.NodeNames[1] = convertorVo.StationName+ "_Low";//末端：与接地线（中性点）相连
                // test
                //convertorVo.StationName = convertorVo.NodeNames[0] + "-----" + convertorVo.NodeNames[1];
                CMCDeviceDataSet.Convertor.VoList.Add(convertorVo);

                // create GroundLine
                CMCGroundLineVo groundLVo = new CMCGroundLineVo();
                groundLVo.StationName = i.SubItems[1].Text;
                groundLVo.DeviceID = groundLVo.StationName + "_ACGNDL";
                groundLVo.DeviceName = groundLVo.DeviceID;
                // devicetype = 16
                groundLVo.NodeNames[0] = groundLVo.StationName + "_Low";          //首端：与换流器底端相连
                groundLVo.NodeNames[1] = groundLVo.StationName + "_GNDLine1";   //末端：与接地极相连
                // test
                //groundLVo.StationName = groundLVo.NodeNames[0] + "-----" + groundLVo.NodeNames[1];
                CMCDeviceDataSet.GroundLine.VoList.Add(groundLVo);

                // create AcSystem
                CMCGroundVo groundVo = new CMCGroundVo();
                groundVo.StationName = i.SubItems[1].Text;
                groundVo.DeviceID = groundVo.StationName + "_ACGND";
                groundVo.DeviceName = groundVo.DeviceID;
                // devicetype = 17
                groundVo.NodeNames[0] = groundVo.StationName + "_GNDLine1"; //与接地线末端相连
                // test
                //groundVo.StationName = groundVo.NodeNames[0];
                CMCDeviceDataSet.Ground.VoList.Add(groundVo);


            }
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
            ListViewItem item = new ListViewItem();
            item.Text = (lstStation.Items.Count + 1) + "";
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
            else
            {
                MessageBox.Show("请选择要删除的换流站");
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
            this.Close();
        }
    }
}
