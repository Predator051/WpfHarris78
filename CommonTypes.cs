using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Harris7800HMP
{
    public enum ChargingStatus { Low, Middle, High };
    public class Battery
    {

        private string chargSymbol = "■";
        private ChargingStatus chargingStatus = ChargingStatus.High;

        public override string ToString()
        {
            var result = "BAT ";
            if (chargingStatus > ChargingStatus.Low)
            {
                result += chargSymbol;
            }
            if (chargingStatus > ChargingStatus.Middle)
            {
                result += chargSymbol;
            }
            if (chargingStatus >= ChargingStatus.High)
            {
                result += chargSymbol;
            }
            return result;
        }

    }

    public class Volume
    {

        private string volumeSymbol = "■";
        private int level = 1;

        public override string ToString()
        {
            if (level == 1)
            {
                return "VOL ■  ";
            }
            if (level == 2)
            {
                return "VOL ■■ ";
            }
            return "VOL ■■■";
        }

    }

    public class WidgetTextParams
    {
        private string name;
        private List<string> parameters = new List<string>();
        private int currIndex = 0;

        public WidgetTextParams(string name)
        {
            Name = name;
        }

        public string Name { get => name; set => name = value; }
        public int CurrIndex { get => currIndex; set => currIndex = value; }
        public List<string> Parameters { get => parameters; set => parameters = value; }

        public WidgetTextParams AddParam(string name)
        {
            parameters.Add(name);
            return this;
        }

        public string GetNextParam()
        {
            currIndex++;
            if (currIndex >= parameters.Count)
            {
                currIndex = 0;
            }
            return parameters[currIndex];
        }
        public string GetPrevParam()
        {
            currIndex--;

            if (currIndex < 0)
            {
                currIndex = parameters.Count - 1;
            }
            return parameters[currIndex];
        }

        public string CurrParam()
        {
            return parameters[currIndex];
        }

        public static bool operator ==(WidgetTextParams a, WidgetTextParams b)
        {
            return a.Name == b.Name;
        }
        public static bool operator !=(WidgetTextParams a, WidgetTextParams b)
        {
            return a.Name != b.Name;
        }

        public void Clear()
        {
            currIndex = 0;
            parameters.Clear();
        }
    }

    public class SmsMenu
    {
        private List<string> numberSms = new List<string>() {
            "", "", "", "", "", "", "", "", "", ""
        };
        private int currentIndex = 0;

        public int CurrentIndex { get => currentIndex; set => currentIndex = value; }
        public List<string> NumberSms { get => numberSms; set => numberSms = value; }

        public void Next()
        {
            CurrentIndex++;
            if (CurrentIndex > NumberSms.Count - 1)
            {
                CurrentIndex = 0;
            }
        }

        public void Previous()
        {
            CurrentIndex--;
            if (CurrentIndex < 0)
            {
                CurrentIndex = NumberSms.Count - 1;
            }
        }

        public Tuple<string, string> GetPair()
        {
            int firstInd;
            int secondInd;
            if (CurrentIndex % 2 == 0)
            {
                firstInd = CurrentIndex;
                secondInd = CurrentIndex + 1;
            }
            else
            {
                firstInd = CurrentIndex - 1;
                secondInd = CurrentIndex;
            }
            var firstStr = firstInd + ":" + NumberSms[firstInd];
            var secondStr = secondInd + ":" + NumberSms[secondInd];
            return new Tuple<string, string>(firstStr, secondStr);
        }
    }

    public class KeyModule
    {
        public enum KeyType
        {
            None,
            Citadel1,
            Aes256,
            Aes128
        }

        public static string TypeToString(KeyType type)
        {
            switch (type)
            {
                case KeyType.Aes128:
                    {
                        return "AES-128";
                    }
                case KeyType.Aes256:
                    {
                        return "AES-256";
                    }
                case KeyType.Citadel1:
                    {
                        return "CITADEL I (MK-128)";
                    }
            }
            return "";
        }

        public static KeyType StringToType(string typeStr)
        {
            switch (typeStr)
            {
                case "AES-128":
                    {
                        return KeyType.Aes128;
                    }
                case "AES-256":
                    {
                        return KeyType.Aes256;
                    }
                case "CITADEL":
                case "CITADEL I (MK-128)":
                    {
                        return KeyType.Citadel1;
                    }
            }
            return KeyType.None;
        }

        public class KeyValue
        {
            public string keyName = "";
            public string keyVal = "";
            public string keyAws = "";
            public RadioStationMode stationMode = RadioStationMode.Fix;
            public int updateCount = 0;
            public KeyType type = KeyType.None;
            public string CountToString()
            {
                if (updateCount < 10)
                {
                    return "0" + updateCount;
                }
                return updateCount.ToString();
            }
        }

        private Dictionary<KeyType, List<KeyValue>> keys = new Dictionary<KeyType, List<KeyValue>> {
            {KeyType.Citadel1, new List<KeyValue>() },
            {KeyType.Aes256, new List<KeyValue>() },
            {KeyType.Aes128, new List<KeyValue>() },
        };

        public int Count(Func<KeyValue, bool> predicat)
        {
            int result = 0;

            foreach (var pair in keys)
            {
                foreach (var keyVal in pair.Value)
                {
                    if ((bool)predicat?.Invoke(keyVal))
                    {
                        result++;
                    }
                }
            }

            return result;
        }

        public KeyValuePair<KeyType, KeyValue> FindFirstCryptoKey ( Func<KeyType, KeyValue, bool> predicat)
        {
            foreach(var pair in keys)
            {
                foreach (var keyVal in pair.Value)
                {
                    if ((bool)predicat?.Invoke(pair.Key, keyVal))
                    {
                        return new KeyValuePair<KeyType, KeyValue>(pair.Key, keyVal);
                    }
                }
            }

            return new KeyValuePair<KeyType, KeyValue>(KeyType.None, null);
        }

        public List<KeyValue> GetCryptoKeysByMode (RadioStationMode mode)
        {
            List<KeyValue> keysResult = new List<KeyValue>();


            foreach (var pair in keys)
            {
                foreach (var keyVal in pair.Value)
                {
                    if (keyVal.stationMode == mode)
                    {
                        keysResult.Add(keyVal);
                    }
                }
            }

            return keysResult;
        }

        public Dictionary<KeyType, List<KeyValue>> Keys { get => keys; set => keys = value; }

        public void AddKey(KeyType type, KeyValue value)
        {
            value.type = type;
            keys[type].Add(value);
        }

        public bool IsContainKey(string name)
        {
            var keysName = Keys.Values.ToList();
            foreach (var klist in keysName)
            {
                foreach (var k in klist)
                {
                    if (k.keyName == name)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public KeyValue FindKey(string name)
        {
            var keysName = Keys.Values.ToList();
            foreach (var klist in keysName)
            {
                foreach (var k in klist)
                {
                    if (k.keyName == name)
                    {
                        return k;
                    }
                }
            }
            return null;
        }
    }

    public class StationPresetModemModule
    {
        public string name;
        public string modemType;
        public string dataRate;
        public string mode;
        public string dataBits;
        public string stopBits;
        public string parity;
        public string enable;
        public string originalName = "";

        public void ParseFromListWidgetTextParams(List<WidgetTextParams> textParams)
        {
            WidgetTextParams FindParam(string name)
            {
                return textParams.Find(tp => tp.Name == name);
            }

            string GetValueTextParam(string name)
            {
                return FindParam(name).CurrParam();
            }

            name = GetValueTextParam("PRESET NAME");
            modemType = GetValueTextParam("MODEM TYPE");
            dataRate = GetValueTextParam("DATA RATE");
            mode = GetValueTextParam("MODE");
            dataBits = GetValueTextParam("DATA BITS");
            stopBits = GetValueTextParam("STOP BITS");
            parity = GetValueTextParam("PARITY");
            enable = GetValueTextParam("ENABLE");
        }

        public static StationPresetModemModule Parse(List<WidgetTextParams> textParams)
        {
            var module = new StationPresetModemModule();
            module.ParseFromListWidgetTextParams(textParams);
            return module;
        }
    }

    public class StationPresetSystem
    {
        public string name;
        public RadioStationMode radioMode;
        public string channelNumber;
        public StationPresetModemModule modemPreset;
        public KeyValuePair<KeyModule.KeyType, KeyModule.KeyValue> key;
        public string ptVoiceMode;
        public string ctVoiceMode;
        public string enable;
    }

    public class StationPresetSystemContainer
    {
        private List<StationPresetSystem> systemPresets = new List<StationPresetSystem>();
        private int currIndex = 0;

        public StationPresetSystemContainer()
        {
            var def = new StationPresetSystem
            {
                channelNumber = "001",
                enable = "ON",
                key = new KeyValuePair<KeyModule.KeyType, KeyModule.KeyValue>(KeyModule.KeyType.None, null),
                ctVoiceMode = "CLR",
                modemPreset = null,
                radioMode = RadioStationMode.Fix
            };
            systemPresets.Add(def);
        }

        public List<StationPresetSystem> SystemPresets { get => systemPresets; set => systemPresets = value; }

        public void AddPresetSystem(StationPresetSystem newPreset)
        {
            SystemPresets.Add(newPreset);
        }

        public StationPresetSystem NextPreset()
        {
            currIndex++;
            if (currIndex > SystemPresets.Count - 1)
            {
                currIndex = 0;
            }

            return SystemPresets[currIndex];
        }

        public StationPresetSystem PrevPreset()
        {
            currIndex--;
            if (currIndex < 0)
            {
                currIndex = SystemPresets.Count - 1;
            }

            return SystemPresets[currIndex];
        }
    }

    public class TxMsg
    {
        public static string emptyMsg = "----------------------";
        public string msg;
        public int number;
        public bool IsDefault()
        {
            return msg == emptyMsg;
        }
    }

    public class TxMsgContainer
    {
        private List<TxMsg> msgs;
        private int currIndex = 0;

        public bool IsEmpty()
        {
            return !msgs.Any((TxMsg msg) =>
            {
                return msg.msg != TxMsg.emptyMsg;
            });
        }

        public TxMsgContainer()
        {
            msgs = new List<TxMsg>();

            for (var i = 0; i <= 9; i++)
            {
                var tx = new TxMsg {msg = TxMsg.emptyMsg, number = i + 1};
                msgs.Add(tx);
            }
        }

        public List<TxMsg> Msgs { get => msgs; set => msgs = value; }

        public TxMsg CurrMsg()
        {
            if (msgs.Count == 0)
            {
                return null;
            }

            return msgs[currIndex];
        }

        public TxMsg NextNdMsg()
        {
            currIndex++;
            var found = false;

            for (; currIndex < msgs.Count; currIndex++)
            {
                if (msgs[currIndex].IsDefault())
                {
                    continue;
                }
                found = true;
                break;
            }

            if (!found)
            {
                currIndex = 0;
                for (; currIndex < msgs.Count; currIndex++)
                {
                    if (msgs[currIndex].IsDefault())
                    {
                        continue;
                    }
                    break;
                }
            }

            return msgs[currIndex];
        }

        public TxMsg PrevNdMsg()
        {
            currIndex--;
            var found = false;
            for (; currIndex >= 0; currIndex--)
            {
                if (msgs[currIndex].IsDefault())
                {
                    continue;
                }
                found = true;
                break;
            }

            if (!found)
            {
                currIndex = msgs.Count - 1;
                for (; currIndex >= 0; currIndex--)
                {
                    if (msgs[currIndex].IsDefault())
                    {
                        continue;
                    }
                    break;
                }
            }

            return msgs[currIndex];
        }
        public TxMsg NextMsg()
        {
            currIndex++;
            if (currIndex > msgs.Count - 1)
            {
                currIndex = 0;
            }

            return msgs[currIndex];
        }

        public TxMsg PrevMsg()
        {
            currIndex--;
            if (currIndex < 0)
            {
                currIndex = msgs.Count - 1;
            }

            return msgs[currIndex];
        }
    }

    public class Square
    {
        private Point p1, p2, p3, p4;

        public Square(Point leftTop, int sideLenght)
        {
            p1 = leftTop;
            p2 = new Point(p1.X + sideLenght, p1.Y);
            p3 = new Point(p1.X + sideLenght, p1.Y + sideLenght);
            p4 = new Point(p1.X, p1.Y + sideLenght);
        }

        public bool IsPointInto(Point point)
        {
            return point.X > p1.X && point.Y > p1.Y && point.X < p3.X && point.Y < p3.Y;
        }
    }
}
