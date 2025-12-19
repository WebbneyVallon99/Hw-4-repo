using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Deck
{
    private List<Card> cards = new List<Card>();
    private Random rng = new Random();

    public Deck()
    {
        foreach (Suit s in Enum.GetValues(typeof(Suit)))
        {
            foreach (Rank r in Enum.GetValues(typeof(Rank)))
            {
                cards.Add(new Card(r, s));
            }
        }
    }

    public List<Card> Cards => cards;

    public Card? TakeTopCard()
    {
        if (cards.Count > 0)
        {
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }
        return null;
    }

    public void Shuffle()
    {
        // Fisher-Yates shuffle algorithm
        for (int i = cards.Count - 1; i > 0; i--)
        {
            int k = rng.Next(i + 1);
            Card value = cards[k];
            cards[k] = cards[i];
            cards[i] = value;
        }
    }

    public void Cut(int index)
    {
        if (index > 0 && index < cards.Count)
        {
            var bottomHalf = cards.GetRange(index, cards.Count - index);
            var topHalf = cards.GetRange(0, index);
            cards = bottomHalf.Concat(topHalf).ToList();
        }
    }
}