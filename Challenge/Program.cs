using System.ComponentModel.Design;

Console.WriteLine("What is your name?");
string name = Console.ReadLine();

Console.WriteLine($"How much money do you have {name}?");
string coin = Console.ReadLine();
int gold = int.Parse( coin );

Console.WriteLine("Would you like to buy a $15 sword?");
string choice = Console.ReadLine();
int difference = gold - 15;

if (choice == "yes")
{
    if (difference > 0)
    {
        Console.WriteLine($"You have {difference} left");
    }
    else if (difference < 0)
    {
        Console.WriteLine("You do not have enough!");
    }
}
else if (choice == "no")
{
    Console.WriteLine("Bye");
}