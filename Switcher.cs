using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace Harris7800HMP
{
    public enum SwitcherState
    {
        OFF,
        PT,
        CT,
        LD,
        Z,
        CLR
    };
    public class Switcher
    {
        private SwitcherState state;
        internal SwitcherState State { get => state; set => state = value; }

        private Dictionary<SwitcherState, System.Drawing.Bitmap> imagesPath = new Dictionary<SwitcherState, System.Drawing.Bitmap>()
        {
            { SwitcherState.OFF, WpfHarris78.Properties.Resources.presetKnob_0 },
            { SwitcherState.PT, WpfHarris78.Properties.Resources.presetKnob_1 },
            { SwitcherState.CT, WpfHarris78.Properties.Resources.presetKnob_2 },
            { SwitcherState.LD, WpfHarris78.Properties.Resources.presetKnob_3 },
            { SwitcherState.Z, WpfHarris78.Properties.Resources.presetKnob_4 },
            { SwitcherState.CLR, WpfHarris78.Properties.Resources.presetKnob_5 },
        };

        public SwitcherState NextState()
        {
            if ((int)state + 1 > 5)
            {
                state = SwitcherState.OFF;
            }
            else
            {
                state += 1;
            }
            return state;
        }

        public void InitToOff()
        {
            state = SwitcherState.OFF;
        }

        public System.Drawing.Bitmap GetImage()
        {
            return imagesPath[state];
        }

        public BitmapSource GetBitmapSource()
        {
            return System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                imagesPath[state].GetHbitmap(),
                IntPtr.Zero,
                System.Windows.Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());
        }
    }
}
