///////////////////////////////////////////////////////////
//  CxbRw_Tree.cs
//  Implementation of the Class CxbRw_Tree
//  Generated by Enterprise Architect
//  Created on:      09-5月-2017 8:08:06
//  Original author: open2
///////////////////////////////////////////////////////////



using Hvdc.MT.xb.Device;
using Hvdc.MT.xb.DevTBL;
using Yao.BaseFrame.Device;
using Yao.BaseFrame.DevTBL;
using Yao.BaseFrame.Func;

namespace Hvdc.MT.xb.Rw
{
    public class CxbRw_Tree : CxbRw
    {
        protected string tblName_Node;
        protected string tblName_Leaf;

        public void InitTable(string vtblName,string vtblName_Node,string vtblName_Leaf)
        {
            tblName = vtblName;
            tblName_Node = vtblName_Node;
            tblName_Leaf = vtblName_Leaf;
        }

        protected virtual string GetSQL_Load_Node(string vNodeName)
        {
            string vSQL, vtbl1, vtbl2;

            vtbl1 = tblName;
            vtbl2 = tblName_Node;

            //select a.stationname1, a.stationname2,a.PosOrNeg, b.* from xbTrap as a, xbTrap_tree as b  
            //where b.ParentDeviceName = a.Devicename 
            //and b.ParentDeviceName = "Trap1"
            //order by b.ParentDeviceName , b.DeviceName
            //
            vSQL = "select b.* from ";
            vSQL = vSQL + vtbl1 + " as a , " + vtbl2 + " as b ";
            vSQL = vSQL + " where b.ParentDeviceName = a.devicename  ";
            vSQL = vSQL + " and b.ParentDeviceName = ";
            vSQL = vSQL + " '";
            vSQL = vSQL + vNodeName;
            vSQL = vSQL + "' ";
            vSQL = vSQL + " order by b.ParentDeviceName , b.DeviceName ";

            return vSQL;

        }

        protected virtual string GetSQL_Load_Leaf(string vLeafName)
        {
            string vSQL, vtbl1, vtbl2;

            vtbl1 = tblName;
            vtbl2 = tblName_Leaf;

            //select a.stationname1, a.stationname2,a.PosOrNeg, b.* 
            //from xbTrap as a, xbTrap_tree as b  
            //where b.ParentDeviceName = a.Devicename 
            //and b.ParentDeviceName = "Trap1"
            //order by b.ParentDeviceName , b.DeviceName

            vSQL = "select a.stationname, a.PosOrNeg, b.*  from " ;
            vSQL = vSQL + vtbl1 + " as a , " + vtbl2 + " as b ";
            vSQL = vSQL + " where b.ParentDeviceName = a.devicename  ";
            vSQL = vSQL + " and b.DeviceName = ";
            vSQL = vSQL + "'";
            vSQL = vSQL + vLeafName;
            vSQL = vSQL + "'";
            vSQL = vSQL + " order by b.ParentDeviceName , b.DeviceName ";

            return vSQL;

        }

        protected virtual string GetSQL_Delete_Leaf(string vLeafName)
        {
            string vSQL, vtblName;

            //delete *  from xbTrap_tree 
            //where DeviceName = "Trap1"

            vtblName = tblName_Leaf;
            //
            vSQL = "delete   from  " + vtblName;
            vSQL = vSQL + " where DeviceName = ";
            vSQL = vSQL + "'";
            vSQL = vSQL + vLeafName;
            vSQL = vSQL + "'";

            return vSQL;

        }

        public override void OnLoad()
        {
            base.OnLoad();

            foreach (CxbDevBase vDev in pGrid.DeviceTBL(tblType).Children())
                doLoad_Child(vDev);
        }
 
        /// 
        /// <param name="vDev"></param>
        protected virtual void doLoad_Child(CxbDevBase vDev)
        {
            CxbDev_Tree vNode;

            if (vDev.IsLeaf())
                doLoad_Leaf(vDev);

            //
            if (!vDev.IsLeaf())
            {   //广度优先
                vNode = (CxbDev_Tree)(vDev);
                doLoad_Node(vNode);

                //
                foreach (CxbDevBase vChild in vNode.Children())
                {
                    doLoad_Child(vChild);
                }//for 

            }//else
        }

        /// 
        /// <param name="vNode"></param>
        protected virtual void doLoad_Node(CxbDev_Tree vNode)
        {
            CxbDevBase vDev;
            string vSQL;
            int vType;

            //
            vSQL = GetSQL_Load_Node(vNode.DeviceName);
            RwAdo.OpenSQL(vSQL);

            //cout << "Load---" + vtbl2 + "----Node----" << vNode.GetDeviceName() << endl;

            while (RwAdo.Record_Read())
            {
                vType = RwAdo.ReadInt32("DeviceType");
                vDev = (CxbDevBase)(CxbDevTBL.xbNewDevice(vType));

                doLoad_Node_Data(vDev);

                //to-do                
                vNode.Add(vDev);

                //
                //RwAdo.Record_MoveNext();

                //cout << "   --" << vDev.GetDeviceName() << endl;

            }//while

            RwAdo.CloseTBL();

        }

