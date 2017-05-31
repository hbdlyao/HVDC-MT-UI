///////////////////////////////////////////////////////////
//  CDevGrid.cs
//  Implementation of the Class CDevGrid
//  Generated by Enterprise Architect
//  Created on:      09-5月-2017 17:08:07
//  Original author: open2
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Data;
using Yao.BaseFrame.Device;

namespace Yao.BaseFrame.DevTBL
{
    public class CDevGrid
    {
        //public DataSet daSet;        
        public List<CDevTBL> pChildren;

        protected Dictionary<int, CDevTBL> pTables;
        protected Dictionary<string, CDevStation> pStations;

        public CDevGrid()
        {
            pChildren = new List<CDevTBL>();

            pTables = new Dictionary<int, CDevTBL>();

            pStations = new Dictionary<string, CDevStation>();

            //
            Init();

        }
        /// 
        /// <param name="vType"></param>
        public virtual string TypeToName(int vType)
        {

            return "TypeToName";
        }

        public virtual void Init()
        {

        }

        public virtual void Clear()
        {
            foreach (CDevTBL vTBL in pChildren)
            {
                vTBL.Clear();
            }

            foreach (CDevStation vSta in pStations.Values )
            {
                vSta.Clear();
            }

            //
            pStations.Clear();

        }
        /// 
		/// <param name="vItem"></param>
		public virtual void Add(CDevTBL vItem)
        {
            pChildren.Add(vItem);
        }

        /// 
        /// <param name="vItem"></param>
        public virtual void Remove(CDevTBL vItem)
        {
            pChildren.Remove(vItem);
        }

        /// 
        /// <param name="vIndex"></param>
        public CDevTBL Child(int vIndex)
        {
            return pChildren[vIndex];
        }

        public List<CDevTBL> Children()
        {
            return pChildren;
        }

        public int ChildCount()
        {
            return pChildren.Count;
        }

        /// 
        /// <param name="vType"></param>
        public virtual CDevTBL NewDevTBL(int vType)
        {
            return null;
        }

        /// 
        /// <param name="vType"></param>
        public CDevTBL DeviceTBL(int vType)
        {
            return pTables[vType];
        }

        public virtual CDevBase NewDevice(int vtblType, int vDevType)
        {
            CDevBase vDev=DeviceTBL(vtblType).NewDevice(vDevType);

            //AddToStation(vDev.StationNames[0], vDev);

            return vDev;

        }

        public virtual void DeviceAdd(int vtblType,CDevBase vDev)
        {
            DeviceTBL(vtblType).DeviceAdd(vDev);
            AddToStation(vDev.StationNames[0],vDev);
        }

 
        public virtual void AddToStation()
        {
            pStations.Clear();

            //
            foreach (CDevTBL vTBL in Children())
            {
                foreach (CDevBase vDev in vTBL.Children())
                {
                    for (int i=0; i<vDev.StaCount; i++)
                        AddToStation(vDev.StationNames[i], vDev);

                }

            }
        }
        protected virtual void AddToStation(string vStaName ,CDevBase vDev)
        {
            CDevStation vSta;

            if (!pStations.ContainsKey(vStaName))
            {
                vSta = doNewStation();
                vSta.StationName = vStaName;
                //
                pStations[vStaName] = vSta;

            }

            //
            vSta = pStations[vStaName];
            vSta.DeviceAdd(vDev.DeviceType,vDev);

        }

        public virtual void DeviceRemove(int vtblType, CDevBase vDev)
        {
            DeviceTBL(vtblType).DeviceRemove(vDev);

            RemoveFromStation(vDev.StationNames[0], vDev);

            //
            vDev.Dispose();

        }


        protected virtual void RemoveFromStation(string vStaName, CDevBase vDev)
        {
              if (pStations.ContainsKey(vStaName))
            {
                //
                CDevStation vSta = pStations[vStaName];

                vSta.DeviceRemove(vDev.DeviceType,vDev);

            }

        }

        protected virtual CDevStation doNewStation()
        {
            return new CDevStation();
        }

        public Dictionary<string, CDevStation> Stations()
        {          
            return pStations;
        }

        public CDevTBL DevTBLfromStation(string vStaName,int vType)
        {//得到变电站内的设备Table
            return pStations[vStaName].DeviceTBL(vType);
        }

    }//end CDevGrid

}//end namespace DevTBL