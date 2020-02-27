using Harris7800HMP;
using LessonParametersSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisAdmin.Src.UI
{
    class SystemListBoxItem
    {
        public StationPresetSystem System { get; set; }

        public bool CheckName { get; set; } = false;
        public bool CheckChannelNumber { get; set; } = false;
        public bool CheckModemPreset { get; set; } = false;
        public bool CheckKey { get; set; } = false;
        public bool CheckPtVoiceMode { get; set; } = false;
        public bool CheckCtVoiceMode { get; set; } = false;
        public bool CheckEnable { get; set; } = false;
        public bool CheckKeyValue { get; set; } = false;
        public bool CheckRadioMode { get; set; } = false;
        public SystemListBoxItem(string sName)
        {
            System = new StationPresetSystem() { name = sName };
        }

        public LessonParameters.Types.Program.Types.Mode.Types.Preset.Types.System SerializeToProtobuf()
        {
            var protoOut = System.SerializeToProtobuf();

            protoOut.CheckChannelNumber = CheckChannelNumber;
            protoOut.CheckCtVoiceMode = CheckCtVoiceMode;
            protoOut.CheckEnable = CheckEnable;
            protoOut.CheckKey = CheckKey;
            protoOut.CheckModemPreset = CheckModemPreset;
            protoOut.CheckName = CheckName;
            protoOut.CheckPtVoiceMode = CheckPtVoiceMode;
            protoOut.CheckKeyValue = CheckKeyValue;
            protoOut.CheckRadioMode = CheckRadioMode;

            return protoOut;
        }

        public override string ToString()
        {
            return System.name;
        }
    }
}
