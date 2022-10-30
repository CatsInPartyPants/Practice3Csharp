using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3Csharp
{
    internal class Passport
    {
        int _serial;
        int _number;

        public Passport(int serial, int number)
        {
            _serial = serial;
            _number = number;
        }

        public override string ToString()
        {
            return $"Серия: {_serial} Номер: {_number}";
        }

        public void Show()
        {
            Console.WriteLine("Method by Passport class");
        }
    }

    internal class ForeignPassport : Passport
    {
        int _numForeignPass;
        string _visa;
        public ForeignPassport(int serial, int number, int numForeignPass, string visa) : base(serial, number)
        {
            _numForeignPass = numForeignPass;
            _visa = visa;
        }

        public override string ToString()
        {
            return $"Данные паспорта: " + base.ToString()
                + $"\n данные загранпаспорта: {_numForeignPass}, "
                + $"Виза: {_visa}";
        }
    }
}
