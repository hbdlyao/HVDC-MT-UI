///////////////////////////////////////////////////////////
//  CmcCasePack.cs
//  Implementation of the Class CmcCasePack
//  Generated by Enterprise Architect
//  Created on:      29-5��-2017 16:13:08
//  Original author: open2
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


using Hvdc.MT.HvdcCommon;
namespace Hvdc.MT.HvdcCommon
{
    public class CmcCasePack : CmcCase
    {
        protected IDictionary<string, CmcCase> pDataPack = new Dictionary<string, CmcCase>();

        public override void Clear()
        {
            foreach (KeyValuePair<string, CmcCase>  vPair in pDataPack)
                vPair.Value.Clear();
        }
        public override bool IsLeaf()
        {
            return false;
        }

        /// 
        /// <param name="vItem"></param>
        public override void Add(CmcCase vItem)
        {
            pDataPack[vItem.DataName] = vItem;
        }

        /// 
        /// <param name="vItem"></param>
        public override void Remove(CmcCase vItem)
        {
            //
        }

        public int ChildCount()
        {
            return pDataPack.Count;
        }

        public CmcCase NewCase(int vIndex, IList<string> vNames)
        {
            CmcCase vData;

            int vDeep = vNames.Count - 1;
            string vID = vNames[vIndex];

            bool IsExist = pDataPack.ContainsKey(vID);

            if (!IsExist)
            {//������ vName

                if (vIndex == vDeep)
                    vData = new CmcCase();
                else
                    vData = new CmcCasePack();
                //

                vData.Init();
                vData.DataName = vID;

                //
                //pDataPack[vID] = vData;

                Add(vData);

            }//if vN

            vData = pDataPack[vID];

            if (vData.IsLeaf())
                return vData;
            else
            {
                CmcCasePack vPack;
                vPack = vData as CmcCasePack;

                return vPack.NewCase(vIndex + 1, vNames);

            }
        }

        public CmcCase getCase(int vIndex, List<string> vNames)
        {

            CmcCase vData;

            int vDeep = vNames.Count - 1;
            string vID = vNames[vIndex];

            //bool IsExist = pDataPack.ContainsKey(vID);

            vData = pDataPack[vID];

            if (vData.IsLeaf())
                return vData;
            else
            {
                CmcCasePack vPack;
                vPack = vData as CmcCasePack;

                return vPack.getCase(vIndex + 1, vNames);

            }
        }

    }//end CmcCasePack

}//end namespace HvdcCommon