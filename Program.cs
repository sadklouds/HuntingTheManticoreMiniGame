// set up game 
int cityHealth = 15;
int manticoreHealth = 10;
int round = 1;
int distance = DistanceRange("Player 1 how far from the city do you wish to station the manticore(0-100)? ",0,100);
// gets rid of player one anwser
Console.Clear();
Console.WriteLine("Player 2 it is your turn.");

//game will run untill manticore is dead or the city is destroyed
while (true)
{
    // displays results of the game
    if (manticoreHealth <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The Mantictore Has been destroyed city of consolas has been saved");
        break;
    }
    else if (cityHealth <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The manticore has destroyed the city of consolas we are doomed!");
        break;
    }

    //display rounds status of manticore and city and asking for cannon range
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("---------------------------------------------------------------");
    Console.WriteLine($"STATUS: Round:{round} City:{cityHealth}/15 Manticore:{manticoreHealth}/10");
    int damage = CannonDamage(round);
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"The cannon is expected to deal {damage} this round.");
    Console.ForegroundColor = ConsoleColor.White;
    int guess = DistanceRange("Enter Desired cannon range: ", 0, 100);
    // if enemy target distance match damage manticore
    bool hit = TargetReached(guess);

    if (hit == true) manticoreHealth -= damage;
    round++; // advance the round 
    cityHealth -= 1; // decrease city health when manticore is still alive
}


//checks if cannon range falls short/over andf hits target
bool TargetReached(int guess)
{
    bool hit = false;
    if (guess == distance)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("That round was  DIRECT HIT!");
        Console.ForegroundColor = ConsoleColor.White;
        return hit = true;
    }
    if (guess > distance)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("That round OVERSHOT the target.");
        
        return hit = false;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("That round FELL SHORT of the target");
        Console.ForegroundColor = ConsoleColor.White;
        return hit = false;
    }
}

// computation for famage of cannon
// mutiple of 5 and 3 combined blast of fire and electric 
// A  a multiple of 5 electric blast
// A multiple of 3 is a fire blast 
int CannonDamage(int round)
{
    int damage = 0;
    if (round % 5 == 0 && round % 3 == 0) return damage = 10; // combined eletric and fire
    if (round % 5 == 0 ) return damage = 3;// electric 
    if (round % 3 == 0 ) return damage = 3; // fire
    else return damage = 1;
}

//asks for range input 
int AskForNumber(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
// makes sure player range is between 0 and 100
int DistanceRange(string question, int min, int max)
{
    while(true)
    {
        int number = AskForNumber(question);
        if (number > min && number < max) return number;
    }
}