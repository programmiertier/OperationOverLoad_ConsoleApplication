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
            Rechteck blumenbeet = new Rechteck(10, 15) { bepflanzung = "Gras" };       // string so hinzufügen, statt ein weiteres mal zu überladen
            /* blumenbeet.umfang = 0; // deswegen wird in Rechteck der setter ignoriert    // Abruf hierdurch vom Setter */
            WriteLine("Der Zaun um das Blumenbeet ist:\t{0} Meter lang", blumenbeet.umfang);
            WriteLine("Es müssen hier ganze {0,6:F2} m² Fläche begossen werden", blumenbeet.flaeche);
            WriteLine(blumenbeet.bepflanzung);              // bepflanzung wird angezeigt
            ReadLine();

            Kreis rund = new Kreis(10.5);
            WriteLine("Einmal um den Teich herum macht {0,6:F2} Meter gelaufen", rund.umfang);
            WriteLine("Der Seerosenteich hat eine Fläche von {0,6:F2} m²", rund.flaeche);
            WriteLine("Der Radius ist dann {0} m", rund.radius);
            ReadLine();

            Rechteck rasen = new Rechteck(40, 80) { bepflanzung = "Gras" };
            WriteLine("Der Linie um den Rasen ist:\t{0} Meter lang", rasen.umfang);
            WriteLine("Es müssen hier ganze {0,6:F2} m² Fläche begossen werden", rasen.flaeche);
            WriteLine(rasen.bepflanzung);
            ReadLine();

            double gesamtFlaeche = rasen.flaeche + blumenbeet.flaeche;
            WriteLine(gesamtFlaeche);
            WriteLine(rasen.flaeche + blumenbeet.flaeche);

            double gesamtUmfang = rasen.umfang + blumenbeet.umfang;
            WriteLine(gesamtUmfang);
            ReadLine();

            // neuesRechteck = rasen + blumenbeet;
                                        // Operatoren überladen, zusätzlich definieren was macht ein + zwischen zwei Objekten von Klasse Rechteck
            Rechteck neuesRechteck = rasen + blumenbeet;
             
            WriteLine("Die Gesamtlinie um Rasen und Blumenbeet sind :\t{0} Meter lang", neuesRechteck.umfang);
            WriteLine("Die Gesamtfläche von Rasen und Blumenbeet sind :\t{0} m²", neuesRechteck.flaeche);
            WriteLine("{0} mal {1}", neuesRechteck.breite, neuesRechteck.laenge);
            ReadLine();

            Kreis runder1 = new Kreis(1);
            WriteLine("Einmal um den Teich1 herum macht {0,6:F2} Meter gelaufen", runder1.umfang);
            WriteLine("Der Seerosenteich1 hat eine Fläche von {0,6:F2} m²", runder1.flaeche);
            WriteLine("Der Radius ist dann {0} m", runder1.radius);
            ReadLine();


            Kreis runder2 = new Kreis(1);
            WriteLine("Einmal um den Teich2 herum macht {0,6:F2} Meter gelaufen", runder2.umfang);
            WriteLine("Der Seerosenteich2 hat eine Fläche von {0,6:F2} m²", runder2.flaeche);
            WriteLine("Der Radius ist dann {0} m", runder2.radius);
            ReadLine();

            Kreis neuerKreis = runder1 + runder2;

            WriteLine("Doppelteich Fläche {0,6:F2} m²", neuerKreis.flaeche);
            WriteLine("Doppelteich Radius {0,4:F2} Meter", neuerKreis.radius);
        }
    }
}
