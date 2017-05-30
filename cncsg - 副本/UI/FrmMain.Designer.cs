
using DevComponents.DotNetBar;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using cn.csg.dpcp.common;

namespace cn.csg.dpcp.ui
{
    partial class FrmMain
    {
        #region Private Vars
        private System.ComponentModel.IContainer components;
        private Bar bar1;
        private LabelItem labelStatus;
        internal LabelItem labelPosition;
        private RibbonControl ribbonControl1;
        private RibbonTabItem ribTabPrjManage;
        private RibbonPanel ribPnlPrjManage;
        private ButtonItem buttonSave;
        private ButtonItem buttonUndo;


        private RibbonPanel ribPnlMainLoop;
        private RibbonBar ribGrpMainLoop;
        private ButtonItem btnMcParam;
        private ButtonItem btnMcOrder;
        private ButtonItem btnMcResult;
        //private RibbonTabItem ribTagMainLoop;
        private ButtonItem buttonChangeStyle;


        //private ButtonItem buttonStyleOffice2007Blue;
        //private ButtonItem buttonStyleOffice2007Silver;
        //private ButtonItem buttonStyleOffice2007Black;
        private ButtonItem buttonStyleOffice2010Silver;
        private ButtonItem buttonStyleOffice2010Blue;
        //private ButtonItem buttonStyleOffice2010Black;
        //private ButtonItem buttonStyleVS2010;
        //private ButtonItem buttonStyleMetro;

        private Timer progressBarTimer;
        private ProgressBarItem progressBarItem1;
        private ColorPickerDropDown buttonStyleCustom;

        private Command AppCommandSave;
        private Command AppCommandTheme;
        private Command RibbonStateCommand;

        private StyleManager styleManager;

        private GroupBox grpBoxTree;
        
        private ImageList imageList;
        private RibbonBar ribBarPrj;
        private ButtonItem buttonItem1;
        private ButtonItem buttonItem2;
        private ButtonItem buttonItem3;
  
        private ApplicationButton applicationButton1;
        private ItemContainer itemContainer1;
        private ItemContainer itemContainer2;
        private ItemContainer itemContainer3;
        private ButtonItem buttonItem4;
        private ButtonItem buttonItem5;
        private ButtonItem buttonItem6;
        private ButtonItem buttonItem7;
        private GalleryContainer galleryContainer1;
        private LabelItem labelItem8;
        private ButtonItem buttonItem8;
        private ButtonItem buttonItem9;
        private ButtonItem buttonItem10;
        private ButtonItem buttonItem11;
        private ItemContainer itemContainer4;
        private ButtonItem buttonItem12;
        private ButtonItem buttonItem13;
        private RibbonPanel ribbonPanel1;
        private RibbonBar Menu_DC_XB_3Md;
        private ButtonItem btn3MdParamIn;
        private ButtonItem btn3MdOrder;
        private ButtonItem btn3MdResult;
        private RibbonTabItem ribTagDcXbEc;
        private ButtonItem btnNewPro;
        private ButtonItem btnOpenPro;
        private ButtonItem btnSavePro;
        private Office2007StartButton buttonFile;
        #endregion

