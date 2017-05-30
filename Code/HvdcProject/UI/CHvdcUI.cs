using Hvdc.MT.mc.App;
using Hvdc.MT.mc.DevTBL;
using Hvdc.MT.Project.App;
using Hvdc.MT.xb.App;
using Hvdc.MT.xb.DevTBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hvdc.MT.Project.UI
{
    class CHvdcUI
    {
        public static CmcHvdcGrid mcHvdc
        {
            get
            {
                return CmcVars.pmcHvdcGrid;
            }

        }

        public static CxbHvdcGrid xbHvdc
        {
            get
            {
                return CxbVars.pxbHvdcGrid; 
            }
         
        }



    }
}
