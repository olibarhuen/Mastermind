class HelloWorld
{
    static void Main()
    {
        int ans;
        string passcode = "";
        int triesCount = 0;
        Random random = new Random();

        //For the following 'for' loop, initialize a randomizer with a lenght of 4, and between digits 1-6.
        for (int i = 0; i < 4; i++)
        {
            passcode += random.Next(1, 6);
        }

        while (triesCount != 10)
        {
            ans = 0;
            string guess = "";
            Console.WriteLine("\n Guess the password! You have " + (10 - triesCount) + " tries left");
            //The following will read user's line:
            guess = Console.ReadLine();

            //If the user enters a string of numbers with more than 4 characters, console will let the user that it was an invalid input
            if (guess.Length != 4)
            {
                Console.WriteLine("Invalid String combination. Please try again \n ");
            }

            //The following will check for all four characters if there are some in the actual code delivering a - or + depending on the correct position. 
            for (int i = 0; i < 4; i++)
            {
                if (guess[i] == passcode[i])
                {
                    ans = ans + 1;
                    if(ans != 4)
                    {
                        Console.Write("+");
                        
                    }
                    else if (ans == 4)
                    {
                        break;
                    }
                }
                //in the following statement, it checks if the character is part of the code,
                //Note: if a character is part of the code for more than one time, the - will
                //keep appearing since the character is still a valid character; however, the + will let the user
                //know that it is in the right place. Otherwise, the 'X' will appear.
                else
                {
                    if (passcode.Contains(Char.ToString(guess[i])))
                        Console.Write("-");
                    
                    else
                        Console.Write("X");
                }
            }
            if (ans == 4)
            {
                Console.WriteLine("\n Eureka! you win!");
                break;
            }
            triesCount++;
        }
        if (triesCount == 10)
        {
            Console.WriteLine("\n You lost the bet ");
            Console.WriteLine("The correct password was " + passcode);
        }
    }
}
