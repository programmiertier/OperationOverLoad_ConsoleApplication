using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OperationOverLoad_ConsoleApplication
{
    class Kreis : Figur
    {
        private double _radius;
        
        public double radius
        { get { return _radius; } }

        public Kreis(double radi)
        {
            _flaeche = Math.PI * Math.Pow(radi, 2);
            _umfang = 2 * radi * Math.PI;
            _radius = radi;
        }

        public static Kreis operator + (Kreis kr1, Kreis kr2)
        {
            Kreis tmp = new Kreis(0);
            tmp._flaeche = kr1._flaeche + kr2._flaeche;
            tmp._radius = Math.Sqrt (tmp._flaeche / Math.PI);
            return tmp;
        }

    }
}
