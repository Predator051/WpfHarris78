using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HarrisUser.Pages
{
    /// <summary>
    /// Логика взаимодействия для LessonListPage.xaml
    /// </summary>
    public partial class LessonListPage : Page
    {
        //public Window Parent;

        public LessonListPage()
        {
            InitializeComponent();

            //Parent = parent;

            this.lbLessons.Items.Clear();
            var lessons = WpfHarris78.Database.LessonsManager.GetLessons();
            foreach (var lesson in lessons)
            {
                Src.UI.LessonListBoxItem lbItem = new Src.UI.LessonListBoxItem(lesson);
                this.lbLessons.Items.Add(lbItem);
            }
        }

        private void loadPdfToView(byte[] arrayByte)
        {
            Stream stream = new MemoryStream(arrayByte);

            this.pdfViewerLesson.Load(stream);
        }


        private void lbLessons_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Src.UI.LessonListBoxItem currItem = (Src.UI.LessonListBoxItem)this.lbLessons.SelectedItem;
            if (currItem != null && currItem.Lesson.Description != null)
            {
                loadPdfToView(currItem.Lesson.Description);
            }
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Src.UI.LessonListBoxItem currItem = (Src.UI.LessonListBoxItem)this.lbLessons.SelectedItem;
                if (currItem == null) return;

                var passingLesson = new Pages.PassingLessonPage(currItem.Lesson);
                ((MainWindow)Window.GetWindow(this)).MainFrame.Content = passingLesson;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
