using System.Collections.Generic;

namespace Harris7800HMP
{
    public class WidgetQueue
    {
        private List<Widget> queue = new List<Widget>();
        private int currentIndex = -1;

        public void Add(Widget wdg)
        {
            queue.Add(wdg);
        }
        public Widget Next()
        {
            currentIndex++;

            if (currentIndex > queue.Count - 1)
            {
                return null;
            }

            return queue[currentIndex];
        }

        public Widget Current()
        {
            if (currentIndex > queue.Count - 1)
            {
                return null;
            }

            return queue[currentIndex];
        }

        public void Clear()
        {
            queue.Clear();
            currentIndex = -1;
        }
    }
}
