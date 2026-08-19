using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernUI_NET472.Assets
{
    public class AppAssets
    {
        public enum ButtonMode
        {
            STANDARD, PRESSED, LOADING, LOCKED, DISABLED
        }

        internal static Image GetPlaceholderButton(bool isHover, ButtonMode mode)
        {
            switch (mode)
            {
                case ButtonMode.STANDARD:
                    return isHover ? Properties.Resources.Hover : Properties.Resources.Standard;
                case ButtonMode.PRESSED:
                    return Properties.Resources.Pressed;
                case ButtonMode.LOADING:
                    return Properties.Resources.Loading;
                case ButtonMode.LOCKED:
                    return isHover ? Properties.Resources.Locked_Hover : Properties.Resources.Locked_Standard;
                case ButtonMode.DISABLED:
                    return isHover ? Properties.Resources.Disabled_Hover : Properties.Resources.Disabled_Standard;
                default:
                    return Properties.Resources.Standard;
            }
        }
    }
}
