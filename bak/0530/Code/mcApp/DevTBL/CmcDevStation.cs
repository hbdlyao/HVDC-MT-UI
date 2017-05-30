///////////////////////////////////////////////////////////
//  CmcStation.cs
//  Implementation of the Class CmcStation
//  Generated by Enterprise Architect
//  Created on:      21-5��-2017 7:51:09
//  Original author: open2
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Yao.BaseFrame.DevTBL;
using Hvdc.MT.mc.Func;
using Hvdc.MT.mc.Def;

namespace Hvdc.MT.mc.DevTBL
{
    public class CmcDevStation : CDevStation
    {

        public override void Init()
        {

            int i1, i2;

            i1 = CmcDef.mc_AcSys;
            i2 = CmcDef.mc_Ground;

            for (int i = i1; i <= i2; i++)
                NewDevTBL(i);
        }

        /// <summary>
        /// @param ="vType"
        /// </summary>
        /// <param name="vDevType"></param>
        public override string TypeToName(int vDevType)
        {

            return CmcFunc.mcTypeToName(vDevType);
        }

        /// 
        /// <param name="vType"></param>
        public override CDevTBL NewDevTBL(int vType)
        {

            string vName;
            CDevTBL vTBL;

            vName = TypeToName(vType);

            //
            vTBL = new CmcDevTBL();

            vTBL.tblName = vName;
            vTBL.tblType = vType;

            //
            Add(vTBL);

            //
            pTables[vType] = vTBL;

            return vTBL;
        }

    }//end CmcStation

}//end namespace DevTBL