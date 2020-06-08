using System.Drawing;

namespace WinForm.Helper
{
    public static class PriceColorHelper
    {
        public static Color GetPriceColor(decimal price)
        {
            switch (price)
            {
                case var value when (value > 100):
                    return Color.DarkRed;
                case var value when (value > 50):
                    return Color.Red;
                case var value when (value > 30):
                    return Color.IndianRed;
                case var value when (value > 15):
                    return Color.Black;
                default:
                    return Color.Green;
            }
        }
    }
}
