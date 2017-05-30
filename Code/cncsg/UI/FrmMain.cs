using System;
using System.Collections;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using cn.csg.dpcp.common;
using Hvdc.MT.Project.App;
using Hvdc.MT.mc.App;
using Hvdc.MT.mc.Rw;
using Hvdc.MT.xb.App;
using Hvdc.MT.U3p.App;

namespace cn.csg.dpcp.ui
{
    public partial class FrmMain : RibbonForm
    {
        private TreeHelper treeHelper = new TreeHelper();
        private CPanelHelper pnlHelper = new CPanelHelper();
        private CProjectHelper proHelper = new CProjectHelper();
        


        #region AppCreation
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //MessageBoxEx.EnableGlass = false; // Disalbe glass effect if available
            Application.Run(new FrmMain());

        }
        #endregion

        private void frmMain_Load(object sender, System.EventArgs e)
        {
            CHvdcInitApp.Init();

            #region ribbon auto code
            ribbonControl1.SelectedRibbonTabChanged += new EventHandler(ribbonCtrlTab_SelectedChanged);
            ribbonControl1.SelectFirstVisibleRibbonTab();

            // Load Quick Access Toolbar layout if one is saved from last session...
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\DevComponents\Ribbon");
            if (key != null)
            {
                try
                {
                    string layout = key.GetValue("RibbonPadCSLayout", "").ToString();
                    if (layout != "" && layout != null)
                        ribbonControl1.QatLayout = layout;
                }
                finally
                {
                    key.Close();
                }
            }

            // Following Code Adds Bell button next to form system buttons on the right hand side
            // If you are loading QAT Layout like code above, adding custom buttons must be done AFTER QatLayout property is set
            ArrayList items = ribbonControl1.RibbonStrip.GetItems("", typeof(SystemCaptionItem));
            SystemCaptionItem sysFormButtons = (SystemCaptionItem)items[items.Count - 1];
            BaseItem parentCont = sysFormButtons.Parent;
            ButtonItem buttonNotify = new ButtonItem("buttonNotify");
            buttonNotify.Symbol = "\uf0f3";
            buttonNotify.ItemAlignment = eItemAlignment.Far;
            buttonNotify.SymbolSize = 12f;
            buttonNotify.Click += new EventHandler(ButtonNotifyClick);
            parentCont.SubItems.Insert(parentCont.SubItems.IndexOf(sysFormButtons), buttonNotify);

            // Pulse the Application Button
            //buttonFile.Pulse(11);
            #endregion ribbon auto code
        }

        private void ribbonCtrlTab_SelectedChanged(object sender, System.EventArgs e)
        {
            RibbonControl ribbon = sender as RibbonControl;
            grpBoxTree.Text = ribbon.SelectedRibbonTabItem.Text;
            //treeHelper.initTree(ribbon.SelectedRibbonTabItem.Text, treeView);
        }

        private void initTree(string treeTitle, string menuName)
        {
            if (CProStatusManager.IsClose())
            {
                return;
            }
            grpBoxTree.Text = treeTitle;
            treeHelper.initTree(menuName, treeView);
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeView tree = sender as TreeView;

            if (e.Node.Nodes.Count > 0)
            { 
                // 非叶节点
                return;
            }

            CfmBaseFrom subPanel = pnlHelper.TreeNodeChanged(null, tree, e);
            if (subPanel == null)
            {
                MessageBox.Show("未找到对应界面");
                return;
            }
            pnlMain.Controls.Clear();
            subPanel.TopLevel = false;
            subPanel.Dock = DockStyle.Left;
            pnlMain.Controls.Add(subPanel);
            subPanel.Show();
        }

        // 新建工程
        private void btnNewPro_Click(object sender, EventArgs e)
        {
            proHelper.CreateProject();
            C3pVars.NewGrid();

        }

        // 打开工程
        private void btnOpenPro_Click(object sender, EventArgs e)
        {
            proHelper.OpenProject();
            
        }

        // 保存工程
        private void btnSavePro_Click(object sender, EventArgs e)
        {
            proHelper.SaveProject();            
        }

        // 关闭工程
        private void btnClosePro_Click(object sender, EventArgs e)
        {
            proHelper.CloseProject();
            treeView.Nodes.Clear();
            pnlMain.Controls.Clear();
        }

