using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cn.csg.dpcp.common;
using cn.csg.dpcp.ui.mc;
using Test1;
using cn.csg.dpcp.ui.xb;
using cn.csg.dpcp.ui.u3p;
using cn.csg.dpcp.ui.zk;

namespace cn.csg.dpcp.ui
{
    class CPanelHelper
    {
        private IDictionary<string, DpcpBaseForm> uiMap = new Dictionary<string, DpcpBaseForm>();

        public CPanelHelper()
        {
            #region 主回路
            uiMap.Add(Constants.MC_CAcSystem, new MCAcSystemUI());
            uiMap.Add(Constants.MC_CConvertor, new MCConvertorUI());
            uiMap.Add(Constants.MC_CTransformer, new MCTransformerUI());
            uiMap.Add(Constants.MC_Order, new MCOrderUI());
            uiMap.Add(Constants.MC_CDcMetalLine, new MCDcMetallLineUI());
            uiMap.Add(Constants.MC_CDcPole, new MCDcLineUI());
            uiMap.Add(Constants.MC_CAcFilter, new MCAcFilterUI());
            uiMap.Add(Constants.MC_CGroundLine, new MCCGroundLineUI());
            uiMap.Add(Constants.MC_CGround, new MCGroundUI());
            uiMap.Add(Constants.MC_CResult, new MCResultUI());
            uiMap.Add(Constants.MC_CDisplay, new MCDisplayUI());
            uiMap.Add(Constants.MCOrderUdCustomUI, new MCOrderUdCustomUI());
            #endregion

            #region 直流滤波设计
            uiMap.Add(Constants.CxbDcLineLbqSingleUI, new CxbSingleDcLineUI());
            uiMap.Add(Constants.CxbDcLineLbqGroundLineUI, new CxbSingleGroundLineUI());
            uiMap.Add(Constants.CxbDcLbqNetUI, new CxbDcLbqNetUI());
            uiMap.Add(Constants.XB_OrderUI, new CxbOrderUI());
            #endregion

            #region 3脉动
            uiMap.Add(Constants.C3MdSingleLoadUI, new C3pSingleLoadUI());
            uiMap.Add(Constants.C3MdMultLoadUI, new C3pMultLoadUI());
            uiMap.Add(Constants.C3pXf2UI, new C3pXf2UI());
            uiMap.Add(Constants.C3pConvertorUI, new C3pConvertorUI());
            uiMap.Add(Constants.C3MdSrcAlgOptionUI, new C3pSrcAlgOptionUI());
            uiMap.Add(Constants.C3MdSysDiffInUI, new C3pSysDiffInUI());
            uiMap.Add(Constants.C3pAcSysUIcs, new C3pAcSysUIcs());
            uiMap.Add(Constants.C3pOrderUI, new C3pOrderUI());           
            #endregion

            #region 阻抗
            uiMap.Add(Constants.CzkTxBaseUI, new CzkTxBaseUI());
            uiMap.Add(Constants.CzkNetParamUI, new CxbDcLbqNetUI()); // 共用网络参数界面
            uiMap.Add(Constants.CzkTransLineUI, new CxbSingleDcLineUI()); // 共用输电线界面
            uiMap.Add(Constants.CzkGroundLineUI, new CxbSingleGroundLineUI()); // 共用谐波接地极界面
            uiMap.Add(Constants.CzkOrderUI, new CzkOrderUI());
            #endregion

        }

        public IDictionary<string, DpcpBaseForm> UIMap
        {
            //set { uiMap = value; }
            get { return uiMap; }
        }

        public DpcpBaseForm TreeNodeChanged(string menuName, TreeView tree, TreeViewEventArgs e)
        {
            bool flag = uiMap.ContainsKey(e.Node.Name);
            return flag ? uiMap[e.Node.Name] : null;
        }
    }
}
