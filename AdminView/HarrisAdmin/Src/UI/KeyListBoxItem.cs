using LessonParametersSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisAdmin.Src.UI
{
    public class KeyListBoxItem
    {
        public Harris7800HMP.KeyModule.KeyValue Key { get; set; }
        public bool CheckType { get; set; } = false;
        public bool CheckName { get; set; } = false;
        public bool CheckKey { get; set; } = false;
        public bool CheckAwsKey { get; set; } = false;

        public KeyListBoxItem(string name)
        {
            Key = new Harris7800HMP.KeyModule.KeyValue();
            Key.keyName = name;
        }

        public LessonParameters.Types.Program.Types.Comsec.Types.Key SerializeToProtobuf()
        {
            var outProto = Key.SerializeToProtobuf();
            outProto.CheckAwsKey = CheckAwsKey;
            outProto.CheckKey = CheckKey;
            outProto.CheckName = CheckName;
            outProto.CheckType = CheckType;
            return outProto;
        }
        public override string ToString()
        {
            return Key.keyName;
        }
    }
}
