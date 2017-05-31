///////////////////////////////////////////////////////////
//  CmcOrder.cs
//  Implementation of the Class CmcOrder
//  Generated by Enterprise Architect
//  Created on:      27-5月-2017 9:49:58
//  Original author: open2
///////////////////////////////////////////////////////////

using Hvdc.MT.HvdcCommon;
using Hvdc.MT.mc.Def;
using System.Collections.Generic;

namespace Hvdc.MT.mc.Solve
{
    public class CmcOrder : CHvdcOrder
    {

        public int Is6Pulse = 0;
        /// <summary>
        /// 电压预设
        /// </summary>
        public IList<RecUdCustom> UdCustoms = new List<RecUdCustom>();

        public override void Init()
        {
            base.Init();

            Is6Pulse = 0;       //是否六脉动中间接地 
            //IsUdCustom = 0;     //直流电压预设情况，如预设则使用UdCustom作为电压指令，否则使用UdLevel
            //IsUacSwap = 0;       // 是否交流电压交叉
            //IsUdToGround = 0;   //直流电压对地或对中性线
            
            ////string Flag_IsPdSingle = "0";//是否单功率水平，该成员可以不要，当成员BdSize取值为1时即为但功率水平
            //PdStartPer = 10;    //起始功率水平
            //PdIncrePer = 5;     //功率水平增量
            //PdSize = 29;        //功率水平数

        }

        public override void Clear()
        {
            UdCustoms.Clear();
        }


    }//end CmcOrder

}//end namespace HvdcCommon