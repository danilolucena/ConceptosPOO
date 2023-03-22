

using ConceptosPOO;

Console.WriteLine("POO Conceptos!");
Console.WriteLine("==============");

try
{
    Console.WriteLine(new Date(2023, 22, 03));
    Console.WriteLine(new Date(2023, 9, 23));
    Console.WriteLine(new Date(2023, 18, 45));
}
catch (Exception error)
{

    Console.WriteLine(error.Message); 
}
