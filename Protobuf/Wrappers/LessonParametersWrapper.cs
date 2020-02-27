using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfHarris78.Protobuf.Wrappers
{
    public class LessonParametersWrapper
    {
        public LessonParametersSet.LessonParameters Parameters { get; set; }

        public LessonParametersWrapper()
        {
            Parameters = new LessonParametersSet.LessonParameters()
            {
                Option = new LessonParametersSet.LessonParameters.Types.Option()
                {
                    Radio = new LessonParametersSet.LessonParameters.Types.Option.Types.Radio(),
                    Test = new LessonParametersSet.LessonParameters.Types.Option.Types.Test(),
                },
                Common = new LessonParametersSet.LessonParameters.Types.Common(),
                Program = new LessonParametersSet.LessonParameters.Types.Program()
                {
                    Comsec = new LessonParametersSet.LessonParameters.Types.Program.Types.Comsec(),
                    Mode = new LessonParametersSet.LessonParameters.Types.Program.Types.Mode()
                    {
                        Preset = new LessonParametersSet.LessonParameters.Types.Program.Types.Mode.Types.Preset()
                    }
                }
            };
        }

        public string ToJsonFormat(bool useDefaultValue = true)
        {
            Google.Protobuf.JsonFormatter jsonFormatter = new Google.Protobuf.JsonFormatter(new Google.Protobuf.JsonFormatter.Settings(useDefaultValue));

            return jsonFormatter.Format(Parameters);
        }
    }
}
