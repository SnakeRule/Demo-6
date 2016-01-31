using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_3
{

    class Deck
    {
        Random rand = new Random();


        public List<Card> cards;
        public List<Card> tempcard;

        public Deck()
        {
            cards = new List<Card>();
            tempcard = new List<Card>();
        }

        public void Addcard(Card card)
        {
            cards.Add(card);
        }
        
        public void ShowDeck()
        {
            foreach(Card card in cards)
            {
                if(card.Number > 10 || card.Number == 1)
                {
                    switch (card.Number)
                    {
                        case 1: Console.WriteLine(card.Suit + " Ace"); break;

                        case 11: Console.WriteLine(card.Suit + " Jack"); break;

                        case 12: Console.WriteLine(card.Suit + " Queen"); break;

                        case 13: Console.WriteLine(card.Suit + " King"); break;
                    }
                }
                else Console.WriteLine(card.Suit + " " + card.Number);
            }
        }

        public void ShuffleDeck()
        {
            int first = 0, second = 0;

            for (int i = 0; i != 100; i++)
            {
                first = rand.Next(52);
                second = rand.Next(52);

                tempcard.Add(cards[first]);
                cards[first] = cards[second];
                cards[second] = tempcard[0];
                tempcard.Clear();
            }
        }
    }
}
