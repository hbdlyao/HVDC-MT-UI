///////////////////////////////////////////////////////////
//  CRwAdo_Access.cs
//  Implementation of the Class CRwAdo_Access
//  Generated by Enterprise Architect
//  Created on:      10-5��-2017 9:23:30
//  Original author: open2
///////////////////////////////////////////////////////////


namespace Yao.BaseFrame.Rw
{
    public class CRwAdo_Access : CRwAdo
    {        
        /// 
        /// <param name="vDbf"></param>
        /// <param name="vUserID"></param>
        /// <param name="vPassword"></param>
        /// <param name="vSecurity"></param>
        public override void InitDbf(string vDbf, string vUserID, string vPassword, string vSecurity)
        {
            dbfName = vDbf;

            UserID = vUserID;
            Password = vPassword;

            //strConnect = "Provider=Microsoft.Jet.OLEDB.4.0 ; Persist Security Info= ";

            strConnect = "Provider = Microsoft.ACE.OLEDB.12.0; Persist Security Info= ";
            strConnect = strConnect + vSecurity;
            strConnect = strConnect + "; Data Source= ";
            strConnect = strConnect + vDbf;


            /*
			strConnect = "Provider = Microsoft.ACE.OLEDB.12.0; Persist Security Info= ";
			strConnect = strConnect + vSecurity;
			strConnect = strConnect + "; Driver = { Microsoft Access Driver(*.mdb, *.accdb) } " ;
			strConnect = strConnect + "; DBQ = " ;
			strConnect = strConnect + vDbf ;
			*/
        }

    }//end CRwAdo_Access

}//end namespace RwBase