using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static static_method.student;

namespace static_method
{
    public class program
    {
        static void Main(string[] args)
        {
            //employee1 e1 = new employee1("emp1", 123434);
            //employee1 e2 = new employee1("emp2", 12343345);
            //employee1 e3 = new employee1("emp3", 123433434);
            //e1.CalculateSalary();
            //e2.CalculateSalary();
            //e3.CalculateSalary();
            //Console.WriteLine(e1);
            //Console.WriteLine(e2);
            //Console.WriteLine(e3);
            //Console.WriteLine(employee1.TotalCount());
           student student1 = new student("s1",76,34,43);
           student student2 = new student("s2",56,34,54);
            student student3 = new student("s3",57,24,67);
            student1.CalculateMarks();
            student2.CalculateMarks();
            student3.CalculateMarks();
            Console.WriteLine(student1);
            Console.WriteLine(student2);
            Console.WriteLine(student3);
            Console.WriteLine(student.TotalCount());

        }
    }
}
