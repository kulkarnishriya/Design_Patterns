using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.CompositePattern
{
    //This interface is used to describe both a "single" card as well as "deck"(collection) of cards.
    public interface ICardDeck
    {
        void AddCard(Card card);

        void Traverse();
    }
}
