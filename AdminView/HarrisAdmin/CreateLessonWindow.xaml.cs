using HarrisAdmin.Pages;
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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HarrisAdmin
{
    /// <summary>
    /// Логика взаимодействия для CreateLessonWindow.xaml
    /// </summary>
    public partial class CreateLessonWindow : Window
    {
        public CreateLessonWindow()
        {
            InitializeComponent();
            this.DataContext = new ViewModel.WindowViewModel(this);
        }

       
        private void btSave_Click(object sender, RoutedEventArgs e)
        {
            var commonLessonSettings = DataModels.ApplicationPageContainer.Contrainer.GetPage<CommonLessonSettings>();

            byte[] bytesOfPdf = null;
            try
            {
                bytesOfPdf = File.ReadAllBytes(commonLessonSettings.tbPdfFilePath.Text);
            }
            catch (IOException)
            {
                System.Windows.MessageBox.Show($"Невдається завантажити файл: {commonLessonSettings.tbPdfFilePath.Text}");
                return;
            }

            WpfHarris78.Database.Lesson newLesson = new WpfHarris78.Database.Lesson
            {
                Name = commonLessonSettings.tbLessonName.Text,
                Description = bytesOfPdf
            };

            var radio = DataModels.ApplicationPageContainer.Contrainer.GetPage<LessonSettingsOptionRadio>().GetProtobufRadioObject();
            var test = DataModels.ApplicationPageContainer.Contrainer.GetPage<LessonSettingsOptionTest>().GetProtobufTestObject();
            var common = DataModels.ApplicationPageContainer.Contrainer.GetPage<LessonSettingsStationStatus>().GetProtobufCommonObject();
            var keys = DataModels.ApplicationPageContainer.Contrainer.GetPage<LessonSettingsProgramComsecKeys>().GetProtobufKeysObject();

            WpfHarris78.Protobuf.Wrappers.LessonParametersWrapper lessonParameters = new WpfHarris78.Protobuf.Wrappers.LessonParametersWrapper();
            lessonParameters.Parameters.Option.Radio = radio;
            lessonParameters.Parameters.Option.Test  = test;
            lessonParameters.Parameters.Common = common;
            lessonParameters.Parameters.Program.Comsec.Keys.Add(keys);

            WpfHarris78.Database.LessonsManager.CreateLesson(newLesson);
            WpfHarris78.Database.LessonParametersManager.CreateLesson(newLesson.Id, lessonParameters);

            this.Close();
        }

        private void SfDataGrid_SelectionChanged(object sender, Syncfusion.UI.Xaml.Grid.GridSelectionChangedEventArgs e)
        {

        }
        private void myFrame_ContentRendered(object sender, EventArgs e)
        {
            this.MainFrame.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;
        }
        private void treeViewLessonParams_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            string itemHeaderString = ((TreeViewItem)this.treeViewLessonParams.SelectedItem).Header.ToString();

            switch(itemHeaderString)
            {
                case "Radio":
                    {
                        this.MainFrame.Content = DataModels.ApplicationPageContainer.Contrainer.Pages[DataModels.ApplicationPage.LessonSettingsOptionRadio];
                        break;
                    }
                case "Загальне":
                    {
                        this.MainFrame.Content = DataModels.ApplicationPageContainer.Contrainer.Pages[DataModels.ApplicationPage.CommonLessonSettings];
                        break;
                    }
                case "Test":
                    {
                        this.MainFrame.Content = DataModels.ApplicationPageContainer.Contrainer.Pages[DataModels.ApplicationPage.LessonSettingsOptionTest];
                        break;
                    }
                case "Режими, положення на інше":
                    {
                        this.MainFrame.Content = DataModels.ApplicationPageContainer.Contrainer.Pages[DataModels.ApplicationPage.LessonSettingsRadioStationStatus];
                        break;
                    }
                case "Keys":
                    {
                        this.MainFrame.Content = DataModels.ApplicationPageContainer.Contrainer.Pages[DataModels.ApplicationPage.LessonSettingsProgramComsecKeys];
                        break;
                    }
                default:
                    {
                        this.MainFrame.Content = null;
                        break;
                    }
            }
        }
    }
}
