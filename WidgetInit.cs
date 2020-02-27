using System;
using System.Collections.Generic;
using System.Linq;
using WpfHarris78;

namespace Harris7800HMP
{
    internal class WidgetInit
    {
        public enum MenuNames
        {
            MainMenu,
            MainMenu2,
            CallMenu,
            CallingMenu,
            MainMenuDisplayOpt,
            ProgramMenu,
            ProgramComsecMenu,
            ProgramComsecIdMenu,
            ProgramComsecMiMenu,
            ProgramComsecAksMenu,
            ProgramComsecKeysMenu,
            ProgramModeMenu,
            ProgramModePresetMenu,
            ProgramModePresetChannelMenu,
            ProgramModePresetModemMenu,
            ProgramModePresetSystemMenu,
            ProgramModeAleMenu,
            ProgramModeAleAmdMenu,
            ProgramModeAleAmdTxMsgMenu,
            TransitionProgramMenu,
            ProgramMenu2,
            OptionMenu,
            OptionMenu2,
            OptionMenuTest,
            OptionMenuRadio,
            KeyboardLock,
            OptionGpsTodMenu,
            OptionScanMenu,
            OptionThreeGMenu,
            OptionThreeG2Menu,
            OptionExtAccMenu,
            OptionTestBitMenu,
            OptionTestBatteryMenu,
            OptionTestTempMenu,
            OptionTestVswrMenu,
            OptionTestSpecialMenu,
            OptionTestSpecialVersionMenu,
            OptionTestSpecialConfigMenu,
            SelectModeMenu,
            OptionMsgMenu,
            OptionMsgSmsMenu,
            OptionMsgSmsFunctionsMenu,
            OptionMsgEnterSmsMenu,
            OptionMsgSmsSendingMenu,
            OptionAleMenu,
            OptionAleLqaMenu,
            OptionAleLqaExchangeMenu,

        }

        private static SmsMenu _smsControls = new SmsMenu();
        public static string GetNameMenu(MenuNames name)
        {
            return Enum.GetName(typeof(MenuNames), name);
        }

        public static Dictionary<string, Widget> widgetContainer = new Dictionary<string, Widget>();

        public static Widget InitDefaultWidgets(RadioStation station)
        {
            var mainMenu = InitMainMenu(station);
            var mainMenu2 = InitMainMenu2(station);
            var callMenu = InitCallMenu(station);
            var callingMenu = InitCallingMenu(station);
            var mainMenuDisplayOpt = InitMainMenuDisplayOpt(station);
            var programMenu = InitProgramMenu(station);
            var transitionPm = InitTransitionProgramMenu(station);
            var programMenu2 = InitProgramMenu2(station);
            var optionMenu = InitOptionMenu(station);
            var optionMenu2 = InitOptionMenu2(station);
            var optionMenuTest = InitOptionMenuTest(station);
            var optionMenuTestVswr = InitOptionTestVswr(station);
            var optionMenuRadio = InitOptionMenuRadio(station);
            var keyBoardLock = InitKeyboardLockMenu(station);
            var optionMenuGps = InitOptionGpsTodMenu(station);
            var optionScanMenu = InitOptionScanMenu(station);
            var optionExtAccMenu = InitOptionExtAccMenu(station);
            var optionThreeGMenu = InitOptionThreeGMenu(station);
            var optionThreeG2Menu = InitOptionThreeG2Menu(station);
            var optionTestBitMenu = InitOptionTestBitMenu(station);
            var optionTestBatteryMenu = InitOptionTestBatteryMenu(station);
            var optionTestTempMenu = InitOptionTestTempMenu(station);
            var optionTestSpecialMenu = InitOptionTestSpecialMenu(station);
            var optionTestSpecialVersionMenu = InitOptionTestSpecialVersionMenu(station);
            var optionTestSpecialConfigMenu = InitOptionTestSpecialConfigMenu(station);
            var optionModeSelectMenu = InitSelectModeMenu(station);
            var optionMsgMenu = InitOptionMsgMenu(station);
            var optionMsgSmsMenu = InitOptionMsgSmsMenu(station);
            var optionMsgSmsFunctionsMenu = InitOptionMsgSmsFunctionsMenu(station);
            var optionMsgEnterSmsMenu = InitOptionMsgNewSmsMenu(station);
            var optionMsgSmsSendingMenu = InitOptionMsgSmsSendingMenu(station);
            var optionAleMenu = InitOptionAleMenu(station);
            var optionAleLqaMenu = InitOptionAleLqaMenu(station);
            var optionAleLqaExchangeMenu = InitOptionAleLqaExchangeMenu(station);
            var programComsecMenu = InitProgramComsecMenu(station);
            var programComsecIdMenu = InitProgramComsecIdMenu(station);
            var programComsecMiMenu = InitProgramComsecMiMenu(station);
            var programComsecAksMenu = InitProgramComsecAksMenu(station);
            var programComsecKeysMenu = InitProgramComsecKeysMenu(station);
            var programModeMenu = InitProgramModeMenu(station);
            var programModePresetMenu = InitProgramModePresetMenu(station);
            var programModePresetChannelMenu = InitProgramModePresetChannelMenu(station);
            var programModePresetModemMenu = InitProgramModePresetModemMenu(station);
            var programModePresetSystemMenu = InitProgramModePresetSystemMenu(station);
            var programModeAleMenu = InitProgramModeAleMenu(station);
            var programModeAleAmdMenu = InitProgramModeAleAmdMenu(station);
            var programModeAleAmdTxMsgMenu = InitProgramModeAleAmdTxMsgMenu(station);

            transitionPm.AddAvailableWidget(GetNameMenu(MenuNames.ProgramMenu), programMenu);

            mainMenu.AddAvailableWidget(GetNameMenu(MenuNames.TransitionProgramMenu), transitionPm);
            mainMenu.AddAvailableWidget(GetNameMenu(MenuNames.OptionMenu), optionMenu);
            mainMenu.AddAvailableWidget(GetNameMenu(MenuNames.KeyboardLock), keyBoardLock);
            mainMenu.AddAvailableWidget(GetNameMenu(MenuNames.SelectModeMenu), optionModeSelectMenu);
            mainMenu.AddAvailableWidget(GetNameMenu(MenuNames.MainMenuDisplayOpt), mainMenuDisplayOpt);
            mainMenu.AddAvailableWidget(GetNameMenu(MenuNames.MainMenu2), mainMenu2);
            mainMenu.AddAvailableWidget(GetNameMenu(MenuNames.CallMenu), callMenu);

            programMenu.AddAvailableWidget(GetNameMenu(MenuNames.ProgramMenu2), programMenu2);
            programMenu.AddAvailableWidget(GetNameMenu(MenuNames.ProgramComsecMenu), programComsecMenu);
            programMenu.AddAvailableWidget(GetNameMenu(MenuNames.ProgramModeMenu), programModeMenu);

            programComsecMenu.AddAvailableWidget(GetNameMenu(MenuNames.ProgramComsecIdMenu), programComsecIdMenu);
            programComsecMenu.AddAvailableWidget(GetNameMenu(MenuNames.ProgramComsecMiMenu), programComsecMiMenu);
            programComsecMenu.AddAvailableWidget(GetNameMenu(MenuNames.ProgramComsecAksMenu), programComsecAksMenu);
            programComsecMenu.AddAvailableWidget(GetNameMenu(MenuNames.ProgramComsecKeysMenu), programComsecKeysMenu);

            programModeMenu.AddAvailableWidget(GetNameMenu(MenuNames.ProgramModePresetMenu), programModePresetMenu);
            programModeMenu.AddAvailableWidget(GetNameMenu(MenuNames.ProgramModeAleMenu), programModeAleMenu);

            programModePresetMenu.AddAvailableWidget(GetNameMenu(MenuNames.ProgramModePresetChannelMenu), programModePresetChannelMenu);
            programModePresetMenu.AddAvailableWidget(GetNameMenu(MenuNames.ProgramModePresetModemMenu), programModePresetModemMenu);
            programModePresetMenu.AddAvailableWidget(GetNameMenu(MenuNames.ProgramModePresetSystemMenu), programModePresetSystemMenu);

            programModeAleMenu.AddAvailableWidget(GetNameMenu(MenuNames.ProgramModeAleAmdMenu), programModeAleAmdMenu);

            programModeAleAmdMenu.AddAvailableWidget(GetNameMenu(MenuNames.ProgramModeAleAmdTxMsgMenu), programModeAleAmdTxMsgMenu);

            optionMenu.AddAvailableWidget(GetNameMenu(MenuNames.OptionMenu2), optionMenu2);
            optionMenu.AddAvailableWidget(GetNameMenu(MenuNames.OptionMenuRadio), optionMenuRadio);
            optionMenu.AddAvailableWidget(GetNameMenu(MenuNames.OptionGpsTodMenu), optionMenuGps);
            optionMenu.AddAvailableWidget(GetNameMenu(MenuNames.OptionScanMenu), optionScanMenu);
            optionMenu.AddAvailableWidget(GetNameMenu(MenuNames.OptionThreeGMenu), optionThreeGMenu);
            optionMenu.AddAvailableWidget(GetNameMenu(MenuNames.OptionAleMenu), optionAleMenu);

            optionMenu2.AddAvailableWidget(GetNameMenu(MenuNames.OptionMenuTest), optionMenuTest);
            optionMenu2.AddAvailableWidget(GetNameMenu(MenuNames.OptionExtAccMenu), optionExtAccMenu);
            optionMenu2.AddAvailableWidget(GetNameMenu(MenuNames.OptionMsgMenu), optionMsgMenu);

            optionMenuRadio.AddAvailableWidget(GetNameMenu(MenuNames.MainMenu), mainMenu);
            optionMenuRadio.AddAvailableWidget(GetNameMenu(MenuNames.KeyboardLock), keyBoardLock);

            optionThreeGMenu.AddAvailableWidget(GetNameMenu(MenuNames.OptionThreeG2Menu), optionThreeG2Menu);

            keyBoardLock.AddAvailableWidget(GetNameMenu(MenuNames.MainMenu), mainMenu);

            optionMenuTest.AddAvailableWidget(GetNameMenu(MenuNames.OptionTestBitMenu), optionTestBitMenu);
            optionMenuTest.AddAvailableWidget(GetNameMenu(MenuNames.OptionTestBatteryMenu), optionTestBatteryMenu);
            optionMenuTest.AddAvailableWidget(GetNameMenu(MenuNames.OptionTestTempMenu), optionTestTempMenu);
            optionMenuTest.AddAvailableWidget(GetNameMenu(MenuNames.OptionTestSpecialMenu), optionTestSpecialMenu);
            optionMenuTest.AddAvailableWidget(GetNameMenu(MenuNames.OptionTestVswrMenu), optionMenuTestVswr);

            optionTestSpecialMenu.AddAvailableWidget(GetNameMenu(MenuNames.OptionTestSpecialVersionMenu), optionTestSpecialVersionMenu);
            optionTestSpecialMenu.AddAvailableWidget(GetNameMenu(MenuNames.OptionTestSpecialConfigMenu), optionTestSpecialConfigMenu);

            optionMsgMenu.AddAvailableWidget(GetNameMenu(MenuNames.OptionMsgSmsMenu), optionMsgSmsMenu);

            optionMsgSmsMenu.AddAvailableWidget(GetNameMenu(MenuNames.OptionMsgSmsFunctionsMenu), optionMsgSmsFunctionsMenu);

            optionMsgSmsFunctionsMenu.AddAvailableWidget(GetNameMenu(MenuNames.OptionMsgEnterSmsMenu), optionMsgEnterSmsMenu);

            optionMsgEnterSmsMenu.AddAvailableWidget(GetNameMenu(MenuNames.OptionMsgSmsSendingMenu), optionMsgSmsSendingMenu);

            optionAleMenu.AddAvailableWidget(GetNameMenu(MenuNames.OptionAleLqaMenu), optionAleLqaMenu);

            optionAleLqaMenu.AddAvailableWidget(GetNameMenu(MenuNames.OptionAleLqaExchangeMenu), optionAleLqaExchangeMenu);

            widgetContainer.Add(GetNameMenu(MenuNames.MainMenu), mainMenu);
            widgetContainer.Add(GetNameMenu(MenuNames.OptionMsgEnterSmsMenu), optionMsgEnterSmsMenu);
            widgetContainer.Add(GetNameMenu(MenuNames.ProgramComsecKeysMenu), programComsecKeysMenu);

            return mainMenu;
        }

