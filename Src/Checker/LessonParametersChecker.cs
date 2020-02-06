using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LessonParametersSet;
using KeyProtobuf = LessonParametersSet.LessonParameters.Types.Program.Types.Comsec.Types.Key;

namespace WpfHarris78.Src.Checker
{
    public class LessonParametersHolder
    {
        static LessonParametersHolder mHolder;
        static public LessonParametersHolder Holder { get {
                return mHolder ?? (mHolder = new LessonParametersHolder());
            } }

        public LessonParameters Parameters { get; set; }
    }

    public class LessonParametersChecker
    {
        LessonParameters originalParameters;

        public LessonParametersChecker(LessonParameters originalParams)
        {
            originalParameters = originalParams;
        }

        static public bool IsEquals (LessonParameters originalParameters, LessonParameters @params)
        {
            //if (originalParameters.Name != "" && originalParameters.Name != @params.Name) return false;

            if (checkObject(originalParameters.Option, @params.Option)) return false;
            
            if (originalParameters.Option != null)
            {
                var originOption = originalParameters.Option;
                var paramsOption = @params.Option;

                if (checkObject(originOption.Radio, paramsOption.Radio)) return false;

                if (originOption.Radio != null)
                {
                    var originRadio = originOption.Radio;
                    var paramsRadio = paramsOption.Radio;

                    if (checkString(originRadio.Bfo, paramsRadio.Bfo)) return false;
                    if (checkString(originRadio.FmSquelchType, paramsRadio.FmSquelchType)) return false;
                    if (checkString(originRadio.InternalCoupler, paramsRadio.InternalCoupler)) return false;
                    if (checkString(originRadio.RadioLock, paramsRadio.RadioLock)) return false;
                    if (checkString(originRadio.RadioSilence, paramsRadio.RadioSilence)) return false;
                    if (checkString(originRadio.RxNoiceBlanking, paramsRadio.RxNoiceBlanking)) return false;
                    if (checkString(originRadio.SquelchLevel, paramsRadio.SquelchLevel)) return false;
                    if (checkString(originRadio.TxPowerLevel, paramsRadio.TxPowerLevel)) return false;

                }

                if (checkObject(originOption.Test, paramsOption.Test)) return false;

                if (originOption.Test != null)
                {
                    var originalTest = originOption.Test;
                    var paramTest = paramsOption.Test;

                    if (checkBoolean(originalTest.Battery, paramTest.Battery)) return false;
                    if (checkBoolean(originalTest.Temp, paramTest.Temp)) return false;
                    if (checkString(originalTest.VswrFrequency, paramTest.VswrFrequency)) return false;

                    if (checkObject(originalTest.Bit, paramTest.Bit)) return false;

                    if (originalTest.Bit != null)
                    {
                        var originalBit = originalTest.Bit;
                        var paramBit = paramTest.Bit;

                        if (checkBoolean(originalBit.ExternalPa, paramBit.ExternalPa)) return false;
                        if (checkBoolean(originalBit.InternalCoupler, paramBit.InternalCoupler)) return false;
                        if (checkBoolean(originalBit.Kdp, paramBit.Kdp)) return false;
                        if (checkBoolean(originalBit.Kdu, paramBit.Kdu)) return false;
                        if (checkBoolean(originalBit.Prepost, paramBit.Prepost)) return false;
                        if (checkBoolean(originalBit.RfCoupler, paramBit.RfCoupler)) return false;
                        if (checkBoolean(originalBit.System, paramBit.System)) return false;
                    }
                }
            }

            if (checkObject(originalParameters.Common, @params.Common)) return false;

            if (originalParameters.Common != null)
            {
                var originalCommon = originalParameters.Common;
                var paramCommon = @params.Common;

                if (checkString(originalCommon.Mode, paramCommon.Mode)) return false;
                if (checkString(originalCommon.State, paramCommon.State)) return false;

                if (checkBoolean(originalCommon.Handset, paramCommon.Handset)) return false;
                if (checkBoolean(originalCommon.Sq, paramCommon.Sq)) return false;
                if (checkBoolean(originalCommon.Usb, paramCommon.Usb)) return false;
                if (checkBoolean(originalCommon.Coupler, paramCommon.Coupler)) return false;
            }


            if (checkObject(originalParameters.Program, @params.Program)) return false;

            if (originalParameters.Program != null)
            {
                var originalProgram = originalParameters.Program;
                var paramProgram = @params.Program;
                if (checkObject(originalProgram.Comsec, paramProgram.Comsec)) return false;

                if (originalProgram.Comsec != null)
                {
                    var originalComsec = originalProgram.Comsec;
                    var paramComsec = paramProgram.Comsec;

                    if (checkArray(originalComsec.Keys, paramComsec.Keys, 
                        complarer: (KeyProtobuf key1, KeyProtobuf key2) => {
                            return key1.Name == key2.Name
                            && key1.Type == key2.Type
                            && key1.Key_ == key2.Key_
                            && key1.AwsKey == key2.AwsKey;
                        },
                        finder: (Google.Protobuf.Collections.RepeatedField<KeyProtobuf> arr1, KeyProtobuf item) => {
                            foreach(var item1 in arr1)
                            {
                                if (item1.Name == item.Name) return item1;
                            }

                            return null;
                        })) return false;
                }

            }
            return true;
        }

        static bool checkArray<T>(Google.Protobuf.Collections.RepeatedField<T> arr1, 
            Google.Protobuf.Collections.RepeatedField<T> arr2, 
            Func<T, T, bool> complarer,
            Func<Google.Protobuf.Collections.RepeatedField<T>, T, T> finder)
        {
            foreach( var item in arr1 )
            {
                var foundItem = finder.Invoke(arr2, item);
                if (foundItem == null)
                {
                    return true;
                }

                if(!complarer.Invoke(item, foundItem))
                {
                    return true;
                }
            }

            return false;
        }

        static bool checkObject(object obj1, object obj2)
        {
            return obj1 != null && ((obj1 == null && obj2 != null) || (obj1 != null && obj2 == null));
        }

        static bool checkString(string str1, string str2)
        {
            return !string.IsNullOrEmpty(str1) && str1 != str2;
        }

        static bool checkBoolean(bool v1, bool v2)
        {
            return v1 && v1 != v2;
        }
    }
}
