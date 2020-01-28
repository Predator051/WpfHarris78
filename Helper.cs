using System;
using System.Drawing;
using System.Linq;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Harris7800HMP
{
    public class Helper
    {
        public static string emptySpaceString = "                                            ";
        public static string CenterString(string str, string insertString)
        {
            var middleNumInsertString = insertString.Length / 2;
            var middleNumStr = str.Length / 2;

            var firstPart = str.Substring(0, middleNumStr - middleNumInsertString);
            var secondPart = str.Substring(middleNumStr + middleNumInsertString);
            return firstPart + insertString + secondPart;
        }

        public static int CalcCenterIndent(int textLength, int lineLength)
        {
            var midTextLength = textLength / 2;
            var midLineLength = lineLength / 2;
            var res = midLineLength - midTextLength;
            return res < 0 ? 0 : res;
        }

        public static ImageSource bitmapTpImageSource(Bitmap image)
        {
            return System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                image.GetHbitmap(),
                IntPtr.Zero,
                System.Windows.Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}
