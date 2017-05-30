using Hvdc.MT.HvdcCommon;
using Hvdc.MT.mc.Def;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hvdc.MT.mc.Solve
{
    public class CmcResult
    {
        public DataTable daTable;

        //public List<RecResultData> DataList = new List<RecResultData>();

        protected CmcCasePack CasePack=new CmcCasePack();

        public string CalName { get; set; }

        public int datDim { get; set; }

        public void Clear()
        {
            CasePack.Clear();                      
        }

        public CmcCase NewCase(IList<string> vStr)
        {
            CmcCase vCase;

            vCase = CasePack.NewCase(0, vStr);

            return vCase;

        }

        public CmcCasePack getCasePack(string vCalName)
        {
            IList<string> vStr = new List<string>();

            vStr.Add(vCalName);
            CmcCase vPack = CasePack.getCasePack(0, vStr);

            return (vPack as CmcCasePack);

        }

        public IDictionary<string, CmcCase> getCaseList(string vCalName)
        {
            IList<string> vStr = new List<string>();

            vStr.Add(vCalName);
            CmcCase vPack=CasePack.getCasePack(0, vStr);

            return (vPack as CmcCasePack).Children();

        }
       

    }
}
