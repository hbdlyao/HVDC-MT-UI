using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cn.csg.dpcp.model.vo.mc
{
    public class CMCConvertorVo : CMCTwoDotVo
    {
        public CMCConvertorVo()
        {
            DeviceType = cn.csg.dpcp.common.DeviceType.MCConvertor;
        }
        /// <summary>
        /// 额定触发角/关断角
        /// </summary>
        public double Alpha_gamaN { set; get; }
        /// <summary>
        /// 触发角/关断角最小值
        /// </summary>
        public double AngleMin { set; get; }
        /// <summary>
        /// 换流器类型（整流=0;逆变=1）
        /// </summary>
        public int StationType { set; get; }
        /// <summary>
        /// 换流器控制类型（定功率=2;定电压=3;定角度=5;定电流=1;电流跟随=6）
        /// </summary>
        public int StationCtrlType { set; get; }
        /// <summary>
        /// 额定直流功率
        /// </summary>
        public double PdN { set; get; }
        /// <summary>
        /// 额定直流电压
        /// </summary>
        public double UdN { set; get; }
        /// <summary>
        /// 6脉动正向导通压降
        /// </summary>
        public double UT { set; get; }
        /// <summary>
        /// 每极12脉动换流组数
        /// </summary>
        public int Valvor12Count { set; get; }
        /// <summary>
        /// 换流站吸收无功最小值
        /// </summary>
        public double Qmin { set; get; }
        /// <summary>
        /// 偏差类型(按百分数/按实际值)
        /// </summary>
        public double Angle_DeltaType { set; get; }
        /// <summary>
        /// 触发角/关断角(偏差百分数,所有晶闸管都一样)
        /// </summary>
        public double AngleDeltaPMax { set; get; }
        /// <summary>
        /// 触发角关断角偏差实际值(按每个晶闸管给出)
        /// </summary>
        public double AngleDeltaVect { set; get; }
        /// <summary>
        /// 是否是金属回线接地点
        /// </summary>
        public double IsGround { set; get; }
        /// <summary>
        /// 直流电流(计算得出)
        /// </summary>
        public double DcId { set; get; }

        /// <summary>
        /// 额定直流电流
        /// </summary>
        public double DcIdN { set; get; }
    }
}
