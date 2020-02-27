using LessonParametersSet;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Threading;

namespace HarrisAdmin.Pages
{
    /// <summary>
    /// Логика взаимодействия для LessonSettingsProgramModeSystem.xaml
    /// </summary>
    public partial class LessonSettingsProgramModeSystem : Page
    {
        public LessonSettingsProgramModeSystem()
        {
            InitializeComponent(); 
            cbRadioMode.ItemsSource = Enum.GetValues(typeof(Harris7800HMP.RadioStationMode)).Cast<Harris7800HMP.RadioStationMode>();
            cbRadioMode.SelectedIndex = 0;

            cbEncryptionType.ItemsSource = Enum.GetValues(typeof(Harris7800HMP.KeyModule.KeyType)).Cast<Harris7800HMP.KeyModule.KeyType>();
            cbEncryptionType.SelectedIndex = 0;

            Src.UI.KeyListBoxItem empty = new Src.UI.KeyListBoxItem("-------------------");
            cbEncryptionKey.Items.Add(empty);

            gbSystem.IsEnabled = false;
        }

        Src.UI.SystemListBoxItem GetCurrentSystem()
        {
            return (Src.UI.SystemListBoxItem)lbSystem.SelectedItem;
        }


        public void ModemPresetUpdate()
        {
            cbModemPreset.Items.Refresh();
        }

        private void chb_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            bool chbValue = (bool)checkBox.IsChecked;
            var currSysObj = GetCurrentSystem();
            switch (checkBox.Name)
            {
                case "chbModemPreset":
                    {
                        currSysObj.CheckModemPreset = chbValue;
                        if (chbValue)
                        {
                            if (cbModemPreset.SelectedItem != null)
                            {
                                GetCurrentSystem().System.modemPreset = ((Src.UI.ModemListBoxItem)cbModemPreset.SelectedItem).Modem;
                            }
                            else
                            {
                                if (cbModemPreset.Items.Count <= 0)
                                {
                                    cbModemPreset.ItemsSource = DataModels.ApplicationPageContainer.Contrainer.GetPage<LessonSettingsProgramModeModem>()
                                        .GetModemsListObject().Cast<Src.UI.ModemListBoxItem>();
                                }
                                cbModemPreset.SelectedIndex = 0;
                            }
                        }
                        break;
                    }
                case "chbRadioMode":
                    {
                        currSysObj.CheckRadioMode = chbValue;
                        if (chbValue)
                        {
                            GetCurrentSystem().System.radioMode = (Harris7800HMP.RadioStationMode)this.cbRadioMode.SelectedItem;
                        }
                        break;
                    }
                case "chbChannelNumber":
                    {
                        currSysObj.CheckChannelNumber = chbValue;
                        if (chbValue)
                        {
                            GetCurrentSystem().System.channelNumber = (string)this.maskedEditNumber.Value;
                        }
                        break;
                    }
                case "chbEncryptionType":
                    {
                        currSysObj.CheckKey = chbValue;
                        if (chbValue)
                        {
                            GetCurrentSystem().System.key = new KeyValuePair<Harris7800HMP.KeyModule.KeyType, Harris7800HMP.KeyModule.KeyValue>(
                                 (Harris7800HMP.KeyModule.KeyType)this.cbEncryptionType.SelectedItem,
                                 new Harris7800HMP.KeyModule.KeyValue());
                        }
                        break;
                    }
                case "chbEncryptionKey":
                    {
                        currSysObj.CheckKeyValue = chbValue;
                        if (chbValue && this.cbEncryptionKey.SelectedItem != null)
                        {
                            GetCurrentSystem().System.key = new KeyValuePair<Harris7800HMP.KeyModule.KeyType, Harris7800HMP.KeyModule.KeyValue>(
                                GetCurrentSystem().System.key.Key,
                                ((Src.UI.KeyListBoxItem)this.cbEncryptionKey.SelectedItem).Key);
                        }
                        break;
                    }
                case "chbPTVoiceMode":
                    {
                        currSysObj.CheckPtVoiceMode = chbValue;
                        if (chbValue)
                        {
                            GetCurrentSystem().System.ptVoiceMode = this.cbPTVoiceMode.Text;
                        }
                        break;
                    }
                case "chbCTVoiceMode":
                    {
                        currSysObj.CheckCtVoiceMode = chbValue;
                        if (chbValue)
                        {
                            GetCurrentSystem().System.ctVoiceMode = this.cbCTVoiceMode.Text;
                        }
                        break;
                    }
                case "chbEnableCheck":
                    {
                        currSysObj.CheckEnable = chbValue;
                        break;
                    }
                case "chbName":
                    {
                        currSysObj.CheckName = chbValue;
                        break;
                    }
            }
        }

