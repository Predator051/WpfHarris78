using System.Collections.Generic;

namespace Harris7800HMP
{
    public class Display
    {
        private List<string> lines = new List<string>();
        private Battery battery = new Battery();
        private RadioStation radioStation;
        public Display(RadioStation station)
        {
            Lines.Add(" " + battery);
            Lines.Add("111111111111111111111111111");
            Lines.Add("line3");
            Lines.Add("line4🥺");
            radioStation = station;
        }

        public List<string> Lines { get => lines; }

        public override string ToString()
        {
            var result = radioStation.ToString();
            return result;
        }
    }
}
