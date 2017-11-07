using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OperationOverLoad_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Rechteck blumenbeet = new Rechteck(10, 15) { bepflanzung = "Rosen" };       // string so hinzufügen, statt ein weiteres mal zu überladen
            blumenbeet.umfang = 200.5;
            WriteLine("Der Zaun um das Blumenbeet ist {0} Meter lang", blumenbeet.umfang);
            WriteLine(blumenbeet.bepflanzung);      // bepflanzung wird angezeigt

            ReadLine();
        }
    }
}
