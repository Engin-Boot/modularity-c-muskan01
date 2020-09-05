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
 
          for(int MajorColorno= 0; MajorColorno < colorMapMajor.Length ; MajorColorno++)
          {
            for(int MinorColorno= 0; MinorColorno < colorMapMinor.Length ; MinorColorno++)
              {   
              string majorcolorName = colorMapMajor[MajorColorno];
              string minorcolorName = colorMapMinor[MinorColorno];      
              PairNumber = PairNumber + 1;
              PairNumberInString = PairNumber .ToString();
              Manual = Manual + PairNumberInString + ". " + "Major: " + majorcolorName + ", Minor: " + minorcolorName + "\n";
              }
          }
 Console.WriteLine(Manual);
        } 
     }
}
