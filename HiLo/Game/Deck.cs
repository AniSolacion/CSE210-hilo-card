using System;
using System.Collections.Generic;

namespace Unit02.Game
{
    /// <summary>
    /// A standard 52 card deck.
    /// 
    /// The responsibility of Deck is to keep track of its currently drawn value and its suit.
    /// </summary> 

    public class Deck
    {
        public List<int> discard = new List<int>();
        public int card = 0;
        public string suitName;
        public int suit = 0;
        public int value = 0;
        
        /// <summary>
        /// Constructs a new instance of Deck.
        /// </summary>
        public Deck()
        {
        }

        /// <summary>
        /// Generates a new random value and suit for the card within the deck limit.
        /// </summary>
        public void draw()
        {
            // if discard pile is full, leave the last discarded card and reshuffe the rest.
            if (discard.Count == 52)
            {
                int discardValue = discard[51];
                discard.Clear();
                discard.Add(discardValue);
            }
            
            Random random = new Random();

            bool legalValue = true;
            while (legalValue)
            {
                value = random.Next(1, 14);
                suit = random.Next(1, 5);
                card = value * suit;

                if (!discard.Contains(card))
                {
                    legalValue = false;
                }
            }

            discard.Add(value);

            if (suit == 1) 
            {
                suitName = "Diamond";
            }
            else if (suit == 2)
            {
                suitName = "Heart";
            }
            else if (suit == 3)
            {
                suitName = "Spade";
            }
            else 
            {
                suitName = "Club";
            }
        }
    }
}