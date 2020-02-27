using Harris7800HMP;
using LessonParametersSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisAdmin.Src.UI
{
    public class ModemListBoxItem
    {
        public StationPresetModemModule Modem { get; set; }

        public bool CheckName { get; set; } = false;
        public bool CheckModemType { get; set; } = false;
        public bool CheckDataRate { get; set; } = false;
        public bool CheckMode { get; set; } = false;
        public bool CheckDataBits { get; set; } = false;
        public bool CheckStopBits { get; set; } = false;
        public bool CheckParity { get; set; } = false;
        public bool CheckEnable { get; set; } = false;
        public bool CheckOriginalName { get; set; } = false;
        public ModemListBoxItem(string name)
        {
            Modem = new StationPresetModemModule()
            {
                name = name,
                originalName = name
            };
        }

        public LessonParameters.Types.Program.Types.Mode.Types.Preset.Types.Modem SerializeToProtobuf()
        {
            var protoOut = Modem.SerializeToProtobuf();
            protoOut.CheckDataBits = CheckDataBits;
            protoOut.CheckDataRate = CheckDataRate;
            protoOut.CheckEnable = CheckEnable;
            protoOut.CheckMode = CheckMode;
            protoOut.CheckModemType = CheckModemType;
            protoOut.CheckName = CheckName;
            protoOut.CheckOriginalName = CheckOriginalName;
            protoOut.CheckParity = CheckParity;
            protoOut.CheckStopBits = CheckStopBits;
            return protoOut;
        }
        public override string ToString()
        {
            return Modem.name;
        }
    }
}
