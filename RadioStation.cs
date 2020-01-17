using System;
using System.Collections.Generic;

namespace Harris7800HMP
{
    public enum RadioStationMode
    {
        Fix, Ale, ThreeG, Hop
    };
    public class RadioStation
    {
        public enum SwitchOnSteps
        {
            Logo, Model, Init, AfterInit
        }

        private SwitchOnSteps onSteps = SwitchOnSteps.Logo;
        private Battery battery = new Battery();
        private bool receptionMode = true;
        private RadioStationMode mode = RadioStationMode.Fix;
        private Volume volume = new Volume();
        private Switcher switcher;
        private bool keyBoardLock = false;
        private string firstLine = "";
        private string secondLine = "";
        private string thirdLine = " ";
        private string fourthLine = "";
        private KeyModule keys = new KeyModule();
        private List<StationPresetModemModule> presetModemsModule = new List<StationPresetModemModule>();
        private StationPresetSystemContainer presetSystemsModule = new StationPresetSystemContainer();
        private TxMsgContainer txMsgs = new TxMsgContainer();

        public bool connectedUsb = false;
        public bool connectedHandset = false;
        public bool connectedCoupler = false;

        public RadioStation()
        {
            for (var i = 1; i <= 20; i++)
            {
                var numStr = i < 10 ? "0" + i : i.ToString();
                var m = new StationPresetModemModule {originalName = "MDM" + numStr, name = "MDM" + numStr};
                presetModemsModule.Add(m);
            }
        }
        public bool KeyBoardLock { get => keyBoardLock; set => keyBoardLock = value; }
        public SwitchOnSteps OnSteps { get => onSteps; set => onSteps = value; }
        public RadioStationMode Mode { get => mode; set => mode = value; }
        public KeyModule Keys { get => keys; set => keys = value; }
        public List<StationPresetModemModule> PresetModems { get => presetModemsModule; set => presetModemsModule = value; }
        public TxMsgContainer TxMsgs { get => txMsgs; set => txMsgs = value; }
        public StationPresetSystemContainer PresetSystemsModule { get => presetSystemsModule; set => presetSystemsModule = value; }

        public void AddPresetModem(StationPresetModemModule modem)
        {
            var isContains = presetModemsModule.Find(m => m.originalName == modem.originalName);
            if (isContains != null)
            {
                presetModemsModule.Remove(isContains);
            }
            presetModemsModule.Add(modem);
        }

        public void AddPresetSystem(List<WidgetTextParams> textParams, string oldName)
        {
            WidgetTextParams FindParam(string name)
            {
                return textParams.Find(tp => tp.Name == name);
            }

            string GetValueTextParam(string name)
            {
                return FindParam(name).CurrParam();
            }

            var stationPresetSystemModule = new StationPresetSystem();

            stationPresetSystemModule.name = GetValueTextParam("PRESET NAME");
            stationPresetSystemModule.radioMode = StringToMode(GetValueTextParam("RADIO MODE"));
            stationPresetSystemModule.channelNumber = GetValueTextParam("CHANNEL NUMBER");
            var modemPreset = GetValueTextParam("MODEM PRESET");
            var keyTypeName = GetValueTextParam("ENCRYPTION TYPE");
            var keyName = GetValueTextParam("ENCRYPTION KEY");
            stationPresetSystemModule.ptVoiceMode = GetValueTextParam("PT VOICE MODE");
            stationPresetSystemModule.ctVoiceMode = GetValueTextParam("CT VOICE MODE");
            stationPresetSystemModule.enable = GetValueTextParam("ENABLE");


            if (modemPreset != "OFF")
            {
                stationPresetSystemModule.modemPreset = PresetModems.Find(pm => pm.name == modemPreset);
            }

            if (keyName == "--------------------")
            {
                var kType = KeyModule.StringToType(keyTypeName);
                var value = Keys.Keys[kType].Find(k => k.keyName == keyName);
                stationPresetSystemModule.key = new KeyValuePair<KeyModule.KeyType, KeyModule.KeyValue>(kType, value);
            }
            else
            {
                var kType = KeyModule.StringToType(keyTypeName);
                stationPresetSystemModule.key = new KeyValuePair<KeyModule.KeyType, KeyModule.KeyValue>(kType, null);
            }

            var isContains = presetSystemsModule.SystemPresets.Find(psm => psm.name == oldName);
            if (isContains != null)
            {
                presetSystemsModule.SystemPresets.Remove(isContains);
            }

            presetSystemsModule.AddPresetSystem(stationPresetSystemModule);
        }
        public void UpdatePresetModem(StationPresetModemModule modem, string oldName)
        {
            var isContains = presetModemsModule.Find(m => m.name == oldName);
            if (isContains != null)
            {
                presetModemsModule.Remove(isContains);
            }
            presetModemsModule.Add(modem);
        }