        /// 
        /// <param name="vLeaf"></param>
        protected virtual void doLoad_Leaf(CxbDevBase vLeaf)
        {
            string vSQL;
            //
            vSQL = GetSQL_Load_Leaf(vLeaf.DeviceName);
            RwAdo.OpenSQL(vSQL);

            //cout << "Load---" << vtbl2 << "---Leaf---" << endl;
            //
            RwAdo.Record_Read();

            doLoad_Leaf_Data(vLeaf);

            //cout << "   --" << vLeaf.GetDeviceName() << endl;

            RwAdo.CloseTBL();

        }

        protected virtual void doLoad_Node_Data(CxbDevBase vNode)
        {
            vNode.ID = RwAdo.ReadInt32("ID");

            vNode.DeviceID   = RwAdo.ReadString("DeviceID");
            vNode.DeviceName = RwAdo.ReadString("DeviceName");
            vNode.DeviceType = RwAdo.ReadInt32("DeviceType");

            //vNode.PosOrNeg = RwAdo.ReadInt16("PosOrNeg");

        }
        /// 
        /// <param name="vLeaf"></param>
        protected virtual void doLoad_Leaf_Data(CxbDevBase vLeaf)
        {
            doLoad0(vLeaf);

            vLeaf.ParentDeviceName = RwAdo.ReadString("ParentDeviceName");

        }

        public override void OnSave()
        {
            base.OnSave();

            //
            foreach (CxbDevBase vDev in pGrid.DeviceTBL(tblType).Children())
                doSave_Child(vDev);
        }

        protected virtual void doSave_Child(CxbDevBase vDev)
        {
            CxbDev_Tree vNode;

            if (vDev.IsLeaf())
                doSave_Leaf(vDev);

            //
            if (!vDev.IsLeaf())
            {   //广度优先
                vNode = (CxbDev_Tree)(vDev);
                doSave_Node(vNode);
                //
                foreach (CxbDevBase vChild in vNode.Children())
                {
                    doSave_Child(vChild);
                }//for 

            }//else
        }
        /// 
        /// <param name="vNode"></param>
        protected virtual void doSave_Node(CxbDev_Tree vNode)
        {
        }

        /// 
        /// <param name="vLeaf"></param>
        protected virtual void doSave_Leaf(CxbDevBase vLeaf)
        {
            string vSQL, vtblName;

            //
            vtblName = tblName_Leaf;
            vSQL = GetSQL_Delete_Leaf(vLeaf.DeviceName);
            RwAdo.ExecSQL(vSQL);

            //
            SqlStr   = "Insert into " + vtblName;
            SqlParam = " ";
           //
           SqlStr   = SqlStr + " (";
           SqlParam = SqlParam + " Values ( ";

            //
            doSave_Leaf_Data(vLeaf);

            //
            SqlStr = SqlStr + " ) ";
            SqlParam = SqlParam + " ) ";
            //
            SqlStr = SqlStr + SqlParam;

            //
            RwAdo.ExecSQL(SqlStr);

            //RwAdo.Record_Update();
            //
            //cout << "   --" << vDev.GetDeviceName() << endl;

            RwAdo.CloseTBL();

        }

        /// 
        /// <param name="vRoot"></param>
        protected virtual void doSave_Node_Data(CxbDevBase vNode)
        {
        }


        protected virtual void doSave_Leaf_Data(CxbDevBase vLeaf)
        {
            int i;
            string vFieldName;

            for (i = 1; i <= vLeaf.dotCount; i++)
            {
                vFieldName = NodeNameField(vLeaf.dotCount, i);

                SqlStr = SqlStr + vFieldName + ",";
                SqlParam = SqlParam + GetString(vLeaf.NodeNames[i - 1]) + ",";
            }

            //SqlStr = SqlStr + "ID , ";
            //SqlParam = SqlParam + GetString(vLeaf.ID) + " , ";

            //
            SqlStr = SqlStr + "DeviceID , ";
            SqlParam = SqlParam + GetString(vLeaf.DeviceID) + " , ";

            SqlStr = SqlStr + "DeviceName , ";
            SqlParam = SqlParam + GetString(vLeaf.DeviceName) + " , ";

            SqlStr = SqlStr + "DeviceType ,";
            SqlParam = SqlParam + GetString(vLeaf.DeviceType) + " , ";

            SqlStr = SqlStr + "ParentDeviceName ";
            SqlParam = SqlParam + GetString(vLeaf.ParentDeviceName);

        }

    }//end CxbRw_Tree

}//end namespace xb