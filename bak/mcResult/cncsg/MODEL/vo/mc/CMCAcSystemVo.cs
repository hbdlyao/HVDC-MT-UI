
namespace cn.csg.dpcp.model.vo.mc
{
    /// <summary>
    /// 主回路 交流系统
    /// </summary>
    public class CMCAcSystemVo : CMCOneDotVo
    {
        public CMCAcSystemVo()
        {
            //DeviceType = cn.csg.dpcp.common.DeviceType.MCAcSystem;
        }
        /// <summary>
        /// 交流系统额定有功功率
        /// </summary>
        public double PacN { set; get; }
        /// <summary>
        /// 交流系统额定无功功率
        /// </summary>
        public double QacN { set; get; }
        /// <summary>
        /// 交流侧电压
        /// </summary>
        public double Uac { set; get; }
        /// <summary>
        /// 交流侧额定电压
        /// </summary>
        public double UacN { set; get; }
        /// <summary>
        /// 交流系统吸收最大无功
        /// </summary>
        public double QinMax { set; get; }
        /// <summary>
        /// 交流系统发出最大无功
        /// </summary>
        public double QoutMax { set; get; }
        /// <summary>
        /// 交流电压极小值
        /// </summary>
        public double UacExMin { set; get; }
        /// <summary>
        /// 交流电压最大值
        /// </summary>
        public double UacMax { set; get; }
        /// <summary>
        /// 交流电压最小值
        /// </summary>
        public double UacMin { set; get; }
    }
       
}
