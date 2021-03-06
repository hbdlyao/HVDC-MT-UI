﻿using System.Collections.Generic;
using System.Windows.Forms;
using cn.csg.dpcp.common;
using cn.csg.dpcp.ui;
using cn.csg.dpcp.ui.mc;

namespace cn.csg.dpcp
{
    class TreeHelper
    {       
        public void initTree(string treeTitle, TreeView tree)
        {
            tree.Nodes.Clear();
            switch (treeTitle)
            {
                #region 主回路
                case Constants.btnMcParam:
                    initTreeMainLoop(tree);
                    break;
                case Constants.btnMcOrder:
                    initTreeMainLoop(tree);
                    break;
                case Constants.btnMcResult:
                    initTreeMainLoop(tree);
                    break;
                #endregion 主回路

                #region 3脉动
                case Constants.btn3MdParamIn:
                    initTreeDcXb3Md(tree);
                    break;
                case Constants.btn3MdOrder:
                    initTreeDcXb3Md(tree);
                    break;
                case Constants.btn3MdResult:
                    initTreeDcXb3Md(tree);
                    break;
                case Constants.C3pAcSysUIcs:
                    initTreeDcXb3Md(tree);
                    break;
                #endregion 3脉动

                #region 谐波器设计 单回线
                case Constants.btnDcLbqSingle:
                    initTreesDcLbqSingleDesgin(tree);
                    break;
                case Constants.btnDcLbqParamIn:
                    initTreesDcLbqSingleDesgin(tree);
                    break;
                case Constants.btnDcLbqOrder:
                    initTreesDcLbqSingleDesgin(tree);
                    break;
                case Constants.btnDcLbqResult:
                    initTreesDcLbqSingleDesgin(tree);
                    break;
                #endregion 谐波器设计 单回线

                #region 谐波器设计 双回线
                #endregion 谐波器设计 双回线

                #region 阻抗
                case Constants.btnZkScanParamIn:
                    initTreeDcZkScan(tree);
                    break;
                case Constants.btnDcZkScanOrder:
                    initTreeDcZkScan(tree);
                    break;
                case Constants.btnDcZkScanResult:
                    initTreeDcZkScan(tree);
                    break;
                #endregion 阻抗

                #region 直流线路参数
                case Constants.btnDcLineParamMenu:
                    initTreeDcLine(tree);
                    break;
                #endregion 直流线路参数
                default:
                    break;
            }
        }

        /// <summary>
        /// 主回路树菜单
        /// </summary>
        /// <param name="tree"></param>
        /// <param name="imgList"></param>
        public void initTreeMainLoop(TreeView tree)
        {
            TreeNode node1 = new TreeNode("参数输入");

            TreeNode s1 = new TreeNode("交流系统", 1, 1);
            s1.Name = Constants.MC_CAcSystem;

            //TreeNode s2 = new TreeNode("交流滤波器", 1, 1);
            //s2.Name = Constants.MC_CAcFilter;

            TreeNode s3 = new TreeNode("换流变压器", 1, 1);
            s3.Name = Constants.MC_CTransformer;

            TreeNode s4 = new TreeNode("换流器", 1, 1);
            s4.Name = Constants.MC_CConvertor;

            TreeNode s5 = new TreeNode("直流极线", 1, 1);
            s5.Name = Constants.MC_CDcPole;

            TreeNode s6 = new TreeNode("金属回线", 1, 1);
            s6.Name = Constants.MC_CDcMetalLine;

            TreeNode s8 = new TreeNode("接地极线", 1, 1);
            s8.Name = Constants.MC_CGroundLine;
            

            TreeNode s15 = new TreeNode("接地电阻", 1, 1);
            s15.Name = Constants.MC_CGround;

            node1.Nodes.Add(s1);
            //node1.Nodes.Add(s2);
            node1.Nodes.Add(s3);
            node1.Nodes.Add(s4);
            node1.Nodes.Add(s5);
            node1.Nodes.Add(s6);
            node1.Nodes.Add(s8);
            node1.Nodes.Add(s15);

            TreeNode node2 = new TreeNode("工况选择与计算");

            TreeNode s10 = new TreeNode("直流电压预设", 1, 1);
            s10.Name = Constants.MCOrderUdCustomUI;

            TreeNode s11 = new TreeNode("工况选择", 1, 1);
            s11.Name = Constants.MC_Order;            

            node2.Nodes.Add(s10);
            node2.Nodes.Add(s11);

            TreeNode node3 = new TreeNode("结果处理");

            //TreeNode s11 = new TreeNode("结果选择", 1, 1);
            //node3.Nodes.Add(s11);

            TreeNode s12 = new TreeNode("结果查看", 1, 1);
            s12.Name = Constants.MC_CResult;
            
            node3.Nodes.Add(s12);

            //TreeNode s13 = new TreeNode("结果导出", 1, 1);
            //node3.Nodes.Add(s13);

            TreeNode s14 = new TreeNode("图形显示", 1, 1);
            s14.Name = Constants.MC_CDisplay;
            node3.Nodes.Add(s14);

            tree.Nodes.Add(node1);
            tree.Nodes.Add(node2);
            tree.Nodes.Add(node3);

            tree.ExpandAll();
            tree.SelectedNode = node1.Nodes[0];

        }

