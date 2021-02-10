public class RockPaperScissors{
    public static void Main(String[] args){    
      do
        {
            Console.WriteLine("Do you choose rock*(1),paper(2) scissors(3)or Exit?(4)");
            int userChoice = Console.ReadLine();
            Random pc = new random();
            int pcChoice = pc.Next(4);

            if (pcChoice == 1)//Rock
                {
                    Console.WriteLine("The computer chose rock");
                    if (userChoice == 1)
                    {                        
                        Console.WriteLine("It is a tie ");                     
                    }
                    else if (userChoice == 2)
                    {
                        Console.WriteLine("Player wins!");
                    }
                    else if (userChoice == 3)
                    {
                        Console.WriteLine("Computer Wins");
                    }
                }
                if (pcChoice == 2)//Paper
                {
                    Console.WriteLine("The computer chose paper");
                    if (userChoice == 1)
                    {
                        Console.WriteLine("Computer Wins");                     
                    }
                    else if (userChoice == 2)
                    {
                        
                        Console.WriteLine("It is a tie "); 

                    }
                    else if (userChoice == 3)
                    {
                        Console.WriteLine("Player wins!");
                    }
                }
                if (pcChoice == 3)//scissors
                {
                     Console.WriteLine("The computer chose scissors");
                    if (userChoice == 1)
                    {                       
                        Console.WriteLine("Player wins!");                  
                    }
                    else if (userChoice == 2)
                    {
                        Console.WriteLine("Computer Wins");
                    }
                    else if (userChoice == 3)
                    {
                        Console.WriteLine("It is a tie ");
                    }
                }

        }while(Console.ReadLine() == "4");
    }
}