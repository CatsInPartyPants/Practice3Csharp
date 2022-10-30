using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3Csharp
{
    internal class Human
    {
        protected string _firstName;
        protected string _lastName;
        DateTime _birthDay;

        public Human(string firstName, string lastName, DateTime birthDay)
        {
            _firstName = firstName;
            _lastName = lastName;
            _birthDay = birthDay;
        }

        public Human(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public override string ToString()
        {
            return $"Фамилия: {_lastName} " +
                $"Имя {_firstName}" +
                $"Дата рождения {_birthDay.ToShortDateString()}";
        }
    }

    class Employee : Human
    {
        double _salary;

        public Employee(string fname, string lname,
            double salary) : base(fname, lname)
        {
            _salary = salary;
        }

        public Employee(string fname, string lname, DateTime bDay,
            double salary) : base(fname, lname, bDay)
        {
            _salary = salary;
        }

        public override string ToString()
        {
            return base.ToString() + $"Зарплата: {_salary}";//используем метод родительского класса

        }
    }
}
