using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfHarris78.Database;

namespace HarrisUser.Src.UI
{
    class LessonListBoxItem
    {
        WpfHarris78.Database.Lesson _lesson;

        public LessonListBoxItem(WpfHarris78.Database.Lesson lesson)
        {
            Lesson = lesson;
        }

        public Lesson Lesson { get => _lesson; set => _lesson = value; }

        public override string ToString()
        {
            return Lesson.Name;
        }
    }
}
