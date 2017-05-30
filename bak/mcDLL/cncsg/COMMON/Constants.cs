using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cn.csg.dpcp.common
{
    public class Constants
    {
        public const string AccessDBPath = "AccessDBPath";
        /// <summary>
        /// 菜单 主回路
        /// </summary>
        public const string MENU_MAIN_LOOP = "Menu_Main_Loop";

        /// <summary>
        /// 菜单直流谐波电流
        /// </summary>
        public const string Menu_DC_XB = "Menu_DC_XB";

        /// <summary>
        /// 直流滤波器设计和阻抗谐振
        /// </summary>
        public const string MENU_DC_LBQ_ZK = "Menu_DC_LBQ_ZK";

        /// <summary>
        /// 三脉动
        /// </summary>
        public const string MENU_3MD = "Menu_3MD";

        /// <summary>
        /// 主回路交流系统
        /// </summary>
        public const string MC_CAcSystem = "MC_CAcSystem";
        public const string MC_CAcSystem_Table = "MCCAcSystem";

        /// <summary>
        /// 主回路换流变压器
        /// </summary>
        public const string MC_CTransformer = "MC_CTransformer";

        /// <summary>
        /// 主回路换流器
        /// </summary>
        public const string MC_CConvertor = "MC_CConvertor";

        /// <summary>
        /// 主回路平波电抗器
        /// </summary>
        public const string MC_CPbDkq = "MC_CPbDkq";

        /// <summary>
        /// 主回路交流滤波器
        /// </summary>
        public const string MC_CAcFilter = "MC_CAcFilter";

        /// <summary>
        /// 主回路接地极线
        /// </summary>
        public const string MC_CGroundLine = "MC_CGroundLine";

        /// <summary>
        /// 直流滤波器
        /// </summary>
        public const string MC_CDcFilter = "MC_CDcFilter";

        /// <summary>
        /// 主回路金属回线
        /// </summary>
        public const string MC_CDcMetalLine = "MC_CDcMetalLine";

        /// <summary>
        /// 主回路直流极线
        /// </summary>
        public const string MC_CDcPole = "MC_CDcPole";

        /// <summary>
        /// 主回路工况选择
        /// </summary>
        public const string MC_Order = "MC_Order";

        /// <summary>
        /// 主回路接地极线
        /// </summary>
        public const string MC_CGround = "MC_CGround";

        /// <summary>
        /// 主回路结果查看
        /// </summary>
        public const string MC_CResult = "MC_CResult";

        /// <summary>
        /// 主回路结果显示
        /// </summary>
        public const string MC_CDisplay = "MC_CDisplay";

        public const string MCOrderUdCustomUI = "MCOrderUdCustomUI";

        /// <summary>
        /// 直流谐波分析设计 3脉动源计算结果选项
        /// </summary>
        public const string XB_3Md_Result_Option = "XB_3Md_Result_Option";

        /// <summary>
        /// 直流谐波分析设计 输电线路参数
        /// </summary>
        public const string XB_DC_LINE_PARAM = "XB_DC_LINE_PARAM";

        /// <summary>
        /// 直流谐波分析设计 接地极线路参数
        /// </summary>
        public const string XB_GROUND_LINE_PARAM = "XB_GROUND_LINE_PARAM";

        /// <summary>
        /// 直流谐波分析设计 主要网络参数
        /// </summary>
        public const string XB_NET_PARAM = "XB_NET_PARAM";

        public const string btn3MdParamIn = "btn3MdParamIn";

        public const string btn3MdOrder = "btn3MdOrder";

        public const string btn3MdResult = "btn3MdResult";

        public const string btnDcLbqSingle = "btnDcLbqSingle";

        public const string btnDcLbqDouble = "btnDcLbqDouble";

        public const string btnDcLbqParamIn = "btnDcLbqParamIn";

        public const string btnDcLbqOrder = "btnDcLbqOrder";

        public const string btnDcLbqResult = "btnDcLbqResult";

        public const string btnDcLineParamIn = "btnDcLineParamIn";

        public const string btnDcLineParamOrder = "btnDcLineParamOrder";

        public const string btnDcLineResult = "btnDcLineResult";

        public const string btnZkScanParamIn = "btnZkScanParamIn";

        public const string btnDcZkScanOrder = "btnDcZkScanOrder";

        public const string btnDcZkScanResult = "btnDcZkScanResult";

        /// <summary>
        /// 直流侧谐波分析与设计 直流侧滤波器设计 单回线 传输线路
        /// </summary>
        public const string CxbDcLineLbqSingleUI = "CxbDcLineLbqSingleUI";

        /// <summary>
        /// 直流侧谐波分析与设计 直流侧滤波器设计 单回线 接地极线路参数
        /// </summary>
        public const string CxbDcLineLbqGroundLineUI = "CxbDcLineLbqGroundLineUI";

        /// <summary>
        /// 直流侧谐波分析与设计 直流侧滤波器设计 单回线 主要网络参数
        /// </summary>
        public const string CxbDcLbqNetUI = "CxbDcLbqNetUI";

        /// <summary>
        /// 直流侧谐波分析与设计 直流侧滤波器设计 单回线 工况选择
        /// </summary>
        public const string XB_OrderUI = "XB_OrderUI";

        /// <summary>
        /// 直流侧谐波分析与设计 三脉动 单负荷水平计算
        /// </summary>
        public const string C3MdSingleLoadUI = "C3MdSingleLoadUI";

        /// <summary>
        /// 直流侧谐波分析与设计 三脉动 多负荷水平计算
        /// </summary>
        public const string C3MdMultLoadUI = "C3MdMultLoadUI";

        /// <summary>
        /// 直流侧谐波分析与设计 三脉动 换流变换相电抗偏差
        /// </summary>
        public const string C3pXf2UI = "C3pXf2UI";

        /// <summary>
        /// 直流侧谐波分析与设计 三脉动 换流变熄弧角偏差
        /// </summary>
        public const string C3pConvertorUI = "C3pConvertorUI";

        /// <summary>
        /// 直流侧谐波分析与设计 三脉动 三脉动源算法选择
        /// </summary>
        public const string C3MdSrcAlgOptionUI = "C3MdSrcAlgOptionUI";

        /// <summary>
        /// 直流侧谐波分析与设计 三脉动 系统偏差输入
        /// </summary>
        public const string C3MdSysDiffInUI = "C3MdSysDiffInUI";

        /// <summary>
        /// 直流侧谐波分析与设计 三脉动 工况选择
        /// </summary>
        public const string C3pOrderUI = "C3pOrderUI";

        /// <summary>
        /// 直流侧谐波分析与设计 三脉动 交流系统
        /// </summary>
        public const string C3pAcSysUIcs = "C3pAcSysUIcs";

        /// <summary>
        /// 直流侧谐波分析与设计 阻抗 调谐基础界面
        /// </summary>
        public const string CzkTxBaseUI = "CzkTxBaseUI";

        /// <summary>
        /// 直流侧谐波分析与设计 阻抗 单调谐滤波器界面
        /// </summary>
        public const string CzkTxOneUI = "CzkTxOneUI";

        /// <summary>
        /// 直流侧谐波分析与设计 阻抗 双调谐滤波器界面
        /// </summary>
        public const string CzkTxTwoUI = "CzkTxTwoUI";

        /// <summary>
        /// 直流侧谐波分析与设计 阻抗 三调谐滤波器界面
        /// </summary>
        public const string CzkTxThreeUI = "CzkTxThreeUI";

        /// <summary>
        /// 直流侧谐波分析与设计 阻抗 运行参数
        /// </summary>
        public const string CzkRunParamUI = "CzkRunParamUI";

        /// <summary>
        /// 直流侧谐波分析与设计 阻抗 阻抗换流变压器
        /// </summary>
        public const string CzkHlbyqUI = "CzkHlbyqUI";

        /// <summary>
        /// 直流侧谐波分析与设计 阻抗 阻抗网络参数
        /// </summary>
        public const string CzkNetParamUI = "CzkNetParamUI";

        /// <summary>
        /// 直流侧谐波分析与设计 阻抗 阻抗传输线
        /// </summary>
        public const string CzkTransLineUI = "CzkTransLineUI";

        /// <summary>
        /// 直流侧谐波分析与设计 阻抗 阻抗接地极线路参数
        /// </summary>
        public const string CzkGroundLineUI = "CzkGroundLineUI";

        /// <summary>
        /// 直流侧谐波分析与设计 阻抗 工况选择
        /// </summary>
        public const string CzkOrderUI = "CzkOrderUI";

        /// <summary>
        /// 直流侧谐波分析与设计 阻抗 单负荷水平计算
        /// </summary>
        public const string CzkSingleLoadCalcUI = "CzkSingleLoadCalcUI";

        /// <summary>
        /// 直流侧谐波分析与设计 阻抗 多负荷水平计算
        /// </summary>
        public const string CzkMultLoadCalcUI = "CzkMultLoadCalcUI";

        /// <summary>
        /// 直流侧谐波分析与设计 谐波 平波电抗器
        /// </summary>
        public const string CxbPbDkqUI = "CxbPbDkqUI";


    }
}
