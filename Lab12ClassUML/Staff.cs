using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12ClassUML
{
    class Staff:Person
    {
        public string School { get; set; }
        public double Pay { get; set; }
        public Staff() {}
        public Staff(string name, string address, string school, double pay):base(name, address)
        {
            School = school;
            Pay = pay;
        }
        public override string ToString()
        {
            return base.ToString()+$" {School} {Pay}";
        }
    }
}
