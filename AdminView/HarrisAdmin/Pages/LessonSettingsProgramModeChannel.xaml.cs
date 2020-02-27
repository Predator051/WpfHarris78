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
using ProtobufChannel = LessonParametersSet.LessonParameters.Types.Program.Types.Mode.Types.Preset.Types.Channel;

namespace HarrisAdmin.Pages
{
    /// <summary>
    /// Логика взаимодействия для LessonsSettingsProgramModeChannel.xaml
    /// </summary>
    public partial class LessonsSettingsProgramModeChannel : Page
    {
        public LessonsSettingsProgramModeChannel()
        {
            InitializeComponent();
            gbChannelSettings.IsEnabled = false;
        }
        /*
         x:Name="checkMaxBandwidth" C
         x:Name="checkModulation" Con
         x:Name="checkTX" Content="" 
         x:Name="checkHailKey" Conten
         x:Name="checkMode" Content="
         x:Name="checkEnableSSbScan" 
         x:Name="checkNumber" Content
             */
        private void checkMaxBandwidth_Checked(object sender, RoutedEventArgs e)
        {
            var checkBox = (CheckBox)sender;
            bool isChecked = (bool)checkBox.IsChecked;
            var currItem = (Src.UI.ChannelItemListBox)lbChannels.SelectedItem;
            
            switch(checkBox.Name)
            {
                case "checkRX":
                    {
                        currItem.CheckRxFrequency = isChecked;
                        break;
                    }
                case "checkMaxBandwidth":
                    {
                        currItem.CheckMaxBandwidth = isChecked;
                        if (isChecked)
                        {
                            ((Src.UI.ChannelItemListBox)lbChannels.SelectedItem).Channel.maxBandwidth = (string)((ComboBoxItem)cbMaxBandWidth.SelectedItem).Content;
                        }
                        break;
                    }
                case "checkModulation":
                    {
                        currItem.CheckModulation = isChecked;
                        if (isChecked)
                        {
                            ((Src.UI.ChannelItemListBox)lbChannels.SelectedItem).Channel.maxBandwidth = (string)((ComboBoxItem)cbModulation.SelectedItem).Content;
                        }
                        break;
                    }
                case "checkTX":
                    {
                        currItem.CheckTxFrequency = isChecked;
                        break;
                    }
                case "checkHailKey":
                    {
                        currItem.CheckHailKey = isChecked;
                        break;
                    }
                case "checkMode":
                    {
                        currItem.CheckMode = isChecked;
                        break;
                    }
                case "checkEnableSSbScan":
                    {
                        currItem.CheckEnableSsbScan = isChecked;
                        break;
                    }
                case "checkNumber":
                    {
                        currItem.CheckNum = isChecked;
                        break;
                    }
            }
        }

        string GenerateName(int num)
        {
            string name = num < 10 ? "00" + num.ToString() : num < 100 ? "0" + num.ToString() : num.ToString();

            bool isContainWithSameName(string n)
            {
                foreach (var item in lbChannels.Items)
                {
                    if (item.ToString() == n) return true;
                }
                return false;
            }

            if (isContainWithSameName(name))
            {
                return GenerateName(num + 1);
            }

            return name;
        }

        private void btnAddChannel_Click(object sender, RoutedEventArgs e)
        {
            Src.UI.ChannelItemListBox item = new Src.UI.ChannelItemListBox(GenerateName(0));
            lbChannels.Items.Add(item);
        }

        private void lbChannels_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = lbChannels.SelectedItem;
            var channel = (Src.UI.ChannelItemListBox)item;
            if (item != null) 
            {
                gbChannelSettings.IsEnabled = true;    
                if (!string.IsNullOrEmpty(channel.Channel.hailKey))
                {
                    this.maskEditHailKey.Value = channel.Channel.hailKey;
                } 
                else
                {
                    this.maskEditHailKey.Value = "";
                }

                if (!string.IsNullOrEmpty(channel.Channel.rxFrequency))
                {
                    this.maskEditRxFrequency.Value = channel.Channel.rxFrequency;
                } 
                else
                {
                    this.maskEditRxFrequency.Value = "";
                }

                if (!string.IsNullOrEmpty(channel.Channel.txFrequency))
                {
                    this.maskEditTxFrequency.Value = channel.Channel.txFrequency;
                }
                else
                {
                    this.maskEditTxFrequency.Value = "";
                }

                if (!string.IsNullOrEmpty(channel.Channel.modulation))
                {
                    foreach (var itemModulation in cbModulation.Items)
                    {
                        if (itemModulation.ToString() == channel.Channel.modulation) cbModulation.SelectedItem = itemModulation;
                    }
                } 

                if (!string.IsNullOrEmpty(channel.Channel.maxBandwidth))
                {
                    foreach (var itemModulation in cbModulation.Items)
                    {
                        if (itemModulation.ToString() == channel.Channel.modulation) cbModulation.SelectedItem = itemModulation;
                    }
                } 

                this.chbMode.IsChecked = channel.Channel.mode;
                this.chbEnableSsbScan.IsChecked = channel.Channel.enableSsbScan;
                this.maskEditNumber.Value = channel.Channel.number;
                this.checkTX.IsChecked = channel.CheckTxFrequency;
                this.checkRX.IsChecked = channel.CheckRxFrequency;
                this.checkNumber.IsChecked = channel.CheckNum;
                this.checkModulation.IsChecked = channel.CheckModulation;
                this.checkMode.IsChecked = channel.CheckMode;
                this.checkMaxBandwidth.IsChecked = channel.CheckMaxBandwidth;
                this.checkHailKey.IsChecked = channel.CheckHailKey;
                this.checkEnableSSbScan.IsChecked = channel.CheckEnableSsbScan;

            } 
            else
            {
                gbChannelSettings.IsEnabled = false;
            }
        }

