using Hvdc.MT.HvdcCommon;
using Hvdc.MT.mc.Def;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hvdc.MT.mc.Solve
{
    public class CmcResult
    {
        public List<RecResultData> DataList = new List<RecResultData>();

        protected CmcCasePack CasePack=new CmcCasePack();

        public string CalName { get; set; }

        public int datDim { get; set; }

        public void Clear()
        {
            DataList.Clear();

            CasePack.Clear();
        }

        public CmcCase NewCase(IList<string> vStr)
        {
            CmcCase vCase;

            vCase = CasePack.NewCase(0, vStr);

            return vCase;

        }
       

    }
}
