using Practice3Csharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3Csharp
{
    class Student1: IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int CompareTo(object obj)
        {
            if(obj is Student1)
            {
                return LastName.CompareTo((obj as Student1).LastName);
            }
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }


    }
    class Auditory : IEnumerable
    {
        Student1[] students =
        {
            new Student1 {FirstName = "Ivan", LastName = "Ivanov"},
            new Student1 {FirstName = "Petr", LastName = "Petrov"},
            new Student1 {FirstName = "Elena", LastName = "Elenova"},
        };

        IEnumerator IEnumerable.GetEnumerator()
        {
            return students.GetEnumerator();
        }
        public void Sort()
        {
            Array.Sort(students);
        }
    }

}