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
            /* blumenbeet.umfang = 0; // deswegen wird in Rechteck der setter ignoriert    // Abruf hierdurch vom Setter */
            WriteLine("Der Zaun um das Blumenbeet ist \t{0} Meter lang und hat eine Fläche von:\t{1}", blumenbeet.umfang, blumenbeet.flaeche);
            WriteLine(blumenbeet.bepflanzung);              // bepflanzung wird angezeigt
            
            ReadLine();
        }
    }
}
