using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{ 
   partial class Program
    { 
     public static void RefManual()
     {      int PairNumber = 0;
            string Manual = "";
            string PairNumberInString = "";
      
          for(int PairNumber= 0; PairNumber < colorMapMajor.Length*colorMapMinor.Length ; PairNumber++)
          {  ColorPair pair = GetColorFromPairNumber(PairNumber);
             String PairName = pair.ToString();
              PairNumberInString = PairNumber.ToString();
              Manual = Manual + PairNumberInString + ". " + PairName + " ";
          }
 Console.WriteLine(Manual);
        } 
     }
}
