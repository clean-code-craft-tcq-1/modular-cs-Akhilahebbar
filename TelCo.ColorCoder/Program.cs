using System;
using System.Diagnostics;
using System.Drawing;
namespace TelCo.ColorCoder
{
    class Program
    {

        private static void Main()
        {

            ColorPairMappingTests.TestGetColorPairFromNumber(4, new ColorPair(Color.White, Color.Brown));
            ColorPairMappingTests.TestGetColorPairFromNumber(5, new ColorPair(Color.White, Color.SlateGray));
            ColorPairMappingTests.TestGetColorPairFromNumber(23, new ColorPair(Color.Violet, Color.Green));

            ColorPairMappingTests.TestGetNumberFromColorPair(new ColorPair(Color.Yellow, Color.Green), 18);
            ColorPairMappingTests.TestGetNumberFromColorPair(new ColorPair(Color.Red, Color.Blue), 6);
        }
    }
}