        /// <summary>
        /// 直流侧谐波分析与设计 三脉动 树菜单
        /// </summary>
        /// <param name="tree"></param>
        /// <param name="imgList"></param>
        public void initTreeDcXb3Md(TreeView tree)
        {
            TreeNode node1 = new TreeNode("参数输入");

            TreeNode s6 = new TreeNode("主回路计算结果选择", 1, 1);
            s6.Name = Constants.U3p_DataFromuMcUI;

            TreeNode s5 = new TreeNode("交流系统", 1, 1);
            s5.Name = Constants.C3pAcSysUIcs;

            TreeNode s1 = new TreeNode("换流变", 1, 1);
            s1.Name = Constants.C3pXf2UI;

            TreeNode s2 = new TreeNode("换流器", 1, 1);
            s2.Name = Constants.C3pConvertorUI;     

            node1.Nodes.Add(s6);
            node1.Nodes.Add(s5);
            node1.Nodes.Add(s1);
            node1.Nodes.Add(s2);

            TreeNode node2 = new TreeNode("工况选择与计算");

            //TreeNode s4 = new TreeNode("系统偏差输入", 1, 1);
            //s4.Name = Constants.C3MdSysDiffInUI;

            //TreeNode s3 = new TreeNode("三脉动源算法选择", 1, 1);
            //s3.Name = Constants.C3MdSrcAlgOptionUI;

            TreeNode s10 = new TreeNode("工况选择", 1, 1);
            s10.Name = Constants.C3pOrderUI;

            //node2.Nodes.Add(s4);
            //node2.Nodes.Add(s3);
            node2.Nodes.Add(s10);

            TreeNode node3 = new TreeNode("结果处理");

            tree.Nodes.Add(node1);
            tree.Nodes.Add(node2);
            tree.Nodes.Add(node3);
            tree.ExpandAll();
        }

        /// <summary>
        /// 直流侧谐波分析与设计 滤波器分析设计 单回线树菜单
        /// </summary>
        /// <param name="tree"></param>
        /// <param name="imgList"></param>
        public void initTreesDcLbqSingleDesgin(TreeView tree)
        {
            TreeNode node1 = new TreeNode("参数输入");

            TreeNode s1 = new TreeNode("三脉动计算结果选择", 1, 1);
            s1.Name = Constants.CxbUIDataFromU3p;

            TreeNode s2 = new TreeNode("输电线路参数", 1, 1);
            s2.Name = Constants.CxbUIDCLine;

            TreeNode s3 = new TreeNode("接地极线路参数", 1, 1);
            s3.Name = Constants.CxbUIGroundLine;

            TreeNode s4 = new TreeNode("主要网络参数", 1, 1);
            s4.Name = Constants.CxbUIDevParam;

            node1.Nodes.Add(s1);
            node1.Nodes.Add(s2);
            node1.Nodes.Add(s3);
            node1.Nodes.Add(s4);

            TreeNode node2 = new TreeNode("工况选择与计算");

            TreeNode s5 = new TreeNode("工况选择", 1, 1);
            s5.Name = Constants.CxbUIOrder;
            node2.Nodes.Add(s5);

            TreeNode node3 = new TreeNode("结果处理");

            tree.Nodes.Add(node1);
            tree.Nodes.Add(node2);
            tree.Nodes.Add(node3);
            tree.ExpandAll();
        }

        /// <summary>
        /// 直流侧谐波分析与设计 滤波器分析设计 双回线树菜单
        /// </summary>
        /// <param name="tree"></param>
        /// <param name="imgList"></param>
        public void initTreesDcLbqDoubleDesgin(TreeView tree)
        {

        }

        /// <summary>
        /// 直流侧谐波分析与设计 阻抗谐振扫描 树菜单
        /// </summary>
        /// <param name="tree"></param>
        /// <param name="imgList"></param>
        public void initTreeDcZkScan(TreeView tree)
        {
            TreeNode node1 = new TreeNode("参数输入");
            TreeNode s1 = new TreeNode("三脉动计算结果选择", 1, 1);
            s1.Name = Constants.CxbUIDataFromU3p;
            TreeNode s2 = new TreeNode("主要网络参数", 1, 1);
            s2.Name = Constants.CzkNetParamUI;
            TreeNode s3 = new TreeNode("输电线路参数", 1, 1);
            s3.Name = Constants.CzkTransLineUI;
            TreeNode s4 = new TreeNode("接地极线路参数", 1, 1);
            s4.Name = Constants.CzkGroundLineUI;

            node1.Nodes.Add(s1);
            node1.Nodes.Add(s2);
            node1.Nodes.Add(s3);
            node1.Nodes.Add(s4);
            
            TreeNode node2 = new TreeNode("工况选择与计算");
            TreeNode s10 = new TreeNode("工况参数", 1, 1);
            s10.Name = Constants.CzkOrderUI;

            node2.Nodes.Add(s10);

            TreeNode node3 = new TreeNode("结果处理");

            tree.Nodes.Add(node1);
            tree.Nodes.Add(node2);
            tree.Nodes.Add(node3);
            tree.ExpandAll();
        }

        /// <summary>
        /// 直流侧谐波分析与设计 直流线路参数
        /// </summary>
        /// <param name="tree"></param>
        /// <param name="imgList"></param>
        public void initTreeDcLine(TreeView tree)
        {
            TreeNode node1 = new TreeNode("参数输入");
            TreeNode s1 = new TreeNode("输电线路参数", 1, 1);
            s1.Name = Constants.CzkTransLineUI;
            TreeNode s2 = new TreeNode("接地极线路参数", 1, 1);
            s2.Name = Constants.CzkGroundLineUI;
            node1.Nodes.Add(s1);
            node1.Nodes.Add(s2);

            TreeNode node2 = new TreeNode("工况选择与计算");

            TreeNode node3 = new TreeNode("结果处理");

            tree.Nodes.Add(node1);
            tree.Nodes.Add(node2);
            tree.Nodes.Add(node3);
            tree.ExpandAll();

        }
    }
}