        public string CurrentModeToString()
        {
            return ModeToString(mode);
        }

        public static string ModeToString(RadioStationMode mode)
        {
            return mode == RadioStationMode.ThreeG ? "3G " : Enum.GetName(typeof(RadioStationMode), mode)?.ToUpper();
        }

        public static RadioStationMode StringToMode(string str)
        {

            switch (str)
            {
                case "3G ":
                case "3G":
                    {
                        return RadioStationMode.ThreeG;
                    }
                case "FIX":
                    {
                        return RadioStationMode.Fix;
                    }
                case "ALE":
                    {
                        return RadioStationMode.Ale;
                    }
                case "HOP":
                    {
                        return RadioStationMode.Hop;
                    }
            }
            return RadioStationMode.Fix;
        }

        public RadioStation(Switcher sw)
        {
            switcher = sw;
            for (var i = 1; i <= 20; i++)
            {
                var numStr = i < 10 ? "0" + i : i.ToString();
                var m = new StationPresetModemModule {originalName = "MDM" + numStr, name = "MDM" + numStr};
                presetModemsModule.Add(m);
            }
        }

        public SwitcherState GetState()
        {
            return switcher.State;
        }

        public bool IsOff()
        {
            return switcher.State == SwitcherState.OFF;
        }

        public void NextState()
        {
            switcher.NextState();

            //sec
        }

        public override string ToString()
        {
            if (switcher.State == SwitcherState.OFF)
            {
                return "";
            }

            return GetFirstLine()
                + "\n" + GetSecondLine()
                + "\n" + GetThirdLine()
                + "\n" + GetFourthLine();
        }
        public string GetFirstLine()
        {
            var result = " ";
            if (receptionMode)
            {
                result += "R";
            }

            result += " " + battery.ToString();

            switch (Mode)
            {
                case RadioStationMode.Ale:
                    {
                        result += " ALE";
                        break;
                    }
                case RadioStationMode.Fix:
                    {
                        result += " FIX";
                        break;
                    }
                case RadioStationMode.Hop:
                    {
                        result += " HOP";
                        break;
                    }
                case RadioStationMode.ThreeG:
                    {
                        result += " 3G ";
                        break;
                    }
            }

            switch (switcher.State)
            {
                case SwitcherState.CLR:
                    {
                        result += " CLR";
                        break;
                    }
                case SwitcherState.CT:
                    {
                        result += " CT ";
                        break;
                    }
                case SwitcherState.LD:
                    {
                        result += " LD ";
                        break;
                    }
                case SwitcherState.PT:
                    {
                        result += " PT ";
                        break;
                    }
                case SwitcherState.Z:
                    {
                        result += " Z  ";
                        break;
                    }
            }

            return result;
        }

        public string GetSecondLine()
        {
            return secondLine;
        }

        public string GetThirdLine()
        {
            return thirdLine;
        }

        public string GetFourthLine()
        {
            return fourthLine;
        }

        public RadioStationMode NextMode()
        {
            if ((int)Mode + 1 > 3)
            {
                Mode = RadioStationMode.Fix;
            }
            else
            {
                Mode += 1;
            }

            switch (Mode)
            {
                case RadioStationMode.Ale:
                    {
                        secondLine = Helper.CenterString(Helper.emptySpaceString, ">>>  ALE  <<<");
                        break;
                    }
                case RadioStationMode.Fix:
                    {
                        secondLine = Helper.CenterString(Helper.emptySpaceString, ">>>  FIX  <<<");
                        break;
                    }
                case RadioStationMode.Hop:
                    {
                        secondLine = Helper.CenterString(Helper.emptySpaceString, ">>>  HOP  <<<");
                        break;
                    }
                case RadioStationMode.ThreeG:
                    {
                        secondLine = Helper.CenterString(Helper.emptySpaceString, ">>>  3G  <<<");
                        break;
                    }
            }

            fourthLine = Helper.CenterString(Helper.emptySpaceString, "MODE TO SELECT");

            return Mode;
        }
    }
}
