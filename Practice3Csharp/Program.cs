using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Employee employee = new Employee("Ivan", "Ivanov", 6000);
            Console.WriteLine(employee);

            Employee employee1 = new Employee("Petr", "Petrov",
                new DateTime(1990, 2, 16), 30000);
            Console.WriteLine(employee1);
            

            Passport passport = new Passport(1110, 781404);
            passport.Show();
            Console.WriteLine(passport);

            ForeignPassport foreignPassport = new ForeignPassport(1110, 781404, 123123, "VISA");
            foreignPassport.Show();
            Console.WriteLine(foreignPassport);
            

            Learner[] learners =
            {
                new Student("15f88", "Ivan", "Ivanov", new DateTime(1999, 1, 15), "IT TOP"),
                new SchoolChild("6 B", "first group", "Petr", "Petrov", new DateTime(2005, 6, 28), "45 school")
            };

            foreach(Learner learner in learners)
            {
                learner.Print();
                learner.Think();
                learner.Study();
            }
           

            Auditory auditory = new Auditory();
           
            foreach(Student1 student in auditory)
            {
                Console.WriteLine(student);
            }
            auditory.Sort();
            foreach (Student1 student in auditory)
            {
                Console.WriteLine(student);
            }
             */

            Figure[] figure =
            {
                new Rectangle(3, 8),
                new Triangle(6,12),
                new Circle(5)
            };

            foreach(Figure f in figure)
            {
                f.Area();
                if(f is Triangle)
                {
                    (f as Triangle).Show();
                }
            }

            

            Console.ReadKey();
        }
    }
}
