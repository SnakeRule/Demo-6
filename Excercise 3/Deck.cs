using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_3
{
    class Deck
    {
        public List<Card> cards;
        public List<Card> shuffledCards;

        public Deck()
        {
            cards = new List<Card>();
        }

        public void Addcard(Card card)
        {
            cards.Add(card);
        }
        
        public void ShowDeck()
        {
            foreach(Card card in cards)
            {
                Console.WriteLine(card.Suit + " " + card.Number);
            }
        }
    }
}
