///////////////////////////////////////////////////////////
//  CxbRw3pVSrc.cs
//  Implementation of the Class CxbRw3pVSrc
//  Generated by Enterprise Architect
//  Created on:      09-5��-2017 8:08:06
//  Original author: open2
///////////////////////////////////////////////////////////

using Hvdc.MT.xb.Device;
using Yao.BaseFrame.Device;
using Yao.BaseFrame.DevTBL;

namespace Hvdc.MT.xb.Rw
{
    public class CxbRw3pVSrc : CxbRwTwo
    {
        public override void OnLoad()
        {
            base.OnLoad();

            doLoad_hData();
        }

        public override void OnSave()
        {
            base.OnSave();

            //doSave_hData();
        }

        protected override void doLoad(CDevBase vDevice)
        {
           CxbDev3pVSrc vDev;

            vDev = (CxbDev3pVSrc)(vDevice);

            base.doLoad(vDev);
            //
        }


        protected void doLoad_hData()
        {
            ///////////////////////////////////////////
            CDevTBL vTBL;

            vTBL = pGrid.DeviceTBL(tblType);
            foreach (CxbDev3pVSrc vDev in vTBL.Children())
            {
                doLoad_hData(vDev);
            }//for each
        }


        protected void doLoad_hData(CxbDev3pVSrc vDev)
        {
            string vSQL;
            int vh;

            //
            vSQL = "select * from " + tblName + "_hData ";
            vSQL = vSQL + " where DeviceName = ";
            vSQL = vSQL + " '";
            vSQL = vSQL + vDev.DeviceName;
            vSQL = vSQL + "' ";
            vSQL = vSQL + " order by DeviceName ,hOrder ";

            RwAdo.OpenSQL(vSQL);

            while (RwAdo.Record_Read())
            {
                vh = RwAdo.ReadInt32("hOrder");

                //vDev.hUrms[vh]  = RwAdo.ReadDouble("hUrms");
                //vDev.hAngle[vh] = RwAdo.ReadDouble("hAngle");
                //vDev.hYb[vh]    = RwAdo.ReadDouble("hYb");

                //
                //RwAdo.Record_MoveNext();


            }//while

            //cout << "   --" << vDev.GetDeviceName() << endl;


            RwAdo.CloseTBL();

            //
        }
    }//end CxbRw3pVSrc

}//end namespace xb