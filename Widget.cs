using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using WpfHarris78;

namespace Harris7800HMP
{
    public class Param
    {
        private bool isActive = false;
        public string text;
        private int activeFrom;
        private int activeTo;
        private string name;
        private Action<string, Param> changeFunction;
        private Action updateFunction;
        private int x;
        private int y;
        private int fontSize = 6;
        private bool isVisible = true;

        public Param(string name, Action<string, Param> act, string text, int xX, int yY, Action update = null)
        {
            Name = name;
            changeFunction = act;
            this.text = text;
            X = xX;
            Y = yY;
            updateFunction = update;
        }
        public void Action(string text)
        {
            changeFunction?.Invoke(text, this);
        }
        public bool IsActive
        {
            get => isActive;
            set
            {
                isActive = value;
                activeFrom = 0;
                activeTo = text.Length;
            }
        }

        public string GetActiveText()
        {
            return text.Substring(activeFrom, activeTo);
        }
        public bool IsInParam()
        {
            return activeFrom != 0 || activeTo != text.Length;
        }
        public string Text
        {
            get => text;
            set
            {
                text = value;
                if (value != null)
                {
                    ActiveTo = value.Length;
                }
            }
        }
        public string Name { get => name; set => name = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int ActiveFrom { get => activeFrom; set => activeFrom = value; }
        public int ActiveTo { get => activeTo; set => activeTo = value; }
        public Action UpdateFunction { get => updateFunction; set => updateFunction = value; }
        public bool IsVisible { get => isVisible; set => isVisible = value; }

        public void SetLocation(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Update()
        {
            UpdateFunction?.Invoke();
        }

        public void FullActive()
        {
            ActiveTo = this.Text.Length;
            ActiveFrom = 0;
        }
    }
    public class Widget
    {
        private string name;
        private Dictionary<string, Widget> availableWidgets = new Dictionary<string, Widget>();
        public Widget comeFrom;
        public Widget moveTo;
        private List<Param> parameters = new List<Param>();
        private Dictionary<Param, List<Button>> paramsAction = new Dictionary<Param, List<Button>>();
        private int lineLenght = 50;
        private Dictionary<int, double> lineSize = new Dictionary<int, double> {
            {0, 6}, {1, 6}, {3, 6}, {2, 6}, {4, 6},
        };
        private Dictionary<int, int> lineCharOffset = new Dictionary<int, int> {
            {0, 2}, {1, 2}, {2, 2}, {3, 2}, {4, 2}
        };
        private Dictionary<Param, List<RadioStationMode>> awailableParamForMode = new Dictionary<Param, List<RadioStationMode>>();
        private Dictionary<string, Object> objectContainer = new Dictionary<string, Object>();
        public Widget(string name)
        {
            this.name = name;
        }
        public Widget ComeFrom { get => comeFrom; set => comeFrom = value; }
        public string Name { get => name; set => name = value; }
        public Widget MoveTo
        {
            get => moveTo; set
            {
                moveTo = value;

                if (moveTo != null)
                {
                    moveTo.ComeFrom = this;
                }
            }
        }

        public Dictionary<int, double> LineSize { get => lineSize; set => lineSize = value; }
        public Dictionary<int, int> LineCharOffset { get => lineCharOffset; set => lineCharOffset = value; }
        public Dictionary<string, object> ObjectContainer { get => objectContainer; set => objectContainer = value; }

        public Param ActiveParam()
        {
            return parameters.Find(param => param.IsActive);
        }

        public List<Param> GetActiveParamsBy(Func<Param, bool> selectFunc = null)
        {
            var @params = new List<Param>();

            foreach (var pr in parameters)
            {
                if (pr.IsActive)
                {
                    if (selectFunc != null && selectFunc(pr))
                    {
                        @params.Add(pr);
                    }
                    else if (selectFunc == null)
                    {
                        @params.Add(pr);
                    }
                }
            }

            return @params;
        }

        public void DeactiveParam()
        {
            parameters.ForEach(param => param.IsActive = false);
        }

        public void AddAvailableWidget(string name, Widget widget)
        {
            availableWidgets.Add(name, widget);
        }
        public Widget GetAvailableWidget(string name)
        {
            return availableWidgets[name];
        }

        public void PrepareToShowWidget(string name)
        {
            MoveTo = availableWidgets[name];
        }
        public Widget ShowPreviousWidget()
        {
            moveTo = comeFrom;
            moveTo.moveTo = null;
            comeFrom = null;
            return moveTo;
        }
        public Widget AddParam(Param param, bool addDefaultMode = true)
        {
            parameters.Add(param);
            if (addDefaultMode)
            {
                awailableParamForMode.Add(param, new List<RadioStationMode> { RadioStationMode.Fix });
            }
            else
            {
                awailableParamForMode.Add(param, new List<RadioStationMode>());
            }
            return this;
        }

        public Widget AddModeForParam(string paramName, RadioStationMode mode)
        {
            awailableParamForMode[GetParam(paramName)].Add(mode);
            return this;
        }

        public Widget AddModesForParam(string paramName, List<RadioStationMode> mode)
        {
            var modesByParam = awailableParamForMode[GetParam(paramName)];

            modesByParam.AddRange(mode);
            awailableParamForMode[GetParam(paramName)] = modesByParam.Distinct().ToList();

            return this;
        }

        public void AddActionToParam(Param param, Button btn)
        {
            if (paramsAction.ContainsKey(param))
            {
                paramsAction[param].Add(btn);
            }
            else
            {
                paramsAction.Add(param, new List<Button>() { btn });
            }
        }

        public List<Param> GetParamByMode(RadioStationMode mode)
        {
            var modeParams = new List<Param>();
            foreach (var pr in parameters)
            {
                if (awailableParamForMode[pr].Contains(mode))
                {
                    modeParams.Add(pr);
                }
            }
            return modeParams;
        }

        public void InvisibleParamsByNode(RadioStationMode mode)
        {
            var paramsByNode = GetParamByMode(mode);

            foreach (var pr in parameters)
            {
                if (!paramsByNode.Contains(pr))
                {
                    pr.IsVisible = false;
                }
            }
        }
        public void VisibleParamsByNode(RadioStationMode mode)
        {
            var paramsByNode = GetParamByMode(mode);

            foreach (var pr in parameters)
            {
                if (paramsByNode.Contains(pr))
                {
                    pr.IsVisible = true;
                }
            }
        }

        public void InvisibleAllParams()
        {
            foreach (var item in parameters)
            {
                item.IsVisible = false;
            }
        }

        private string InsertParamToLine(Param param, string line)
        {
            line = line.Remove(param.Y, param.Text.Length);
            return line.Insert(param.Y, param.Text);
        }

        public string[] ToLines()
        {
            var lineString = new Dictionary<int, string>();

            foreach (var param in parameters)
            {
                if (param.IsVisible == false)
                {
                    continue;
                }

                if (!lineString.ContainsKey(param.X))
                {
                    lineString.Add(param.X, new string(' ', lineLenght));
                }
                lineString[param.X] = InsertParamToLine(param, lineString[param.X]);
            }

            var result = new List<string>();

            foreach (var line in lineString.Keys)
            {
                result.Add(lineString[line]);
            }

            for (int i = 0; i<4; i++)
            {
                if (i > result.Count - 1)
                {
                    result.Add(new string(' ', lineLenght));
                }
            }

            return result.ToArray();
        }

        public override string ToString()
        {
            var result = "";

            var lineString = new Dictionary<int, string>();

            foreach (var param in parameters)
            {
                if (!lineString.ContainsKey(param.X))
                {
                    lineString.Add(param.X, new string(' ', lineLenght));
                }
                lineString[param.X] = InsertParamToLine(param, lineString[param.X]);
            }

            foreach (var line in lineString.Keys)
            {
                result += lineString[line] + "\n";
            }

            return result;
        }

        public Param GetParam(string name)
        {
            return parameters.Find(param => param.Name == name);
        }

        public void BtnClick(string name, RadioStation station)
        {
            Debug.WriteLine($"PRESSED BTN {name}");
            if (station.GetState() == SwitcherState.OFF)
            {
                return;
            }

            if (Name == WidgetInit.GetNameMenu(WidgetInit.MenuNames.MainMenu)
                && station.KeyBoardLock)
            {
                switch (name)
                {
                    case "CALL":
                        {
                            MainWindow.keyEntered += "1";
                            break;
                        }
                    case "MODE":
                        {
                            MainWindow.keyEntered += "3";
                            break;
                        }
                    case "OPT":
                        {
                            MainWindow.keyEntered += "7";
                            break;
                        }
                    case "DOWN":
                        {
                            MainWindow.keyEntered += "9";
                            station.KeyBoardLock = !MainWindow.keyEntered.Contains(MainWindow.keyNeed);
                            break;
                        }
                }
                if (station.KeyBoardLock)
                {
                    PrepareToShowWidget(WidgetInit.GetNameMenu(WidgetInit.MenuNames.KeyboardLock));
                    MainWindow.timerAction = () =>
                    {
                        var trans = GetAvailableWidget(WidgetInit.GetNameMenu(WidgetInit.MenuNames.KeyboardLock));
                        trans.PrepareToShowWidget(WidgetInit.GetNameMenu(WidgetInit.MenuNames.MainMenu));
                    };
                    MainWindow.StartTimer();
                }
                return;
            }

            var btn = new List<Button>();
            foreach (var list in paramsAction.Values)
            {
                var bt = list.Find(button => button.Name == name);
                if (bt != null)
                {
                    btn.Add(bt);
                }
            }

            btn.ForEach(button => button.Click(station, this));
        }
        public void Update()
        {
            parameters.ForEach(p => p.Update());
        }

        public bool IsContainParam(string name)
        {
            foreach (var pr in parameters)
            {
                if (pr.Name == name)
                {
                    return true;
                }
            }

            return false;
        }
    }


}
