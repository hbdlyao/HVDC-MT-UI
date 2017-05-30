using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Hvdc.MT.mc.App
{
    public class CmcDLL
    {
        [DllImport("./Dll/mcApp.dll")]
        public static extern void mcCalculate(StringBuilder vCalName);

        [DllImport("./Dll/mcApp.dll")]
        public static extern void mcCalculateNormal();

        [DllImport("./Dll/mcApp.dll")]
        public static extern void mcInit(StringBuilder vDBFFile);

        [DllImport("./Dll/mcApp.dll")]
        public static extern void mcLoad();

        [DllImport("./Dll/mcApp.dll")]
        public static extern void mcClose();


        [DllImport("./Dll/mcApp.dll")]
        public static extern void mcMain();


        public static void Run(StringBuilder vdbfFile, StringBuilder vCalName)
        {
            try
            {
                CmcDLL.mcInit(vdbfFile);
                CmcDLL.mcLoad();
                CmcDLL.mcCalculateNormal();
                CmcDLL.mcCalculate(vCalName);

                //CmcDLL.mcClose();

            }
            catch (Exception)
            {
                MessageBox.Show("主回路计算发生错误");
                
            }
            
        }
    }
}
