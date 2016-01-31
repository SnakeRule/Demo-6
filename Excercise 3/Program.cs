using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_3
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Deck deck = new Deck();

            for (int i = 1; i != 14; i++)
            {
                Card card = new Card { Suit = "Hearts", Number = i };
                deck.Addcard(card);
            }
            for (int i = 1; i != 14; i++)
            {
                Card card = new Card { Suit = "Spades", Number = i };
                deck.Addcard(card);
            }
            for (int i = 1; i != 14; i++)
            {
                Card card = new Card { Suit = "Diamonds", Number = i };
                deck.Addcard(card);
            }
            for (int i = 1; i != 14; i++)
            {
                Card card = new Card { Suit = "Clubs", Number = i };
                deck.Addcard(card);
            }

            deck.ShowDeck();

            deck.ShuffleDeck();

            deck.ShowDeck();
        }
    }
}
