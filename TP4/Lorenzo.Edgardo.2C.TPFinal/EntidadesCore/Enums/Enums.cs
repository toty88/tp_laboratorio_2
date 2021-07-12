using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCore
{
    public enum EKeyboardSize
    { 
        Tenkeyless = 87,
        FullSize = 104,
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