namespace NumbersGame
{
    internal class Program
    {        

        static void Main(string[] args)
        {
            {                
                welCome();
                Random random = new Random();
                int randomNum = random.Next(0, 25);
                int guesses = 5;                
                while (guesses!=0)
                {                 
                    try
                    {
                        guesses = CheckGuess(guesses, randomNum);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Du måste gissa på ett heltal mellan 1 - 25");                       
                    }                                                 
                }                
            }
        }
        static public void welCome ()
        {
            Console.WriteLine("Välkommen till GISSA NUMRET!!!");
            Console.WriteLine("Du får 5 gissningar och ifall du misslyckas, då är det över.....");
            Thread.Sleep(3000);
            Console.WriteLine("Jag tänker på ett nummer mellan 1-25, kan du gissa vilket?");            
        }
        static public int CheckGuess (int guesses, int randomNum)
        {
                int lotteryGuess = Convert.ToInt32(Console.ReadLine());
                                         
            if (lotteryGuess == randomNum)
            {
                    Console.WriteLine($"Du gissade på {lotteryGuess}...");
                    Thread.Sleep(2000);
                    Console.WriteLine("Det var rätt!! Grattis");
                    guesses = 0;                    
            }
            else if (lotteryGuess != randomNum && lotteryGuess > 0 && lotteryGuess < 26)
            {
                
                    guesses--;
                    Console.WriteLine($"Du gissade på {lotteryGuess}... ");
                    Thread.Sleep(2000);
                    Console.WriteLine("Det var fel.... du har {0} gissningar kvar... ", guesses);
                
                        if (guesses == 0 && lotteryGuess != randomNum)
                        {
                        Console.WriteLine($"Hade du gissat på {randomNum} så hade du vunnit, bättre lycka nästa gång.... ");
                        }
            }

            return guesses;        
        }                     
    }              
}

    
