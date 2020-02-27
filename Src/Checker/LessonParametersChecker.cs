using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LessonParametersSet;
using KeyProtobuf = LessonParametersSet.LessonParameters.Types.Program.Types.Comsec.Types.Key;
using ChannelProtobuf = LessonParametersSet.LessonParameters.Types.Program.Types.Mode.Types.Preset.Types.Channel;
using ModemProtobuf = LessonParametersSet.LessonParameters.Types.Program.Types.Mode.Types.Preset.Types.Modem;
using SystemProtobuf = LessonParametersSet.LessonParameters.Types.Program.Types.Mode.Types.Preset.Types.System;

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

                    if (checkString(originRadio.CheckBfo, originRadio.Bfo, paramsRadio.Bfo)) return false;
                    if (checkString(originRadio.CheckFmSquelchType, originRadio.FmSquelchType, paramsRadio.FmSquelchType)) return false;
                    if (checkString(originRadio.CheckInternalCoupler, originRadio.InternalCoupler, paramsRadio.InternalCoupler)) return false;
                    if (checkString(originRadio.CheckRadioLock, originRadio.RadioLock, paramsRadio.RadioLock)) return false;
                    if (checkString(originRadio.CheckRadioSilence, originRadio.RadioSilence, paramsRadio.RadioSilence)) return false;
                    if (checkString(originRadio.CheckRxNoiceBlanking, originRadio.RxNoiceBlanking, paramsRadio.RxNoiceBlanking)) return false;
                    if (checkString(originRadio.CheckSquelchLevel, originRadio.SquelchLevel, paramsRadio.SquelchLevel)) return false;
                    if (checkString(originRadio.CheckTxPowerLevel, originRadio.TxPowerLevel, paramsRadio.TxPowerLevel)) return false;

                }

                if (checkObject(originOption.Test, paramsOption.Test)) return false;

                if (originOption.Test != null)
                {
                    var originalTest = originOption.Test;
                    var paramTest = paramsOption.Test;

                    if (checkBoolean(originalTest.CheckBattery, originalTest.Battery, paramTest.Battery)) return false;
                    if (checkBoolean(originalTest.CheckTemp, originalTest.Temp, paramTest.Temp)) return false;
                    if (checkString(originalTest.CheckVswrFrequency, originalTest.VswrFrequency, paramTest.VswrFrequency)) return false;

                    if (checkObject(originalTest.Bit, paramTest.Bit)) return false;

                    if (originalTest.Bit != null)
                    {
                        var originalBit = originalTest.Bit;
                        var paramBit = paramTest.Bit;

                        if (checkBoolean(originalBit.CheckExternalPa, originalBit.ExternalPa, paramBit.ExternalPa)) return false;
                        if (checkBoolean(originalBit.CheckInternalCoupler, originalBit.InternalCoupler, paramBit.InternalCoupler)) return false;
                        if (checkBoolean(originalBit.CheckKdp, originalBit.Kdp, paramBit.Kdp)) return false;
                        if (checkBoolean(originalBit.CheckKdu, originalBit.Kdu, paramBit.Kdu)) return false;
                        if (checkBoolean(originalBit.CheckPrepost, originalBit.Prepost, paramBit.Prepost)) return false;
                        if (checkBoolean(originalBit.CheckRfCoupler, originalBit.RfCoupler, paramBit.RfCoupler)) return false;
                        if (checkBoolean(originalBit.CheckSystem, originalBit.System, paramBit.System)) return false;
                    }
                }
            }

            if (checkObject(originalParameters.Common, @params.Common)) return false;

            if (originalParameters.Common != null)
            {
                var originalCommon = originalParameters.Common;
                var paramCommon = @params.Common;

                if (checkString(originalCommon.CheckMode, originalCommon.Mode, paramCommon.Mode)) return false;
                if (checkString(originalCommon.CheckState, originalCommon.State, paramCommon.State)) return false;

                if (checkBoolean(originalCommon.CheckHandset, originalCommon.Handset, paramCommon.Handset)) return false;
                if (checkBoolean(originalCommon.CheckSq, originalCommon.Sq, paramCommon.Sq)) return false;
                if (checkBoolean(originalCommon.CheckUsb, originalCommon.Usb, paramCommon.Usb)) return false;
                if (checkBoolean(originalCommon.CheckCoupler, originalCommon.Coupler, paramCommon.Coupler)) return false;
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
                        comparer: (KeyProtobuf key1, KeyProtobuf key2) => {

                            if (checkString(key1.CheckName, key1.Name, key2.Name)) return false;
                            if (checkString(key1.CheckKey, key1.Key_, key2.Key_)) return false;
                            if (checkString(key1.CheckAwsKey, key1.AwsKey, key2.AwsKey)) return false;
                            if (key1.CheckType && key1.Type != key2.Type) return false;

                            return true;
                        },
                        finder: (Google.Protobuf.Collections.RepeatedField<KeyProtobuf> arr1, KeyProtobuf item) => {
                            foreach(var item1 in arr1)
                            {
                                if (item1.Name == item.Name) return item1;
                            }

                            return null;
                        })) return false;
                }

                if (checkObject(originalProgram.Mode, paramProgram.Mode)) return false;

                if (originalProgram.Mode != null)
                {
                    var originalMode = originalProgram.Mode;
                    var paramMode = paramProgram.Mode;

                    if (checkObject(originalMode.Preset, paramMode.Preset)) return false;

                    if (originalMode.Preset != null)
                    {

                        var originalPreset = originalMode.Preset;
                        var paramPreset = paramMode.Preset;

                        if (checkArray(originalPreset.Channels, paramPreset.Channels,
                            comparer: (ChannelProtobuf item1, ChannelProtobuf item2) =>
                            {

                                if (checkString(item1.CheckNum, item1.Num, item2.Num)) return false;
                                if (checkBoolean(item1.CheckEnableSsbScan, item1.EnableSsbScan, item2.EnableSsbScan)) return false;
                                if (checkString(item1.CheckHailKey, item1.HailKey, item2.HailKey)) return false;
                                if (checkBoolean(item1.CheckMode, item1.Mode, item2.Mode)) return false;
                                if (checkString(item1.CheckModulation, item1.Modulation, item2.Modulation)) return false;
                                if (checkString(item1.CheckRxFrequency, item1.RxFrequency, item2.RxFrequency)) return false;
                                if (checkString(item1.CheckTxFrequency, item1.TxFrequency, item2.TxFrequency)) return false;

                                return true;
                            },
                            finder: (Google.Protobuf.Collections.RepeatedField<ChannelProtobuf> arr2, ChannelProtobuf item) =>
                            {
                                foreach (var item1 in arr2)
                                {
                                    if (item1.Num == item.Num) return item1;
                                }

                                return null;
                            })) return false;

                        if (checkArray(originalPreset.Modems, paramPreset.Modems,
                            comparer: (ModemProtobuf item1, ModemProtobuf item2) =>
                            {
                                if (checkString(item1.CheckDataBits, item1.DataBits, item2.DataBits)) return false;
                                if (checkString(item1.CheckDataRate, item1.DataRate, item2.DataRate)) return false;
                                if (checkString(item1.CheckEnable, item1.Enable, item2.Enable)) return false;
                                if (checkString(item1.CheckMode, item1.Mode, item2.Mode)) return false;
                                if (checkString(item1.CheckModemType, item1.ModemType, item2.ModemType)) return false;
                                if (checkString(item1.CheckName, item1.Name, item2.Name)) return false;
                                if (checkString(item1.CheckParity, item1.Parity, item2.Parity)) return false;
                                if (checkString(item1.CheckStopBits, item1.StopBits, item2.StopBits)) return false;
                                return true;
                            },
                            finder: (Google.Protobuf.Collections.RepeatedField<ModemProtobuf> arr2, ModemProtobuf item) =>
                            {
                                foreach (var item1 in arr2)
                                {
                                    if (item1.Name == item.Name) return item1;
                                }

                                return null;
                            })) return false;

                        if (checkArray(originalPreset.Systems, paramPreset.Systems,
                            comparer: (SystemProtobuf item1, SystemProtobuf item2) =>
                            {

                                if (checkString(item1.CheckChannelNumber, item1.ChannelNumber, item2.ChannelNumber)) return false;
                                if (checkString(item1.CheckCtVoiceMode, item1.CtVoiceMode, item2.CtVoiceMode)) return false;
                                if (checkString(item1.CheckPtVoiceMode, item1.PtVoiceMode, item2.PtVoiceMode)) return false;
                                if (checkString(item1.CheckName, item1.Name, item2.Name)) return false;
                                if (checkString(item1.CheckEnable, item1.Enable, item2.Enable)) return false;

                                if (checkObject(item1.ModemPreset, item2.ModemPreset)) return false;

                                if (item1.ModemPreset != null)
                                {
                                    var modemPreset1 = item1.ModemPreset;
                                    var modemPreset2 = item2.ModemPreset;
                                    if (checkString(item1.CheckModemPreset, modemPreset1.Name, modemPreset2.Name)) return false;
                                }

                                if (checkObject(item1.Key, item2.Key)) return false;

                                if (item1.Key != null)
                                {
                                    var key1 = item1.Key;
                                    var key2 = item2.Key;
                                    if (checkString(item1.CheckKeyValue, key1.Name, key2.Name)) return false;
                                    if (item1.CheckKey && key1.Type != key2.Type) return false;
                                }

                                return true;
                            },
                            finder: (Google.Protobuf.Collections.RepeatedField<SystemProtobuf> arr2, SystemProtobuf item) =>
                            {
                                foreach (var item1 in arr2)
                                {
                                    if (item1.Name == item.Name) return item1;
                                }

                                return null;
                            })) return false;
                    }
                }
            }
            return true;
        }

        static bool checkArray<T>(Google.Protobuf.Collections.RepeatedField<T> arr1, 
            Google.Protobuf.Collections.RepeatedField<T> arr2, 
            Func<T, T, bool> comparer,
            Func<Google.Protobuf.Collections.RepeatedField<T>, T, T> finder)
        {
            foreach( var item in arr1 )
            {
                var foundItem = finder.Invoke(arr2, item);
                if (foundItem == null)
                {
                    return true;
                }

                if(!comparer.Invoke(item, foundItem))
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

        static bool checkString(bool isNeedCheck, string str1, string str2)
        {
            if (!isNeedCheck) return false;
            return !string.IsNullOrEmpty(str1) && str1 != str2;
        }

        static bool checkBoolean(bool isNeedCheck, bool v1, bool v2)
        {
            if (!isNeedCheck) return false;
            return v1 && v1 != v2;
        }
    }
}
