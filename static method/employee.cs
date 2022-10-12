//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Web;

//namespace static_method
//{
//    public class employee
//    {
//        private int id;
//        private string name;
//        private double salary;
//        private static int count;
//        public employee(string name, double salary)
//        {
//            count++;
//            this.id = count;
//            this.name = name;
//            this.salary = salary;
//        }
//        public static string TotalCount()
//        {
//            return $"Total count is {count}";
//        }
//        public override string ToString()
//        {
//            return $"Id:{id}Name:{name}Salary{salary}";
//        }
//    }
//}
