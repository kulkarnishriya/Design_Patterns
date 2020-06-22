using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.CompositePattern
{
    public class Card : ICardDeck
    {
        private int value = 0;

        public Card(int val)
        {
            value = val;
        }
        public void AddCard(Card card)
        {
            throw new InvalidOperationException("Cannot add card to card.");
        }

        public void Traverse()
        {
            Console.WriteLine("Card value:" + value);
        }
    }
}
