using LessonParametersSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisAdmin.Src.UI
{
    class KeyListBoxItem
    {
        public Harris7800HMP.KeyModule.KeyValue Key { get; set; }
        
        public KeyListBoxItem(string name)
        {
            Key = new Harris7800HMP.KeyModule.KeyValue();
            Key.keyName = name;
        }

        public LessonParameters.Types.Program.Types.Comsec.Types.Key SerializeToProtobuf()
        {

            return Key.SerializeToProtobuf();
        }
        public override string ToString()
        {
            return Key.keyName;
        }
    }
}
