using System;
using System.Collections.Generic;
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
using Checker = WpfHarris78.Src.Checker;

namespace HarrisUser.Pages
{
    /// <summary>
    /// Логика взаимодействия для PassingLessonPage.xaml
    /// </summary>
    public partial class PassingLessonPage : Page
    {
        WpfHarris78.Database.Lesson Lesson { get; set; }
        LessonParametersSet.LessonParameters LessonCheckSteps { get; set; }
        public PassingLessonPage(WpfHarris78.Database.Lesson lesson)
        {
            InitializeComponent();
            Lesson = lesson;

            LessonCheckSteps = WpfHarris78.Database.LessonParametersManager.GetParametersLesson(lesson.Id);

            WpfHarris78.MainWindow mainWindow = new WpfHarris78.MainWindow();
            mainWindow.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool isPassing = Checker.LessonParametersChecker.IsEquals(LessonCheckSteps, Checker.LessonParametersHolder.Holder.Parameters);

            this.tbInfoAboutPassing.Text = isPassing ? "Пройдено!" : "Не пройдено!";
        }
    }
}
