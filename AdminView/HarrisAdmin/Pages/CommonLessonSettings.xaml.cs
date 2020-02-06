using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HarrisAdmin.Pages
{
    /// <summary>
    /// Логика взаимодействия для CommonLessonSettings.xaml
    /// </summary>
    public partial class CommonLessonSettings : Page
    {
        public CommonLessonSettings()
        {
            InitializeComponent();
        }
        private void tbPdfFilePath_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog
            {
                DefaultExt = ".pdf",
                CheckFileExists = true
            };
            myDialog.Filter = "pdf files (*.pdf)|*.pdf";
            if (myDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbPdfFilePath.Text = myDialog.FileName;
            }
        }

    }

}
