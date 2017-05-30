///////////////////////////////////////////////////////////
//  CmcOrder.cs
//  Implementation of the Class CmcOrder
//  Generated by Enterprise Architect
//  Created on:      27-5��-2017 9:49:58
//  Original author: open2
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Hvdc.MT.HvdcCommon;

namespace Hvdc.MT.xb.Solve
{
    public class CxbOrder : CHvdcOrder
    {
        public List<RecResultData> mcData = new List<RecResultData>();


        /// <summary>
        /// 12�����м��Ƿ�ӵ�
        /// </summary>
        public int Is6Pulse = 0;

        /// <summary>
        /// ���㷽ʽ��0=���ܼ���;1=��ֵ���㣬Ĭ��1
        /// </summary>
        public int CalcType = 1;

        /// <summary>
        /// ���ؽ����ʽ��0=��Ե�;1=��Զ࣬Ĭ��1
        /// </summary>
        public int SingleReusltType = 0;

        /// <summary>
        /// ��Ȩ��ʽ��0=P��Ȩ;1=C��Ȩ;2=����Ȩ
        /// </summary>
        public int Plus = 0;

        public override void Init()
        {
            base.Init();           
        }

    }//end CxbOrder

}//end namespace HvdcCommon