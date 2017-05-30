using cn.csg.dpcp.model.vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Yao.BaseFrame.Device;

namespace cn.csg.dpcp.model.vo.mc
{
    public class CMCResultVo : CBasicVo
    {
        /// <summary>
        /// 工况名称
        /// </summary>
        public string CaseID { set; get; }
        /// <summary>
        /// 站名
        /// </summary>
        public string StationName { set; get; }
        /// <summary>
        /// 功率水平Pd(%)
        /// </summary>
        public double Pd { set; get; }
        /// <summary>
        /// 网侧电压Ul(kV)
        /// </summary>
        public double Uac { set; get; }
        /// <summary>
        /// 阀侧电压Uv(kV)
        /// </summary>
        public double Uv { set; get; }
        /// <summary>
        /// 理想空载电压Udio(kV)
        /// </summary>
        public double Udio { set; get; }
        /// <summary>
        /// 直流端口电压Ud(kV)
        /// </summary>
        public double Ud { set; get; }
        /// <summary>
        /// 直流对地电压UdL(kV)
        /// </summary>
        public double UdL { set; get; }
        /// <summary>
        /// 额定理想空载电压Udio_N(kV)
        /// </summary>
        public double Udio_N { set; get; }
        /// <summary>
        /// 额定阀侧电压Uv_N(kV)
        /// </summary>
        public double Uv_N { set; get; }
        /// <summary>
        /// 直流电流Id(kA)
        /// </summary>
        public double DcId { set; get; }
        /// <summary>
        /// 直流功率Pd(kA)
        /// </summary>
        public double PdPer { set; get; }
        /// <summary>
        /// 换流器有功Pconv(MW)
        /// </summary>
        public double Pconv { set; get; }
        /// <summary>
        /// 换流器无功Qconv(Mvar)
        /// </summary>
        public double Qconv { set; get; }
        /// <summary>
        /// 变压器抽头档位TC
        /// </summary>
        public int TC { set; get; }
        /// <summary>
        /// 触发角/关断角alphaOrgamma(°)
        /// </summary>
        public int alphaOrgamma { set; get; }
        /// <summary>
        /// 换相角miu(°)
        /// </summary>
        public double miu { set; get; }
        /// <summary>
        /// 滤波器的最大无功Qf_max(Mvar)
        /// </summary>
        public double Qf_max { set; get; }
        /// <summary>
        /// 滤波器的最小无功Qf_min(Mvar)
        /// </summary>
        public double Qf_min { set; get; }

    }
}
