using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using LessonParametersSet;

namespace HarrisAdmin.Pages
{
    /// <summary>
    /// Логика взаимодействия для LessonSettingsProgramComsecKeys.xaml
    /// </summary>
    public partial class LessonSettingsProgramComsecKeys : Page
    {
        public LessonSettingsProgramComsecKeys()
        {
            InitializeComponent();

            cbKeyType.ItemsSource = Enum.GetValues(typeof(Harris7800HMP.KeyModule.KeyType)).Cast<Harris7800HMP.KeyModule.KeyType>();
            cbKeyType.SelectedIndex = 0;

            this.gridKeyContent.IsEnabled = false;
        }
       
        string GenerateName(string prefix, int num)
        {
            string name = prefix + (num < 10 ? "0" + num.ToString() : num.ToString());
            
            bool isContainWithSameName(string n)
            {
                foreach (var item in lbKeys.Items)
                {
                    if (item.ToString() == n) return true;
                }
                return false;
            }

            if (isContainWithSameName(name))
            {
                return GenerateName(prefix, num+1);
            }

            return name;
        }
        
        private void btnAddKey_Click(object sender, RoutedEventArgs e)
        {
            Src.UI.KeyListBoxItem keyListBoxItem = new Src.UI.KeyListBoxItem(GenerateName("TEK", 1));
            keyListBoxItem.Key.type = Harris7800HMP.KeyModule.KeyType.Citadel1;

            lbKeys.Items.Add(keyListBoxItem);
        }

        private void lbKeys_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var currItem = (Src.UI.KeyListBoxItem)lbKeys.SelectedItem;
            if (currItem != null)
            {

                this.gridKeyContent.IsEnabled = true;
                this.maskEditName.Value = currItem.Key.keyName;
                this.maskEditKey.Value = currItem.Key.keyVal;
                if (!string.IsNullOrEmpty(currItem.Key.keyAws))
                {
                    this.maskEditAvs.Value = currItem.Key.keyAws;
                } 
                else
                {
                    this.maskEditAvs.Value = "";
                }

                foreach(var item in cbKeyType.Items)
                {
                    if ((Harris7800HMP.KeyModule.KeyType)item == currItem.Key.type)
                    {
                        cbKeyType.SelectedItem = item;
                    }
                }

                this.chbAvs.IsChecked = currItem.CheckAwsKey;
                this.chbCheckKey.IsChecked = currItem.CheckKey;
                this.chbCheckName.IsChecked = currItem.CheckName;
                this.chbCheckType.IsChecked = currItem.CheckType;
            }
        }

        private void cbKeyType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var currItem = cbKeyType.SelectedItem;
            var currKeyType = (Harris7800HMP.KeyModule.KeyType)currItem;
            if (currKeyType != Harris7800HMP.KeyModule.KeyType.Citadel1)
            {
                maskEditAvs.Value = "";
                maskEditAvs.IsEnabled = false;
            } 
            else
            {
                maskEditAvs.IsEnabled = true;
            }

            var currKeyItem = lbKeys.SelectedItem;

            if (currKeyItem != null)
            {
                var currKey = (Src.UI.KeyListBoxItem)currKeyItem;
                currKey.Key.type = currKeyType;
            }
        }

        private void maskEditName_TextChanged(object sender, TextChangedEventArgs e)
        {
            var currKeyItem = lbKeys.SelectedItem;

            var currKey = (Src.UI.KeyListBoxItem)currKeyItem;

            currKey.Key.keyName = maskEditName.Text;
            lbKeys.Items.Refresh();
        }

        private void maskEditKey_TextChanged(object sender, TextChangedEventArgs e)
        {
            var currKeyItem = lbKeys.SelectedItem;

            var currKey = (Src.UI.KeyListBoxItem)currKeyItem; 
            currKey.Key.keyVal = maskEditKey.Text.Trim(new char[] { '_' });
        }

        private void chbAvs_Checked(object sender, RoutedEventArgs e)
        {
            var key = (Src.UI.KeyListBoxItem)lbKeys.SelectedItem;
            key.CheckAwsKey = true;
            var currKey = (Src.UI.KeyListBoxItem)lbKeys.SelectedItem;
            currKey.Key.keyAws = maskEditAvs.Text.Trim(new char[] { '_' });
        }

        private void chbAvs_Unchecked(object sender, RoutedEventArgs e)
        {
            var key = (Src.UI.KeyListBoxItem)lbKeys.SelectedItem;
            key.CheckAwsKey = false;
        }

        private void maskEditAvs_TextChanged(object sender, TextChangedEventArgs e)
        {
            var currKeyItem = lbKeys.SelectedItem;

            var currKey = (Src.UI.KeyListBoxItem)currKeyItem;
            currKey.Key.keyAws = maskEditAvs.Text.Trim(new char[] { '_' });
        }

        public Google.Protobuf.Collections.RepeatedField<LessonParameters.Types.Program.Types.Comsec.Types.Key> GetProtobufKeysObject()
        {
            Google.Protobuf.Collections.RepeatedField<LessonParameters.Types.Program.Types.Comsec.Types.Key> 
                keysOut = new Google.Protobuf.Collections.RepeatedField<LessonParameters.Types.Program.Types.Comsec.Types.Key>();

            foreach(var item in lbKeys.Items)
            {
                var key = (Src.UI.KeyListBoxItem)item;
                keysOut.Add(key.SerializeToProtobuf());
            }

            return keysOut;
        }

        public List<Src.UI.KeyListBoxItem> GetKeysList()
        {
            List<Src.UI.KeyListBoxItem> keys = new List<Src.UI.KeyListBoxItem>();
            foreach (var item in lbKeys.Items)
            {
                var key = (Src.UI.KeyListBoxItem)item;
                keys.Add(key);
            }
            return keys;
        }

        private void chbCheckKey_Checked(object sender, RoutedEventArgs e)
        {
            bool checkStatus = (bool)((CheckBox)sender).IsChecked;
            var key = (Src.UI.KeyListBoxItem)lbKeys.SelectedItem;
            key.CheckKey = checkStatus;
            if (checkStatus)
            {
                key.Key.keyVal = maskEditKey.Text.Trim(new char[] { '_' });
            }
        }

        private void chbCheckType_Checked(object sender, RoutedEventArgs e)
        {
            bool checkStatus = (bool)((CheckBox)sender).IsChecked;
            var key = (Src.UI.KeyListBoxItem)lbKeys.SelectedItem;
            key.CheckType = checkStatus; 
            if (checkStatus)
            {
                key.Key.type = (Harris7800HMP.KeyModule.KeyType)cbKeyType.SelectedItem;
            }
        }

        private void chbCheckName_Checked(object sender, RoutedEventArgs e)
        {
            var key = (Src.UI.KeyListBoxItem)lbKeys.SelectedItem;
            key.CheckName = (bool)((CheckBox)sender).IsChecked;
        }
    }
}
