using MyFirstClassLib;

Console.WriteLine("Enter your first name:");
string? firstName = Console.ReadLine();

Console.WriteLine("Enter your last name:");
string? lastName = Console.ReadLine();

string fullName = PersonProcessor.JoinNames(firstName ?? "", lastName ?? "");

Console.WriteLine($"Your full name is: {fullName}");
Console.ReadKey();