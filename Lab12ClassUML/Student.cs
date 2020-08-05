using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12ClassUML
{
    class Student:Person
    {
        public string Program { get; set; }
        public int Year { get; set; }
        public double Fee { get; set; }

        public Student() { }
        public Student(string name, string address, string program, int year, double fee):base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }

        public override string ToString()
        {
            return base.ToString()+$" {Program} {Year} {Fee}";
        }
    }
}
