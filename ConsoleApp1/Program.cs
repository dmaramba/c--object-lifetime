using ConsoleApp1;

//GC destructor function, uncomment the line below to run the code
//new GCDestructor();


//Dispose function

using (var logger= new FileLogger("log.txt"))
{
    logger.WriteLogText("User logged in");
    logger.WriteLogText("User search information about cybersecyrity");
}


//some class file as well logging

using (var logger = new FileLogger("log.txt"))
{
    logger.WriteLogText("User completed quiz");
    logger.WriteLogText("User added task");
}


//Lazy Loading Numbers
NumberList numberList = new NumberList();

//Get me the list of numbers
var numbers = numberList.GetList();
Console.WriteLine($" These are the numbers ");
foreach (var number in numbers)
{
    Console.Write($"{number} ");
}
Console.WriteLine("");

//Get all even numbers
var numbers2 = numberList.GetList();
Console.WriteLine($" These are the even numbers ");
foreach (var number in numbers)
{
    if (number % 2 == 0)
        Console.Write($"{number} ");
}
Console.WriteLine("");
//Get all odd numbers
var numbers3 = numberList.GetList();
Console.WriteLine($" These are the even numbers ");
foreach (var number in numbers)
{
    if (number % 2 != 0)
        Console.Write($"{number} ");
}
Console.WriteLine("");
Console.ReadKey();


