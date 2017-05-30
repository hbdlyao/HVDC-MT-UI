///////////////////////////////////////////////////////////
//  CxbDev_Tree.cs
//  Implementation of the Class CxbDev_Tree
//  Generated by Enterprise Architect
//  Created on:      09-5��-2017 17:08:09
//  Original author: open2
///////////////////////////////////////////////////////////


using Hvdc.MT.xb.Func;
using System.Collections.Generic;
using Yao.BaseFrame.Device;

namespace Hvdc.MT.xb.Device
{
    public class CxbDev_Tree : CxbDevBase
    {
        /// <summary>
        /// protected pObjVector pChildren;
        /// </summary>
        public List<CDevBase> pChildren;
        //public string tableName;

        public CxbDev_Tree()
        {
            pChildren = new List<CDevBase>();
        }

        /// 
        /// <param name="vType"></param>
        public virtual string TypeToName(int vType)
        {
            return CxbFunc.xbTypeToName(vType);
        }

        public int ChildCount()
        {
            return pChildren.Count;
        }

        public List<CDevBase> Children()
        {
            return pChildren;
        }

        /// 
        /// <param name="vIndex"></param>
        public Yao.BaseFrame.Device.CDevBase Child(int vIndex)
        {
            return pChildren[vIndex];
        }

        public override bool IsLeaf()
        {
            return false;
        }

        /// 
        /// <param name="vItem"></param>
        public override void Add(CDevBase vItem)
        {
            pChildren.Add(vItem);
        }

        /// 
        /// <param name="vItem"></param>
        public override void Remove(CDevBase vItem)
        {
            pChildren.Remove(vItem);
        }
    }//end CxbDev_Tree

}//end namespace xbDev