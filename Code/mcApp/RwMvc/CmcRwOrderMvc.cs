using Hvdc.MT.mc.Def;
using Hvdc.MT.mc.Solve;
using Yao.BaseFrame.Rw;

namespace Hvdc.MT.mc.RwMvc
{
    class CmcRwOrderMvc : CRwMvcAccess
    {
        protected CmcOrder pOrder;
        public void InitOrder(CmcOrder vOrder)
        {
            pOrder = vOrder;
        }

        protected override void OnLoad()
        {
            using (RwAdo.OpenDBF())
            {
                doLoad();

                doLoad_UdCustom();

                //
                RwAdo.CloseDBF();

            }//

        }

        protected override void OnSave()
        {
            using (RwAdo.OpenDBF())
            {
                //崔康生20170528-Bug
                doSave();

                doSave_UdCustom();

                //
                RwAdo.CloseDBF();

            }//

        }
        protected override void doLoad()
        {
            string vSQL;
            //
            vSQL = "select * from mcOrder ";
            vSQL = vSQL + " where CalName = ";
            vSQL = vSQL + " '";
            vSQL = vSQL + pOrder.CalName;
            vSQL = vSQL + "' ";
            RwAdo.OpenSQL(vSQL);

            //cout << "Load---mcOrder---" << endl;
            while (RwAdo.Record_Read())
            {
                //pOrder.CalName = RwAdo.ReadString("CalName");
                pOrder.Flag_Ground = RwAdo.ReadString("Flag_Ground");
                pOrder.Flag_Ground = RwAdo.ReadString("Flag_Ud");
                pOrder.Flag_Ground = RwAdo.ReadString("Flag_Rd");
                pOrder.Flag_Ground = RwAdo.ReadString("Flag_Uac");

                pOrder.nValNum = RwAdo.ReadInt32("nValvor");
                pOrder.IsUdCustom = RwAdo.ReadInt32("IsUdCustom");
                pOrder.IsUacSwap = RwAdo.ReadInt32("IsUacSwap");
                pOrder.IsUdToGround = RwAdo.ReadInt32("IsUdToGround");
                pOrder.Is6Pulse = RwAdo.ReadInt32("Is6Pulse");

                pOrder.PdStartPer = RwAdo.ReadDouble("PdStartPercent");
                pOrder.PdIncrePer = RwAdo.ReadDouble("PdIncrePer");
                pOrder.PdSize = RwAdo.ReadInt32("PdSize");

                //崔康生20170528-单功率水平
                pOrder.IsLoadSingle = RwAdo.ReadInt32("IsLoadSingle");
                pOrder.PdSingle = RwAdo.ReadDouble("PdSingle");
                pOrder.UdSingle = RwAdo.ReadDouble("UdSingle");

            }//while

            RwAdo.CloseTBL();
        }

        protected void doLoad_UdCustom()
        {
            string vSQL;
            //
            vSQL = "select * from mcOrder_UdData ";
            vSQL = vSQL + " where CalName = ";
            vSQL = vSQL + " '";
            vSQL = vSQL + pOrder.CalName;
            vSQL = vSQL + "' ";
            RwAdo.OpenSQL(vSQL);

            //崔康生20170528-直流电压预设
            RecUdCustom vUdCustom = new RecUdCustom();

            //cout << "Load---mcOrder_UdData---" << endl;
            while (RwAdo.Record_Read())
            {
                vUdCustom.PdIndex = RwAdo.ReadInt32("PdIndex");
                vUdCustom.Ud11 = RwAdo.ReadDouble("Ud_Ground11");
                vUdCustom.Ud21 = RwAdo.ReadDouble("Ud_Ground21");
                vUdCustom.Ud22 = RwAdo.ReadDouble("Ud_Ground22");

                //
                pOrder.UdCustoms.Add(vUdCustom);

            }//while

            RwAdo.CloseTBL();
        }

        protected override void doSave()
        {
            string vSQL;

            //
            vSQL = "delete from mcOrder ";
            vSQL = vSQL + " where CalName = ";
            vSQL = vSQL + " '";
            vSQL = vSQL + pOrder.CalName;
            vSQL = vSQL + "' ";
            RwAdo.ExecSQL(vSQL);

            //
            //cout << "Save---" << tblName << "---" << endl;
            SqlStr = "Insert into mcOrder ";
            SqlParam = "Values ";
            //
            SqlStr = SqlStr + " ( ";
            SqlParam = SqlParam + " ( ";

            //
            doSave1();

            //
            SqlStr = SqlStr + " ) ";
            SqlParam = SqlParam + " ) ";
            //
            SqlStr = SqlStr + SqlParam;

            //
            RwAdo.ExecSQL(SqlStr);

            RwAdo.CloseTBL();

            //cout << " Finished mc_Order " << endl;
        }

