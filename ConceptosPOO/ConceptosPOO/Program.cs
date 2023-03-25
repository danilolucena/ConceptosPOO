

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
Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    Id = 2,
    FirstName = "Giuliano",
    LastName = "Lucena",
    BirthDay = new Date(1995, 12, 13),
    HiringDate = new Date(2020, 05, 11),
    IsActive = true,
    CommissionPercentaje = 3,
    Sales=200000M,
};
Console.WriteLine(employee2);