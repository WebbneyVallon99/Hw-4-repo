using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Card
{
    private readonly Rank rank;
    private readonly Suit suit;
    private bool faceUp;

    public Card(Rank rank, Suit suit)
    {
        this.rank = rank;
        this.suit = suit;
        this.faceUp = false; // Cards usually start face down
    }

    public Rank Rank { get { return rank; } }
    public Suit Suit { get { return suit; } }
    public bool FaceUp { get { return faceUp; } }

    public void FlipOver()
    {
        faceUp = !faceUp;
    }

    public override string ToString()
    {
        return faceUp ? $"{rank} of {suit}" : "Face Down";
    }
}