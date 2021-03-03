using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    public  class ColorPairMappingTests
    {
        public static void TestGetColorPairFromNumber(int pairNumber,ColorPair ExpectedColor)
        {
            ColorPair colorpair= ColorPairMapper.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, colorpair);
            Debug.Assert(colorpair.Major == ExpectedColor.Major);
            Debug.Assert(colorpair.Minor == ExpectedColor.Minor);
        }
        public static void TestGetNumberFromColorPair(ColorPair colorpair, int ExpectedNumber)
        {
            ColorPair testPair = new ColorPair(colorpair.Major, colorpair.Minor);
            int pairNumber = ColorPairMapper.GetPairNumberFromColor(testPair);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair, pairNumber);
            Debug.Assert(pairNumber == ExpectedNumber);
        }

    }
}

