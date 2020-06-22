using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.CompositePattern
{
    public class CardClient
    {
        public void CallComposite()
        {
            CardDeck deck = new CardDeck(52);
            deck.AddCard(new Card(1));
            deck.AddCard(new Card(2));
            deck.AddCard(new Card(5));

            deck.Traverse();
        }
    }
}
