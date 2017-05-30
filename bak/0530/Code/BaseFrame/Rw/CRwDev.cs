///////////////////////////////////////////////////////////
//  CRwDbf.cs
//  Implementation of the Class CRwDbf
//  Generated by Enterprise Architect
//  Created on:      10-5��-2017 9:23:45
//  Original author: open2
///////////////////////////////////////////////////////////

using Yao.BaseFrame.Device;
using Yao.BaseFrame.DevTBL;
using Yao.BaseFrame.Func;

namespace Yao.BaseFrame.Rw
{
    public class CRwDev : CRwDbf
    {
        protected CDevGrid pGrid;

        public void InitGrid(CDevGrid vGrid)
        {
            pGrid = vGrid;
        }

        protected string StaField(int vStaCount, int vIndex)
        {
            string vStr;

            switch (vStaCount)
            {
                case 1:
                    vStr = "StationName";
                    break;

                default:
                    vStr = "StationName" + vIndex.ToString();
                    break;

            }

            return vStr;
        }

        protected string NodeNameField(int vStaCount, int vIndex)
        {
            string vStr;

            switch (vStaCount)
            {
                case 1:
                    vStr = "NodeName";
                    break;

                default:
                    vStr = "NodeName" + vIndex.ToString();
                    break;

            }

            return vStr;
        }

        protected override void OnLoad(string vtblName,string vSQL_Load)
        {
            CDevTBL vTBL;
            CDevBase vDev;

            //cout << "Load---" << tblName << "---" << endl;    
            
            //
            vTBL = pGrid.DeviceTBL(tblType);

            //
            RwAdo.OpenSQL(vSQL_Load);
            while (RwAdo.Record_Read())
            {
                //
                vDev = vTBL.NewDevice(devType);
                //
                doLoad(vDev);
                //
                vTBL.DeviceAdd(vDev);

                //RwAdo.Record_MoveNext();

                //cout << "   --" << vDev.GetDeviceName() << endl;
            }

            //
            RwAdo.CloseTBL();

        }

        protected override void OnSave(string vtblName, string vSQL_Save)
        {
            CDevTBL vTBL;

            // cout << " Save ---" << vtblName << "---" << endl;

            vTBL = pGrid.DeviceTBL(tblType);
            foreach (CDevBase vDev in vTBL.Children())
            {
                //
                SqlStr = "Insert into " + vtblName;
                SqlParam = "";
                //
                SqlStr = SqlStr + " (";
                SqlParam = SqlParam + " Values ( ";

                //
                doSave(vDev);

                //
                SqlStr = SqlStr + " ) ";
                SqlParam = SqlParam + " ) ";
                //
                SqlStr = SqlStr + SqlParam;

                //
                RwAdo.ExecSQL(SqlStr);

                //
                //RwAdo.Record_Update();
                //
                //cout << "   --" << vDev.GetDeviceName() << endl;

            }//for


            RwAdo.CloseTBL();

        }

        public virtual void OnLoad(string vDeviceName)
        {
            CDevTBL vTBL;
            CDevBase vDev;
            string vSQL;

            //cout << "Load---" << tblName << "---" << endl;    

            vSQL = "select *  from  " + tblName;
            vSQL = vSQL + " where DeviceName = ";
            vSQL = vSQL + "'";
            vSQL = vSQL + vDeviceName;
            vSQL = vSQL + "'";

            //
            RwAdo.OpenSQL(vSQL);

            //
            vTBL = pGrid.DeviceTBL(tblType);
            if (RwAdo.Reader.HasRows)
            {
                vDev = vTBL.Device(vDeviceName);
                if (vDev == null)
                {
                    vDev = vTBL.NewDevice(devType);
                    vTBL.DeviceAdd(vDev);
                }

                //
                RwAdo.Record_Read();
                //
                doLoad(vDev);

            }
            //cout << "   --" << vDev.GetDeviceName() << endl;
            //
            RwAdo.CloseTBL();

        }

        public virtual void OnSave(CDevBase vDev)
        {
            string vSQL;

            vSQL = "delete  from  " + tblName;
            vSQL = vSQL + " where DeviceName = ";
            vSQL = vSQL + "'";
            vSQL = vSQL + vDev.DeviceName;
            vSQL = vSQL + "'";

            RwAdo.ExecSQL(vSQL);

            //
            SqlStr = "Insert into " + tblName;
            SqlParam = "";
            //
            SqlStr = SqlStr + " (";
            SqlParam = SqlParam + " Values ( ";

            //
            doSave(vDev);

            //
            SqlStr = SqlStr + " ) ";
            SqlParam = SqlParam + " ) ";
            //
            SqlStr = SqlStr + SqlParam;
            //
            RwAdo.ExecSQL(SqlStr);

            //
            //cout << "   --" << vDev.GetDeviceName() << endl;

            RwAdo.CloseTBL();

        }

        /// 
        /// <param name="vDevice"></param>
        protected virtual void doLoad(CDevBase vDevice)
        {
            int i;
            string vFieldName;

            for (i = 1; i <= vDevice.StaCount; i++)
            {
                vFieldName = StaField(vDevice.StaCount, i);

                vDevice.StationNames[i - 1] = RwAdo.ReadString(vFieldName);
            }

            for (i = 1; i <= vDevice.dotCount; i++)
            {
                vFieldName = NodeNameField(vDevice.dotCount, i);

                vDevice.NodeNames[i - 1] = RwAdo.ReadString(vFieldName);
            }

            //
            vDevice.ID = RwAdo.ReadInt32("ID");

            vDevice.DeviceID = RwAdo.ReadString("DeviceID");
            vDevice.DeviceName = RwAdo.ReadString("DeviceName");
            vDevice.DeviceType = RwAdo.ReadInt32("DeviceType");

        }

        /// 
        /// <param name="vDevice"></param>
        protected virtual void doSave(CDevBase vDevice)
        {
            int i;
            string vFieldName;

            for (i = 1; i <= vDevice.StaCount; i++)
            {
                vFieldName = StaField(vDevice.StaCount, i);

                SqlStr = SqlStr + vFieldName+",";
                SqlParam = SqlParam + GetString(vDevice.StationNames[i - 1]) + ",";
            }

            for (i = 1; i <= vDevice.dotCount; i++)
            {
                vFieldName = NodeNameField(vDevice.dotCount, i);

                SqlStr = SqlStr + vFieldName + ",";
                SqlParam = SqlParam + GetString(vDevice.NodeNames[i - 1]) + ",";
            }

            //SqlStr = SqlStr + "ID , ";
            //SqlParam = SqlParam + GetString(vDevice.ID) + " , ";
            //
            SqlStr = SqlStr + "DeviceID , ";
            SqlParam = SqlParam + GetString(vDevice.DeviceID) + " , ";

            SqlStr = SqlStr + "DeviceName , ";
            SqlParam = SqlParam + GetString(vDevice.DeviceName) + " , ";

            SqlStr = SqlStr + "DeviceType ";
            SqlParam = SqlParam + GetString(vDevice.DeviceType);

        }
    }//end CRwDev

}//end namespace RwBase