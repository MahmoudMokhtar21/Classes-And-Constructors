// See https://aka.ms/new-console-template for more information
using ConsoleApp5;

Console.WriteLine("Hello, World!");
Date d = new Date(29, 02, 2001);
Date d2 = new Date(2000);
Console.WriteLine(d.getDate());  // 01/01/0001
Console.WriteLine(d2.getDate()); // 01/01/2000

// u have 2 ways to make objec intilizing 

//1st
//Employee employee = new Employee();
//employee.id = 20;
//employee.fname = "mmm";
//employee.lname = "assas";


//2nd
//Employee employee = new Employee
//{
//    id = 20,
//    fname = "asdsd",
//    lname = "dasds"
//};

// remember static make u call cons bt classname
Employee e = Employee.create(222, "mahmoud", "mokhtar");
Console.WriteLine(e.display());


