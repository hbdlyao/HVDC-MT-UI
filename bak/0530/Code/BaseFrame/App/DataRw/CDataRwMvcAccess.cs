///////////////////////////////////////////////////////////
//  CRwMvcAccess.cs
//  Implementation of the Class CRwMvcAccess
//  Generated by Enterprise Architect
//  Created on:      10-5��-2017 9:43:27
//  Original author: open2
///////////////////////////////////////////////////////////

using System.Data;

namespace Yao.BaseFrame.dataRw
{
    public class CDataRwMvcAccess : CDataRwMvc
    {
        /// 
        /// <param name="vDbf"></param>
        public override void InitAdo(string vDbf)
        {
            dbfName = vDbf;

            daSet = new DataSet();

            RwAdo = new CDataRwAccess(daSet);
            RwAdo.InitDbf(dbfName, "", "", "false");

        }

    }//end CDataRwMvcAccess

}//end namespace RwBase