        #region Constructor/Dispose
        public FrmMain()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.labelStatus = new DevComponents.DotNetBar.LabelItem();
            this.progressBarItem1 = new DevComponents.DotNetBar.ProgressBarItem();
            this.labelPosition = new DevComponents.DotNetBar.LabelItem();
            this.AppCommandTheme = new DevComponents.DotNetBar.Command(this.components);
            this.AppCommandSave = new DevComponents.DotNetBar.Command(this.components);
            this.buttonStyleCustom = new DevComponents.DotNetBar.ColorPickerDropDown();
            this.RibbonStateCommand = new DevComponents.DotNetBar.Command(this.components);
            this.progressBarTimer = new System.Windows.Forms.Timer(this.components);
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.grpBoxTree = new System.Windows.Forms.GroupBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.Menu_DC_LBQ_ZK = new DevComponents.DotNetBar.RibbonBar();
            this.btnZkScanParamIn = new DevComponents.DotNetBar.ButtonItem();
            this.btnDcZkScanOrder = new DevComponents.DotNetBar.ButtonItem();
            this.btnDcZkScanResult = new DevComponents.DotNetBar.ButtonItem();
            this.ribDcLineParam = new DevComponents.DotNetBar.RibbonBar();
            this.btnDcLineParamMenu = new DevComponents.DotNetBar.ButtonItem();
            this.btnDcLineParamOrder = new DevComponents.DotNetBar.ButtonItem();
            this.btnDcLineResult = new DevComponents.DotNetBar.ButtonItem();
            this.ribBarDcLbq = new DevComponents.DotNetBar.RibbonBar();
            this.btnDcLbqSingle = new DevComponents.DotNetBar.ButtonItem();
            this.btnDcLbqDouble = new DevComponents.DotNetBar.ButtonItem();
            this.btnDcLbqParamIn = new DevComponents.DotNetBar.ButtonItem();
            this.btnDcLbqOrder = new DevComponents.DotNetBar.ButtonItem();
            this.btnDcLbqResult = new DevComponents.DotNetBar.ButtonItem();
            this.Menu_DC_XB_3Md = new DevComponents.DotNetBar.RibbonBar();
            this.btn3MdParamIn = new DevComponents.DotNetBar.ButtonItem();
            this.btn3MdOrder = new DevComponents.DotNetBar.ButtonItem();
            this.btn3MdResult = new DevComponents.DotNetBar.ButtonItem();
            this.ribPnlMainLoop = new DevComponents.DotNetBar.RibbonPanel();
            this.ribGrpMainLoop = new DevComponents.DotNetBar.RibbonBar();
            this.btnMcParam = new DevComponents.DotNetBar.ButtonItem();
            this.btnMcOrder = new DevComponents.DotNetBar.ButtonItem();
            this.btnMcResult = new DevComponents.DotNetBar.ButtonItem();
            this.ribPnlPrjManage = new DevComponents.DotNetBar.RibbonPanel();
            this.ribBarPrj = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonFile = new DevComponents.DotNetBar.Office2007StartButton();
            this.btnNewPro = new DevComponents.DotNetBar.ButtonItem();
            this.btnOpenPro = new DevComponents.DotNetBar.ButtonItem();
            this.btnSavePro = new DevComponents.DotNetBar.ButtonItem();
            this.btnClosePro = new DevComponents.DotNetBar.ButtonItem();
            this.btmExit = new DevComponents.DotNetBar.ButtonItem();
            this.ribTabPrjManage = new DevComponents.DotNetBar.RibbonTabItem();
            this.Menu_Main_Loop = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribTagDcXbEc = new DevComponents.DotNetBar.RibbonTabItem();
            this.buttonChangeStyle = new DevComponents.DotNetBar.ButtonItem();
            this.buttonStyleOffice2010Silver = new DevComponents.DotNetBar.ButtonItem();
            this.buttonSave = new DevComponents.DotNetBar.ButtonItem();
            this.buttonUndo = new DevComponents.DotNetBar.ButtonItem();
            this.buttonStyleOffice2010Blue = new DevComponents.DotNetBar.ButtonItem();
            this.applicationButton1 = new DevComponents.DotNetBar.ApplicationButton();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem5 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem6 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem7 = new DevComponents.DotNetBar.ButtonItem();
            this.galleryContainer1 = new DevComponents.DotNetBar.GalleryContainer();
            this.labelItem8 = new DevComponents.DotNetBar.LabelItem();
            this.buttonItem8 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem9 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem10 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem11 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer4 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem12 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem13 = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.grpBoxTree.SuspendLayout();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.ribPnlMainLoop.SuspendLayout();
            this.ribPnlPrjManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.AccessibleDescription = "DotNetBar Bar (bar1)";
            this.bar1.AccessibleName = "DotNetBar Bar";
            this.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.bar1.AntiAlias = true;
            this.bar1.BarType = DevComponents.DotNetBar.eBarType.StatusBar;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bar1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar1.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.ResizeHandle;
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelStatus,
            this.progressBarItem1});
            this.bar1.ItemSpacing = 2;
            this.bar1.Location = new System.Drawing.Point(5, 697);
            this.bar1.Name = "bar1";
            this.bar1.PaddingBottom = 0;
            this.bar1.PaddingTop = 0;
            this.bar1.Size = new System.Drawing.Size(1340, 31);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 7;
            this.bar1.TabStop = false;
            this.bar1.Text = "barStatus";
            // 
            // labelStatus
            // 
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.PaddingLeft = 2;
            this.labelStatus.PaddingRight = 2;
            this.labelStatus.SingleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.labelStatus.Stretch = true;
            // 
            // progressBarItem1
            // 
            // 
            // 
            // 
            this.progressBarItem1.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarItem1.ChunkGradientAngle = 0F;
            this.progressBarItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.progressBarItem1.Name = "progressBarItem1";
            this.progressBarItem1.RecentlyUsed = false;
            // 
            // labelPosition
            // 
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.PaddingLeft = 2;
            this.labelPosition.PaddingRight = 2;
            this.labelPosition.SingleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.labelPosition.Width = 100;
            // 
            // AppCommandTheme
            // 
            this.AppCommandTheme.Name = "AppCommandTheme";
            this.AppCommandTheme.Executed += new System.EventHandler(this.AppCommandTheme_Executed);
            // 
            // AppCommandSave
            // 
            this.AppCommandSave.Name = "AppCommandSave";
            // 
            // buttonStyleCustom
            // 
            this.buttonStyleCustom.BeginGroup = true;
            this.buttonStyleCustom.Command = this.AppCommandTheme;
            this.buttonStyleCustom.Name = "buttonStyleCustom";
            this.buttonStyleCustom.Text = "Custom scheme";
            this.buttonStyleCustom.Tooltip = "Custom color scheme is created based on currently selected color table. Try selec" +
    "ting Silver or Blue color table and then creating custom color scheme.";
            this.buttonStyleCustom.SelectedColorChanged += new System.EventHandler(this.buttonStyleCustom_SelectedColorChanged);
            this.buttonStyleCustom.ColorPreview += new DevComponents.DotNetBar.ColorPreviewEventHandler(this.buttonStyleCustom_ColorPreview);
            this.buttonStyleCustom.ExpandChange += new System.EventHandler(this.buttonStyleCustom_ExpandChange);
            // 
            // RibbonStateCommand
            // 
            this.RibbonStateCommand.Name = "RibbonStateCommand";
            this.RibbonStateCommand.Executed += new System.EventHandler(this.RibbonStateCommand_Executed);
            // 
            // progressBarTimer
            // 
            this.progressBarTimer.Enabled = true;
            this.progressBarTimer.Interval = 800;
            this.progressBarTimer.Tick += new System.EventHandler(this.progressBarTimer_Tick);
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Silver;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // grpBoxTree
            // 
            this.grpBoxTree.Controls.Add(this.treeView);
            this.grpBoxTree.Location = new System.Drawing.Point(8, 158);
            this.grpBoxTree.Name = "grpBoxTree";
            this.grpBoxTree.Size = new System.Drawing.Size(210, 545);
            this.grpBoxTree.TabIndex = 15;
            this.grpBoxTree.TabStop = false;
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.SystemColors.Window;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Font = new System.Drawing.Font("Segoe UI", 7.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList;
            this.treeView.Indent = 23;
            this.treeView.ItemHeight = 18;
            this.treeView.Location = new System.Drawing.Point(3, 29);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(204, 513);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "node.png");
            this.imageList.Images.SetKeyName(1, "leaf.png");
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Location = new System.Drawing.Point(221, 158);
            this.pnlMain.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1124, 545);
            this.pnlMain.TabIndex = 16;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.BackColor = System.Drawing.SystemColors.Control;
            this.ribbonControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ribbonControl1.BackgroundImage")));
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribPnlPrjManage);
            this.ribbonControl1.Controls.Add(this.ribPnlMainLoop);
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl1.ForeColor = System.Drawing.Color.Black;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonFile,
            this.ribTabPrjManage,
            this.Menu_Main_Loop,
            this.ribTagDcXbEc,
            this.buttonChangeStyle});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl1.Location = new System.Drawing.Point(5, 1);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ribbonControl1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonSave,
            this.buttonUndo});
            this.ribbonControl1.RibbonStripFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl1.Size = new System.Drawing.Size(1340, 154);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl1.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 8;
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.Menu_DC_LBQ_ZK);
            this.ribbonPanel1.Controls.Add(this.ribDcLineParam);
            this.ribbonPanel1.Controls.Add(this.ribBarDcLbq);
            this.ribbonPanel1.Controls.Add(this.Menu_DC_XB_3Md);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 68);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(1340, 83);
            // 
            // 
            // 
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 5;
            this.ribbonPanel1.Visible = false;
            // 
            // Menu_DC_LBQ_ZK
            // 
            this.Menu_DC_LBQ_ZK.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.Menu_DC_LBQ_ZK.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.Menu_DC_LBQ_ZK.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Menu_DC_LBQ_ZK.ContainerControlProcessDialogKey = true;
            this.Menu_DC_LBQ_ZK.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu_DC_LBQ_ZK.DragDropSupport = true;
            this.Menu_DC_LBQ_ZK.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_DC_LBQ_ZK.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnZkScanParamIn,
            this.btnDcZkScanOrder,
            this.btnDcZkScanResult});
            this.Menu_DC_LBQ_ZK.Location = new System.Drawing.Point(662, 0);
            this.Menu_DC_LBQ_ZK.Name = "Menu_DC_LBQ_ZK";
            this.Menu_DC_LBQ_ZK.Size = new System.Drawing.Size(189, 80);
            this.Menu_DC_LBQ_ZK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Menu_DC_LBQ_ZK.TabIndex = 3;
            this.Menu_DC_LBQ_ZK.Text = "阻抗谐振扫描";
            // 
            // 
            // 
            this.Menu_DC_LBQ_ZK.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.Menu_DC_LBQ_ZK.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnZkScanParamIn
            // 
            this.btnZkScanParamIn.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnZkScanParamIn.Image = global::cn.csg.dpcp.ui.Properties.Resources.input;
            this.btnZkScanParamIn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnZkScanParamIn.Name = "btnZkScanParamIn";
            this.btnZkScanParamIn.SubItemsExpandWidth = 14;
            this.btnZkScanParamIn.Tag = "阻抗谐振扫描";
            this.btnZkScanParamIn.Text = "参数录入";
            this.btnZkScanParamIn.Click += new System.EventHandler(this.btnZkScanParamIn_Click);
            // 
            // btnDcZkScanOrder
            // 
            this.btnDcZkScanOrder.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDcZkScanOrder.Image = global::cn.csg.dpcp.ui.Properties.Resources.calculate;
            this.btnDcZkScanOrder.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDcZkScanOrder.Name = "btnDcZkScanOrder";
            this.btnDcZkScanOrder.SubItemsExpandWidth = 14;
            this.btnDcZkScanOrder.Tag = "阻抗谐振扫描";
            this.btnDcZkScanOrder.Text = "工况计算";
            this.btnDcZkScanOrder.Click += new System.EventHandler(this.btnDcZkScanOrder_Click);
            // 
            // btnDcZkScanResult
            // 
            this.btnDcZkScanResult.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDcZkScanResult.Image = global::cn.csg.dpcp.ui.Properties.Resources.process;
            this.btnDcZkScanResult.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDcZkScanResult.Name = "btnDcZkScanResult";
            this.btnDcZkScanResult.SubItemsExpandWidth = 14;
            this.btnDcZkScanResult.Tag = "阻抗谐振扫描";
            this.btnDcZkScanResult.Text = "结果处理";
            this.btnDcZkScanResult.Click += new System.EventHandler(this.btnDcZkScanResult_Click);
            // 
            // ribDcLineParam
            // 
            this.ribDcLineParam.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribDcLineParam.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribDcLineParam.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribDcLineParam.ContainerControlProcessDialogKey = true;
            this.ribDcLineParam.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribDcLineParam.DragDropSupport = true;
            this.ribDcLineParam.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribDcLineParam.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDcLineParamMenu,
            this.btnDcLineParamOrder,
            this.btnDcLineResult});
            this.ribDcLineParam.Location = new System.Drawing.Point(473, 0);
            this.ribDcLineParam.Name = "ribDcLineParam";
            this.ribDcLineParam.Size = new System.Drawing.Size(189, 80);
            this.ribDcLineParam.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribDcLineParam.TabIndex = 2;
            this.ribDcLineParam.Text = "直流线路参数计算";
            // 
            // 
            // 
            this.ribDcLineParam.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribDcLineParam.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnDcLineParamMenu
            // 
            this.btnDcLineParamMenu.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDcLineParamMenu.Image = global::cn.csg.dpcp.ui.Properties.Resources.input;
            this.btnDcLineParamMenu.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDcLineParamMenu.Name = "btnDcLineParamMenu";
            this.btnDcLineParamMenu.SubItemsExpandWidth = 14;
            this.btnDcLineParamMenu.Tag = "直流线路参数计算";
            this.btnDcLineParamMenu.Text = "参数录入";
            this.btnDcLineParamMenu.Click += new System.EventHandler(this.btnDcLineParamIn_Click);
            // 
            // btnDcLineParamOrder
            // 
            this.btnDcLineParamOrder.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDcLineParamOrder.Image = global::cn.csg.dpcp.ui.Properties.Resources.calculate;
            this.btnDcLineParamOrder.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDcLineParamOrder.Name = "btnDcLineParamOrder";
            this.btnDcLineParamOrder.SubItemsExpandWidth = 14;
            this.btnDcLineParamOrder.Tag = "直流线路参数计算";
            this.btnDcLineParamOrder.Text = "工况计算";
            // 
            // btnDcLineResult
            // 
            this.btnDcLineResult.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDcLineResult.Image = global::cn.csg.dpcp.ui.Properties.Resources.process;
            this.btnDcLineResult.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDcLineResult.Name = "btnDcLineResult";
            this.btnDcLineResult.SubItemsExpandWidth = 14;
            this.btnDcLineResult.Tag = "直流线路参数计算";
            this.btnDcLineResult.Text = "结果处理";
            // 
            // ribBarDcLbq
            // 
            this.ribBarDcLbq.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribBarDcLbq.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribBarDcLbq.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribBarDcLbq.ContainerControlProcessDialogKey = true;
            this.ribBarDcLbq.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribBarDcLbq.DragDropSupport = true;
            this.ribBarDcLbq.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribBarDcLbq.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDcLbqSingle,
            this.btnDcLbqDouble,
            this.btnDcLbqParamIn,
            this.btnDcLbqOrder,
            this.btnDcLbqResult});
            this.ribBarDcLbq.Location = new System.Drawing.Point(192, 0);
            this.ribBarDcLbq.Name = "ribBarDcLbq";
            this.ribBarDcLbq.Size = new System.Drawing.Size(281, 80);
            this.ribBarDcLbq.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribBarDcLbq.TabIndex = 1;
            this.ribBarDcLbq.Text = "直流侧谐波器设计";
            // 
            // 
            // 
            this.ribBarDcLbq.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribBarDcLbq.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnDcLbqSingle
            // 
            this.btnDcLbqSingle.Name = "btnDcLbqSingle";
            this.btnDcLbqSingle.SubItemsExpandWidth = 14;
            this.btnDcLbqSingle.Tag = "直流侧谐波器设计";
            this.btnDcLbqSingle.Text = "单回线";
            this.btnDcLbqSingle.Click += new System.EventHandler(this.btnDcLbqSingle_Click);
            // 
            // btnDcLbqDouble
            // 
            this.btnDcLbqDouble.Name = "btnDcLbqDouble";
            this.btnDcLbqDouble.SubItemsExpandWidth = 14;
            this.btnDcLbqDouble.Tag = "直流侧谐波器设计";
            this.btnDcLbqDouble.Text = "双回线";
            this.btnDcLbqDouble.Click += new System.EventHandler(this.btnDcLbqDouble_Click);
            // 
            // btnDcLbqParamIn
            // 
            this.btnDcLbqParamIn.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDcLbqParamIn.Image = global::cn.csg.dpcp.ui.Properties.Resources.input;
            this.btnDcLbqParamIn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDcLbqParamIn.Name = "btnDcLbqParamIn";
            this.btnDcLbqParamIn.SubItemsExpandWidth = 14;
            this.btnDcLbqParamIn.Tag = "直流侧谐波器设计";
            this.btnDcLbqParamIn.Text = "参数录入";
            this.btnDcLbqParamIn.Click += new System.EventHandler(this.btnDcLbqParamIn_Click);
            // 
            // btnDcLbqOrder
            // 
            this.btnDcLbqOrder.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDcLbqOrder.Image = global::cn.csg.dpcp.ui.Properties.Resources.calculate;
            this.btnDcLbqOrder.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDcLbqOrder.Name = "btnDcLbqOrder";
            this.btnDcLbqOrder.SubItemsExpandWidth = 14;
            this.btnDcLbqOrder.Tag = "直流侧谐波器设计";
            this.btnDcLbqOrder.Text = "工况计算";
            this.btnDcLbqOrder.Click += new System.EventHandler(this.btnDcLbqOrder_Click);
            // 
            // btnDcLbqResult
            // 
            this.btnDcLbqResult.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDcLbqResult.Image = global::cn.csg.dpcp.ui.Properties.Resources.process;
            this.btnDcLbqResult.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDcLbqResult.Name = "btnDcLbqResult";
            this.btnDcLbqResult.SubItemsExpandWidth = 14;
            this.btnDcLbqResult.Tag = "直流侧谐波器设计";
            this.btnDcLbqResult.Text = "结果处理";
            this.btnDcLbqResult.Click += new System.EventHandler(this.btnDcLbqResult_Click);
            // 
            // Menu_DC_XB_3Md
            // 
            this.Menu_DC_XB_3Md.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.Menu_DC_XB_3Md.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.Menu_DC_XB_3Md.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Menu_DC_XB_3Md.ContainerControlProcessDialogKey = true;
            this.Menu_DC_XB_3Md.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu_DC_XB_3Md.DragDropSupport = true;
            this.Menu_DC_XB_3Md.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_DC_XB_3Md.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn3MdParamIn,
            this.btn3MdOrder,
            this.btn3MdResult});
            this.Menu_DC_XB_3Md.Location = new System.Drawing.Point(3, 0);
            this.Menu_DC_XB_3Md.Name = "Menu_DC_XB_3Md";
            this.Menu_DC_XB_3Md.Size = new System.Drawing.Size(189, 80);
            this.Menu_DC_XB_3Md.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Menu_DC_XB_3Md.TabIndex = 0;
            this.Menu_DC_XB_3Md.Text = "三脉动谐波电压源计算";
            // 
            // 
            // 
            this.Menu_DC_XB_3Md.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.Menu_DC_XB_3Md.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btn3MdParamIn
            // 
            this.btn3MdParamIn.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn3MdParamIn.Image = global::cn.csg.dpcp.ui.Properties.Resources.input;
            this.btn3MdParamIn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn3MdParamIn.Name = "btn3MdParamIn";
            this.btn3MdParamIn.SubItemsExpandWidth = 14;
            this.btn3MdParamIn.Tag = "三脉动谐波电压源计算";
            this.btn3MdParamIn.Text = "参数录入";
            this.btn3MdParamIn.Click += new System.EventHandler(this.btn3MdParamIn_Click);
            // 
            // btn3MdOrder
            // 
            this.btn3MdOrder.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn3MdOrder.Image = global::cn.csg.dpcp.ui.Properties.Resources.calculate;
            this.btn3MdOrder.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn3MdOrder.Name = "btn3MdOrder";
            this.btn3MdOrder.SubItemsExpandWidth = 14;
            this.btn3MdOrder.Tag = "三脉动谐波电压源计算";
            this.btn3MdOrder.Text = "工况计算";
            this.btn3MdOrder.Click += new System.EventHandler(this.btn3MdOrder_Click);
            // 
            // btn3MdResult
            // 
            this.btn3MdResult.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn3MdResult.Image = global::cn.csg.dpcp.ui.Properties.Resources.process;
            this.btn3MdResult.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn3MdResult.Name = "btn3MdResult";
            this.btn3MdResult.SubItemsExpandWidth = 14;
            this.btn3MdResult.Tag = "三脉动谐波电压源计算";
            this.btn3MdResult.Text = "结果处理";
            this.btn3MdResult.Click += new System.EventHandler(this.btn3MdResult_Click);
            // 
            // ribPnlMainLoop
            // 
            this.ribPnlMainLoop.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribPnlMainLoop.Controls.Add(this.ribGrpMainLoop);
            this.ribPnlMainLoop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribPnlMainLoop.Location = new System.Drawing.Point(0, 68);
            this.ribPnlMainLoop.Name = "ribPnlMainLoop";
            this.ribPnlMainLoop.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribPnlMainLoop.Size = new System.Drawing.Size(1340, 83);
            // 
            // 
            // 
            this.ribPnlMainLoop.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribPnlMainLoop.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribPnlMainLoop.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribPnlMainLoop.TabIndex = 4;
            this.ribPnlMainLoop.Visible = false;
            // 
            // ribGrpMainLoop
            // 
            this.ribGrpMainLoop.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribGrpMainLoop.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribGrpMainLoop.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribGrpMainLoop.ContainerControlProcessDialogKey = true;
            this.ribGrpMainLoop.DragDropSupport = true;
            this.ribGrpMainLoop.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribGrpMainLoop.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMcParam,
            this.btnMcOrder,
            this.btnMcResult});
            this.ribGrpMainLoop.Location = new System.Drawing.Point(3, 0);
            this.ribGrpMainLoop.Name = "ribGrpMainLoop";
            this.ribGrpMainLoop.Size = new System.Drawing.Size(189, 93);
            this.ribGrpMainLoop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribGrpMainLoop.TabIndex = 0;
            this.ribGrpMainLoop.Text = "主回路状态计算";
            // 
            // 
            // 
            this.ribGrpMainLoop.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribGrpMainLoop.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnMcParam
            // 
            this.btnMcParam.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnMcParam.Image = global::cn.csg.dpcp.ui.Properties.Resources.input;
            this.btnMcParam.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnMcParam.Name = "btnMcParam";
            this.btnMcParam.RibbonWordWrap = false;
            this.btnMcParam.Tag = "主回路状态计算";
            this.btnMcParam.Text = "参数输入";
            this.btnMcParam.Click += new System.EventHandler(this.btnParamIn4MainLoop_Click);
            // 
            // btnMcOrder
            // 
            this.btnMcOrder.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnMcOrder.Image = global::cn.csg.dpcp.ui.Properties.Resources.calculate;
            this.btnMcOrder.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnMcOrder.Name = "btnMcOrder";
            this.btnMcOrder.RibbonWordWrap = false;
            this.btnMcOrder.Tag = "主回路状态计算";
            this.btnMcOrder.Text = "工况计算";
            this.btnMcOrder.Click += new System.EventHandler(this.btnCalc4MainLoop_Click);
            // 
            // btnMcResult
            // 
            this.btnMcResult.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnMcResult.Image = global::cn.csg.dpcp.ui.Properties.Resources.process;
            this.btnMcResult.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnMcResult.Name = "btnMcResult";
            this.btnMcResult.RibbonWordWrap = false;
            this.btnMcResult.Tag = "主回路状态计算";
            this.btnMcResult.Text = "结果处理";
            this.btnMcResult.Click += new System.EventHandler(this.btnProcess4MainLoop_Click);
            // 
            // ribPnlPrjManage
            // 
            this.ribPnlPrjManage.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribPnlPrjManage.Controls.Add(this.ribBarPrj);
            this.ribPnlPrjManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribPnlPrjManage.Location = new System.Drawing.Point(0, 68);
            this.ribPnlPrjManage.Name = "ribPnlPrjManage";
            this.ribPnlPrjManage.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribPnlPrjManage.Size = new System.Drawing.Size(1340, 83);
            // 
            // 
            // 
            this.ribPnlPrjManage.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribPnlPrjManage.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribPnlPrjManage.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribPnlPrjManage.TabIndex = 1;
            // 
            // ribBarPrj
            // 
            this.ribBarPrj.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribBarPrj.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribBarPrj.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribBarPrj.ContainerControlProcessDialogKey = true;
            this.ribBarPrj.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribBarPrj.DragDropSupport = true;
            this.ribBarPrj.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribBarPrj.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.buttonItem2,
            this.buttonItem3});
            this.ribBarPrj.Location = new System.Drawing.Point(3, 0);
            this.ribBarPrj.Name = "ribBarPrj";
            this.ribBarPrj.Size = new System.Drawing.Size(189, 80);
            this.ribBarPrj.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribBarPrj.TabIndex = 5;
            this.ribBarPrj.Text = "工程管理";
            // 
            // 
            // 
            this.ribBarPrj.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribBarPrj.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem1
            // 
            this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem1.Image = global::cn.csg.dpcp.ui.Properties.Resources.input;
            this.buttonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.RibbonWordWrap = false;
            this.buttonItem1.Text = "参数输入";
            // 
            // buttonItem2
            // 
            this.buttonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem2.Image = global::cn.csg.dpcp.ui.Properties.Resources.calculate;
            this.buttonItem2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.RibbonWordWrap = false;
            this.buttonItem2.SubItemsExpandWidth = 24;
            this.buttonItem2.Text = "工况计算";
            // 
            // buttonItem3
            // 
            this.buttonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem3.Image = global::cn.csg.dpcp.ui.Properties.Resources.process;
            this.buttonItem3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.RibbonWordWrap = false;
            this.buttonItem3.SubItemsExpandWidth = 24;
            this.buttonItem3.Text = "结果处理";
            // 
            // buttonFile
            // 
            this.buttonFile.CanCustomize = false;
            this.buttonFile.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.buttonFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonFile.Image")));
            this.buttonFile.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.buttonFile.ImagePaddingHorizontal = 0;
            this.buttonFile.ImagePaddingVertical = 0;
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnNewPro,
            this.btnOpenPro,
            this.btnSavePro,
            this.btnClosePro,
            this.btmExit});
            this.buttonFile.Text = "&工程";
            // 
            // btnNewPro
            // 
            this.btnNewPro.Name = "btnNewPro";
            this.btnNewPro.Text = "新建工程";
            this.btnNewPro.Click += new System.EventHandler(this.btnNewPro_Click);
            // 
            // btnOpenPro
            // 
            this.btnOpenPro.Name = "btnOpenPro";
            this.btnOpenPro.Text = "打开工程";
            this.btnOpenPro.Click += new System.EventHandler(this.btnOpenPro_Click);
            // 
            // btnSavePro
            // 
            this.btnSavePro.Name = "btnSavePro";
            this.btnSavePro.Text = "保存工程";
            this.btnSavePro.Click += new System.EventHandler(this.btnSavePro_Click);
            // 
            // btnClosePro
            // 
            this.btnClosePro.Name = "btnClosePro";
            this.btnClosePro.Text = "关闭工程";
            this.btnClosePro.Click += new System.EventHandler(this.btnClosePro_Click);
            // 
            // btmExit
            // 
            this.btmExit.Name = "btmExit";
            this.btmExit.Text = "退出程序";
            this.btmExit.Click += new System.EventHandler(this.btmExit_Click);
            // 
            // ribTabPrjManage
            // 
            this.ribTabPrjManage.Checked = true;
            this.ribTabPrjManage.Name = "ribTabPrjManage";
            this.ribTabPrjManage.Panel = this.ribPnlPrjManage;
            this.ribTabPrjManage.Text = "工程管理";
            // 
            // Menu_Main_Loop
            // 
            this.Menu_Main_Loop.ColorTable = DevComponents.DotNetBar.eRibbonTabColor.Orange;
            this.Menu_Main_Loop.Name = "Menu_Main_Loop";
            this.Menu_Main_Loop.Panel = this.ribPnlMainLoop;
            this.Menu_Main_Loop.Text = "主回路状态计算";
            // 
            // ribTagDcXbEc
            // 
            this.ribTagDcXbEc.Name = "ribTagDcXbEc";
            this.ribTagDcXbEc.Panel = this.ribbonPanel1;
            this.ribTagDcXbEc.Text = "直流侧谐波电流与设计";
            // 
            // buttonChangeStyle
            // 
            this.buttonChangeStyle.AutoExpandOnClick = true;
            this.buttonChangeStyle.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.buttonChangeStyle.Name = "buttonChangeStyle";
            this.buttonChangeStyle.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonStyleOffice2010Silver});
            this.buttonChangeStyle.Text = "Style";
            // 
            // buttonStyleOffice2010Silver
            // 
            this.buttonStyleOffice2010Silver.Command = this.AppCommandTheme;
            this.buttonStyleOffice2010Silver.CommandParameter = "Office2010Silver";
            this.buttonStyleOffice2010Silver.Name = "buttonStyleOffice2010Silver";
            this.buttonStyleOffice2010Silver.OptionGroup = "style";
            this.buttonStyleOffice2010Silver.Text = "Office 2010 <font color=\"Silver\"><b>Silver</b></font>";
            // 
            // buttonSave
            // 
            this.buttonSave.Command = this.AppCommandSave;
            this.buttonSave.Enabled = false;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Text = "buttonItem2";
            // 
            // buttonUndo
            // 
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Text = "Undo";
            // 
            // buttonStyleOffice2010Blue
            // 
            this.buttonStyleOffice2010Blue.Command = this.AppCommandTheme;
            this.buttonStyleOffice2010Blue.CommandParameter = "Office2010Blue";
            this.buttonStyleOffice2010Blue.Name = "buttonStyleOffice2010Blue";
            this.buttonStyleOffice2010Blue.OptionGroup = "style";
            this.buttonStyleOffice2010Blue.Text = "Office 2010 <font color=\"Blue\"><b>Blue</b></font>";
            // 
            // applicationButton1
            // 
            this.applicationButton1.AutoExpandOnClick = true;
            this.applicationButton1.CanCustomize = false;
            this.applicationButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.applicationButton1.Image = ((System.Drawing.Image)(resources.GetObject("applicationButton1.Image")));
            this.applicationButton1.ImagePaddingHorizontal = 2;
            this.applicationButton1.ImagePaddingVertical = 2;
            this.applicationButton1.Name = "applicationButton1";
            this.applicationButton1.ShowSubItems = false;
            this.applicationButton1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.applicationButton1.Text = "&File";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer2,
            this.itemContainer4});
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer";
            this.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.ItemSpacing = 0;
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer3,
            this.galleryContainer1});
            // 
            // 
            // 
            this.itemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemContainer3
            // 
            // 
            // 
            // 
            this.itemContainer3.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.itemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer3.MinimumSize = new System.Drawing.Size(120, 0);
            this.itemContainer3.Name = "itemContainer3";
            this.itemContainer3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem4,
            this.buttonItem5,
            this.buttonItem6,
            this.buttonItem7});
            // 
            // 
            // 
            this.itemContainer3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem4
            // 
            this.buttonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem4.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem4.Image")));
            this.buttonItem4.Name = "buttonItem4";
            this.buttonItem4.SubItemsExpandWidth = 24;
            this.buttonItem4.Text = "&Save...";
            // 
            // buttonItem5
            // 
            this.buttonItem5.BeginGroup = true;
            this.buttonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem5.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem5.Image")));
            this.buttonItem5.Name = "buttonItem5";
            this.buttonItem5.SubItemsExpandWidth = 24;
            this.buttonItem5.Text = "S&hare...";
            // 
            // buttonItem6
            // 
            this.buttonItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem6.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem6.Image")));
            this.buttonItem6.Name = "buttonItem6";
            this.buttonItem6.SubItemsExpandWidth = 24;
            this.buttonItem6.Text = "&Print...";
            // 
            // buttonItem7
            // 
            this.buttonItem7.BeginGroup = true;
            this.buttonItem7.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem7.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem7.Image")));
            this.buttonItem7.Name = "buttonItem7";
            this.buttonItem7.SubItemsExpandWidth = 24;
            this.buttonItem7.Text = "&Close";
            // 
            // galleryContainer1
            // 
            // 
            // 
            // 
            this.galleryContainer1.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer";
            this.galleryContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.galleryContainer1.EnableGalleryPopup = false;
            this.galleryContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.galleryContainer1.MinimumSize = new System.Drawing.Size(180, 240);
            this.galleryContainer1.MultiLine = false;
            this.galleryContainer1.Name = "galleryContainer1";
            this.galleryContainer1.PopupUsesStandardScrollbars = false;
            this.galleryContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem8,
            this.buttonItem8,
            this.buttonItem9,
            this.buttonItem10,
            this.buttonItem11});
            // 
            // 
            // 
            this.galleryContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // labelItem8
            // 
            this.labelItem8.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.labelItem8.BorderType = DevComponents.DotNetBar.eBorderType.Etched;
            this.labelItem8.CanCustomize = false;
            this.labelItem8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelItem8.Name = "labelItem8";
            this.labelItem8.PaddingBottom = 2;
            this.labelItem8.PaddingTop = 2;
            this.labelItem8.Stretch = true;
            this.labelItem8.Text = "Recent Documents";
            // 
            // buttonItem8
            // 
            this.buttonItem8.Name = "buttonItem8";
            this.buttonItem8.Text = "&1. Short News 5-7.rtf";
            // 
            // buttonItem9
            // 
            this.buttonItem9.Name = "buttonItem9";
            this.buttonItem9.Text = "&2. Prospect Email.rtf";
            // 
            // buttonItem10
            // 
            this.buttonItem10.Name = "buttonItem10";
            this.buttonItem10.Text = "&3. Customer Email.rtf";
            // 
            // buttonItem11
            // 
            this.buttonItem11.Name = "buttonItem11";
            this.buttonItem11.Text = "&4. example.rtf";
            // 
            // itemContainer4
            // 
            // 
            // 
            // 
            this.itemContainer4.BackgroundStyle.Class = "RibbonFileMenuBottomContainer";
            this.itemContainer4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer4.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.itemContainer4.Name = "itemContainer4";
            this.itemContainer4.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem12,
            this.buttonItem13});
            // 
            // 
            // 
            this.itemContainer4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem12
            // 
            this.buttonItem12.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem12.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonItem12.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem12.Image")));
            this.buttonItem12.Name = "buttonItem12";
            this.buttonItem12.SubItemsExpandWidth = 24;
            this.buttonItem12.Text = "Opt&ions";
            // 
            // buttonItem13
            // 
            this.buttonItem13.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem13.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonItem13.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem13.Image")));
            this.buttonItem13.Name = "buttonItem13";
            this.buttonItem13.SubItemsExpandWidth = 24;
            this.buttonItem13.Text = "E&xit";
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.grpBoxTree);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.bar1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(1, 1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DPCP SOFTWAVE";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmMain_Closing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.grpBoxTree.ResumeLayout(false);
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.ribPnlMainLoop.ResumeLayout(false);
            this.ribPnlPrjManage.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private void AppCommandTheme_Executed(object sender, EventArgs e)
        {
            ICommandSource source = sender as ICommandSource;
            if (source.CommandParameter is string)
            {
                eStyle style = (eStyle)Enum.Parse(typeof(eStyle), source.CommandParameter.ToString());
                // Using StyleManager change the style and color tinting
                if (StyleManager.IsMetro(style))
                {
                    // More customization is needed for Metro
                    // Capitalize App Button and tab
                    buttonFile.Text = buttonFile.Text.ToUpper();
                    foreach (BaseItem item in RibbonControl.Items)
                    {
                        // Ribbon Control may contain items other than tabs so that needs to be taken in account
                        RibbonTabItem tab = item as RibbonTabItem;
                        if (tab != null)
                            tab.Text = tab.Text.ToUpper();
                    }

                    buttonFile.BackstageTabEnabled = true; // Use Backstage for Metro

                    ribbonControl1.RibbonStripFont = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    if (style == eStyle.Metro)
                        StyleManager.MetroColorGeneratorParameters = DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters.DarkBlue;

                    // Adjust size of switch button to match Metro styling
                    //switchButtonItem1.SwitchWidth = 16;
                    //switchButtonItem1.ButtonWidth = 48;
                    //switchButtonItem1.ButtonHeight = 19;

                    // Adjust tab strip style
                    //tabStrip1.Style = eTabStripStyle.Metro;
                    StyleManager.Style = style; // BOOM
                }
                else
                {
                    // If previous style was Metro we need to update other properties as well
                    if (StyleManager.IsMetro(StyleManager.Style))
                    {
                        ribbonControl1.RibbonStripFont = null;
                        // Fix capitalization App Button and tab
                        //buttonFile.Text = ToTitleCase(buttonFile.Text);
                        foreach (BaseItem item in RibbonControl.Items)
                        {
                            // Ribbon Control may contain items other than tabs so that needs to be taken in account
                            RibbonTabItem tab = item as RibbonTabItem;
                            if (tab != null)
                            {

                            }
                        }
                    }
                    // Adjust tab strip style
                    //tabStrip1.Style = eTabStripStyle.Office2007Document;
                    StyleManager.ChangeStyle(style, Color.Empty);
                    if (style == eStyle.Office2007Blue || style == eStyle.Office2007Silver || style == eStyle.Office2010Blue)
                        buttonFile.BackstageTabEnabled = false;
                    else
                        buttonFile.BackstageTabEnabled = true;
                }
            }
            else if (source.CommandParameter is Color)
            {
                if (StyleManager.IsMetro(StyleManager.Style))
                    StyleManager.MetroColorGeneratorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(Color.White, (Color)source.CommandParameter);
                else
                    StyleManager.ColorTint = (Color)source.CommandParameter;
            }
        }


        

        private void buttonStyleCustom_SelectedColorChanged(object sender, System.EventArgs e)
        {
            m_ColorSelected = true; // Indicate that color was selected for buttonStyleCustom_ExpandChange method
            buttonStyleCustom.CommandParameter = buttonStyleCustom.SelectedColor;
        }

        void ButtonNotifyClick(object sender, EventArgs e)
        {
            MessageBoxEx.Show("Example of how to add a button to ribbon caption. See Form.Load event for example code.");
        }



        private void LaunchRibbonDialog(object sender, System.EventArgs e)
        {
            MessageBoxEx.Show("Start <i>Ribbon Dialog</i> with more options here...", "Ribbon Demo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void frmMain_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Save Quick Access Toolbar layout if it has changed...
            if (ribbonControl1.QatLayoutChanged)
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\DevComponents\Ribbon");
                try
                {
                    key.SetValue("RibbonPadCSLayout", ribbonControl1.QatLayout);
                }
                finally
                {
                    key.Close();
                }
            }
        }

        private void progressBarTimer_Tick(object sender, System.EventArgs e)
        {
            if (progressBarItem1.Value >= progressBarItem1.Maximum)
            {
                progressBarTimer.Stop();
                progressBarItem1.Value = 50;
            }
            else
                progressBarItem1.Value += 4;
        }

        private bool m_ColorSelected = false;
        private eStyle m_BaseStyle = eStyle.Office2010Silver;
        private void buttonStyleCustom_ExpandChange(object sender, System.EventArgs e)
        {
            if (buttonStyleCustom.Expanded)
            {
                // Remember the starting color scheme to apply if no color is selected during live-preview
                m_ColorSelected = false;
                m_BaseStyle = StyleManager.Style;
            }
            else
            {
                if (!m_ColorSelected)
                {
                    if (StyleManager.IsMetro(StyleManager.Style))
                        StyleManager.MetroColorGeneratorParameters = DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters.Default;
                    else
                        StyleManager.ChangeStyle(m_BaseStyle, Color.Empty);
                }
            }
        }

        private void buttonStyleCustom_ColorPreview(object sender, ColorPreviewEventArgs e)
        {
            if (StyleManager.IsMetro(StyleManager.Style))
            {
                Color baseColor = e.Color;
                StyleManager.MetroColorGeneratorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(Color.White, baseColor);
            }
            else
                StyleManager.ColorTint = e.Color;
        }

        private void RibbonStateCommand_Executed(object sender, EventArgs e)
        {
            ribbonControl1.Expanded = RibbonStateCommand.Checked;
            RibbonStateCommand.Checked = !RibbonStateCommand.Checked;
        }

        private RibbonTabItem Menu_Main_Loop;
        private RibbonBar Menu_DC_LBQ_ZK;
        private ButtonItem btnZkScanParamIn;
        private ButtonItem btnDcZkScanOrder;
        private ButtonItem btnDcZkScanResult;
        private RibbonBar ribDcLineParam;
        private ButtonItem btnDcLineParamMenu;
        private ButtonItem btnDcLineParamOrder;
        private ButtonItem btnDcLineResult;
        private RibbonBar ribBarDcLbq;
        private ButtonItem btnDcLbqParamIn;
        private ButtonItem btnDcLbqOrder;
        private ButtonItem btnDcLbqResult;
        private ButtonItem btnDcLbqSingle;
        private ButtonItem btnDcLbqDouble;
        private TreeView treeView;
        private ButtonItem btnClosePro;
        private ButtonItem btmExit;
        private Panel pnlMain;
    }
}
