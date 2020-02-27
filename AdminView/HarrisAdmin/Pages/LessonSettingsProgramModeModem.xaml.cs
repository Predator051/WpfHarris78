using LessonParametersSet;
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
    /// Логика взаимодействия для LessonSettingsProgramModeModem.xaml
    /// </summary>
    public partial class LessonSettingsProgramModeModem : Page
    {
        Dictionary<CheckBox, Src.UI.ModemListBoxItem> checkBoxModem = new Dictionary<CheckBox, Src.UI.ModemListBoxItem>();
        public LessonSettingsProgramModeModem()
        {
            InitializeComponent();
            gbModem.IsEnabled = false;

            for (int i = 1; i < 21; i++)
            {
                Src.UI.ModemListBoxItem modem = new Src.UI.ModemListBoxItem("MDM" + (i < 10 ? "0" + i.ToString() : i.ToString()));
                CheckBox checkBox = new CheckBox();
                checkBox.Content = modem;
                checkBox.Checked += CheckBox_Checked;

                checkBoxModem.Add(checkBox, modem);
                lbModems.Items.Add(checkBox);
            }
        }

        private Src.UI.ModemListBoxItem getCurrentModem()
        {
            if (lbModems.SelectedItem == null) return null;
            return checkBoxModem[(CheckBox)lbModems.SelectedItem];
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e) {}

        public Google.Protobuf.Collections.RepeatedField<LessonParameters.Types.Program.Types.Mode.Types.Preset.Types.Modem> GetModemsProtobufObject()
        {
            Google.Protobuf.Collections.RepeatedField<LessonParameters.Types.Program.Types.Mode.Types.Preset.Types.Modem> 
                modems = new Google.Protobuf.Collections.RepeatedField<LessonParameters.Types.Program.Types.Mode.Types.Preset.Types.Modem>();

            foreach (CheckBox item in lbModems.Items)
            {
                if ((bool)item.IsChecked)
                {
                    modems.Add(checkBoxModem[item].SerializeToProtobuf());
                }
            }

            return modems;
        }

        public List<Src.UI.ModemListBoxItem> GetModemsListObject()
        {
            List<Src.UI.ModemListBoxItem> result = new List<Src.UI.ModemListBoxItem>();
            foreach (CheckBox item in lbModems.Items)
            {
                result.Add(checkBoxModem[item]);
            }
            return result;
        }

        private void lbModems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = lbModems.SelectedItem;
            if (selectedItem != null)
            {
                gbModem.IsEnabled = true;
                void setCBItem(ComboBox box, string activeString)
                {
                    foreach(ComboBoxItem item in box.Items)
                    {
                        if ((string)item.Content == activeString)
                        {
                            box.SelectedItem = item;
                            break;
                        }
                    }
                }
                var currModem = getCurrentModem().Modem;
                this.maskedEditName.Value = currModem.name;
                if (!string.IsNullOrEmpty(currModem.dataBits))
                {
                    setCBItem(cbDataBits, currModem.dataBits);
                } 
                else
                {
                    cbDataBits.SelectedIndex = 0;
                }
                if (!string.IsNullOrEmpty(currModem.dataRate))
                {
                    setCBItem(cbDataRate, currModem.dataRate);
                }
                else
                {
                    cbDataRate.SelectedIndex = 0;
                }
                if (!string.IsNullOrEmpty(currModem.mode))
                {
                    setCBItem(cbMode, currModem.mode);
                }
                else
                {
                    cbMode.SelectedIndex = 0;
                }
                if (!string.IsNullOrEmpty(currModem.modemType))
                {
                    setCBItem(cbModemType, currModem.modemType);
                }
                else
                {
                    cbModemType.SelectedIndex = 0;
                }
                if (!string.IsNullOrEmpty(currModem.parity))
                {
                    setCBItem(cbParity, currModem.parity);
                }
                else
                {
                    cbParity.SelectedIndex = 0;
                }
                if (!string.IsNullOrEmpty(currModem.stopBits))
                {
                    setCBItem(cbStopBits, currModem.stopBits);
                }
                else
                {
                    cbStopBits.SelectedIndex = 0;
                }

                var modemItem = getCurrentModem();
                detachEventFromCheckBox();
                this.chbDataBits.IsChecked = modemItem.CheckDataBits;
                this.chbDataRate.IsChecked = modemItem.CheckDataRate;
                this.chbEnableCheck.IsChecked = modemItem.CheckEnable;
                this.chbMode.IsChecked = modemItem.CheckMode;
                this.chbModemType.IsChecked = modemItem.CheckModemType;
                this.chbName.IsChecked = modemItem.CheckName;
                this.chbParity.IsChecked = modemItem.CheckParity;
                this.chbStopBits.IsChecked = modemItem.CheckStopBits;
                attachEventToCheckBox();
            }
            else
            {
                gbModem.IsEnabled = false;
            }
        }

        private void detachEventFromCheckBox()
        {
            this.chbDataBits.Checked  -= chb_Checked;
            this.chbDataRate.Checked -= chb_Checked;
            this.chbEnableCheck.Checked  -= chb_Checked;;
            this.chbMode.Checked  -= chb_Checked;
            this.chbModemType.Checked -= chb_Checked;
            this.chbName.Checked  -= chb_Checked;
            this.chbParity.Checked  -= chb_Checked;
            this.chbStopBits.Checked  -= chb_Checked;

            this.chbDataBits    .Unchecked -= chb_Unchecked;
            this.chbDataRate    .Unchecked -= chb_Unchecked;
            this.chbEnableCheck .Unchecked -= chb_Unchecked;
            this.chbMode        .Unchecked -= chb_Unchecked;
            this.chbModemType   .Unchecked -= chb_Unchecked;
            this.chbName        .Unchecked -= chb_Unchecked;
            this.chbParity      .Unchecked -= chb_Unchecked;
            this.chbStopBits    .Unchecked -= chb_Unchecked;
        }

        private void attachEventToCheckBox()
        {
            this.chbDataBits.Checked += chb_Checked;
            this.chbDataRate.Checked += chb_Checked;
            this.chbEnableCheck.Checked += chb_Checked; ;
            this.chbMode.Checked += chb_Checked;
            this.chbModemType.Checked += chb_Checked;
            this.chbName.Checked += chb_Checked;
            this.chbParity.Checked += chb_Checked;
            this.chbStopBits.Checked += chb_Checked;

            this.chbDataBits.Unchecked += chb_Unchecked;
            this.chbDataRate.Unchecked += chb_Unchecked;
            this.chbEnableCheck.Unchecked += chb_Unchecked;
            this.chbMode.Unchecked += chb_Unchecked;
            this.chbModemType.Unchecked += chb_Unchecked;
            this.chbName.Unchecked += chb_Unchecked;
            this.chbParity.Unchecked += chb_Unchecked;
            this.chbStopBits.Unchecked += chb_Unchecked;
        }

        private void chb_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            var currModem = getCurrentModem();
            bool isChecked = (bool)checkBox.IsChecked;

            switch (checkBox.Name)
            {
                case "chbModemType":
                    {
                        currModem.Modem.modemType = this.cbModemType.Text;
                        currModem.CheckModemType = isChecked;
                        break;
                    }
                case "chbDataRate":
                    {
                        currModem.Modem.dataRate = this.cbDataRate.Text;
                        currModem.CheckDataRate = isChecked;
                        break;
                    }
                case "chbMode":
                    {
                        currModem.Modem.mode = this.cbMode.Text;
                        currModem.CheckMode = isChecked;
                        break;
                    }
                case "chbDataBits":
                    {
                        currModem.Modem.dataBits = this.cbDataBits.Text;
                        currModem.CheckDataBits = isChecked;
                        break;
                    }
                case "chbStopBits":
                    {
                        currModem.Modem.stopBits = this.cbStopBits.Text;
                        currModem.CheckStopBits = isChecked;
                        break;
                    }
                case "chbParity":
                    {
                        currModem.Modem.parity = this.cbParity.Text;
                        currModem.CheckParity = isChecked;
                        break;
                    }
                case "chbEnableCheck":
                    {
                        currModem.Modem.enable = (bool)this.chbEnable.IsChecked ? "YES" : "NO";
                        currModem.CheckEnable = isChecked;
                        break;
                    }
                case "chbName":
                    {
                        currModem.CheckName = isChecked;
                        break;
                    }
            }
        }

        private void chb_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            var currModem = getCurrentModem();
            bool isChecked = (bool)checkBox.IsChecked;

            switch (checkBox.Name)
            {
                case "chbModemType":
                    {
                        currModem.CheckModemType = isChecked;
                        break;
                    }
                case "chbDataRate":
                    {
                        currModem.CheckDataRate = isChecked;
                        break;
                    }
                case "chbMode":
                    {
                        currModem.CheckMode = isChecked;
                        break;
                    }
                case "chbDataBits":
                    {
                        currModem.CheckDataBits = isChecked;
                        break;
                    }
                case "chbStopBits":
                    {
                        currModem.CheckStopBits = isChecked;
                        break;
                    }
                case "chbParity":
                    {
                        currModem.CheckParity = isChecked;
                        break;
                    }
                case "chbEnableCheck":
                    {
                        currModem.CheckEnable = isChecked;
                        break;
                    }
                case "chbName":
                    {
                        currModem.CheckName = isChecked;
                        break;
                    }
            }
        }

        private void maskedEditName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = maskedEditName.Text;
            if (!text.Contains('_'))
            {
                getCurrentModem().Modem.name = text.ToUpper();
                ((CheckBox)lbModems.SelectedItem).Content = text.ToUpper();
                lbModems.Items.Refresh();
                DataModels.ApplicationPageContainer.Contrainer.GetPage<LessonSettingsProgramModeSystem>().ModemPresetUpdate();
            }
        }

        private void cbModemType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (getCurrentModem() == null) return;
            getCurrentModem().Modem.modemType = ((ComboBoxItem)cbModemType.SelectedItem).Content as string;
        }

        private void cbDataRate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (getCurrentModem() == null) return;
            getCurrentModem().Modem.dataRate = ((ComboBoxItem)cbDataRate.SelectedItem).Content as string;
        }

        private void cbMode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (getCurrentModem() == null) return;
            getCurrentModem().Modem.mode = ((ComboBoxItem)cbMode.SelectedItem).Content as string; 
        }

        private void cbDataBits_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (getCurrentModem() == null) return;
            getCurrentModem().Modem.dataBits = ((ComboBoxItem)cbDataBits.SelectedItem).Content as string;
        }

        private void cbStopBits_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (getCurrentModem() == null) return;
            getCurrentModem().Modem.stopBits = ((ComboBoxItem)cbStopBits.SelectedItem).Content as string;
        }

        private void cbParity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (getCurrentModem() == null) return;
            getCurrentModem().Modem.parity = ((ComboBoxItem)cbParity.SelectedItem).Content as string;
        }

        private void chbEnable_Checked(object sender, RoutedEventArgs e)
        {
            if (getCurrentModem() == null) return;
            bool isChecked = (bool)((CheckBox)sender).IsChecked;
            getCurrentModem().Modem.enable = isChecked ? "YES" : "NO";
            ((CheckBox)sender).Content = getCurrentModem().Modem.enable;
        }
    }
}
