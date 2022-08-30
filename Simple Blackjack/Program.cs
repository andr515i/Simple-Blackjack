using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Blackjack
{
    class Program
    {

        static void Main(string[] args)
        {  // a simple blackjack game built on structs
            int counter = 0;
            Random random = new Random();
            int totalCards = 52; // total amount of cards in blackjack is 5            

            Cards[] cards = new Cards[totalCards];
            for (int i = 0; i < 2; i++)
            {
                for (int x = 0; x < totalCards / 2; x++) // half of the total cards, as there is no 2 colors in blackjack
                {
                    cards[counter].CardValue = (x % 13) + 1;      // modulus 13 + 1 so we can get the correct numbers from 1 to 13
                    if (i == 0)
                    {
                        cards[counter].CardColor = "Black";    // make sure the card color to card X has the correct color, either being black or red
                    }
                    else
                    {
                        cards[counter].CardColor = "Red";
                    }
                    counter++;
                    //Console.WriteLine(cards[x].CardValue);
                }
            }
            Cards[] player = new Cards[5];
            Cards[] dealer = new Cards[5];

            bool run = true;  // game loop bool

            int playerCardCounter = 0;
            //dealer[0] = cards[randomCard];
            //Console.Write("\ndealer's hand has: ");
            //for (int i = 0; i < dealer.Length; i++)        
            //{
            //    if (dealer[i].CardValue != 0)
            //    {
            //        Console.Write(CardsToString(dealer[i].CardValue));
            //    }
            //    else
            //    {
            //        Console.Write("*");
            //    }
            //}

            while (run) // game loop to make sure we can keep playing until we dont want to play anymore :)
            {
                Console.Write(" your hand: ");
                for (int i = 0; i < player.Length; i++)
                {
                    Console.Write(CardsToString(player[i].CardValue) + " ");
                }
                int randomCard = random.Next(1, 52);

                Console.WriteLine(" do you want to hit or stay? ");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case string val when (val == "hit" || val == "h"):
                        player[playerCardCounter] = cards[randomCard];
                        break;
                    case string val when (val == "s" || val == "stay"):
                        Console.Write("\ndealer's hand has: ");
                        for (int i = 0; i < dealer.Length; i++)
                        {
                            randomCard = random.Next(1, 52);

                            dealer[i] = cards[randomCard];
                            if (dealer[i].CardValue != 0)
                            {
                                Console.Write(CardsToString(dealer[i].CardValue) + " ");
                            }
                            else
                            {
                                Console.Write("* ");
                            }
                        }
                        break;

                }

                playerCardCounter++;
            }
        }
        public static string CardsToString(int value)
        {

            switch (value)
            {
                case int val when val == 1 || val == 11:
                    return "Ace";
                case int val when val == 12:
                    return "Jacks";
                case int val when val == 13:
                    return "Queens";
                case int val when val == 14:
                    return "Kings";
                default:
                    return value.ToString();
            }
        }
    }
}

