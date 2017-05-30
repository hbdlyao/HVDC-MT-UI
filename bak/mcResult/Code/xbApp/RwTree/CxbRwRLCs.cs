///////////////////////////////////////////////////////////
//  CxbRwMonitor.cs
//  Implementation of the Class CxbRwMonitor
//  Generated by Enterprise Architect
//  Created on:      09-5��-2017 8:08:06
//  Original author: open2
///////////////////////////////////////////////////////////

using Hvdc.MT.xb.Device;
using Yao.BaseFrame.Func;

namespace Hvdc.MT.xb.Rw
{
    public class CxbRwRLCs : CxbRw_Tree
    {
        protected override void doLoad_Leaf_Data(CxbDevBase vLeaf)
        {
            CxbDevBranch vDev;
            vDev = (CxbDevBranch)vLeaf;

            base.doLoad_Leaf_Data(vDev);

            vDev.Zr = RwAdo.ReadDouble("Zr");
            vDev.Z_L = RwAdo.ReadDouble("Z_L");
            vDev.Z_C = RwAdo.ReadDouble("Z_C");
            vDev.Zx_L = RwAdo.ReadDouble("Zx_L");
            vDev.Zx_C = RwAdo.ReadDouble("Zx_C");

        }

        protected override void doSave_Leaf_Data(CxbDevBase vLeaf)
        {
            CxbDevBranch vDev;

            vDev = (CxbDevBranch)vLeaf;

            base.doSave_Leaf_Data(vLeaf);

            SqlStr   = SqlStr   + ", ";
            SqlParam = SqlParam +" , ";

            SqlStr = SqlStr + "Zr, ";
            SqlParam = SqlParam + GetString(vDev.Zr) + " , ";

            SqlStr = SqlStr + "Z_L, ";
            SqlParam = SqlParam + GetString(vDev.Z_L) + " , ";

            SqlStr = SqlStr + "Z_C, ";
            SqlParam = SqlParam + GetString(vDev.Z_C) + " , ";

            SqlStr = SqlStr + "Zx_L, ";
            SqlParam = SqlParam + GetString(vDev.Zx_L) + " , ";

            SqlStr = SqlStr + "Zx_C ";
            SqlParam = SqlParam + GetString(vDev.Zx_C);
        }

    }//end CxbRwMonitor

}//end namespace xb