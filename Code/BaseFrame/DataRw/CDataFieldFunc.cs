using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yao.BaseFrame.dataRw
{
    public static class CDataFieldFunc
    {
        public static int ReadInt16(DataRow vRow,string vField)
        {
            if (!vRow.IsNull(vField))
                return (int)vRow[vField];
            else
                return -10000;
        }

        public static int ReadInt32(DataRow vRow,string vField)
        {
            if (!vRow.IsNull(vField))
                return (int)vRow[vField];
            else
                return -10000;
            
        }

        public static double ReadDouble(DataRow vRow,string vField)
        {
            if (!vRow.IsNull(vField))
                return (double)vRow[vField];
            else
                return -10000;
        }

        public static string ReadString(DataRow vRow,string vField)
        {
            if (!vRow.IsNull(vField))
                return vRow[vField].ToString();
            else
                return "Null";
        }

        public static bool ReadBool(DataRow vRow,string vField)
        {
            if (!vRow.IsNull(vField))
                return (bool)vRow[vField];
            else
                return false;
        }

        public static void SaveField(DataRow vRow,string vField, int vValue)
        {
            vRow[vField] = vValue;
        }

        public static void SaveField(DataRow vRow,string vField, double vValue)
        {
            vRow[vField] = vValue;
        }

        public static void SaveField(DataRow vRow,string vField, string vValue)
        {
            vRow[vField] = vValue;
        }

        public static void SaveField(DataRow vRow,string vField, bool vValue)
        {
            vRow[vField] = vValue;
        }
    }
}
