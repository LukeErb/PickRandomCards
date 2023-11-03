using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of hands: ");
            string Hands = Console.ReadLine();
            Console.Write("Enter the number of cards per hand: ");
            string Cards = Console.ReadLine();
            if (int.TryParse(Hands, out int numberOfHands) && int.TryParse(Cards, out int numberOfCards) && numberOfCards <= 52 && numberOfCards > 0 && numberOfHands > 0 )
            {
                while (numberOfHands > 0)
                {
                    foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                    {
                        Console.WriteLine(card);
                    }
                    numberOfHands--;
                }
            }
            else
            {
                Console.WriteLine("You can only enter valid numbers");
            }

        }
    }
}
