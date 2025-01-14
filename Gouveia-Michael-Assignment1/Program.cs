
Console.WriteLine("You are in a match of hand to hand combat with MILLIONS watching you, will you make the right choice and enjoy glory! Or will you suffer the shame of defeat?");
Console.WriteLine("DING DING DING DING");
Console.WriteLine("The fight begins, your oponent makes the first move and hones in on you....");

Console.WriteLine("Your oponent moves his left fist as to hit you but then quickly goes for a right-hook!" +
    "What will you do? Type either [block] or [punch] or [weave]");
string choice1 = Console.ReadLine();
if (choice1 == "block")
{
    Console.WriteLine("You successfully blocked!");
    Console.WriteLine("He quickly goes for a punch in the gut using his left, type either [tankit] or [dodge] or [grab]");
    string choice2 = Console.ReadLine();
    if (choice2 == "tankit")
    {
        Console.WriteLine("You took the hit, and with a sudden urge of adrenaline you land a one-two!");
        Console.WriteLine("Oh no! Your oponent counters your second punch and rushes for a hit back! What do you do? [parry] [block] [dodge]");
    }
}
if (choice1 == "punch")
{
    Console.WriteLine(
}
if (choice1 == "weave")
{
    Console.WriteLine(
}