using System;
using System.Drawing;
namespace TelCo.ColorCoder
{
    public  class ColorPair
    {
        public Color major, minor;
        public static Color[] MapMajor, MapMinor;
        public static ColorPair GetColorFromPairNumber(int pairNumber)
        {
          int minorSize = MapMinor.Length;
            int majorSize =MapMajor.Length;
            if (pairNumber < 1 || pairNumber > minorSize * majorSize)
            {
                throw new ArgumentOutOfRangeException(string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }
         int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorSize;
            int minorIndex = zeroBasedPairNumber % minorSize;
          ColorPair pair = new ColorPair()
            {
                major =MapMajor[majorIndex],  minor =MapMinor[minorIndex]
            }; // return the value
            return pair;
        }
        public static int GetPairNumberFromColor(ColorPair pair)
        {
            int minorColorIndex = GetColorIndex(pair.major, MapMinor);
            int majorColorIndex = GetColorIndex(pair.minor, MapMajor);
            if (minorColorIndex == -1 || majorColorIndex == -1)
            {
                throw new ArgumentException($"Unknown Colors: {pair}");
            }
            return (majorColorIndex * MapMinor.Length) + (minorColorIndex + 1);
        }
  public static int GetColorIndex(Color pair, Color[] colorMap)
        {
            int index = -1;
            for (int i = 0; i < colorMap.Length; i++)
            {
                if (colorMap[i] == pair)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
 }
}
