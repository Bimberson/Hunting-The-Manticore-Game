Console.WriteLine("Hunting the Manticore. Press any key to begin ");
Console.ReadKey();
Console.Clear();
Console.WriteLine("Player 1, how far away from the city do you want to station the Manticore? Enter a number between 0 and 100 ");
int manticoreLocation = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("You have selected " + manticoreLocation + " Press any key to pass to player 2 ");
Console.ReadKey();
Console.Clear();

int manticoreHealth = 10;
int cityHealth = 15;
int round = 1;
int cannonDamage(int x)
{
    if (round % 5 == 0 && round % 3 == 0)
        x = 10;
    if (round % 5 == 0 || round % 3 == 0)
        x = 3;
    else x = 1;
    return x;
}
int enemyHit(int y)
{
    if (round % 5 == 0 && round % 3 == 0)
        y = 10;
    if (round % 5 == 0 || round % 3 == 0)
        y = 3;
    else y = 1;
    return y;
}
do
{
    Console.WriteLine(" ------------------------------ ");
    Console.WriteLine("Status:  Round: " + round + " City: " + cityHealth + "/15  Manticore: " + manticoreHealth + "/10");
    Console.WriteLine("The cannon is expected to deal: " + cannonDamage(1) + " damage this round.");
    Console.WriteLine(" Enter desired cannon range: ");
    int playerShot = Convert.ToInt32(Console.ReadLine());
    if (playerShot > manticoreLocation)
        Console.WriteLine("The round OVERSHOT the target. ");
    if (playerShot < manticoreLocation)
        Console.WriteLine("The round FELL SHORT of the target. ");
    if (playerShot == manticoreLocation)
    {
        Console.WriteLine("The round was a DIRECT HIT! ");
        manticoreHealth = manticoreHealth - enemyHit(1);
    }
    round++;
    cityHealth--;
    if (cityHealth <= 0)
    {
        Console.WriteLine("You have lost! Player 1 Wins! Press any key to close ");
        Console.ReadKey();
        //Console.WriteLine("You lost! Player 1 Wins! Type Y to play again");
        
    }
    if (manticoreHealth <= 0)
    {
        //Console.WriteLine("You have defeated the Manticore. Player 2 Wins! Type Y to play again");
        Console.WriteLine(" You have defeated the Manticore. Player 2 Wins! Press any key to close ");
        Console.ReadKey();
        
    }
}
while (cityHealth >= 0 && manticoreHealth >= 0);


