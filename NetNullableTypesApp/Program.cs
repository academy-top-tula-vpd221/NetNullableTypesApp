//Nullable<Int32> n;
using System.Net.Sockets;

int? n;
n = null;

int m = 300;
n = m;

//string s = "Hello";
//Console.WriteLine(s);

User user = new User() { Name = "Bob" };

Console.Write($"User name: {user.Name}");
if (user.Company is not null)
{
    Console.Write($", company title: {user.Company.Title}");
    if (user.Company.Address is not null)
        Console.Write($", company city: {user.Company.Address.City}");
}
Console.WriteLine();

Console.Write($"User name: {user.Name}, company title: {user.Company?.Title}, company city: {user.Company?.Address?.City}");


class User
{
    public string? Name { get; set; }
    public Company? Company { get; set; }

}

class Company
{
    public string Title { set; get; } = null!;
    public Address? Address { set; get; }

}

class Address
{
    public string? City { set; get; }
}