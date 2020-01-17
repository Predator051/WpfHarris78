using System;

namespace Harris7800HMP
{
    public class Button
    {
        private string name;

        public Button(string n, Action<Button, RadioStation, Widget> act)
        {
            Name = n;
            Action = act;
        }

        public string Name { get => name; set => name = value; }
        internal Action<Button, RadioStation, Widget> Action { get; set; }

        public void Click(RadioStation station, Widget widget)
        {
            Action?.Invoke(this, station, widget);
        }
    }
}
