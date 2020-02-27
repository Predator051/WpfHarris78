using LessonParametersSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisAdmin.Src.UI
{
    class ChannelItemListBox
    {
        public Harris7800HMP.StationChannel Channel { get; set; }

        public bool CheckNum { get; set; } = false;
        public bool CheckRxFrequency { get; set; }  = false;
        public bool CheckTxFrequency { get; set; }   = false;
        public bool CheckModulation { get; set; }    = false;
        public bool CheckMode { get; set; }          = false;
        public bool CheckHailKey { get; set; }       = false;
        public bool CheckEnableSsbScan { get; set; } = false;
        public bool CheckMaxBandwidth { get; set; }  = false;
        public ChannelItemListBox(string number)
        {
            Channel = new Harris7800HMP.StationChannel
            {
                number = number
            };
        }

        public LessonParameters.Types.Program.Types.Mode.Types.Preset.Types.Channel SerializeToProtobuf()
        {
            var protoOut = Channel.SerializeToProtobuf();

            protoOut.CheckEnableSsbScan = CheckEnableSsbScan;
            protoOut.CheckHailKey = CheckHailKey;
            protoOut.CheckMaxBandwidth = CheckMaxBandwidth;
            protoOut.CheckMode = CheckMode;
            protoOut.CheckModulation = CheckModulation;
            protoOut.CheckNum = CheckNum;
            protoOut.CheckRxFrequency = CheckRxFrequency;
            protoOut.CheckTxFrequency = CheckTxFrequency;

            return protoOut;
        }
        public override string ToString()
        {
            return Channel.number;
        }
    }
}
