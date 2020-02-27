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
    /// Логика взаимодействия для LessonSettingsOptionRadio.xaml
    /// </summary>
    public partial class LessonSettingsOptionRadio : Page
    {
        public LessonSettingsOptionRadio()
        {
            InitializeComponent();
            this.cbPowerLevel.IsEnabled = false;
            this.cbSquelchLevel.IsEnabled = false;
            this.cbSquelchType.IsEnabled = false;
            this.cbInternalCoupler.IsEnabled = false;
            this.chbRadioSilence.IsEnabled = false;
            this.cbBfo.IsEnabled = false;
            this.chbNoiceBlanking.IsEnabled = false;
            this.chbRadioLock.IsEnabled = false;

        }
        /*
         "checkedPowerLevel" Cont
         "checkedSquelchLevel" Co
         "checkedSquelchType" Con
         "checkedInternalCoupler"
         "checkedRadioSilence" Co
         "checkedBfo" Content="" 
         "checkedNoiceBlanking" C
         "checkedRadioLock" Conte
             */

        public LessonParametersSet.LessonParameters.Types.Option.Types.Radio GetProtobufRadioObject ()
        {
            LessonParametersSet.LessonParameters.Types.Option.Types.Radio radio = new LessonParametersSet.LessonParameters.Types.Option.Types.Radio();

            radio.CheckBfo = (bool)this.checkedBfo.IsChecked;
            radio.CheckInternalCoupler = (bool)this.checkedInternalCoupler.IsChecked;
            radio.CheckRadioLock = (bool)this.checkedRadioLock.IsChecked;
            radio.CheckRadioSilence = (bool)this.checkedRadioSilence.IsChecked;
            radio.CheckRxNoiceBlanking = (bool)this.checkedNoiceBlanking.IsChecked;
            radio.CheckSquelchLevel = (bool)this.checkedNoiceBlanking.IsChecked;
            radio.CheckTxPowerLevel = (bool)this.checkedPowerLevel.IsChecked;


            if ((bool)this.checkedBfo.IsChecked)
            {
                radio.Bfo = this.cbBfo.Text;
            }
            if ((bool)this.checkedInternalCoupler.IsChecked)
            {
                radio.InternalCoupler = this.cbInternalCoupler.Text;
            }
            if ((bool)this.checkedNoiceBlanking.IsChecked)
            {
                radio.RxNoiceBlanking = (bool)this.chbNoiceBlanking.IsChecked ? "ON" : "OFF";
            }
            if ((bool)this.checkedPowerLevel.IsChecked)
            {
                radio.TxPowerLevel = this.cbPowerLevel.Text;
            }
            if ((bool)this.checkedRadioLock.IsChecked)
            {
                radio.RadioLock = (bool)this.chbRadioLock.IsChecked ? "ON" : "OFF";
            }
            if ((bool)this.checkedRadioSilence.IsChecked)
            {
                radio.RadioSilence = (bool)this.chbRadioSilence.IsChecked ? "ON" : "OFF";
            }
            if ((bool)this.checkedSquelchLevel.IsChecked)
            {
                radio.SquelchLevel = this.cbSquelchLevel.Text;
            }
            if ((bool)this.checkedSquelchType.IsChecked)
            {
                radio.FmSquelchType = this.cbSquelchType.Text;
            }

            return radio;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            switch(checkBox.Name)
            {
                case "checkedPowerLevel":
                    {
                        this.cbPowerLevel.IsEnabled = true;
                        break;
                    }
                case "checkedSquelchLevel":
                    {
                        this.cbSquelchLevel.IsEnabled = true;
                        break;
                    }
                case "checkedSquelchType":
                    {
                        this.cbSquelchType.IsEnabled = true;
                        break;
                    }
                case "checkedInternalCoupler":
                    {
                        this.cbInternalCoupler.IsEnabled = true;
                        break;
                    }
                case "checkedRadioSilence":
                    {
                        this.chbRadioSilence.IsEnabled = true;
                        break;
                    }
                case "checkedBfo":
                    {
                        this.cbBfo.IsEnabled = true;
                        break;
                    }
                case "checkedNoiceBlanking":
                    {
                        this.chbNoiceBlanking.IsEnabled = true;
                        break;
                    }
                case "checkedRadioLock":
                    {
                        this.chbRadioLock.IsEnabled = true;
                        break;
                    }
            }
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            switch (checkBox.Name)
            {
                case "checkedPowerLevel":
                    {
                        this.cbPowerLevel.IsEnabled = false;
                        break;
                    }
                case "checkedSquelchLevel":
                    {
                        this.cbSquelchLevel.IsEnabled = false;
                        break;
                    }
                case "checkedSquelchType":
                    {
                        this.cbSquelchType.IsEnabled = false;
                        break;
                    }
                case "checkedInternalCoupler":
                    {
                        this.cbInternalCoupler.IsEnabled = false;
                        break;
                    }
                case "checkedRadioSilence":
                    {
                        this.chbRadioSilence.IsEnabled = false;
                        break;
                    }
                case "checkedBfo":
                    {
                        this.cbBfo.IsEnabled = false;
                        break;
                    }
                case "checkedNoiceBlanking":
                    {
                        this.chbNoiceBlanking.IsEnabled = false;
                        break;
                    }
                case "checkedRadioLock":
                    {
                        this.chbRadioLock.IsEnabled = false;
                        break;
                    }
            }
        }
    }
}
