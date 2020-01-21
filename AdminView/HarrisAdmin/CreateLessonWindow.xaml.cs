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
        }

        private void tbPdfFilePath_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.DefaultExt = ".pdf";
            myDialog.CheckFileExists = true;
            if (myDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbPdfFilePath.Text = myDialog.FileName;
            }
        }

        private void btSave_Click(object sender, RoutedEventArgs e)
        {
            byte[] bytesOfPdf = null;
            try
            {
                bytesOfPdf = File.ReadAllBytes(tbPdfFilePath.Text);
            }
            catch (IOException)
            {
                System.Windows.MessageBox.Show($"Невдається завантажити файл: {tbPdfFilePath.Text}");
                return;
            }

            WpfHarris78.Database.Lesson newLesson = new WpfHarris78.Database.Lesson();
            newLesson.Name = tbLessonName.Text;
            newLesson.Description = bytesOfPdf;

            WpfHarris78.Database.LessonsManager.CreateLesson(newLesson);
            this.Close();
        }

        private void SfDataGrid_SelectionChanged(object sender, Syncfusion.UI.Xaml.Grid.GridSelectionChangedEventArgs e)
        {

        }
    }
}
