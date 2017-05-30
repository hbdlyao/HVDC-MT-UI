///////////////////////////////////////////////////////////
//  CDevTree.cs
//  Implementation of the Class CDevTree
//  Generated by Enterprise Architect
//  Created on:      09-5��-2017 17:08:07
//  Original author: open2
///////////////////////////////////////////////////////////

using System.Collections.Generic;

using Yao.BaseFrame.Device;

namespace Yao.BaseFrame.DevTBL
{
    public class CDevTree : CDevBase
    {

        /// <summary>
        /// protected pObjVector pChildren;
        /// </summary>
        public List<CDevBase> pChildren;
        public string tableName;

        public CDevTree()
        {

            pChildren = new List<CDevBase>();
        }

        public virtual void Clear()
        {
            pChildren.Clear();            
        }

        /// 
        /// <param name="vType"></param>
        public virtual string TypeToName(int vType)
        {

            return "TypeToName";
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
        public CDevBase Child(int vIndex)
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

    }//end CDevTree

}//end namespace DevTBL