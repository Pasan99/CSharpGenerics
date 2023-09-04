using CSharpGenerics.Models;
using CSharpGenerics.Utilities;

Console.WriteLine("Press enter to read the test.csv file");
Console.ReadLine();
var users = CsvFileReader.Read<User>("test.csv");

foreach (var user in users)
{
    Console.WriteLine($"Name : {user.Name}, Email : {user.Email}");
}