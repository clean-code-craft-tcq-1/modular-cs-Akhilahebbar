using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class Program
    {
        static Program()
        {
            ColorPair.MapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            ColorPair.MapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }

        private static void Main(string[] args)
        {
            int pairNumber = 4;
            ColorPair testPair1 = ColorPair.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.Major == Color.White);
            Debug.Assert(testPair1.Minor == Color.Brown);

            pairNumber = 5;
            testPair1 = ColorPair.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.Major == Color.White);
            Debug.Assert(testPair1.Minor == Color.SlateGray);

            pairNumber = 23;
            testPair1 = ColorPair.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.Major == Color.Violet);
            Debug.Assert(testPair1.Minor== Color.Green);

            ColorPair testPair2 = new ColorPair() { Major = Color.Yellow, Minor = Color.Green };
            pairNumber = ColorPair.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
            Debug.Assert(pairNumber == 18);

            testPair2 = new ColorPair() { Major = Color.Red, Minor = Color.Blue };
            pairNumber = ColorPair.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}", testPair2, pairNumber);
            Debug.Assert(pairNumber == 6);
        }
    }
}
