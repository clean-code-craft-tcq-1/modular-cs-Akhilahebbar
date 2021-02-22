
using System;
using System.Diagnostics;
using System.Drawing;


namespace TelCo.ColorCoder
{
  
 public  class ColorPair
    {
        public Color major;
        public Color minor;
        public static Color[] MapMajor;
        public static Color[] MapMinor;
        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", major.Name, minor.Name);
        }
        public static ColorPair GetColorFromPairNumber(int pairNumber)
        {
            // The function supports only 1 based index. Pair numbers valid are from 1 to 25
            int minorSize = MapMinor.Length;
            int majorSize =MapMajor.Length;
            if (pairNumber < 1 || pairNumber > minorSize * majorSize)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }

            // Find index of major and minor color from pair number
            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorSize;
            int minorIndex = zeroBasedPairNumber % minorSize;

            // Construct the return val from the arrays
            ColorPair pair = new ColorPair()
            {
                major =MapMajor[majorIndex],
                minor =MapMinor[minorIndex]
            };

            // return the value
            return pair;
        }
        public static int GetPairNumberFromColor(ColorPair pair)
        {
            // Find the major color in the array and get the index
            int majorIndex = -1;
            for (int i = 0; i <MapMajor.Length; i++)
            {
                if (MapMajor[i] == pair.major)
                {
                    majorIndex = i;
                    break;
                }
            }

            // Find the minor color in the array and get the index
            int minorIndex = -1;
            for (int i = 0; i < MapMinor.Length; i++)
            {
                if (MapMinor[i] == pair.minor)
                {
                    minorIndex = i;
                    break;
                }
            }
            // If colors can not be found throw an exception
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }

            // Compute pair number and Return  
            // (Note: +1 in compute is because pair number is 1 based, not zero)
            return (majorIndex * MapMinor.Length) + (minorIndex + 1);
        }
    }
}

