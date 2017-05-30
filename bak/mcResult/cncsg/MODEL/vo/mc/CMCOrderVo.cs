using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cn.csg.dpcp.model.vo.mc
{
    /// <summary>
    /// 主回路工况选择
    /// </summary>
    public class CMCOrderVo : CMCDeviceVo
    {
        /// <summary>
        /// 每极12脉动组数
        /// </summary>
        public int S12Count { set; get; }

        /// <summary>
        /// 极线接大地/中性线，1=大地；2=中性线
        /// </summary>
        public int GroundLineAc { set; get; }

        /// <summary>
        /// 运行模式计算选择：双极运行
        /// </summary>
        public int DRun { set; get; }

        /// <summary>
        /// 运行模式计算选择：单极大地
        /// </summary>
        public int SGround { set; get; }

        /// <summary>
        /// 运行模式计算选择：单极金属
        /// </summary>
        public int SMetal { set; get; }

        /// <summary>
        /// 直流电压水平计算选择：全压运行
        /// </summary>
        public int DcUdAll { set; get; }

        /// <summary>
        /// 直流电压水平计算选择：80%降压
        /// </summary>
        public int DcUd80 { set; get; }

        /// <summary>
        /// 直流电压水平计算选择：70%降压
        /// </summary>
        public int DcUd70 { set; get; }

        /// <summary>
        /// 直流线路电阻计算选择：直流线路高阻
        /// </summary>
        public int DcHZr { set; get; }

        /// <summary>
        /// 直流线路电阻计算选择：直流线路低阻
        /// </summary>
        public int DcLZr { set; get; }

        /// <summary>
        /// 整流站交流电压计算选择：最高水平
        /// </summary>
        public int RAcUdMax { set; get; }

        /// <summary>
        /// 整流站交流电压计算选择：额定水平
        /// </summary>
        public int RAcUdN { set; get; }

        /// <summary>
        /// 整流站交流电压计算选择：较低水平
        /// </summary>
        public int RAcUdLow { set; get; }

        /// <summary>
        /// 整流站交流电压计算选择：极低水平
        /// </summary>
        public int RAcUdLowest { set; get; }

        /// <summary>
        /// 两侧交流电压水平选择：是否交叉
        /// </summary>
        public int BAcUdC { set; get; }

        /// <summary>
        /// 两侧交流电压水平选择：不平衡工况运行
        /// </summary>
        public int BAcUdNE { set; get; }

        /// <summary>
        /// 直流功率
        /// </summary>
        public double Pd { set; get; }


        /// <summary>
        /// 直流电压
        /// </summary>
        public double Ud { set; get; }

        /// <summary>
        /// 直流电流
        /// </summary>
        public double DcId { set; get; }

        /// <summary>
        /// 起始负荷
        /// </summary>
        public double BdStart { set; get; }

        /// <summary>
        /// 负荷变化步长
        /// </summary>
        public double BdIncre { set; get; }

        /// <summary>
        /// 负荷水平数
        /// </summary>
        public double BdSize { set; get; }

        /// <summary>
        /// 负荷水平选择 0=单负荷；1=多负荷
        /// </summary>
        public int IsBdSingle { set; get; }

        public string Flag_Ground { set; get; }

        public string Flag_Ud { set; get; }

        public string Flag_Rd { set; get; }

        public string Flag_Uac { set; get; }

    }
}