        public static Widget InitMainMenu(RadioStation station)
        {
            var mainMenu = new Widget(Enum.GetName(typeof(MenuNames), MenuNames.MainMenu));
            mainMenu.LineSize[0] = 7;
            mainMenu.LineSize[1] = 11.5;
            mainMenu.LineSize[2] = 11.5;
            mainMenu.LineSize[3] = 7;
            mainMenu.LineCharOffset[0] = 6;
            mainMenu.LineCharOffset[1] = 5;
            mainMenu.LineCharOffset[2] = 6;
            mainMenu.LineCharOffset[3] = 5;

            mainMenu.AddParam(new Param("Body", null, "", 1, 0))
                .AddModesForParam("Body", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            mainMenu.AddParam(new Param("StationRTmode", null, "R", 1, 0))
                .AddModesForParam("StationRTmode", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            mainMenu.AddParam(new Param("Battery", null, "BAT ■■■■■", 1, 2))
                .AddModesForParam("Battery", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            mainMenu
                .AddParam(new Param("StationMode", null, "FIX", 1, 12, () =>
                {
                    mainMenu.GetParam("StationMode").Text = RadioStation.ModeToString(station.Mode);
                    WpfHarris78.Src.Checker.LessonParametersHolder.Holder.Parameters.Common.Mode = station.CurrentModeToString();
                }))
                .AddModesForParam("StationMode", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop }); ;
            mainMenu
                .AddParam(new Param("SQ", null, "SQ", 1, 16))
                .AddModesForParam("SQ", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop }); ;
            mainMenu
                .AddParam(new Param("SwitchState", null, "PT", 1, 19, () =>
                {
                    mainMenu.GetParam("SwitchState").Text = Enum.GetName(typeof(SwitcherState), station.GetState());
                }))
                .AddModesForParam("SwitchState", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            mainMenu
                .AddParam(new Param("SwitchStateChan", null, "S 3 6 9 *", 1, 30))
                .AddModesForParam("SwitchStateChan", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });

            mainMenu.AddParam(new Param("Manual", null, "MANUAL", 2, 0))
                .AddModesForParam("Manual", new List<RadioStationMode> { RadioStationMode.Ale, RadioStationMode.Hop });
            mainMenu.AddParam(new Param("UpdateSignal", null, "⟲▮▮▮▯", 2, 17))
                .AddModesForParam("UpdateSignal", new List<RadioStationMode> { RadioStationMode.Ale, RadioStationMode.Hop });

            mainMenu
                .AddParam(new Param("DataValue", (string text, Param cParam) =>
            {

            }, "OFF", 3, 0))
                .AddModesForParam("DataValue", new List<RadioStationMode> { RadioStationMode.Ale, RadioStationMode.Hop });
            mainMenu
                .AddParam(new Param("VoiceValue", (string text, Param cParam) =>
            {
                cParam.Text = text;
            }, "CLR", 3, 5))
                .AddModesForParam("VoiceValue", new List<RadioStationMode> { RadioStationMode.Ale, RadioStationMode.Hop });
            mainMenu
                .AddParam(new Param("KeyValue", null, "▬▬▬▬▬", 3, 11, () => {
                    var keyValueParam = mainMenu.GetParam("KeyValue");
                    if (station.GetState() != SwitcherState.CT)
                    {
                        keyValueParam.text = "▬▬▬▬▬";
                        return;
                    }

                    List<KeyModule.KeyValue> keys = station.Keys.GetCryptoKeysByMode(station.Mode);

                    if (keys.Count == 0)
                    {
                        keyValueParam.text = "▬▬▬▬▬";
                        keyValueParam.container = null;
                    }

                }))
                .AddModesForParam("KeyValue", new List<RadioStationMode> { RadioStationMode.Ale, RadioStationMode.Hop });
            mainMenu
                .AddParam(new Param("ChanValue", (string text, Param cParam) =>
            {
                cParam.text = cParam.Text.Remove(cParam.ActiveFrom, cParam.ActiveTo);
                cParam.text = cParam.Text.Insert(cParam.ActiveFrom, text);

            }, "003", 3, 18))
                .AddModesForParam("ChanValue", new List<RadioStationMode> { RadioStationMode.Ale, RadioStationMode.Hop });
            mainMenu.AddParam(new Param("Data", null, "DATA", 4, 0))
                .AddModesForParam("Data", new List<RadioStationMode> { RadioStationMode.Ale, RadioStationMode.Hop });
            mainMenu.AddParam(new Param("Voice", null, "VOICE", 4, 8))
                .AddModesForParam("Voice", new List<RadioStationMode> { RadioStationMode.Ale, RadioStationMode.Hop });
            mainMenu.AddParam(new Param("Key", null, "KEY", 4, 23))
                .AddModesForParam("Key", new List<RadioStationMode> { RadioStationMode.Ale, RadioStationMode.Hop });
            mainMenu.AddParam(new Param("Chan", null, "CHAN", 4, 35))
                .AddModesForParam("Chan", new List<RadioStationMode> { RadioStationMode.Ale, RadioStationMode.Hop });
            //CT State and KeyValue == active
            mainMenu.AddParam(new Param("KeyName", null, "", 4, 0, () => {
                var myParam = mainMenu.GetParam("KeyName");
                var keyValueParam = mainMenu.GetParam("KeyValue");

                if (station.GetState() != SwitcherState.CT 
                || station.Keys.Count(val => val.stationMode == station.Mode) == 0
                || !keyValueParam.IsActive) return;

                myParam.Text = keyValueParam.Text;
            }))
                .AddModesForParam("KeyName", new List<RadioStationMode> { RadioStationMode.Ale, RadioStationMode.Hop });
            mainMenu.AddParam(new Param("Sig", null, "SIG:QBLV", 4, 23))
                .AddModesForParam("Sig", new List<RadioStationMode> { RadioStationMode.Ale, RadioStationMode.Hop });
            mainMenu.AddParam(new Param("UC", null, "UC:00", 4, 35))
                .AddModesForParam("UC", new List<RadioStationMode> { RadioStationMode.Ale, RadioStationMode.Hop });

            var dataTitleParam = mainMenu.GetParam("Data");
            var voiceTitleParam = mainMenu.GetParam("Voice");
            var keyTitleParam = mainMenu.GetParam("Key");
            var chanTitleParam = mainMenu.GetParam("Chan");

            var keyNameParam = mainMenu.GetParam("KeyName");
            var sigParam = mainMenu.GetParam("Sig");
            var usParam = mainMenu.GetParam("UC");

            mainMenu.ignorParam(keyNameParam);
            mainMenu.ignorParam(sigParam);
            mainMenu.ignorParam(usParam);

            mainMenu.AddActionToParam(mainMenu.GetParam("SQ"), new Button("SQL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (wdg.ActiveParam() != null)
                {
                    return;
                }

                var param = wdg.GetParam("SQ");
                param.Text = param.Text == "SQ" ? "  " : "SQ";
                WpfHarris78.Src.Checker.LessonParametersHolder.Holder.Parameters.Common.Sq = param.Text == "SQ";
            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("ChanValue"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("ChanValue");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                if (activeParam.IsInParam())
                {
                    if (activeParam.ActiveFrom == 0)
                    {
                        activeParam.ActiveFrom = 2;
                        activeParam.ActiveTo = 1;
                    }
                    else
                    {
                        activeParam.ActiveFrom -= 1;
                        activeParam.ActiveTo = 1;
                    }
                    return;
                }

                switch (activeParam.Name)
                {
                    case "ChanValue":
                        {
                            var param = wdg.GetParam("KeyValue");
                            wdg.DeactiveParam();
                            param.IsActive = true;

                            if (station.GetState() != SwitcherState.CT
                                || station.Keys.Count(val => val.stationMode == station.Mode) == 0) return;

                            mainMenu.ignorParam(dataTitleParam);
                            mainMenu.ignorParam(voiceTitleParam);
                            mainMenu.ignorParam(keyTitleParam);
                            mainMenu.ignorParam(chanTitleParam);

                            mainMenu.unignorParam(keyNameParam);
                            mainMenu.unignorParam(sigParam);
                            mainMenu.unignorParam(usParam);

                            break;
                        }
                    case "KeyValue":
                        {
                            var param = wdg.GetParam("VoiceValue");
                            wdg.DeactiveParam();
                            param.IsActive = true;

                            mainMenu.unignorParam(dataTitleParam);
                            mainMenu.unignorParam(voiceTitleParam);
                            mainMenu.unignorParam(keyTitleParam);
                            mainMenu.unignorParam(chanTitleParam);

                            mainMenu.ignorParam(keyNameParam);
                            mainMenu.ignorParam(sigParam);
                            mainMenu.ignorParam(usParam);

                            break;
                        }
                    case "VoiceValue":
                        {
                            var param = wdg.GetParam("DataValue");
                            wdg.DeactiveParam();
                            param.IsActive = true;

                            break;
                        }
                    case "DataValue":
                        {
                            var param = wdg.GetParam("ChanValue");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("ChanValue"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("ChanValue");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                if (activeParam.IsInParam())
                {
                    if (activeParam.ActiveFrom == 2)
                    {
                        activeParam.ActiveFrom = 0;
                        activeParam.ActiveTo = 1;
                    }
                    else
                    {
                        activeParam.ActiveFrom += 1;
                        activeParam.ActiveTo = 1;
                    }
                    return;
                }

                switch (activeParam.Name)
                {
                    case "ChanValue":
                        {

                            var param = wdg.GetParam("DataValue");
                            wdg.DeactiveParam();
                            param.IsActive = true;

                            dataTitleParam.IsVisible = true;
                            voiceTitleParam.IsVisible = true;
                            keyTitleParam.IsVisible = true;
                            chanTitleParam.IsVisible = true;

                            keyNameParam.IsVisible = false;
                            sigParam.IsVisible = false;
                            usParam.IsVisible = false;

                            break;
                        }
                    case "KeyValue":
                        {

                            var param = wdg.GetParam("ChanValue");
                            wdg.DeactiveParam();
                            param.IsActive = true;

                            mainMenu.unignorParam(dataTitleParam);
                            mainMenu.unignorParam(voiceTitleParam);
                            mainMenu.unignorParam(keyTitleParam);
                            mainMenu.unignorParam(chanTitleParam);

                            mainMenu.ignorParam(keyNameParam);
                            mainMenu.ignorParam(sigParam);
                            mainMenu.ignorParam(usParam);

                            break;
                        }
                    case "VoiceValue":
                        {

                            var param = wdg.GetParam("KeyValue");
                            wdg.DeactiveParam();
                            param.IsActive = true;

                            if (station.GetState() != SwitcherState.CT
                                || station.Keys.Count(val => val.stationMode == station.Mode) == 0) return;

                            mainMenu.ignorParam(dataTitleParam);
                            mainMenu.ignorParam(voiceTitleParam);
                            mainMenu.ignorParam(keyTitleParam);
                            mainMenu.ignorParam(chanTitleParam);

                            mainMenu.unignorParam(keyNameParam);
                            mainMenu.unignorParam(sigParam);
                            mainMenu.unignorParam(usParam);

                            break;
                        }
                    case "DataValue":
                        {
                            var param = wdg.GetParam("VoiceValue");
                            wdg.DeactiveParam();
                            param.IsActive = true;

                            break;
                        }
                }

            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("ChanValue"), new Button("CALL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null
                    || activeParam.Name != "ChanValue")
                {
                    mainMenu.PrepareToShowWidget(GetNameMenu(MenuNames.CallMenu));
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.Action("1");

            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("ChanValue"), new Button("LT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null
                    || activeParam.Name != "ChanValue")
                {
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.Action("2");

            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("ChanValue"), new Button("MODE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null
                    || activeParam.Name != "ChanValue")
                {
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.Action("3");

            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("ChanValue"), new Button("SQL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null
                    || activeParam.Name != "ChanValue")
                {
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.Action("4");

            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("ChanValue"), new Button("ZERO", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null
                    || activeParam.Name != "ChanValue")
                {
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.Action("5");

            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("ChanValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null
                    || activeParam.Name != "ChanValue")
                {
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.Action("6");

            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("ChanValue"), new Button("OPT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null
                    || activeParam.Name != "ChanValue")
                {
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.Action("7");

            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("ChanValue"), new Button("PGM", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null
                    || activeParam.Name != "ChanValue")
                {
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.Action("8");

            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("ChanValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null
                    || activeParam.Name != "ChanValue")
                {
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.Action("9");

            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("ChanValue"), new Button("UPDATE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null
                    || activeParam.Name != "ChanValue")
                {
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.Action("0");

            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("VoiceValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null
                    || activeParam.Name != "VoiceValue")
                {
                    return;
                }

                var values = new Dictionary<string, int>(){
                    { "CLR", 0 },
                    { "NONE", 1 },
                    { "LDV",  2 },
                    { "ME24", 3 },
                    { "ME12", 4 },
                    { "ME6", 5 },
                    { "DV24", 6 },
                    { "DV6", 7 },
                    { "AVS", 8 },
                    { "CVSD", 9 }
                };

                var valuesNum = new Dictionary<int, string>(){
                    { 0, "CLR" },
                    { 1, "NONE" },
                    { 2, "LDV" },
                    { 3 ,"ME24"},
                    { 4, "ME12"},
                    { 5, "ME6"},
                    { 6, "DV24"},
                    { 7, "DV6"},
                    { 8, "AVS"},
                    { 9, "CVSD" }
                };

                var index = values[activeParam.Text];
                string text;
                if (index >= 9)
                {
                    text = valuesNum[0];
                }
                else
                {
                    text = valuesNum[index + 1];
                }
                activeParam.Action(text);
                activeParam.ActiveTo = text.Length;
            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("VoiceValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null
                    || activeParam.Name != "VoiceValue")
                {
                    return;
                }

                var values = new Dictionary<string, int>(){
                    { "CLR", 0 },
                    { "NONE", 1 },
                    { "LDV",  2 },
                    { "ME24", 3 },
                    { "ME12", 4 },
                    { "ME6", 5 },
                    { "DV24", 6 },
                    { "DV6", 7 },
                    { "AVS", 8 },
                    { "CVSD", 9 }
                };

                var valuesNum = new Dictionary<int, string>(){
                    { 0, "CLR" },
                    { 1, "NONE" },
                    { 2, "LDV" },
                    { 3 ,"ME24"},
                    { 4, "ME12"},
                    { 5, "ME6"},
                    { 6, "DV24"},
                    { 7, "DV6"},
                    { 8, "AVS"},
                    { 9, "CVSD" }
                };

                var index = values[activeParam.Text];
                string text;
                if (index <= 0)
                {
                    text = valuesNum[9];
                }
                else
                {
                    text = valuesNum[index - 1];
                }
                activeParam.Action(text);
                activeParam.ActiveTo = text.Length;
            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("KeyValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null
                    || activeParam.Name != "KeyValue" 
                    || station.GetState() != SwitcherState.CT)
                {
                    return;
                }

                List<KeyModule.KeyValue> keys = station.Keys.GetCryptoKeysByMode(station.Mode);

                if (keys.Count == 0) return;

                if (activeParam.text == "▬▬▬▬▬")
                {
                    activeParam.Text = keys[0].keyName;
                    activeParam.container = keys[0];
                    return;
                }

                int index = keys.IndexOf(activeParam.container as KeyModule.KeyValue);
                index++;
                if (index > keys.Count - 1) index = 0;

                activeParam.Text = keys[index].keyName;
                activeParam.container = keys[index];

                if (keys.Count == 1) return;

                sigParam.Text = "SIG:" + Helper.RandomString(4);

            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("KeyValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null
                    || activeParam.Name != "KeyValue"
                    || station.GetState() != SwitcherState.CT)
                {
                    return;
                }

                List<KeyModule.KeyValue> keys = station.Keys.GetCryptoKeysByMode(station.Mode);

                if (keys.Count == 0) return;

                if (activeParam.text == "▬▬▬▬▬")
                {
                    activeParam.Text = keys[0].keyName;
                    activeParam.container = keys[0];
                    return;
                }

                int index = keys.IndexOf(activeParam.container as KeyModule.KeyValue);
                index--;
                if (index < 0) index = keys.Count - 1;

                activeParam.Text = keys[index].keyName;
                activeParam.container = keys[index];

                if (keys.Count == 1) return;

                sigParam.Text = "SIG:" + Helper.RandomString(4);
            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("Chan"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.DeactiveParam();
            }));

            mainMenu.AddActionToParam(mainMenu.GetParam("Body"), new Button("PGM", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (mainMenu.ActiveParam() != null)
                {
                    return;
                }

                wdg.PrepareToShowWidget(Enum.GetName(typeof(MenuNames), MenuNames.TransitionProgramMenu));

                MainWindow.timerAction = () =>
                {
                    var trans = wdg.GetAvailableWidget(GetNameMenu(MenuNames.TransitionProgramMenu));
                    trans.PrepareToShowWidget(GetNameMenu(MenuNames.ProgramMenu));
                    trans.GetAvailableWidget(GetNameMenu(MenuNames.ProgramMenu)).comeFrom = wdg;
                };
                MainWindow.StartTimer();
            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("Body"), new Button("OPT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (mainMenu.ActiveParam() != null)
                {
                    return;
                }

                wdg.PrepareToShowWidget(Enum.GetName(typeof(MenuNames), MenuNames.OptionMenu));
            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("StationMode"), new Button("MODE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (mainMenu.ActiveParam() != null)
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.SelectModeMenu));
            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("Body"), new Button("PRE_PLUS", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (mainMenu.ActiveParam() != null)
                {
                    return;
                }

                var next = station.PresetSystemsModule.NextPreset();

                var chan = mainMenu.GetParam("Chan");
                chan.Text = next.channelNumber;

                var voice = mainMenu.GetParam("VoiceValue");
                voice.Text = next.ctVoiceMode;

                var mode = mainMenu.GetParam("StationMode");
                mode.Text = RadioStation.ModeToString(next.radioMode);

                var name = mainMenu.GetParam("Manual");
                name.Text = next.name;

            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("Body"), new Button("LT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (mainMenu.ActiveParam() != null)
                {
                    return;
                }

                mainMenu.PrepareToShowWidget(GetNameMenu(MenuNames.MainMenuDisplayOpt));

            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("Body"), new Button("UPDATE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (mainMenu.ActiveParam() != null)
                {
                    return;
                }

                mainMenu.PrepareToShowWidget(GetNameMenu(MenuNames.MainMenu2));

            }));

            mainMenu.AddActionToParam(mainMenu.GetParam("Body"), new Button("PRE_PLUS", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (mainMenu.ActiveParam() != null)
                {
                    return;
                }

                var next = station.PresetSystemsModule.PrevPreset();

                var chan = mainMenu.GetParam("Chan");
                chan.Text = next.channelNumber;

                var voice = mainMenu.GetParam("VoiceValue");
                voice.Text = next.ctVoiceMode;

                var mode = mainMenu.GetParam("StationMode");
                mode.Text = RadioStation.ModeToString(next.radioMode);

                var name = mainMenu.GetParam("Manual");
                name.Text = next.name;

            }));
            //3G mode

            mainMenu.AddParam(new Param("3GTitle", null, "INCOMPLETE 3G FILL", 2, 4), false).AddModeForParam("3GTitle", RadioStationMode.ThreeG);

            mainMenu.AddParam(new Param("RebuildByStationMode", null, "", 1, 0, () =>
            {
                var modeParams = mainMenu.GetParamByMode(station.Mode);

                mainMenu.InvisibleAllParams();
                mainMenu.VisibleParamsByNode(station.Mode, true);
                
                if (station.GetState() == SwitcherState.CT
                                && station.Keys.Count(val => val.stationMode == station.Mode) != 0
                    && mainMenu.GetParam("KeyValue").Text == "▬▬▬▬▬")
                {
                    List<KeyModule.KeyValue> keys = station.Keys.GetCryptoKeysByMode(station.Mode);

                    mainMenu.GetParam("KeyValue").Text = keys[0].keyName;
                    mainMenu.GetParam("KeyValue").container = keys[0];

                    keyNameParam.Text = keys[0].keyName;
                }

                if (mainMenu.GetParam("KeyValue").Text == "▬▬▬▬▬")
                {
                    mainMenu.GetParam("KeyValue").Y = 11;
                    mainMenu.GetParam("ChanValue").Y = 18;
                } 
                else
                {
                    mainMenu.GetParam("KeyValue").Y = 13;
                    mainMenu.GetParam("ChanValue").Y = 20;
                }

            }));

            return mainMenu;
        }

        public static Widget InitMainMenu2(RadioStation station)
        {
            var mainMenu = new Widget(Enum.GetName(typeof(MenuNames), MenuNames.MainMenu2));
            mainMenu.LineSize[0] = 7;
            mainMenu.LineSize[1] = 11.5;
            mainMenu.LineSize[2] = 11.5;
            mainMenu.LineSize[3] = 7;
            mainMenu.LineCharOffset[0] = 6;
            mainMenu.LineCharOffset[1] = 5;
            mainMenu.LineCharOffset[2] = 6;
            mainMenu.LineCharOffset[3] = 5;

            mainMenu.AddParam(new Param("Body", null, "", 1, 0))
                .AddModesForParam("Body", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            mainMenu.AddParam(new Param("StationRTmode", null, "R", 1, 0))
                .AddModesForParam("StationRTmode", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            mainMenu.AddParam(new Param("Battery", null, "BAT ■■■■■", 1, 2))
                .AddModesForParam("Battery", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            mainMenu
                .AddParam(new Param("StationMode", null, "FIX", 1, 12, () =>
                {
                    mainMenu.GetParam("StationMode").Text = RadioStation.ModeToString(station.Mode);
                }))
                .AddModesForParam("StationMode", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop }); ;
            mainMenu
                .AddParam(new Param("SQ", null, "SQ", 1, 16))
                .AddModesForParam("SQ", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop }); ;
            mainMenu
                .AddParam(new Param("SwitchState", null, "PT", 1, 19, () =>
                {
                    mainMenu.GetParam("SwitchState").Text = Enum.GetName(typeof(SwitcherState), station.GetState());
                }))
                .AddModesForParam("SwitchState", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            mainMenu
                .AddParam(new Param("SwitchStateChan", null, "S 3 6 9 *", 1, 31))
                .AddModesForParam("SwitchStateChan", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });

            mainMenu.AddParam(new Param("ChTitle", null, "CH", 2, 0))
                .AddModesForParam("ChTitle", new List<RadioStationMode> { RadioStationMode.Ale, RadioStationMode.Hop });
            mainMenu.AddParam(new Param("ChNumber", (text, cParam) =>
                {
                    cParam.text = cParam.Text.Remove(cParam.ActiveFrom, cParam.ActiveTo);
                    cParam.text = cParam.Text.Insert(cParam.ActiveFrom, text);
                }, "001", 2, 2))
                .AddModesForParam("ChNumber", new List<RadioStationMode> { RadioStationMode.Ale, RadioStationMode.Hop });
            mainMenu.AddParam(new Param("RTitle", null, "R", 2, 8))
                .AddModesForParam("RTitle", new List<RadioStationMode> { RadioStationMode.Ale });
            mainMenu.AddParam(new Param("RNumber", (text, cParam) =>
                {
                    cParam.text = cParam.Text.Remove(cParam.ActiveFrom, cParam.ActiveTo);
                    cParam.text = cParam.Text.Insert(cParam.ActiveFrom, text);
                }, "07.0000", 2, 9))
                .AddModesForParam("RNumber", new List<RadioStationMode> { RadioStationMode.Ale});
            mainMenu.AddParam(new Param("UpdateSignal", null, "⟲▮▮▮▯", 2, 17))
                .AddModesForParam("UpdateSignal", new List<RadioStationMode> { RadioStationMode.Ale});

            mainMenu.AddParam(new Param("ModValue", null, "USB", 3, 0))
                .AddModesForParam("ModValue", new List<RadioStationMode> { RadioStationMode.Ale});
            mainMenu.AddParam(new Param("TTitle", null, "T", 3, 8))
                .AddModesForParam("TTitle", new List<RadioStationMode> { RadioStationMode.Ale});
            mainMenu.AddParam(new Param("TNumber", (text, cParam) =>
                {
                    cParam.text = cParam.Text.Remove(cParam.ActiveFrom, cParam.ActiveTo);
                    cParam.text = cParam.Text.Insert(cParam.ActiveFrom, text);
                }, "07.0000", 3, 9))
                .AddModesForParam("TNumber", new List<RadioStationMode> { RadioStationMode.Ale });
            mainMenu.AddParam(new Param("AgcValue", null, "OFF", 3, 20))
                .AddModesForParam("AgcValue", new List<RadioStationMode> { RadioStationMode.Ale });

            mainMenu.AddParam(new Param("ModTitle", null, "MOD", 4, 1))
                .AddModesForParam("ModTitle", new List<RadioStationMode> { RadioStationMode.Ale });
            mainMenu.AddParam(new Param("Frequency", null, "Frequency (MHZ)", 4, 12))
                .AddModesForParam("Frequency", new List<RadioStationMode> { RadioStationMode.Ale });
            mainMenu.AddParam(new Param("AgcTitle", null, "AGC", 4, 35))
                .AddModesForParam("AgcTitle", new List<RadioStationMode> { RadioStationMode.Ale });

            //ONLY HOP MODE
            mainMenu.AddParam(new Param("Narrow", null, "NARROW", 2, 6), false)
                .AddModesForParam("Narrow", new List<RadioStationMode> { RadioStationMode.Hop });
            mainMenu.AddParam(new Param("AutoSignal", null, "⟲AUTO", 2, 19), false)
                .AddModesForParam("AutoSignal", new List<RadioStationMode> { RadioStationMode.Hop });

            mainMenu.AddParam(new Param("HopFrequency", (text, cParam) =>
                {
                    cParam.text = cParam.Text.Remove(cParam.ActiveFrom, cParam.ActiveTo);
                    cParam.text = cParam.Text.Insert(cParam.ActiveFrom, text);
                }, "07.8000", 3, 2), false)
                .AddModesForParam("HopFrequency", new List<RadioStationMode> { RadioStationMode.Hop });
            mainMenu.AddParam(new Param("AutoSearching", null, "SEARCHING", 3, 16), false)
                .AddModesForParam("AutoSearching", new List<RadioStationMode> { RadioStationMode.Hop });

            mainMenu.AddParam(new Param("CenterFreq", null, "CENTER FREQ (MHZ)", 4, 1), false)
                .AddModesForParam("CenterFreq", new List<RadioStationMode> { RadioStationMode.Hop });
            mainMenu.AddParam(new Param("GpsStatus", null, "GPS STATUS", 4, 25), false)
                .AddModesForParam("GpsStatus", new List<RadioStationMode> { RadioStationMode.Hop });

            mainMenu.AddActionToParam(mainMenu.GetParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("AgcValue");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                if (activeParam.IsInParam())
                {
                    if (activeParam.ActiveFrom == 0)
                    {
                        activeParam.ActiveFrom = activeParam.Text.Length - 1;
                        activeParam.ActiveTo = 1;
                    }
                    else
                    {
                        activeParam.ActiveFrom -= 1;
                        activeParam.ActiveTo = 1;
                        if (!char.IsDigit(activeParam.GetActiveText()[0]))
                        {
                            activeParam.ActiveFrom -= 1;
                        }
                    }
                    return;
                }

                switch (activeParam.Name)
                {
                    case "ChNumber":
                    {
                        var param = wdg.GetParam("AgcValue");
                        if (wdg.GetParam("HopFrequency").IsVisible)
                        {
                            param = wdg.GetParam("HopFrequency");
                        }
                        wdg.DeactiveParam();
                        param.IsActive = true;
                        break;
                    }

                    case "ModValue":
                    {
                        var param = wdg.GetParam("ChNumber");
                        wdg.DeactiveParam();
                        param.IsActive = true;
                        break;
                    }

                    case "RNumber":
                    {
                        var param = wdg.GetParam("ModValue");
                        wdg.DeactiveParam();
                        param.IsActive = true;
                        break;
                    }

                    case "TNumber":
                    {
                        var param = wdg.GetParam("RNumber");
                        wdg.DeactiveParam();
                        param.IsActive = true;
                        break;
                    }

                    case "AgcValue":
                    {
                        var param = wdg.GetParam("TNumber");
                        wdg.DeactiveParam();
                        param.IsActive = true;
                        break;
                    }

                    case "HopFrequency":
                    {
                        var param = wdg.GetParam("ChNumber");
                        wdg.DeactiveParam();
                        param.IsActive = true;
                        break;
                    }
                }

            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("ChNumber");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                if (activeParam.IsInParam())
                {
                    if (activeParam.ActiveFrom == activeParam.Text.Length - 1)
                    {
                        activeParam.ActiveFrom = 0;
                        activeParam.ActiveTo = 1;
                    }
                    else
                    {
                        activeParam.ActiveFrom += 1;
                        if (!Char.IsDigit(activeParam.GetActiveText()[0]))
                        {
                            activeParam.ActiveFrom += 1;
                        }
                        activeParam.ActiveTo = 1;
                    }
                    return;
                }

                switch (activeParam.Name)
                {
                    case "ChNumber":
                    {
                        var param = wdg.GetParam("ModValue");
                        if (wdg.GetParam("HopFrequency").IsVisible)
                        {
                            param = wdg.GetParam("HopFrequency");
                        }
                        wdg.DeactiveParam();
                        param.IsActive = true;
                        break;
                    }

                    case "ModValue":
                    {
                        var param = wdg.GetParam("RNumber");
                        wdg.DeactiveParam();
                        param.IsActive = true;
                        break;
                    }

                    case "RNumber":
                    {
                        var param = wdg.GetParam("TNumber");
                        wdg.DeactiveParam();
                        param.IsActive = true;
                        break;
                    }

                    case "TNumber":
                    {
                        var param = wdg.GetParam("AgcValue");
                        wdg.DeactiveParam();
                        param.IsActive = true;
                        break;
                    }

                    case "AgcValue":
                    {
                        var param = wdg.GetParam("ChNumber");
                        wdg.DeactiveParam();
                        param.IsActive = true;
                        break;
                    }

                    case "HopFrequency":
                    {
                        var param = wdg.GetParam("ChNumber");
                        wdg.DeactiveParam();
                        param.IsActive = true;
                        break;
                    }
                }

            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("Body"), new Button("CALL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null
                    || activeParam.Name == "AgcValue"
                    || activeParam.Name == "ModValue")
                {
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.Action("1");

            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("Body"), new Button("LT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null
                    || activeParam.Name == "AgcValue"
                    || activeParam.Name == "ModValue")
                {
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.Action("2");

            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("Body"), new Button("MODE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null
                    || activeParam.Name == "AgcValue"
                    || activeParam.Name == "ModValue")
                {
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.Action("3");

            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("Body"), new Button("SQL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null
                    || activeParam.Name == "AgcValue"
                    || activeParam.Name == "ModValue")
                {
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.Action("4");

            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("Body"), new Button("ZERO", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null
                    || activeParam.Name == "AgcValue"
                    || activeParam.Name == "ModValue")
                {
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.Action("5");

            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("Body"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam.Name == "AgcValue"
                    || activeParam.Name == "ModValue")
                {
                    var values = new Dictionary<string, int>();
                    if (activeParam.Name == "ModValue")
                    {
                        values = new Dictionary<string, int>()
                        {
                            {"USB", 0},
                            {"LSB", 1},
                            {"AME", 2},
                            {"CW", 3},
                            {"FM", 4},
                        };
                    }
                    else if (activeParam.Name == "AgcValue")
                    {
                        values = new Dictionary<string, int>()
                        {
                            {"OFF", 0},
                            {"SLOW", 1},
                            {"MED", 2},
                            {"FAST", 3},
                            {"DATA", 4},
                            {"AUTO", 5},
                        };
                    }

                    var valuesNum = values.ToDictionary(k => k.Value, k => k.Key);

                    var index = values[activeParam.Text];
                    var text = index >= values.Count - 1 ? valuesNum[0] : valuesNum[index + 1];
                    activeParam.Text = text;
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.Action("6");

            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("Body"), new Button("OPT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null
                    || activeParam.Name == "AgcValue"
                    || activeParam.Name == "ModValue")
                {
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.Action("7");

            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("Body"), new Button("PGM", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null
                    || activeParam.Name == "AgcValue"
                    || activeParam.Name == "ModValue")
                {
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.Action("8");

            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("Body"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam.Name == "AgcValue"
                    || activeParam.Name == "ModValue")
                {
                    var values = new Dictionary<string, int>();
                    if (activeParam.Name == "ModValue")
                    {
                        values = new Dictionary<string, int>()
                        {
                            {"USB", 0},
                            {"LSB", 1},
                            {"AME", 2},
                            {"CW", 3},
                            {"FM", 4},
                        };
                    }
                    else if (activeParam.Name == "AgcValue")
                    {
                        values = new Dictionary<string, int>()
                        {
                            {"OFF", 0},
                            {"SLOW", 1},
                            {"MED", 2},
                            {"FAST", 3},
                            {"DATA", 4},
                            {"AUTO", 5},
                        };
                    }

                    var valuesNum = values.ToDictionary(k => k.Value, k => k.Key);

                    var index = values[activeParam.Text];
                    var text = index <= 0 ? valuesNum[values.Count - 1] : valuesNum[index - 1];
                    activeParam.Text = text;
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.Action("9");

            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("Body"), new Button("UPDATE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null
                    || activeParam.Name == "AgcValue"
                    || activeParam.Name == "ModValue")
                {
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.Action("0");

            }));
            mainMenu.AddActionToParam(mainMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (wdg.ActiveParam() != null && wdg.ActiveParam().IsInParam())
                {
                    wdg.ActiveParam().FullActive();
                    return;
                }

                mainMenu.ShowPreviousWidget();
            }));
            mainMenu.AddParam(new Param("RebuildByStationMode", null, "", 1, 0, () =>
            {
                List<Param> modeParams = mainMenu.GetParamByMode(station.Mode);

                mainMenu.InvisibleAllParams();
                mainMenu.VisibleParamsByNode(station.Mode, true);
            }));

            return mainMenu;
        }

        public static Widget InitCallMenu(RadioStation station)
        {
            var callMenu = new Widget(GetNameMenu(MenuNames.CallMenu));

            callMenu.LineSize[0] = 7;
            callMenu.LineSize[1] = 11.5;
            callMenu.LineSize[2] = 11.5;
            callMenu.LineSize[3] = 7;
            callMenu.LineCharOffset[0] = 6;
            callMenu.LineCharOffset[1] = 5;
            callMenu.LineCharOffset[2] = 6;
            callMenu.LineCharOffset[3] = 5;
            callMenu.AddParam(new Param("Body", null, "", 1, 0)); 
            callMenu.AddParam(new Param("StationRTmode", null, "R", 1, 0))
                .AddModesForParam("StationRTmode", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            callMenu.AddParam(new Param("Battery", null, "BAT ■■■■■", 1, 2))
                .AddModesForParam("Battery", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            callMenu
                .AddParam(new Param("StationMode", null, "FIX", 1, 12, () =>
                {
                    callMenu.GetParam("StationMode").Text = RadioStation.ModeToString(station.Mode);
                }))
                .AddModesForParam("StationMode", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop }); ;
            callMenu
                .AddParam(new Param("SQ", null, "SQ", 1, 16))
                .AddModesForParam("SQ", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop }); ;
            callMenu
                .AddParam(new Param("SwitchState", null, "PT", 1, 19, () =>
                {
                    callMenu.GetParam("SwitchState").Text = Enum.GetName(typeof(SwitcherState), station.GetState());
                }))
                .AddModesForParam("SwitchState", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            callMenu.AddParam(new Param("Title", null, "CALL TYPE", 2, 7));
            callMenu.GetParam("Title").Y = Helper.CalcCenterIndent(callMenu.GetParam("Title").Text.Length, 25);
            callMenu.AddParam(new Param("Value", null, "MANUAL", 3, 12));
            callMenu.GetParam("Value").Y = Helper.CalcCenterIndent(callMenu.GetParam("Value").Text.Length, 25);
            callMenu.AddParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL", 4, 12));
            
            callMenu.GetParam("Value").IsActive = true;
            
            var item1 = new WidgetTextParams("CALL TYPE");
            item1.AddParam("AUTOMATIC").AddParam("MANUAL");
            var item2 = new WidgetTextParams("ADDRESS TYPE");
            item2.AddParam("INDIVIDUAL").AddParam("ALL").AddParam("ANY").AddParam("GROUP").AddParam("NET");

            var radioParams = new List<WidgetTextParams>
            {
                item1,
                item2,
            };

            callMenu.AddActionToParam(callMenu.GetParam("Value"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("Title");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            callMenu.AddActionToParam(callMenu.GetParam("Value"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("Title");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            callMenu.AddActionToParam(callMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("Title");

                var paramTitle = titleParam.Text;

                var nextIndex = radioParams.IndexOf(radioParams.Find(p => p.Name == paramTitle)) + 1;
                if (nextIndex < radioParams.Count)
                {
                    titleParam.Text = radioParams[nextIndex].Name;
                    activeParam.Text = radioParams[nextIndex].CurrParam();
                    activeParam.ActiveTo = activeParam.Text.Length;
                    activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                    titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
                }
            }));

            callMenu.AddActionToParam(callMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                callMenu.ShowPreviousWidget();
            }));

            return callMenu;
        }

        public static Widget InitCallingMenu(RadioStation station)
        {
            var callMenu = new Widget(GetNameMenu(MenuNames.CallMenu))
            {
                LineSize = {[0] = 5, [1] = 9, [2] = 9, [3] = 5},
                LineCharOffset = {[0] = 6, [1] = 7, [2] = 6, [3] = 6}
            };

            callMenu.AddParam(new Param("Body", null, "", 1, 0));
            callMenu.AddParam(new Param("StationRTmode", null, "R", 1, 0))
                .AddModesForParam("StationRTmode", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            callMenu.AddParam(new Param("Battery", null, "BAT ■■■■■", 1, 2))
                .AddModesForParam("Battery", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            callMenu
                .AddParam(new Param("StationMode", null, "FIX", 1, 10, () =>
                {
                    callMenu.GetParam("StationMode").Text = RadioStation.ModeToString(station.Mode);
                }))
                .AddModesForParam("StationMode", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop }); ;
            callMenu
                .AddParam(new Param("SQ", null, "SQ", 1, 14))
                .AddModesForParam("SQ", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop }); ;
            callMenu
                .AddParam(new Param("SwitchState", null, "PT", 1, 17, () =>
                {
                    callMenu.GetParam("SwitchState").Text = Enum.GetName(typeof(SwitcherState), station.GetState());
                }))
                .AddModesForParam("SwitchState", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            callMenu.AddParam(new Param("Title", null, "CALL TYPE", 2, 7));
            callMenu.GetParam("Title").Y = Helper.CalcCenterIndent(callMenu.GetParam("Title").Text.Length, 28);
            callMenu.AddParam(new Param("Value", null, "MANUAL", 3, 12));
            callMenu.GetParam("Value").Y = Helper.CalcCenterIndent(callMenu.GetParam("Value").Text.Length, 28);
            callMenu.AddParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL", 4, 19));

            callMenu.GetParam("Value").IsActive = true;

            var item1 = new WidgetTextParams("CALL TYPE");
            item1.AddParam("AUTOMATIC").AddParam("MANUAL");
            var item2 = new WidgetTextParams("ADDRESS TYPE");
            item2.AddParam("INDIVIDUAL").AddParam("ALL").AddParam("ANY").AddParam("GROUP").AddParam("NET");

            var radioParams = new List<WidgetTextParams>
            {
                item1,
                item2,
            };


            callMenu.AddActionToParam(callMenu.GetParam("Value"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("Title");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            callMenu.AddActionToParam(callMenu.GetParam("Value"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("Title");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            callMenu.AddActionToParam(callMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("Title");

                var paramTitle = titleParam.Text;

                var nextIndex = radioParams.IndexOf(radioParams.Find(p => p.Name == paramTitle)) + 1;
                if (nextIndex >= radioParams.Count) return;
                titleParam.Text = radioParams[nextIndex].Name;
                activeParam.Text = radioParams[nextIndex].CurrParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            return callMenu;
        }

        public static Widget InitMainMenuDisplayOpt(RadioStation station)
        {
            var programMenu = new Widget(GetNameMenu(MenuNames.MainMenuDisplayOpt));
            programMenu.LineSize[0] = 7;
            programMenu.LineSize[1] = 11.5;
            programMenu.LineSize[2] = 11.5;
            programMenu.LineSize[3] = 7;
            programMenu.LineCharOffset[0] = 6;
            programMenu.LineCharOffset[1] = 5;
            programMenu.LineCharOffset[2] = 6;
            programMenu.LineCharOffset[3] = 5;

            programMenu.AddParam(new Param("Body", null, "", 1, 0));
            programMenu.AddParam(new Param("StationRTmode", null, "R", 1, 0))
                .AddModesForParam("StationRTmode", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            programMenu.AddParam(new Param("Battery", null, "BAT ■■■■■", 1, 2))
                .AddModesForParam("Battery", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            programMenu
                .AddParam(new Param("StationMode", null, "FIX", 1, 10, () =>
                {
                    programMenu.GetParam("StationMode").Text = RadioStation.ModeToString(station.Mode);
                }))
                .AddModesForParam("StationMode", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop }); ;
            programMenu
                .AddParam(new Param("SQ", null, "SQ", 1, 14))
                .AddModesForParam("SQ", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop }); ;
            programMenu
                .AddParam(new Param("SwitchState", null, "PT", 1, 17, () =>
                {
                    programMenu.GetParam("SwitchState").Text = Enum.GetName(typeof(SwitcherState), station.GetState());
                }))
                .AddModesForParam("SwitchState", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            programMenu.AddParam(new Param("BrightTitle", null, "BRIGHT", 2, 1));
            programMenu.AddParam(new Param("ContrastTitle", null, "CONTRAST", 2, 16));
            programMenu.AddParam(new Param("BrightValue", null, "7", 3, 3));
            programMenu.AddParam(new Param("ContrastValue", null, "100%", 3, 17));
            programMenu.GetParam("BrightValue").IsActive = true;
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                if (activeParam == null)
                {
                    var param = wdg.GetParam("ContrastValue");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "BrightValue":
                        {
                            var param = wdg.GetParam("ContrastValue");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "ContrastValue":
                        {
                            var param = wdg.GetParam("BrightValue");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("BrightValue");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "BrightValue":
                        {
                            var param = wdg.GetParam("ContrastValue");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "ContrastValue":
                        {
                            var param = wdg.GetParam("BrightValue");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }


            }));

            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                switch (activeParam.Name)
                {
                    case "BrightValue":
                        {
                            var value = int.Parse(activeParam.Text);
                            value++;
                            if (value > 7)
                            {
                                value = 1;
                            }
                            MainWindow.currObject.SetBrigth(value);
                            activeParam.Text = value.ToString();
                            break;
                        }
                    case "ContrastValue":
                        {
                            var value = int.Parse(activeParam.Text.Replace("%", ""));
                            value += 10;
                            if (value > 100)
                            {
                                value = 20;
                            }
                            MainWindow.currObject.SetContrast(value);
                            activeParam.Text = value.ToString() + "%";
                            break;
                        }
                }
            }));

            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                switch (activeParam.Name)
                {
                    case "BrightValue":
                        {
                            var value = int.Parse(activeParam.Text);
                            value--;
                            if (value < 1)
                            {
                                value = 7;
                            }
                            MainWindow.currObject.SetBrigth(value);
                            activeParam.Text = value.ToString();
                            break;
                        }
                    case "ContrastValue":
                        {
                            var value = int.Parse(activeParam.Text.Replace("%", ""));
                            value -= 10;
                            if (value < 20)
                            {
                                value = 100;
                            }
                            MainWindow.currObject.SetContrast(value);
                            activeParam.Text = value.ToString() + "%";
                            break;
                        }
                }


            }));
            return programMenu;
        }
        public static Widget InitProgramMenu(RadioStation station)
        {
            var programMenu = new Widget(GetNameMenu(MenuNames.ProgramMenu));
            programMenu.LineSize[0] = 7;
            programMenu.LineSize[1] = 1;
            programMenu.LineSize[2] = 11.5;
            programMenu.LineSize[3] = 11.5;
            programMenu.LineCharOffset[0] = 6;
            programMenu.LineCharOffset[1] = 1;
            programMenu.LineCharOffset[2] = 6;
            programMenu.LineCharOffset[3] = 5;

            programMenu.AddParam(new Param("Body", null, "", 1, 0));
            programMenu.AddParam(new Param("Title", null, "PGM", 1, 0));
            programMenu.AddParam(new Param("EmptyLine", null, "             ", 2, 0));
            programMenu.AddParam(new Param("Comsec", null, "COMSEC", 3, 0));
            programMenu.AddParam(new Param("Config", null, "CONFIG", 3, 9));
            programMenu.AddParam(new Param("Mode", null, "MODE", 3, 17));
            programMenu.AddParam(new Param("Maintenance", null, "MAINTENANCE", 4, 0));
            programMenu.AddParam(new Param("NextPage", null, "->", 4, 20));
            programMenu.GetParam("Comsec").IsActive = true;
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Maintenance");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Comsec":
                        {
                            wdg.DeactiveParam();
                            wdg.PrepareToShowWidget(Enum.GetName(typeof(MenuNames), MenuNames.ProgramMenu2));
                            wdg.GetAvailableWidget(GetNameMenu(MenuNames.ProgramMenu2)).GetParam("Sched").IsActive = true;
                            break;
                        }
                    case "Config":
                        {
                            var param = wdg.GetParam("Comsec");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Mode":
                        {
                            var param = wdg.GetParam("Config");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Maintenance":
                        {
                            var param = wdg.GetParam("Mode");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Comsec");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Comsec":
                        {
                            var param = wdg.GetParam("Config");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Config":
                        {
                            var param = wdg.GetParam("Mode");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Mode":
                        {
                            var param = wdg.GetParam("Maintenance");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Maintenance":
                        {
                            wdg.DeactiveParam();
                            wdg.PrepareToShowWidget(Enum.GetName(typeof(MenuNames), MenuNames.ProgramMenu2));
                            wdg.GetAvailableWidget(GetNameMenu(MenuNames.ProgramMenu2)).GetParam("Install").IsActive = true;
                            break;
                        }
                }

            }));
            programMenu.AddActionToParam(programMenu.GetParam("Comsec"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null || activeParam.Name != "Comsec")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.ProgramComsecMenu));

            }));
            programMenu.AddActionToParam(programMenu.GetParam("Mode"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null || activeParam.Name != "Mode")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.ProgramModeMenu));

            }));
            return programMenu;
        }
        public static Widget InitTransitionProgramMenu(RadioStation station)
        {
            var transition = new Widget(GetNameMenu(MenuNames.TransitionProgramMenu));
            transition.LineSize[0] = 7;
            transition.LineSize[1] = 11.5;
            transition.LineSize[2] = 11.5;
            transition.LineSize[3] = 7;
            transition.LineCharOffset[0] = 6;
            transition.LineCharOffset[1] = 5;
            transition.LineCharOffset[2] = 6;
            transition.LineCharOffset[3] = 5;
            transition.AddParam(new Param("Body", null, "", 1, 0));
            transition.AddParam(new Param("ActionEnter", null, "** ENTERING **", 2, 7));
            transition.AddParam(new Param("Title", null, "PROGRAM MENU", 3, 7));
            transition.AddParam(new Param("Description", null, "...WAIT...", 4, 18));
            return transition;
        }
        public static Widget InitProgramMenu2(RadioStation station)
        {
            var programMenu = new Widget(GetNameMenu(MenuNames.ProgramMenu2));
            programMenu.LineSize[0] = 7;
            programMenu.LineSize[1] = 11.5;
            programMenu.LineSize[2] = 11.5;
            programMenu.LineSize[3] = 7;
            programMenu.LineCharOffset[0] = 6;
            programMenu.LineCharOffset[1] = 5;
            programMenu.LineCharOffset[2] = 6;
            programMenu.LineCharOffset[3] = 5;
            programMenu.AddParam(new Param("Body", null, "", 1, 0));
            programMenu.AddParam(new Param("Title", null, "PGM", 1, 0));
            programMenu.AddParam(new Param("EmptyLine", null, "", 2, 0));
            programMenu.AddParam(new Param("PreviousPage", null, "<-", 3, 0));
            programMenu.AddParam(new Param("Install", null, "INSTALL", 3, 4));
            programMenu.AddParam(new Param("Sched", null, "SCHED", 3, 15));
            programMenu.GetParam("Install").IsActive = true;

            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Sched");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Install":
                        {
                            wdg.DeactiveParam();
                            wdg.ShowPreviousWidget().GetParam("Maintenance").IsActive = true;
                            break;
                        }
                    case "Sched":
                        {
                            var param = wdg.GetParam("Install");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Install");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Install":
                        {
                            var param = wdg.GetParam("Sched");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Sched":
                        {
                            wdg.DeactiveParam();
                            wdg.ShowPreviousWidget().GetParam("Comsec").IsActive = true;
                            break;
                        }
                }

            }));
            return programMenu;
        }

        public static Widget InitOptionMenu(RadioStation station)
        {
            var optionMenu = new Widget(GetNameMenu(MenuNames.OptionMenu));
            optionMenu.LineSize[0] = 9;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 11.5;
            optionMenu.LineCharOffset[2] = 5;
            optionMenu
                .AddParam(new Param("Body", null, "", 1, 0))
                .AddModesForParam("Body", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            optionMenu.AddParam(new Param("Title", null, "OPTIONS", 1, 0))
                .AddModesForParam("Title", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            optionMenu.AddParam(new Param("EmptyLine", null, " ", 2, 0))
                .AddModesForParam("EmptyLine", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            optionMenu.AddParam(new Param("GPS-tod", null, "GPS-TOD", 3, 0))
                .AddModesForParam("GPS-tod", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            optionMenu.AddParam(new Param("Retune", null, "RETUNE", 3, 10))
                .AddModesForParam("Retune", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            optionMenu.AddParam(new Param("Radio", null, "RADIO", 3, 18))
                .AddModesForParam("Radio", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            optionMenu.AddParam(new Param("Scan", null, "SCAN", 4, 0));
            optionMenu.AddParam(new Param("GPS-apr", null, "GPS-APR", 4, 10))
                .AddModesForParam("GPS-apr", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            optionMenu.AddParam(new Param("NextPage", null, "->", 4, 22))
                .AddModesForParam("NextPage", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            optionMenu.AddParam(new Param("3G", null, "3G", 4, 0), false)
                .AddModesForParam("3G", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.AddParam(new Param("Ale", null, "ALE", 4, 0), false)
                .AddModesForParam("Ale", new List<RadioStationMode> { RadioStationMode.Ale });

            optionMenu.AddParam(new Param("RebuildByStationMode", null, "", 1, 0, () =>
            {
                var modeParams = optionMenu.GetParamByMode(station.Mode);

                optionMenu.InvisibleAllParams();
                optionMenu.VisibleParamsByNode(station.Mode);
            }));

            optionMenu.GetParam("GPS-tod").IsActive = true;

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("GPS-apr");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "GPS-tod":
                        {
                            wdg.DeactiveParam();
                            wdg.GetAvailableWidget(GetNameMenu(MenuNames.OptionMenu2)).GetParam("Test").IsActive = true;
                            wdg.PrepareToShowWidget(GetNameMenu(MenuNames.OptionMenu2));
                            break;
                        }
                    case "Retune":
                        {
                            var param = wdg.GetParam("GPS-tod");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Radio":
                        {
                            var param = wdg.GetParam("Retune");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "3G":
                    case "Ale":
                    case "Scan":
                        {
                            var param = wdg.GetParam("Radio");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "GPS-apr":
                        {
                            wdg.DeactiveParam();
                            if (wdg.GetParam("Scan").IsVisible)
                            {
                                wdg.GetParam("Scan").IsActive = true;
                            }
                            else if (wdg.GetParam("3G").IsVisible)
                            {
                                wdg.GetParam("3G").IsActive = true;
                            }
                            else if (wdg.GetParam("Ale").IsVisible)
                            {
                                wdg.GetParam("Ale").IsActive = true;
                            }
                            else if (wdg.GetParam("Radio").IsVisible)
                            {
                                wdg.GetParam("Radio").IsActive = true;
                            }
                            break;
                        }
                }

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("GPS-tod");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "GPS-tod":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Retune");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Retune":
                        {
                            var param = wdg.GetParam("Radio");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Radio":
                        {
                            wdg.DeactiveParam();
                            if (wdg.GetParam("Scan").IsVisible)
                            {
                                wdg.GetParam("Scan").IsActive = true;
                            }
                            else if (wdg.GetParam("3G").IsVisible)
                            {
                                wdg.GetParam("3G").IsActive = true;
                            }
                            else if (wdg.GetParam("Ale").IsVisible)
                            {
                                wdg.GetParam("Ale").IsActive = true;
                            }
                            else if (wdg.GetParam("GPS-apr").IsVisible)
                            {
                                wdg.GetParam("GPS-apr").IsActive = true;
                            }
                            break;
                        }
                    case "3G":
                    case "Ale":
                    case "Scan":
                        {
                            var param = wdg.GetParam("GPS-apr");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "GPS-apr":
                        {
                            wdg.DeactiveParam();
                            wdg.PrepareToShowWidget(GetNameMenu(MenuNames.OptionMenu2));
                            wdg.GetAvailableWidget(GetNameMenu(MenuNames.OptionMenu2)).GetParam("Ext-acc").IsActive = true;
                            break;
                        }
                }

            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Radio"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                if (activeParam == null || activeParam.Name != "Radio")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.OptionMenuRadio));
            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("GPS-tod"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                if (activeParam == null || activeParam.Name != "GPS-tod")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.OptionGpsTodMenu));
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Scan"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                if (activeParam == null || activeParam.Name != "Scan")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.OptionScanMenu));
            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("3G"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                if (activeParam == null || activeParam.Name != "3G")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.OptionThreeGMenu));
            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Ale"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                if (activeParam == null || activeParam.Name != "Ale")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.OptionAleMenu));
            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));

            return optionMenu;
        }
        public static Widget InitOptionMenu2(RadioStation station)
        {
            var optionMenu = new Widget(GetNameMenu(MenuNames.OptionMenu2));
            optionMenu.LineSize[0] = 9;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 11.5;
            optionMenu.LineCharOffset[2] = 5;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0))
                .AddModesForParam("Body", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            optionMenu.AddParam(new Param("Title", null, "OPTIONS", 1, 0))
                .AddModesForParam("Title", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            optionMenu.AddParam(new Param("EmptyLine", null, " ", 2, 0))
                .AddModesForParam("EmptyLine", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            optionMenu.AddParam(new Param("NextPage", null, "<-", 3, 0))
                .AddModesForParam("NextPage", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            optionMenu.AddParam(new Param("Ext-acc", null, "EXT-ACC", 3, 10))
                .AddModesForParam("Ext-acc", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            optionMenu.AddParam(new Param("Test", null, "TEST", 3, 20))
                .AddModesForParam("Test", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.Ale, RadioStationMode.Hop });
            optionMenu.AddParam(new Param("Msg", null, "MSG", 3, 20), false)
                .AddModesForParam("Msg", new List<RadioStationMode> { RadioStationMode.ThreeG });

            optionMenu.GetParam("Ext-acc").IsActive = true;

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Test");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Ext-acc":
                        {
                            wdg.DeactiveParam();
                            wdg.ShowPreviousWidget().GetParam("GPS-apr").IsActive = true;
                            break;
                        }
                    case "Msg":
                        {
                            var param = wdg.GetParam("Ext-acc");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Test":
                        {
                            wdg.DeactiveParam();
                            if (wdg.GetParam("Msg").IsVisible)
                            {
                                wdg.GetParam("Msg").IsActive = true;
                            }
                            else if (wdg.GetParam("Ext-acc").IsVisible)
                            {
                                wdg.GetParam("Ext-acc").IsActive = true;
                            }
                            break;
                        }
                }

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Ext-acc");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Ext-acc":
                        {
                            wdg.DeactiveParam();
                            if (wdg.GetParam("Msg").IsVisible)
                            {
                                wdg.GetParam("Msg").IsActive = true;
                            }
                            else if (wdg.GetParam("Test").IsVisible)
                            {
                                wdg.GetParam("Test").IsActive = true;
                            }
                            break;
                        }
                    case "Msg":
                        {
                            var param = wdg.GetParam("Test");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Test":
                        {
                            wdg.DeactiveParam();
                            wdg.ShowPreviousWidget().GetParam("GPS-tod").IsActive = true;
                            break;
                        }
                }

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Test"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null || activeParam.Name != "Test")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.OptionMenuTest));
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Ext-acc"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                if (activeParam == null || activeParam.Name != "Ext-acc")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.OptionExtAccMenu));
            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Msg"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                if (activeParam == null || activeParam.Name != "Msg")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.OptionMsgMenu));
            })); 
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));
            optionMenu.AddParam(new Param("RebuildByStationMode", null, "", 1, 0, () =>
            {
                var modeParams = optionMenu.GetParamByMode(station.Mode);

                optionMenu.InvisibleAllParams();
                optionMenu.VisibleParamsByNode(station.Mode);

                if (station.Mode == RadioStationMode.ThreeG)
                {
                    optionMenu.GetParam("Test").X = 4;
                    optionMenu.GetParam("Test").Y = 0;
                }
                if (station.Mode == RadioStationMode.Fix)
                {
                    optionMenu.GetParam("Test").X = 3;
                    optionMenu.GetParam("Test").Y = 20;
                }
            }));
            return optionMenu;
        }

        public static Widget InitOptionMenuTest(RadioStation station)
        {
            var optionMenu = new Widget(GetNameMenu(MenuNames.OptionMenu2));

            optionMenu.LineSize[0] = 9;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 11.5;
            optionMenu.LineCharOffset[2] = 5;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "OPTIONS-TEST", 1, 0));
            optionMenu.AddParam(new Param("EmptyLine", null, " ", 2, 0));
            optionMenu.AddParam(new Param("Bit", null, "BIT", 3, 0));
            optionMenu.AddParam(new Param("Ping", null, "PING", 3, 7));
            optionMenu.AddParam(new Param("Battery", null, "BATTERY", 3, 16));
            optionMenu.AddParam(new Param("Vswr", null, "VSWR", 4, 0));
            optionMenu.AddParam(new Param("Temp", null, "TEMP", 4, 7));
            optionMenu.AddParam(new Param("Special", null, "SPECIAL", 4, 16));

            optionMenu.GetParam("Bit").IsActive = true;

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Special");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Bit":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Special");
                            param.IsActive = true;
                            break;
                        }
                    case "Ping":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Bit");
                            param.IsActive = true;
                            break;
                        }
                    case "Battery":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Ping");
                            param.IsActive = true;
                            break;
                        }
                    case "Vswr":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Battery");
                            param.IsActive = true;
                            break;
                        }
                    case "Temp":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Vswr");
                            param.IsActive = true;
                            break;
                        }
                    case "Special":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Temp");
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Bit");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Bit":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Ping");
                            param.IsActive = true;
                            break;
                        }
                    case "Ping":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Battery");
                            param.IsActive = true;
                            break;
                        }
                    case "Battery":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Vswr");
                            param.IsActive = true;
                            break;
                        }
                    case "Vswr":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Temp");
                            param.IsActive = true;
                            break;
                        }
                    case "Temp":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Special");
                            param.IsActive = true;
                            break;
                        }
                    case "Special":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Bit");
                            param.IsActive = true;
                            break;
                        }
                }

            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Bit"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                if (activeParam == null || activeParam.Name != "Bit")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.OptionTestBitMenu));
            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Battery"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                if (activeParam == null || activeParam.Name != "Battery")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.OptionTestBatteryMenu));
            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Temp"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                if (activeParam == null || activeParam.Name != "Temp")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.OptionTestTempMenu));
                WpfHarris78.Src.Checker.LessonParametersHolder.Holder.Parameters.Option.Test.Temp = true; 
            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Special"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                if (activeParam == null || activeParam.Name != "Special")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.OptionTestSpecialMenu));
            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Vswr"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                if (activeParam == null || activeParam.Name != "Vswr")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.OptionTestVswrMenu));
            }));
            return optionMenu;
        }

        public static Widget InitOptionMenuRadio(RadioStation station)
        {
            var optionMenu = new Widget(GetNameMenu(MenuNames.OptionMenuRadio));

            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 5;
            optionMenu.LineCharOffset[2] = 6;
            optionMenu.LineCharOffset[3] = 5;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "OPTI0NS-RADIO", 1, 0));
            optionMenu.AddParam(new Param("RadioOptionsTitle", null, "TX POWER LEVEL", 2, 7));
            optionMenu.AddParam(new Param("RadioOptionsValue", null, "LOW", 3, 12));
            optionMenu.AddParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL", 4, 13));


            optionMenu.GetParam("RadioOptionsTitle").Y = Helper.CalcCenterIndent(optionMenu.GetParam("RadioOptionsTitle").Text.Length, 25);
            optionMenu.GetParam("RadioOptionsValue").Y = Helper.CalcCenterIndent(optionMenu.GetParam("RadioOptionsValue").Text.Length, 25);

            optionMenu.GetParam("RadioOptionsValue").IsActive = true;

            var paramPowerLevel = new WidgetTextParams("TX POWER LEVEL");
            paramPowerLevel.AddParam("LOW").AddParam("HIGH").AddParam("MED");
            var paramSquelch = new WidgetTextParams("SQUELCH LEVEL");
            paramSquelch.AddParam("LOW").AddParam("HIGH").AddParam("MED");
            var paramFmSquelch = new WidgetTextParams("FM SQUELCH TYPE");
            paramFmSquelch.AddParam("TONE").AddParam("NOICE");
            var paramInternelCoupler = new WidgetTextParams("INTERNAL COUPLER");
            paramInternelCoupler.AddParam("ENABLED").AddParam("BYPASSED");
            var paramRadioSilence = new WidgetTextParams("RADIO SILENCE");
            paramRadioSilence.AddParam("OFF").AddParam("ON");
            var paramBfo = new WidgetTextParams("BFO");
            paramBfo.AddParam("-10").AddParam("0").AddParam("10");
            var paramRxNocie = new WidgetTextParams("RX NOICE BLANKING");
            paramRxNocie.AddParam("OFF").AddParam("ON");
            var paramRadioLock = new WidgetTextParams("RADIO LOCK");
            paramRadioLock.AddParam("OFF").AddParam("ON");

            var radioParams = new List<WidgetTextParams>
            {
                paramPowerLevel,
                paramSquelch,
                paramFmSquelch,
                paramInternelCoupler,
                paramRadioSilence,
                paramBfo,
                paramRxNocie,
                paramRadioLock
            };


            optionMenu.AddActionToParam(optionMenu.GetParam("RadioOptionsValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("RadioOptionsTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("RadioOptionsValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("RadioOptionsTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("RadioOptionsTitle");

                var paramTitle = titleParam.Text;

                var nextIndex = radioParams.IndexOf(radioParams.Find(p => p.Name == paramTitle)) + 1;
                if (nextIndex < radioParams.Count)
                {
                    titleParam.Text = radioParams[nextIndex].Name;
                    activeParam.Text = radioParams[nextIndex].CurrParam();
                    activeParam.ActiveTo = activeParam.Text.Length;
                    activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                    titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
                }
                else
                {
                    if (paramTitle == "RADIO LOCK")
                    {
                        var lessonsParams = WpfHarris78.Src.Checker.LessonParametersHolder.Holder.Parameters;
                        lessonsParams.Option.Radio.Bfo = paramBfo.CurrParam();
                        lessonsParams.Option.Radio.FmSquelchType = paramFmSquelch.CurrParam();
                        lessonsParams.Option.Radio.InternalCoupler = paramInternelCoupler.CurrParam();
                        lessonsParams.Option.Radio.RadioLock = paramRadioLock.CurrParam();
                        lessonsParams.Option.Radio.RadioSilence = paramRadioSilence.CurrParam();
                        lessonsParams.Option.Radio.RxNoiceBlanking = paramRxNocie.CurrParam();
                        lessonsParams.Option.Radio.SquelchLevel = paramSquelch.CurrParam();
                        lessonsParams.Option.Radio.TxPowerLevel = paramPowerLevel.CurrParam();

                        var res = activeParam.Text == "ON";
                        rs.KeyBoardLock = res;
                        if (res)
                        {
                            wdg.PrepareToShowWidget(GetNameMenu(MenuNames.KeyboardLock));
                            wdg.GetAvailableWidget(GetNameMenu(MenuNames.KeyboardLock)).ComeFrom = null;

                            MainWindow.timerAction = () =>
                            {
                                var trans = wdg.GetAvailableWidget(GetNameMenu(MenuNames.KeyboardLock));
                                trans.PrepareToShowWidget(GetNameMenu(MenuNames.MainMenu));
                                trans.GetAvailableWidget(GetNameMenu(MenuNames.MainMenu));
                            };
                            MainWindow.StartTimer();
                            return;
                        }
                        else
                        {
                            wdg.ShowPreviousWidget();

                            activeParam.Text = radioParams[0].CurrParam();
                            titleParam.Text = radioParams[0].Name;
                            activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                            titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
                        }
                    }
                }
            }));

            return optionMenu;
        }

        public static Widget InitOptionTestVswr(RadioStation station)
        {
            var optionMenu = new Widget(GetNameMenu(MenuNames.OptionTestVswrMenu));

            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 5;
            optionMenu.LineCharOffset[2] = 6;
            optionMenu.LineCharOffset[3] = 5;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0)); 
            optionMenu.AddParam(new Param("StationRTmode", null, "R", 1, 0));
            optionMenu.AddParam(new Param("Battery", null, "BAT ■■■■■", 1, 2));
            optionMenu
                .AddParam(new Param("StationMode", null, "FIX", 1, 12, () =>
                {
                    optionMenu.GetParam("StationMode").Text = RadioStation.ModeToString(station.Mode);
                }));
            optionMenu
                .AddParam(new Param("SQ", null, "SQ", 1, 16));
            optionMenu
                .AddParam(new Param("SwitchState", null, "PT", 1, 19, () =>
                {
                    optionMenu.GetParam("SwitchState").Text = Enum.GetName(typeof(SwitcherState), station.GetState());
                }));

            optionMenu.AddParam(new Param("Title", null, "VSWR FREQUENCY", 2, 7));
            optionMenu.AddParam(new Param("Value", (string text, Param cParam) =>
            {
                cParam.text = cParam.Text.Remove(cParam.ActiveFrom, cParam.ActiveTo);
                cParam.text = cParam.Text.Insert(cParam.ActiveFrom, text);
            }, "07.8000", 3, 12));
            optionMenu.AddParam(new Param("Info", null, "ENT TO TEST - CLR TO ABORT", 4, 8));
            string firstTitle = "VSWR FREQUENCY";
            var titleParam = optionMenu.GetParam("Title");
            var valueParam = optionMenu.GetParam("Value");
            var infoParam = optionMenu.GetParam("Info");


            titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            valueParam.Y = Helper.CalcCenterIndent(valueParam.Text.Length, 25);

            valueParam.IsActive = true;

            optionMenu.AddActionToParam(optionMenu.GetParam("Value"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (!valueParam.IsInParam())
                {
                    valueParam.ActiveFrom = 0;
                    valueParam.ActiveTo = 1;
                }
                valueParam.Action("9");
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Value"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (!valueParam.IsInParam())
                {
                    valueParam.ActiveFrom = 0;
                    valueParam.ActiveTo = 1;
                }
                valueParam.Action("6");
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Value"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (!valueParam.IsInParam())
                {
                    valueParam.ActiveFrom = 0;
                    valueParam.ActiveTo = 1;
                    return;
                }

                if (valueParam.IsInParam())
                {
                    if (valueParam.ActiveFrom <= 0)
                    {
                        return;
                    }
                    valueParam.ActiveFrom -= 1;
                    if (!Char.IsDigit(valueParam.GetActiveText()[0]))
                    {
                        valueParam.ActiveFrom -= 1;
                    }
                }
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Value"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {

                if (!valueParam.IsInParam())
                {
                    valueParam.ActiveFrom = 0;
                    valueParam.ActiveTo = 1;
                    return;
                }

                if (valueParam.IsInParam())
                {
                    valueParam.ActiveFrom += 1;

                    if (valueParam.ActiveFrom > valueParam.Text.Length - 1)
                    {
                        valueParam.ActiveFrom = valueParam.Text.Length - 1;
                    }
                    if (!Char.IsDigit(valueParam.GetActiveText()[0]))
                    {
                        valueParam.ActiveFrom += 1;
                    }
                }
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CALL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (!valueParam.IsInParam())
                {
                    valueParam.ActiveFrom = 0;
                    valueParam.ActiveTo = 1;
                }
                valueParam.Action("1");

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("LT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (!valueParam.IsInParam())
                {
                    valueParam.ActiveFrom = 0;
                    valueParam.ActiveTo = 1;
                }
                valueParam.Action("2");

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("MODE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (!valueParam.IsInParam())
                {
                    valueParam.ActiveFrom = 0;
                    valueParam.ActiveTo = 1;
                }
                valueParam.Action("3");

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("SQL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (!valueParam.IsInParam())
                {
                    valueParam.ActiveFrom = 0;
                    valueParam.ActiveTo = 1;
                }
                valueParam.Action("4");


            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("ZERO", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (!valueParam.IsInParam())
                {
                    valueParam.ActiveFrom = 0;
                    valueParam.ActiveTo = 1;
                }
                valueParam.Action("5");


            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("OPT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (!valueParam.IsInParam())
                {
                    valueParam.ActiveFrom = 0;
                    valueParam.ActiveTo = 1;
                }
                valueParam.Action("7");


            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("PGM", (Button btn, RadioStation rs, Widget wdg) =>
            {

                if (!valueParam.IsInParam())
                {
                    valueParam.ActiveFrom = 0;
                    valueParam.ActiveTo = 1;
                }
                valueParam.Action("8");


            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("UPDATE", (Button btn, RadioStation rs, Widget wdg) =>
            {

                if (!valueParam.IsInParam())
                {
                    valueParam.ActiveFrom = 0;
                    valueParam.ActiveTo = 1;
                }
                valueParam.Action("0");


            }));


            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var freqStr = valueParam.Text;
                freqStr = freqStr.Replace(".", ",");
                WpfHarris78.Src.Checker.LessonParametersHolder.Holder.Parameters.Option.Test.VswrFrequency = freqStr;
                Widget transition = GetVswrTestInProgressMenu(station, valueParam.Text, "MIC", "USB");
                Widget step2 = GetOptionTestVswr2(station,
                    clr: () =>
                    {
                        MainWindow.currObject.QueueWidget.Add(optionMenu);
                        MainWindow.currObject.StartShowWidgetQueue();
                    },
                    ent: () =>
                    {
                        MainWindow.currObject.QueueWidget.Add(optionMenu.ComeFrom);
                        MainWindow.currObject.StartShowWidgetQueue();
                    });
                MainWindow.currObject.QueueWidget.Add(transition);
                MainWindow.currObject.QueueWidget.Add(step2);
                MainWindow.currObject.StartShowWidgetQueue(2000);
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                optionMenu.ShowPreviousWidget();
            }));

            return optionMenu;
        }

        public static Widget InitKeyboardLockMenu(RadioStation station)
        {
            var optionMenu = new Widget(GetNameMenu(MenuNames.KeyboardLock));
            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            //optionMenu.LineCharOffset[0] = 6;
            //optionMenu.LineCharOffset[1] = 5;
            //optionMenu.LineCharOffset[2] = 6;
            //optionMenu.LineCharOffset[3] = 5;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "OPTIONS", 1, 0));
            optionMenu.AddParam(new Param("EmptyLine", null, "", 2, 0));
            optionMenu.AddParam(new Param("Title", null, "RADIO LOCK ENABLED", 3, 3));
            optionMenu.AddParam(new Param("Info", null, "ENTER 1379 TO UNLOCK", 4, 10));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CALL", (Button btn, RadioStation st, Widget wdg) =>
            {
                MainWindow.keyEntered += "1";
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("MODE", (Button btn, RadioStation st, Widget wdg) =>
            {
                MainWindow.keyEntered += "3";
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("OPT", (Button btn, RadioStation st, Widget wdg) =>
            {
                MainWindow.keyEntered += "7";
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("DOWN", (Button btn, RadioStation st, Widget wdg) =>
            {
                MainWindow.keyEntered += "9";
                st.KeyBoardLock = !MainWindow.keyEntered.Contains(MainWindow.keyNeed);
            }));

            return optionMenu;
        }
        public static Widget InitOptionGpsTodMenu(RadioStation station)
        {
            var optionMenu = new Widget(GetNameMenu(MenuNames.OptionGpsTodMenu));
            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 5;
            optionMenu.LineCharOffset[2] = 6;
            optionMenu.LineCharOffset[3] = 5;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "OPTIONS", 1, 0));
            optionMenu.AddParam(new Param("GpsTitle", null, "GPS STATUS", 2, 9));
            optionMenu.AddParam(new Param("GpsValue", null, "TRACKING", 3, 10));
            optionMenu.AddParam(new Param("Info", null, "PRESS ↑ OR ↓ TO SCROLL", 4, 10));

            optionMenu.GetParam("GpsTitle").Y = Helper.CalcCenterIndent(optionMenu.GetParam("GpsTitle").Text.Length, 25);
            optionMenu.GetParam("GpsValue").Y = Helper.CalcCenterIndent(optionMenu.GetParam("GpsValue").Text.Length, 25);

            optionMenu.GetParam("GpsValue").IsActive = true;

            var paramPowerLevel = new WidgetTextParams("GPS STATUS");
            paramPowerLevel.AddParam("TRACKING");
            var paramSquelch = new WidgetTextParams("LAT: N 43'09.1958");
            paramSquelch.AddParam("LNG: W 77'34.0012");
            var paramFmSquelch = new WidgetTextParams("HEADING: 169'");
            paramFmSquelch.AddParam("VELOCITY: 0.0 kph");
            var paramInternelCoupler = new WidgetTextParams("ALTITUDE: 159.66 m");
            paramInternelCoupler.AddParam("");

            var radioParams = new List<WidgetTextParams>
            {
                paramPowerLevel, paramSquelch, paramFmSquelch, paramInternelCoupler
            };

            optionMenu.AddActionToParam(optionMenu.GetParam("GpsValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("GpsTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("GpsValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("GpsTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("GpsTitle");

                activeParam.Text = radioParams[0].CurrParam();
                titleParam.Text = radioParams[0].Name;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("GpsTitle");

                var paramTitle = titleParam.Text;

                var nextIndex = radioParams.IndexOf(radioParams.Find(p => p.Name == paramTitle)) + 1;
                if (nextIndex < radioParams.Count)
                {
                    titleParam.Text = radioParams[nextIndex].Name;
                    activeParam.Text = radioParams[nextIndex].CurrParam();
                    activeParam.ActiveTo = activeParam.Text.Length;
                }
                else
                {
                    wdg.ShowPreviousWidget();

                    activeParam.Text = radioParams[0].CurrParam();
                    titleParam.Text = radioParams[0].Name;
                    activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                    titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
                    return;
                }


                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));
            return optionMenu;
        }

        public static Widget InitOptionScanMenu(RadioStation station)
        {
            var optionMenu = new Widget(GetNameMenu(MenuNames.OptionMenuRadio));

            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 5;
            optionMenu.LineCharOffset[2] = 6;
            optionMenu.LineCharOffset[3] = 5;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "OPTI0NS-RADIO", 1, 0));
            optionMenu.AddParam(new Param("ScanTitle", null, "ENABLE SSB SCAN", 2, 5));
            optionMenu.AddParam(new Param("ScanValue", null, "ON", 3, 9));
            optionMenu.AddParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL", 4, 12));

            optionMenu.GetParam("ScanTitle").Y = Helper.CalcCenterIndent(optionMenu.GetParam("ScanTitle").Text.Length, 25);
            optionMenu.GetParam("ScanValue").Y = Helper.CalcCenterIndent(optionMenu.GetParam("ScanValue").Text.Length, 25);
            optionMenu.GetParam("ScanValue").IsActive = true;

            var paramPowerLevel = new WidgetTextParams("ENABLE SSB SCAN");
            paramPowerLevel.AddParam("ON").AddParam("OFF");

            var radioParams = new List<WidgetTextParams> {paramPowerLevel};

            optionMenu.AddActionToParam(optionMenu.GetParam("ScanValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("ScanTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("ScanValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("ScanTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("ScanTitle");

                var paramTitle = titleParam.Text;

                var nextIndex = radioParams.IndexOf(radioParams.Find(p => p.Name == paramTitle)) + 1;
                if (nextIndex < radioParams.Count)
                {
                    titleParam.Text = radioParams[nextIndex].Name;
                    activeParam.Text = radioParams[nextIndex].CurrParam();
                    activeParam.ActiveTo = activeParam.Text.Length;
                }
                else
                {
                    wdg.ShowPreviousWidget();
                    return;
                }

                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));

            return optionMenu;
        }

        public static Widget InitOptionExtAccMenu(RadioStation station)
        {
            var optionMenu = new Widget(GetNameMenu(MenuNames.OptionExtAccMenu));


            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 5;
            optionMenu.LineCharOffset[2] = 6;
            optionMenu.LineCharOffset[3] = 5;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "OPTI0NS-RADIO", 1, 0));
            optionMenu.AddParam(new Param("ExtTitle", null, "EXTERNAL ADAPTER", 2, 6));
            optionMenu.AddParam(new Param("ExtValue", null, "NOT DETECTED", 3, 8));
            optionMenu.AddParam(new Param("Info", null, "PRESS ENT TO CONT", 4, 12));

            optionMenu.GetParam("ExtTitle").Y = Helper.CalcCenterIndent(optionMenu.GetParam("ExtTitle").Text.Length, 25);
            optionMenu.GetParam("ExtValue").Y = Helper.CalcCenterIndent(optionMenu.GetParam("ExtValue").Text.Length, 25);
            optionMenu.GetParam("ExtValue").IsActive = true;

            var paramExternalAdapter = new WidgetTextParams("EXTERNAL ADAPTER");
            paramExternalAdapter.AddParam("NOT DETECTED");
            var paramPowerAmp = new WidgetTextParams("EXTERNAL POWER AMP");
            paramPowerAmp.AddParam("NOT DETECTED");
            var paramExternalPrepost = new WidgetTextParams("EXTERNAL PREPOST");
            paramExternalPrepost.AddParam("NOT DETECTED");
            var paramExternalCoupler = new WidgetTextParams("EXTERNAL COUPLER");
            paramExternalCoupler.AddParam("NOT DETECTED");

            var radioParams = new List<WidgetTextParams>
            {
                paramExternalAdapter, paramPowerAmp, paramExternalPrepost, paramExternalCoupler
            };


            optionMenu.AddActionToParam(optionMenu.GetParam("ExtValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("ExtTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("ExtValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("ExtTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("ExtTitle");

                var paramTitle = titleParam.Text;

                var nextIndex = radioParams.IndexOf(radioParams.Find(p => p.Name == paramTitle)) + 1;
                if (nextIndex < radioParams.Count)
                {
                    titleParam.Text = radioParams[nextIndex].Name;
                    activeParam.Text = radioParams[nextIndex].CurrParam();
                    activeParam.ActiveTo = activeParam.Text.Length;
                }
                else
                {
                    wdg.ShowPreviousWidget();
                    return;
                }

                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("ExtTitle");

                activeParam.Text = radioParams[0].CurrParam();
                titleParam.Text = radioParams[0].Name;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));
            return optionMenu;
        }

        public static Widget InitOptionTestBitMenu(RadioStation station)
        {
            var optionMenu = new Widget(GetNameMenu(MenuNames.OptionTestBitMenu));

            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 5;
            optionMenu.LineCharOffset[2] = 6;
            optionMenu.LineCharOffset[3] = 5;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "OPTI0NS-RADIO", 1, 0));
            optionMenu.AddParam(new Param("TestTitle", null, "BUILT-IN-TEST", 2, 7));
            optionMenu.AddParam(new Param("TestValue", null, "SYSTEM", 3, 10));
            optionMenu.AddParam(new Param("Info", null, "↑↓ TO SCROLL - ENT TO EXECUTE", 4, 7));

            optionMenu.GetParam("TestValue").IsActive = true;
            optionMenu.GetParam("TestValue").Y = Helper.CalcCenterIndent(optionMenu.GetParam("TestValue").Text.Length, 25);
            optionMenu.GetParam("TestTitle").Y = Helper.CalcCenterIndent(optionMenu.GetParam("TestTitle").Text.Length, 25);

            var paramSystem = new WidgetTextParams("BUILT-IN-TEST");
            paramSystem.AddParam("SYSTEM");
            var paramCoupler = new WidgetTextParams("BUILT-IN-TEST");
            paramCoupler.AddParam("RF-5382 COUPLER");
            var paramPrepost = new WidgetTextParams("BUILT-IN-TEST");
            paramPrepost.AddParam("PREPOST");
            var paramPa = new WidgetTextParams("BUILT-IN-TEST");
            paramPa.AddParam("EXTERNAL PA");
            var paramKdp = new WidgetTextParams("BUILT-IN-TEST");
            paramPa.AddParam("KDP");
            var paramKdu = new WidgetTextParams("BUILT-IN-TEST");
            paramPa.AddParam("KDU");
            var paramInternalCoupler = new WidgetTextParams("BUILT-IN-TEST");
            paramPa.AddParam("INTERNAL COUPLER");

            var radioParams = new List<string>
            {
                "SYSTEM",
                "RF-5382 COUPLER",
                "PREPOST",
                "EXTERNAL PA",
                "KDP",
                "KDU",
                "INTERNAL COUPLER"
            };


            optionMenu.AddActionToParam(optionMenu.GetParam("TestValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                var index = radioParams.IndexOf(activeParam.Text);
                index++;
                if (index < radioParams.Count)
                {
                    activeParam.Text = radioParams[index];
                }
                else
                {
                    activeParam.Text = radioParams[0];
                }

                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("TestValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                var index = radioParams.IndexOf(activeParam.Text);
                index--;
                if (index >= 0)
                {
                    activeParam.Text = radioParams[index];
                }
                else
                {
                    activeParam.Text = radioParams[radioParams.Count - 1];
                }

                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var bitParamsCheck = WpfHarris78.Src.Checker.LessonParametersHolder.Holder.Parameters.Option.Test.Bit;

                switch (activeParam.Text)
                {
                    case "SYSTEM":
                        {
                            bitParamsCheck.System = true;
                            MainWindow.currObject.QueueWidget.Add(GetTestInProgressMenu());
                            MainWindow.currObject.QueueWidget.Add(GetTestContrastMenu());
                            MainWindow.currObject.QueueWidget.Add(GetTestLightMenu());
                            MainWindow.currObject.QueueWidget.Add(GetTestInProgressMenu());
                            MainWindow.currObject.QueueWidget.Add(GetTestPassedMenu());
                            MainWindow.currObject.StartShowWidgetQueue();
                            break;
                        }
                    case "RF-5382 COUPLER":
                        {
                            bitParamsCheck.RfCoupler = true;
                            MainWindow.currObject.QueueWidget.Add(GetTestInProgressMenu());
                            MainWindow.currObject.QueueWidget.Add(GetCouplerRfMenu());
                            MainWindow.currObject.StartShowWidgetQueue();
                            break;
                        }
                    case "PREPOST":
                        {
                            bitParamsCheck.Prepost = true;
                            MainWindow.currObject.QueueWidget.Add(GetTestInProgressMenu());
                            MainWindow.currObject.QueueWidget.Add(GetPrepostMenu());
                            MainWindow.currObject.StartShowWidgetQueue();
                            break;
                        }
                    case "EXTERNAL PA":
                        {
                            bitParamsCheck.ExternalPa = true;
                            MainWindow.currObject.QueueWidget.Add(GetTestInProgressMenu());
                            MainWindow.currObject.QueueWidget.Add(GetExtraMenu());
                            MainWindow.currObject.StartShowWidgetQueue();
                            break;
                        }
                    case "KDP":
                        {
                            bitParamsCheck.Kdp = true;
                            MainWindow.currObject.QueueWidget.Add(GetTestContrastMenu());
                            MainWindow.currObject.QueueWidget.Add(GetTestLightMenu());
                            MainWindow.currObject.QueueWidget.Add(GetTestPassedMenu());
                            MainWindow.currObject.StartShowWidgetQueue();
                            break;
                        }
                    case "KDU":
                        {
                            bitParamsCheck.Kdu = true;
                            MainWindow.currObject.QueueWidget.Add(GetTestInProgressMenu());
                            MainWindow.currObject.QueueWidget.Add(GetTestPassedMenu());
                            MainWindow.currObject.StartShowWidgetQueue();
                            break;
                        }
                    case "INTERNAL COUPLER":
                        {
                            bitParamsCheck.InternalCoupler = true;
                            MainWindow.currObject.QueueWidget.Add(GetTestInProgressMenu());
                            MainWindow.currObject.QueueWidget.Add(GetTestPassedMenu());
                            MainWindow.currObject.StartShowWidgetQueue();
                            break;
                        }
                }

            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("TestValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                optionMenu.ShowPreviousWidget();
            }));
            return optionMenu;
        }
        public static Widget GetVswrTestInProgressMenu(RadioStation station, string freq, string key, string mod)
        {
            var optionMenu = new Widget("GetVswrTestInProgressMenu");

            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 5;
            optionMenu.LineCharOffset[2] = 6;
            optionMenu.LineCharOffset[3] = 5;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("StationRTmode", null, "R", 1, 0));
            optionMenu.AddParam(new Param("Battery", null, "BAT ■■■■■", 1, 2));
            optionMenu
                .AddParam(new Param("StationMode", null, "FIX", 1, 12, () =>
                {
                    optionMenu.GetParam("StationMode").Text = RadioStation.ModeToString(station.Mode);
                }));
            optionMenu
                .AddParam(new Param("SQ", null, "SQ", 1, 16));
            optionMenu
                .AddParam(new Param("SwitchState", null, "PT", 1, 19, () =>
                {
                    optionMenu.GetParam("SwitchState").Text = Enum.GetName(typeof(SwitcherState), station.GetState());
                }));

            optionMenu.AddParam(new Param("TestTitle", null, "VSWR TESTING", 2, 8));
            optionMenu.AddParam(new Param("TestValue", null, "IN PROGRESS", 3, 7));
            optionMenu.AddParam(new Param("Info", null, $"  KEY: {key}  FREQ: {freq} MOD: {mod}", 4, 2));
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
            optionMenu.GetParam("TestTitle").Y = Helper.CalcCenterIndent(optionMenu.GetParam("TestTitle").Text.Length, 25);
            optionMenu.GetParam("TestValue").Y = Helper.CalcCenterIndent(optionMenu.GetParam("TestValue").Text.Length, 25);

            return optionMenu;
        }
        public static Widget GetOptionTestVswr2(RadioStation station, Action clr, Action ent)
        {
            Random rand = new Random();
            var optionMenu = new Widget("GetOptionTestVswr2");

            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 5;
            optionMenu.LineCharOffset[2] = 6;
            optionMenu.LineCharOffset[3] = 5;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("StationRTmode", null, "R", 1, 0));
            optionMenu.AddParam(new Param("Battery", null, "BAT ■■■■■", 1, 2));
            optionMenu
                .AddParam(new Param("StationMode", null, "FIX", 1, 12, () =>
                {
                    optionMenu.GetParam("StationMode").Text = RadioStation.ModeToString(station.Mode);
                }));
            optionMenu
                .AddParam(new Param("SQ", null, "SQ", 1, 16));
            optionMenu
                .AddParam(new Param("SwitchState", null, "PT", 1, 19, () =>
                {
                    optionMenu.GetParam("SwitchState").Text = Enum.GetName(typeof(SwitcherState), station.GetState());
                }));

            optionMenu.AddParam(new Param("TestTitle", null, "POWER:               21 W", 2, 0));
            optionMenu.AddParam(new Param("TestValue", null, $"VSWR:               {rand.Next(1,4)}.{rand.Next(1, 4)}:{rand.Next(1, 4)}", 3, 0));
            optionMenu.AddParam(new Param("Info", null, "CLR TO VIEW FREQ - ENT TO EXIT", 4, 4));


            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                clr?.Invoke();
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                ent?.Invoke();
            }));
            return optionMenu;
        }
        public static Widget GetTestInProgressMenu()
        {
            var optionMenu = new Widget("TestInProgressMenu");

            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 5;
            optionMenu.LineCharOffset[2] = 6;
            optionMenu.LineCharOffset[3] = 5;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "TESTING", 1, 0));
            optionMenu.AddParam(new Param("TestTitle", null, "*** TEST ***", 2, 8));
            optionMenu.AddParam(new Param("TestValue", null, "IN PROGRESS", 3, 7));
            optionMenu.AddParam(new Param("Info", null, "...WAIT...", 4, 19));

            return optionMenu;
        }
        public static Widget GetTestContrastMenu()
        {
            var optionMenu = new Widget("TestContrastMenu");

            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 5;
            optionMenu.LineCharOffset[2] = 6;
            optionMenu.LineCharOffset[3] = 5;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "TESTING", 1, 0));
            optionMenu.AddParam(new Param("TestTitle", null, "CONTRAST TEST", 2, 7));
            optionMenu.AddParam(new Param("TestValue", null, "", 3, 12));
            optionMenu.AddParam(new Param("Info", null, "...WAIT...", 4, 19));

