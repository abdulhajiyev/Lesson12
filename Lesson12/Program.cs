using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace Lesson12
{
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public int Score { get; set; }

        public override string ToString() => $@"
    Name: {Name}
    Surname: {Surname}
    BirthDate: {BirthDate.ToShortDateString()}
    Score: {Score}";
    }

    class Program
    {
        private static void Students(out List<Student> students)
        {
            students = new List<Student>
            {
                new Student
                {
                    Name = "Zahid", Surname = "Vahabzade",
                    BirthDate = new DateTime(2001, 11, 3), Score = 12
                },
                new Student
                {
                    Name = "Emin", Surname = "Velizade",
                    BirthDate = new DateTime(2001, 10, 14), Score = 11
                },
                new Student
                {
                    Name = "Yusif", Surname = "Rustemov",
                    BirthDate = new DateTime(2004, 3, 2), Score = 10
                },
                new Student
                {
                    Name = "Emiraslan", Surname = "Eliyev",
                    BirthDate = new DateTime(2002, 9, 29), Score = 9
                },
                new Student
                {
                    Name = "Nebi", Surname = "Nebili",
                    BirthDate = new DateTime(2002, 11, 17), Score = 8
                },
                new Student
                {
                    Name = "Ebdul", Surname = "Haciyev",
                    BirthDate = new DateTime(2001, 4, 29), Score = 7
                },
                new Student
                {
                    Name = "Nicat", Surname = "Ceferli",
                    BirthDate = new DateTime(2003, 10, 22), Score = 6
                },
                new Student
                {
                    Name = "Kenan", Surname = "Idayetov",
                    BirthDate = new DateTime(2001, 12, 28), Score = 5
                },
                new Student
                {
                    Name = "Ilqar", Surname = "Hesenzade",
                    BirthDate = new DateTime(1990, 11, 11), Score = 4
                },
            };
        }

        
        static void Main(string[] args)
        {
            
            List<Student> students;
            Students(out students);

            int[] numbers = new []{1, 4, 5, 7, 90, 80, 551,1,5};

            var list = numbers.Distinct();
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
                //list.ForEach(n => Console.WriteLine(n));
            // Lambda Expression
            // => (Lambda operator)



            /*var list = numbers.Where(x => x > 50).ToList();
            list.ForEach(l=> Console.WriteLine(l));*/
            
        }
    }
}