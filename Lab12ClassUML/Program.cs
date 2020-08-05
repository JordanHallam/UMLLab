using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Lab12ClassUML
{
    class Program
    {
        static void Main(string[] args)
        {
            Student newStudent = new Student("John", "333 weton park", "business", 1999, 2102.66);
            List<Person> schoolPeople = new List<Person>
            {
                new Student("Simon", "1234 Lolipop rd", "Library Science",1989,3605.23),
                new Student("Colin","444 e highway st", "Advertising and Public Relations", 1997,12360.76),
                new Staff("Ms.Reimveldt", "1332 trillium place", "Tobey Elementary",32401.97),
                new Staff("Mr. Hart", "604 Hassyampa blvd", "Arizona State University", 79888)
            };
            schoolPeople.Add(newStudent);
            
            foreach(Person bob in schoolPeople)
            {
                Console.WriteLine(bob.ToString());
            }
            //Console.WriteLine(newStudent.ToString());
            //Console.WriteLine(newStudent);

        }

        public static void AddStudent(List<Person> schoolPeople)
        {
            Console.WriteLine("Press 1. to add a student /n Press 2. to add staff");
            int choose=int.Parse(Console.ReadLine());

            if (choose == 1)
            {
                Console.WriteLine("What is the student's name?");
                string name = Console.ReadLine();

                Console.WriteLine("What is the student's address?");
                string address = Console.ReadLine();

                Console.WriteLine("What program is the student in?");
                string program = Console.ReadLine();

                Console.WriteLine("What year is the student in?");
                int year = int.Parse(Console.ReadLine());

                Console.WriteLine("What is the student's fee?");
                double fee=double.Parse(Console.ReadLine());

                Student addedStudent = new Student(name, address, program, year, fee);
                schoolPeople.Add(addedStudent);
            }
            else if (choose == 2)
            {
                Console.WriteLine("What is the staff member's name?");
                string name = Console.ReadLine();

                Console.WriteLine("What is the address of the staff member?");
                string address = Console.ReadLine();

                Console.WriteLine("Which school does the staff member work at?");
                string school=Console.ReadLine();

                Console.WriteLine("What is the staff member's salary?");
                double salary = double.Parse(Console.ReadLine());

                Staff addedStaff = new Staff(name, address, school, salary);
                schoolPeople.Add(addedStaff);
            }
            else
            {
                Console.WriteLine("Please try again and enter either 1. or 2.");
            }
        }
    }
}
