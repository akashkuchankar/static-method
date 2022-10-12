//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace static_method
//{
//    internal class employee1
//    {
//        private int id;
//        private string name;
//        private double basicsalary;
//        private double hra, da, pf, netpaid;

//        private static int count;
        
//        public employee1(string name, double basicsalary)
//        {
//            count++;
//            this.id = count;
//            this.name = name;
//            this.basicsalary = basicsalary;
//        }
//        public static string TotalCount()
//        {
//            return $"Total count is {count}";
//        }
//        public void CalculateSalary()
//        {
//            hra = basicsalary * 0.40;
//            da = basicsalary * 0.20;
//            pf = basicsalary * 0.12;
//            netpaid = (hra + da + basicsalary) - pf;
//        }
       
//        public override string ToString()
//        {
//            return$"ID:{id} Name:{name} Salary:{basicsalary} netpaid: {netpaid}";
//        }
        
       
        
//    }
//}

