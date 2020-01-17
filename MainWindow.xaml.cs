using Harris7800HMP;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfHarris78
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public enum ButtonKey
        {
            VOLUME_PLUS,
            VOLUME_MINUS,
            CLR,
            UPDATE,
            OPT,
            SQL,
            CALL,
            LT,
            ZERO,
            PGM,
            LEFT,
            RIGTH,
            DOWN,
            UP,
            PRE_PLUS,
            PRE_MINUS,
            ENT, 
            MODE
        }

        public static Dictionary<ButtonKey, string> buttonKeyString = new Dictionary<ButtonKey, string>()
        {
            { ButtonKey.VOLUME_MINUS, "VOLUME_MINUS" },
            { ButtonKey.VOLUME_PLUS, "VOLUME_PLUS" },
            { ButtonKey.CLR, "CLR" },
            { ButtonKey.UPDATE, "UPDATE" },
            { ButtonKey.OPT, "OPT" },
            { ButtonKey.SQL, "SQL" },
            { ButtonKey.CALL, "CALL" },
            { ButtonKey.LT, "LT" },
            { ButtonKey.ZERO, "ZERO" },
            { ButtonKey.PGM, "PGM" },
            { ButtonKey.LEFT, "LEFT" },
            { ButtonKey.RIGTH, "RIGTH" },
            { ButtonKey.DOWN, "DOWN" },
            { ButtonKey.UP, "UP" },
            { ButtonKey.PRE_PLUS, "PRE_PLUS" },
            { ButtonKey.PRE_MINUS, "PRE_MINUS" },
            { ButtonKey.ENT, "ENT" },
            { ButtonKey.MODE, "MODE" },

        };
        public static Switcher switcher = new Switcher();
        public static Action timerAction;
        private RadioStation radioStation;
        private Widget currentWidget;
        private PrivateFontCollection displayFonts = new PrivateFontCollection();
        private WidgetQueue queueWidget = new WidgetQueue();

        public static DispatcherTimer transitionTimer = new DispatcherTimer();
        public static DispatcherTimer timer1 = new DispatcherTimer();
        public static DispatcherTimer timerOn = new DispatcherTimer();
        public static DispatcherTimer timerAnimation = new DispatcherTimer();

        public static String keyNeed = "1379";
        public static String keyEntered = "";
        
        public static MainWindow currObject;
        
        private FileInfo fileLesson;
        public RichTextBox lessonsInfo = new RichTextBox();
        private RadioModules externalModules = new RadioModules();
        private Color displayColor = Color.FromRgb(138, 164, 0);
        private Color displayTextColor = Color.FromRgb(138, 164, 0);

        public WidgetQueue QueueWidget => queueWidget;
        public MainWindow()
        {
            InitializeComponent();
            MainWindow.currObject = this;

            this.btCall.Name = buttonKeyString[ButtonKey.CALL];
            this.btClr.Name = buttonKeyString[ButtonKey.CLR];
            this.btDown.Name = buttonKeyString[ButtonKey.DOWN];
            this.btEnt.Name = buttonKeyString[ButtonKey.ENT];
            this.btLeft.Name = buttonKeyString[ButtonKey.LEFT];
            this.btLt.Name = buttonKeyString[ButtonKey.LT];
            this.btMode.Name = buttonKeyString[ButtonKey.MODE];
            this.btOpt.Name = buttonKeyString[ButtonKey.OPT];
            this.btPgm.Name = buttonKeyString[ButtonKey.PGM];
            this.btPreDown.Name = buttonKeyString[ButtonKey.PRE_MINUS];
            this.btPreUp.Name = buttonKeyString[ButtonKey.PRE_PLUS];
            this.btRigth.Name = buttonKeyString[ButtonKey.RIGTH];
            this.btSql.Name = buttonKeyString[ButtonKey.SQL];
            this.btUp.Name = buttonKeyString[ButtonKey.UP];
            this.btUpdate.Name = buttonKeyString[ButtonKey.UPDATE];
            this.btVolDown.Name = buttonKeyString[ButtonKey.VOLUME_MINUS];
            this.btVolUp.Name = buttonKeyString[ButtonKey.VOLUME_PLUS];
            this.btZero.Name = buttonKeyString[ButtonKey.ZERO];


            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            switcher.InitToOff();
            displayFonts.AddFontFile(@"fonts\pixelmix.ttf");
            richDispley.FontFamily = new FontFamily(displayFonts.Families[0].Name);
            richDispley.FontWeight = FontWeight.FromOpenTypeWeight(500);
            richDispley.Background = new SolidColorBrush(displayColor);

            radioStation = new RadioStation(switcher);
            currentWidget = WidgetInit.InitDefaultWidgets(radioStation);

            WidgetTextToRichText(currentWidget);
            timer1.Interval = new TimeSpan(0,0,0,0,500);
            timer1.Tick += timer1_Tick;
            timerAnimation.Interval = new TimeSpan(0, 0, 0, 1);
            //fileLesson = fLesson;
            //richDisplay.BackColor = displayColor;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            WidgetTextToRichText(currentWidget);
        }
        private void WidgetTextToRichText(Widget currWidget)
        {
            if (radioStation.IsOff())
            {
                //richDisplay.Clear();
                timer1.Stop();
                return;
            }

            if (currWidget.MoveTo != null)
            {
                currentWidget = currWidget.MoveTo;
                if (currentWidget.MoveTo != null)
                {
                    currentWidget.MoveTo = null;
                }
            }

            currentWidget.Update();
            var lines = currentWidget.ToLines();
            //richDisplay.Text = string.Join("\n", lines);

            FlowDocument myFlowDoc = new FlowDocument();

            var line1 = new Paragraph(new Run(lines[0]));
            line1.Name = "line1";
            var line2 = new Paragraph(new Run(lines[1]));
            line2.Name = "line2";
            var line3 = new Paragraph(new Run(lines[2]));
            line3.Name = "line3";
            var line4 = new Paragraph(new Run(lines[3]));
            line4.Name = "line4";


            myFlowDoc.Blocks.Add(line1);
            myFlowDoc.Blocks.Add(line2);
            myFlowDoc.Blocks.Add(line3);
            myFlowDoc.Blocks.Add(line4);

            richDispley.Document = myFlowDoc;

            if (lines.Length > 0)
            {
                selectTextRichDisplay(0, lines[0].Length);
                line1.FontSize = currentWidget.LineSize[0];
                line1.Margin = new Thickness(0, 0, 0, currentWidget.LineCharOffset[0]);

            }
            if (lines.Length > 1)
            {
                selectTextRichDisplay(lines[0].Length + 1, lines[1].Length);
                line2.FontSize = currentWidget.LineSize[1];
                line2.Margin = new Thickness(0, 0, 0, currentWidget.LineCharOffset[1]);
            }
            if (lines.Length > 2)
            {
                selectTextRichDisplay(lines[0].Length + lines[1].Length + 2, lines[2].Length);
                line3.FontSize = currentWidget.LineSize[2];
                line3.Margin = new Thickness(0, 0, 0, currentWidget.LineCharOffset[2]);
                //line3.LineHeight = currentWidget.LineCharOffset[2]
            }
            if (lines.Length > 3)
            {
                selectTextRichDisplay(lines[0].Length + lines[1].Length + lines[2].Length + 3, lines[3].Length);
                line4.FontSize = currentWidget.LineSize[3];
                line4.Margin = new Thickness(0, 0, 0, currentWidget.LineCharOffset[3]);
            }
            if (currentWidget.ActiveParam() != null)
            {
                var activeParams = currentWidget.GetActiveParamsBy();
                foreach (var param in activeParams)
                {
                    if (param.X == 1) selectActiveParam(param, line1);
                    if (param.X == 2) selectActiveParam(param, line2);
                    if (param.X == 3) selectActiveParam(param, line3);
                    if (param.X == 4) selectActiveParam(param, line4);
                }
            }

        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (radioStation.IsOff())
            {
#if DEBUG
                timerOn.Interval = new TimeSpan(0,0,0,0,1);
#elif !DEBUG
                timerOn.Interval = new TimeSpan(0,0,0,1,500);
#endif
                timerOn.Tick += timer2_Tick;
                timerOn.Start();
            }
            radioStation.NextState();
            var pBox = (Image)sender;
            pBox.Source = switcher.GetBitmapSource();
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            pbOn.Visibility = Visibility.Visible;
            if (radioStation.OnSteps == RadioStation.SwitchOnSteps.AfterInit)
            {
                radioStation.OnSteps = RadioStation.SwitchOnSteps.Logo;
                pbOn.Visibility = Visibility.Hidden;
                ((DispatcherTimer)sender).Stop();
                timer1.Start();
                return;
            }
            switch (radioStation.OnSteps)
            {
                case RadioStation.SwitchOnSteps.Logo:
                    {
                        pbOn.Source = Helper.bitmapTpImageSource(Properties.Resources.powerOnLogo);
                        radioStation.OnSteps++;
                        break;
                    }
                case RadioStation.SwitchOnSteps.Model:
                    {
                        pbOn.Source = Helper.bitmapTpImageSource(Properties.Resources.powerOnModel);
                        radioStation.OnSteps++;
                        break;
                    }
                case RadioStation.SwitchOnSteps.Init:
                    {
                        pbOn.Source = Helper.bitmapTpImageSource(Properties.Resources.powerOnInit);
                        radioStation.OnSteps++;
                        break;
                    }
            }


        }

        public void SetBrigth(int value)
        {
            byte bValue20 = Convert.ToByte(value * 20);
            byte bValue25 = Convert.ToByte(value * 25);
            displayColor = Color.FromRgb(bValue20, bValue25, displayColor.B);
            displayTextColor = Color.FromRgb(bValue20, bValue25, displayColor.B);
            richDispley.Background = new SolidColorBrush(displayColor);
            richDispley.Selection.ApplyPropertyValue(TextElement.ForegroundProperty, new SolidColorBrush(displayTextColor));
        }

        public void SetContrast(int value)
        {
            byte bValueR = Convert.ToByte(displayColor.R * value / 100);
            byte bValueG = Convert.ToByte(displayColor.G * value / 100);
            richDispley.Background = new SolidColorBrush(Color.FromRgb(bValueR, bValueG, displayColor.B));
        }

        public void StartShowWidgetQueue(int interval = 1000)
        {
            int seconds = interval / 1000;
            int millseconds = interval % 1000;
            timerAnimation.Interval = new TimeSpan(0,0,0, seconds, millseconds);
            timerAnimation.Tick += timerAnimation_Tick;
            timer1.Stop();
            timerAnimation.Start();
        }
        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            var next = queueWidget.Next();
            if (next == null)
            {
                timer1.Start();
                ((DispatcherTimer)sender).Stop();
                queueWidget.Clear();
                return;
            }

            currentWidget = next;
            WidgetTextToRichText(next);
        }
        public static void StartTimer()
        {
            transitionTimer.Interval = new TimeSpan(0, 0, 0, 2, 0);
            transitionTimer.Tick += trans_timer_Tick;
            transitionTimer.Start();
        }

        private static void trans_timer_Tick(object sender, EventArgs e)
        {
            ((DispatcherTimer)sender).Stop();
            timerAction?.Invoke();
        }
        private void btMouseEnter(object sender, MouseEventArgs e)
        {
            var btn = (System.Windows.Controls.Button)sender;
            btn.Opacity = 0.50;
        }

        private void btMouseLeave(object sender, MouseEventArgs e)
        {
            var btn = (System.Windows.Controls.Button)sender;
            btn.Opacity = 0.00;
        }

        private void btVolUp_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Click");
            FlowDocument myFlowDoc = new FlowDocument();

            myFlowDoc.Blocks.Add(new Paragraph(new Run("Paragraph 1")));
            myFlowDoc.Blocks.Add(new Paragraph(new Run("Paragraph 2")));
            myFlowDoc.Blocks.Add(new Paragraph(new Run("Paragraph 3")));
            myFlowDoc.Blocks.Add(new Paragraph(new Run("Paragraph 3")));

            richDispley.Document = myFlowDoc;

            richDispley.Selection.Select(
                richDispley.Document.ContentStart.GetPositionAtOffset(10),
                richDispley.Document.ContentStart.GetPositionAtOffset(20));

            richDispley.Selection.ApplyPropertyValue(TextElement.BackgroundProperty, new SolidColorBrush(Colors.Blue));
            richDispley.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);

            Debug.WriteLine(richDispley.Selection.Text);

        }
        
        private void selectTextRichDisplay(int start, int end)
        {
            var pos1 = richDispley.Document.ContentStart.GetPositionAtOffset(start, LogicalDirection.Forward);
            richDispley.Selection.Select(pos1, pos1.GetPositionAtOffset(end, LogicalDirection.Backward));
        }

        private void selectActiveParam(Param param, Paragraph paragraph)
        {
            TextRange allText = new TextRange(richDispley.Document.ContentStart, richDispley.Document.ContentEnd);
            string[] lines = allText.Text.Split(new char[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);

            var pos1 = paragraph.ContentStart.GetPositionAtOffset(param.Y + 1 + param.ActiveFrom, LogicalDirection.Forward);
            richDispley.Selection.Select(pos1, pos1.GetPositionAtOffset(param.ActiveTo, LogicalDirection.Backward));

            richDispley.Selection.ApplyPropertyValue(TextElement.BackgroundProperty, new SolidColorBrush(Colors.Black));
            richDispley.Selection.ApplyPropertyValue(TextElement.ForegroundProperty, new SolidColorBrush(displayTextColor));
            //var t = richDispley.Selection.Text;

            /*
             * int indexFrom = 2;
            for(int i = 0; i < lines.Length; i++)
            {
                if (param.X - 1 == i)
                {
                    //indexFrom += param.Y + 2;
                    //indexFrom += param.ActiveFrom;
                    //selectTextRichDisplay(indexFrom, param.ActiveTo);
                    //var tt = richDispley.CaretPosition.Paragraph.Name;
                    //var t = richDispley.Selection.Text;
                    //richDispley.Selection.ApplyPropertyValue(TextElement.BackgroundProperty, new SolidColorBrush(Colors.Black));
                    ////richDispley.Selection.ApplyPropertyValue(
                    indexFrom += param.Y + 2;
                    indexFrom += param.ActiveFrom;
                }
                indexFrom += lines[i].Length + 2;
            }
                    var activeParam = param;
                    var pText = activeParam.Text;
                    var index = richDisplay.Lines[activeParam.X - 1].IndexOf(pText, StringComparison.Ordinal);
                    for (var i = 0; i < richDisplay.Lines.Length && i < activeParam.X - 1; i++)
                    {
                        index += richDisplay.Lines[i].Length + 1;
                    }
                    index += activeParam.ActiveFrom;
                    richDisplay.Select(index, activeParam.ActiveTo);
                    richDisplay.SelectionBackColor = Color.Black;
                    richDisplay.SelectionColor = displayTextColor; 
            */
        }

        private void btKeyBoard_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.Button btn = (System.Windows.Controls.Button)sender;
            currentWidget.BtnClick(btn.Name, radioStation);
            WidgetTextToRichText(currentWidget);
        }

        private void richDispley_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
