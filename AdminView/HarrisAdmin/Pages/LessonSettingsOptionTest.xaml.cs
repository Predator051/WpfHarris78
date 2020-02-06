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
    /// Логика взаимодействия для LessonSettingsOptionTest.xaml
    /// </summary>
    public partial class LessonSettingsOptionTest : Page
    {
        public LessonSettingsOptionTest()
        {
            InitializeComponent();
            ((StackPanel)this.gbBit.Content).IsEnabled = false;
            ((StackPanel)this.gbVswr.Content).IsEnabled = false;
        }

        private void chbVswr_Checked(object sender, RoutedEventArgs e)
        {
            ((StackPanel)this.gbVswr.Content).IsEnabled = true;
        }

        private void chbVswr_Unchecked(object sender, RoutedEventArgs e)
        {
            ((StackPanel)this.gbVswr.Content).IsEnabled = false;
        }

        private void chbBit_Checked(object sender, RoutedEventArgs e)
        {
            ((StackPanel)this.gbBit.Content).IsEnabled = true;
        }

        private void chbBit_Unchecked(object sender, RoutedEventArgs e)
        {

            ((StackPanel)this.gbBit.Content).IsEnabled = false;
        }

        public LessonParametersSet.LessonParameters.Types.Option.Types.Test GetProtobufTestObject()
        {
            LessonParametersSet.LessonParameters.Types.Option.Types.Test test = new LessonParametersSet.LessonParameters.Types.Option.Types.Test();

            if ((bool)chbBit.IsChecked)
            {
                test.Bit = new LessonParametersSet.LessonParameters.Types.Option.Types.Test.Types.Bit
                {
                    ExternalPa = (bool)chbExternalPa.IsChecked,
                    InternalCoupler = (bool)chbInternalCoupler.IsChecked,
                    Kdp = (bool)chbKdp.IsChecked,
                    Kdu = (bool)chbKdu.IsChecked,
                    Prepost = (bool)chbPrepost.IsChecked,
                    RfCoupler = (bool)chbRfCoupler.IsChecked,
                    System = (bool)chbSystem.IsChecked
                };
            }

            test.VswrFrequency = (bool)chbVswr.IsChecked ? tbVswrFrequency.Value : "";
            test.Battery = (bool)chbBattery.IsChecked;
            test.Temp = (bool)chbTemp.IsChecked;
            return test;
        }
    }
}
