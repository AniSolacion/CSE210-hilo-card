using System;
using System.Collections.Generic;


namespace Unit02.Game
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        Deck deck = new Deck();
        bool isPlaying = true;
        int points = 300;
        int old_card = 0;
        string old_suit;
        int new_card = 0;
        string new_suit;
        

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            deck.draw();
            old_card = deck.value;
            old_suit = deck.suitName;

        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Asks the user if they want to roll.
        /// </summary>
        public void GetInputs()
        {
            //Draw new Card
            deck.draw();
            new_card = deck.value;
            new_suit = deck.suitName;
            //Print Old card
            Console.WriteLine($"The starting card is a {old_card} of {old_suit}");
            //Input guess
            Console.WriteLine("Is the next card going to be higher or lower? [h/l]:  ");
            string higherOrLower = Console.ReadLine();
            Console.WriteLine($"The card was a {new_card} of {new_suit}");
            
        }

        /// <summary>
        /// Updates the player's score.
        /// </summary>
        public void DoUpdates()
        {
            
            if ((new_card > old_card && higherOrLower = "h")||(new_card < old_card && higherOrLower = "l"))
            {
                points = points + 100;
            }
            else
            {
                points = points - 75;
            }
        }

        /// <summary>
        /// Displays the dice and the score. Also asks the player if they want to roll again. 
        /// </summary>
        public void DoOutputs()
        {
            
            Console.WriteLine($"Your score is: {totalScore}\n");
            isPlaying = (score > 0);
            if (isPlaying)
            {
                Console.WriteLine($"Your score is: {totalScore}\n");
                Console.WriteLine($"Would you like to draw again? (y/n)");
                string drawAgain = Console.ReadLine();
                isPlaying = (drawAgain == "y" || drawAgain == "Y");
                old_card = new_card;
                old_suit = new_suit;  
            }
            else
            {
                Console.WriteLine($"Your final score is: {totalScore}\n");
            }
            
        }
    }
}


