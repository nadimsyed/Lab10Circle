using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab10
{
    class Validator
    {
        private double db;

        public double Db { get => db; set => db = value; }

        public bool Checker(string x)
        {
            return double.TryParse(x, out double work);
        }

        public Validator(string input)
        {
            Checker(input);
        }
    }
}
