using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace static_method
{
    public class student
    {

        private int rollno;
        private string name;
        private double total;
        private double s1, s2, s3;
        private double percentage;

        private static int count;

        public student(string name,double s1,double s2,double s3)
        {
            count++;
            this.rollno = count;
            this.name = name;
            this.s1 = s1;
            this.s2 = s2;   
            this.s3 = s3;   
        }
        public static string TotalCount()
        {
            return $"Total count is {count}";
        }
        public void CalculateMarks()
        {

            total = s1 + s2 + s3;
            percentage = (total * 100) / 300;
        }

        public override string ToString()
        {
            return $"ID:{rollno} Name:{name} total:{total} percentage: {percentage}";
        }




    }
}
