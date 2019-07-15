using System;
using System.Collections.Generic;

class Sphinx
{
  
    static void Main()
    {
        
        

        Dictionary <int, string> myRiddles = new Dictionary <int,string>() { {1,"This walks on four legs in the morning, two legs in the afernoon, and three legs in the evening. What am I?"},{2, "riddles2"}, {3, "riddles3"} };

        Dictionary <int, string> myAnswers = new Dictionary <int,string>() { {1,"A person"},{2, "answer2"}, {3, "answer3"} };

        Dictionary <int, int> randomNumbers = new Dictionary <int,int>() {  };
        
        
        for (int i = 0; i < myRiddles.Count; i ++) {
            Random rnd = new Random();
             int randomizer  = rnd.Next(1, 3);
            if (randomNumbers.ContainsKey(i)) {
                
                randomNumbers.Add(randomizer, randomizer);
            } 
            else {
            randomNumbers.Add(i, i);
            }
            Console.WriteLine(randomNumbers);
        }

        
        Console.WriteLine("MAIN MENU");
        Console.WriteLine("Do you want to play our game?");
        string answer = Console.ReadLine();
        if (answer == "yes" || answer == "Yes")
        {
            Console.WriteLine(myRiddles[randomizer]);
            string answer1 = Console.ReadLine();
            if (answer1 == myAnswers[randomizer]){
                Console.WriteLine("YOU'RE CORRECT");
                Main();
            }else{
                Console.WriteLine("you're wrong");
                Main();
            }

        }
        else
        {

        }
    }
}
