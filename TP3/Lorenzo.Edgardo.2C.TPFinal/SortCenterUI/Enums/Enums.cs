using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCore
{
    public enum EKeyboardSize
    { 
        /*
         * Vortex Race 3
         * Ducky One 2
         * Varmilo VA87M
         * */

        Tenkeyless = 87,

        /*
         * Ducky Shine
         * Vortex Tab
         * Varmilo VA108M
         * Leopold FC980M
         * */

        FullSize = 104,

        /*
         * Vortex Core
         * Qisan Magicforce
         * Planck
         * YMDK
         * */
        Small = 40
    }
    public enum ESwitchColor
    {
        CherryBrown = ESwitchType.Clicky, 
        CherryBlue = ESwitchType.Clicky, 
        CherryRed = ESwitchType.Linear,
        GateronBrown = ESwitchType.Clicky,
        GateronBlue = ESwitchType.Clicky, 
        GateronClear = ESwitchType.Linear
    }
    public enum ESwitchType
    {
        Clicky, Linear
    }
    public enum EScreenSize
    {
        MediumScreen = 14,
        LargeScreen = 15
    }
}