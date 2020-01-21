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
using WpfHarris78.Database;

namespace HarrisAdmin
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //WpfHarris78.MainWindow h = new WpfHarris78.MainWindow();
            //h.Show();
        }

        private void btAddLesson_Click(object sender, RoutedEventArgs e)
        {
            CreateLessonWindow createWindow = new CreateLessonWindow();
            createWindow.ShowDialog();

            this.lbLessons.Items.Clear();
            var lessons = WpfHarris78.Database.LessonsManager.GetLessons();
            foreach( var lesson in lessons)
            {
                Src.UI.LessonListBoxItem lbItem = new Src.UI.LessonListBoxItem(lesson);
                this.lbLessons.Items.Add(lbItem);
            }
        }

        private void loadPdfToView(byte[] arrayByte)
        {
            Stream stream = new MemoryStream(arrayByte);

            this.pdfLessonInfo.Load(stream);
        }

        private void lbLessons_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Src.UI.LessonListBoxItem currItem = (Src.UI.LessonListBoxItem) this.lbLessons.SelectedItem;
            if (currItem != null)
            {
                loadPdfToView(currItem.Lesson.Description);
            }
        }
    }
}
