using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hvdc.MT.HvdcCommon
{
    public class CHvdcDefs
    {
        public const int mcGridType = 1;
        public const int xbGridType = 2;
        public const int u3pGridType = 3;

    }


    public struct RecResultData
    {
        public string CalName;
        public string CaseID;
        public string StationName;//站名

        public double PdPer;//功率水平
        public double Uac;//交流电压
        public double Uv;//阀侧电压
        public double Udio;//理想空载直流电压
        public double Ud;//直流端口电压
        public double UdL;//直流端口对地电压
        public double Id;//直流电流
        public double Pd;//直流功率
        public double Pconv;//换流器有功
        public double Qconv;//换流器无功

        public int TC;//变压器分接头档位
        public double alphaOrgamma;//触发角/关断角
        public double miu;//换相角
        public double Qf_max;//滤波器提供的最大无功
        public double Qf_min;//滤波器提供的最小无功

        public double Udio_N;//理想空载直流电压额定值
        public double Uv_N;//阀侧电压额定值

        public double Tk_N;//变压器额定变比
        public double Tk;//变压器实际变比

        public double Ud6Valve;//6脉动阀电压
        public double Pd6Valve;//6脉动阀直流功率
        public double Pac6Valve;//6脉动阀有功
        public double Qac6Valve;//6脉动阀有功
    };

}
