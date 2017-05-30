using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cn.csg.dpcp.common;
using cn.csg.dpcp.ui.mc;
using cn.csg.dpcp.ui.xb;
using cn.csg.dpcp.ui.u3p;
using cn.csg.dpcp.ui.zk;

namespace cn.csg.dpcp.ui
{
    class CPanelHelper
    {
        private IDictionary<string, CfmBaseFrom> uiMap = new Dictionary<string, CfmBaseFrom>();

        public CPanelHelper()
        {
            #region 主回路
            uiMap.Add(Constants.MC_CAcSystem, new CmcUIAcSystem());
            uiMap.Add(Constants.MC_CConvertor, new CmcUIConvertor());
            uiMap.Add(Constants.MC_CTransformer, new CmcUIXf2());
            uiMap.Add(Constants.MC_Order, new CmcUIOrder());
            uiMap.Add(Constants.MC_CDcMetalLine, new CmcUIMetalLine());
            uiMap.Add(Constants.MC_CDcPole, new CmcUIDCLine());
            uiMap.Add(Constants.MC_CAcFilter, new CmcUIAcFileter());
            uiMap.Add(Constants.MC_CGroundLine, new CmcUIGroundLine());
            uiMap.Add(Constants.MC_CGround, new CmcUIGround());
            uiMap.Add(Constants.MC_CResult, new CmcUIResult());
            uiMap.Add(Constants.MC_CDisplay, new MCDisplayUI());
            uiMap.Add(Constants.MCOrderUdCustomUI, new CmcUIUdCustom());
            #endregion

            #region 直流滤波设计
            uiMap.Add(Constants.CxbUIDCLine, new CxbUIDCLine());
            uiMap.Add(Constants.CxbUIGroundLine, new CxbUIGroundLine());
            uiMap.Add(Constants.CxbUIDevParam, new CxbUIDevParam());
            uiMap.Add(Constants.CxbUIOrder, new CxbUIOrder());
            uiMap.Add(Constants.CxbUIDataFromU3p, new CxbUIDataFromU3p());
            #endregion

            #region 3脉动
            //uiMap.Add(Constants.C3MdSingleLoadUI, new C3pSingleLoadUI());
            //uiMap.Add(Constants.C3MdMultLoadUI, new C3pMultLoadUI());
            uiMap.Add(Constants.C3pXf2UI, new C3pXf2UI());
            uiMap.Add(Constants.C3pConvertorUI, new C3pConvertorUI());
            //uiMap.Add(Constants.C3MdSrcAlgOptionUI, new C3pSrcAlgOptionUI());
            //uiMap.Add(Constants.C3MdSysDiffInUI, new C3pSysDiffInUI());
            uiMap.Add(Constants.C3pAcSysUIcs, new C3pAcSysUIcs());
            uiMap.Add(Constants.C3pOrderUI, new C3pOrderUI());
            uiMap.Add(Constants.U3p_DataFromuMcUI, new U3pDataFromuMcUI());
            #endregion

            #region 阻抗
            uiMap.Add(Constants.CzkTxBaseUI, new CzkTxBaseUI());
            uiMap.Add(Constants.CzkNetParamUI, new CxbUIDevParam()); // 共用网络参数界面
            uiMap.Add(Constants.CzkTransLineUI, new CxbUIDCLine()); // 共用输电线界面
            uiMap.Add(Constants.CzkGroundLineUI, new CxbUIGroundLine()); // 共用谐波接地极界面
            uiMap.Add(Constants.CzkOrderUI, new CzkOrderUI());
            #endregion

        }

        public IDictionary<string, CfmBaseFrom> UIMap
        {
            //set { uiMap = value; }
            get { return uiMap; }
        }

        public CfmBaseFrom TreeNodeChanged(string menuName, TreeView tree, TreeViewEventArgs e)
        {
            bool flag = uiMap.ContainsKey(e.Node.Name);
            return flag ? uiMap[e.Node.Name] : null;
        }
    }
}
