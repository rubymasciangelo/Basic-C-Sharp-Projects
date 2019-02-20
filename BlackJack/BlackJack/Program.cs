using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Cards = new List<Card>();

            //Card cardOne = new Card();
            ////cardOne.Face = "Queen";
            ////cardOne.Suit = "Spades";

            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
                Console.ReadLine();
        }
    }
}
