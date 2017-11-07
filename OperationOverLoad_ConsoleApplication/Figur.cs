using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OperationOverLoad_ConsoleApplication
{
    public class Figur
    {
        protected double _umfang;
        protected double _flaeche;

        public double umfang
        { get { return _umfang; } }

        public double flaeche
        { get { return _flaeche; } }
    }
}