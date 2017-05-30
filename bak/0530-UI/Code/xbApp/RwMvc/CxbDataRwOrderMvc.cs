///////////////////////////////////////////////////////////
//  CmcDataRwMvc.cs
//  Implementation of the Class CmcDataRwMvc
//  Generated by Enterprise Architect
//  Created on:      09-5��-2017 8:08:05
//  Original author: open2
///////////////////////////////////////////////////////////

using Hvdc.MT.HvdcCommon;
using Hvdc.MT.xb.Solve;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using Yao.BaseFrame.dataRw;


namespace Hvdc.MT.xb.dataRw
{
    public class CxbDataRwOrderMvc : CDataRwMvcAccess
    {
        private CxbOrder pOrder;
        
        /// 
        /// <param name="vHvdc"></param>
        public void InitOrder(CxbOrder vOrder)
        {
            pOrder = vOrder;
        }


        public DataTable OnLoadTable()
        {
            try
            {
                using (RwAdo.OpenDBF())
                {
                    doLoad();

                    //doCopy();

                    //
                    RwAdo.CloseDBF();

                }//

                return RwAdo.daTBL;

            }
            catch (OleDbException)
            {
                throw;
            }


        }

        /// <summary>
        /// void
        /// </summary>
        protected override void doLoad()
        {
            string vSQL;
            string tblName = "mcResult";

            vSQL = "select * from "+ tblName;
            RwAdo.OpenTBL(vSQL, tblName);

            RecResultData vData = new RecResultData();

            for (int i = 0; i < RwAdo.RowCount; i++)
            {
                RwAdo.Record_Read(i);
                //
                //doLoad(vData);

                vData.CalName = RwAdo.ReadString("CalName");
                vData.CaseID = RwAdo.ReadString("CaseID");
                vData.StationName = RwAdo.ReadString("StationName");
                vData.PdPer = RwAdo.ReadDouble("PdPercent");

                pOrder.mcData.Add(vData);


            }//for

            RwAdo.CloseTBL();

        }

        protected void doLoad(RecResultData vData)
        {
            

        }

    }//end CxbDataRwOrderMvc

}//end namespace mc