using cn.csg.dpcp.model.table.mc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cn.csg.dpcp.model.dataset
{
    public class CMCDeviceDataSet : CBaseDataSet
    {
        private static CMCAcFilterTable acFilter = new CMCAcFilterTable();
        private static CMCAcSystemTable acSystem = new CMCAcSystemTable();
        private static CMCConvertorTable convertor = new CMCConvertorTable();
        private static CMCDcFilterTable dcFilter = new CMCDcFilterTable();
        private static CMCDcMetallLineTable dcMetallLine = new CMCDcMetallLineTable();
        private static CMCDcLineTable dcLine = new CMCDcLineTable();
        private static CMCGroundLineTable groundLine = new CMCGroundLineTable();
        private static CMCpbDkqTable pbdkq = new CMCpbDkqTable();
        private static CMCTransformerTable transformer = new CMCTransformerTable();
        private static CMCOrderable order = new CMCOrderable();
        private static CMCResultTable result = new CMCResultTable();
        private static CMCGroundTable ground = new CMCGroundTable();

        public static CMCAcFilterTable AcFilter
        {
            get
            {
                return acFilter;
            }

            set
            {
                acFilter = value;
            }
        }

        public static CMCAcSystemTable AcSystem
        {
            get
            {
                return acSystem;
            }

            set
            {
                acSystem = value;
            }
        }

        public static CMCConvertorTable Convertor
        {
            get
            {
                return convertor;
            }

            set
            {
                convertor = value;
            }
        }

        public static CMCDcFilterTable DcFilter
        {
            get
            {
                return dcFilter;
            }

            set
            {
                dcFilter = value;
            }
        }

        public static CMCDcMetallLineTable DcMetallLine
        {
            get
            {
                return dcMetallLine;
            }

            set
            {
                dcMetallLine = value;
            }
        }

        public static CMCDcLineTable DcLine
        {
            get
            {
                return dcLine;
            }

            set
            {
                dcLine = value;
            }
        }

        public static CMCGroundLineTable GroundLine
        {
            get
            {
                return groundLine;
            }

            set
            {
                groundLine = value;
            }
        }

        public static CMCpbDkqTable Pbdkq
        {
            get
            {
                return pbdkq;
            }

            set
            {
                pbdkq = value;
            }
        }

        public static CMCTransformerTable Transformer
        {
            get
            {
                return transformer;
            }

            set
            {
                transformer = value;
            }
        }

        public static CMCOrderable Order
        {
            get
            {
                return order;
            }

            set
            {
                order = value;
            }
        }

        public static CMCResultTable Result
        {
            get
            {
                return result;
            }

            set
            {
                result = value;
            }
        }

        public static CMCGroundTable Ground
        {
            get
            {
                return ground;
            }

            set
            {
                ground = value;
            }
        }
    }
}
