using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3Csharp
{
    internal abstract class Human1
    {
        protected string _firstName;
        protected string _lastName;
        DateTime _birthDay;

        public Human1(string firstName, string lastName, DateTime birthDay)
        {
            _firstName = firstName;
            _lastName = lastName;
            _birthDay = birthDay;
        }

        public abstract void Think();

        public virtual void Print()
        {
            Console.WriteLine($"Second name: {_lastName}" +
                $"Name: {_firstName}" +
                $"Birthday: {_birthDay.ToShortDateString()}");
        }
    }

    abstract class Learner: Human1
    {
        string _institution;
        protected Learner(string firstName, string lastName, DateTime birthDay, string instution) : base(firstName, lastName, birthDay)
        {
            _institution = instution;
        }

        public abstract void Study();

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Institution: {_institution}");
        }
    }

    class Student : Learner
    {
        string _groupName;
        public Student(string groupName, string firstName, string lastName, DateTime birthDay, string instution) : base(firstName, lastName, birthDay, instution)
        {
            _groupName = groupName;
        }

        public override void Study()
        {
            Console.WriteLine($"Im study in the university");
        }

        public override void Think()
        {
            Console.WriteLine($"Im thinking like a student");
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Учусь в {_groupName} группе");
        }
    }

    class SchoolChild : Learner
    {
        string _className;

        public SchoolChild(string className, string groupName, string firstName, string lastName, DateTime birthDay, string instution) : base(firstName, lastName, birthDay, instution)
        {
            _className = className;
        }

        public override void Study()
        {
            Console.WriteLine($"Im study in the school");
        }

        public override void Think()
        {
            Console.WriteLine($"Im thinking like a school child");
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Учусь в {_className} группе");
        }

    }


}