        string GenerateName(string prefix, int num)
        {
            string name = prefix + (num < 10 ? "0" + num.ToString() : num.ToString());

            bool isContainWithSameName(string n)
            {
                foreach (var item in lbSystem.Items)
                {
                    if (item.ToString() == n) return true;
                }
                return false;
            }

            if (isContainWithSameName(name))
            {
                return GenerateName(prefix, num + 1);
            }

            return name;
        }

        private void maskedEditNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = maskedEditNumber.Text;
            if (!text.Contains('_') && GetCurrentSystem() != null)
            {
                GetCurrentSystem().System.channelNumber = text;
            }
        }

        private void maskedEditName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = maskedEditName.Text;
            if (!text.Contains('_'))
            {
                GetCurrentSystem().System.name = text;
                lbSystem.Items.Refresh();
            }
        }

        private void cbPTVoiceMode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var currSystem = GetCurrentSystem();
            if (currSystem != null)
            {
                currSystem.System.ptVoiceMode = ((ComboBoxItem)cbPTVoiceMode.SelectedItem).Content as string;
            }
        }

        private void cbCTVoiceMode_Copy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var currSystem = GetCurrentSystem();
            if (currSystem != null)
            {
                currSystem.System.ctVoiceMode = ((ComboBoxItem)cbCTVoiceMode.SelectedItem).Content as string;
            }
        }

        private void btnAddSystem_Click(object sender, RoutedEventArgs e)
        {
            Src.UI.SystemListBoxItem keyListBoxItem = new Src.UI.SystemListBoxItem(GenerateName("SYSPRE", 1));
            keyListBoxItem.System.radioMode = Harris7800HMP.RadioStationMode.None;
            
            lbSystem.Items.Add(keyListBoxItem);
        }

        private void btnRemoveSystem_Click(object sender, RoutedEventArgs e)
        {
            if (lbSystem.Items.Count <= 0)
            {
                gbSystem.IsEnabled = false;
            } 
            else
            {
                lbSystem.Items.Remove(lbSystem.SelectedItem);
            }
        }

        private void lbSystem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbSystem.SelectedItem != null)
            {
                gbSystem.IsEnabled = true;
                maskedEditName.Value = ((Src.UI.SystemListBoxItem)lbSystem.SelectedItem).System.name;

                void setCBItem(ComboBox box, string activeString)
                {
                    foreach (ComboBoxItem item in box.Items)
                    {
                        if ((string)item.Content == activeString)
                        {
                            box.SelectedItem = item;
                            break;
                        }
                    }
                }

                var systemObj = ((Src.UI.SystemListBoxItem)lbSystem.SelectedItem).System;
                if (!string.IsNullOrEmpty(systemObj.ptVoiceMode))
                {
                    setCBItem(cbPTVoiceMode, systemObj.ptVoiceMode);
                } 
                else
                {
                    cbPTVoiceMode.SelectedIndex = 0;
                }

                if (!string.IsNullOrEmpty(systemObj.ctVoiceMode))
                {
                    setCBItem(cbCTVoiceMode, systemObj.ctVoiceMode);
                }
                else
                {
                    cbCTVoiceMode.SelectedIndex = 0;
                }
                if (!string.IsNullOrEmpty(systemObj.enable))
                {
                    chbEnable.IsChecked = systemObj.enable == "YES";
                } 
                else
                {
                    chbEnable.IsChecked = false;
                }
                if (!string.IsNullOrEmpty(systemObj.channelNumber))
                {
                    maskedEditNumber.Value = systemObj.channelNumber;
                }
                else
                {
                    maskedEditNumber.Value = "000";
                }
                if (systemObj.key.Key != Harris7800HMP.KeyModule.KeyType.None)
                {
                    foreach(var type in cbEncryptionType.Items)
                    {
                        if ((Harris7800HMP.KeyModule.KeyType)type == systemObj.key.Key)
                        {
                            cbEncryptionType.SelectionChanged -= cbEncryptionType_SelectionChanged;
                            cbEncryptionType.SelectedItem = type;
                            LoadKeysByType((Harris7800HMP.KeyModule.KeyType)type);
                            cbEncryptionType.SelectionChanged += cbEncryptionType_SelectionChanged;
                            break;
                        }
                    }
                }
                else
                {
                    cbEncryptionType.SelectedIndex = 0;
                }
                if (systemObj.key.Value != null && !string.IsNullOrEmpty(systemObj.key.Value.keyName))
                {
                    foreach (Src.UI.KeyListBoxItem key in cbEncryptionKey.Items)
                    {
                        if (key.Key.keyName == systemObj.key.Value.keyName)
                        {
                            cbEncryptionKey.SelectionChanged -= cbEncryptionKey_SelectionChanged;
                            cbEncryptionKey.SelectedItem = key;
                            cbEncryptionKey.SelectionChanged += cbEncryptionKey_SelectionChanged;
                            break;
                        }
                    }
                }
                else
                {
                    cbEncryptionKey.SelectedIndex = 0;
                }
                if (systemObj.radioMode != Harris7800HMP.RadioStationMode.None)
                {
                    foreach (Harris7800HMP.RadioStationMode mode in cbRadioMode.Items)
                    {
                        if (mode == systemObj.radioMode)
                        {
                            cbRadioMode.SelectedItem = mode;
                            break;
                        }
                    }
                }
                else
                {
                    cbRadioMode.SelectedIndex = 0;
                }
                if (systemObj.modemPreset != null && !string.IsNullOrEmpty(systemObj.modemPreset.name))
                {
                    foreach (Src.UI.ModemListBoxItem modem in cbModemPreset.Items)
                    {
                        if (modem.Modem.name == systemObj.modemPreset.name)
                        {
                            cbModemPreset.SelectedItem = modem;
                            break;
                        }
                    }
                }
                else
                {
                    cbModemPreset.SelectedIndex = 0;
                }
                detachCheckedEventFromCheckBox();
                var systemItem = (Src.UI.SystemListBoxItem)lbSystem.SelectedItem;
                this.chbChannelNumber.IsChecked = systemItem.CheckChannelNumber;
                this.chbCTVoiceMode.IsChecked = systemItem.CheckCtVoiceMode;
                this.chbEnableCheck.IsChecked = systemItem.CheckEnable;
                this.chbEncryptionKey.IsChecked = systemItem.CheckKey;
                this.chbEncryptionType.IsChecked = systemItem.CheckKeyValue;
                this.chbModemPreset.IsChecked = systemItem.CheckModemPreset;
                this.chbName.IsChecked = systemItem.CheckName;
                this.chbPTVoiceMode.IsChecked = systemItem.CheckPtVoiceMode;
                this.chbRadioMode.IsChecked = systemItem.CheckRadioMode;
                attachCheckedEventToCheckBox();
            }
        }

        void detachCheckedEventFromCheckBox()
        {
            this.chbChannelNumber.Checked -= chb_Checked;
            this.chbCTVoiceMode.Checked -= chb_Checked;
            this.chbEnableCheck.Checked -= chb_Checked;
            this.chbEncryptionKey.Checked -= chb_Checked;
            this.chbEncryptionType.Checked -= chb_Checked;
            this.chbModemPreset.Checked -= chb_Checked;
            this.chbName.Checked -= chb_Checked;
            this.chbPTVoiceMode.Checked -= chb_Checked;
            this.chbRadioMode.Checked -= chb_Checked;

            this.chbChannelNumber.Unchecked -= chb_Checked;
            this.chbCTVoiceMode.Unchecked -= chb_Checked;
            this.chbEnableCheck.Unchecked -= chb_Checked;
            this.chbEncryptionKey.Unchecked -= chb_Checked;
            this.chbEncryptionType.Unchecked -= chb_Checked;
            this.chbModemPreset.Unchecked -= chb_Checked;
            this.chbName.Unchecked -= chb_Checked;
            this.chbPTVoiceMode.Unchecked -= chb_Checked;
            this.chbRadioMode.Unchecked -= chb_Checked;
        }

        void attachCheckedEventToCheckBox()
        {
            this.chbChannelNumber.Checked += chb_Checked;
            this.chbCTVoiceMode.Checked += chb_Checked;
            this.chbEnableCheck.Checked += chb_Checked;
            this.chbEncryptionKey.Checked += chb_Checked;
            this.chbEncryptionType.Checked += chb_Checked;
            this.chbModemPreset.Checked += chb_Checked;
            this.chbName.Checked += chb_Checked;
            this.chbPTVoiceMode.Checked += chb_Checked;
            this.chbRadioMode.Checked += chb_Checked;

            this.chbChannelNumber.Unchecked += chb_Checked;
            this.chbCTVoiceMode.Unchecked += chb_Checked;
            this.chbEnableCheck.Unchecked += chb_Checked;
            this.chbEncryptionKey.Unchecked += chb_Checked;
            this.chbEncryptionType.Unchecked += chb_Checked;
            this.chbModemPreset.Unchecked += chb_Checked;
            this.chbName.Unchecked += chb_Checked;
            this.chbPTVoiceMode.Unchecked += chb_Checked;
            this.chbRadioMode.Unchecked += chb_Checked;
        }

        private void cbRadioMode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var currSystem = GetCurrentSystem();
            if (currSystem != null)
            {
                currSystem.System.radioMode = (Harris7800HMP.RadioStationMode)cbRadioMode.SelectedItem;
            }
        }

        private void cbModemPreset_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var currSystem = GetCurrentSystem();
            if (currSystem != null)
            {
                currSystem.System.modemPreset = ((Src.UI.ModemListBoxItem)cbModemPreset.SelectedItem).Modem;
            }
        }
        private void LoadKeysByType(Harris7800HMP.KeyModule.KeyType type)
        {
            var keys = DataModels.ApplicationPageContainer.Contrainer.GetPage<LessonSettingsProgramComsecKeys>().GetKeysList();

            cbEncryptionKey.Items.Clear();
            Src.UI.KeyListBoxItem empty = new Src.UI.KeyListBoxItem("-------------------");
            cbEncryptionKey.Items.Add(empty);
            foreach (var key in keys)
            {
                if (key.Key.type == type)
                {
                    cbEncryptionKey.Items.Add(key);
                }
            }
        }
        private void cbEncryptionType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!DataModels.ApplicationPageContainer.IsInited) return;
            Harris7800HMP.KeyModule.KeyType type = (Harris7800HMP.KeyModule.KeyType)cbEncryptionType.SelectedItem;

            var systemItem = GetCurrentSystem().System;
            systemItem.key = new KeyValuePair<Harris7800HMP.KeyModule.KeyType, Harris7800HMP.KeyModule.KeyValue>(type, new Harris7800HMP.KeyModule.KeyValue());

            LoadKeysByType(type);

            if (cbEncryptionKey.Items.Count <= 1)
            {
                cbEncryptionKey.SelectedIndex = 0;
            }
        }

        private void cbEncryptionKey_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (GetCurrentSystem() != null && cbEncryptionKey.SelectedItem != null)
            {
                var system = GetCurrentSystem().System;
                Src.UI.KeyListBoxItem currKey = (Src.UI.KeyListBoxItem)cbEncryptionKey.SelectedItem;
                system.key = new KeyValuePair<Harris7800HMP.KeyModule.KeyType, Harris7800HMP.KeyModule.KeyValue>(system.key.Key, currKey.Key);
            }
        }

        private void chbEnable_Checked(object sender, RoutedEventArgs e)
        {
            bool checkStatus = (bool)chbEnable.IsChecked;
            string text = checkStatus ? "YES" : "NO";
            chbEnable.Content = text;
            GetCurrentSystem().System.enable = text;
        }

        private void chbEnableCheck_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void chbEnableCheck_Unchecked(object sender, RoutedEventArgs e)
        {
        }

        public Google.Protobuf.Collections.RepeatedField<LessonParameters.Types.Program.Types.Mode.Types.Preset.Types.System> GetSystemProtobufObjects()
        {
            Google.Protobuf.Collections.RepeatedField<LessonParameters.Types.Program.Types.Mode.Types.Preset.Types.System> systems =
                new Google.Protobuf.Collections.RepeatedField<LessonParameters.Types.Program.Types.Mode.Types.Preset.Types.System>();

            foreach (Src.UI.SystemListBoxItem item in lbSystem.Items)
            {
                systems.Add(item.SerializeToProtobuf());
            }

            return systems;
        }

        private void cbModemPreset_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (cbModemPreset.Items.Count <= 0)
            {
                cbModemPreset.ItemsSource = DataModels.ApplicationPageContainer.Contrainer.GetPage<LessonSettingsProgramModeModem>()
                    .GetModemsListObject().Cast<Src.UI.ModemListBoxItem>();
                cbModemPreset.SelectedIndex = 0;
            }
        }
    }
}
