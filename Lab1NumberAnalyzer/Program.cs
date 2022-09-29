Console.WriteLine("Hello! First, please type your name.");
string userName = Console.ReadLine();

Console.WriteLine($"Thanks {userName}! Now, please type a number between 1 and 100 (inclusive).");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber >= 1 && userNumber <= 100)
{

    if (userNumber % 2 != 0)
    {
        if (userNumber < 60)
        {
            Console.WriteLine($"You chose {userNumber}. {userName}, fun fact! That number is odd and less than 60.");
        }
        else
        {
            Console.WriteLine($"You chose {userNumber}. {userName}, fun fact! That number is odd and greater than 60.");
        }
    }
    else if (userNumber % 2 == 0)
    {
        if (userNumber >= 2 && userNumber <= 24)
        {
            Console.WriteLine($"You chose {userNumber}. {userName}, fun fact! That number is even and less than 25.");
        }
        else if (userNumber >= 26 && userNumber <= 60)
        {
            Console.WriteLine($"You chose {userNumber}. {userName}, fun fact! That number is even and between 26 and 60 inclusive.");
        }
        else if (userNumber > 60)
        {
            Console.WriteLine($"You chose {userNumber}. {userName}, fun fact! That number is even and greater than 60.");
        }
    }

}

else
{
    Console.WriteLine($"C'mon {userName}, I told you to pick a number between 1 and 100 (inclusive)! I'm really disappointed in you.");
}