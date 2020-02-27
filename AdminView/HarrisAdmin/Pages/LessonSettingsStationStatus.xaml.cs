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

namespace HarrisAdmin.Pages
{
    /// <summary>
    /// Логика взаимодействия для LessonSettingsStationStatus.xaml
    /// </summary>
    public partial class LessonSettingsStationStatus : Page
    {
        public LessonSettingsStationStatus()
        {
            InitializeComponent();
            this.cbMode.IsEnabled = false;
            this.cbState.IsEnabled = false;
        }

        private void chbMode_Checked(object sender, RoutedEventArgs e)
        {
            this.cbMode.IsEnabled = true;
        }
        private void chbMode_Unchecked(object sender, RoutedEventArgs e)
        {
            this.cbMode.IsEnabled = false;
        }
        private void chbState_Checked(object sender, RoutedEventArgs e)
        {
            this.cbState.IsEnabled = true;
        }
        private void chbState_Unchecked(object sender, RoutedEventArgs e)
        {
            this.cbState.IsEnabled = false;
        }

        public LessonParametersSet.LessonParameters.Types.Common GetProtobufCommonObject()
        {
            LessonParametersSet.LessonParameters.Types.Common common = new LessonParametersSet.LessonParameters.Types.Common
            {
                Coupler = (bool)chbCoupler.IsChecked,
                CheckCoupler = (bool)chbCoupler.IsChecked,
                Handset = (bool)chbHandset.IsChecked,
                CheckHandset = (bool)chbHandset.IsChecked,
                Mode = (bool)chbMode.IsChecked ? cbMode.Text : "",
                CheckMode = (bool)chbMode.IsChecked,
                Sq = (bool)chbSq.IsChecked,
                CheckSq = (bool)chbSq.IsChecked,
                State = (bool)chbState.IsChecked ? cbState.Text : "",
                CheckState = (bool)chbState.IsChecked,
                Usb = (bool)chbUsb.IsChecked,
                CheckUsb = (bool)chbUsb.IsChecked
            };

            return common;
        }
    }
}
