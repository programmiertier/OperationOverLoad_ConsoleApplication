using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OperationOverLoad_ConsoleApplication
{
    public class Rechteck : Figur
    {
        private double _breite;
        private double _laenge;
        private string _bepflanzung;

        public string bepflanzung
        { get { return "Das Beet ist bepflanzt mit " + _bepflanzung; } set { _bepflanzung = value; } }

        public double breite
        {
            get
            {
                return _breite;
            }

            set
            {
                _breite = value;
            }
        }

        public double laenge
        {
            get
            {
                return _laenge;
            }

            set
            {
                _laenge = value;
            }
        }


        // gibt den Umfang des Rechtecks zurück

        public Rechteck(double breite, double laenge)
        {
            _breite = breite;
            _laenge = laenge;
            _umfang = 2 * (breite + laenge);
            _flaeche = breite * laenge;
        }
                            // typ der entsteht welches Rechenzeichen   Beteiligten
        public static Rechteck operator         +                       (Rechteck eck1, Rechteck eck2)
        {
            Rechteck tmp = new Rechteck(0, 0);
            tmp._flaeche = eck1.flaeche + eck2.flaeche;
            tmp._umfang = eck1.umfang + eck2.umfang;
            return tmp;
        }
    }
}