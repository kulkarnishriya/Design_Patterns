using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.CompositePattern
{
    //This is a composite class containing list of cards.
    public class CardDeck : ICardDeck
    {
        private int value = 0;

        private List<Card> Cards = new List<Card>();
        public CardDeck(int val)
        {
            value = val;
        }
        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        public void Traverse()
        {
            Console.WriteLine("Total cards are:" + value);
            foreach (var card in Cards)
            {
                //Print value of each card that was added.
                card.Traverse();
            }
        }
    }
}
