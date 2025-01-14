
Console.WriteLine("You are in a match of hand to hand combat with MILLIONS watching you, will you make the right choice and enjoy glory! Or will you suffer the shame of defeat?");
Console.WriteLine("DING DING DING DING");
Console.WriteLine("The fight begins, your oponent makes the first move and hones in on you....");

Console.WriteLine("Your oponent moves his left fist as to hit you but then quickly goes for a right-hook!" +
    "What will you do? Type either [block] or [punch]");
string choice1 = Console.ReadLine();
if (choice1 == "block")
{
    Console.WriteLine("You successfully blocked!");
    Console.WriteLine("He quickly goes for a punch in the gut using his left, type either [tankit] or [grab]");
    string choice2 = Console.ReadLine();
    if (choice2 == "tankit")
    {
        Console.WriteLine("You took the hit, and with a sudden urge of adrenaline you land a one-two!");
        Console.WriteLine("Oh no! Your oponent counters your second punch and rushes for a hit back! What do you do? [parry]");
        string choice3 = Console.ReadLine();
        if (choice3 == "parry")
        {
            Console.WriteLine("You parried...but your oponent weaves and goes for another blow! Do you [dodge] or [counter] ?");
            string choice4 = Console.ReadLine();
            if (choice4 == "dodge")
            {
                Console.WriteLine("You try to dodge but your too slow and he lands his hit BAMMM!!! KNOCKOUT YOU LOSE!!!!");
            }
            if (choice4 == "counter")
            {
                Console.WriteLine("You somehow move around his fist at record breaking speed and land the finishing blow! KNOCKOUT YOU WINNN!!!!");
            }
        }
    }
    if (choice2 == "grab")
    {
        Console.WriteLine("You try grabbing his fist but he quickly lands a cold hit right into your face! You begin to passout that evwn theese wurds are jumbled upy");
        Console.WriteLine("What dou youd do? [lose] [try]");
        string choice5 = Console.ReadLine();
        if (choice5 == "lose")
        {
            Console.WriteLine("You B****! You passout! KNOCKOUT YOU LOSE!!!");
        }
        if (choice5 == "try")
        {
            Console.WriteLine("You suddenly put your feet straight on the ground and suddenly power up a KAMEHAMEHA and BLAST your foe to oblivion! KNOCKOUT??? YOU WIN!!!!");
        }
    }
}
if (choice1 == "punch")
{
    Console.WriteLine("You take a hit by landing your own punch! Now do you immediatly [punch] again or [weave] ?");
    string choice6 = Console.ReadLine();
    if (choice6 == "punch")
    {
        Console.WriteLine("You go for a punch right away but also does you oponent! BAM!! You both get knockedout! DOUBLE KNOCKOUT...IT IS A TIE????");
    }
    if (choice6 == "weave")
    {
        Console.WriteLine("You easily dodge his fist! And without a second hesitation throw and land a clean right hook! KNOCKOUT YOU WINN!!!");
    }
}