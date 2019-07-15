using System;
using System.Collections.Generic;

class Sphinx
{
  
    public static Dictionary <int, string> myRiddles = new Dictionary <int,string>() { {1,"This walks on four legs in the morning, two legs in the afernoon, and three legs in the evening. What am I?"},{2, "If two peacocks lay two eggs in two days how many eggs does one peacock lay in four days?"}, {3, "I have a bed, but I do not sleep. I have a mouth, but I don't eat. You hear me whisper, but I never talk. You can see me run, I never walk. What am I?"} };

    public static Dictionary <int, string> myAnswers = new Dictionary <int,string>() { {1,"A person"},{2, "Peacocks don't lay eggs."}, {3, "A river"} };

    public static List<int> randomNumbers = new List<int>{};

    static void Main()
    {
        
        Console.WriteLine("MAIN MENU");
        Console.WriteLine("Do you want to play our game?");
        string answer = Console.ReadLine();
        if (answer == "yes" || answer == "Yes")
        {   
            randomGenerator();
            Console.WriteLine(myRiddles[randomNumbers[0]]);
            string answer1 = Console.ReadLine();
            if (answer1 == myAnswers[randomNumbers[0]]){
                Console.WriteLine("YOU'RE CORRECT");

                Console.WriteLine(myRiddles[randomNumbers[1]]);
                string answer2 = Console.ReadLine();
                if (answer2 == myAnswers[randomNumbers[1]]){
                    Console.WriteLine("YOU'RE CORRECT");
                    
                    Console.WriteLine(myRiddles[randomNumbers[2]]);
                    string answer3 = Console.ReadLine();
                    if (answer3 == myAnswers[randomNumbers[2]]){
                    Console.WriteLine("YOU'RE CORRECT");
                    Console.WriteLine("You have slain me. *DIES*");

                }
            }else{
                Console.WriteLine("you're wrong");
                Console.WriteLine("*EATS YOU*");
                Main();
            }

        }
        else
        {

        }
    }
    }

        static void randomGenerator(){

            Random rnd = new Random();
            for (int i = 0; i < 3; i++){
                int number = rnd.Next(1, 4);
                while (randomNumbers.Contains(number)){
                number = rnd.Next(1, 4);
                }
                randomNumbers.Add(number);
                
            }
           
        }
        
}


  