            return optionMenu;
        }
        public static Widget GetTestLightMenu()
        {
            var optionMenu = new Widget("TestLightMenu");

            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 5;
            optionMenu.LineCharOffset[2] = 6;
            optionMenu.LineCharOffset[3] = 5;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "TESTING", 1, 0));
            optionMenu.AddParam(new Param("TestTitle", null, "LIGHT TEST", 2, 8));
            optionMenu.AddParam(new Param("TestValue", null, "", 3, 12));
            optionMenu.AddParam(new Param("Info", null, "...WAIT...", 4, 19));

            return optionMenu;
        }
        public static Widget GetTestPassedMenu()
        {
            var optionMenu = new Widget("getTestPassedMenu");

            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 5;
            optionMenu.LineCharOffset[2] = 6;
            optionMenu.LineCharOffset[3] = 5;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "TESTING", 1, 0));
            optionMenu.AddParam(new Param("TestTitle", null, "*** TEST ***", 2, 8));
            optionMenu.AddParam(new Param("TestValue", null, "PASSED", 3, 10));
            optionMenu.AddParam(new Param("Info", null, "PRESS CLR/ENT TO EXIT", 4, 12));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation st, Widget wdg) =>
            {
                WidgetInit.widgetContainer[GetNameMenu(MenuNames.MainMenu)].MoveTo = null;
                MainWindow.currObject.QueueWidget.Clear();
                MainWindow.currObject.QueueWidget.Add(WidgetInit.widgetContainer[GetNameMenu(MenuNames.MainMenu)]);
                MainWindow.currObject.StartShowWidgetQueue();
            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation st, Widget wdg) =>
            {
                WidgetInit.widgetContainer[GetNameMenu(MenuNames.MainMenu)].MoveTo = null;
                MainWindow.currObject.QueueWidget.Clear();
                MainWindow.currObject.QueueWidget.Add(WidgetInit.widgetContainer[GetNameMenu(MenuNames.MainMenu)]);
                MainWindow.currObject.StartShowWidgetQueue();
            }));

            return optionMenu;
        }
        public static Widget GetCouplerRfMenu()
        {
            var optionMenu = new Widget("getCouplerRFMenu");

            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 4;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "TESTING", 1, 0));
            optionMenu.AddParam(new Param("TestTitle", null, "MODULE: 5382_COUPLER", 2, 0));
            optionMenu.AddParam(new Param("TestValue", null, "FAULT:       99", 3, 0));
            optionMenu.AddParam(new Param("Info", null, "PRESS CLR/ENT TO EXIT", 4, 11));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("UPDATE", (Button btn, RadioStation st, Widget wdg) =>
            {
                wdg.GetParam("TestValue").Text = wdg.GetParam("TestValue").Text == "FAULT:       99" ? "NOT_INSTALLED" : "FAULT:       99";
            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation st, Widget wdg) =>
            {
                WidgetInit.widgetContainer[GetNameMenu(MenuNames.MainMenu)].MoveTo = null;
                MainWindow.currObject.QueueWidget.Clear();
                MainWindow.currObject.QueueWidget.Add(WidgetInit.widgetContainer[GetNameMenu(MenuNames.MainMenu)]);
                MainWindow.currObject.StartShowWidgetQueue();
            }));

            return optionMenu;
        }
        public static Widget GetPrepostMenu()
        {
            var optionMenu = new Widget("getPrepostMenu");

            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 4;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "TESTING", 1, 0));
            optionMenu.AddParam(new Param("TestTitle", null, "MODULE: PREPOST_1", 2, 0));
            optionMenu.AddParam(new Param("TestValue", null, "FAULT:       99", 3, 0));
            optionMenu.AddParam(new Param("Info", null, "PRESS CLR/ENT TO EXIT", 4, 15));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("UPDATE", (Button btn, RadioStation st, Widget wdg) =>
            {
                wdg.GetParam("TestValue").Text = wdg.GetParam("TestValue").Text == "FAULT:       99" ? "NOT_INSTALLED" : "FAULT:       99";
            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation st, Widget wdg) =>
            {
                WidgetInit.widgetContainer[GetNameMenu(MenuNames.MainMenu)].MoveTo = null;
                MainWindow.currObject.QueueWidget.Clear();
                MainWindow.currObject.QueueWidget.Add(WidgetInit.widgetContainer[GetNameMenu(MenuNames.MainMenu)]);
                MainWindow.currObject.StartShowWidgetQueue();
            }));

            return optionMenu;
        }
        public static Widget GetExtraMenu()
        {
            var optionMenu = new Widget("getExtraMenu");

            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 4;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "TESTING", 1, 0));
            optionMenu.AddParam(new Param("TestTitle", null, "MODULE: EXTRA", 2, 0));
            optionMenu.AddParam(new Param("TestValue", null, "FAULT:       99", 3, 0));
            optionMenu.AddParam(new Param("Info", null, "PRESS CLR/ENT TO EXIT", 4, 15));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("UPDATE", (Button btn, RadioStation st, Widget wdg) =>
            {
                wdg.GetParam("TestValue").Text = wdg.GetParam("TestValue").Text == "FAULT:       99" ? "NOT_INSTALLED" : "FAULT:       99";
            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation st, Widget wdg) =>
            {
                WidgetInit.widgetContainer[GetNameMenu(MenuNames.MainMenu)].MoveTo = null;
                MainWindow.currObject.QueueWidget.Clear();
                MainWindow.currObject.QueueWidget.Add(WidgetInit.widgetContainer[GetNameMenu(MenuNames.MainMenu)]);
                MainWindow.currObject.StartShowWidgetQueue();
            }));

            return optionMenu;
        }

        public static Widget InitOptionTestBatteryMenu(RadioStation station)
        {
            var optionMenu = new Widget(GetNameMenu(MenuNames.OptionTestBatteryMenu));

            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 5;
            optionMenu.LineCharOffset[2] = 6;
            optionMenu.LineCharOffset[3] = 5;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "OPTI0NS-RADIO", 1, 0));
            optionMenu.AddParam(new Param("BatteryTitle", null, "BATT:      RECHARGEABLE", 2, 0));
            optionMenu.AddParam(new Param("BatteryValue", null, "VOLTAGE:   29.7 NOMINAL", 3, 0));
            optionMenu.AddParam(new Param("Info", null, "PRESS ENT TO CONT", 4, 13));

            optionMenu.GetParam("BatteryValue").IsActive = true;

            var paramFirst = new WidgetTextParams("BATT:      RECHARGEABLE");
            paramFirst.AddParam("VOLTAGE:   29.7 NOMINAL");
            var paramSecond = new WidgetTextParams("HUB VOLTAGE:     3.62 V");
            paramSecond.AddParam("HUB STATUS:     NOMINAL");
            var paramFmSquelch = new WidgetTextParams("    HUB CAPACITY EST");
            paramFmSquelch.AddParam("    DAYS REMAINING:   349");

            var radioParams = new List<WidgetTextParams> {paramFirst, paramSecond, paramFmSquelch};


            optionMenu.AddActionToParam(optionMenu.GetParam("BatteryValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("BatteryTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("BatteryValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("BatteryTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("BatteryTitle");

                var paramTitle = titleParam.Text;

                var nextIndex = radioParams.IndexOf(radioParams.Find(p => p.Name == paramTitle)) + 1;
                if (nextIndex < radioParams.Count)
                {
                    titleParam.Text = radioParams[nextIndex].Name;
                    activeParam.Text = radioParams[nextIndex].CurrParam();
                    activeParam.ActiveTo = activeParam.Text.Length;
                }
                else
                {
                    WpfHarris78.Src.Checker.LessonParametersHolder.Holder.Parameters.Option.Test.Battery = true;
                    wdg.ShowPreviousWidget();

                    activeParam.Text = radioParams[0].CurrParam();
                    titleParam.Text = radioParams[0].Name;
                    activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                    titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
                }


            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation st, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();

                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("BatteryTitle");

                activeParam.Text = radioParams[0].CurrParam();
                titleParam.Text = radioParams[0].Name;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));
            return optionMenu;
        }

        public static Widget InitOptionTestTempMenu(RadioStation station)
        {
            var optionMenu = new Widget(GetNameMenu(MenuNames.OptionTestTempMenu));

            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 5;
            optionMenu.LineCharOffset[2] = 6;
            optionMenu.LineCharOffset[3] = 5;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "TESTING-TEMP", 1, 0));
            optionMenu.AddParam(new Param("TestTitle", null, "DIG BD TEMP: 42.0 C", 2, 5));
            optionMenu.AddParam(new Param("TestValue", null, "PA TEMP: 35.6 C", 3, 7));
            optionMenu.AddParam(new Param("Info", null, "ENT TO REFRESH/CLR TO EXIT", 4, 10));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation st, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("UPDATE", (Button btn, RadioStation st, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));

            return optionMenu;
        }
        public static Widget InitOptionTestSpecialMenu(RadioStation station)
        {
            var optionMenu = new Widget(GetNameMenu(MenuNames.OptionTestSpecialMenu));

            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "OPTION-TEST-SPECIAL", 1, 0));
            optionMenu.AddParam(new Param("Version", null, "VERSION", 2, 0));
            optionMenu.AddParam(new Param("Stats", null, "RADIO STATS", 2, 10));
            optionMenu.AddParam(new Param("Config", null, "CONFIG", 3, 10));

            optionMenu.GetParam("Version").IsActive = true;

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation st, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("UPDATE", (Button btn, RadioStation st, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Config");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Version":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Config");
                            param.IsActive = true;
                            break;
                        }
                    case "Stats":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Version");
                            param.IsActive = true;
                            break;
                        }
                    case "Config":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Stats");
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Version");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Version":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Stats");
                            param.IsActive = true;
                            break;
                        }
                    case "Stats":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Config");
                            param.IsActive = true;
                            break;
                        }
                    case "Config":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Version");
                            param.IsActive = true;
                            break;
                        }
                }
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Version"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null || activeParam.Name != "Version")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.OptionTestSpecialVersionMenu));
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Config"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null || activeParam.Name != "Config")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.OptionTestSpecialConfigMenu));
            }));

            return optionMenu;
        }

        public static Widget InitOptionTestSpecialVersionMenu(RadioStation station)
        {
            var optionMenu = new Widget(GetNameMenu(MenuNames.OptionTestSpecialVersionMenu));

            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "OPTION-TEST-SPECIAL-VERSION", 1, 0));
            optionMenu.AddParam(new Param("Software", null, "SOFTWARE", 2, 0));
            optionMenu.AddParam(new Param("Hardware", null, "HARDWARE", 2, 10));

            optionMenu.GetParam("Software").IsActive = true;

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation st, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Hardware");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Software":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Hardware");
                            param.IsActive = true;
                            break;
                        }
                    case "Hardware":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Software");
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Software");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Software":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Hardware");
                            param.IsActive = true;
                            break;
                        }
                    case "Hardware":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Software");
                            param.IsActive = true;
                            break;
                        }
                }
            }));


            return optionMenu;
        }

        public static Widget InitOptionTestSpecialConfigMenu(RadioStation station)
        {
            var optionMenu = new Widget(GetNameMenu(MenuNames.OptionTestSpecialConfigMenu));

            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "OPTION-TEST-SPECIAL-CONFIG", 1, 0));
            optionMenu.AddParam(new Param("Ids", null, "IDS", 2, 0));
            optionMenu.AddParam(new Param("Options", null, "OPTIONS", 2, 10));
            optionMenu.GetParam("Ids").IsActive = true;

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation st, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Options");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Ids":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Options");
                            param.IsActive = true;
                            break;
                        }
                    case "Options":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Ids");
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Ids");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Ids":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Options");
                            param.IsActive = true;
                            break;
                        }
                    case "Options":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Ids");
                            param.IsActive = true;
                            break;
                        }
                }
            }));


            return optionMenu;
        }

        public static Widget InitSelectModeMenu(RadioStation station)
        {
            var mainMenu = new Widget(GetNameMenu(MenuNames.OptionTestSpecialConfigMenu));

            var oldMode = station.Mode;

            mainMenu.LineSize[0] = 7;
            mainMenu.LineSize[1] = 13;
            mainMenu.LineSize[2] = 11.5;
            mainMenu.LineSize[3] = 7;
            mainMenu.LineCharOffset[0] = 9;
            mainMenu.LineCharOffset[1] = 3;
            mainMenu.LineCharOffset[2] = 2;
            mainMenu.LineCharOffset[3] = 6;
            mainMenu.AddParam(new Param("Body", null, "", 1, 0));
            mainMenu.AddParam(new Param("StationRTmode", null, "R", 1, 0));
            mainMenu.AddParam(new Param("Battery", null, "BAT ■■■■■", 1, 2));
            mainMenu.AddParam(new Param("StationMode", null, station.CurrentModeToString(), 1, 12, () =>
            {
                mainMenu.GetParam("StationMode").Text = station.CurrentModeToString();
            }));
            mainMenu.AddParam(new Param("SQ", null, "SQ", 1, 16));
            mainMenu.AddParam(new Param("SwitchState", null, Enum.GetName(typeof(SwitcherState), station.GetState()), 1, 19, () =>
            {
                mainMenu.GetParam("SwitchState").Text = Enum.GetName(typeof(SwitcherState), station.GetState());
            }));
            mainMenu.AddParam(new Param("Select", null, $">>> {station.CurrentModeToString()} <<<", 2, 6));
            mainMenu.AddParam(new Param("EmptyLine", null, "", 3, 0));
            mainMenu.AddParam(new Param("Info", null, "MODE TO SELECT", 4, 14));

            mainMenu.AddActionToParam(mainMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation st, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
                station.Mode = oldMode;
            }));

            mainMenu.AddActionToParam(mainMenu.GetParam("Body"), new Button("MODE", (Button btn, RadioStation st, Widget wdg) =>
            {
                station.NextMode();
                mainMenu.GetParam("Select").Text = $">>> {station.CurrentModeToString()} <<<";
            }));

            mainMenu.AddActionToParam(mainMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation st, Widget wdg) =>
            {
                if (station.Mode == RadioStationMode.Ale)
                {
                    MainWindow.currObject.QueueWidget.Add(InitAleSelfAddressMenu(station));
                    MainWindow.currObject.StartShowWidgetQueue();
                    return;
                }

                mainMenu.ShowPreviousWidget();
            }));

            return mainMenu;
        }

        public static Widget InitOptionThreeGMenu(RadioStation station)
        {
            var optionMenu = new Widget(GetNameMenu(MenuNames.OptionMenu));
            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 11.5;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu
                .AddParam(new Param("Body", null, "", 1, 0))
                .AddModesForParam("Body", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.AddParam(new Param("Title", null, "OPTIONS-3G", 1, 0))
                .AddModesForParam("Title", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.AddParam(new Param("EmptyLine", null, " ", 2, 0))
                .AddModesForParam("EmptyLine", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.AddParam(new Param("Lqa", null, "LQA", 3, 0))
                .AddModesForParam("Lqa", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.AddParam(new Param("Scores", null, "SCORES", 3, 5))
                .AddModesForParam("Scores", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.AddParam(new Param("Unsync", null, "UNSYNC", 3, 16))
                .AddModesForParam("Unsync", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.AddParam(new Param("Tod", null, "TOD", 4, 0));
            optionMenu.AddParam(new Param("Todrole", null, "TODROLE", 4, 10))
                .AddModesForParam("Todrole", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.AddParam(new Param("NextPage", null, "->", 4, 22))
                .AddModesForParam("NextPage", new List<RadioStationMode> { RadioStationMode.ThreeG });

            optionMenu.GetParam("Lqa").IsActive = true;

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Todrole");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Lqa":
                        {
                            wdg.DeactiveParam();
                            wdg.PrepareToShowWidget(GetNameMenu(MenuNames.OptionThreeG2Menu));
                            wdg.GetAvailableWidget(GetNameMenu(MenuNames.OptionThreeG2Menu)).GetParam("Linked").IsActive = true;
                            break;
                        }
                    case "Scores":
                        {
                            var param = wdg.GetParam("Lqa");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Unsync":
                        {
                            var param = wdg.GetParam("Scores");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Tod":
                        {
                            var param = wdg.GetParam("Unsync");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Todrole":
                        {
                            var param = wdg.GetParam("Tod");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Lqa");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Lqa":
                        {
                            var param = wdg.GetParam("Scores");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Scores":
                        {
                            var param = wdg.GetParam("Unsync");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Unsync":
                        {
                            var param = wdg.GetParam("Tod");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Tod":
                        {
                            var param = wdg.GetParam("Todrole");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Todrole":
                        {
                            wdg.DeactiveParam();
                            wdg.PrepareToShowWidget(GetNameMenu(MenuNames.OptionThreeG2Menu));
                            wdg.GetAvailableWidget(GetNameMenu(MenuNames.OptionThreeG2Menu)).GetParam("Linked").IsActive = true;
                            break;
                        }
                }

            }));

            //optionMenu.addActionToParam(optionMenu.getParam("Scan"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            //{
            //    Param activeParam = wdg.activeParam();
            //    if (activeParam == null || activeParam.Name != "Scan")
            //    {
            //        return;
            //    }

            //    wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionScanMenu));
            //}));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));

            return optionMenu;
        }

        public static Widget InitOptionThreeG2Menu(RadioStation station)
        {
            var optionMenu = new Widget(GetNameMenu(MenuNames.OptionThreeG2Menu));
            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 11.5;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu
                .AddParam(new Param("Body", null, "", 1, 0))
                .AddModesForParam("Body", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.AddParam(new Param("Title", null, "OPTIONS-3G", 1, 0))
                .AddModesForParam("Title", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.AddParam(new Param("EmptyLine", null, " ", 2, 0))
                .AddModesForParam("EmptyLine", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.AddParam(new Param("NextPage", null, "<-", 3, 0))
                .AddModesForParam("NextPage", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.AddParam(new Param("Linked", null, "LINKED", 3, 3))
                .AddModesForParam("Linked", new List<RadioStationMode> { RadioStationMode.ThreeG });

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Linked");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                wdg.ComeFrom.GetParam("Todrole").IsActive = true;
                wdg.ShowPreviousWidget();
            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Linked");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                wdg.ComeFrom.GetParam("Lqa").IsActive = true;
                wdg.ShowPreviousWidget();
            }));

            //optionMenu.addActionToParam(optionMenu.getParam("Scan"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            //{
            //    Param activeParam = wdg.activeParam();
            //    if (activeParam == null || activeParam.Name != "Scan")
            //    {
            //        return;
            //    }

            //    wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionScanMenu));
            //}));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));


            return optionMenu;
        }

        public static Widget InitOptionMsgMenu(RadioStation station)
        {

            var optionMenu = new Widget(GetNameMenu(MenuNames.OptionMsgMenu));
            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu
                .AddParam(new Param("Body", null, "", 1, 0))
                .AddModesForParam("Body", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.AddParam(new Param("Title", null, "OPTIONS-MSG", 1, 0))
                .AddModesForParam("Title", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.AddParam(new Param("EmptyLine", null, " ", 2, 0))
                .AddModesForParam("EmptyLine", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.AddParam(new Param("Lvd", null, "LVD", 3, 0))
                .AddModesForParam("Lvd", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.AddParam(new Param("Sms", null, "SMS", 3, 15))
                .AddModesForParam("Sms", new List<RadioStationMode> { RadioStationMode.ThreeG });

            optionMenu.GetParam("Lvd").IsActive = true;

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Lvd");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Lvd":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Sms");
                            param.IsActive = true;
                            break;
                        }
                    case "Sms":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Lvd");
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Sms");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Lvd":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Sms");
                            param.IsActive = true;
                            break;
                        }
                    case "Sms":
                        {
                            wdg.DeactiveParam();
                            var param = wdg.GetParam("Lvd");
                            param.IsActive = true;
                            break;
                        }
                }

            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Sms"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                if (activeParam == null || activeParam.Name != "Sms")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.OptionMsgSmsMenu));
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));

            return optionMenu;
        }

        public static Widget InitOptionMsgSmsMenu(RadioStation station)
        {
            var smsMenu = new Widget(GetNameMenu(MenuNames.OptionMsgSmsMenu));

            smsMenu.LineSize[0] = 7;
            smsMenu.LineSize[1] = 11.5;
            smsMenu.LineSize[2] = 11.5;
            smsMenu.LineSize[3] = 7;
            smsMenu.LineCharOffset[0] = 6;
            smsMenu.LineCharOffset[1] = 6;
            smsMenu.LineCharOffset[2] = 7;
            smsMenu.LineCharOffset[3] = 6;
            smsMenu
                .AddParam(new Param("Body", null, "", 1, 0))
                .AddModesForParam("Body", new List<RadioStationMode> { RadioStationMode.ThreeG });

            smsMenu.AddParam(new Param("Title", null, "↑↓ TO BROWSE RECEIVED MSGS", 1, 0, () =>
            {
                var activeSms = smsMenu.GetActiveParamsBy(pr =>
                {
                    return pr.X == 4;
                })[0];
                var title = smsMenu.GetParam("Title");
                switch (activeSms.Name)
                {
                    case "Select":
                        {
                            title.Text = "↑↓ TO BROWSE RECEIVED MSGS";
                            break;
                        }
                    case "New":
                        {
                            title.Text = "ENTER FOR NEW MSGS";
                            break;
                        }
                    case "Delete_all":
                        {
                            title.Text = "ENTER TO DELETE MSGS";
                            break;
                        }
                }
            }))
                .AddModesForParam("Title", new List<RadioStationMode> { RadioStationMode.ThreeG });

            smsMenu
                .AddParam(new Param("MsgLine1", null, "", 2, 0, () =>
                {
                    smsMenu.GetParam("MsgLine1").Text = _smsControls.GetPair().Item1;
                }))
                .AddModesForParam("MsgLine1", new List<RadioStationMode> { RadioStationMode.ThreeG });
            smsMenu
                .AddParam(new Param("MsgLine2", null, "", 3, 0, () =>
                {
                    smsMenu.GetParam("MsgLine2").Text = _smsControls.GetPair().Item2;
                }))
                .AddModesForParam("MsgLine2", new List<RadioStationMode> { RadioStationMode.ThreeG });

            smsMenu.AddParam(new Param("Select", null, "SELECT", 4, 0))
                .AddModesForParam("Select", new List<RadioStationMode> { RadioStationMode.ThreeG });
            smsMenu.AddParam(new Param("New", null, "NEW", 4, 13))
                .AddModesForParam("New", new List<RadioStationMode> { RadioStationMode.ThreeG });
            smsMenu.AddParam(new Param("Delete_all", null, "DELETE_ALL", 4, 23))
                .AddModesForParam("Delete_all", new List<RadioStationMode> { RadioStationMode.ThreeG });

            smsMenu.GetParam("MsgLine1").IsActive = true;
            smsMenu.GetParam("Select").IsActive = true;

            smsMenu.AddActionToParam(smsMenu.GetParam("Body"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeSms = wdg.GetActiveParamsBy(pr =>
                {
                    return pr.X == 2 || pr.X == 3;
                })[0];

                if (activeSms.Name == "MsgLine1")
                {
                    activeSms.IsActive = false;
                    wdg.GetParam("MsgLine2").IsActive = true;
                }
                else
                {
                    activeSms.IsActive = false;
                    wdg.GetParam("MsgLine1").IsActive = true;
                }

                _smsControls.Next();
            }));
            smsMenu.AddActionToParam(smsMenu.GetParam("Body"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeSms = wdg.GetActiveParamsBy(pr =>
                {
                    return pr.X == 2 || pr.X == 3;
                })[0];

                if (activeSms.Name == "MsgLine1")
                {
                    activeSms.IsActive = false;
                    wdg.GetParam("MsgLine2").IsActive = true;
                }
                else
                {
                    activeSms.IsActive = false;
                    wdg.GetParam("MsgLine1").IsActive = true;
                }

                _smsControls.Previous();
            }));


            smsMenu.AddActionToParam(smsMenu.GetParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeSms = wdg.GetActiveParamsBy(pr =>
                {
                    return pr.X == 4;
                })[0];

                switch (activeSms.Name)
                {
                    case "Select":
                        {
                            activeSms.IsActive = false;
                            var param = wdg.GetParam("Delete_all");
                            param.IsActive = true;
                            break;
                        }
                    case "New":
                        {
                            activeSms.IsActive = false;
                            var param = wdg.GetParam("Select");
                            param.IsActive = true;
                            break;
                        }
                    case "Delete_all":
                        {
                            activeSms.IsActive = false;
                            var param = wdg.GetParam("New");
                            param.IsActive = true;
                            break;
                        }
                }
            }));

            smsMenu.AddActionToParam(smsMenu.GetParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeSms = wdg.GetActiveParamsBy(pr =>
                {
                    return pr.X == 4;
                })[0];

                switch (activeSms.Name)
                {
                    case "Select":
                        {
                            activeSms.IsActive = false;
                            var param = wdg.GetParam("New");
                            param.IsActive = true;
                            break;
                        }
                    case "New":
                        {
                            activeSms.IsActive = false;
                            var param = wdg.GetParam("Delete_all");
                            param.IsActive = true;
                            break;
                        }
                    case "Delete_all":
                        {
                            activeSms.IsActive = false;
                            var param = wdg.GetParam("Select");
                            param.IsActive = true;
                            break;
                        }
                }
            }));

            smsMenu.AddActionToParam(smsMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeSms = wdg.GetActiveParamsBy(pr =>
                {
                    return pr.X == 4;
                })[0];

                switch (activeSms.Name)
                {
                    case "Select":
                        {

                            break;
                        }
                    case "New":
                        {
                            wdg.PrepareToShowWidget(GetNameMenu(MenuNames.OptionMsgSmsFunctionsMenu));
                            break;
                        }
                    case "Delete_all":
                        {
                            break;
                        }
                }
            }));

            return smsMenu;
        }

        public static Widget InitOptionMsgSmsFunctionsMenu(RadioStation station)
        {
            var optionMenu = new Widget(GetNameMenu(MenuNames.OptionMenuRadio));

            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "", 1, 0));
            optionMenu.AddParam(new Param("SmsTitle", null, "MESSAGE TYPE", 2, 7));
            optionMenu.AddParam(new Param("SmsValue", null, "NEW MSG", 3, 9));
            optionMenu.AddParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL", 4, 12));

            optionMenu.GetParam("SmsValue").IsActive = true;
            optionMenu.GetParam("SmsValue").Y = Helper.CalcCenterIndent(optionMenu.GetParam("SmsValue").Text.Length, 25);
            optionMenu.GetParam("SmsTitle").Y = Helper.CalcCenterIndent(optionMenu.GetParam("SmsTitle").Text.Length, 25);

            var smsFunctions = new WidgetTextParams("MESSAGE TYPE");
            smsFunctions.AddParam("NEW MSG").AddParam("CANNED MSG").AddParam("LAST SEND MSG").AddParam("LAST ENTERED MSG");

            var radioParams = new List<WidgetTextParams> {smsFunctions};


            optionMenu.AddActionToParam(optionMenu.GetParam("SmsValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("SmsTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("SmsValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("SmsTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                switch (activeParam.Text)
                {
                    case "NEW MSG":
                        {
                            wdg.PrepareToShowWidget(GetNameMenu(MenuNames.OptionMsgEnterSmsMenu));
                            break;
                        }
                }
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));

            return optionMenu;
        }

        public static Widget InitOptionMsgNewSmsMenu(RadioStation station)
        {
            var enterMsgMenu = new Widget(GetNameMenu(MenuNames.OptionMsgMenu));
            enterMsgMenu.LineSize[0] = 7;
            enterMsgMenu.LineSize[1] = 11.5;
            enterMsgMenu.LineSize[2] = 11.5;
            enterMsgMenu.LineSize[3] = 7;
            enterMsgMenu.LineCharOffset[0] = 6;
            enterMsgMenu.LineCharOffset[1] = 6;
            enterMsgMenu.LineCharOffset[2] = 7;
            enterMsgMenu.LineCharOffset[3] = 6;
            enterMsgMenu
                .AddParam(new Param("Body", null, "", 1, 0))
                .AddModesForParam("Body", new List<RadioStationMode> { RadioStationMode.ThreeG });
            enterMsgMenu.AddParam(new Param("Title", null, "USE ⟳ FOR MORE OPTIONS", 1, 8))
                .AddModesForParam("Title", new List<RadioStationMode> { RadioStationMode.ThreeG });
            enterMsgMenu
                .AddParam(new Param("LineOne", (string text, Param cParam) =>
            {
                cParam.text = cParam.Text.Remove(cParam.ActiveFrom, cParam.ActiveTo);
                cParam.text = cParam.Text.Insert(cParam.ActiveFrom, text);

            }, "                    ", 2, 0))
                .AddModesForParam("LineOne", new List<RadioStationMode> { RadioStationMode.ThreeG });
            enterMsgMenu
                .AddParam(new Param("LineTwo", (string text, Param cParam) =>
            {
                cParam.text = cParam.Text.Remove(cParam.ActiveFrom, cParam.ActiveTo);
                cParam.text = cParam.Text.Insert(cParam.ActiveFrom, text);

            }, "                    ", 3, 0))
                .AddModesForParam("LineTwo", new List<RadioStationMode> { RadioStationMode.ThreeG });
            enterMsgMenu
                .AddParam(new Param("Enter", null, "PRESS ENTER TO SEND MESSAGE", 4, 7))
                .AddModesForParam("Enter", new List<RadioStationMode> { RadioStationMode.ThreeG });

            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    param.ActiveFrom = 0;
                    param.ActiveTo = 1;
                    return;
                }

                if (activeParam.IsInParam())
                {
                    if (activeParam.ActiveFrom >= 0)
                    {
                        activeParam.ActiveFrom -= 1;
                        activeParam.ActiveTo = 1;
                    }
                    else
                    {
                        activeParam.IsActive = false;
                        wdg.GetParam("LineOne").IsActive = true;
                        wdg.GetParam("LineOne").ActiveFrom = 0;
                        wdg.GetParam("LineOne").ActiveTo = 1;
                    }
                    return;
                }

            }));

            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    param.ActiveFrom = 0;
                    param.ActiveTo = 1;
                    return;
                }

                if (activeParam.IsInParam())
                {
                    if (activeParam.ActiveFrom < 20)
                    {
                        activeParam.ActiveFrom += 1;
                        activeParam.ActiveTo = 1;
                    }
                    else
                    {
                        activeParam.IsActive = false;
                        wdg.GetParam("LineTwo").IsActive = true;
                        wdg.GetParam("LineTwo").ActiveFrom = 0;
                        wdg.GetParam("LineTwo").ActiveTo = 1;
                    }
                    return;
                }

            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("CALL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    activeParam = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "1ABC";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("LT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    activeParam = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "2DEF";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("MODE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    activeParam = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "3GHI";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("SQL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    activeParam = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "4JKL";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("ZERO", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    activeParam = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "5MNO";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    activeParam = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "6PQR";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);
            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("OPT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    activeParam = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "7STU";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("PGM", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    activeParam = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "8VWX";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    activeParam = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "9YZ?";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("UPDATE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null
                    || activeParam.Name != "ChanValue")
                {
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.Action("0");

            }));

            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var lineOne = wdg.GetParam("LineOne").Text.Trim(new char[] { ' ' });
                var lineTwo = wdg.GetParam("LineTwo").Text.Trim(new char[] { ' ' });
                _smsControls.NumberSms[_smsControls.CurrentIndex] = lineOne + lineTwo;

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.OptionMsgSmsSendingMenu));
            }));

            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));

            return enterMsgMenu;
        }

        public static Widget InitOptionMsgSmsSendingMenu(RadioStation station)
        {
            var optionMenu = new Widget("optionMsgSmsSendingMenu");

            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "", 1, 0));
            optionMenu.AddParam(new Param("SendingTitle", null, "SEND TO", 2, 9));
            optionMenu.AddParam(new Param("SendingValue", null, "STATION", 3, 9));
            optionMenu.AddParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL", 4, 12));

            optionMenu.GetParam("SendingValue").IsActive = true;

            var smsFunctions = new WidgetTextParams("SEND TO");
            smsFunctions.AddParam("STATION").AddParam("NET");
            var stationAddress = new WidgetTextParams("STATION ADDRESS");
            stationAddress.AddParam("7800H2");

            var radioParams = new List<WidgetTextParams> {smsFunctions, stationAddress};


            optionMenu.AddActionToParam(optionMenu.GetParam("SendingValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("SendingTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("SendingValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("SendingTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("SendingTitle");

                if (titleParam.Text == "STATION ADDRESS")
                {
                    widgetContainer[GetNameMenu(MenuNames.MainMenu)].MoveTo = null;
                    MainWindow.currObject.QueueWidget.Add(InitSentMessageTransition());
                    MainWindow.currObject.QueueWidget.Add(widgetContainer[GetNameMenu(MenuNames.MainMenu)]);
                    MainWindow.currObject.StartShowWidgetQueue();
                    return;
                }

                titleParam.Text = stationAddress.Name;
                activeParam.Text = stationAddress.CurrParam();
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);

            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();

                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("SendingTitle");

                activeParam.Text = radioParams[0].CurrParam();
                titleParam.Text = radioParams[0].Name;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            return optionMenu;
        }

        public static Widget InitSentMessageTransition()
        {

            var optionMenu = new Widget("sentMessageTransition");

            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "", 1, 0));
            optionMenu.AddParam(new Param("SendingTitle", null, "", 2, 7));
            optionMenu.AddParam(new Param("SendingValue", null, "MESSAGE SENT TO", 3, 7));


            return optionMenu;

        }

        public static Widget InitAleSelfAddressMenu(RadioStation station)
        {

            var optionMenu = new Widget("initAleFillMenu");

            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("StationRTmode", null, "R", 1, 0))
                .AddModesForParam("StationRTmode", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.AddParam(new Param("Battery", null, "BAT ■■■■■", 1, 2))
                .AddModesForParam("Battery", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu
                .AddParam(new Param("StationMode", null, "ALE", 1, 12, () =>
                {
                    optionMenu.GetParam("StationMode").Text = Enum.GetName(typeof(RadioStationMode), station.Mode);
                }))
                .AddModesForParam("Battery", new List<RadioStationMode> { RadioStationMode.ThreeG }); ;
            optionMenu
                .AddParam(new Param("SQ", null, "SQ", 1, 16))
                .AddModesForParam("Battery", new List<RadioStationMode> { RadioStationMode.ThreeG }); ;
            optionMenu
                .AddParam(new Param("SwitchState", null, "PT", 1, 19, () =>
                {
                    optionMenu.GetParam("SwitchState").Text = Enum.GetName(typeof(SwitcherState), station.GetState());
                }))
                .AddModesForParam("Battery", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.AddParam(new Param("InfoOne", null, "SELF ADDRESS", 2, 6));
            optionMenu.AddParam(new Param("InfoTwo", null, "NO 1-3 CHAR DEFAULT", 3, 3));
            optionMenu.AddParam(new Param("InfoBottom", null, "WAIT OR PRESS CLR/ENT TO CLEAR", 4, 6));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                widgetContainer[GetNameMenu(MenuNames.MainMenu)].MoveTo = null;
                MainWindow.currObject.QueueWidget.Add(widgetContainer[GetNameMenu(MenuNames.MainMenu)]);
                MainWindow.currObject.StartShowWidgetQueue();
            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                widgetContainer[GetNameMenu(MenuNames.MainMenu)].MoveTo = null;
                MainWindow.currObject.QueueWidget.Add(widgetContainer[GetNameMenu(MenuNames.MainMenu)]);
                MainWindow.currObject.StartShowWidgetQueue();
            }));

            return optionMenu;

        }

        public static Widget InitOptionAleMenu(RadioStation station)
        {

            var optionMenu = new Widget(GetNameMenu(MenuNames.OptionAleMenu));

            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;

            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "OPTIONS-ALE", 1, 0));
            optionMenu.AddParam(new Param("Lqa", null, "LQA", 2, 0));
            optionMenu.AddParam(new Param("Scores", null, "SCORES", 2, 10));
            optionMenu.AddParam(new Param("Tx-msg", null, "TX-MSG", 3, 0));
            optionMenu.AddParam(new Param("Rx-msg", null, "RX-MSG", 3, 10));
            optionMenu.GetParam("Lqa").IsActive = true;

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Rx-msg");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Lqa":
                        {
                            var param = wdg.GetParam("Rx-msg");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Scores":
                        {
                            var param = wdg.GetParam("Lqa");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Tx-msg":
                        {
                            var param = wdg.GetParam("Scores");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Rx-msg":
                        {
                            var param = wdg.GetParam("Tx-msg");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Lqa");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Lqa":
                        {
                            var param = wdg.GetParam("Scores");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Scores":
                        {
                            var param = wdg.GetParam("Tx-msg");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Tx-msg":
                        {
                            var param = wdg.GetParam("Rx-msg");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Rx-msg":
                        {
                            var param = wdg.GetParam("Lqa");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Lqa"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (wdg.ActiveParam() == null
                || wdg.ActiveParam().Name != "Lqa")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.OptionAleLqaMenu));
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Tx-msg"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (wdg.ActiveParam() == null
                || wdg.ActiveParam().Name != "Tx-msg")
                {
                    return;
                }

                var txMsg = InitOptionAleTxMsgMenu(station);
                txMsg.comeFrom = optionMenu;
                MainWindow.currObject.QueueWidget.Add(txMsg);
                if (station.TxMsgs.Msgs.Count < 0)
                {
                    MainWindow.currObject.QueueWidget.Add(wdg);
                }
                MainWindow.currObject.StartShowWidgetQueue();
            }));
            return optionMenu;
        }

        public static Widget InitOptionAleLqaMenu(RadioStation station)
        {

            var optionMenu = new Widget(GetNameMenu(MenuNames.OptionAleLqaMenu));

            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;

            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "OPTIONS-ALE-LQA", 1, 0));
            optionMenu.AddParam(new Param("EmptyLine", null, " ", 2, 0));
            optionMenu.AddParam(new Param("Exchange", null, "EXCHANGE", 3, 0));
            optionMenu.AddParam(new Param("Sound", null, "SOUND", 3, 15));
            optionMenu.GetParam("Exchange").IsActive = true;

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Sound");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Exchange":
                        {
                            var param = wdg.GetParam("Sound");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Sound":
                        {
                            var param = wdg.GetParam("Exchange");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Exchange");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Exchange":
                        {
                            var param = wdg.GetParam("Sound");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Sound":
                        {
                            var param = wdg.GetParam("Exchange");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Exchange"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();

                if (activeParam == null || activeParam.Name == "Exchange")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.OptionAleLqaExchangeMenu));

            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Sound"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();

                if (activeParam == null || activeParam.Name == "Sound")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.OptionAleLqaExchangeMenu));

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));

            return optionMenu;
        }
        public static Widget InitOptionAleLqaExchangeMenu(RadioStation station)
        {

            var optionMenu = new Widget(GetNameMenu(MenuNames.OptionAleLqaExchangeMenu));

            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;

            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("StationRTmode", null, "R", 1, 0));
            optionMenu.AddParam(new Param("Battery", null, "BAT ■■■■■", 1, 2));
            optionMenu.AddParam(new Param("StationMode", null, "ALE", 1, 10));
            optionMenu.AddParam(new Param("SQ", null, "SQ", 1, 14));
            optionMenu.AddParam(new Param("SwitchState", null, "PT", 1, 17));
            optionMenu.AddParam(new Param("ExchangeTitle", null, "EXCHANGE TYPE", 2, 7));
            optionMenu.AddParam(new Param("ExchangeValue", null, "INDIVIDUAL", 3, 12));
            optionMenu.AddParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL", 4, 12));

            optionMenu.GetParam("ExchangeValue").IsActive = true;
            optionMenu.GetParam("ExchangeValue").Y = Helper.CalcCenterIndent(optionMenu.GetParam("ExchangeValue").Text.Length, 25);
            optionMenu.GetParam("ExchangeTitle").Y = Helper.CalcCenterIndent(optionMenu.GetParam("ExchangeTitle").Text.Length, 25);

            var smsFunctions = new WidgetTextParams("EXCHANGE TYPE");
            smsFunctions.AddParam("INDIVIDUAL").AddParam("NET");

            var radioParams = new List<WidgetTextParams> {smsFunctions};


            optionMenu.AddActionToParam(optionMenu.GetParam("ExchangeValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("ExchangeTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("ExchangeValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("ExchangeTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("ExchangeTitle");

            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));

            return optionMenu;
        }

        public static Widget InitOptionAleTxMsgMenu(RadioStation station)
        {

            var optionMenu = new Widget("initOptionAleTxMsgMenu");

            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;

            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "OPTION-ALE-TX_MSG", 1, 0));
            optionMenu.AddParam(new Param("LineOne", null, "NO TX", 2, 0));
            optionMenu.AddParam(new Param("LineTwo", null, "MESSAGES", 3, 0));
            optionMenu.AddParam(new Param("Info", null, "PRESS ENT/CLR TO CONTINUE", 4, 10));

            var lineOne = optionMenu.GetParam("LineOne");
            var lineTwo = optionMenu.GetParam("LineTwo");

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (station.TxMsgs.IsEmpty())
                {
                    return;
                }

                void Clr()
                {
                    MainWindow.currObject.QueueWidget.Add(optionMenu);
                    MainWindow.currObject.StartShowWidgetQueue();
                }

                var question = DialogMenu("OPTION-ALE-TX_MSG", "SEND TX MESSAGE"
                    , Clr
                    , ifYes: () =>
                    {
                        var sendingMenu = InitOptionAleTxMsgSendingMenu(station, Clr);
                        MainWindow.currObject.QueueWidget.Add(sendingMenu);
                        MainWindow.currObject.StartShowWidgetQueue();
                    }
                    , Clr);


                MainWindow.currObject.QueueWidget.Add(question);
                MainWindow.currObject.StartShowWidgetQueue();
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (station.TxMsgs.IsEmpty())
                {
                    return;
                }
                var next = station.TxMsgs.PrevNdMsg();
                lineTwo.Text = next.msg;
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (station.TxMsgs.IsEmpty())
                {
                    return;
                }
                var next = station.TxMsgs.NextNdMsg();
                lineTwo.Text = next.msg;
            }));

            optionMenu.AddParam(new Param("Rebuild", null, "", 1, 0, () =>
            {
                if (station.TxMsgs.IsEmpty())
                {
                    lineOne.Text = "NO TX";
                    lineTwo.Text = "MESSAGES";
                    lineOne.SetLocation(2, 12);
                    lineTwo.SetLocation(3, 10);
                    return;
                }

                lineOne.Text = "TX MESSAGES TO SEND:";
                if (lineTwo.Text == "MESSAGES")
                {
                    optionMenu.GetParam("LineTwo").Text = station.TxMsgs.Msgs[0].msg;
                }

                lineOne.SetLocation(2, 5);
                lineTwo.SetLocation(3, 0);
            }));



            return optionMenu;
        }
        public static Widget InitProgramComsecMenu(RadioStation station)
        {

            var optionMenu = new Widget(GetNameMenu(MenuNames.OptionAleLqaMenu));
            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 1;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 11.5;
            optionMenu.LineCharOffset[0] = 3;
            optionMenu.LineCharOffset[1] = 1;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "PGM-COMSEC", 1, 0));
            optionMenu.AddParam(new Param("EmptyLine", null, " ", 2, 0));
            optionMenu.AddParam(new Param("Cam", null, "CAM", 3, 0));
            optionMenu.AddParam(new Param("Id", null, "ID", 3, 10));
            optionMenu.AddParam(new Param("Keys", null, "KEYS", 3, 20));
            optionMenu.AddParam(new Param("Mi", null, "MI", 4, 0));
            optionMenu.AddParam(new Param("Aks", null, "AKS", 4, 15));
            optionMenu.GetParam("Cam").IsActive = true;

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Aks");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Cam":
                        {
                            var param = wdg.GetParam("Aks");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Id":
                        {
                            var param = wdg.GetParam("Cam");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Keys":
                        {
                            var param = wdg.GetParam("Id");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Mi":
                        {
                            var param = wdg.GetParam("Keys");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Aks":
                        {
                            var param = wdg.GetParam("Mi");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Cam");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Cam":
                        {
                            var param = wdg.GetParam("Id");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Id":
                        {
                            var param = wdg.GetParam("Keys");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Keys":
                        {
                            var param = wdg.GetParam("Mi");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Mi":
                        {
                            var param = wdg.GetParam("Aks");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Aks":
                        {
                            var param = wdg.GetParam("Cam");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Id"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();

                if (activeParam == null || activeParam.Name != "Id")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.ProgramComsecIdMenu));

            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Mi"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();

                if (activeParam == null || activeParam.Name != "Mi")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.ProgramComsecMiMenu));

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Aks"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();

                if (activeParam == null || activeParam.Name != "Aks")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.ProgramComsecAksMenu));

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Keys"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();

                if (activeParam == null || activeParam.Name != "Keys")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.ProgramComsecKeysMenu));

            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));
            return optionMenu;
        }

        public static Widget InitProgramComsecIdMenu(RadioStation station)
        {

            var optionMenu = new Widget(GetNameMenu(MenuNames.ProgramComsecIdMenu));

            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "PGM-COMSEC-ID", 1, 0));
            optionMenu.AddParam(new Param("IdTitle", null, "KERNEL_ID", 2, 7));
            optionMenu.AddParam(new Param("IdValue", null, "", 3, 12));
            optionMenu.AddParam(new Param("Info", null, "", 4, 15));

            optionMenu.GetParam("IdValue").IsActive = true;

            var smsFunctions = new WidgetTextParams("KERNEL_ID");
            smsFunctions.AddParam("");

            var radioParams = new List<WidgetTextParams> {smsFunctions};


            optionMenu.AddActionToParam(optionMenu.GetParam("IdValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("IdTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("IdValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("IdTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
            }));


            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));

            return optionMenu;
        }
        public static Widget InitProgramComsecMiMenu(RadioStation station)
        {

            var programMenu = new Widget(GetNameMenu(MenuNames.ProgramComsecMiMenu));

            programMenu.LineSize[0] = 7;
            programMenu.LineSize[1] = 11.5;
            programMenu.LineSize[2] = 11.5;
            programMenu.LineSize[3] = 7;
            programMenu.LineCharOffset[0] = 6;
            programMenu.LineCharOffset[1] = 6;
            programMenu.LineCharOffset[2] = 7;
            programMenu.LineCharOffset[3] = 6;
            programMenu.AddParam(new Param("Body", null, "", 1, 0));
            programMenu.AddParam(new Param("Title", null, "PGM-COMSEC-MI", 1, 0));
            programMenu.AddParam(new Param("MiTitle", null, "CRYPTO MI", 2, 10));
            programMenu.AddParam(new Param("MiValue", null, "DEFAULT", 3, 11));
            programMenu.AddParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL", 4, 12));

            programMenu.GetParam("MiValue").IsActive = true;
            programMenu.GetParam("MiValue").Y = Helper.CalcCenterIndent(programMenu.GetParam("MiValue").Text.Length, 25);
            programMenu.GetParam("MiTitle").Y = Helper.CalcCenterIndent(programMenu.GetParam("MiTitle").Text.Length, 25);

            var smsFunctions = new WidgetTextParams("CRYPTO MI");
            smsFunctions.AddParam("DEFAULT").AddParam("3X").AddParam("1X");

            var radioParams = new List<WidgetTextParams> {smsFunctions};


            programMenu.AddActionToParam(programMenu.GetParam("MiValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("MiTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            programMenu.AddActionToParam(programMenu.GetParam("MiValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("MiTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));


            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));

            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));

            return programMenu;
        }

        public static Widget InitProgramComsecAksMenu(RadioStation station)
        {

            var programMenu = new Widget(GetNameMenu(MenuNames.ProgramComsecAksMenu));

            programMenu.LineSize[0] = 7;
            programMenu.LineSize[1] = 11.5;
            programMenu.LineSize[2] = 11.5;
            programMenu.LineSize[3] = 7;
            programMenu.LineCharOffset[0] = 6;
            programMenu.LineCharOffset[1] = 6;
            programMenu.LineCharOffset[2] = 7;
            programMenu.LineCharOffset[3] = 6;
            programMenu.AddParam(new Param("Body", null, "", 1, 0));
            programMenu.AddParam(new Param("Title", null, "PGM-COMSEC-AKS", 1, 0));
            programMenu.AddParam(new Param("AksTitle", null, "AUTO KEY SELECT", 2, 7));
            programMenu.AddParam(new Param("AksValue", null, "KEY & KRYPTO TYPE", 3, 10));
            programMenu.AddParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL", 4, 12));

            programMenu.GetParam("AksValue").IsActive = true;
            programMenu.GetParam("AksValue").Y = Helper.CalcCenterIndent(programMenu.GetParam("AksValue").Text.Length, 25);
            programMenu.GetParam("AksTitle").Y = Helper.CalcCenterIndent(programMenu.GetParam("AksTitle").Text.Length, 25);

            var @params = new WidgetTextParams("AUTO KEY SELECT");
            @params.AddParam("KEY & KRYPTO TYPE").AddParam("KEY ONLY").AddParam("DISABLE");

            var radioParams = new List<WidgetTextParams> {@params};

            programMenu.AddActionToParam(programMenu.GetParam("AksValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("AksTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            programMenu.AddActionToParam(programMenu.GetParam("AksValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("AksTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));


            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));

            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));

            return programMenu;
        }

        public static Widget InitProgramComsecKeysMenu(RadioStation station)
        {
            var optionMenu = new Widget(GetNameMenu(MenuNames.ProgramComsecKeysMenu));
            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 1;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "PGM-COMSEC", 1, 0));
            optionMenu.AddParam(new Param("EmptyLine", null, " ", 2, 0));
            optionMenu.AddParam(new Param("Enter", null, "ENTER", 3, 0));
            optionMenu.AddParam(new Param("Update", null, "UPDATE", 3, 8));
            optionMenu.AddParam(new Param("Erase", null, "ERASE", 3, 15));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Erase");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Enter":
                        {
                            var param = wdg.GetParam("Erase");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Update":
                        {
                            var param = wdg.GetParam("Enter");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Erase":
                        {
                            var param = wdg.GetParam("Update");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Enter");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Enter":
                        {
                            var param = wdg.GetParam("Update");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Update":
                        {
                            var param = wdg.GetParam("Erase");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Erase":
                        {
                            var param = wdg.GetParam("Enter");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Enter"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();

                if (activeParam == null || activeParam.Name != "Enter")
                {
                    return;
                }
                var nextStep = InitProgramComsecKeysEnterMenu(station);

                nextStep.AddActionToParam(nextStep.GetParam("Body"), new Button("CLR", (Button btn1, RadioStation rs1, Widget wdg1) =>
                {
                    optionMenu.moveTo = null;
                    MainWindow.currObject.QueueWidget.Add(optionMenu);
                    MainWindow.currObject.StartShowWidgetQueue();
                }));

                MainWindow.currObject.QueueWidget.Add(nextStep);
                MainWindow.currObject.StartShowWidgetQueue();

            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Update"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();

                if (activeParam == null || activeParam.Name != "Update")
                {
                    return;
                }

                var nextStep = InitProgramComsecKeysUpdateMenu(station);

                nextStep.AddActionToParam(nextStep.GetParam("Body"), new Button("CLR", (Button btn1, RadioStation rs1, Widget wdg1) =>
                {
                    optionMenu.moveTo = null;
                    MainWindow.currObject.QueueWidget.Add(optionMenu);
                    MainWindow.currObject.StartShowWidgetQueue();
                }));


                MainWindow.currObject.QueueWidget.Add(nextStep);

                MainWindow.currObject.StartShowWidgetQueue();

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Erase"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();

                if (activeParam == null || activeParam.Name != "Erase")
                {
                    return;
                }

                wdg.ShowPreviousWidget();

            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {

                wdg.ShowPreviousWidget();

            }));
            return optionMenu;
        }

        public static Widget InitProgramComsecKeysEnterMenu(RadioStation station)
        {

            var programMenu = new Widget("initProgramComsecKeysEnterMenu");

            programMenu.LineSize[0] = 7;
            programMenu.LineSize[1] = 11.5;
            programMenu.LineSize[2] = 11.5;
            programMenu.LineSize[3] = 7;
            programMenu.LineCharOffset[0] = 6;
            programMenu.LineCharOffset[1] = 6;
            programMenu.LineCharOffset[2] = 7;
            programMenu.LineCharOffset[3] = 6;
            programMenu.AddParam(new Param("Body", null, "", 1, 0));
            programMenu.AddParam(new Param("Title", null, "PGM-COMSEC-KEYS", 1, 0));
            programMenu.AddParam(new Param("KeyTitle", null, "KEY TYPE", 2, 10));
            programMenu.AddParam(new Param("KeyValue", null, "CITADEL I (MK-128)", 3, 6));
            programMenu.AddParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL", 4, 12));

            programMenu.GetParam("KeyValue").IsActive = true;
            programMenu.GetParam("KeyValue").Y = Helper.CalcCenterIndent(programMenu.GetParam("KeyValue").Text.Length, 25);
            programMenu.GetParam("KeyTitle").Y = Helper.CalcCenterIndent(programMenu.GetParam("KeyTitle").Text.Length, 25);

            var @params = new WidgetTextParams("KEY TYPE");
            @params
                .AddParam(KeyModule.TypeToString(KeyModule.KeyType.Citadel1))
                .AddParam(KeyModule.TypeToString(KeyModule.KeyType.Aes256))
                .AddParam(KeyModule.TypeToString(KeyModule.KeyType.Aes128));

            var radioParams = new List<WidgetTextParams> {@params};


            programMenu.AddActionToParam(programMenu.GetParam("KeyValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            programMenu.AddActionToParam(programMenu.GetParam("KeyValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var nextStep = InitProgramComsecKeysEnterNameMenu(station);
                nextStep.ObjectContainer.Add("KeyType", KeyModule.StringToType(wdg.GetParam("KeyValue").Text));

                nextStep.AddActionToParam(nextStep.GetParam("Body"), new Button("CLR", (Button btn1, RadioStation rs1, Widget wdg1) =>
                {
                    MainWindow.currObject.QueueWidget.Add(programMenu);
                    MainWindow.currObject.StartShowWidgetQueue();
                }));

                MainWindow.currObject.QueueWidget.Add(nextStep);
                MainWindow.currObject.StartShowWidgetQueue();
            }));

            return programMenu;
        }
        public static Widget InitProgramComsecKeysEnterNameMenu(RadioStation station)
        {

            var programMenu = new Widget("initProgramComsecKeysEnterMenu");

            programMenu.LineSize[0] = 7;
            programMenu.LineSize[1] = 11.5;
            programMenu.LineSize[2] = 11.5;
            programMenu.LineSize[3] = 7;
            programMenu.LineCharOffset[0] = 6;
            programMenu.LineCharOffset[1] = 6;
            programMenu.LineCharOffset[2] = 7;
            programMenu.LineCharOffset[3] = 6;
            programMenu.AddParam(new Param("Body", null, "", 1, 0));
            programMenu.AddParam(new Param("Title", null, "PGM-COMSEC-KEYS-ENTER", 1, 0));
            programMenu.AddParam(new Param("KeyTitle", null, "KEY TO ENTER", 2, 6));
            programMenu.AddParam(new Param("KeyValue", (string text, Param cParam) =>
            {
                cParam.text = cParam.Text.Remove(cParam.ActiveFrom, cParam.ActiveTo);
                cParam.text = cParam.Text.Insert(cParam.ActiveFrom, text);
            }, "TEK01", 3, 11));
            programMenu.AddParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL", 4, 12));

            programMenu.GetParam("KeyValue").IsActive = true;
            programMenu.GetParam("KeyValue").ActiveTo = 1;

            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam.IsInParam())
                {
                    if (activeParam.ActiveFrom >= 0)
                    {
                        activeParam.ActiveFrom -= 1;
                        activeParam.ActiveTo = 1;
                    }
                    return;
                }

            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam.IsInParam())
                {
                    if (activeParam.ActiveFrom < 5)
                    {
                        activeParam.ActiveFrom += 1;
                        activeParam.ActiveTo = 1;
                    }
                    return;
                }

            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("CALL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();


                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "1ABC";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("LT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "2DEF";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("MODE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "3GHI";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("SQL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();


                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "4JKL";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("ZERO", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "5MNO";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "6PQR";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);
            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("OPT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "7STU";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("PGM", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "8VWX";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "9YZ?";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("UPDATE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                activeParam.Action("0");

            }));

            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                //wdg.showPreviousWidget();
                string keyName = programMenu.GetParam("KeyValue").Text;
                if (station.Keys.IsContainKey(keyName))
                {
                    var holderKeys = WpfHarris78.Src.Checker.LessonParametersHolder.Holder.Parameters.Program.Comsec.Keys;

                    foreach(var item in holderKeys.ToArray())
                    {
                        if (item.Name == keyName)
                        {
                            holderKeys.Remove(item);
                        } 
                    }

                    MainWindow.currObject.QueueWidget.Add(DialogMenu(title: "PGM-COMSEC-AKS-ENTER", text: "KEY EXIST OVERWRITE?", null
                        , ifYes: () =>
                        {
                            var keyValue = station.Keys.FindKey(programMenu.GetParam("KeyValue").Text);
                            var nextStep = InitProgramComsecKeysEnterValueMenu(rs);
                            nextStep.ObjectContainer.Add("KeyValue", keyValue);
                            nextStep.ObjectContainer.Add("KeyType", programMenu.ObjectContainer["KeyType"]);

                            nextStep.AddActionToParam(nextStep.GetParam("Body"), new Button("CLR", (Button btn1, RadioStation rs1, Widget wdg1) =>
                            {
                                MainWindow.currObject.QueueWidget.Add(programMenu);
                                MainWindow.currObject.StartShowWidgetQueue();
                            }));

                            MainWindow.currObject.QueueWidget.Add(nextStep);
                            MainWindow.currObject.StartShowWidgetQueue();
                        }
                        , ifNo: () =>
                        {
                            MainWindow.currObject.QueueWidget.Add(widgetContainer[GetNameMenu(MenuNames.ProgramComsecKeysMenu)]);
                            MainWindow.currObject.StartShowWidgetQueue();
                        }));
                    MainWindow.currObject.StartShowWidgetQueue();
                }
                else
                {
                    var keyValue = new KeyModule.KeyValue {keyName = programMenu.GetParam("KeyValue").Text};

                    var nextStep = InitProgramComsecKeysEnterValueMenu(rs);
                    nextStep.ObjectContainer.Add("KeyValue", keyValue);
                    nextStep.ObjectContainer.Add("KeyType", programMenu.ObjectContainer["KeyType"]);

                    nextStep.AddActionToParam(nextStep.GetParam("Body"), new Button("CLR", (Button btn1, RadioStation rs1, Widget wdg1) =>
                    {
                        MainWindow.currObject.QueueWidget.Add(programMenu);
                        MainWindow.currObject.StartShowWidgetQueue();
                    }));

                    MainWindow.currObject.QueueWidget.Add(nextStep);
                    MainWindow.currObject.StartShowWidgetQueue();
                }
            }));

            return programMenu;
        }
        public static Widget InitProgramComsecKeysEnterValueMenu(RadioStation station)
        {

            var enterMsgMenu = new Widget("initProgramComsecKeysEnterValueMenu");
            enterMsgMenu.LineSize[0] = 7;
            enterMsgMenu.LineSize[1] = 11.5;
            enterMsgMenu.LineSize[2] = 11.5;
            enterMsgMenu.LineSize[3] = 7;
            enterMsgMenu.LineCharOffset[0] = 6;
            enterMsgMenu.LineCharOffset[1] = 6;
            enterMsgMenu.LineCharOffset[2] = 7;
            enterMsgMenu.LineCharOffset[3] = 6;
            enterMsgMenu
                .AddParam(new Param("Body", null, "", 1, 0))
                .AddModesForParam("Body", new List<RadioStationMode> { RadioStationMode.ThreeG });
            enterMsgMenu.AddParam(new Param("Title", null, "PGM-COMSEC-KEYS-ENTER-", 1, 0))
                .AddModesForParam("Title", new List<RadioStationMode> { RadioStationMode.ThreeG });
            enterMsgMenu
                .AddParam(new Param("LineOne", (string text, Param cParam) =>
                {
                    cParam.text = cParam.Text.Remove(cParam.ActiveFrom, cParam.ActiveTo);
                    cParam.text = cParam.Text.Insert(cParam.ActiveFrom, text);

                }, "____________________", 2, 4))
                .AddModesForParam("LineOne", new List<RadioStationMode> { RadioStationMode.ThreeG });
            enterMsgMenu
                .AddParam(new Param("LineTwo", (string text, Param cParam) =>
                {
                    cParam.text = cParam.Text.Remove(cParam.ActiveFrom, cParam.ActiveTo);
                    cParam.text = cParam.Text.Insert(cParam.ActiveFrom, text);

                }, "____________________", 3, 4))
                .AddModesForParam("LineTwo", new List<RadioStationMode> { RadioStationMode.ThreeG });
            enterMsgMenu
                .AddParam(new Param("Enter", null, "PRESS ENTER TO SEND MESSAGE", 4, 6))
                .AddModesForParam("Enter", new List<RadioStationMode> { RadioStationMode.ThreeG });

            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    param.ActiveFrom = 0;
                    param.ActiveTo = 1;
                    return;
                }

                if (activeParam.IsInParam())
                {
                    if (activeParam.ActiveFrom > 0)
                    {
                        activeParam.ActiveFrom -= 1;
                        activeParam.ActiveTo = 1;
                    }
                    else
                    {
                        activeParam.IsActive = false;
                        wdg.GetParam("LineOne").IsActive = true;
                        wdg.GetParam("LineOne").ActiveFrom = 0;
                        wdg.GetParam("LineOne").ActiveTo = 1;
                    }
                    return;
                }

            }));

            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    param.ActiveFrom = 0;
                    param.ActiveTo = 1;
                    return;
                }

                if (activeParam.IsInParam())
                {
                    if (activeParam.ActiveFrom < 19)
                    {
                        activeParam.ActiveFrom += 1;
                        activeParam.ActiveTo = 1;
                    }
                    else
                    {
                        activeParam.IsActive = false;
                        wdg.GetParam("LineTwo").IsActive = true;
                        wdg.GetParam("LineTwo").ActiveFrom = 0;
                        wdg.GetParam("LineTwo").ActiveTo = 1;
                    }
                    return;
                }

            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("CALL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    activeParam = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "1ABC";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("LT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    activeParam = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "2DEF";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("MODE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    activeParam = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "3GHI";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("SQL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    activeParam = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "4JKL";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("ZERO", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    activeParam = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "5MNO";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    activeParam = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "6PQR";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);
            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("OPT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    activeParam = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "7STU";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("PGM", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    activeParam = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "8VWX";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    activeParam = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "9YZ?";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("UPDATE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    activeParam = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.Action("0");

            }));

            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var lineOne = wdg.GetParam("LineOne").Text.Trim(new char[] { '_' });
                var lineTwo = wdg.GetParam("LineTwo").Text.Trim(new char[] { '_' });
                var value = (KeyModule.KeyValue)enterMsgMenu.ObjectContainer["KeyValue"];
                var type = (KeyModule.KeyType)enterMsgMenu.ObjectContainer["KeyType"];
                value.keyVal = lineOne + lineTwo;
                value.stationMode = rs.Mode;
                value.type = type;

                rs.Keys.Keys[type].Add(value);

                void ReturnToThisWidget ()
                {
                    MainWindow.currObject.QueueWidget.Add(enterMsgMenu);
                    MainWindow.currObject.StartShowWidgetQueue();
                }

                if (type == KeyModule.KeyType.Citadel1)
                {
                    MainWindow.currObject.QueueWidget.Add(DialogMenu(title: "PGM-COMSEC-KEYS-ENTER"
                    , text: "ENTER AVS KEY"
                    , clr: ReturnToThisWidget
                    , ifYes: () =>
                    {
                        MainWindow.currObject.QueueWidget.Add(EnterMsg("PGM-COMSEC-KEYS-ENTER-", "ENTER AVS KEY"
                        , ReturnToThisWidget
                        , (string enteredMsg) =>
                        {
                            value.keyAws = enteredMsg;
                            WpfHarris78.Src.Checker.LessonParametersHolder.Holder.Parameters.Program.Comsec.Keys.Add(value.SerializeToProtobuf());
                            MainWindow.currObject.QueueWidget.Add(MessageMenu("PGM-COMSEC-KEYS-ENTER-"
                                , "MK-128 AND AWS"
                                , "KEYS LOADED"
                                , "WAIT OR PRESS CLR/ENT TO CONTINUE"
                                , ent: () => {
                                    var nextStep = InitProgramComsecKeysEnterMenu(station);

                                    nextStep.AddActionToParam(nextStep.GetParam("Body"), new Button("CLR", (Button btn1, RadioStation rs1, Widget wdg1) =>
                                    {
                                        var comsecKeys = widgetContainer[GetNameMenu(MenuNames.ProgramComsecKeysMenu)];
                                        comsecKeys.moveTo = null;
                                        MainWindow.currObject.QueueWidget.Add(comsecKeys);
                                        MainWindow.currObject.StartShowWidgetQueue();
                                    }));

                                    MainWindow.currObject.QueueWidget.Add(nextStep);
                                    MainWindow.currObject.StartShowWidgetQueue();
                                }
                                , clr: () => {
                                        var nextStep = InitProgramComsecKeysEnterMenu(station);

                                        nextStep.AddActionToParam(nextStep.GetParam("Body"), new Button("CLR", (Button btn1, RadioStation rs1, Widget wdg1) =>
                                        {
                                            var programComsec = widgetContainer[GetNameMenu(MenuNames.ProgramComsecKeysMenu)];
                                            programComsec.moveTo = null;
                                            MainWindow.currObject.QueueWidget.Add(programComsec);
                                            MainWindow.currObject.StartShowWidgetQueue();
                                        }));

                                        MainWindow.currObject.QueueWidget.Add(nextStep);
                                        MainWindow.currObject.StartShowWidgetQueue();
                                    })); 
                            var optionMenu = widgetContainer[GetNameMenu(MenuNames.ProgramComsecKeysMenu)];
                            optionMenu.moveTo = null;
                            MainWindow.currObject.QueueWidget.Add(optionMenu);
                            MainWindow.currObject.StartShowWidgetQueue();
                        }));
                        MainWindow.currObject.StartShowWidgetQueue();
                    }
                    , ifNo: () => {
                        WpfHarris78.Src.Checker.LessonParametersHolder.Holder.Parameters.Program.Comsec.Keys.Add(value.SerializeToProtobuf());
                        Widget keyLoaded = MessageMenu("PGM-COMSEC-KEYS-ENTER--",
                                    "MK-128 AND AVS",
                                    "KEYS LOADED",
                                    "WAIT OR PRESS CLR/ENT TO CONTINUE",
                                    ent: () => {
                                        var nextStep = InitProgramComsecKeysEnterMenu(station);

                                        nextStep.AddActionToParam(nextStep.GetParam("Body"), new Button("CLR", (Button btn1, RadioStation rs1, Widget wdg1) =>
                                        {
                                            var programComsec = widgetContainer[GetNameMenu(MenuNames.ProgramComsecKeysMenu)];
                                            programComsec.moveTo = null;
                                            MainWindow.currObject.QueueWidget.Add(programComsec);
                                            MainWindow.currObject.StartShowWidgetQueue();
                                        }));

                                        MainWindow.currObject.QueueWidget.Add(nextStep);
                                        MainWindow.currObject.StartShowWidgetQueue();
                                    },
                                    clr: () => {
                                        var nextStep = InitProgramComsecKeysEnterMenu(station);

                                        nextStep.AddActionToParam(nextStep.GetParam("Body"), new Button("CLR", (Button btn1, RadioStation rs1, Widget wdg1) =>
                                        {
                                            var programComsec = widgetContainer[GetNameMenu(MenuNames.ProgramComsecKeysMenu)];
                                            programComsec.moveTo = null;
                                            MainWindow.currObject.QueueWidget.Add(programComsec);
                                            MainWindow.currObject.StartShowWidgetQueue();
                                        }));

                                        MainWindow.currObject.QueueWidget.Add(nextStep);
                                        MainWindow.currObject.StartShowWidgetQueue();
                                    });

                        var optionMenu = widgetContainer[GetNameMenu(MenuNames.ProgramComsecKeysMenu)];
                        optionMenu.moveTo = null;
                        MainWindow.currObject.QueueWidget.Add(keyLoaded);
                        MainWindow.currObject.QueueWidget.Add(optionMenu);
                        MainWindow.currObject.StartShowWidgetQueue(1000);
                    }));
                    MainWindow.currObject.StartShowWidgetQueue();
                }
                else
                {
                    WpfHarris78.Src.Checker.LessonParametersHolder.Holder.Parameters.Program.Comsec.Keys.Add(value.SerializeToProtobuf());
                    MainWindow.currObject.QueueWidget.Add(MessageMenu("PGM-COMSEC-KEYS-ENTER"
                        , KeyModule.TypeToString(type).ToUpper()
                        , "KEY ENTERED"
                        , "WAIT OR PRESS CLR/ENT TO CONTINUE"
                        , ReturnToThisWidget
                        , ReturnToThisWidget));
                    MainWindow.currObject.QueueWidget.Add(enterMsgMenu);
                    MainWindow.currObject.StartShowWidgetQueue();
                }

                //wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionMsgSmsSendingMenu));
            }));


            return enterMsgMenu;
        }

        public static Widget DialogMenu(string title, string text, Action clr, Action ifYes, Action ifNo = null)
        {
            var programMenu = new Widget(title);

            programMenu.LineSize[0] = 7;
            programMenu.LineSize[1] = 11.5;
            programMenu.LineSize[2] = 11.5;
            programMenu.LineSize[3] = 7;
            programMenu.LineCharOffset[0] = 6;
            programMenu.LineCharOffset[1] = 6;
            programMenu.LineCharOffset[2] = 7;
            programMenu.LineCharOffset[3] = 6;

            programMenu.AddParam(new Param("Body", null, "", 1, 0));
            programMenu.AddParam(new Param("Title", null, title, 1, 0));
            programMenu.AddParam(new Param("KeyTitle", null, text, 2, 7));
            programMenu.AddParam(new Param("KeyValue", null, "YES", 3, 13));
            programMenu.AddParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL", 4, 12));

            programMenu.GetParam("KeyValue").IsActive = true;
            programMenu.GetParam("KeyTitle").Y = Helper.CalcCenterIndent(programMenu.GetParam("KeyTitle").Text.Length, 25);

            var @params = new WidgetTextParams(text);
            @params
                .AddParam("YES")
                .AddParam("NO");

            var radioParams = new List<WidgetTextParams> {@params};


            programMenu.AddActionToParam(programMenu.GetParam("KeyValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
            }));

            programMenu.AddActionToParam(programMenu.GetParam("KeyValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
            }));


            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                clr?.Invoke();
            }));

            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var choice = programMenu.ActiveParam().Text;

                if (choice == "YES")
                {
                    ifYes?.Invoke();
                }
                else
                {
                    ifNo?.Invoke();
                }
            }));

            return programMenu;
        }
        public static Widget EnterMsg(string title, string info, Action clr, Action<string> ent)
        {

            var enterMsgMenu = new Widget(title);
            enterMsgMenu.LineSize[0] = 7;
            enterMsgMenu.LineSize[1] = 11.5;
            enterMsgMenu.LineSize[2] = 11.5;
            enterMsgMenu.LineSize[3] = 7;
            enterMsgMenu.LineCharOffset[0] = 6;
            enterMsgMenu.LineCharOffset[1] = 6;
            enterMsgMenu.LineCharOffset[2] = 7;
            enterMsgMenu.LineCharOffset[3] = 6;

            enterMsgMenu
                .AddParam(new Param("Body", null, "", 1, 0))
                .AddModesForParam("Body", new List<RadioStationMode> { RadioStationMode.ThreeG });
            enterMsgMenu.AddParam(new Param("Title", null, title, 1, 0))
                .AddModesForParam("Title", new List<RadioStationMode> { RadioStationMode.ThreeG });
            enterMsgMenu
                .AddParam(new Param("LineOne", (string text, Param cParam) =>
                {
                    cParam.text = cParam.Text.Remove(cParam.ActiveFrom, cParam.ActiveTo);
                    cParam.text = cParam.Text.Insert(cParam.ActiveFrom, text);

                }, "____________________", 2, 0))
                .AddModesForParam("LineOne", new List<RadioStationMode> { RadioStationMode.ThreeG });
            enterMsgMenu
                .AddParam(new Param("LineTwo", (string text, Param cParam) =>
                {
                    cParam.text = cParam.Text.Remove(cParam.ActiveFrom, cParam.ActiveTo);
                    cParam.text = cParam.Text.Insert(cParam.ActiveFrom, text);

                }, "____________________", 3, 0))
                .AddModesForParam("LineTwo", new List<RadioStationMode> { RadioStationMode.ThreeG });
            enterMsgMenu
                .AddParam(new Param("Info", null, info, 4, 0))
                .AddModesForParam("Info", new List<RadioStationMode> { RadioStationMode.ThreeG });

            enterMsgMenu.GetParam("Info").Y = Helper.CalcCenterIndent(enterMsgMenu.GetParam("Info").Text.Length, 25);

            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    param.ActiveFrom = 0;
                    param.ActiveTo = 1;
                    return;
                }

                if (activeParam.IsInParam())
                {
                    if (activeParam.ActiveFrom >= 0)
                    {
                        activeParam.ActiveFrom -= 1;
                        activeParam.ActiveTo = 1;
                    }
                    else
                    {
                        activeParam.IsActive = false;
                        wdg.GetParam("LineOne").IsActive = true;
                        wdg.GetParam("LineOne").ActiveFrom = 0;
                        wdg.GetParam("LineOne").ActiveTo = 1;
                    }
                    return;
                }

            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    param.ActiveFrom = 0;
                    param.ActiveTo = 1;
                    return;
                }

                if (activeParam.IsInParam())
                {
                    if (activeParam.ActiveFrom < 19)
                    {
                        activeParam.ActiveFrom += 1;
                        activeParam.ActiveTo = 1;
                    }
                    else
                    {
                        activeParam.IsActive = false;
                        wdg.GetParam("LineTwo").IsActive = true;
                        wdg.GetParam("LineTwo").ActiveFrom = 0;
                        wdg.GetParam("LineTwo").ActiveTo = 1;
                    }
                    return;
                }

            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("CALL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    activeParam = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "1ABC";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("LT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    activeParam = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "2DEF";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("MODE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    activeParam = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "3GHI";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("SQL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    activeParam = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "4JKL";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("ZERO", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    activeParam = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "5MNO";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    activeParam = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "6PQR";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);
            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("OPT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    activeParam = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "7STU";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("PGM", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    activeParam = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "8VWX";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    activeParam = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "9YZ?";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("UPDATE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    activeParam = wdg.GetParam("LineOne");
                    wdg.DeactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.Action("0");

            }));

            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var lineOne = wdg.GetParam("LineOne").Text.Trim(new char[] { '_' });
                var lineTwo = wdg.GetParam("LineTwo").Text.Trim(new char[] { '_' });

                ent?.Invoke(lineOne + lineTwo);
            }));

            enterMsgMenu.AddActionToParam(enterMsgMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                clr?.Invoke();
            }));

            return enterMsgMenu;
        }
        public static Widget MessageMenu(string title, string lineOne, string lineTwo, string info, Action ent = null, Action clr = null)
        {
            var programMenu = new Widget(title);

            programMenu.LineSize[0] = 7;
            programMenu.LineSize[1] = 11.5;
            programMenu.LineSize[2] = 11.5;
            programMenu.LineSize[3] = 7;
            programMenu.LineCharOffset[0] = 6;
            programMenu.LineCharOffset[1] = 6;
            programMenu.LineCharOffset[2] = 7;
            programMenu.LineCharOffset[3] = 6;
            programMenu.AddParam(new Param("Body", null, "", 1, 0));
            programMenu.AddParam(new Param("Title", null, title, 1, 0));
            programMenu.AddParam(new Param("KeyTitle", null, lineOne, 2, 7));
            programMenu.AddParam(new Param("KeyValue", null, lineTwo, 3, 10));
            programMenu.AddParam(new Param("Info", null, info, 4, 5));

            //programMenu.GetParam("Title").Y = Helper.CalcCenterIndent(programMenu.GetParam("Title").Text.Length, 25);
            //programMenu.GetParam("Info").Y = Helper.CalcCenterIndent(programMenu.GetParam("Info").Text.Length, 25);
            programMenu.GetParam("KeyTitle").Y = Helper.CalcCenterIndent(programMenu.GetParam("KeyTitle").Text.Length, 25);
            programMenu.GetParam("KeyValue").Y = Helper.CalcCenterIndent(programMenu.GetParam("KeyValue").Text.Length, 25);



            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                clr?.Invoke();
            }));

            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                ent?.Invoke();
            }));

            return programMenu;
        }
        public static Widget InitProgramComsecKeysUpdateMenu(RadioStation station)
        {

            var programMenu = new Widget("InitProgramComsecKeysUpdateMenu");

            programMenu.LineSize[0] = 7;
            programMenu.LineSize[1] = 11.5;
            programMenu.LineSize[2] = 11.5;
            programMenu.LineSize[3] = 7;
            programMenu.LineCharOffset[0] = 6;
            programMenu.LineCharOffset[1] = 6;
            programMenu.LineCharOffset[2] = 7;
            programMenu.LineCharOffset[3] = 6;
            programMenu.AddParam(new Param("Body", null, "", 1, 0));
            programMenu.AddParam(new Param("Title", null, "PGM-COMSEC-KEYS-UPDATE", 1, 0));
            programMenu.AddParam(new Param("KeyTitle", null, "KEY TYPE", 2, 9));
            programMenu.AddParam(new Param("KeyValue", null, "CITADEL I (MK-128)", 3, 10));
            programMenu.AddParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL", 4, 12));

            programMenu.GetParam("KeyValue").IsActive = true;
            programMenu.GetParam("KeyValue").Y = Helper.CalcCenterIndent(programMenu.GetParam("KeyValue").Text.Length, 25);
            programMenu.GetParam("KeyTitle").Y = Helper.CalcCenterIndent(programMenu.GetParam("KeyTitle").Text.Length, 25);

            var @params = new WidgetTextParams("KEY TYPE");
            @params
                .AddParam(KeyModule.TypeToString(KeyModule.KeyType.Citadel1))
                .AddParam(KeyModule.TypeToString(KeyModule.KeyType.Aes256))
                .AddParam(KeyModule.TypeToString(KeyModule.KeyType.Aes128));

            var radioParams = new List<WidgetTextParams> {@params};


            programMenu.AddActionToParam(programMenu.GetParam("KeyValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;

                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            programMenu.AddActionToParam(programMenu.GetParam("KeyValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;

                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var keyType = KeyModule.StringToType(wdg.GetParam("KeyValue").Text);
                var nextStep = InitProgramComsecKeysUpdateKeysMenu(station, keyType);
                nextStep.ObjectContainer.Add("KeyType", keyType);

                nextStep.AddActionToParam(nextStep.GetParam("Body"), new Button("CLR", (Button btn1, RadioStation rs1, Widget wdg1) =>
                {
                    MainWindow.currObject.QueueWidget.Add(programMenu);
                    MainWindow.currObject.StartShowWidgetQueue();
                }));

                MainWindow.currObject.QueueWidget.Add(nextStep);
                MainWindow.currObject.StartShowWidgetQueue();
            }));

            return programMenu;
        }
        public static Widget InitProgramComsecKeysUpdateKeysMenu(RadioStation station, KeyModule.KeyType type)
        {

            var keysByType = station.Keys.Keys[type];


            var @params = new WidgetTextParams("KEY TYPE");

            keysByType.ForEach(v =>
            {
                @params.AddParam(v.keyName);
            });

            var programMenu = new Widget("initProgramComsecKeysUpdateKeysMenu");

            programMenu.LineSize[0] = 7;
            programMenu.LineSize[1] = 11.5;
            programMenu.LineSize[2] = 11.5;
            programMenu.LineSize[3] = 7;
            programMenu.LineCharOffset[0] = 6;
            programMenu.LineCharOffset[1] = 6;
            programMenu.LineCharOffset[2] = 7;
            programMenu.LineCharOffset[3] = 6;
            programMenu.AddParam(new Param("Body", null, "", 1, 0));
            programMenu.AddParam(new Param("Title", null, "PGM-COMSEC-KEYS-UPDATE: ", 1, 0, () =>
            {
                var title = programMenu.GetParam("Title");
                title.Text = "PGM-COMSEC-KEYS-UPDATE:      " + type;
            }));
            programMenu.AddParam(new Param("CountTitle", null, "UPDATE COUNT:", 2, 0));
            programMenu.AddParam(new Param("CountValue", null, "00", 2, 20
                , update: () =>
                {
                    var count = programMenu.GetParam("CountValue");
                    var value = keysByType.Find(v =>
                    {
                        return v.keyName == @params.CurrParam();
                    });
                    if (value != null)
                    {
                        count.Text = value.CountToString();
                    }

                }));

            var keyValue = "----------";

            if (keysByType.Count > 0)
            {
                keyValue = keysByType[0].keyName;
            }

            programMenu.AddParam(new Param("IsUpdateTitle", null, "UPDATE?", 2, 0));
            programMenu.AddParam(new Param("IsUpdateValue", null, "YES", 2, 20));
            programMenu.GetParam("IsUpdateTitle").IsVisible = false;
            programMenu.GetParam("IsUpdateValue").IsVisible = false;

            programMenu.AddParam(new Param("KeyValue", null, keyValue, 3, 9));
            programMenu.AddParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL", 4, 12));

            programMenu.GetParam("KeyValue").IsActive = true;


            programMenu.AddActionToParam(programMenu.GetParam("KeyValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                if (programMenu.GetParam("CountTitle").IsVisible && keysByType.Count > 0)
                {
                    activeParam.Text = @params.GetPrevParam();
                    activeParam.ActiveTo = activeParam.Text.Length;
                }
                else if (programMenu.GetParam("IsUpdateTitle").IsVisible)
                {
                    activeParam.Text = activeParam.Text == "YES" ? "NO" : "YES";
                }
            }));

            programMenu.AddActionToParam(programMenu.GetParam("KeyValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                if (programMenu.GetParam("CountTitle").IsVisible && keysByType.Count > 0)
                {

                    activeParam.Text = @params.GetNextParam();
                    activeParam.ActiveTo = activeParam.Text.Length;
                }
                else if (programMenu.GetParam("IsUpdateTitle").IsVisible)
                {
                    activeParam.Text = activeParam.Text == "YES" ? "NO" : "YES";
                }
            }));

            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                if (keysByType.Count <= 0)
                {
                    return;
                }

                void ReturnToThisWidget()
                {
                    MainWindow.currObject.QueueWidget.Add(programMenu);
                    MainWindow.currObject.StartShowWidgetQueue();
                }

                if (programMenu.GetParam("CountTitle").IsVisible)
                {
                    programMenu.GetParam("CountTitle").IsVisible = false;
                    programMenu.GetParam("CountValue").IsVisible = false;
                    programMenu.GetParam("IsUpdateTitle").IsVisible = true;
                    programMenu.GetParam("IsUpdateValue").IsVisible = true;

                    programMenu.DeactiveParam();
                    programMenu.GetParam("IsUpdateValue").IsActive = true;
                    programMenu.GetParam("IsUpdateValue").Text = "YES";
                    return;
                }
                if (programMenu.GetParam("IsUpdateTitle").IsVisible)
                {
                    if (programMenu.GetParam("IsUpdateValue").Text == "YES")
                    {
                        var keyValueParam = programMenu.GetParam("KeyValue");
                        keysByType.Find(kv => kv.keyName == keyValueParam.Text).updateCount += 1;
                        MainWindow.currObject.QueueWidget.Add(MessageMenu("PGM-COMSEC-KEYS-ENTER-"
                                , "** UPDATE KEY **"
                                , "KEY UPDATE"
                                , "WAIT OR PRESS CLR/ENT TO CONTINUE"
                                , ReturnToThisWidget
                                , ReturnToThisWidget));
                        MainWindow.currObject.QueueWidget.Add(programMenu);
                        MainWindow.currObject.StartShowWidgetQueue();
                    }
                    else
                    {
                        MainWindow.currObject.QueueWidget.Add(programMenu);
                        MainWindow.currObject.StartShowWidgetQueue(500);
                    }

                    programMenu.GetParam("CountTitle").IsVisible = true;
                    programMenu.GetParam("CountValue").IsVisible = true;
                    programMenu.GetParam("IsUpdateTitle").IsVisible = false;
                    programMenu.GetParam("IsUpdateValue").IsVisible = false;

                    programMenu.DeactiveParam();
                    programMenu.GetParam("KeyValue").IsActive = true;
                }
            }));

            return programMenu;
        }

        public static Widget InitProgramModeMenu(RadioStation station)
        {

            var optionMenu = new Widget(GetNameMenu(MenuNames.ProgramModeMenu));
            optionMenu.LineSize[0] = 7;
            //optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 11.5;
            optionMenu.LineCharOffset[0] = 6;
            //optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "PGM-MODE", 1, 0));
            optionMenu.AddParam(new Param("EmptyLine", null, " ", 2, 0));
            optionMenu.AddParam(new Param("Preset", null, "PRESET", 3, 0));
            optionMenu.AddParam(new Param("Ale", null, "ALE", 3, 10));
            optionMenu.AddParam(new Param("3G", null, "3G", 3, 20));
            optionMenu.AddParam(new Param("Hop", null, "HOP", 4, 0));
            optionMenu.AddParam(new Param("Arq", null, "ARQ", 4, 10));
            optionMenu.AddParam(new Param("Xdl", null, "XDL", 4, 20));
            optionMenu.GetParam("Preset").IsActive = true;

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Xdl");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Preset":
                        {
                            var param = wdg.GetParam("Xdl");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Ale":
                        {
                            var param = wdg.GetParam("Preset");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "3G":
                        {
                            var param = wdg.GetParam("Ale");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Hop":
                        {
                            var param = wdg.GetParam("3G");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Arq":
                        {
                            var param = wdg.GetParam("Hop");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Xdl":
                        {
                            var param = wdg.GetParam("Arq");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Preset");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Preset":
                        {
                            var param = wdg.GetParam("Ale");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Ale":
                        {
                            var param = wdg.GetParam("3G");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "3G":
                        {
                            var param = wdg.GetParam("Hop");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Hop":
                        {
                            var param = wdg.GetParam("Arq");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Arq":
                        {
                            var param = wdg.GetParam("Xdl");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Xdl":
                        {
                            var param = wdg.GetParam("Preset");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Preset"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();

                if (activeParam == null || activeParam.Name != "Preset")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.ProgramModePresetMenu));

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Ale"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();

                if (activeParam == null || activeParam.Name != "Ale")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.ProgramModeAleMenu));

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));
            return optionMenu;
        }
        public static Widget InitProgramModePresetMenu(RadioStation station)
        {

            var optionMenu = new Widget(GetNameMenu(MenuNames.ProgramModePresetMenu));
            optionMenu.LineSize[0] = 7;
            //optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 11.5;
            optionMenu.LineCharOffset[0] = 6;
            //optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "PGM-MODE", 1, 0));
            optionMenu.AddParam(new Param("EmptyLine", null, " ", 2, 0));
            optionMenu.AddParam(new Param("Channel", null, "CHANNEL", 3, 0));
            optionMenu.AddParam(new Param("Modem", null, "MODEM", 3, 10));
            optionMenu.AddParam(new Param("System", null, "SYSTEM", 4, 0));
            optionMenu.AddParam(new Param("Manual", null, "MANUAL", 4, 10));
            optionMenu.GetParam("Channel").IsActive = true;

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Manual");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Channel":
                        {
                            var param = wdg.GetParam("Manual");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Modem":
                        {
                            var param = wdg.GetParam("Channel");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "System":
                        {
                            var param = wdg.GetParam("Modem");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Manual":
                        {
                            var param = wdg.GetParam("System");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Channel");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Channel":
                        {
                            var param = wdg.GetParam("Modem");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Modem":
                        {
                            var param = wdg.GetParam("System");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "System":
                        {
                            var param = wdg.GetParam("Manual");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Manual":
                        {
                            var param = wdg.GetParam("Channel");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Channel"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();

                if (activeParam == null || activeParam.Name != "Channel")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.ProgramModePresetChannelMenu));

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Modem"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();

                if (activeParam == null || activeParam.Name != "Modem")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.ProgramModePresetModemMenu));

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("System"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();

                if (activeParam == null || activeParam.Name != "System")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.ProgramModePresetSystemMenu));

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));
            return optionMenu;
        }
        public static Widget InitProgramModePresetChannelMenu(RadioStation station)
        {
            var programMenu = new Widget(GetNameMenu(MenuNames.ProgramModePresetChannelMenu));

            programMenu.LineSize[0] = 7;
            programMenu.LineSize[1] = 11.5;
            programMenu.LineSize[2] = 11.5;
            programMenu.LineSize[3] = 7;
            programMenu.LineCharOffset[0] = 6;
            programMenu.LineCharOffset[1] = 6;
            programMenu.LineCharOffset[2] = 7;
            programMenu.LineCharOffset[3] = 6;
            programMenu.AddParam(new Param("Body", null, "", 1, 0));
            programMenu.AddParam(new Param("Title", null, "PGM-MODE-PRESET-CHANNEL-", 1, 0));
            programMenu.AddParam(new Param("KeyTitle", null, "CHANNEL NUMBER", 2, 6));
            programMenu.AddParam(new Param("KeyTitleCont", null, "TO CHANGE:", 3, 0));
            programMenu.AddParam(new Param("KeyValue", (string text, Param cParam) =>
            {
                cParam.text = cParam.Text.Remove(cParam.ActiveFrom, cParam.ActiveTo);
                cParam.text = cParam.Text.Insert(cParam.ActiveFrom, text);

            }, "000", 3, 15));
            programMenu.AddParam(new Param("Info", null, "ENT TO SAVE - CLR TO EXIT", 4, 10));

            programMenu.GetParam("KeyValue").IsActive = true;
            programMenu.GetParam("KeyValue").Y = Helper.CalcCenterIndent(programMenu.GetParam("KeyValue").Text.Length, 25);

            var channelNumberTp = new WidgetTextParams("CHANNEL NUMBER");//ENTER
            channelNumberTp.AddParam("000");
            var rxFrequencyPt = new WidgetTextParams("RX FREQUENCY");//ENTER
            rxFrequencyPt.AddParam("07.8000 MHZ");
            var txFrequencyPt = new WidgetTextParams("TX FREQUENCY");//ENTER
            txFrequencyPt.AddParam("07.8000 MHZ"); ;
            var modulationPt = new WidgetTextParams("MODULATION");
            modulationPt.AddParam("USB").AddParam("FM").AddParam("CW").AddParam("AME").AddParam("LSB");
            var rxOnlyPt = new WidgetTextParams("MODE");
            rxOnlyPt.AddParam("NO").AddParam("YES");
            var enableHailTxPt = new WidgetTextParams("ENABLE HAIL TX");
            enableHailTxPt.AddParam("NO").AddParam("YES");
            var hailKeyPt = new WidgetTextParams("HAIL KEY"); //ENTER, AFTER enableHailTxPT == YES
            hailKeyPt.AddParam("00");
            var enableSsbScan = new WidgetTextParams("ENABLE SSB SCAN");
            enableSsbScan.AddParam("NO").AddParam("YES");
            var maximumBandwidth = new WidgetTextParams("MAXIMUM BANDWIDTH");
            maximumBandwidth.AddParam("3 KHZ").AddParam("24 KHZ").AddParam("21 KHZ").AddParam("18 KHZ").AddParam("15 KHZ").AddParam("12 KHZ").AddParam("9 KHZ").AddParam("6 KHZ");

            var radioParams = new List<WidgetTextParams>
            {
                channelNumberTp,
                rxFrequencyPt,
                txFrequencyPt,
                modulationPt,
                rxOnlyPt,
                enableHailTxPt,
                hailKeyPt,
                enableSsbScan,
                maximumBandwidth
            };

            programMenu.AddActionToParam(programMenu.GetParam("KeyValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                if (titleParam.Text != "CHANNEL NUMBER"
                && titleParam.Text != "RX FREQUENCY"
                && titleParam.Text != "TX FREQUENCY"
                && titleParam.Text != "HAIL KEY")
                {
                    var paramTitle = titleParam.Text;

                    activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetPrevParam();
                    activeParam.ActiveTo = activeParam.Text.Length;

                    activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                    titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                activeParam.Action("9");
            }));

            programMenu.AddActionToParam(programMenu.GetParam("KeyValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");


                if (titleParam.Text != "CHANNEL NUMBER"
                && titleParam.Text != "RX FREQUENCY"
                && titleParam.Text != "TX FREQUENCY"
                && titleParam.Text != "HAIL KEY")
                {

                    var paramTitle = titleParam.Text;

                    activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetNextParam();
                    activeParam.ActiveTo = activeParam.Text.Length;

                    activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                    titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                activeParam.Action("6");
            }));

            programMenu.AddActionToParam(programMenu.GetParam("KeyValue"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");


                if (titleParam.Text != "CHANNEL NUMBER"
                && titleParam.Text != "RX FREQUENCY"
                && titleParam.Text != "TX FREQUENCY"
                && titleParam.Text != "HAIL KEY")
                {
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                    return;
                }

                if (activeParam.IsInParam())
                {
                    if (activeParam.ActiveFrom <= 0)
                    {
                        return;
                    }
                    activeParam.ActiveFrom -= 1;
                    if (!Char.IsDigit(activeParam.GetActiveText()[0]))
                    {
                        activeParam.ActiveFrom -= 1;
                    }
                }
            }));

            programMenu.AddActionToParam(programMenu.GetParam("KeyValue"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");



                if (titleParam.Text != "CHANNEL NUMBER"
                && titleParam.Text != "RX FREQUENCY"
                && titleParam.Text != "TX FREQUENCY"
                && titleParam.Text != "HAIL KEY")
                {
                    return;
                }


                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                    return;
                }

                if (activeParam.IsInParam())
                {
                    activeParam.ActiveFrom += 1;

                    if (titleParam.Text == "RX FREQUENCY" || titleParam.Text == "TX FREQUENCY")
                    {
                        if (!Char.IsDigit(activeParam.GetActiveText()[0]))
                        {
                            activeParam.ActiveFrom += 1;
                        }
                        if (activeParam.ActiveFrom > activeParam.Text.Length - 5)
                        {
                            activeParam.ActiveFrom = activeParam.Text.Length - 5;
                        }
                    }
                    else if (activeParam.ActiveFrom > activeParam.Text.Length - 1)
                    {
                        activeParam.ActiveFrom = activeParam.Text.Length - 1;
                    }
                }
            }));

            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("CALL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                if (titleParam.Text != "CHANNEL NUMBER"
                && titleParam.Text != "RX FREQUENCY"
                && titleParam.Text != "TX FREQUENCY"
                && titleParam.Text != "HAIL KEY")
                {
                    return;
                }


                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                activeParam.Action("1");

            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("LT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                if (titleParam.Text != "CHANNEL NUMBER"
                && titleParam.Text != "RX FREQUENCY"
                && titleParam.Text != "TX FREQUENCY"
                && titleParam.Text != "HAIL KEY")
                {
                    return;
                }


                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                activeParam.Action("2");

            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("MODE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                if (titleParam.Text != "CHANNEL NUMBER"
                && titleParam.Text != "RX FREQUENCY"
                && titleParam.Text != "TX FREQUENCY"
                && titleParam.Text != "HAIL KEY")
                {
                    return;
                }


                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                activeParam.Action("3");

            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("SQL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                if (titleParam.Text != "CHANNEL NUMBER"
                && titleParam.Text != "RX FREQUENCY"
                && titleParam.Text != "TX FREQUENCY"
                && titleParam.Text != "HAIL KEY")
                {
                    return;
                }


                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                activeParam.Action("4");


            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("ZERO", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                if (titleParam.Text != "CHANNEL NUMBER"
                && titleParam.Text != "RX FREQUENCY"
                && titleParam.Text != "TX FREQUENCY"
                && titleParam.Text != "HAIL KEY")
                {
                    return;
                }


                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                activeParam.Action("5");


            }));

            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("OPT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                if (titleParam.Text != "CHANNEL NUMBER"
                && titleParam.Text != "RX FREQUENCY"
                && titleParam.Text != "TX FREQUENCY"
                && titleParam.Text != "HAIL KEY")
                {
                    return;
                }


                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                activeParam.Action("7");


            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("PGM", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                if (titleParam.Text != "CHANNEL NUMBER"
                && titleParam.Text != "RX FREQUENCY"
                && titleParam.Text != "TX FREQUENCY"
                && titleParam.Text != "HAIL KEY")
                {
                    return;
                }


                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                activeParam.Action("8");


            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("UPDATE", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                if (titleParam.Text != "CHANNEL NUMBER"
                && titleParam.Text != "RX FREQUENCY"
                && titleParam.Text != "TX FREQUENCY"
                && titleParam.Text != "HAIL KEY")
                {
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                activeParam.Action("0");


            }));

            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                var paramTitle = titleParam.Text;

                if (titleParam.Text == "CHANNEL NUMBER"
                    || titleParam.Text == "RX FREQUENCY"
                    || titleParam.Text == "TX FREQUENCY"
                    || titleParam.Text == "HAIL KEY")
                {
                    var currParam = radioParams.Find(p => p.Name == paramTitle);
                    currParam.Parameters[currParam.CurrIndex] = activeParam.Text;
                }

                var nextIndex = radioParams.IndexOf(radioParams.Find(p => p.Name == paramTitle)) + 1;
                if (nextIndex < radioParams.Count)
                {
                    titleParam.Text = radioParams[nextIndex].Name;
                    activeParam.Text = radioParams[nextIndex].CurrParam();
                }
                else
                {
                    titleParam.Text = radioParams[0].Name;
                    activeParam.Text = radioParams[0].CurrParam();
                }

                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.ActiveFrom = 0;

                if (titleParam.Text == "CHANNEL NUMBER")
                {
                    programMenu.GetParam("KeyTitleCont").IsVisible = true;

                    StationChannel channel = new StationChannel
                    {
                        enableSsbScan = enableSsbScan.CurrParam() == "YES",
                        hailKey = hailKeyPt.CurrParam(),
                        maxBandwidth = maximumBandwidth.CurrParam(),
                        mode = rxOnlyPt.CurrParam() == "YES",
                        modulation = modulationPt.CurrParam(),
                        number = channelNumberTp.CurrParam(),
                        rxFrequency = rxFrequencyPt.CurrParam(),
                        txFrequency = txFrequencyPt.CurrParam()
                    };

                    var protoChannels = WpfHarris78.Src.Checker.LessonParametersHolder.Holder.Parameters.Program.Mode.Preset.Channels;
                    foreach(var item in protoChannels)
                    {
                        if (item.Num == channel.number) protoChannels.Remove(item);
                    }
                    protoChannels.Add(channel.SerializeToProtobuf());
                }
                else
                {
                    programMenu.GetParam("KeyTitleCont").IsVisible = false;
                }

                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();

                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                activeParam.Text = radioParams[0].CurrParam();
                titleParam.Text = radioParams[0].Name;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            return programMenu;
        }
        public static Widget InitProgramModePresetModemMenu(RadioStation station)
        {

            var programMenu = new Widget(GetNameMenu(MenuNames.ProgramModePresetModemMenu));

            programMenu.LineSize[0] = 7;
            programMenu.LineSize[1] = 11.5;
            programMenu.LineSize[2] = 11.5;
            programMenu.LineSize[3] = 7;
            programMenu.LineCharOffset[0] = 6;
            programMenu.LineCharOffset[1] = 6;
            programMenu.LineCharOffset[2] = 7;
            programMenu.LineCharOffset[3] = 6;
            programMenu.AddParam(new Param("Body", null, "", 1, 0));
            programMenu.AddParam(new Param("Title", null, "PGM-MODE-PRESET-MODEM-", 1, 0));
            programMenu.AddParam(new Param("KeyTitle", null, "MODEM PRESET", 2, 10));
            programMenu.AddParam(new Param("KeyTitleCont", null, "TO CHANGE:", 3, 0));
            programMenu.AddParam(new Param("KeyValue", (string text, Param cParam) =>
            {
                cParam.text = cParam.Text.Remove(cParam.ActiveFrom, cParam.ActiveTo);
                cParam.text = cParam.Text.Insert(cParam.ActiveFrom, text);

            }, "MDM01", 3, 10));
            programMenu.AddParam(new Param("Info", null, "ENT TO SAVE - CLR TO EXIT", 4, 15));

            programMenu.GetParam("KeyValue").IsActive = true;
            programMenu.GetParam("KeyValue").Y = Helper.CalcCenterIndent(programMenu.GetParam("KeyValue").Text.Length, 25);
            programMenu.GetParam("KeyTitle").Y = Helper.CalcCenterIndent(programMenu.GetParam("KeyTitle").Text.Length, 25);

            var modemNumTp = new WidgetTextParams("MODEM PRESET");
            for (var i = 1; i <= 20; i++)
            {
                var numStr = i < 10 ? "0" + i : i.ToString();
                modemNumTp.AddParam("MDM" + numStr);
            }

            var presetNameTp = new WidgetTextParams("PRESET NAME");
            presetNameTp.AddParam("");
            var modemTypeTp = new WidgetTextParams("MODEM TYPE");
            modemTypeTp
                .AddParam("MIL110B").AddParam("WBHF").AddParam("ARQ").AddParam("XDL")
                .AddParam("WBFSK").AddParam("STANAG-4285-U").AddParam("STANAG-4285-C").AddParam("SERIAL");
            var dataRateTp = new WidgetTextParams("DATA RATE");
            dataRateTp.AddParam("600").AddParam("300").AddParam("150").AddParam("75").AddParam("4800")
                      .AddParam("2400").AddParam("1200");
            var modeTp = new WidgetTextParams("MODE");
            modeTp.AddParam("SYNC").AddParam("ASYNC");
            var dataBitsTp = new WidgetTextParams("DATA BITS");
            dataBitsTp.AddParam("7").AddParam("8");
            var stopBitsTp = new WidgetTextParams("STOP BITS");
            stopBitsTp.AddParam("1").AddParam("2");
            var parityTp = new WidgetTextParams("PARITY");
            parityTp.AddParam("EVEN").AddParam("NONE").AddParam("SPACE").AddParam("MARK").AddParam("ODD");
            var enableTp = new WidgetTextParams("ENABLE");
            enableTp.AddParam("NO").AddParam("YES");


            var radioParams = new List<WidgetTextParams>
            {
                modemNumTp,
                presetNameTp,
                modemTypeTp,
                dataRateTp,
                modeTp,
                dataBitsTp,
                stopBitsTp,
                parityTp,
                enableTp
            };

            var oldPresetName = "MDM01";

            programMenu.AddActionToParam(programMenu.GetParam("KeyValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                if (titleParam.Text != "PRESET NAME")
                {
                    var paramTitle = titleParam.Text;

                    activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetPrevParam();
                    activeParam.ActiveTo = activeParam.Text.Length;
                    activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                    titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "9YZ?";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);
            }));

            programMenu.AddActionToParam(programMenu.GetParam("KeyValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");


                if (titleParam.Text != "PRESET NAME")
                {

                    var paramTitle = titleParam.Text;

                    activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetNextParam();
                    activeParam.ActiveTo = activeParam.Text.Length;
                    activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                    titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "6PQR";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);
            }));

            programMenu.AddActionToParam(programMenu.GetParam("KeyValue"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");


                if (activeParam == null || titleParam.Text != "PRESET NAME")
                {
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                    return;
                }

                if (activeParam.IsInParam())
                {
                    if (activeParam.ActiveFrom <= 0)
                    {
                        return;
                    }
                    activeParam.ActiveFrom -= 1;
                }
            }));

            programMenu.AddActionToParam(programMenu.GetParam("KeyValue"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");



                if (activeParam == null || titleParam.Text != "PRESET NAME")
                {
                    return;
                }


                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                    return;
                }

                if (activeParam.IsInParam())
                {
                    activeParam.ActiveFrom += 1;

                    if (activeParam.ActiveFrom > activeParam.Text.Length - 1)
                    {
                        activeParam.ActiveFrom = activeParam.Text.Length - 1;
                    }
                }
            }));

            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("CALL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                if (activeParam == null || titleParam.Text != "PRESET NAME")
                {
                    return;
                }


                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "1ABC";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("LT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                if (activeParam == null || titleParam.Text != "PRESET NAME")
                {
                    return;
                }


                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "2DEF";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("MODE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                if (activeParam == null || titleParam.Text != "PRESET NAME")
                {
                    return;
                }


                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "3GHI";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("SQL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                if (activeParam == null || titleParam.Text != "PRESET NAME")
                {
                    return;
                }


                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "4JKL";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);


            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("ZERO", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                if (activeParam == null || titleParam.Text != "PRESET NAME")
                {
                    return;
                }


                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "5MNO";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);


            }));

            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("OPT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                if (activeParam == null || titleParam.Text != "PRESET NAME")
                {
                    return;
                }


                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "7STU";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);


            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("PGM", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                if (activeParam == null || titleParam.Text != "PRESET NAME")
                {
                    return;
                }


                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                var symbols = "8VWX";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);


            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("UPDATE", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                if (activeParam == null || titleParam.Text != "PRESET NAME")
                {
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                activeParam.Action("0");


            }));

            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                var paramTitle = titleParam.Text;

                if (titleParam.Text == "PRESET NAME")
                {
                    var currParam = radioParams.Find(p => p.Name == paramTitle);
                    currParam.Parameters[currParam.CurrIndex] = activeParam.Text;
                }

                if (titleParam.Text == "MODEM PRESET")
                {
                    var currParam = radioParams.Find(p => p.Name == "PRESET NAME");
                    currParam.Parameters[0] = activeParam.Text;
                    oldPresetName = activeParam.Text;
                }

                if (titleParam.Text == "ENABLE")
                {
                    var presetNameParam = radioParams.Find(p => p.Name == "MODEM PRESET");
                    presetNameParam.Parameters[presetNameParam.CurrIndex] = radioParams.Find(p => p.Name == "PRESET NAME").CurrParam();
                    var newModem = StationPresetModemModule.Parse(radioParams);

                    newModem = station.UpdatePresetModem(newModem, oldPresetName);

                    var protobufModems = WpfHarris78.Src.Checker.LessonParametersHolder.Holder.Parameters.Program.Mode.Preset.Modems;
                    foreach( var item in protobufModems)
                    {
                        if (item.OriginalName == newModem.originalName) 
                        { 
                            protobufModems.Remove(item);
                            break;
                        }
                    }
                    protobufModems.Add(newModem.SerializeToProtobuf());
                }

                var nextIndex = radioParams.IndexOf(radioParams.Find(p => p.Name == paramTitle)) + 1;
                if (nextIndex < radioParams.Count)
                {
                    titleParam.Text = radioParams[nextIndex].Name;
                    activeParam.Text = radioParams[nextIndex].CurrParam();
                }
                else
                {
                    titleParam.Text = radioParams[0].Name;
                    activeParam.Text = radioParams[0].CurrParam();
                }

                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.ActiveFrom = 0;

                if (titleParam.Text == "MODEM PRESET")
                {
                    programMenu.GetParam("KeyTitleCont").IsVisible = true;
                }
                else
                {
                    programMenu.GetParam("KeyTitleCont").IsVisible = false;
                }
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();

                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                activeParam.Text = presetNameTp.CurrParam();
                titleParam.Text = presetNameTp.Name;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            return programMenu;
        }

        public static Widget InitProgramModePresetSystemMenu(RadioStation station)
        {

            var programMenu = new Widget(GetNameMenu(MenuNames.ProgramModePresetSystemMenu));

            programMenu.LineSize[0] = 7;
            programMenu.LineSize[1] = 11.5;
            programMenu.LineSize[2] = 11.5;
            programMenu.LineSize[3] = 7;
            programMenu.LineCharOffset[0] = 6;
            programMenu.LineCharOffset[1] = 6;
            programMenu.LineCharOffset[2] = 7;
            programMenu.LineCharOffset[3] = 6;
            programMenu.AddParam(new Param("Body", null, "", 1, 0));
            programMenu.AddParam(new Param("Title", null, "PGM-MODE-PRESET-SYSTEM-", 1, 0));
            programMenu.AddParam(new Param("KeyTitle", null, "SYSTEM PRESET", 2, 10));
            programMenu.AddParam(new Param("KeyTitleCont", null, "TO CHANGE:", 3, 0));
            programMenu.AddParam(new Param("KeyValue", (string text, Param cParam) =>
            {
                cParam.text = cParam.Text.Remove(cParam.ActiveFrom, cParam.ActiveTo);
                cParam.text = cParam.Text.Insert(cParam.ActiveFrom, text);

            }, "SYSPRE01", 3, 10));
            programMenu.AddParam(new Param("Info", null, "ENT TO SAVE - CLR TO EXIT", 4, 10));

            programMenu.GetParam("KeyValue").IsActive = true;

            var modemNumTp = new WidgetTextParams("SYSTEM PRESET");
            for (var i = 1; i <= 75; i++)
            {
                var numStr = i < 10 ? "0" + i : i.ToString();
                modemNumTp.AddParam("SYSPRE" + numStr);
            }

            var presetNameTp = new WidgetTextParams("PRESET NAME"); //ENTER
            presetNameTp.AddParam("");
            var radioModeTp = new WidgetTextParams("RADIO MODE");
            radioModeTp.AddParam("FIX").AddParam("3G").AddParam("ALE").AddParam("HOP");
            var channelNumberTp = new WidgetTextParams("CHANNEL NUMBER"); //ENTER
            channelNumberTp.AddParam("000");
            var modemPreset = new WidgetTextParams("MODEM PRESET");
            modemPreset.AddParam("OFF");
            var encryptionType = new WidgetTextParams("ENCRYPTION TYPE");
            encryptionType.AddParam("CITADEL").AddParam("AES-256").AddParam("AES-128");
            var encryptionKeyTp = new WidgetTextParams("ENCRYPTION KEY"); //TO DO
            encryptionKeyTp.AddParam("-------------------");
            var ptVoiceModeTp = new WidgetTextParams("PT VOICE MODE");
            ptVoiceModeTp.AddParam("CVSD").AddParam("CLR").AddParam("NONE").AddParam("LDV").AddParam("ME24")
                .AddParam("ME12").AddParam("ME6").AddParam("DV24").AddParam("DV6").AddParam("AVS");
            var ctVoiceModeTp = new WidgetTextParams("CT VOICE MODE");
            ctVoiceModeTp.AddParam("NONE").AddParam("LDV").AddParam("ME24")
                .AddParam("ME12").AddParam("ME6").AddParam("DV24").AddParam("DV6");
            var enableTp = new WidgetTextParams("ENABLE");
            enableTp.AddParam("YES").AddParam("NO");

            programMenu.GetParam("KeyTitle").Y = Helper.CalcCenterIndent(programMenu.GetParam("KeyTitle").Text.Length, 25);

            var radioParams = new List<WidgetTextParams>
            {
                modemNumTp,
                presetNameTp,
                radioModeTp,
                channelNumberTp,
                modemPreset,
                encryptionType,
                encryptionKeyTp,
                ptVoiceModeTp,
                ctVoiceModeTp,
                enableTp
            };

            var oldPresetName = "SYSPRE01";

            programMenu.AddActionToParam(programMenu.GetParam("KeyValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                if (titleParam.Text != "PRESET NAME" && titleParam.Text != "CHANNEL NUMBER")
                {
                    var paramTitle = titleParam.Text;

                    activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetPrevParam();
                    activeParam.ActiveTo = activeParam.Text.Length;
                    activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                    titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (titleParam.Text == "CHANNEL NUMBER")
                {
                    activeParam.Action("9");
                    return;
                }

                var symbols = "9YZ?";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);
            }));

            programMenu.AddActionToParam(programMenu.GetParam("KeyValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");


                if (titleParam.Text != "PRESET NAME" && titleParam.Text != "CHANNEL NUMBER")
                {

                    var paramTitle = titleParam.Text;

                    activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetNextParam();
                    activeParam.ActiveTo = activeParam.Text.Length;
                    activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                    titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                if (titleParam.Text == "CHANNEL NUMBER")
                {
                    activeParam.Action("6");
                    return;
                }

                var symbols = "6PQR";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);
            }));

            programMenu.AddActionToParam(programMenu.GetParam("KeyValue"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");


                if (activeParam == null || (titleParam.Text != "PRESET NAME" && titleParam.Text != "CHANNEL NUMBER"))
                {
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                    return;
                }

                if (activeParam.IsInParam())
                {
                    if (activeParam.ActiveFrom <= 0)
                    {
                        return;
                    }
                    activeParam.ActiveFrom -= 1;
                }
            }));

            programMenu.AddActionToParam(programMenu.GetParam("KeyValue"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");



                if (activeParam == null
                || (titleParam.Text != "PRESET NAME" && titleParam.Text != "CHANNEL NUMBER"))
                {
                    return;
                }


                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                    return;
                }

                if (activeParam.IsInParam())
                {
                    activeParam.ActiveFrom += 1;

                    if (activeParam.ActiveFrom > activeParam.Text.Length - 1)
                    {
                        activeParam.ActiveFrom = activeParam.Text.Length - 1;
                    }
                }
            }));

            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("CALL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                if (activeParam == null || (titleParam.Text != "PRESET NAME" && titleParam.Text != "CHANNEL NUMBER"))
                {
                    return;
                }


                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                if (titleParam.Text == "CHANNEL NUMBER")
                {
                    activeParam.Action("1");
                    return;
                }

                var symbols = "1ABC";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("LT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                if (activeParam == null || (titleParam.Text != "PRESET NAME" && titleParam.Text != "CHANNEL NUMBER"))
                {
                    return;
                }


                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                if (titleParam.Text == "CHANNEL NUMBER")
                {
                    activeParam.Action("2");
                    return;
                }

                var symbols = "2DEF";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("MODE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                if (activeParam == null || (titleParam.Text != "PRESET NAME" && titleParam.Text != "CHANNEL NUMBER"))
                {
                    return;
                }


                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                if (titleParam.Text == "CHANNEL NUMBER")
                {
                    activeParam.Action("3");
                    return;
                }

                var symbols = "3GHI";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);

            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("SQL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                if (activeParam == null || (titleParam.Text != "PRESET NAME" && titleParam.Text != "CHANNEL NUMBER"))
                {
                    return;
                }


                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                if (titleParam.Text == "CHANNEL NUMBER")
                {
                    activeParam.Action("4");
                    return;
                }

                var symbols = "4JKL";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);


            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("ZERO", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                if (activeParam == null || (titleParam.Text != "PRESET NAME" && titleParam.Text != "CHANNEL NUMBER"))
                {
                    return;
                }


                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                if (titleParam.Text == "CHANNEL NUMBER")
                {
                    activeParam.Action("5");
                    return;
                }

                var symbols = "5MNO";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);


            }));

            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("OPT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                if (activeParam == null || (titleParam.Text != "PRESET NAME" && titleParam.Text != "CHANNEL NUMBER"))
                {
                    return;
                }


                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                if (titleParam.Text == "CHANNEL NUMBER")
                {
                    activeParam.Action("7");
                    return;
                }

                var symbols = "7STU";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);


            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("PGM", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                if (activeParam == null || (titleParam.Text != "PRESET NAME" && titleParam.Text != "CHANNEL NUMBER"))
                {
                    return;
                }


                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                if (titleParam.Text == "CHANNEL NUMBER")
                {
                    activeParam.Action("8");
                    return;
                }

                var symbols = "8VWX";
                var currentSymbol = activeParam.GetActiveText();
                var index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                var nextSymbol = symbols.Substring(index, 1);
                activeParam.Action(nextSymbol);


            }));
            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("UPDATE", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                if (activeParam == null || (titleParam.Text != "PRESET NAME" && titleParam.Text != "CHANNEL NUMBER"))
                {
                    return;
                }

                if (!activeParam.IsInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                activeParam.Action("0");


            }));

            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                var paramTitle = titleParam.Text;

                if (titleParam.Text == "PRESET NAME")
                {
                    var currParam = radioParams.Find(p => p.Name == paramTitle);
                    currParam.Parameters[currParam.CurrIndex] = activeParam.Text;
                }

                if (titleParam.Text == "SYSTEM PRESET")
                {
                    var currParam = radioParams.Find(p => p.Name == "PRESET NAME");
                    currParam.Parameters[0] = activeParam.Text;
                    oldPresetName = activeParam.Text;
                }

                if (titleParam.Text == "ENABLE")
                {
                    var presetNameParam = radioParams.Find(p => p.Name == "SYSTEM PRESET");
                    presetNameParam.Parameters[presetNameParam.CurrIndex] = radioParams.Find(p => p.Name == "PRESET NAME").CurrParam();
                    var newStationPreset = station.AddPresetSystem(radioParams, oldPresetName);
                    var protoSystems = WpfHarris78.Src.Checker.LessonParametersHolder.Holder.Parameters.Program.Mode.Preset.Systems;
                    foreach(var sys in protoSystems.ToArray())
                    {
                        if (sys.Name == newStationPreset.name)
                        {
                            protoSystems.Remove(sys);
                            break;
                        }
                    }
                    protoSystems.Add(newStationPreset.SerializeToProtobuf());
                }

                if (titleParam.Text == "ENCRYPTION TYPE")
                {
                    var nextParam = radioParams.Find(p => p.Name == "ENCRYPTION KEY");
                    nextParam.Clear();
                    nextParam.AddParam("-------------------");
                    var type = KeyModule.StringToType(activeParam.Text);
                    foreach (var key in station.Keys.Keys[type])
                    {
                        nextParam.AddParam(key.keyName);
                    }
                }

                var nextIndex = radioParams.IndexOf(radioParams.Find(p => p.Name == paramTitle)) + 1;
                if (nextIndex < radioParams.Count)
                {
                    titleParam.Text = radioParams[nextIndex].Name;
                    activeParam.Text = radioParams[nextIndex].CurrParam();
                }
                else
                {
                    titleParam.Text = radioParams[0].Name;
                    activeParam.Text = radioParams[0].CurrParam();
                }

                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.ActiveFrom = 0;

                if (titleParam.Text == "MODEM PRESET")
                {
                    programMenu.GetParam("KeyTitleCont").IsVisible = true;
                    modemPreset.Clear();
                    modemPreset.AddParam("OFF");
                    foreach (var modem in station.PresetModems)
                    {
                        modemPreset.AddParam(modem.name);
                    }
                }
                else
                {
                    programMenu.GetParam("KeyTitleCont").IsVisible = false;
                }

                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            programMenu.AddActionToParam(programMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();

                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("KeyTitle");

                activeParam.Text = presetNameTp.CurrParam();
                titleParam.Text = presetNameTp.Name;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = 10; 
                programMenu.GetParam("KeyTitleCont").IsVisible = true;
            }));

            return programMenu;
        }

        public static Widget InitProgramModeAleMenu(RadioStation station)
        {

            var optionMenu = new Widget(GetNameMenu(MenuNames.ProgramModeAleMenu));
            optionMenu.LineSize[0] = 7;
            //optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 11.5;
            optionMenu.LineCharOffset[0] = 6;
            //optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "PGM-MODE-ALE", 1, 0));
            optionMenu.AddParam(new Param("EmptyLine", null, " ", 2, 0));
            optionMenu.AddParam(new Param("Chan_group", null, "CHAN_GROUP", 3, 0));
            optionMenu.AddParam(new Param("Address", null, "ADDRESS", 3, 15));
            optionMenu.AddParam(new Param("Config", null, "CONFIG", 4, 0));
            optionMenu.AddParam(new Param("Lqa", null, "LQA", 4, 10));
            optionMenu.AddParam(new Param("Amd", null, "AMD", 4, 15));
            optionMenu.GetParam("Chan_group").IsActive = true;

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Amd");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Chan_group":
                        {
                            var param = wdg.GetParam("Amd");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Address":
                        {
                            var param = wdg.GetParam("Chan_group");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Config":
                        {
                            var param = wdg.GetParam("Address");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Lqa":
                        {
                            var param = wdg.GetParam("Config");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Amd":
                        {
                            var param = wdg.GetParam("Lqa");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Chan_group");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Chan_group":
                        {
                            var param = wdg.GetParam("Address");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Address":
                        {
                            var param = wdg.GetParam("Config");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Config":
                        {
                            var param = wdg.GetParam("Lqa");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Lqa":
                        {
                            var param = wdg.GetParam("Amd");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Amd":
                        {
                            var param = wdg.GetParam("Address");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Amd"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();

                if (activeParam == null || activeParam.Name != "Amd")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.ProgramModeAleAmdMenu));

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));
            return optionMenu;
        }
        public static Widget InitProgramModeAleAmdMenu(RadioStation station)
        {

            var optionMenu = new Widget(GetNameMenu(MenuNames.ProgramModeAleAmdMenu));
            optionMenu.LineSize[0] = 7;
            //optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 11.5;
            optionMenu.LineCharOffset[0] = 6;
            //optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "PGM-MODE-ALE-AMD", 1, 0));
            optionMenu.AddParam(new Param("EmptyLine", null, " ", 2, 0));
            optionMenu.AddParam(new Param("Tx_msg", null, "TX_MSG", 3, 0));
            optionMenu.AddParam(new Param("Rx_msg", null, "RX_MSG", 3, 15));
            optionMenu.GetParam("Tx_msg").IsActive = true;

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Rx_msg");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Tx_msg":
                        {
                            var param = wdg.GetParam("Rx_msg");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Rx_msg":
                        {
                            var param = wdg.GetParam("Tx_msg");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();

                if (activeParam == null)
                {
                    var param = wdg.GetParam("Tx_msg");
                    wdg.DeactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Tx_msg":
                        {
                            var param = wdg.GetParam("Rx_msg");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Rx_msg":
                        {
                            var param = wdg.GetParam("Tx_msg");
                            wdg.DeactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Tx_msg"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.ActiveParam();

                if (activeParam == null || activeParam.Name != "Tx_msg")
                {
                    return;
                }

                wdg.PrepareToShowWidget(GetNameMenu(MenuNames.ProgramModeAleAmdTxMsgMenu));

            }));
            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));
            return optionMenu;
        }

        public static Widget InitProgramModeAleAmdTxMsgMenu(RadioStation station)
        {
            var optionMenu = new Widget(GetNameMenu(MenuNames.ProgramModeAleAmdTxMsgMenu));

            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 11.5;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "PGM-MODE-ALE-AMD-TX_MSG", 1, 0));
            optionMenu.AddParam(new Param("SmsTitle", null, "TX_MESSAGE", 2, 7));
            optionMenu.AddParam(new Param("SmsValue", null, "EDIT", 3, 12));
            optionMenu.AddParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL", 4, 12));

            optionMenu.GetParam("SmsValue").IsActive = true;
            optionMenu.GetParam("SmsValue").Y = Helper.CalcCenterIndent(optionMenu.GetParam("SmsValue").Text.Length, 25);
            optionMenu.GetParam("SmsTitle").Y = Helper.CalcCenterIndent(optionMenu.GetParam("SmsTitle").Text.Length, 25);

            var smsFunctions = new WidgetTextParams("TX_MESSAGE");
            smsFunctions.AddParam("EDIT").AddParam("REVIEW").AddParam("DELETE");

            var radioParams = new List<WidgetTextParams> {smsFunctions};


            optionMenu.AddActionToParam(optionMenu.GetParam("SmsValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("SmsTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("SmsValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("SmsTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();

                switch (activeParam.Text)
                {
                    case "EDIT":
                        {
                            MainWindow.currObject.QueueWidget.Add(InitProgramModeAleAmdTxMsgSelectMenu(station, true, false, clr: () =>
                            {
                                MainWindow.currObject.QueueWidget.Add(optionMenu);
                                MainWindow.currObject.StartShowWidgetQueue();
                            }));
                            MainWindow.currObject.StartShowWidgetQueue();
                            break;
                        }
                    case "DELETE":
                        {
                            MainWindow.currObject.QueueWidget.Add(InitProgramModeAleAmdTxMsgSelectMenu(station, false, true, clr: () =>
                            {
                                MainWindow.currObject.QueueWidget.Add(optionMenu);
                                MainWindow.currObject.StartShowWidgetQueue();
                            }));
                            MainWindow.currObject.StartShowWidgetQueue();
                            break;
                        }
                }
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.ShowPreviousWidget();
            }));

            return optionMenu;
        }
        public static Widget InitProgramModeAleAmdTxMsgSelectMenu(RadioStation station, bool edit = false, bool remove = false, Action clr = null)
        {
            var optionMenu = new Widget("initProgramModeAleAmdTxMsgSelectMenu");

            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "PGM-MODE-ALE-AMD-TX_MSG", 1, 0));
            optionMenu.AddParam(new Param("TitleNumberMessage", null, "", 1, 25, () =>
            {
                var tnm = optionMenu.GetParam("TitleNumberMessage");
                tnm.Text = "EDIT " + station.TxMsgs.CurrMsg().number;
            }));
            optionMenu.AddParam(new Param("SmsTitle", null, "TX MESSAGE:", 2, 7));
            optionMenu.AddParam(new Param("SmsValue", null, "", 3, 0, () =>
            {
                var smsVal = optionMenu.GetParam("SmsValue");
                var defLenghtEmptyMsg = TxMsg.emptyMsg.Length;
                var currMsg = station.TxMsgs.CurrMsg();
                if (currMsg.msg.Length < defLenghtEmptyMsg)
                {
                    smsVal.Text = currMsg.msg;
                }
                else
                {
                    smsVal.Text = currMsg.msg.Substring(0, defLenghtEmptyMsg - 1);
                }
            }));
            optionMenu.AddParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL / ENT TO CONT", 4, 10));

            optionMenu.GetParam("SmsValue").IsActive = true;


            optionMenu.AddActionToParam(optionMenu.GetParam("SmsValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                station.TxMsgs.NextMsg();
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("SmsValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                station.TxMsgs.PrevMsg();
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                void ClrAction()
                {
                    MainWindow.currObject.QueueWidget.Add(optionMenu);
                    MainWindow.currObject.StartShowWidgetQueue();
                }


                if (edit)
                {
                    var editMessageView = EnterMsg("PGM-MODE-ALE-AMD-TX_MSG-", "ENT TO SAVE - CLR TO EXIT",
                    clr: ClrAction,
                    ent: (string newMsg) =>
                    {
                        station.TxMsgs.CurrMsg().msg = newMsg;
                        ClrAction();
                    });

                    MainWindow.currObject.QueueWidget.Add(editMessageView);
                    MainWindow.currObject.StartShowWidgetQueue();
                }

                if (remove)
                {
                    MainWindow.currObject.QueueWidget.Add(DialogMenu("PGM-MODE-ALE-AMD-TX_MSG-", "TX MESSAGE:",
                        clr: ClrAction,
                        ifYes: () =>
                        {
                            station.TxMsgs.CurrMsg().msg = TxMsg.emptyMsg;
                            ClrAction();
                        },
                        ifNo: () =>
                        {
                            ClrAction();
                        }));
                    MainWindow.currObject.StartShowWidgetQueue();
                }
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                clr?.Invoke();
            }));

            return optionMenu;
        }

        public static Widget InitOptionAleTxMsgSendingMenu(RadioStation station, Action clr = null)
        {
            var optionMenu = new Widget("initOptionAleTxMsgSendingMenu");

            optionMenu.LineSize[0] = 7;
            optionMenu.LineSize[1] = 11.5;
            optionMenu.LineSize[2] = 11.5;
            optionMenu.LineSize[3] = 7;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.AddParam(new Param("Body", null, "", 1, 0));
            optionMenu.AddParam(new Param("Title", null, "PGM-MODE-ALE-AMD-TX_MSG", 1, 0));
            optionMenu.AddParam(new Param("SmsTitle", null, "CALL TYPE", 2, 7));
            optionMenu.AddParam(new Param("SmsValue", null, "AUTOMATIC", 3, 12));
            optionMenu.AddParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL", 4, 12));

            optionMenu.GetParam("SmsValue").IsActive = true;
            optionMenu.GetParam("SmsValue").Y = Helper.CalcCenterIndent(optionMenu.GetParam("SmsValue").Text.Length, 25);
            optionMenu.GetParam("SmsTitle").Y = Helper.CalcCenterIndent(optionMenu.GetParam("SmsTitle").Text.Length, 25);

            var callTypeTp = new WidgetTextParams("CALL TYPE");
            callTypeTp.AddParam("AUTOMATIC").AddParam("MANUAL");
            var addressTypeTp = new WidgetTextParams("ADDRESS TYPE");
            addressTypeTp.AddParam("INDIVIDUAL").AddParam("ALL").AddParam("ANY").AddParam("GROUP").AddParam("NET");
            var individualAddressTypeTp = new WidgetTextParams("INDIV ADDR");
            individualAddressTypeTp.AddParam("R2");

            var radioParams = new List<WidgetTextParams> {callTypeTp, addressTypeTp, individualAddressTypeTp};


            optionMenu.AddActionToParam(optionMenu.GetParam("SmsValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("SmsTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("SmsValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("SmsTitle");

                var paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).GetNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleP = wdg.GetParam("SmsTitle");

                var nextIndex = radioParams.IndexOf(radioParams.Find(p => p.Name == titleP.Text)) + 1;
                if (nextIndex < radioParams.Count)
                {
                    titleP.Text = radioParams[nextIndex].Name;
                    activeParam.Text = radioParams[nextIndex].CurrParam();
                }
                else
                {
                    titleP.Text = radioParams[0].Name;
                    activeParam.Text = radioParams[0].CurrParam();
                }

                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.ActiveFrom = 0;

                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleP.Y = Helper.CalcCenterIndent(titleP.Text.Length, 28);
            }));

            optionMenu.AddActionToParam(optionMenu.GetParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.ActiveParam();
                var titleParam = wdg.GetParam("SmsTitle");

                activeParam.Text = callTypeTp.CurrParam();
                titleParam.Text = callTypeTp.Name;
                activeParam.Y = Helper.CalcCenterIndent(activeParam.Text.Length, 25);
                titleParam.Y = Helper.CalcCenterIndent(titleParam.Text.Length, 25);

                clr?.Invoke();
            }));

            return optionMenu;
        }
    }

}
