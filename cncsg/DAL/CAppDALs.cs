using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cn.csg.dpcp.common;
using cn.csg.dpcp.dal.mc;

namespace cn.csg.dpcp.dal
{
    public class CAppDALs
    {
        //public static IDictionary<string, BaseDAL> DalMap = new Dictionary<string, BaseDAL>();

        public static void Init()
        {
            //DalMap.Add(Constants.MAIN_LOOP_ContorlMethod, new AccessControlMethodDAL());
            //DalMap.Add(Constants.MAIN_LOOP_ConvertorParameter, new AccessConvertorParameterDAL());
            //DalMap.Add(Constants.MAIN_LOOP_LineResistance, new AccessLineResistanceDAL());
            //DalMap.Add(Constants.MAIN_LOOP_MainCircuitMode, new AccessMainCircuitModeDAL());
            //DalMap.Add(Constants.MAIN_LOOP_PresetDCVoltage, new AccessPresetDCVoltageDAL());
            //DalMap.Add(Constants.MAIN_LOOP_ReactivePower, new AccessReactivePowerDAL());
            //DalMap.Add(Constants.MAIN_LOOP_SpecialParameter, new AccessSpecialParameterDAL());
            //DalMap.Add(Constants.MAIN_LOOP_TFTapParameter, new AccessTFTapParameterDAL());
            //DalMap.Add(Constants.MAIN_LOOP_VariousVoltage, new AccessVariousVoltageDAL());

            // 20170325
            #region
            //DalMap.Add(Constants.MC_CAcSystem, new MCCAcSystemDAL());
            #endregion
        }
    }
}