        private void btmExit_Click(object sender, EventArgs e)
        {
            proHelper.CloseProject();
            Dispose(true);
        }


        #region 菜单按钮事件
        /// <summary>
        /// 直流侧谐波器设计 三脉动 参数录入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn3MdParamIn_Click(object sender, EventArgs e)
        {
            ButtonItem btn = sender as ButtonItem;
            initTree(btn.Tag.ToString(), btn.Name);
        }

        /// <summary>
        /// 直流侧谐波器设计 三脉动 工况计算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn3MdOrder_Click(object sender, EventArgs e)
        {
            ButtonItem btn = sender as ButtonItem;
            initTree(btn.Tag.ToString(), btn.Name);
        }

        /// <summary>
        /// 直流侧谐波器设计 三脉动 结果处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn3MdResult_Click(object sender, EventArgs e)
        {
            ButtonItem btn = sender as ButtonItem;
            initTree(btn.Tag.ToString(), btn.Name);
        }

        /// <summary>
        /// 直流侧谐波器设计 滤波器设计 单回线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDcLbqSingle_Click(object sender, EventArgs e)
        {
            ButtonItem btn = sender as ButtonItem;
            initTree(btn.Tag.ToString(), btn.Name);
        }

        /// <summary>
        /// 直流侧谐波器设计 滤波器设计 双回线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDcLbqDouble_Click(object sender, EventArgs e)
        {
            ButtonItem btn = sender as ButtonItem;
            initTree(btn.Tag.ToString(), btn.Name);
        }

        /// <summary>
        /// 直流侧谐波器设计 滤波器设计 参数录入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDcLbqParamIn_Click(object sender, EventArgs e)
        {
            ButtonItem btn = sender as ButtonItem;
            initTree(btn.Tag.ToString(), btn.Name);
        }

        /// <summary>
        /// 直流侧谐波器设计 滤波器设计 工况计算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDcLbqOrder_Click(object sender, EventArgs e)
        {
            ButtonItem btn = sender as ButtonItem;
            initTree(btn.Tag.ToString(), btn.Name);
        }

        /// <summary>
        /// 直流侧谐波器设计 滤波器设计 结果处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDcLbqResult_Click(object sender, EventArgs e)
        {
            ButtonItem btn = sender as ButtonItem;
            initTree(btn.Tag.ToString(), btn.Name);
        }

        /// <summary>
        /// 直流侧谐波器设计 阻抗 参数录入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZkScanParamIn_Click(object sender, EventArgs e)
        {
            ButtonItem btn = sender as ButtonItem;
            initTree(btn.Tag.ToString(), btn.Name);
        }

        /// <summary>
        /// 直流侧谐波器设计 阻抗 工况
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDcZkScanOrder_Click(object sender, EventArgs e)
        {
            ButtonItem btn = sender as ButtonItem;
            initTree(btn.Tag.ToString(), btn.Name);
        }

        /// <summary>
        /// 直流侧谐波器设计 阻抗 结果处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDcZkScanResult_Click(object sender, EventArgs e)
        {
            ButtonItem btn = sender as ButtonItem;
            initTree(btn.Tag.ToString(), btn.Name);
        }

        /// <summary>
        /// 主回路 参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParamIn4MainLoop_Click(object sender, EventArgs e)
        {
            ButtonItem btn = sender as ButtonItem;
            initTree(btn.Tag.ToString(), btn.Name);
        }

        /// <summary>
        /// 主回路 工况
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalc4MainLoop_Click(object sender, EventArgs e)
        {
            ButtonItem btn = sender as ButtonItem;
            initTree(btn.Tag.ToString(), btn.Name);
        }

        /// <summary>
        /// 主回路 结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProcess4MainLoop_Click(object sender, EventArgs e)
        {
            ButtonItem btn = sender as ButtonItem;
            initTree(btn.Tag.ToString(), btn.Name);
        }

        /// <summary>
        /// 直流线路参数 参数选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDcLineParamIn_Click(object sender, EventArgs e)
        {
            ButtonItem btn = sender as ButtonItem;
            initTree(btn.Tag.ToString(), btn.Name);
        }
        #endregion 菜单按钮事件


    }
}