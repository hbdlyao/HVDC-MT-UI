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
        
        
        private ButtonItem btnClosePro;
        private ButtonItem btmExit;

        private TreeHelper treeHelper = new TreeHelper();
        private CPanelHelper pnlHelper = new CPanelHelper();
        private CProjectHelper proHelper = new CProjectHelper();
        private UIStatusEnum uiStatus = UIStatusEnum.EMPTY;
        private TreeView treeView1;
        private Panel pnlMain;
        private MenuBtnEventHandle mbeh = new MenuBtnEventHandle();


        public UIStatusEnum UiStatus
        {
            get { return uiStatus; }
            set { uiStatus = value; }
        }

        public TreeView GetTree
        {
            get { return treeView1; }
        }

        public Panel PanMain
        {
            get { return pnlMain; }
        }

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

        private void ribbonCtrlTab_SelectedChanged(object sender, System.EventArgs e)
        {
            if (uiStatus == UIStatusEnum.EMPTY || uiStatus == UIStatusEnum.CLOSE)
            {
                return;
            }
            RibbonControl ribbon = sender as RibbonControl;
            grpBoxTree.Text = ribbon.SelectedRibbonTabItem.Text;

            treeHelper.initTree(ribbon.SelectedRibbonTabItem.Name, treeView1, imageList);
        }

        private void frmMain_Load(object sender, System.EventArgs e)
        {
            CHvdcInitApp.Init();


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
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeView tree = sender as TreeView;

            if (e.Node.Nodes.Count > 0)
            { 
                // 非叶节点
                return;
            }

            DpcpBaseForm subPanel = pnlHelper.TreeNodeChanged(null, tree, e);
            if (subPanel == null)
            {
                MessageBox.Show("未找到对应UI");
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
            proHelper.CreateProject(this);
            UiStatus = UIStatusEnum.NEW;

            //
            C3pVars.NewGrid();

        }

        // 打开工程
        private void btnOpenPro_Click(object sender, EventArgs e)
        {
            proHelper.OpenProject(this);
            uiStatus = UIStatusEnum.OPEN;



            CHvdcMvcs.OnLoad();


        }

        // 保存工程
        private void btnSavePro_Click(object sender, EventArgs e)
        {
            proHelper.SaveProject(this);
            UiStatus = UIStatusEnum.OPEN;
            
        }

        // 关闭工程
        private void btnClosePro_Click(object sender, EventArgs e)
        {
            proHelper.CloseProject(this);
            UiStatus = UIStatusEnum.EMPTY;
            treeView1.Nodes.Clear();
            pnlMain.Controls.Clear();
            
        }

        private void btmExit_Click(object sender, EventArgs e)
        {
            proHelper.CloseProject(this);
            Dispose(true);
        }

        private void initTree(ButtonItem btn)
        {
            if (uiStatus == UIStatusEnum.EMPTY || uiStatus == UIStatusEnum.CLOSE)
            {
                return;
            }
            grpBoxTree.Text = btn.Tag.ToString();

            treeHelper.initTree(btn.Name, treeView1, imageList);
        }

        /// <summary>
        /// 直流侧谐波器设计 三脉动 参数录入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn3MdParamIn_Click(object sender, EventArgs e)
        {
            ButtonItem btn = sender as ButtonItem;
            initTree(btn);
        }

        /// <summary>
        /// 直流侧谐波器设计 三脉动 工况计算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn3MdOrder_Click(object sender, EventArgs e)
        {
            ButtonItem btn = sender as ButtonItem;
            initTree(btn);
        }

        /// <summary>
        /// 直流侧谐波器设计 三脉动 结果处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn3MdResult_Click(object sender, EventArgs e)
        {
            ButtonItem btn = sender as ButtonItem;
            initTree(btn);
        }

        /// <summary>
        /// 直流侧谐波器设计 滤波器设计 单回线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDcLbqSingle_Click(object sender, EventArgs e)
        {
            ButtonItem btn = sender as ButtonItem;
            initTree(btn);
        }

        /// <summary>
        /// 直流侧谐波器设计 滤波器设计 双回线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDcLbqDouble_Click(object sender, EventArgs e)
        {
            ButtonItem btn = sender as ButtonItem;
            initTree(btn);
        }

        /// <summary>
        /// 直流侧谐波器设计 滤波器设计 参数录入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDcLbqParamIn_Click(object sender, EventArgs e)
        {
            ButtonItem btn = sender as ButtonItem;
            initTree(btn);
        }

        /// <summary>
        /// 直流侧谐波器设计 滤波器设计 工况计算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDcLbqOrder_Click(object sender, EventArgs e)
        {
            ButtonItem btn = sender as ButtonItem;
            initTree(btn);
        }

        /// <summary>
        /// 直流侧谐波器设计 滤波器设计 结果处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDcLbqResult_Click(object sender, EventArgs e)
        {
            ButtonItem btn = sender as ButtonItem;
            initTree(btn);
        }

        /// <summary>
        /// 直流侧谐波器设计 阻抗 参数录入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZkScanParamIn_Click(object sender, EventArgs e)
        {
            ButtonItem btn = sender as ButtonItem;
            initTree(btn);
        }

        /// <summary>
        /// 直流侧谐波器设计 阻抗 工况
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDcZkScanOrder_Click(object sender, EventArgs e)
        {
            ButtonItem btn = sender as ButtonItem;
            initTree(btn);
        }

        /// <summary>
        /// 直流侧谐波器设计 阻抗 结果处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDcZkScanResult_Click(object sender, EventArgs e)
        {
            ButtonItem btn = sender as ButtonItem;
            initTree(btn);
        }
    }
}