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
      
          for(int Pair_numb= 0; Pair_numb < colorMapMajor.Length*colorMapMinor.Length ; Pair_numb++)
          {  ColorPair pair = GetColorFromPairNumber(Pair_numb);
             String PairName = pair.ToString();
              PairNumberInString = PairNumber.ToString();
              Manual = Manual + PairNumberInString + ". " + PairName + " ";
          }
 Console.WriteLine(Manual);
        } 
     }
}
