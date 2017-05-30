using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cn.csg.dpcp.model.vo.mc
{
    public class CMCTransformerVo : CMCTwoDotVo
    {
        public CMCTransformerVo()
        {
            //DeviceType = cn.csg.dpcp.common.DeviceType.MCTransformer;
        }
        /// <summary>
        /// 触发角/关断角最大值
        /// </summary>
        public double AngleMax { set; get; }
        /// <summary>
        /// 触发角/关断角最小值
        /// </summary>
        public double AngleMin { set; get; }
        /// <summary>
        /// 分接头控制类型
        /// </summary>
        public int TapCtrlType { set; get; }
        /// <summary>
        /// 定电压参考值
        /// </summary>
        public double FixedURef { set; get; }
        /// <summary>
        /// 变压器额定容量
        /// </summary>
        public double SN { set; get; }
        /// <summary>
        /// 分接头最大档位
        /// </summary>
        public double TapMax { set; get; }
        /// <summary>
        /// 分接头最小档位
        /// </summary>
        public double TapMin { set; get; }
        /// <summary>
        /// 分接头额定档位
        /// </summary>
        public double TapN { set; get; }
        /// <summary>
        /// 网侧额定交流电压
        /// </summary>
        public double UacN { set; get; }
        /// <summary>
        /// 阀侧最大交流电压
        /// </summary>
        public double UvMax { set; get; }
        /// <summary>
        /// 短路阻抗百分比
        /// </summary>
        public double Ukp { set; get; }
        /// <summary>
        /// 阻性压降百分比
        /// </summary>
        public double Urp { set; get; }
        /// <summary>
        /// 分解头调整步长
        /// </summary>
        public double TapSetup { set; get; }
        /// <summary>
        /// a相电感偏差
        /// </summary>
        public double L_deltaA { set; get; }
        /// <summary>
        /// b相电感偏差
        /// </summary>
        public double L_deltaB { set; get; }
        /// <summary>
        /// c相电感偏差
        /// </summary>
        public double L_deltaC { set; get; }
        /// <summary>
        /// 最大电感偏差百分数
        /// </summary>
        public double L_deltaPMax { set; get; }
        /// <summary>
        /// 偏差类型方式
        /// </summary>
        public double L_deltaType { set; get; }
        /// <summary>
        /// 杂散电容
        /// </summary>
        public double Zc { set; get; }
        /// <summary>
        /// 变压器电抗
        /// </summary>
        public double ZL { set; get; }
    }
}