        protected void doSave1()
        {
            //
            SqlStr = SqlStr + "CalName, ";
            SqlParam = SqlParam + GetString(pOrder.CalName) + ",";

            SqlStr = SqlStr + "Flag_Ground, ";
            SqlParam = SqlParam + GetString(pOrder.Flag_Ground) + ",";

            SqlStr = SqlStr + "Flag_Ud, ";
            SqlParam = SqlParam + GetString(pOrder.Flag_Ud) + ",";

            SqlStr = SqlStr + "Flag_Rd, ";
            SqlParam = SqlParam + GetString(pOrder.Flag_Rd) + ",";

            SqlStr = SqlStr + "Flag_Uac, ";
            SqlParam = SqlParam + GetString(pOrder.Flag_Uac) + ",";

            SqlStr = SqlStr + "IsUdCustom, ";
            SqlParam = SqlParam + GetString(pOrder.IsUdCustom) + ",";

            SqlStr = SqlStr + "IsUacSwap, ";
            SqlParam = SqlParam + GetString(pOrder.IsUacSwap) + ",";

            SqlStr = SqlStr + "IsUdToGround, ";
            SqlParam = SqlParam + GetString(pOrder.IsUdToGround) + ",";

            SqlStr = SqlStr + "nValvor, ";
            SqlParam = SqlParam + GetString(pOrder.nValNum) + ",";

            SqlStr = SqlStr + "PdStartPercent, ";
            SqlParam = SqlParam + GetString(pOrder.PdStartPer) + ",";

            SqlStr = SqlStr + "PdIncrePer, ";
            SqlParam = SqlParam + GetString(pOrder.PdIncrePer) + ",";

            SqlStr = SqlStr + "PdSize, ";
            SqlParam = SqlParam + GetString(pOrder.PdSize) + ",";

            SqlStr = SqlStr + "Is6Pulse, ";
            SqlParam = SqlParam + GetString(pOrder.Is6Pulse) + ",";

            //崔康生20170528-单功率水平
            SqlStr = SqlStr + "IsLoadSingle, ";
            SqlParam = SqlParam + GetString(pOrder.IsLoadSingle) + ",";

            SqlStr = SqlStr + "PdSingle, ";
            SqlParam = SqlParam + GetString(pOrder.PdSingle) + ",";

            SqlStr = SqlStr + "UdSingle ";
            SqlParam = SqlParam + GetString(pOrder.UdSingle) + "";
        }

        protected void doSave_UdCustom()
        {
            string vSQL;

            //
            vSQL = "delete from mcOrder_UdData ";
            vSQL = vSQL + " where CalName = ";
            vSQL = vSQL + " '";
            vSQL = vSQL + pOrder.CalName;
            vSQL = vSQL + "' ";
            RwAdo.ExecSQL(vSQL);

            //崔康生20170528-直流电压预设
            foreach (RecUdCustom vUdCustom in pOrder.UdCustoms)
            {
                //
                //cout << "Save---" << tblName << "---" << endl;
                SqlStr = "Insert into mcOrder_UdData ";
                SqlParam = "Values ";
                //
                SqlStr = SqlStr + " ( ";
                SqlParam = SqlParam + " ( ";

                doSave_UdCustom1(vUdCustom);

                //
                SqlStr = SqlStr + " ) ";
                SqlParam = SqlParam + " ) ";
                //
                SqlStr = SqlStr + SqlParam;

                //
                RwAdo.ExecSQL(SqlStr);

            }
            RwAdo.CloseTBL();

            //cout << " Finished mc_Order " << endl;
        }

        protected void doSave_UdCustom1(RecUdCustom vUdCustom)
        {
            SqlStr = SqlStr + "CalName, ";
            SqlParam = SqlParam + GetString(pOrder.CalName) + ",";

            //崔康生20170528-直流电压预设
            SqlStr = SqlStr + "PdIndex, ";
            SqlParam = SqlParam + GetString(vUdCustom.PdIndex) + ",";

            SqlStr = SqlStr + "Ud_Ground11, ";
            SqlParam = SqlParam + GetString(vUdCustom.Ud11) + ",";

            SqlStr = SqlStr + "Ud_Ground21, ";
            SqlParam = SqlParam + GetString(vUdCustom.Ud21) + ",";

            SqlStr = SqlStr + "Ud_Ground22 ";
            SqlParam = SqlParam + GetString(vUdCustom.Ud22) + "";
            //
        }


    }
}
