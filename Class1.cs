using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Date
    {                                             //0  1   2   3   4   5   6   7   8   9   10  11  12
        private static readonly int[] yearin365 = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] yearin366 = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        // readonly mean array  or var will be intialized by only a constractor
        // static mean wa can use var in static by classname or constructor without using var name
        private readonly int day = 01;
        private readonly int month = 01;
        private readonly int year = 01;

        public Date(int day, int month, int year)
        {
            var isleap = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
            if(year >= 1 && year <=9999 && month<=1 && month <=12 )
            {   
                int[] days = isleap ? yearin366 : yearin365;
                if(day>=1 && day <= days[month])
                {
                    this.day = day;
                    this.month = month;
                    this.year = year;
                }
                // or by default give value to private variablues without using else
                //else
                //{
                //    this.day = 01;
                //    this.month = 01;
                //    this.year = 01;
                //}
                
            }

            


        }
        // constructor overloading
        // u could enter only year
        public Date(int year) : this(01,01,year)
        {
            
        }
        // u could enter only year and month
        public Date(int month ,int year) : this(01, month, year)
        {

        }
        public string getDate()
        {
            return $"{this.day.ToString().PadLeft(2, '0')}/{this.month.ToString().PadLeft(2, '0')}/{this.year.ToString().PadLeft(4, '0')}";
        }
    }

    public class Employee
    {
        // private constructor
        // called only in his class not in program 
        // to use constructor must make a method helping to call constructor
        // have strong security

        private  int id;
        private  string fname;
        private  string lname;
        public Employee() { }
        
        private Employee(int id,string name,string lname)
        {
            this.id = id;
            this.fname = name;
            this.lname = lname;
        }
        public static Employee create (int id, string name, string lname)
        {
            return new Employee(id,name,lname);
        }
        public string display()
        {
            return $" id : {id} name : {fname} {lname}";
        }
    }
}
