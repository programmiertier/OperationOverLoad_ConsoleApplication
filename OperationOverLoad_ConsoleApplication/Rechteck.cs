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


        // gibt den Umfang des Rechtecks zurück
        public double umfang
        { get { return _umfang; } /* set { _umfang = 2 * (_breite + _laenge);  hier steht nicht value! } */ }

        public double flaeche
        { get { return _flaeche; } }

        public Rechteck(double breite, double laenge)
        {
            _breite = breite;
            _laenge = laenge;
            _umfang = 2 * (breite + laenge);
            _flaeche = breite * laenge;
        }

    }
}