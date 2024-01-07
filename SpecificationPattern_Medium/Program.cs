using SpecificationPattern_Medium;
using SpecificationPattern_Medium.Models;

Person p = new() { Age = 19 }; 
ConcertTicket ct = new() { TicketType= TicketType.Normal}; 

var AgeSpecification = new MinimumAgeSpecification();
var PriortiySpecification = new PriorityTicketSpecification();

if (AgeSpecification.IsSatisfiedBy(p))
{
    Console.WriteLine("You can pass!");
}
else
{
    Console.WriteLine("People under 18 cannot enter!");
}

if (PriortiySpecification.IsSatisfiedBy(ct))
{
    Console.WriteLine("You can pass VIP section!");
}
else
{
    Console.WriteLine("You cant pass here!");
}

