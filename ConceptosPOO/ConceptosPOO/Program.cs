

using ConceptosPOO;

Console.WriteLine("POO Conceptos!");
Console.WriteLine("==============");

//try
//{
//    Console.WriteLine(new Date(2023, 22, 03));
//    Console.WriteLine(new Date(2023, 9, 23));
//    Console.WriteLine(new Date(2023, 18, 45));
//}
//catch (Exception error)
//{

//    Console.WriteLine(error.Message); 
//}

Employee employee1 = new SalaryEmployee()
{
    Id = 1,
    FirstName = "Danilo",
    LastName = "Lucena",
    BirthDay = new Date(1994,11,02),
    HiringDate = new Date(2022,03,01),
    IsActive = true,
    Salary = 350000
};
//Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    Id = 2,
    FirstName = "Giuliano",
    LastName = "Lucena",
    BirthDay = new Date(1995, 12, 13),
    HiringDate = new Date(2020, 05, 11),
    IsActive = true,
    CommissionPercentaje = 0.03F,
    Sales=200000M,
};
//Console.WriteLine(employee2);

Employee employee3 = new HourlyEmployee()
{
    Id = 3,
    FirstName = "Delfina",
    LastName = "Lucena",
    BirthDay = new Date(1998, 04, 22),
    HiringDate = new Date(2021, 08, 10),
    IsActive = true,
    HourValue = 1100M,
    Hours =125
};
//Console.WriteLine(employee3);

Employee employee4 = new BaseCommisionEmployee()
{
    Id = 4,
    FirstName = "Paulina",
    LastName = "Lucena",
    BirthDay = new Date(2004, 12, 30),
    HiringDate = new Date(2022, 01, 11),
    IsActive = true,
    CommissionPercentaje = 0.015F,
    Sales = 100000M,
    Base = 80000
};
//Console.WriteLine(employee4);
ICollection<Employee> employees = new List<Employee>()
{
    employee1,employee2,employee3,employee4
};
decimal payroll = 0;

foreach(Employee e in employees)
{
    payroll += e.GetValueToPay();
}
Console.WriteLine(" ====================");
Console.WriteLine($"Total: {payroll:C2}");

Invoice invoice = new Invoice() { Description = "Iphone 13", Id = 1, Price = 300000M, Quantity = 6 };
Invoice invoice2 = new Invoice() { Description = "Cordero", Id = 2, Price = 100000M, Quantity = 15 };

Console.WriteLine(invoice);
Console.WriteLine(invoice2);