        private void maskEditNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            var currChannelItem = lbChannels.SelectedItem;

            var currChannel = (Src.UI.ChannelItemListBox)currChannelItem;
            if (currChannel == null) return;

            currChannel.Channel.number = maskEditNumber.Text.Trim(new char[] { '_' });
            lbChannels.Items.Refresh();
        }

        private void maskEditRxFrequency_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (maskEditRxFrequency.Text.Contains('_')) return;
            var currChannelItem = lbChannels.SelectedItem;

            var currChannel = (Src.UI.ChannelItemListBox)currChannelItem;
            currChannel.Channel.rxFrequency = maskEditRxFrequency.Text.Replace(",", ".") + " MHZ";
        }

        private void maskEditTxFrequency_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (maskEditTxFrequency.Text.Contains('_')) return;
            var currChannelItem = lbChannels.SelectedItem;

            var currChannel = (Src.UI.ChannelItemListBox)currChannelItem;
            currChannel.Channel.txFrequency = maskEditTxFrequency.Text.Replace(",", ".") + " MHZ";
        }

        private void cbModulation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var currChannelItem = lbChannels.SelectedItem;

            var currChannel = (Src.UI.ChannelItemListBox)currChannelItem;
            if (currChannel == null) return;

            currChannel.Channel.modulation = (string)((ComboBoxItem)cbModulation.SelectedItem).Content;
        }

        private void maskEditHailKey_TextChanged(object sender, TextChangedEventArgs e)
        {
            var currChannelItem = lbChannels.SelectedItem;

            var currChannel = (Src.UI.ChannelItemListBox)currChannelItem;
            if (currChannel == null) return;

            currChannel.Channel.hailKey = maskEditHailKey.Text.Trim(new char[] { '_' });
        }

        private void chbMode_Checked(object sender, RoutedEventArgs e)
        {
            var currChannelItem = lbChannels.SelectedItem;

            var currChannel = (Src.UI.ChannelItemListBox)currChannelItem;
            if (currChannel == null) return;

            currChannel.Channel.mode = true;
        }

        private void chbMode_Unchecked(object sender, RoutedEventArgs e)
        {
            var currChannelItem = lbChannels.SelectedItem;

            var currChannel = (Src.UI.ChannelItemListBox)currChannelItem;
            if (currChannel == null) return;

            currChannel.Channel.mode = false;
        }

        private void chbEnableSsbScan_Checked(object sender, RoutedEventArgs e)
        {
            var currChannelItem = lbChannels.SelectedItem;

            var currChannel = (Src.UI.ChannelItemListBox)currChannelItem;
            if (currChannel == null) return;

            currChannel.Channel.enableSsbScan = true;
        }

        private void chbEnableSsbScan_Unchecked(object sender, RoutedEventArgs e)
        {
            var currChannelItem = lbChannels.SelectedItem;

            var currChannel = (Src.UI.ChannelItemListBox)currChannelItem;
            if (currChannel == null) return;

            currChannel.Channel.enableSsbScan = false;
        }

        private void cbMaxBandWidth_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var currChannelItem = lbChannels.SelectedItem;

            var currChannel = (Src.UI.ChannelItemListBox)currChannelItem;
            if (currChannel == null) return;

            currChannel.Channel.maxBandwidth = (string)((ComboBoxItem)cbMaxBandWidth.SelectedItem).Content;
        }

        private void btnRemoveChannel_Click(object sender, RoutedEventArgs e)
        {
            var currChannelItem = lbChannels.SelectedItem;
            lbChannels.Items.Remove(currChannelItem);
        }

        public Google.Protobuf.Collections.RepeatedField<ProtobufChannel> GetProtobufChannelObjects()
        {
            Google.Protobuf.Collections.RepeatedField<ProtobufChannel> channels = new Google.Protobuf.Collections.RepeatedField<ProtobufChannel>();

            foreach(var item in lbChannels.Items)
            {
                var channel = (Src.UI.ChannelItemListBox)item;
                channels.Add(channel.SerializeToProtobuf());
            }

            return channels;
        }
    }
}
