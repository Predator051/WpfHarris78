using System;
using System.Collections.Generic;
using System.Drawing;

namespace Harris7800HMP
{
    public class RadioModules
    {
        public enum ModuleType
        {
            Handset, Usb, Coupler
        }
        public class Location
        {
            public int x = 0;
            public int y = 0;

            public Location(int xx, int yy)
            {
                x = xx;
                y = yy;
            }
        }

        public Dictionary<ModuleType, Tuple<Bitmap, Location>> modulesImage = new Dictionary<ModuleType, Tuple<Bitmap, Location>> {
            { ModuleType.Handset, new Tuple<Bitmap, Location>(WpfHarris78.Properties.Resources.handsetTube, new Location(650, 320)) },
            { ModuleType.Usb , new Tuple<Bitmap, Location>(WpfHarris78.Properties.Resources.usbJustConnector, new Location(665, 245)) },
            { ModuleType.Coupler , new Tuple<Bitmap, Location>(WpfHarris78.Properties.Resources.coupler, new Location(-40, 155)) }
        };
    }
}
