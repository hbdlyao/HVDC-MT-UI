///////////////////////////////////////////////////////////
//  CmcDevConvertor.cs
//  Implementation of the Class CmcDevConvertor
//  Generated by Enterprise Architect
//  Created on:      09-5��-2017 17:08:08
//  Original author: open2
///////////////////////////////////////////////////////////




namespace Hvdc.MT.mc.Device
{
    /// <summary>
    /// ������
    /// </summary>
    public class CmcDevConvertor : CmcDevTwoDot
    {

        /// <summary>
        /// �������й��ֵ
        /// </summary>
        protected double f_PconvN;
        /// <summary>
        /// �������޹��ֵ
        /// </summary>
        protected double f_QconvN;
        /// <summary>
        /// ����Ƕֵ(��)
        /// </summary>
        protected double f_miuN;
        /// <summary>
        /// �������/�ضϽ�
        /// </summary>
        protected double f_Alpha_gamaN;
        /// <summary>
        /// ������/�ضϽ����ֵ
        /// </summary>
        protected double f_AngleMax;
        /// <summary>
        /// ������/�ضϽ���Сֵ
        /// </summary>
        protected double f_AngleMin;
        /// <summary>
        /// �ֱ������
        /// </summary>
        protected double f_PdN;
        /// <summary>
        /// �ֱ����ѹ
        /// </summary>
        protected double f_UdN;
        /// <summary>
        /// 6��������ͨѹ��
        /// </summary>
        protected double f_UT;
        /// <summary>
        /// ÿ��12������������
        /// </summary>
        protected int f_Valvor12Count;
        protected double f_UdioN;
        /// <summary>
        /// ������ѹ
        /// </summary>
        protected double f_UvN;
        /// <summary>
        /// ֱ������,������ó�
        /// </summary>
        protected double f_IdN;
        /// <summary>
        /// ���������ͣ�������䣩
        /// </summary>
        protected int f_StationType;
        /// <summary>
        /// �������������ͣ��������������ʣ�����ѹ��
        /// </summary>
        protected int f_StationCtrlType;
        /// <summary>
        /// �������������Ͷֵ
        /// </summary>
        protected int f_StationCtrlTypeN;
        /// <summary>
        /// �Ƿ񵥼���������ʱ�ӵ�
        /// </summary>
        protected int f_IsGround;
        /// <summary>
        /// �ǶȲο�ֵ
        /// </summary>
        protected double f_AngleRef;
        /// <summary>
        /// ��������������վ
        /// </summary>
        protected string f_MeasureStation;

        public double PconvN
        {
            get
            {
                return f_PconvN;
            }
            set
            {
                f_PconvN = value;
            }
        }

        public double QconvN
        {
            get
            {
                return f_QconvN;
            }
            set
            {
                f_QconvN = value;
            }
        }

        public double miuN
        {
            get
            {
                return f_miuN;
            }
            set
            {
                f_miuN = value;
            }
        }

        /// <summary>
        /// �������/�ضϽ�
        /// </summary>
        public double Alpha_gamaN
        {
            get
            {
                return f_Alpha_gamaN;
            }
            set
            {
                f_Alpha_gamaN = value;
            }
        }

        /// <summary>
        /// ������/�ضϽ����ֵ
        /// </summary>
        public double AngleMax
        {
            get
            {
                return f_AngleMax;
            }
            set
            {
                f_AngleMax = value;
            }
        }

        /// <summary>
        /// ������/�ضϽ���Сֵ
        /// </summary>
        public double AngleMin
        {
            get
            {
                return f_AngleMin;
            }
            set
            {
                f_AngleMin = value;
            }
        }

        /// <summary>
        /// �ֱ������
        /// </summary>
        public double PdN
        {
            get
            {
                return f_PdN;
            }
            set
            {
                f_PdN = value;
            }
        }

        /// <summary>
        /// �ֱ����ѹ
        /// </summary>
        public double UdN
        {
            get
            {
                return f_UdN;
            }
            set
            {
                f_UdN = value;
            }
        }

        /// <summary>
        /// 6��������ͨѹ��
        /// </summary>
        public double UT
        {
            get
            {
                return f_UT;
            }
            set
            {
                f_UT = value;
            }
        }

        /// <summary>
        /// ÿ��12������������
        /// </summary>
        public int Valvor12Count
        {
            get
            {
                return f_Valvor12Count;
            }
            set
            {
                f_Valvor12Count = value;
            }
        }

        public double UdioN
        {
            get
            {
                return f_UdioN;
            }
            set
            {
                f_UdioN = value;
            }
        }

        /// <summary>
        /// ������ѹ
        /// </summary>
        public double UvN
        {
            get
            {
                return f_UvN;
            }
            set
            {
                f_UvN = value;
            }
        }

        /// <summary>
        /// ֱ������,������ó�
        /// </summary>
        public double IdN
        {
            get
            {
                return f_IdN;
            }
            set
            {
                f_IdN = value;
            }
        }

        /// <summary>
        /// ���������ͣ�������䣩
        /// </summary>
        public int StationType
        {
            get
            {
                return f_StationType;
            }
            set
            {
                f_StationType = value;
            }
        }

        /// <summary>
        /// �������������ͣ��������������ʣ�����ѹ��
        /// </summary>
        public int StationCtrlType
        {
            get
            {
                return f_StationCtrlType;
            }
            set
            {
                f_StationCtrlType = value;
            }
        }

        /// <summary>
        /// ��������������վ
        /// </summary>
        public string MeasureStation
        {
            get
            {
                return f_MeasureStation;
            }
            set
            {
                f_MeasureStation = value;
            }
        }

        /// <summary>
        /// �ǶȲο�ֵ
        /// </summary>
        public double AngleRef
        {
            get
            {
                return f_AngleRef;
            }
            set
            {
                f_AngleRef = value;
            }
        }

        /// <summary>
        /// �Ƿ񵥼���������ʱ�ӵ�
        /// </summary>
        public int IsGround
        {
            get
            {
                return f_IsGround;
            }
            set
            {
                f_IsGround = value;
            }
        }

        /// <summary>
        /// �������������Ͷֵ
        /// </summary>
        public int StationCtrlTypeN
        {
            get
            {
                return f_StationCtrlTypeN;
            }
            set
            {
                f_StationCtrlTypeN = value;
            }
        }

    }//end CmcDevConvertor

}//end namespace mcDev